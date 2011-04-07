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
        private Cook Selected;
        private Cook[] FavList;
        private int FavListLength;
        public CookDetailView(Cook Data, Cook[] Fav)
        {
            InitializeComponent();
            Selected = Data;
            FavList = Fav;      // 메인 Form의 FavList와 연결
            UpdateData(Data);
        }
        
        private void AddFavList(Cook Data)
        {
            if (CheckFavList(Data)) return;
            if (FavListLength >= FavList.Length)
                MessageBox.Show("즐겨찾기 갯수 허용량을 초과하였습니다.\n다른 것을 지우고 다시 시도해 보세요.");
            else
                FavList[FavListLength++] = Data;
        }
        private void DeleteFavList(Cook Data)
        {
            for (int i = 0; i < FavListLength; i++)
            {
                if (FavList[i].Equals(Data))
                {
                    for (int j = i + 1; j < FavListLength; j++) FavList[j] = FavList[j - 1];
                    FavListLength--;
                }
            }
        }
        private bool CheckFavList(Cook Data)
        {
            for (int i = 0; i < FavListLength; i++)
                if (FavList[i].Equals(Data)) return true;
            return false;
        }
        public void UpdateData(Cook Data)
        {   // MabiCooker Form 에서 같이 쓰이는 메소드. public
            Selected = Data;
            lCookName.Text = Data.getName();
            lStuffOne.Text = (Data.getStuff())[0];
            lStuffTwo.Text = (Data.getStuff())[1];
            if ((Data.getRatio())[0] == 230)
            {
                lCookName.Text += " (조리불가)";
            }
            if (Data.getStuff().Length == 3) lStuffThree.Text = (Data.getStuff())[2];
            else
            {
                lStuffThree.Text = "";
                lStuffThree.Visible = false;
            }
            lEffects.Text = Data.getEffect();
            lRank.Text = Data.getRank().ToString();
            if (CheckFavList(Data)) cbIsFav.Checked = true;
            else cbIsFav.Checked = false;
        }
        private void bClose_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
        private void bDisplayRatio_Click(object sender, EventArgs e)
        {
            if(MabiCooker.RatioView == null) MabiCooker.RatioView = new CookRatioView();
            CookRatioView.SelectedCook = this.Selected;
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
                this.lRank.Location = new Point(212, lRank.Location.Y);
                this.cbIsFav.Location = new Point(239, 6);
                this.bClose.Location = new Point(197, 138);
            }
            else
            {
                int ChangedPixels = lEffects.Width - 260 + 10; //
                this.Width += ChangedPixels;
                this.pDisplayEffects.Width += ChangedPixels;
                this.pDisplayInfo.Width += ChangedPixels;
                this.pDisplayCookName.Width += ChangedPixels;
                this.cbIsFav.Location = new Point(cbIsFav.Location.X + ChangedPixels, cbIsFav.Location.Y);
                this.lRank.Location = new Point(lRank.Location.X + ChangedPixels, lRank.Location.Y);
                this.bClose.Location = new Point(bClose.Location.X + ChangedPixels, bClose.Location.Y);
            }
        }
        private void cbIsFav_CheckedChanged(object sender, EventArgs e)
        {
            if (cbIsFav.Checked == true) AddFavList(Selected);
            else DeleteFavList(Selected);
        }
    }
}
