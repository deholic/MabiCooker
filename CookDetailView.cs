using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CookImplement;

namespace MabiCooker2
{
    public partial class CookDetailView : Form
    {
        #region 변수들이염 뿌우 'ㅅ'
        private ListBox FavListView;
        private MabiCooker MainWindow;
        private Cook Selected;
        private String ChkKeyword;
        private int DataIndex;
        private readonly List<Stuff> StuffData;
        public Stack<CookData> ForTrace = new Stack<CookData>();
        private int[] StuffIndexs = new int[3];
        private CookData CookInfo;
        public static bool NoticeInfo = false;
        #endregion

        public CookDetailView(MabiCooker Main, int DataIndex, Cook Data, ListBox FavView, List<Stuff> StuffData)
        {
            InitializeComponent(); 
            
            if (Properties.Settings.Default.LastInfoPoint.X != 0 && Properties.Settings.Default.LastInfoPoint.Y != 0)
            {
                this.StartPosition = FormStartPosition.Manual;
                this.Location = new Point(Properties.Settings.Default.LastInfoPoint.X, Properties.Settings.Default.LastInfoPoint.Y);
            }

            this.Selected = Data;
            this.FavListView = FavView;
            this.MainWindow = Main;
            this.DataIndex = DataIndex;
            this.StuffData = StuffData;
            UpdateData(DataIndex, Data);
        }
        public CookDetailView(MabiCooker Main, CookData Exchange, ListBox FavView)
        {
            InitializeComponent();
            this.MainWindow = Main;
            this.CookInfo = Exchange;
            this.FavListView = FavView;
            UpdateData(this.CookInfo);
        }
        public void UpdateData(int DataIndex, Cook Data)
        {   // MabiCooker Form 에서 같이 쓰이는 메소드. public
            this.Height = 197;
            this.Selected = Data;
            this.DataIndex = DataIndex;
            if (this.ForTrace.Count == 0) bNext.Enabled = false;
            lCookName.Text = Data.getName();
            lStuffOne.Text = (Data.getStuff())[0];
            lStuffTwo.Text = (Data.getStuff())[1];
            if ((Data.getRatio())[0] == 230)
            {
                lCookName.Text += " (조리불가)";
            }
            if (Data.getStuff().Length == 3)
            {
                lStuffThree.Text = (Data.getStuff())[2];
                lStuffThree.Visible = true;
            }
            else
            {
                lStuffThree.Text = "";
                lStuffThree.Visible = false;
            }
            lEffects.Text = Data.getEffect();
            lRank.Text = Data.getRank().ToString();
            if (MainWindow.FavList.Contains(DataIndex))
                pDisplayCookName.BackColor = Color.LimeGreen;
            else
                pDisplayCookName.BackColor = Color.Black;
        }
        public void UpdateData(CookData Exchange)
        {
            this.Height = 197;
            this.CookInfo = Exchange;
            if (this.ForTrace.Count == 0) bNext.Enabled = false; // 이전 요리 스택에 뭔가 있으면 버튼 활성화
            lCookName.Text = CookInfo.cook.getName();
            lStuffOne.Text = CookInfo.stuffs[0].sName; CheckStuff(CookInfo.stuffs[0], lStuffOne, lStuffOnePrice);
            lStuffTwo.Text = CookInfo.stuffs[1].sName; CheckStuff(CookInfo.stuffs[1], lStuffTwo, lStuffTwoPrice);

            if ((CookInfo.cook.getRatio())[0] == 230)
            {
                lCookName.Text += " (조리불가)";
            }
            if (CookInfo.stuffs[2] != null)
            {
                lStuffThree.Text = CookInfo.stuffs[2].sName; CheckStuff(CookInfo.stuffs[2], lStuffThree, lStuffThreePrice);
                lStuffThree.Visible = true;
            }
            else
            {
                lStuffThree.Text = "";
                lStuffThree.Visible = false;
                lStuffThreePrice.Visible = false;
            }
            lEffects.Text = CookInfo.cook.getEffect();
            lRank.Text = CookInfo.cook.getRank().ToString();
            if (MainWindow.FavList.Contains(CookInfo.cIndex))
                pDisplayCookName.BackColor = Color.LimeGreen;
            else
                pDisplayCookName.BackColor = Color.Black;
        }
        /// <summary>
        /// Label Refresh
        /// </summary>
        /// <param name="s">Stuff Data</param>
        /// <param name="l1">Stuff Name LinkLabel</param>
        /// <param name="l2">Stuff Price Label</param>
        private void CheckStuff(Stuff s, LinkLabel l1, Label l2)
        {
            if (s.sSellingPoint.Contains(Stuff.SellerName.요리)) l1.LinkArea = new LinkArea(0, l1.Text.Length);
            else l1.LinkArea = new LinkArea(0, 0);
            int i;
            if ((i = s.sPrice) != 0)
            {
                l2.Visible = true; l2.Text = "(" + i.ToString() + " G)";
                l2.Location = new Point(l1.Location.X + l1.Width, l2.Location.Y);
            }
            else
            {
                l2.Visible = false;
                l2.Location = new Point(l1.Location.X + l1.Width, l2.Location.Y);
            }
        }
        private bool CheckStuffName(Stuff o)
        {
            if (o.sName == ChkKeyword) return true;
            return false;
        }
        private void TraceLink(int StuffNumber)
        {
            ForTrace.Push(CookInfo); bNext.Enabled = true;
            UpdateData(new CookData(CookInfo.cList, CookInfo.sList, CookInfo.stuffs[StuffNumber].sName));
            CookRatioView.SelectedCook = CookInfo.cook;
            CookRatioView.DataIndex = CookInfo.cIndex;
            if (MabiCooker.RatioView != null) MabiCooker.RatioView.UpdateData();
        }

        #region 이벤트 처리 함수들
        private void bClose_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
        private void bDisplayRatio_Click(object sender, EventArgs e)
        {
            if(MabiCooker.RatioView == null) MabiCooker.RatioView = new CookRatioView(MainWindow, FavListView);
            CookRatioView.SelectedCook = this.CookInfo.cook;
            MabiCooker.RatioView.UpdateData();
        }
        private void lEffects_SizeChanged(object sender, EventArgs e)
        {
            if (lEffects.Width <= 240)
            {
                this.Size = new Size(290, 197);
                this.pDisplayEffects.Width = 260;
                this.pDisplayInfo.Width = 260;
                this.pDisplayCookName.Width = 260;
                this.pAlertShowing.Width = 260;
                this.lRank.Location = new Point(212, lRank.Location.Y);
                this.bClose.Location = new Point(222, 138);
            }
            else
            {
                int ChangedPixels = lEffects.Width - 260 + 10; //
                this.Width = 290 + ChangedPixels;
                this.pDisplayEffects.Width = 260 + ChangedPixels;
                this.pDisplayInfo.Width = 260 + ChangedPixels;
                this.pDisplayCookName.Width = 260 + ChangedPixels;
                this.pAlertShowing.Width = 260 + ChangedPixels;
                this.lRank.Location = new Point(212 + ChangedPixels, lRank.Location.Y);
                this.bClose.Location = new Point(222 + ChangedPixels, bClose.Location.Y);
            }
        }
        private void CookDetailView_FormClosed(object sender, FormClosedEventArgs e)
        {
            MabiCooker.DetailView = new CookDetailView(MainWindow, CookInfo, FavListView);
        }
        private void bModFav_Click(object sender, EventArgs e)
        {
            if (MainWindow.FavList.Contains(CookInfo.cIndex))
            {
                MainWindow.DeleteFavList(CookInfo.cIndex);
                MainWindow.UpdateData(MainWindow.FavList, FavListView);
                if (MabiCooker.RatioView != null) MabiCooker.RatioView.UpdateData();
                pAlertShowing.BackColor = Color.OrangeRed;
                pDisplayCookName.BackColor = Color.Black;
                lAlert.Text = "즐겨찾기에서 삭제 되었습니다.";
                pAlertShowing.Visible = true;
                tiCheckAlert.Enabled = true;
            }
            else
            {
                MainWindow.AddFavList(CookInfo.cIndex);
                MainWindow.UpdateData(MainWindow.FavList, FavListView);
                if (MabiCooker.RatioView != null) MabiCooker.RatioView.UpdateData();
                pAlertShowing.BackColor = Color.LimeGreen;
                pDisplayCookName.BackColor = Color.LimeGreen;
                lAlert.Text = "즐겨찾기에 추가 되었습니다.";
                pAlertShowing.Visible = true;
                tiCheckAlert.Enabled = true;
            }
        }
        private void tiCheckAlert_Tick(object sender, EventArgs e)
        {
            pAlertShowing.Visible = false;
            tiCheckAlert.Enabled = false;
        }
        private void lStuffOne_MouseHover(object sender, EventArgs e)
        {
            String buffer = "";
            for (int i = 0; i < CookInfo.stuffs[0].sSellingPoint.Count; )
            {
                buffer += CookInfo.stuffs[0].sSellingPoint[i++];
                if (i != CookInfo.stuffs[0].sSellingPoint.Count) buffer += ", ";
            }
            toolTip1.SetToolTip(lStuffOne, buffer);
        }
        private void lStuffTwo_MouseHover(object sender, EventArgs e)
        {
            String buffer = "";
            for (int i = 0; i < CookInfo.stuffs[1].sSellingPoint.Count; )
            {
                buffer += CookInfo.stuffs[1].sSellingPoint[i++];
                if (i != CookInfo.stuffs[1].sSellingPoint.Count) buffer += ", ";
            }
            toolTip1.SetToolTip(lStuffTwo, buffer);
        }
        private void lStuffThree_MouseHover(object sender, EventArgs e)
        {
            if (CookInfo.stuffs[2] != null)
            {
                String buffer = "";
                for (int i = 0; i < CookInfo.stuffs[2].sSellingPoint.Count; )
                {
                    buffer += CookInfo.stuffs[2].sSellingPoint[i++];
                    if (i != CookInfo.stuffs[2].sSellingPoint.Count) buffer += ", ";
                }
                toolTip1.SetToolTip(lStuffThree, buffer);
            }
        }
        private void lStuffOne_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TraceLink(0);
        }
        private void lStuffTwo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TraceLink(1);
        }
        private void lStuffThree_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TraceLink(2);
        }
        private void bNext_Click(object sender, EventArgs e)
        {
            if (ForTrace.Count != 0)
            {
                CookInfo = ForTrace.Pop();
                UpdateData(CookInfo);
                CookRatioView.SelectedCook = CookInfo.cook;
                CookRatioView.DataIndex = CookInfo.cIndex;
                if (MabiCooker.RatioView != null) MabiCooker.RatioView.UpdateData();
                if (ForTrace.Count == 0) bNext.Enabled = false;
            }
        }
        private void bDisplayRatio_MouseHover(object sender, EventArgs e)
        {
            toolTip2.SetToolTip(bDisplayRatio, "비율보기");
        }
        private void bModFav_MouseHover(object sender, EventArgs e)
        {
            toolTip2.SetToolTip(bModFav, "즐겨찾기");
        }
        private void bNext_MouseHover(object sender, EventArgs e)
        {
            if(bNext.Enabled == true) toolTip2.SetToolTip(bNext, "이전 요리 보기");
        }
        #endregion
    }
}
