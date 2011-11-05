namespace MabiCooker2
{
    partial class CookDetailView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CookDetailView));
            this.pDisplayInfo = new System.Windows.Forms.Panel();
            this.lStuffThreePrice = new System.Windows.Forms.Label();
            this.lStuffTwoPrice = new System.Windows.Forms.Label();
            this.lStuffOnePrice = new System.Windows.Forms.Label();
            this.lStuffThree = new System.Windows.Forms.LinkLabel();
            this.lStuffTwo = new System.Windows.Forms.LinkLabel();
            this.lStuffOne = new System.Windows.Forms.LinkLabel();
            this.pDisplayCookName = new System.Windows.Forms.Panel();
            this.lCookName = new System.Windows.Forms.Label();
            this.pDisplayEffects = new System.Windows.Forms.Panel();
            this.pAlertShowing = new System.Windows.Forms.Panel();
            this.lAlert = new System.Windows.Forms.Label();
            this.lEffects = new System.Windows.Forms.Label();
            this.lRank = new System.Windows.Forms.Label();
            this.bDisplayRatio = new System.Windows.Forms.Button();
            this.bClose = new System.Windows.Forms.Button();
            this.bModFav = new System.Windows.Forms.Button();
            this.tiCheckAlert = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bNext = new System.Windows.Forms.Button();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.pDisplayInfo.SuspendLayout();
            this.pDisplayCookName.SuspendLayout();
            this.pDisplayEffects.SuspendLayout();
            this.pAlertShowing.SuspendLayout();
            this.SuspendLayout();
            // 
            // pDisplayInfo
            // 
            this.pDisplayInfo.BackColor = System.Drawing.SystemColors.Window;
            this.pDisplayInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pDisplayInfo.Controls.Add(this.lStuffThreePrice);
            this.pDisplayInfo.Controls.Add(this.lStuffTwoPrice);
            this.pDisplayInfo.Controls.Add(this.lStuffOnePrice);
            this.pDisplayInfo.Controls.Add(this.lStuffThree);
            this.pDisplayInfo.Controls.Add(this.lStuffTwo);
            this.pDisplayInfo.Controls.Add(this.lStuffOne);
            this.pDisplayInfo.Controls.Add(this.pDisplayCookName);
            this.pDisplayInfo.Controls.Add(this.pDisplayEffects);
            this.pDisplayInfo.Controls.Add(this.lRank);
            resources.ApplyResources(this.pDisplayInfo, "pDisplayInfo");
            this.pDisplayInfo.Name = "pDisplayInfo";
            // 
            // lStuffThreePrice
            // 
            resources.ApplyResources(this.lStuffThreePrice, "lStuffThreePrice");
            this.lStuffThreePrice.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lStuffThreePrice.Name = "lStuffThreePrice";
            // 
            // lStuffTwoPrice
            // 
            resources.ApplyResources(this.lStuffTwoPrice, "lStuffTwoPrice");
            this.lStuffTwoPrice.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lStuffTwoPrice.Name = "lStuffTwoPrice";
            // 
            // lStuffOnePrice
            // 
            resources.ApplyResources(this.lStuffOnePrice, "lStuffOnePrice");
            this.lStuffOnePrice.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lStuffOnePrice.Name = "lStuffOnePrice";
            // 
            // lStuffThree
            // 
            resources.ApplyResources(this.lStuffThree, "lStuffThree");
            this.lStuffThree.LinkColor = System.Drawing.Color.Firebrick;
            this.lStuffThree.Name = "lStuffThree";
            this.lStuffThree.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lStuffThree_LinkClicked);
            this.lStuffThree.MouseHover += new System.EventHandler(this.lStuffThree_MouseHover);
            // 
            // lStuffTwo
            // 
            resources.ApplyResources(this.lStuffTwo, "lStuffTwo");
            this.lStuffTwo.LinkColor = System.Drawing.Color.Firebrick;
            this.lStuffTwo.Name = "lStuffTwo";
            this.lStuffTwo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lStuffTwo_LinkClicked);
            this.lStuffTwo.MouseHover += new System.EventHandler(this.lStuffTwo_MouseHover);
            // 
            // lStuffOne
            // 
            resources.ApplyResources(this.lStuffOne, "lStuffOne");
            this.lStuffOne.DisabledLinkColor = System.Drawing.SystemColors.ControlText;
            this.lStuffOne.LinkColor = System.Drawing.Color.Firebrick;
            this.lStuffOne.Name = "lStuffOne";
            this.lStuffOne.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lStuffOne_LinkClicked);
            this.lStuffOne.MouseHover += new System.EventHandler(this.lStuffOne_MouseHover);
            // 
            // pDisplayCookName
            // 
            this.pDisplayCookName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pDisplayCookName.Controls.Add(this.lCookName);
            resources.ApplyResources(this.pDisplayCookName, "pDisplayCookName");
            this.pDisplayCookName.Name = "pDisplayCookName";
            // 
            // lCookName
            // 
            resources.ApplyResources(this.lCookName, "lCookName");
            this.lCookName.BackColor = System.Drawing.Color.Transparent;
            this.lCookName.ForeColor = System.Drawing.Color.White;
            this.lCookName.Name = "lCookName";
            // 
            // pDisplayEffects
            // 
            resources.ApplyResources(this.pDisplayEffects, "pDisplayEffects");
            this.pDisplayEffects.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pDisplayEffects.Controls.Add(this.pAlertShowing);
            this.pDisplayEffects.Controls.Add(this.lEffects);
            this.pDisplayEffects.Name = "pDisplayEffects";
            // 
            // pAlertShowing
            // 
            this.pAlertShowing.BackColor = System.Drawing.SystemColors.Highlight;
            this.pAlertShowing.Controls.Add(this.lAlert);
            resources.ApplyResources(this.pAlertShowing, "pAlertShowing");
            this.pAlertShowing.Name = "pAlertShowing";
            // 
            // lAlert
            // 
            resources.ApplyResources(this.lAlert, "lAlert");
            this.lAlert.ForeColor = System.Drawing.Color.White;
            this.lAlert.Name = "lAlert";
            // 
            // lEffects
            // 
            resources.ApplyResources(this.lEffects, "lEffects");
            this.lEffects.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lEffects.Name = "lEffects";
            this.lEffects.SizeChanged += new System.EventHandler(this.lEffects_SizeChanged);
            // 
            // lRank
            // 
            resources.ApplyResources(this.lRank, "lRank");
            this.lRank.BackColor = System.Drawing.Color.Transparent;
            this.lRank.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lRank.Name = "lRank";
            // 
            // bDisplayRatio
            // 
            resources.ApplyResources(this.bDisplayRatio, "bDisplayRatio");
            this.bDisplayRatio.Name = "bDisplayRatio";
            this.bDisplayRatio.UseVisualStyleBackColor = true;
            this.bDisplayRatio.Click += new System.EventHandler(this.bDisplayRatio_Click);
            this.bDisplayRatio.MouseHover += new System.EventHandler(this.bDisplayRatio_MouseHover);
            // 
            // bClose
            // 
            this.bClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.bClose, "bClose");
            this.bClose.Name = "bClose";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // bModFav
            // 
            resources.ApplyResources(this.bModFav, "bModFav");
            this.bModFav.Name = "bModFav";
            this.bModFav.UseVisualStyleBackColor = true;
            this.bModFav.Click += new System.EventHandler(this.bModFav_Click);
            this.bModFav.MouseHover += new System.EventHandler(this.bModFav_MouseHover);
            // 
            // tiCheckAlert
            // 
            this.tiCheckAlert.Interval = 1500;
            this.tiCheckAlert.Tick += new System.EventHandler(this.tiCheckAlert_Tick);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "材料の入手方法";
            // 
            // bNext
            // 
            resources.ApplyResources(this.bNext, "bNext");
            this.bNext.Name = "bNext";
            this.bNext.UseVisualStyleBackColor = true;
            this.bNext.Click += new System.EventHandler(this.bNext_Click);
            this.bNext.MouseHover += new System.EventHandler(this.bNext_MouseHover);
            // 
            // CookDetailView
            // 
            this.AcceptButton = this.bDisplayRatio;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bClose;
            this.ControlBox = false;
            this.Controls.Add(this.bNext);
            this.Controls.Add(this.bModFav);
            this.Controls.Add(this.bDisplayRatio);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.pDisplayInfo);
            this.MaximizeBox = false;
            this.Name = "CookDetailView";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CookDetailView_FormClosed);
            this.pDisplayInfo.ResumeLayout(false);
            this.pDisplayInfo.PerformLayout();
            this.pDisplayCookName.ResumeLayout(false);
            this.pDisplayCookName.PerformLayout();
            this.pDisplayEffects.ResumeLayout(false);
            this.pDisplayEffects.PerformLayout();
            this.pAlertShowing.ResumeLayout(false);
            this.pAlertShowing.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pDisplayInfo;
        private System.Windows.Forms.Button bDisplayRatio;
        private System.Windows.Forms.Label lEffects;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Panel pDisplayCookName;
        private System.Windows.Forms.Label lCookName;
        private System.Windows.Forms.Panel pDisplayEffects;
        private System.Windows.Forms.Label lRank;
        private System.Windows.Forms.Button bModFav;
        private System.Windows.Forms.Timer tiCheckAlert;
        private System.Windows.Forms.Panel pAlertShowing;
        private System.Windows.Forms.Label lAlert;
        private System.Windows.Forms.LinkLabel lStuffThree;
        private System.Windows.Forms.LinkLabel lStuffTwo;
        private System.Windows.Forms.LinkLabel lStuffOne;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button bNext;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.Label lStuffThreePrice;
        private System.Windows.Forms.Label lStuffTwoPrice;
        private System.Windows.Forms.Label lStuffOnePrice;
    }
}