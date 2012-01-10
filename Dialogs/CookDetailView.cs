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
		private int DataIndex;
		private readonly List<Stuff> StuffData;
		public Stack<CookData> ForTrace = new Stack<CookData>();
		private int[] StuffIndexs = new int[3];
		private CookData CookInfo;
		public static bool NoticeInfo = false;

		// Initial Window Size
        private string message = null;
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
			//this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
			this.Selected = Data;
			this.DataIndex = DataIndex;
			if (this.ForTrace.Count == 0) bBack.Enabled = false;
			this.Text = Data.getName();
			lStuffOne.Text = (Data.getStuff())[0];
			lStuffTwo.Text = (Data.getStuff())[1];
            tiCheckAlert.Enabled = false;
			if ((Data.getRatio())[0] == 230)
			{
				this.Text += Properties.Resources.StrCannotCook;
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
			this.message = Data.getRankName();
            lMessage.Text = this.message;
			/*
			if (MainWindow.FavList.Contains(DataIndex))
				pDisplayCookName.BackColor = Color.LimeGreen;
			else
				pDisplayCookName.BackColor = Color.Black;
			*/
		}
		public void UpdateData(CookData Exchange)
		{
			try
			{
				this.CookInfo = Exchange;
				bBack.Enabled = (this.ForTrace.Count == 0) ? false : true; // 이전 요리 스택에 뭔가 있으면 버튼 활성화
				this.Text = CookInfo.cook.getName();

                if (CookInfo.stuffs[0] != null)
                {
                    lStuffOne.Text = CookInfo.stuffs[0].sName;
                    CheckStuff(CookInfo.stuffs[0], lStuffOne, lStuffOnePrice);
                }
                else
                {
                    lStuffOne.Text = "Unknown Error";
                }

                if (CookInfo.stuffs[1] != null)
                {
                    CheckStuff(CookInfo.stuffs[1], lStuffTwo, lStuffTwoPrice);
                    lStuffTwo.Text = CookInfo.stuffs[1].sName;
                }
                else
                {
                    lStuffTwo.Text = "Unknown Error";
                }

				if ((CookInfo.cook.getRatio())[0] == 230)
				{
					this.Text += Properties.Resources.StrCannotCook;
				}
				if (CookInfo.stuffs[2] != null)
				{
					lStuffThree.Text = CookInfo.stuffs[2].sName;
					CheckStuff(CookInfo.stuffs[2], lStuffThree, lStuffThreePrice);
					lStuffThree.Visible = true;
				}
				else
				{
					lStuffThree.Text = "";
					lStuffThree.Visible = false;
					lStuffThreePrice.Visible = false;
				}

                if (MainWindow.FavList.Contains(CookInfo.cIndex))
                {
                    bModFav.Image = MabiCooker2.Properties.Resources.bookmark_remove;
                }else{
                    bModFav.Image = MabiCooker2.Properties.Resources.bookmark;
                }
				lEffects.Text = CookInfo.cook.getEffect();
				var RankId = CookInfo.cook.getRank();

				lRank.Text = RankId.ToString();
				lPicture.Image = CookImplement.Rank.getRankBitmap(RankId);
                this.message = CookImplement.Rank.getRankName(RankId);
                lMessage.Text = this.message;
			}
			catch (IndexOutOfRangeException e)
			{
				CookImplement.Dialog.ErrorDialog error = new CookImplement.Dialog.ErrorDialog(null, e.StackTrace);
				error.ShowDialog();
			}
		}
		/// <summary>
		/// Label Refresh
		/// </summary>
		/// <param name="s">Stuff Data</param>
		/// <param name="StuffLabel">Stuff Name LinkLabel</param>
		/// <param name="DetailLabel">Stuff Price Label</param>
		private void CheckStuff(Stuff s, LinkLabel StuffLabel, Label DetailLabel)
		{
			//if (s.sSellingPoint.Contains(Stuff.SellerName.요리))
			if (s.sSellingPoint.Contains(Seller.toString(14)))
			{
				StuffLabel.LinkArea = new LinkArea(0, StuffLabel.Text.Length);
			}
			else
			{
				StuffLabel.LinkArea = new LinkArea(0, 0);
			}
			int i;
			if ((i = s.sPrice) != 0)
			{
				DetailLabel.Visible = true;
                DetailLabel.Text = "(" + i.ToString() + " G)";
				DetailLabel.Location = new Point(StuffLabel.Location.X + StuffLabel.Width, DetailLabel.Location.Y);
			}
			else
			{
				DetailLabel.Visible = false;
				DetailLabel.Location = new Point(StuffLabel.Location.X + StuffLabel.Width, DetailLabel.Location.Y);
			}
		}
		private void TraceLink(int StuffNumber)
		{
			ForTrace.Push(CookInfo); bBack.Enabled = true;
			UpdateData(new CookData(CookInfo.cList, CookInfo.sList, CookInfo.stuffs[StuffNumber].sName));
			CookRatioView.SelectedCook = CookInfo.cook;
			CookRatioView.DataIndex = CookInfo.cIndex;
			if (MabiCooker.RatioView != null) MabiCooker.RatioView.UpdateData();
		}

		#region 이벤트 처리 함수들
		private void bDisplayRatio_Click(object sender, EventArgs e)
		{
            if (MabiCooker.RatioView == null)
            {
                MabiCooker.RatioView = new CookRatioView(MainWindow, FavListView);
            }
            else
            {
                if (MabiCooker.RatioView.Visible == true)
                {
                    MabiCooker.RatioView.Visible = false;
                }else if (MabiCooker.RatioView.Visible == false){
                    MabiCooker.RatioView.Visible = true;
                }
            }
			CookRatioView.SelectedCook = this.CookInfo.cook;
			MabiCooker.RatioView.UpdateData();
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
                pAlertShowing.BackColor = SystemColors.InactiveCaption;
				lMessage.Text = Properties.Resources.MsgFavoriteRemove;
                bModFav.Image = MabiCooker2.Properties.Resources.bookmark;
				tiCheckAlert.Enabled = true;
			}
			else
			{
				MainWindow.AddFavList(CookInfo.cIndex);
				MainWindow.UpdateData(MainWindow.FavList, FavListView);
				if (MabiCooker.RatioView != null) MabiCooker.RatioView.UpdateData();
				pAlertShowing.BackColor = SystemColors.ActiveCaption;
				lMessage.Text = Properties.Resources.MsgFavoriteAdd;
                bModFav.Image = MabiCooker2.Properties.Resources.bookmark_remove;
				tiCheckAlert.Enabled = true;
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
        private void tiCheckAlert_Tick(object sender, EventArgs e)
        {
            tiCheckAlert.Enabled = false;
            pAlertShowing.BackColor = SystemColors.Control;
        }
		private void lStuffOne_MouseHover(object sender, EventArgs e)
		{
            if (tiCheckAlert.Enabled == false)
            {
                String buffer = "";
                for (int i = 0; i < CookInfo.stuffs[0].sSellingPoint.Count; )
                {
                    buffer += CookInfo.stuffs[0].sSellingPoint[i++];
                    if (i != CookInfo.stuffs[0].sSellingPoint.Count) buffer += ", ";
                }
                lMessage.Text = buffer;
            }
		}
		private void lStuffTwo_MouseHover(object sender, EventArgs e)
		{
            if (tiCheckAlert.Enabled == false)
            {
                String buffer = "";
                for (int i = 0; i < CookInfo.stuffs[1].sSellingPoint.Count; )
                {
                    buffer += CookInfo.stuffs[1].sSellingPoint[i++];
                    if (i != CookInfo.stuffs[1].sSellingPoint.Count) buffer += ", ";
                }
                lMessage.Text = buffer;
            }
		}
		private void lStuffThree_MouseHover(object sender, EventArgs e)
		{
            if (CookInfo.stuffs[2] != null )
			{
				String buffer = "";
				for (int i = 0; i < CookInfo.stuffs[2].sSellingPoint.Count; )
				{
					buffer += CookInfo.stuffs[2].sSellingPoint[i++];
					if (i != CookInfo.stuffs[2].sSellingPoint.Count) buffer += ", ";
				}
				lMessage.Text = buffer;
			}
		}
        private void reset_message_bar(object sender, EventArgs e)
        {
            lMessage.Text = this.message;
        }
		private void bBack_Click(object sender, EventArgs e)
		{
			if (ForTrace.Count != 0)
			{
				CookInfo = ForTrace.Pop();
				UpdateData(CookInfo);
				CookRatioView.SelectedCook = CookInfo.cook;
				CookRatioView.DataIndex = CookInfo.cIndex;
				if (MabiCooker.RatioView != null) MabiCooker.RatioView.UpdateData();
				if (ForTrace.Count == 0) bBack.Enabled = false;
			}
		}
		private void bDisplayRatio_MouseHover(object sender, EventArgs e)
		{
            if (tiCheckAlert.Enabled == false)
            {
                lMessage.Text = Properties.Resources.StrDisplayRatio;
            }
		}
		private void bModFav_MouseHover(object sender, EventArgs e)
		{
            if (tiCheckAlert.Enabled == false)
            {
                if (MainWindow.FavList.Contains(CookInfo.cIndex))
                {
                    lMessage.Text = Properties.Resources.StrFavoriteRemove;
                }
                else
                {
                    lMessage.Text = Properties.Resources.StrFavorite;
                }
            }
		}
		private void bBack_MouseHover(object sender, EventArgs e)
		{
			if (bBack.Enabled == true && tiCheckAlert.Enabled == false) lMessage.Text = Properties.Resources.StrBack;
		}
		#endregion

	}
}
