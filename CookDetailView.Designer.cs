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
            this.pDisplayInfo = new System.Windows.Forms.Panel();
            this.lStuffThreePrice = new System.Windows.Forms.Label();
            this.lStuffTwoPrice = new System.Windows.Forms.Label();
            this.lStuffOnePrice = new System.Windows.Forms.Label();
            this.lStuffThree = new System.Windows.Forms.LinkLabel();
            this.lStuffTwo = new System.Windows.Forms.LinkLabel();
            this.lStuffOne = new System.Windows.Forms.LinkLabel();
            this.pAlertShowing = new System.Windows.Forms.Panel();
            this.lAlert = new System.Windows.Forms.Label();
            this.pDisplayCookName = new System.Windows.Forms.Panel();
            this.lCookName = new System.Windows.Forms.Label();
            this.pDisplayEffects = new System.Windows.Forms.Panel();
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
            this.pAlertShowing.SuspendLayout();
            this.pDisplayCookName.SuspendLayout();
            this.pDisplayEffects.SuspendLayout();
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
            this.pDisplayInfo.Controls.Add(this.pAlertShowing);
            this.pDisplayInfo.Controls.Add(this.pDisplayCookName);
            this.pDisplayInfo.Controls.Add(this.pDisplayEffects);
            this.pDisplayInfo.Controls.Add(this.lRank);
            this.pDisplayInfo.Location = new System.Drawing.Point(12, 12);
            this.pDisplayInfo.Name = "pDisplayInfo";
            this.pDisplayInfo.Size = new System.Drawing.Size(260, 120);
            this.pDisplayInfo.TabIndex = 0;
            // 
            // lStuffThreePrice
            // 
            this.lStuffThreePrice.AutoSize = true;
            this.lStuffThreePrice.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lStuffThreePrice.Location = new System.Drawing.Point(73, 76);
            this.lStuffThreePrice.Name = "lStuffThreePrice";
            this.lStuffThreePrice.Size = new System.Drawing.Size(38, 12);
            this.lStuffThreePrice.TabIndex = 6;
            this.lStuffThreePrice.Text = "label1";
            // 
            // lStuffTwoPrice
            // 
            this.lStuffTwoPrice.AutoSize = true;
            this.lStuffTwoPrice.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lStuffTwoPrice.Location = new System.Drawing.Point(73, 54);
            this.lStuffTwoPrice.Name = "lStuffTwoPrice";
            this.lStuffTwoPrice.Size = new System.Drawing.Size(38, 12);
            this.lStuffTwoPrice.TabIndex = 6;
            this.lStuffTwoPrice.Text = "label1";
            // 
            // lStuffOnePrice
            // 
            this.lStuffOnePrice.AutoSize = true;
            this.lStuffOnePrice.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lStuffOnePrice.Location = new System.Drawing.Point(73, 32);
            this.lStuffOnePrice.Name = "lStuffOnePrice";
            this.lStuffOnePrice.Size = new System.Drawing.Size(38, 12);
            this.lStuffOnePrice.TabIndex = 6;
            this.lStuffOnePrice.Text = "label1";
            // 
            // lStuffThree
            // 
            this.lStuffThree.AutoSize = true;
            this.lStuffThree.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lStuffThree.LinkArea = new System.Windows.Forms.LinkArea(0, 0);
            this.lStuffThree.LinkColor = System.Drawing.Color.Firebrick;
            this.lStuffThree.Location = new System.Drawing.Point(6, 76);
            this.lStuffThree.Name = "lStuffThree";
            this.lStuffThree.Size = new System.Drawing.Size(61, 12);
            this.lStuffThree.TabIndex = 5;
            this.lStuffThree.Text = "linkLabel1";
            this.lStuffThree.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lStuffThree_LinkClicked);
            this.lStuffThree.MouseHover += new System.EventHandler(this.lStuffThree_MouseHover);
            // 
            // lStuffTwo
            // 
            this.lStuffTwo.AutoSize = true;
            this.lStuffTwo.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lStuffTwo.LinkArea = new System.Windows.Forms.LinkArea(0, 0);
            this.lStuffTwo.LinkColor = System.Drawing.Color.Firebrick;
            this.lStuffTwo.Location = new System.Drawing.Point(6, 54);
            this.lStuffTwo.Name = "lStuffTwo";
            this.lStuffTwo.Size = new System.Drawing.Size(61, 12);
            this.lStuffTwo.TabIndex = 5;
            this.lStuffTwo.Text = "linkLabel1";
            this.lStuffTwo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lStuffTwo_LinkClicked);
            this.lStuffTwo.MouseHover += new System.EventHandler(this.lStuffTwo_MouseHover);
            // 
            // lStuffOne
            // 
            this.lStuffOne.AutoSize = true;
            this.lStuffOne.DisabledLinkColor = System.Drawing.SystemColors.ControlText;
            this.lStuffOne.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lStuffOne.LinkArea = new System.Windows.Forms.LinkArea(0, 0);
            this.lStuffOne.LinkColor = System.Drawing.Color.Firebrick;
            this.lStuffOne.Location = new System.Drawing.Point(6, 32);
            this.lStuffOne.Name = "lStuffOne";
            this.lStuffOne.Size = new System.Drawing.Size(61, 12);
            this.lStuffOne.TabIndex = 5;
            this.lStuffOne.Text = "linkLabel1";
            this.lStuffOne.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lStuffOne_LinkClicked);
            this.lStuffOne.MouseHover += new System.EventHandler(this.lStuffOne_MouseHover);
            // 
            // pAlertShowing
            // 
            this.pAlertShowing.BackColor = System.Drawing.Color.LimeGreen;
            this.pAlertShowing.Controls.Add(this.lAlert);
            this.pAlertShowing.Location = new System.Drawing.Point(-1, 94);
            this.pAlertShowing.Name = "pAlertShowing";
            this.pAlertShowing.Size = new System.Drawing.Size(260, 25);
            this.pAlertShowing.TabIndex = 3;
            this.pAlertShowing.Visible = false;
            // 
            // lAlert
            // 
            this.lAlert.AutoSize = true;
            this.lAlert.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lAlert.ForeColor = System.Drawing.Color.White;
            this.lAlert.Location = new System.Drawing.Point(7, 7);
            this.lAlert.Name = "lAlert";
            this.lAlert.Size = new System.Drawing.Size(44, 12);
            this.lAlert.TabIndex = 0;
            this.lAlert.Text = "label1";
            // 
            // pDisplayCookName
            // 
            this.pDisplayCookName.BackColor = System.Drawing.Color.Black;
            this.pDisplayCookName.Controls.Add(this.lCookName);
            this.pDisplayCookName.Location = new System.Drawing.Point(0, 0);
            this.pDisplayCookName.Name = "pDisplayCookName";
            this.pDisplayCookName.Size = new System.Drawing.Size(259, 25);
            this.pDisplayCookName.TabIndex = 3;
            // 
            // lCookName
            // 
            this.lCookName.AutoSize = true;
            this.lCookName.BackColor = System.Drawing.Color.Transparent;
            this.lCookName.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lCookName.ForeColor = System.Drawing.Color.White;
            this.lCookName.Location = new System.Drawing.Point(4, 5);
            this.lCookName.Name = "lCookName";
            this.lCookName.Size = new System.Drawing.Size(97, 16);
            this.lCookName.TabIndex = 0;
            this.lCookName.Text = "CookName";
            // 
            // pDisplayEffects
            // 
            this.pDisplayEffects.AutoSize = true;
            this.pDisplayEffects.BackColor = System.Drawing.Color.LightGray;
            this.pDisplayEffects.Controls.Add(this.lEffects);
            this.pDisplayEffects.Location = new System.Drawing.Point(-1, 94);
            this.pDisplayEffects.Name = "pDisplayEffects";
            this.pDisplayEffects.Size = new System.Drawing.Size(260, 25);
            this.pDisplayEffects.TabIndex = 4;
            // 
            // lEffects
            // 
            this.lEffects.AutoSize = true;
            this.lEffects.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lEffects.Location = new System.Drawing.Point(6, 7);
            this.lEffects.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lEffects.Name = "lEffects";
            this.lEffects.Size = new System.Drawing.Size(43, 12);
            this.lEffects.TabIndex = 1;
            this.lEffects.Text = "Effects";
            this.lEffects.SizeChanged += new System.EventHandler(this.lEffects_SizeChanged);
            // 
            // lRank
            // 
            this.lRank.AutoSize = true;
            this.lRank.BackColor = System.Drawing.Color.Transparent;
            this.lRank.Font = new System.Drawing.Font("Verdana", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRank.ForeColor = System.Drawing.Color.Silver;
            this.lRank.Location = new System.Drawing.Point(212, 57);
            this.lRank.Name = "lRank";
            this.lRank.Size = new System.Drawing.Size(47, 45);
            this.lRank.TabIndex = 2;
            this.lRank.Text = "P";
            // 
            // bDisplayRatio
            // 
            this.bDisplayRatio.Font = new System.Drawing.Font("Gulim", 9F);
            this.bDisplayRatio.Location = new System.Drawing.Point(10, 138);
            this.bDisplayRatio.Name = "bDisplayRatio";
            this.bDisplayRatio.Size = new System.Drawing.Size(23, 23);
            this.bDisplayRatio.TabIndex = 0;
            this.bDisplayRatio.Text = "♬";
            this.bDisplayRatio.UseVisualStyleBackColor = true;
            this.bDisplayRatio.Click += new System.EventHandler(this.bDisplayRatio_Click);
            this.bDisplayRatio.MouseHover += new System.EventHandler(this.bDisplayRatio_MouseHover);
            // 
            // bClose
            // 
            this.bClose.Font = new System.Drawing.Font("Gulim", 9F);
            this.bClose.Location = new System.Drawing.Point(222, 138);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(50, 23);
            this.bClose.TabIndex = 1;
            this.bClose.Text = "닫기";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // bModFav
            // 
            this.bModFav.Font = new System.Drawing.Font("Gulim", 9F);
            this.bModFav.Location = new System.Drawing.Point(38, 138);
            this.bModFav.Name = "bModFav";
            this.bModFav.Size = new System.Drawing.Size(23, 23);
            this.bModFav.TabIndex = 2;
            this.bModFav.Text = "★";
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
            this.toolTip1.ToolTipTitle = "재료 입수 방법";
            // 
            // bNext
            // 
            this.bNext.Enabled = false;
            this.bNext.Font = new System.Drawing.Font("Gulim", 9F);
            this.bNext.Location = new System.Drawing.Point(67, 138);
            this.bNext.Name = "bNext";
            this.bNext.Size = new System.Drawing.Size(23, 23);
            this.bNext.TabIndex = 2;
            this.bNext.Text = "▷";
            this.bNext.UseVisualStyleBackColor = true;
            this.bNext.Click += new System.EventHandler(this.bNext_Click);
            this.bNext.MouseHover += new System.EventHandler(this.bNext_MouseHover);
            // 
            // CookDetailView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 169);
            this.ControlBox = false;
            this.Controls.Add(this.bNext);
            this.Controls.Add(this.bModFav);
            this.Controls.Add(this.bDisplayRatio);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.pDisplayInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "CookDetailView";
            this.Text = "자세히 보기";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CookDetailView_FormClosed);
            this.pDisplayInfo.ResumeLayout(false);
            this.pDisplayInfo.PerformLayout();
            this.pAlertShowing.ResumeLayout(false);
            this.pAlertShowing.PerformLayout();
            this.pDisplayCookName.ResumeLayout(false);
            this.pDisplayCookName.PerformLayout();
            this.pDisplayEffects.ResumeLayout(false);
            this.pDisplayEffects.PerformLayout();
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