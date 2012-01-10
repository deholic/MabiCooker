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
	public partial class CookRatioView : Form
	{
		private const int STUFF_FLOW_SIZE = 175;

		public bool NoticeInfo = true;
		public static Cook SelectedCook;
		public static int DataIndex;
		
		private bool RightLeft = true;
		private Point mousePoint;
		private ListBox FavListView;
		private MabiCooker MainWindow;

        private int initial_height;
        private int default_opacity = 50;
        private int hoverd_opacity = 75;
        private int fade_sleep_length = 5;
		
		public CookRatioView(MabiCooker Main, ListBox FavView)
		{
			InitializeComponent();

			if (Properties.Settings.Default.LastRatioPoint.X != 0 && Properties.Settings.Default.LastRatioPoint.Y != 0)
			{
				this.StartPosition = FormStartPosition.Manual;
				this.Location = new Point(Properties.Settings.Default.LastRatioPoint.X, Properties.Settings.Default.LastRatioPoint.Y);
			}

			this.FavListView = FavView;
			this.MainWindow = Main;
            initial_height = this.Size.Height;
		}
		public void UpdateData()
		{
			// 요리 재료 라벨 사이즈 165
			if (SelectedCook != null)
			{
				int[] iBuffer;
				int RankId = SelectedCook.getRank();
				//Type def = typeof(Cook.RankName);
				// lStuffs.Location = new Point(lName.Location.X + lName.Width + 5, 15);
				lStuffs.Text = SelectedCook.getStuffForString();
				//lRankName.Text = Enum.GetName(def, Cook.checkRank(SelectedCook.getRank()));
				lRankName.Text = Rank.getRankName(RankId);
                lRank.Text = Rank.getRankChar(RankId).ToString();
				lName.Text = SelectedCook.getName();
				lName.Location = new Point(lRankName.Location.X + lRankName.Width, lName.Location.Y);
				//lRank.Text = SelectedCook.getRank().ToString();
				iBuffer = SelectedCook.getRatio();
				if (iBuffer[0] == 230)
				{
					lName.Text += Properties.Resources.StrCannotCook;
				}
				pbStuffOne.Width = iBuffer[0];
				pbStuffTwo.Location = new Point(iBuffer[0], 0);
				pbStuffTwo.Width = iBuffer[1];
				if (iBuffer.Length == 3)
				{
					pbStuffThree.Location = new Point(iBuffer[0] + iBuffer[1], 0);
					pbStuffThree.Width = iBuffer[2];
				}
				else pbStuffThree.Width = 0;
				if (MainWindow.FavList.Contains(DataIndex) == true)
					lFavCheck.Text = Properties.Resources.SymbolFavorite;
				else
					lFavCheck.Text = Properties.Resources.SymbolAddFavorite;
				lStuffs.Location = new Point(20, lStuffs.Location.Y);
				if (lStuffs.Width > STUFF_FLOW_SIZE) tiRatioView.Enabled = true;
				else tiRatioView.Enabled = false;
				this.PrintRatio();
			}
			else return;
		}
		private void PrintRatio()
		{
			this.Visible = true;
		}

        #region Event Handler
        private void MabiCooker_RatioView_MouseDown(object sender, MouseEventArgs e)
		{
            this.Opacity = (double)hoverd_opacity/100;
            mousePoint = new Point(e.X, e.Y);
		}
		private void MabiCooker_RatioView_MouseMove(object sender, MouseEventArgs e)
		{
            this.Opacity = (double)hoverd_opacity / 100;
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
			{
				Location = new Point(this.Left - (mousePoint.X - e.X),
					this.Top - (mousePoint.Y - e.Y));
			}
		}
		private void CookRatioView_FormClosed(object sender, FormClosedEventArgs e)
		{
			Properties.Settings.Default.LastRatioPoint = new Point(this.Location.X, this.Location.Y);
			MabiCooker.RatioView = new CookRatioView(MainWindow, FavListView);
		}
		private void CookRatioView_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape) this.Visible = false;
		}
		private void lCloseRatio_Click(object sender, EventArgs e)
		{
			this.Visible = false;
		}
		private void lFavCheck_Click(object sender, EventArgs e)
		{
			if (MainWindow.FavList.Contains(DataIndex) == false)
			{
				MainWindow.AddFavList(DataIndex);
				lFavCheck.Text = Properties.Resources.SymbolFavorite;
			}
			else
			{
				MainWindow.DeleteFavList(DataIndex);
				lFavCheck.Text = Properties.Resources.SymbolAddFavorite;
			}
			MainWindow.UpdateData(MainWindow.FavList, FavListView);
			if (MabiCooker.DetailView != null) MabiCooker.DetailView.UpdateData(DataIndex, SelectedCook);
			if (MainWindow.FavList.Count != 0) FavListView.BringToFront();
			else FavListView.SendToBack();
		}
		private void tiRatioView_Tick(object sender, EventArgs e)
		{
			// 이 라벨 사이즈가 165 이상이게 되면 동작.
			if (lStuffs.Width > STUFF_FLOW_SIZE)
			{
				// lStuffs.Location.X > 20 - (lStuffs.Width - 165)
				if (lStuffs.Location.X == STUFF_FLOW_SIZE + 15 - lStuffs.Width) RightLeft = false;
				else if (lStuffs.Location.X == 25) RightLeft = true;
				if (RightLeft)
					lStuffs.Location = new Point(lStuffs.Location.X - 1, lStuffs.Location.Y);
				else
					lStuffs.Location = new Point(lStuffs.Location.X + 1, lStuffs.Location.Y);
			}
			else return;
		}

		private void CookRatioView_VisibleChanged(object sender, EventArgs e)
		{
			if (this.Visible == false)
				tiRatioView.Enabled = false;
			else if (this.Visible == true && lStuffs.Width > STUFF_FLOW_SIZE)
				tiRatioView.Enabled = true;
		}

		private void pbStuffOne_Click(object sender, EventArgs e)
		{
			if (this.NoticeInfo == true)
			{
				this.NoticeInfo = false;
				this.Height = 8;
			}
			else
			{
				this.NoticeInfo = true;
				this.Height = initial_height;
			}
		}
        #endregion
        private void CookRatioView_Fade(object sender, EventArgs e)
        {
            if (this.Opacity >= default_opacity)
            {
                // Fade out
                for (double i = this.Opacity; i <= hoverd_opacity; i++)
                {
                    this.Opacity = i;
                    System.Threading.Thread.Sleep(fade_sleep_length);
                }
            }
            else if (this.Opacity <= hoverd_opacity)
            {
                // Fade in
                for (double i = this.Opacity; i <= hoverd_opacity; i++)
                {
                    this.Opacity = i;
                    System.Threading.Thread.Sleep(fade_sleep_length);
                }
            }
        }
        private void CookRatioView_active(object sender, EventArgs e)
        {
            int initial_opacity = (int)this.Opacity * 100;
            // Fade in
            if (initial_opacity != default_opacity)
            {
                for (int i = default_opacity; i <= hoverd_opacity; i++)
                {
                    this.Opacity = (double)i / 100;
                    System.Threading.Thread.Sleep(fade_sleep_length);
                }
            }
        }
        private void CookRatioView_deactive(object sender, EventArgs e)
        {
            int initial_opacity = (int)this.Opacity * 100;
            // Fade out
            if (initial_opacity != hoverd_opacity)
            {
                for (int i = hoverd_opacity; i >= default_opacity; i--)
                {
                    this.Opacity = (double)i / 100;
                    System.Threading.Thread.Sleep(fade_sleep_length);
                }
            }
        }

        private void RatioView_Hover_Stuff1(object sender, EventArgs e)
        {

        }
        private void RatioView_Hover_Stuff2(object sender, EventArgs e)
        {

        }
        private void RatioView_Hover_Stuff3(object sender, EventArgs e)
        {

        }
	}
}
