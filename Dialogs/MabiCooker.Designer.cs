namespace MabiCooker2
{
    partial class MabiCooker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MabiCooker));
            this.bDetailView = new System.Windows.Forms.Button();
            this.tcMainCtrl = new System.Windows.Forms.TabControl();
            this.tpRank = new System.Windows.Forms.TabPage();
            this.lbRankResult = new System.Windows.Forms.ListBox();
            this.cbRankSelector = new System.Windows.Forms.ComboBox();
            this.tpSearch = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.rbForName = new System.Windows.Forms.RadioButton();
            this.rbForStuff = new System.Windows.Forms.RadioButton();
            this.rbForEffect = new System.Windows.Forms.RadioButton();
            this.tlPrevSearch = new System.Windows.Forms.TableLayoutPanel();
            this.lPrevSearch_1 = new System.Windows.Forms.Label();
            this.lPrevSearch_2 = new System.Windows.Forms.Label();
            this.lbSearchResult = new System.Windows.Forms.ListBox();
            this.bSearchStart = new System.Windows.Forms.Button();
            this.tbSearchTerm = new System.Windows.Forms.TextBox();
            this.tpFav = new System.Windows.Forms.TabPage();
            this.tlNoneFav = new System.Windows.Forms.TableLayoutPanel();
            this.lNoneFav_1 = new System.Windows.Forms.Label();
            this.lNoneFav_2 = new System.Windows.Forms.Label();
            this.lbFavResult = new System.Windows.Forms.ListBox();
            this.bPrintRatio = new System.Windows.Forms.Button();
            this.lVersion = new System.Windows.Forms.Label();
            this.lCopyright = new System.Windows.Forms.LinkLabel();
            this.lCopyrites = new System.Windows.Forms.LinkLabel();
            this.tcMainCtrl.SuspendLayout();
            this.tpRank.SuspendLayout();
            this.tpSearch.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tlPrevSearch.SuspendLayout();
            this.tpFav.SuspendLayout();
            this.tlNoneFav.SuspendLayout();
            this.SuspendLayout();
            // 
            // bDetailView
            // 
            resources.ApplyResources(this.bDetailView, "bDetailView");
            this.bDetailView.Name = "bDetailView";
            this.bDetailView.UseVisualStyleBackColor = true;
            this.bDetailView.Click += new System.EventHandler(this.bDetailView_Click);
            // 
            // tcMainCtrl
            // 
            this.tcMainCtrl.Controls.Add(this.tpRank);
            this.tcMainCtrl.Controls.Add(this.tpSearch);
            this.tcMainCtrl.Controls.Add(this.tpFav);
            resources.ApplyResources(this.tcMainCtrl, "tcMainCtrl");
            this.tcMainCtrl.Name = "tcMainCtrl";
            this.tcMainCtrl.SelectedIndex = 0;
            this.tcMainCtrl.SelectedIndexChanged += new System.EventHandler(this.tcMainCtrl_SelectedIndexChanged);
            // 
            // tpRank
            // 
            this.tpRank.BackColor = System.Drawing.SystemColors.Control;
            this.tpRank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpRank.Controls.Add(this.lbRankResult);
            this.tpRank.Controls.Add(this.cbRankSelector);
            this.tpRank.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.tpRank, "tpRank");
            this.tpRank.Name = "tpRank";
            // 
            // lbRankResult
            // 
            resources.ApplyResources(this.lbRankResult, "lbRankResult");
            this.lbRankResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbRankResult.FormattingEnabled = true;
            this.lbRankResult.Name = "lbRankResult";
            this.lbRankResult.SelectedIndexChanged += new System.EventHandler(this.lbRankResult_SelectedIndexChanged);
            this.lbRankResult.VisibleChanged += new System.EventHandler(this.lbRankResult_VisibleChanged);
            this.lbRankResult.DoubleClick += new System.EventHandler(this.lbRankResult_DoubleClick);
            // 
            // cbRankSelector
            // 
            resources.ApplyResources(this.cbRankSelector, "cbRankSelector");
            this.cbRankSelector.BackColor = System.Drawing.Color.White;
            this.cbRankSelector.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cbRankSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRankSelector.ForeColor = System.Drawing.Color.Black;
            this.cbRankSelector.FormattingEnabled = true;
            this.cbRankSelector.Items.AddRange(new object[] {
            resources.GetString("cbRankSelector.Items"),
            resources.GetString("cbRankSelector.Items1"),
            resources.GetString("cbRankSelector.Items2"),
            resources.GetString("cbRankSelector.Items3"),
            resources.GetString("cbRankSelector.Items4"),
            resources.GetString("cbRankSelector.Items5"),
            resources.GetString("cbRankSelector.Items6"),
            resources.GetString("cbRankSelector.Items7"),
            resources.GetString("cbRankSelector.Items8"),
            resources.GetString("cbRankSelector.Items9"),
            resources.GetString("cbRankSelector.Items10")});
            this.cbRankSelector.Name = "cbRankSelector";
            this.cbRankSelector.SelectedIndexChanged += new System.EventHandler(this.cbRankSelector_SelectedIndexChanged);
            // 
            // tpSearch
            // 
            this.tpSearch.BackColor = System.Drawing.SystemColors.Control;
            this.tpSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpSearch.Controls.Add(this.flowLayoutPanel1);
            this.tpSearch.Controls.Add(this.tlPrevSearch);
            this.tpSearch.Controls.Add(this.lbSearchResult);
            this.tpSearch.Controls.Add(this.bSearchStart);
            this.tpSearch.Controls.Add(this.tbSearchTerm);
            this.tpSearch.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.tpSearch, "tpSearch");
            this.tpSearch.Name = "tpSearch";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.rbForName);
            this.flowLayoutPanel1.Controls.Add(this.rbForStuff);
            this.flowLayoutPanel1.Controls.Add(this.rbForEffect);
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // rbForName
            // 
            resources.ApplyResources(this.rbForName, "rbForName");
            this.rbForName.Checked = true;
            this.rbForName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbForName.Name = "rbForName";
            this.rbForName.TabStop = true;
            this.rbForName.UseVisualStyleBackColor = true;
            // 
            // rbForStuff
            // 
            resources.ApplyResources(this.rbForStuff, "rbForStuff");
            this.rbForStuff.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbForStuff.Name = "rbForStuff";
            this.rbForStuff.UseVisualStyleBackColor = true;
            // 
            // rbForEffect
            // 
            resources.ApplyResources(this.rbForEffect, "rbForEffect");
            this.rbForEffect.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbForEffect.Name = "rbForEffect";
            this.rbForEffect.UseVisualStyleBackColor = false;
            // 
            // tlPrevSearch
            // 
            this.tlPrevSearch.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.tlPrevSearch, "tlPrevSearch");
            this.tlPrevSearch.Controls.Add(this.lPrevSearch_1, 0, 0);
            this.tlPrevSearch.Controls.Add(this.lPrevSearch_2, 0, 1);
            this.tlPrevSearch.Name = "tlPrevSearch";
            // 
            // lPrevSearch_1
            // 
            this.lPrevSearch_1.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.lPrevSearch_1, "lPrevSearch_1");
            this.lPrevSearch_1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lPrevSearch_1.Name = "lPrevSearch_1";
            // 
            // lPrevSearch_2
            // 
            this.lPrevSearch_2.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.lPrevSearch_2, "lPrevSearch_2");
            this.lPrevSearch_2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lPrevSearch_2.Name = "lPrevSearch_2";
            // 
            // lbSearchResult
            // 
            this.lbSearchResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbSearchResult.FormattingEnabled = true;
            resources.ApplyResources(this.lbSearchResult, "lbSearchResult");
            this.lbSearchResult.Name = "lbSearchResult";
            this.lbSearchResult.SelectedIndexChanged += new System.EventHandler(this.lbSearchResult_SelectedIndexChanged);
            this.lbSearchResult.VisibleChanged += new System.EventHandler(this.lbSearchResult_VisibleChanged);
            this.lbSearchResult.DoubleClick += new System.EventHandler(this.lbSearchResult_DoubleClick);
            // 
            // bSearchStart
            // 
            this.bSearchStart.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bSearchStart.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            resources.ApplyResources(this.bSearchStart, "bSearchStart");
            this.bSearchStart.Image = global::MabiCooker2.Properties.Resources.Search;
            this.bSearchStart.Name = "bSearchStart";
            this.bSearchStart.UseVisualStyleBackColor = false;
            this.bSearchStart.Click += new System.EventHandler(this.bSearchStart_Click);
            // 
            // tbSearchTerm
            // 
            this.tbSearchTerm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.tbSearchTerm, "tbSearchTerm");
            this.tbSearchTerm.Name = "tbSearchTerm";
            this.tbSearchTerm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSearchTerm_KeyDown);
            // 
            // tpFav
            // 
            this.tpFav.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpFav.Controls.Add(this.tlNoneFav);
            this.tpFav.Controls.Add(this.lbFavResult);
            this.tpFav.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.tpFav, "tpFav");
            this.tpFav.Name = "tpFav";
            // 
            // tlNoneFav
            // 
            resources.ApplyResources(this.tlNoneFav, "tlNoneFav");
            this.tlNoneFav.BackColor = System.Drawing.Color.White;
            this.tlNoneFav.Controls.Add(this.lNoneFav_1, 0, 0);
            this.tlNoneFav.Controls.Add(this.lNoneFav_2, 0, 1);
            this.tlNoneFav.Name = "tlNoneFav";
            // 
            // lNoneFav_1
            // 
            this.lNoneFav_1.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.lNoneFav_1, "lNoneFav_1");
            this.lNoneFav_1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lNoneFav_1.Name = "lNoneFav_1";
            // 
            // lNoneFav_2
            // 
            this.lNoneFav_2.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.lNoneFav_2, "lNoneFav_2");
            this.lNoneFav_2.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.lNoneFav_2.Name = "lNoneFav_2";
            // 
            // lbFavResult
            // 
            this.lbFavResult.AllowDrop = true;
            resources.ApplyResources(this.lbFavResult, "lbFavResult");
            this.lbFavResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbFavResult.FormattingEnabled = true;
            this.lbFavResult.Name = "lbFavResult";
            this.lbFavResult.SelectedIndexChanged += new System.EventHandler(this.lbFavResult_SelectedIndexChanged);
            this.lbFavResult.DoubleClick += new System.EventHandler(this.lbFavResult_DoubleClick);
            this.lbFavResult.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbFavResult_KeyDown);
            // 
            // bPrintRatio
            // 
            resources.ApplyResources(this.bPrintRatio, "bPrintRatio");
            this.bPrintRatio.Name = "bPrintRatio";
            this.bPrintRatio.UseVisualStyleBackColor = true;
            this.bPrintRatio.Click += new System.EventHandler(this.bPrintRatio_Click);
            // 
            // lVersion
            // 
            resources.ApplyResources(this.lVersion, "lVersion");
            this.lVersion.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lVersion.Name = "lVersion";
            // 
            // lCopyright
            // 
            this.lCopyright.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            resources.ApplyResources(this.lCopyright, "lCopyright");
            this.lCopyright.Name = "lCopyright";
            this.lCopyright.TabStop = true;
            this.lCopyright.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lCopyrites_LinkClicked);
            // 
            // lCopyrites
            // 
            resources.ApplyResources(this.lCopyrites, "lCopyrites");
            this.lCopyrites.Name = "lCopyrites";
            this.lCopyrites.TabStop = true;
            // 
            // MabiCooker
            // 
            this.AcceptButton = this.bSearchStart;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lCopyrites);
            this.Controls.Add(this.lCopyright);
            this.Controls.Add(this.lVersion);
            this.Controls.Add(this.tcMainCtrl);
            this.Controls.Add(this.bDetailView);
            this.Controls.Add(this.bPrintRatio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MabiCooker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MabiCooker_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MabiCooker_FormClosed);
            this.tcMainCtrl.ResumeLayout(false);
            this.tpRank.ResumeLayout(false);
            this.tpSearch.ResumeLayout(false);
            this.tpSearch.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tlPrevSearch.ResumeLayout(false);
            this.tpFav.ResumeLayout(false);
            this.tlNoneFav.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bDetailView;
        private System.Windows.Forms.TabControl tcMainCtrl;
        private System.Windows.Forms.TabPage tpRank;
        private System.Windows.Forms.TabPage tpSearch;
        private System.Windows.Forms.ListBox lbRankResult;
        private System.Windows.Forms.ComboBox cbRankSelector;
        private System.Windows.Forms.TabPage tpFav;
        private System.Windows.Forms.ListBox lbSearchResult;
        private System.Windows.Forms.TextBox tbSearchTerm;
        private System.Windows.Forms.ListBox lbFavResult;
        private System.Windows.Forms.Button bSearchStart;
        private System.Windows.Forms.RadioButton rbForStuff;
        private System.Windows.Forms.RadioButton rbForName;
        private System.Windows.Forms.Button bPrintRatio;
        private System.Windows.Forms.Label lVersion;
        private System.Windows.Forms.LinkLabel lCopyright;
        private System.Windows.Forms.Label lNoneFav_1;
        private System.Windows.Forms.Label lNoneFav_2;
        private System.Windows.Forms.Label lPrevSearch_1;
        private System.Windows.Forms.Label lPrevSearch_2;
        private System.Windows.Forms.RadioButton rbForEffect;
        private System.Windows.Forms.LinkLabel lCopyrites;
        private System.Windows.Forms.TableLayoutPanel tlPrevSearch;
        private System.Windows.Forms.TableLayoutPanel tlNoneFav;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

