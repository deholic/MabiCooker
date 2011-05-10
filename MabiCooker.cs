using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Xml;
using System.Windows.Forms;
using CookImplement;

namespace MabiCooker2
{
    public partial class MabiCooker : Form
    {
        private const int RankSize = 11;
        private const int BufferSize = 128;

        /// <summary>
        ///  Name : List<Cook> PrepareData
        ///  Desc : 데이터 파일에서 읽어 들여서 미리 준비
        ///  PVer : private Cook[][] PreparedDatas = new Cook[RankSize][]; 
        ///  SVer : v2.0, 사용 가능
        ///  
        ///  Name : List<int> SelectedRank
        ///  Desc : 선택한 랭크의 데이터 인덱스만 따로 읽어 들이기
        ///  SVer : v2.1, 사용 가능
        ///  
        ///  Name : List<int> SearchResult 
        ///  Desc : 키워드에 맞는 옵션에 일치하는 것만 읽어 들이기 
        ///  PVer : private Cook[] SearchList; 
        ///  SVer : v2.0, 사용 가능
        ///  
        ///  Name : List<int> FavList
        ///  Desc : 키워드에 맞는 옵션에 일치하는 것만 읽어 들이기 
        ///  PVer : public static Cook[] FavList = new Cook[128];
        ///  SVer : v2.0, 사용 가능
        /// </summary>

        private DataSet DataPool = new DataSet();
        
        private List<Cook> CookData = new List<Cook>();
        private List<Stuff> StuffData = new List<Stuff>();
        private List<int> SelectedRank = new List<int>();
        private List<int> SearchResult = new List<int>();
        public List<int> FavList = new List<int>();
        public static bool isLoaded = false;
        public static int FavListLength;        
        public static CookDetailView DetailView;
        public static CookRatioView RatioView;

        
        public MabiCooker()
        {
            InitializeComponent();

            if (Properties.Settings.Default.LastSelectPoint.X != 0 && Properties.Settings.Default.LastSelectPoint.Y != 0)
            {
                this.StartPosition = FormStartPosition.Manual;
                this.Location = new System.Drawing.Point(Properties.Settings.Default.LastSelectPoint.X, Properties.Settings.Default.LastSelectPoint.Y);
            }

            isLoaded = InitBase();
            cbRankSelector.SelectedIndex = 0;
        }
        public void UpdateData(List<int> Data, ListBox Target)
        {
            Target.Items.Clear();
            for (int i = 0; i < Data.Count; i++)
            {
                Target.Items.Add(CookData[Data[i]].getName());
            }
        }
        public void AddFavList(int index)
        {
            /* -- Version 2.0
             * -- 배열 형태를 사용하므로 쬐끔 복잡 -_- 
             * if (MabiCooker.FavListLength >= MabiCooker.FavList[FavListLength])
             *      MessageBox.Show("즐겨찾기 갯수 허용량을 초과하였습니다.\n다른 것을 지우고 다시 시도해 보세요.", "경고");
             * else
             *      MabiCooker.FavList[MabiCooker.FavListLength++] = Data; */
            
            /* Version 2.1 */
            // 리스트를 사용해서 쉽고 편하게~
            if (FavList.Contains(index)) return;
            else
            {
                FavList.Add(index);
                lNoneFav_1.Visible = false; lNoneFav_2.Visible = false;
            }
        }
        public void DeleteFavList(int index)
        {
            /* Version 2.1 에서 삭제
            for (int i = 0; i < MabiCooker.FavListLength; i++)
            {
                if (MabiCooker.FavList[i].Equals(Data))
                {
                    MabiCooker.FavList.RemoveAt(i);
                    for (int j = i + 1; j < MabiCooker.FavListLength; j++)
                        MabiCooker.FavList[j - 1] = MabiCooker.FavList[j];
                    MabiCooker.FavListLength--;
                }
            }
             */
            if (FavList.Contains(index))
            {
                FavList.Remove(index);
                if (FavList.Count == 0)
                {
                    lNoneFav_1.Visible = true; lNoneFav_2.Visible = true;
                }
            }
            else return;
        }
        /* CheckFavList() : Version 2.1 에서 삭제
        public bool CheckFavList(int index)
        {
            //for (int i = 0; i < MabiCooker.FavListLength; i++)
            //    if (MabiCooker.FavList[i].Equals(Data)) return true;
            if (FavList.Contains(index)) return true;
            return false;
        }
         */
        private CookData MakeExchange()
        {
            if (tcMainCtrl.SelectedIndex == 0)
                return new CookData(CookData, StuffData, CookData[SelectedRank[lbRankResult.SelectedIndex]]);
            else if (tcMainCtrl.SelectedIndex == 1)
                return new CookData(CookData, StuffData, CookData[SearchResult[lbSearchResult.SelectedIndex]]);
            else if (tcMainCtrl.SelectedIndex == 2)
                return new CookData(CookData, StuffData, CookData[FavList[lbFavResult.SelectedIndex]]);
            else
                return null;
        }
        private void SearchStart()
        {
            // Queue SearchBuffer = new Queue();
            lbSearchResult.Items.Clear();
            if (tbSearchTerm.Text != "")
            {
                if (rbForName.Checked == true)
                {
                    /*
                    for (int i = 0; i < RankSize; i++)
                        for (int j = 0; j < PreparedDatas[i].Length; j++)
                            if (PreparedDatas[i][j].getName().Contains(tbSearchTerm.Text))
                                SearchBuffer.waitNodeAdd(PreparedDatas[i][j]);
                     */
                    SearchResult.Clear();
                    int i = -1;
                    while ((i = CookData.FindIndex(i+1, CheckCookName)) != -1) SearchResult.Add(i);
                }
                else if (rbForStuff.Checked == true)
                {
                    /*
                    String[] selected;
                    for (int i = 0; i < RankSize; i++)
                        for (int j = 0; j < PreparedDatas[i].Length; j++)
                            for (int k = 0; k < (selected = PreparedDatas[i][j].getStuff()).Length; k++)
                                if (selected[k].Contains(tbSearchTerm.Text))
                                {
                                    SearchBuffer.waitNodeAdd(PreparedDatas[i][j]);
                                    break;
                                }
                     */
                    SearchResult.Clear();
                    int i = -1;
                    while ((i = CookData.FindIndex(i+1, CheckCookStuff)) != -1) SearchResult.Add(i);
                }
                /*
                SearchList = new Cook[SearchBuffer.getQueueLength()];
                for (int i = 0; i < SearchList.Length; i++)
                {
                    SearchList[i] = SearchBuffer.serviceNode();
                    //                lbSearchResult.Items.Add(SearchList[i].getName());
                }
                 */
                else if (rbForEffect.Checked == true)
                {
                    SearchResult.Clear();
                    int i = -1;
                    while ((i = CookData.FindIndex(i + 1, CheckCookEffect)) != -1) SearchResult.Add(i);
                }
                if (SearchResult.Count > 0) lbSearchResult.BringToFront();
                else if (SearchResult.Count == 0) lbSearchResult.SendToBack();
                else lbSearchResult.SendToBack();

                UpdateData(SearchResult, lbSearchResult);
            }
        }
        private void ViewDetail()
        {
            if (DetailView != null)
            {
                if (DetailView.Visible == false)
                {
                    DetailView.Visible = true;
                    DetailView.UpdateData(MakeExchange());
                }
                else DetailView.Visible = false;
            }
            else
            {
                DetailView = new CookDetailView(this, MakeExchange(), lbFavResult);
                DetailView.Show();
            }
        }
        private bool InitBase()
        {
            /* Text Data Mode */
            String lineBuffer; StreamReader CookReader;
            if (File.Exists("cook.dat") && File.Exists("favcook.dat") && File.Exists("stuff.dat"))
            {
                #region old code : ~v2.0
                /* ~20100103 // Version 2.0 * //
                CookData = new StreamReader("cook.dat");
                for (int i = 0; i < RankSize; i++) RankTable[i] = new Queue();
                while ((lineBuffer = CookData.ReadLine()) != null)
                {
                    dataBuffer = new Cook(lineBuffer);
                    RankTable[Cook.checkRank(dataBuffer.getRank())].waitNodeAdd(dataBuffer);
                }
                for (int i = 0; i < RankSize; i++)
                {
                    PreparedDatas[i] = new Cook[RankTable[i].getQueueLength()]; int j = 0;
                    while ((dataBuffer = RankTable[i].serviceNode()) != null) PreparedDatas[i][j++] = dataBuffer;
                }
                cbRankSelector.SelectedIndex = 0;
                CookData.Close();

                CookData = new StreamReader("favcook.dat");
                for (int i = 0; (lineBuffer = CookData.ReadLine()) != null; i++)
                {
                    dataBuffer = new Cook(lineBuffer);
                    FavList[i] = dataBuffer;
                    FavListLength++;
                }
                CookData.Close();
                // ~20100103 // Version 2.0 // END */
                #endregion
                #region old code : ~v2.3
                //* 20100103~ // Version 2.1 */
                // SIMPLE IS BEST!!! //
                CookReader = new StreamReader("cook.dat");
                while ((lineBuffer = CookReader.ReadLine()) != null) CookData.Add(new Cook(lineBuffer));
                CookReader.Close();
                CookReader = new StreamReader("favcook.dat");
                while ((lineBuffer = CookReader.ReadLine()) != null)
                {
                    Cook DataBuffer = new Cook(lineBuffer); int i = 0;
                    if ((i = CookData.IndexOf(DataBuffer)) != -1) FavList.Add(i);
                }
                CookReader.Close();
                CookReader = new StreamReader("stuff.dat");
                while ((lineBuffer = CookReader.ReadLine()) != null) StuffData.Add(new Stuff(lineBuffer));
                CookReader.Close();
                // 20100103~ // Version 2.1 // END */
                #endregion
                return true;
            }
            /* XML Data Mode */
            else if (File.Exists("CookData.xml"))
            {
                DataPool.ReadXml("CookData.xml");
                return false;
            }
            else
            {
                MessageBox.Show("데이터 파일이 존재하지 않습니다.\n확인 해 주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }
        private bool CheckCookRank(Cook c)
        {
            if (c.Rank.ToString() == Cook.checkRank(cbRankSelector.SelectedIndex).ToString())
                return true;
            else
                return false;
        }
        private bool CheckCookName(Cook c)
        {
            if (c.Name.Contains(tbSearchTerm.Text)) return true;
            else return false;
        }
        private bool CheckCookStuff(Cook c)
        {
            foreach(string stuffs in c.Stuff) if (stuffs.Contains(tbSearchTerm.Text)) return true;
            return false;
        }
        private bool CheckCookEffect(Cook c)
        {
            if (c.getEffect().Contains(tbSearchTerm.Text)) return true;
            else return false;
        }
        /* CheckSearchType() : Version 2.1 에서 삭제
        private void CheckSearchType(object sender, EventArgs e)
        {
            if (rbForEffect.Checked == true)
            {
                tbSearchTerm.Visible = false;
                bSearchStart.Visible = false;
            }
            else
            {
                tbSearchTerm.Visible = true;
                bSearchStart.Visible = true;
            }
        }
        */

        private void cbRankSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbRankResult.Items.Clear(); SelectedRank.Clear();
            bPrintRatio.Enabled = false;
            bDetailView.Enabled = false;
            int i = -1;
            while ((i = CookData.FindIndex(i+1, CheckCookRank)) != -1) SelectedRank.Add(i);
            UpdateData(SelectedRank, lbRankResult);
        }
        private void bSearchStart_Click(object sender, EventArgs e)
        {
            SearchStart();
        }
        private void bDetailView_Click(object sender, EventArgs e)
        {
            ViewDetail();
        }
        private void lbRankResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbRankResult.SelectedIndex >= 0 && lbRankResult.SelectedIndex < SelectedRank.Count)
            {
                bDetailView.Enabled = true;
                bPrintRatio.Enabled = true;
                CookRatioView.SelectedCook = CookData[SelectedRank[lbRankResult.SelectedIndex]];
                CookRatioView.DataIndex = SelectedRank[lbRankResult.SelectedIndex];
                if (DetailView != null && DetailView.Visible == true) {
                    DetailView.ForTrace.Clear();
                    DetailView.UpdateData(MakeExchange());
                }
                if (RatioView != null && RatioView.Visible == true)
                {
                    RatioView.UpdateData();
                }
            }
        }
        private void lbRankResult_VisibleChanged(object sender, EventArgs e)
        {
            bDetailView.Enabled = false;
            bPrintRatio.Enabled = false;
        }
        private void lbSearchResult_VisibleChanged(object sender, EventArgs e)
        {
            bDetailView.Enabled = false;
            bPrintRatio.Enabled = false;
        }
        private void lbSearchResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbSearchResult.SelectedIndex >= 0 && lbSearchResult.SelectedIndex < SearchResult.Count)
            {
                bDetailView.Enabled = true;
                bPrintRatio.Enabled = true;
                CookRatioView.SelectedCook = CookData[SearchResult[lbSearchResult.SelectedIndex]];
                CookRatioView.DataIndex = SearchResult[lbSearchResult.SelectedIndex];
                if (DetailView != null && DetailView.Visible == true)
                {
                    DetailView.ForTrace.Clear();
                    DetailView.UpdateData(MakeExchange());
                    DetailView.Activate();
                }
                if (RatioView != null && RatioView.Visible == true)
                {
                    RatioView.UpdateData();
                    RatioView.Activate();
                }
            }
        }
        private void lbFavResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbFavResult.SelectedIndex >= 0)
            {
                bDetailView.Enabled = true;
                bPrintRatio.Enabled = true;
                CookRatioView.SelectedCook = CookData[FavList[lbFavResult.SelectedIndex]];
                CookRatioView.DataIndex = FavList[lbFavResult.SelectedIndex];
                if (RatioView != null && RatioView.Visible == true)
                {
                    RatioView.UpdateData();
                    
                    RatioView.Activate();
                }
                if (DetailView != null && DetailView.Visible == true)
                {
                    DetailView.ForTrace.Clear();
                    DetailView.UpdateData(MakeExchange());
                    DetailView.Activate();
                }
            }
        }
        private void tcMainCtrl_SelectedIndexChanged(object sender, EventArgs e)
        {
            bDetailView.Enabled = false;
            bPrintRatio.Enabled = false;
            if (tcMainCtrl.SelectedIndex == 0)
            {
                cbRankSelector.ResetText();
                lbRankResult.SelectedIndex = -1;
            }
            else if (tcMainCtrl.SelectedIndex == 1)
            {
                if (SearchResult == null) lbSearchResult.SendToBack();
                else if (SearchResult.Count == 0) lbSearchResult.SendToBack();
                lbSearchResult.SelectedIndex = -1;
            }
            else if (tcMainCtrl.SelectedIndex == 2)
            {
                if (FavList.Count <= 0) lbFavResult.SendToBack();
                else if (FavList.Count > 0) lbFavResult.BringToFront();
                UpdateData(FavList, lbFavResult);
            }
//          lbRankResult.Items.Clear();
        }
        private void bPrintRatio_Click(object sender, EventArgs e)
        {
            if(tcMainCtrl.SelectedIndex != -1)
            {
                if (RatioView == null)
                {
                    RatioView = new CookRatioView(this, lbFavResult);
                    if (tcMainCtrl.SelectedIndex == 0)
                    {
                        CookRatioView.SelectedCook = CookData[SelectedRank[lbRankResult.SelectedIndex]];
                        CookRatioView.DataIndex = SelectedRank[lbRankResult.SelectedIndex];
                    }
                    else if (tcMainCtrl.SelectedIndex == 1)
                    {
                        CookRatioView.SelectedCook = CookData[SearchResult[lbSearchResult.SelectedIndex]];
                        CookRatioView.DataIndex = SearchResult[lbSearchResult.SelectedIndex];
                    }
                    else if (tcMainCtrl.SelectedIndex == 2)
                    {
                        CookRatioView.SelectedCook = CookData[FavList[lbFavResult.SelectedIndex]];
                        CookRatioView.DataIndex = FavList[lbFavResult.SelectedIndex];
                    }
                    RatioView.UpdateData();
                    RatioView.Activate();
                }
                else
                {
                    if (RatioView.Visible == true) RatioView.Visible = false;
                    else
                    {
                        if (tcMainCtrl.SelectedIndex == 0)
                        {
                            CookRatioView.SelectedCook = CookData[SelectedRank[lbRankResult.SelectedIndex]];
                            CookRatioView.DataIndex = SelectedRank[lbRankResult.SelectedIndex];
                        }
                        else if (tcMainCtrl.SelectedIndex == 1)
                        {
                            CookRatioView.SelectedCook = CookData[SearchResult[lbSearchResult.SelectedIndex]];
                            CookRatioView.DataIndex = SearchResult[lbSearchResult.SelectedIndex];
                        }
                        else if (tcMainCtrl.SelectedIndex == 2)
                        {
                            CookRatioView.SelectedCook = CookData[FavList[lbFavResult.SelectedIndex]];
                            CookRatioView.DataIndex = FavList[lbFavResult.SelectedIndex];
                        }
                        RatioView.UpdateData();
                        RatioView.Activate();
                    }
                }
            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            /*
			if (File.Exists("supervisor.tag"))
			{
                for (int i = 0; i < CookData.Count; i++)
                {
                    CookImplement.CookData buffer = new CookData(CookData, StuffData, i);

                    int[] sRatio = buffer.cook.getRatio();
                    int[] cEffect = buffer.cook.getEffectArray();
                    bool cSEffectbool = false;
                    if(buffer.cook.SEffect != "") cSEffectbool = true;

                    string query = String.Format("INSERT INTO `mabicooker`.`mc_cooks` "
                        + "(`name`, `rank`, `ratio_1`, `ratio_2`, `ratio_3`, `effect_0`, `effect_1`, `effect_2`, `effect_3`, `effect_4`, `effect_5`, `effect_6`, `effect_7`, `effect_8`, `effect_9`, `effect_10`, `isSpecial`, `effect_special`, `stuff_1`, `stuff_2`, `stuff_3`) "
                        + "VALUES ('{0}', '{1}', {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}, {12}, {13}, {14}, {15}, {16}, '{17}', {18}, {19}, {20})",
                        buffer.cook.Name, buffer.cook.Rank, 
                        sRatio[0], sRatio[1], sRatio[2], 
                        cEffect[0], cEffect[1], cEffect[2], cEffect[3], cEffect[4], cEffect[5], cEffect[6], cEffect[7], cEffect[8], cEffect[9], cEffect[10],
                        cSEffectbool, buffer.cook.SEffect, buffer.stuffs[0]);
                }
			}
			
            if (File.Exists("supervisor.tag"))
            {
                // File.Copy("cook.dat", "cook_prev_ver.dat");
                // StreamWriter data = new StreamWriter("cook.dat");
                StreamWriter data = new StreamWriter("stuff_anlysis.dat");
                List<String> stuffs = new List<String>();
                Action<String> writefile = data.WriteLine;
                for (int i = 0; i < CookData.Count; i++)
                {
                    string[] buffer = CookData[i].Stuff;
                    for (int k = 0; k < buffer.Length; k++)
                        if (!stuffs.Contains(buffer[k])) stuffs.Add(buffer[k]);
                }
                stuffs.Sort();
                stuffs.ForEach(writefile);
                // MessageBox.Show("데이터 정렬이 완료 되었습니다.", "관리자 알림");
                MessageBox.Show("재료 데이터 출력이 완료 되었습니다.", "관리자 알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                data.Close();
            }
            else if (File.Exists("listclear.tag") && !File.Exists("CookData.xml"))
            {
                DataTable tblCook = new DataTable("tblCook");
                DataTable tblStuff = new DataTable("tblStuff");
                DataColumn col;
                DataRow row;

                col = new DataColumn("No", typeof(int));
                col.Unique = true; col.AutoIncrement = true; tblCook.Columns.Add(col);
                col = new DataColumn("Name", typeof(string));
                col.Unique = true; tblCook.Columns.Add(col);
                col = new DataColumn("Rank", typeof(string));
                col.MaxLength = 1; tblCook.Columns.Add(col);
                col = new DataColumn("Stuff", typeof(string[]));
                tblCook.Columns.Add(col);
                col = new DataColumn("Ratio", typeof(int[]));
                tblCook.Columns.Add(col);
                col = new DataColumn("Effect", typeof(int[]));
                tblCook.Columns.Add(col);
                col = new DataColumn("SpecialEffect", typeof(string));
                tblCook.Columns.Add(col);

                col = new DataColumn("No", typeof(int));
                col.Unique = true; col.AutoIncrement = true; tblStuff.Columns.Add(col);
            }
			
            else
            {*/
                System.Diagnostics.Process.Start("http://dehol.kr");
                return;
            //}
        }
        private void MabiCooker_FormClosed(object sender, FormClosedEventArgs e)
        {
            StreamWriter FavFileSave;
            // StringWriter FavFileSave;
            StringBuilder buffer = new StringBuilder();
            try
            {
                FavFileSave = new StreamWriter("favcook.dat");
                //FavFileSave = new StringWriter(buffer);
            }
            catch (IOException)
            {
                MessageBox.Show("favcook.dat 파일을 다른 프로그램에서 사용하고 있습니다.\n즐겨찾기 목록이 저장되지 않습니다.", "경고");
                return;
            }
            for (int i = 0; i < FavList.Count; i++)
                FavFileSave.WriteLine(CookData[FavList[i]].ToString());
            FavFileSave.Close();
        }
        private void tbSearchTerm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) SearchStart();
        }
        private void lbRankResult_DoubleClick(object sender, EventArgs e)
        {
            if (lbRankResult.SelectedIndex != -1) ViewDetail();
        }
        private void lbSearchResult_DoubleClick(object sender, EventArgs e)
        {
            if (lbSearchResult.SelectedIndex != -1) ViewDetail();
        }
        private void lbFavResult_DoubleClick(object sender, EventArgs e)
        {
            if (lbFavResult.SelectedIndex != -1) ViewDetail();
        }
        private void lbFavResult_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                DialogResult yesno = MessageBox.Show("즐겨찾기가 삭제됩니다. \n정말 삭제하시겠습니까?", "알림", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (yesno == DialogResult.Yes)
                {
                    int IndexTemp = lbFavResult.SelectedIndex;
                    int CookTemp = FavList[lbFavResult.SelectedIndex];
                    DeleteFavList(FavList[lbFavResult.SelectedIndex]);
                    UpdateData(FavList, lbFavResult);
                    if(DetailView != null) DetailView.UpdateData(CookTemp, CookData[CookTemp]);
                    if(RatioView != null) 
                    {
                        CookRatioView.SelectedCook = CookData[CookTemp];
                        CookRatioView.DataIndex = CookTemp;
                        RatioView.UpdateData();
                    }
                    lbFavResult.SelectedIndex = IndexTemp - 1;
                }
            }
        }

        private void MabiCooker_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.LastSelectPoint = new System.Drawing.Point(this.Location.X, this.Location.Y);
            if(RatioView != null) Properties.Settings.Default.LastRatioPoint = new System.Drawing.Point(RatioView.Location.X, RatioView.Location.Y);
            if(DetailView != null) Properties.Settings.Default.LastInfoPoint = new System.Drawing.Point(DetailView.Location.X, DetailView.Location.Y);

            Properties.Settings.Default.Save();
        }
    }
}