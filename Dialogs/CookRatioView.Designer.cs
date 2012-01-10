namespace MabiCooker2
{
    partial class CookRatioView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CookRatioView));
            this.pbStuffOne = new System.Windows.Forms.PictureBox();
            this.pbStuffTwo = new System.Windows.Forms.PictureBox();
            this.pbStuffThree = new System.Windows.Forms.PictureBox();
            this.lName = new System.Windows.Forms.Label();
            this.lStuffs = new System.Windows.Forms.Label();
            this.lRankName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lCloseRatio = new System.Windows.Forms.Label();
            this.lFavCheck = new System.Windows.Forms.Label();
            this.lRank = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tiRatioView = new System.Windows.Forms.Timer(this.components);
            this.DetailTooltip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbStuffOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStuffTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStuffThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pbStuffOne
            // 
            this.pbStuffOne.BackColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.pbStuffOne, "pbStuffOne");
            this.pbStuffOne.Name = "pbStuffOne";
            this.pbStuffOne.TabStop = false;
            this.pbStuffOne.Click += new System.EventHandler(this.pbStuffOne_Click);
            this.pbStuffOne.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MabiCooker_RatioView_MouseDown);
            this.pbStuffOne.MouseHover += new System.EventHandler(this.RatioView_Hover_Stuff1);
            this.pbStuffOne.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MabiCooker_RatioView_MouseMove);
            // 
            // pbStuffTwo
            // 
            this.pbStuffTwo.BackColor = System.Drawing.Color.Yellow;
            resources.ApplyResources(this.pbStuffTwo, "pbStuffTwo");
            this.pbStuffTwo.Name = "pbStuffTwo";
            this.pbStuffTwo.TabStop = false;
            this.pbStuffTwo.Click += new System.EventHandler(this.pbStuffOne_Click);
            this.pbStuffTwo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MabiCooker_RatioView_MouseDown);
            this.pbStuffTwo.MouseHover += new System.EventHandler(this.RatioView_Hover_Stuff2);
            this.pbStuffTwo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MabiCooker_RatioView_MouseMove);
            // 
            // pbStuffThree
            // 
            this.pbStuffThree.BackColor = System.Drawing.Color.Lime;
            resources.ApplyResources(this.pbStuffThree, "pbStuffThree");
            this.pbStuffThree.Name = "pbStuffThree";
            this.pbStuffThree.TabStop = false;
            this.pbStuffThree.Click += new System.EventHandler(this.pbStuffOne_Click);
            this.pbStuffThree.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MabiCooker_RatioView_MouseDown);
            this.pbStuffThree.MouseHover += new System.EventHandler(this.RatioView_Hover_Stuff3);
            this.pbStuffThree.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MabiCooker_RatioView_MouseMove);
            // 
            // lName
            // 
            resources.ApplyResources(this.lName, "lName");
            this.lName.CausesValidation = false;
            this.lName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lName.Name = "lName";
            this.lName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MabiCooker_RatioView_MouseDown);
            this.lName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MabiCooker_RatioView_MouseMove);
            // 
            // lStuffs
            // 
            resources.ApplyResources(this.lStuffs, "lStuffs");
            this.lStuffs.BackColor = System.Drawing.Color.Transparent;
            this.lStuffs.CausesValidation = false;
            this.lStuffs.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lStuffs.Name = "lStuffs";
            this.lStuffs.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MabiCooker_RatioView_MouseDown);
            this.lStuffs.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MabiCooker_RatioView_MouseMove);
            // 
            // lRankName
            // 
            resources.ApplyResources(this.lRankName, "lRankName");
            this.lRankName.BackColor = System.Drawing.Color.Transparent;
            this.lRankName.CausesValidation = false;
            this.lRankName.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lRankName.Name = "lRankName";
            this.lRankName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MabiCooker_RatioView_MouseDown);
            this.lRankName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MabiCooker_RatioView_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // lCloseRatio
            // 
            resources.ApplyResources(this.lCloseRatio, "lCloseRatio");
            this.lCloseRatio.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lCloseRatio.CausesValidation = false;
            this.lCloseRatio.ForeColor = System.Drawing.Color.White;
            this.lCloseRatio.Name = "lCloseRatio";
            this.lCloseRatio.Click += new System.EventHandler(this.lCloseRatio_Click);
            // 
            // lFavCheck
            // 
            resources.ApplyResources(this.lFavCheck, "lFavCheck");
            this.lFavCheck.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lFavCheck.CausesValidation = false;
            this.lFavCheck.ForeColor = System.Drawing.Color.White;
            this.lFavCheck.Name = "lFavCheck";
            this.lFavCheck.Click += new System.EventHandler(this.lFavCheck_Click);
            // 
            // lRank
            // 
            resources.ApplyResources(this.lRank, "lRank");
            this.lRank.BackColor = System.Drawing.Color.Transparent;
            this.lRank.CausesValidation = false;
            this.lRank.ForeColor = System.Drawing.Color.White;
            this.lRank.Name = "lRank";
            this.lRank.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MabiCooker_RatioView_MouseDown);
            this.lRank.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MabiCooker_RatioView_MouseMove);
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // tiRatioView
            // 
            this.tiRatioView.Interval = 75;
            this.tiRatioView.Tick += new System.EventHandler(this.tiRatioView_Tick);
            // 
            // CookRatioView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            resources.ApplyResources(this, "$this");
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lRank);
            this.Controls.Add(this.lFavCheck);
            this.Controls.Add(this.lCloseRatio);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lStuffs);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.pbStuffThree);
            this.Controls.Add(this.pbStuffTwo);
            this.Controls.Add(this.pbStuffOne);
            this.Controls.Add(this.lRankName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CookRatioView";
            this.Opacity = 0.5D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CookRatioView_FormClosed);
            this.VisibleChanged += new System.EventHandler(this.CookRatioView_VisibleChanged);
            this.Enter += new System.EventHandler(this.CookRatioView_active);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CookRatioView_KeyDown);
            this.Leave += new System.EventHandler(this.CookRatioView_deactive);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MabiCooker_RatioView_MouseDown);
            this.MouseLeave += new System.EventHandler(this.CookRatioView_deactive);
            this.MouseHover += new System.EventHandler(this.CookRatioView_active);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MabiCooker_RatioView_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pbStuffOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStuffTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStuffThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbStuffOne;
        private System.Windows.Forms.PictureBox pbStuffTwo;
        private System.Windows.Forms.PictureBox pbStuffThree;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Label lStuffs;
        private System.Windows.Forms.Label lRankName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lCloseRatio;
        private System.Windows.Forms.Label lFavCheck;
        private System.Windows.Forms.Label lRank;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer tiRatioView;
        private System.Windows.Forms.ToolTip DetailTooltip;
    }
}