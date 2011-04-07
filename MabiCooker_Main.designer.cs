namespace MabiCooker
{
    partial class MabiCooker_Main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MabiCooker_Main));
            this.status_text = new System.Windows.Forms.Label();
            this.creator = new System.Windows.Forms.Label();
            this.RankSelect = new System.Windows.Forms.ComboBox();
            this.ShowRatioBar = new System.Windows.Forms.Button();
            this.CookList = new System.Windows.Forms.ListBox();
            this.ShowCookInfo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CooksEffect = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Ingredent_No3 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Ingredent_No2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Ingredent_No1 = new System.Windows.Forms.Label();
            this.CookName = new System.Windows.Forms.Label();
            this.CookFindString = new System.Windows.Forms.TextBox();
            this.CookPreviewPanel = new System.Windows.Forms.Panel();
            this.NoneResult = new System.Windows.Forms.Label();
            this.CloseFindResult = new System.Windows.Forms.LinkLabel();
            this.PrevLink = new System.Windows.Forms.LinkLabel();
            this.NextLink = new System.Windows.Forms.LinkLabel();
            this.FindedCook3 = new System.Windows.Forms.LinkLabel();
            this.FindedCook4 = new System.Windows.Forms.LinkLabel();
            this.FindedCook2 = new System.Windows.Forms.LinkLabel();
            this.FindedCook1 = new System.Windows.Forms.LinkLabel();
            this.ShowCookInfo.SuspendLayout();
            this.CookPreviewPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // status_text
            // 
            this.status_text.AutoSize = true;
            this.status_text.Font = new System.Drawing.Font("맑은 고딕", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.status_text.Location = new System.Drawing.Point(10, 228);
            this.status_text.Name = "status_text";
            this.status_text.Size = new System.Drawing.Size(61, 13);
            this.status_text.TabIndex = 0;
            this.status_text.Text = "status_text";
            this.status_text.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // creator
            // 
            this.creator.AutoSize = true;
            this.creator.Enabled = false;
            this.creator.Font = new System.Drawing.Font("맑은 고딕", 8F);
            this.creator.Location = new System.Drawing.Point(413, 228);
            this.creator.Name = "creator";
            this.creator.Size = new System.Drawing.Size(99, 13);
            this.creator.TabIndex = 1;
            this.creator.Text = "Created by DeHol";
            this.creator.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RankSelect
            // 
            this.RankSelect.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.RankSelect.FormattingEnabled = true;
            this.RankSelect.Items.AddRange(new object[] {
            "요리 연습랭크 (혼합)",
            "요리 F랭크 (굽기)",
            "요리 E랭크 (삶기)",
            "요리 D랭크 (반죽 만들기)",
            "요리 C랭크 (끓이기)",
            "요리 B랭크 (면 만들기)",
            "요리 A랭크 (튀기기)",
            "요리 9랭크 (볶기)",
            "요리 8랭크 (파스타 만들기)"});
            this.RankSelect.Location = new System.Drawing.Point(12, 12);
            this.RankSelect.Name = "RankSelect";
            this.RankSelect.Size = new System.Drawing.Size(175, 23);
            this.RankSelect.TabIndex = 2;
            this.RankSelect.Text = "==== 요리랭크 선택 ====";
            this.RankSelect.SelectedIndexChanged += new System.EventHandler(this.RankSelect_SelectedIndexChanged);
            // 
            // ShowRatioBar
            // 
            this.ShowRatioBar.Enabled = false;
            this.ShowRatioBar.Location = new System.Drawing.Point(13, 187);
            this.ShowRatioBar.Name = "ShowRatioBar";
            this.ShowRatioBar.Size = new System.Drawing.Size(174, 29);
            this.ShowRatioBar.TabIndex = 3;
            this.ShowRatioBar.Text = "요리 비율 출력";
            this.ShowRatioBar.UseVisualStyleBackColor = true;
            this.ShowRatioBar.Click += new System.EventHandler(this.ShowRatioBar_Click);
            // 
            // CookList
            // 
            this.CookList.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CookList.FormattingEnabled = true;
            this.CookList.ItemHeight = 15;
            this.CookList.Location = new System.Drawing.Point(13, 42);
            this.CookList.Name = "CookList";
            this.CookList.Size = new System.Drawing.Size(174, 139);
            this.CookList.TabIndex = 5;
            this.CookList.SelectedIndexChanged += new System.EventHandler(this.CookList_SelectedIndexChanged);
            // 
            // ShowCookInfo
            // 
            this.ShowCookInfo.BackColor = System.Drawing.SystemColors.Window;
            this.ShowCookInfo.Controls.Add(this.label1);
            this.ShowCookInfo.Controls.Add(this.label5);
            this.ShowCookInfo.Controls.Add(this.CooksEffect);
            this.ShowCookInfo.Controls.Add(this.label4);
            this.ShowCookInfo.Controls.Add(this.Ingredent_No3);
            this.ShowCookInfo.Controls.Add(this.label3);
            this.ShowCookInfo.Controls.Add(this.Ingredent_No2);
            this.ShowCookInfo.Controls.Add(this.label2);
            this.ShowCookInfo.Controls.Add(this.Ingredent_No1);
            this.ShowCookInfo.Controls.Add(this.CookName);
            this.ShowCookInfo.Location = new System.Drawing.Point(193, 42);
            this.ShowCookInfo.Name = "ShowCookInfo";
            this.ShowCookInfo.Padding = new System.Windows.Forms.Padding(10);
            this.ShowCookInfo.Size = new System.Drawing.Size(320, 174);
            this.ShowCookInfo.TabIndex = 8;
            this.ShowCookInfo.MouseHover += new System.EventHandler(this.ShowCookInfo_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(14, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "마비노기 요리 도우미";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(13, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(238, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "공식 홈페이지 : http://mabicooker.dehol.kr";
            // 
            // CooksEffect
            // 
            this.CooksEffect.AutoSize = true;
            this.CooksEffect.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CooksEffect.Location = new System.Drawing.Point(13, 124);
            this.CooksEffect.Name = "CooksEffect";
            this.CooksEffect.Size = new System.Drawing.Size(229, 15);
            this.CooksEffect.TabIndex = 2;
            this.CooksEffect.Text = "공식 홈페이지 : http://cooking.dehol.info";
            this.CooksEffect.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(13, 99);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "일체 하지 않으니 안심하고 사용하세요. ^^";
            // 
            // Ingredent_No3
            // 
            this.Ingredent_No3.AutoSize = true;
            this.Ingredent_No3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Ingredent_No3.Location = new System.Drawing.Point(13, 99);
            this.Ingredent_No3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.Ingredent_No3.Name = "Ingredent_No3";
            this.Ingredent_No3.Size = new System.Drawing.Size(238, 15);
            this.Ingredent_No3.TabIndex = 1;
            this.Ingredent_No3.Text = "일체 하지 않으니 안심하고 사용하세요. ^^";
            this.Ingredent_No3.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(13, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(282, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "프로그램 입니다. 클라이언트 변조나 메모리 변조는";
            // 
            // Ingredent_No2
            // 
            this.Ingredent_No2.AutoSize = true;
            this.Ingredent_No2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Ingredent_No2.Location = new System.Drawing.Point(13, 74);
            this.Ingredent_No2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.Ingredent_No2.Name = "Ingredent_No2";
            this.Ingredent_No2.Size = new System.Drawing.Size(282, 15);
            this.Ingredent_No2.TabIndex = 1;
            this.Ingredent_No2.Text = "프로그램 입니다. 클라이언트 변조나 메모리 변조는";
            this.Ingredent_No2.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(13, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "이 프로그램은 마비노기 요리스킬을 위한 도우미";
            // 
            // Ingredent_No1
            // 
            this.Ingredent_No1.AutoSize = true;
            this.Ingredent_No1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Ingredent_No1.Location = new System.Drawing.Point(13, 49);
            this.Ingredent_No1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.Ingredent_No1.Name = "Ingredent_No1";
            this.Ingredent_No1.Size = new System.Drawing.Size(267, 15);
            this.Ingredent_No1.TabIndex = 1;
            this.Ingredent_No1.Text = "이 프로그램은 마비노기 요리스킬을 위한 도우미";
            this.Ingredent_No1.Visible = false;
            // 
            // CookName
            // 
            this.CookName.AutoSize = true;
            this.CookName.Font = new System.Drawing.Font("맑은 고딕", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CookName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CookName.Location = new System.Drawing.Point(14, 14);
            this.CookName.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.CookName.Name = "CookName";
            this.CookName.Size = new System.Drawing.Size(166, 21);
            this.CookName.TabIndex = 0;
            this.CookName.Text = "마비노기 요리 도우미";
            this.CookName.Visible = false;
            // 
            // CookFindString
            // 
            this.CookFindString.Location = new System.Drawing.Point(311, 13);
            this.CookFindString.Name = "CookFindString";
            this.CookFindString.Size = new System.Drawing.Size(201, 22);
            this.CookFindString.TabIndex = 10;
            this.CookFindString.Text = "요리 이름으로 검색하세요";
            this.CookFindString.TextChanged += new System.EventHandler(this.CookFindString_TextChanged);
            this.CookFindString.Click += new System.EventHandler(this.CookFindString_Click);
            this.CookFindString.Leave += new System.EventHandler(this.CookFindString_Leave);
            // 
            // CookPreviewPanel
            // 
            this.CookPreviewPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CookPreviewPanel.Controls.Add(this.NoneResult);
            this.CookPreviewPanel.Controls.Add(this.CloseFindResult);
            this.CookPreviewPanel.Controls.Add(this.PrevLink);
            this.CookPreviewPanel.Controls.Add(this.NextLink);
            this.CookPreviewPanel.Controls.Add(this.FindedCook3);
            this.CookPreviewPanel.Controls.Add(this.FindedCook4);
            this.CookPreviewPanel.Controls.Add(this.FindedCook2);
            this.CookPreviewPanel.Controls.Add(this.FindedCook1);
            this.CookPreviewPanel.Location = new System.Drawing.Point(311, 38);
            this.CookPreviewPanel.Name = "CookPreviewPanel";
            this.CookPreviewPanel.Padding = new System.Windows.Forms.Padding(5);
            this.CookPreviewPanel.Size = new System.Drawing.Size(201, 154);
            this.CookPreviewPanel.TabIndex = 11;
            this.CookPreviewPanel.Visible = false;
            // 
            // NoneResult
            // 
            this.NoneResult.AutoSize = true;
            this.NoneResult.Location = new System.Drawing.Point(8, 13);
            this.NoneResult.Margin = new System.Windows.Forms.Padding(5);
            this.NoneResult.Name = "NoneResult";
            this.NoneResult.Size = new System.Drawing.Size(127, 13);
            this.NoneResult.TabIndex = 5;
            this.NoneResult.Text = "검색된 결과가 없습니다.";
            // 
            // CloseFindResult
            // 
            this.CloseFindResult.AutoSize = true;
            this.CloseFindResult.Location = new System.Drawing.Point(10, 129);
            this.CloseFindResult.Name = "CloseFindResult";
            this.CloseFindResult.Size = new System.Drawing.Size(29, 13);
            this.CloseFindResult.TabIndex = 4;
            this.CloseFindResult.TabStop = true;
            this.CloseFindResult.Text = "닫기";
            this.CloseFindResult.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CloseFindResult_LinkClicked);
            // 
            // PrevLink
            // 
            this.PrevLink.AutoSize = true;
            this.PrevLink.Location = new System.Drawing.Point(129, 129);
            this.PrevLink.Name = "PrevLink";
            this.PrevLink.Size = new System.Drawing.Size(28, 13);
            this.PrevLink.TabIndex = 3;
            this.PrevLink.TabStop = true;
            this.PrevLink.Text = "Prev";
            this.PrevLink.Visible = false;
            this.PrevLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.PrevLink_LinkClicked);
            // 
            // NextLink
            // 
            this.NextLink.AutoSize = true;
            this.NextLink.Location = new System.Drawing.Point(161, 129);
            this.NextLink.Name = "NextLink";
            this.NextLink.Size = new System.Drawing.Size(30, 13);
            this.NextLink.TabIndex = 2;
            this.NextLink.TabStop = true;
            this.NextLink.Text = "Next";
            this.NextLink.Visible = false;
            this.NextLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.NextLink_LinkClicked);
            // 
            // FindedCook3
            // 
            this.FindedCook3.AutoSize = true;
            this.FindedCook3.Location = new System.Drawing.Point(10, 82);
            this.FindedCook3.Margin = new System.Windows.Forms.Padding(5);
            this.FindedCook3.Name = "FindedCook3";
            this.FindedCook3.Size = new System.Drawing.Size(58, 13);
            this.FindedCook3.TabIndex = 1;
            this.FindedCook3.TabStop = true;
            this.FindedCook3.Text = "linkLabel3";
            this.FindedCook3.Visible = false;
            this.FindedCook3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.FindedCook3_LinkClicked);
            // 
            // FindedCook4
            // 
            this.FindedCook4.AutoSize = true;
            this.FindedCook4.Location = new System.Drawing.Point(10, 105);
            this.FindedCook4.Margin = new System.Windows.Forms.Padding(5);
            this.FindedCook4.Name = "FindedCook4";
            this.FindedCook4.Size = new System.Drawing.Size(58, 13);
            this.FindedCook4.TabIndex = 1;
            this.FindedCook4.TabStop = true;
            this.FindedCook4.Text = "linkLabel4";
            this.FindedCook4.Visible = false;
            this.FindedCook4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.FindedCook4_LinkClicked);
            // 
            // FindedCook2
            // 
            this.FindedCook2.AutoSize = true;
            this.FindedCook2.Location = new System.Drawing.Point(10, 59);
            this.FindedCook2.Margin = new System.Windows.Forms.Padding(5);
            this.FindedCook2.Name = "FindedCook2";
            this.FindedCook2.Size = new System.Drawing.Size(58, 13);
            this.FindedCook2.TabIndex = 1;
            this.FindedCook2.TabStop = true;
            this.FindedCook2.Text = "linkLabel2";
            this.FindedCook2.Visible = false;
            this.FindedCook2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.FindedCook2_LinkClicked);
            // 
            // FindedCook1
            // 
            this.FindedCook1.AutoSize = true;
            this.FindedCook1.Location = new System.Drawing.Point(10, 36);
            this.FindedCook1.Margin = new System.Windows.Forms.Padding(5);
            this.FindedCook1.Name = "FindedCook1";
            this.FindedCook1.Size = new System.Drawing.Size(58, 13);
            this.FindedCook1.TabIndex = 1;
            this.FindedCook1.TabStop = true;
            this.FindedCook1.Text = "linkLabel1";
            this.FindedCook1.Visible = false;
            this.FindedCook1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.FindedCook1_LinkClicked);
            // 
            // MabiCooker_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 253);
            this.Controls.Add(this.CookPreviewPanel);
            this.Controls.Add(this.CookFindString);
            this.Controls.Add(this.ShowCookInfo);
            this.Controls.Add(this.CookList);
            this.Controls.Add(this.ShowRatioBar);
            this.Controls.Add(this.RankSelect);
            this.Controls.Add(this.creator);
            this.Controls.Add(this.status_text);
            this.Font = new System.Drawing.Font("맑은 고딕", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MabiCooker_Main";
            this.Text = "MabiCooker v1.1.0";
            this.Load += new System.EventHandler(this.MabiCooker_Main_Load);
            this.ShowCookInfo.ResumeLayout(false);
            this.ShowCookInfo.PerformLayout();
            this.CookPreviewPanel.ResumeLayout(false);
            this.CookPreviewPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
       
        public void status_change(int status)
        {
            switch (status)
            {
                case 0: // 준비 완료
                    this.status_text.Text = "준비 완료";
                    break;
                case 1: // 데이터 로드중
                    this.status_text.Text = "데이터를 불러오는 중입니다.";
                    break;
                case 2: // 데이터 로드 실패
                    this.status_text.Text = "데이터 로드에 실패하였습니다. 재시작 해보세요.";
                    break;
            }
        }
        public void status_change(int status, int debug)
        {
            switch (status)
            {
                case 0: // 준비 완료
                    this.status_text.Text = "준비 완료" + debug;
                    break;
                case 1: // 데이터 로드중
                    this.status_text.Text = "데이터를 불러오는 중입니다." + debug;
                    break;
                case 2: // 데이터 로드 실패
                    this.status_text.Text = "데이터 로드에 실패하였습니다. 재시작 해보세요." + debug;
                    break;
            }
        }
        public int WhatRankSelected()
        {
            return RankSelect.SelectedIndex;
        }
        public int WhatCookSelected()
        {
            return CookList.SelectedIndex;
        }
        
        private System.Windows.Forms.Label status_text;
        private System.Windows.Forms.Label creator;
        private System.Windows.Forms.ListBox CookList;
        private System.Windows.Forms.ComboBox RankSelect;
        private System.Windows.Forms.Button ShowRatioBar;
        private System.Windows.Forms.Label CooksEffect;
        private System.Windows.Forms.Panel ShowCookInfo;
        private System.Windows.Forms.Label CookName;
        private System.Windows.Forms.Label Ingredent_No1;
        private System.Windows.Forms.Label Ingredent_No3;
        private System.Windows.Forms.Label Ingredent_No2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CookFindString;
        private System.Windows.Forms.Panel CookPreviewPanel;
        private System.Windows.Forms.LinkLabel FindedCook1;
        private System.Windows.Forms.LinkLabel FindedCook3;
        private System.Windows.Forms.LinkLabel FindedCook4;
        private System.Windows.Forms.LinkLabel FindedCook2;
        private System.Windows.Forms.LinkLabel NextLink;
        private System.Windows.Forms.LinkLabel CloseFindResult;
        private System.Windows.Forms.LinkLabel PrevLink;
        private System.Windows.Forms.Label NoneResult;
    }
}

