using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Resources;
using Finisar.SQLite;


namespace MabiCooker
{
    public partial class MabiCooker_Main : Form
    {
        public MabiCooker_Main()
        {
            InitializeComponent();
        }

        private Food[] DataArray;
        private Food[] ThisRankData;
        private Food SelectedCook;
        private int DataSize;
        private Food[] SearchDummy;
        private int SearchIndex = 0; // 현재 포인터라능
        private int SearchedNumber = 0; // 데이터 풀에서 해당 데이터 찾은 개수
        private const int SEARCH_RESULT_COUNT = 4;

        /* 090806 ADD : SQLite 사용 위한 객체들
        
        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();

        private void SetConnection()
        {
            sql_con = new SQLiteConnection("Data Sorce=MabiCooker.db;Version=3;New=True;Compress=True;");
        }

        private void ExecuteQuery(string txtQuery)
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = txtQuery;
            sql_cmd.ExecuteNonQuery();
            sql_con.Close();
        }
        
        */
        private void MabiCooker_Main_Load(object sender, EventArgs e)
        {
            int number = 0;
            string buffer;

            // 일단 한번 쭉 돌려서 몇줄인지 세야 할듯 'ㅅ'
            status_change(1);
            StreamReader CookData = new StreamReader("cook.dat");
            while (CookData.ReadLine() != null) number++;
            CookData.Close();
            status_change(0);

            using (CookData = new StreamReader("cook.dat"))
            {
                status_change(1);
                DataArray = new Food[number];
                DataSize = number;
                number = 0;
                while ((buffer = CookData.ReadLine()) != null)
                {
                    status_change(1);
                    DataArray[number] = new Food(buffer);
                    number++;
                }
            }
            status_change(0);
        }
        private void RankSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowRatioBar.Enabled = false;
            CookList_Update(WhatRankSelected());
        }
        private void CookList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected = WhatCookSelected();
            SelectedCook = ThisRankData[selected];
            // 090624 : CookView_Update 멤버로 변경
            CookView_Update(SelectedCook);
            ShowRatioBar.Enabled = true;
        }
        private void ShowRatioBar_Click(object sender, EventArgs e)
        {
            MabiCooker_RatioView RatioView = new MabiCooker_RatioView(SelectedCook);
            /* 구버전 생성자
            MabiCooker_RatioView RatioView;
            if (SelectedCook.ingredents.Length > 2)
                RatioView = new MabiCooker_RatioView(SelectedCook.percentage[0], SelectedCook.percentage[1], SelectedCook.percentage[2]);
            else
                RatioView = new MabiCooker_RatioView(SelectedCook.percentage[0], SelectedCook.percentage[1]);
            */
            RatioView.Show();
        }
        private void CookFindString_TextChanged(object sender, EventArgs e)
        {
            string findstring = this.CookFindString.Text;
            int i = 0, j = 0;
            
            // 찾는 스트링값이 바뀌면 SearchIndex, SearchDummy는 초기화함
            SearchIndex = 0; 
            if(SearchDummy != null) SearchDummy.Initialize();
            this.NoneResult.Text = "검색된 결과가 없습니다.";
            this.PrevLink.Visible = false;
            this.NextLink.Visible = false;

            if (this.CookFindString.Text == null)
                this.CookPreviewPanel.Visible = false;
             
            // 텍스트 입력란이 비어 있으면 그냥 판넬만 보여주고 해당값 없음 메세지 Open
            else if (this.CookFindString.Text == "")
            {
                this.CookPreviewPanel.Visible = true;
                this.FindedCook1.Visible = false;
                this.FindedCook2.Visible = false;
                this.FindedCook3.Visible = false;
                this.FindedCook4.Visible = false;
            }
            else
            {
                this.CookPreviewPanel.Visible = true;

                // SearchDummy 크기 재보자 'ㅅ'
                while (i < DataArray.Length)
                {
                    if (DataArray[i].name.Contains(findstring)) j++;
                    i++;
                }
                SearchedNumber = j;

                // SearchDummy 내용 채우기
                if (SearchedNumber != 0)
                {
                    SearchDummy = new Food[j];
                    i = 0; j = 0;
                    while (i < DataArray.Length)
                    {   // 090626 : 수정 완료 / 이 부분 고쳐야함 : 전방일치 아니고 일부 단어라도 있으면 출력되도록
                        // if (DataArray[i].name == findstring)
                        if (DataArray[i].name.Contains(findstring))
                        {
                            SearchDummy[j] = DataArray[i];
                            j++;
                        }
                        i++;
                    }
                }
                // 없으면 짜져 ' 3'
                else
                {
                    this.NoneResult.Visible = true;
                    this.FindedCook1.Visible = false;
                    this.FindedCook2.Visible = false;
                    this.FindedCook3.Visible = false;
                    this.FindedCook4.Visible = false;
                    return;
                }

                // Next/Prev 링크 보이기/감추기
                if (SearchedNumber > SEARCH_RESULT_COUNT)
                {
                    this.PrevLink.Visible = false;
                    this.NextLink.Visible = true;
                }
                SearchResult_Update();
            }
        }
        private void CloseFindResult_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.CookPreviewPanel.Visible = false;
        }
        private void CookFindString_Click(object sender, EventArgs e)
        {
            this.CookFindString.Text = null;
        }
        private void CookFindString_Leave(object sender, EventArgs e)
        {
            this.CookFindString.Text = "요리 이름으로 검색하세요";
            this.CookPreviewPanel.Visible = false;
        }
        // 090625 : CookList 업데이트 부분 외부 함수로 빼냄
        // 090625 : 헷갈리는 부분 주석처리. 작동 잘 된다
        private void CookList_Update(int Rank)
        {   // Rank : RankSelect Combobox의 Index
            int i = 0, j = 0, ThisRankDataSize = 0;

            // 1. DataSize만큼 루프 돌려서 랭크가 맞는게 몇개나 있는지 체크
            while (i < this.DataSize)
            {   // RankParse() : 데이터의 랭크를 Combobox Index 형식으로 변환시킨다
                if (DataArray[i].RankParse() == Rank) ThisRankDataSize++;
                i++;
            }

            i = 0;

            // 2. 해당 랭크 요리갯수만큼의 데이터 배열을 만든다
            ThisRankData = new Food[ThisRankDataSize+1];
            CookList.Items.Clear(); // 리스트 아이템 싸그리 삭제
            
            // 3. 만들어진 배열에 검색 결과 채워 넣고 리스트에도 등록
            while (i < this.DataSize)
            {
                if (DataArray[i].RankParse() == Rank)
                {
                    ThisRankData[j] = DataArray[i];
                    CookList.Items.Add(ThisRankData[j].name);
                    j++;
                }
                i++;
            }
            CookList.EndUpdate();
        }
        // 090624 : CookView 내용 변경하는 부분을 외부 함수로 빼냄 (재사용 가능 +ㅂ+)
        private void CookView_Update(Food SelectedData)
        {
            // 090624 : 판넬 초기화 ㄱㄱ
            this.label1.Visible = false;
            this.label2.Visible = false;
            this.label3.Visible = false;
            this.label4.Visible = false;
            this.label5.Visible = false;
            this.CookName.Visible = true;
            this.Ingredent_No1.Visible = true;
            this.Ingredent_No2.Visible = true;
            this.Ingredent_No3.Visible = true;
            this.CooksEffect.Visible = true;

            int ingredents_number = SelectedData.ingredents.Length,
            effects_number = SelectedData.effects.Length, i = 0;

            this.CookName.Text = SelectedData.name;
            this.Ingredent_No1.Text = SelectedData.ingredents[0];
            this.Ingredent_No2.Text = SelectedData.ingredents[1];
            if (ingredents_number != 2) this.Ingredent_No3.Text = SelectedData.ingredents[2];
            else this.Ingredent_No3.Text = " ";
            
            this.CooksEffect.Text = "";
            while (i < effects_number)
            {
                this.CooksEffect.Text += SelectedData.effects[i];
                if (i == 2) CooksEffect.Text += '\n';
                else if (i != effects_number - 1) CooksEffect.Text += " / ";
                i++;
            }
        }
        // 090625 : 검색 결과를 4개씩 잘라서 보여주기
        private void SearchResult_Update()
        {
            /* 일단은 Prev/Next 링크 보여주는 여부부터 설정하고 -> SearchIndex 사용
             * SearchDummy하고 SearchIndex 사용해서 4개씩 잘라서 최신화 
             * 그나저나 코드 한번 참 더럽네 -ㅅ- */
            int i = SearchIndex * 4, ResultLength = SearchDummy.Length;
            this.NoneResult.Text = "검색 결과 : " + SearchDummy.Length + "개";
            
            // Prev&Next 링크 보이기 판정
            if (SearchIndex == 0 && ResultLength > 4)
            {
                this.PrevLink.Visible = false;
                this.NextLink.Visible = true;
            }
            else if (SearchIndex == 0 && ResultLength < 4)
            {
                this.PrevLink.Visible = false;
                this.NextLink.Visible = false;
            }
            else if ((ResultLength - i) / 4 == 0)
            {
                this.PrevLink.Visible = true;
                this.NextLink.Visible = false;
            }
            else
            {
                this.PrevLink.Visible = true;
                this.NextLink.Visible = true;
            }
            
            // 090626 : 수정 완료
            // 현재 문제 있음 : 
            // 리스트가 두개씩밖에 안나오고.
            // 2페이지부터는 아예 다른 값이 나옴. 수정 요함.
            if (ResultLength - i >= SEARCH_RESULT_COUNT || ResultLength - i == 0)
            {
                this.FindedCook1.Text = SearchDummy[i].name;
                this.FindedCook1.Visible = true;
                this.FindedCook2.Text = SearchDummy[i+1].name;
                this.FindedCook2.Visible = true;
                this.FindedCook3.Text = SearchDummy[i+2].name;
                this.FindedCook3.Visible = true;
                this.FindedCook4.Text = SearchDummy[i+3].name;
                this.FindedCook4.Visible = true;
            }
            else if (ResultLength % 4 == 1 && ResultLength - i < SEARCH_RESULT_COUNT)
            {
                this.FindedCook1.Text = SearchDummy[i].name;
                this.FindedCook1.Visible = true;
                this.FindedCook2.Visible = false;
                this.FindedCook3.Visible = false;
                this.FindedCook4.Visible = false;
            }
            else if (ResultLength % 4 == 2 && ResultLength - i < SEARCH_RESULT_COUNT)
            {
                this.FindedCook1.Text = SearchDummy[i].name;
                this.FindedCook1.Visible = true;
                this.FindedCook2.Text = SearchDummy[i+1].name;
                this.FindedCook2.Visible = true;
                this.FindedCook3.Visible = false;
                this.FindedCook4.Visible = false;
            }
            else
            {
                this.FindedCook1.Text = SearchDummy[i].name;
                this.FindedCook1.Visible = true;
                this.FindedCook2.Text = SearchDummy[i+1].name;
                this.FindedCook2.Visible = true;
                this.FindedCook3.Text = SearchDummy[i+2].name;
                this.FindedCook3.Visible = true;
                this.FindedCook4.Visible = false;
            }
        }

        // 090625 : 검색 링크 타고 CookView 판넬 업데이트
        private void FindedCook1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CookView_Update(SearchDummy[SearchIndex * 4]);
            SelectedCook = SearchDummy[SearchIndex * 4];
            RankSelect.SelectedIndex = SelectedCook.RankParse();
            ShowRatioBar.Enabled = true;
        }
        private void FindedCook2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CookView_Update(SearchDummy[(SearchIndex * 4) + 1]);
            SelectedCook = SearchDummy[(SearchIndex * 4) + 1];
            RankSelect.SelectedIndex = SelectedCook.RankParse();
            ShowRatioBar.Enabled = true;
        }
        private void FindedCook3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CookView_Update(SearchDummy[(SearchIndex * 4) + 2]);
            SelectedCook = SearchDummy[(SearchIndex * 4) + 2];
            RankSelect.SelectedIndex = SelectedCook.RankParse();
            ShowRatioBar.Enabled = true;
        }
        private void FindedCook4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CookView_Update(SearchDummy[(SearchIndex * 4) + 3]);
            SelectedCook = SearchDummy[(SearchIndex * 4) + 3];
            RankSelect.SelectedIndex = SelectedCook.RankParse();
            ShowRatioBar.Enabled = true;
        }
        private void NextLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SearchIndex++;
            SearchResult_Update();
            CookPreviewPanel.Visible = true;
        }
        private void PrevLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SearchIndex--;
            SearchResult_Update();
            CookPreviewPanel.Visible = true;
        }
        private void ShowCookInfo_MouseHover(object sender, EventArgs e)
        {
            this.CookPreviewPanel.Visible = false;
            if(SearchDummy != null) SearchDummy.Initialize();
        }
    }
}
