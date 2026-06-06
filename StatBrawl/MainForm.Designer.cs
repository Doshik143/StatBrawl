namespace StatBrawl
{
    partial class StatBrawl
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatBrawl));
            this.btnLoad = new System.Windows.Forms.Button();
            this.lblTrophies = new System.Windows.Forms.Label();
            this.lblHighest = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.dgvBrawlers = new System.Windows.Forms.DataGridView();
            this.txtTag = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.pnlStart = new System.Windows.Forms.Panel();
            this.pnlStats = new System.Windows.Forms.Panel();
            this.lblBrawlersCount = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.miFile = new System.Windows.Forms.ToolStripMenuItem();
            this.miRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.miBack = new System.Windows.Forms.ToolStripMenuItem();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.miStats = new System.Windows.Forms.ToolStripMenuItem();
            this.miTop5 = new System.Windows.Forms.ToolStripMenuItem();
            this.miStrongest = new System.Windows.Forms.ToolStripMenuItem();
            this.miOther = new System.Windows.Forms.ToolStripMenuItem();
            this.miClub = new System.Windows.Forms.ToolStripMenuItem();
            this.miCompare = new System.Windows.Forms.ToolStripMenuItem();
            this.miHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.miAbout = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBrawlers)).BeginInit();
            this.pnlStart.SuspendLayout();
            this.pnlStats.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.Transparent;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLoad.Location = new System.Drawing.Point(123, 269);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(175, 26);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Отримати статистику";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lblTrophies
            // 
            this.lblTrophies.AutoSize = true;
            this.lblTrophies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTrophies.Location = new System.Drawing.Point(71, 93);
            this.lblTrophies.Name = "lblTrophies";
            this.lblTrophies.Size = new System.Drawing.Size(29, 20);
            this.lblTrophies.TabIndex = 2;
            this.lblTrophies.Text = "🏆:";
            // 
            // lblHighest
            // 
            this.lblHighest.AutoSize = true;
            this.lblHighest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHighest.Location = new System.Drawing.Point(31, 116);
            this.lblHighest.Name = "lblHighest";
            this.lblHighest.Size = new System.Drawing.Size(69, 20);
            this.lblHighest.TabIndex = 3;
            this.lblHighest.Text = "Рекорд:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.Location = new System.Drawing.Point(45, 70);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 20);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name:";
            // 
            // dgvBrawlers
            // 
            this.dgvBrawlers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBrawlers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBrawlers.Location = new System.Drawing.Point(12, 224);
            this.dgvBrawlers.Name = "dgvBrawlers";
            this.dgvBrawlers.ReadOnly = true;
            this.dgvBrawlers.Size = new System.Drawing.Size(410, 200);
            this.dgvBrawlers.TabIndex = 5;
            // 
            // txtTag
            // 
            this.txtTag.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtTag.Location = new System.Drawing.Point(123, 224);
            this.txtTag.Name = "txtTag";
            this.txtTag.Size = new System.Drawing.Size(175, 26);
            this.txtTag.TabIndex = 0;
            this.txtTag.Text = "#8G08UCPCY";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSearch.Location = new System.Drawing.Point(247, 189);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(175, 26);
            this.txtSearch.TabIndex = 6;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSearch.Location = new System.Drawing.Point(212, 192);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(29, 20);
            this.lblSearch.TabIndex = 7;
            this.lblSearch.Text = "🔎:";
            // 
            // pnlStart
            // 
            this.pnlStart.Controls.Add(this.btnLoad);
            this.pnlStart.Controls.Add(this.txtTag);
            this.pnlStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStart.Location = new System.Drawing.Point(0, 0);
            this.pnlStart.Name = "pnlStart";
            this.pnlStart.Size = new System.Drawing.Size(434, 436);
            this.pnlStart.TabIndex = 8;
            // 
            // pnlStats
            // 
            this.pnlStats.Controls.Add(this.lblBrawlersCount);
            this.pnlStats.Controls.Add(this.lblHighest);
            this.pnlStats.Controls.Add(this.lblTrophies);
            this.pnlStats.Controls.Add(this.lblName);
            this.pnlStats.Controls.Add(this.dgvBrawlers);
            this.pnlStats.Controls.Add(this.txtSearch);
            this.pnlStats.Controls.Add(this.lblSearch);
            this.pnlStats.Controls.Add(this.menuStrip1);
            this.pnlStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStats.Location = new System.Drawing.Point(0, 0);
            this.pnlStats.Name = "pnlStats";
            this.pnlStats.Size = new System.Drawing.Size(434, 436);
            this.pnlStats.TabIndex = 2;
            // 
            // lblBrawlersCount
            // 
            this.lblBrawlersCount.AutoSize = true;
            this.lblBrawlersCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBrawlersCount.Location = new System.Drawing.Point(26, 139);
            this.lblBrawlersCount.Name = "lblBrawlersCount";
            this.lblBrawlersCount.Size = new System.Drawing.Size(74, 20);
            this.lblBrawlersCount.TabIndex = 8;
            this.lblBrawlersCount.Text = "Brawlers:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFile,
            this.miStats,
            this.miOther,
            this.miHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(434, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // miFile
            // 
            this.miFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miRefresh,
            this.miBack,
            this.miExit});
            this.miFile.Name = "miFile";
            this.miFile.Size = new System.Drawing.Size(48, 20);
            this.miFile.Text = "Файл";
            // 
            // miRefresh
            // 
            this.miRefresh.Name = "miRefresh";
            this.miRefresh.Size = new System.Drawing.Size(208, 22);
            this.miRefresh.Text = "Оновити статистику";
            this.miRefresh.Click += new System.EventHandler(this.miRefresh_Click);
            // 
            // miBack
            // 
            this.miBack.Name = "miBack";
            this.miBack.Size = new System.Drawing.Size(208, 22);
            this.miBack.Text = "Повернутися до пошуку";
            this.miBack.Click += new System.EventHandler(this.miBack_Click);
            // 
            // miExit
            // 
            this.miExit.Name = "miExit";
            this.miExit.Size = new System.Drawing.Size(208, 22);
            this.miExit.Text = "Вихід";
            this.miExit.Click += new System.EventHandler(this.miExit_Click);
            // 
            // miStats
            // 
            this.miStats.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miTop5,
            this.miStrongest});
            this.miStats.Name = "miStats";
            this.miStats.Size = new System.Drawing.Size(80, 20);
            this.miStats.Text = "Статистика";
            // 
            // miTop5
            // 
            this.miTop5.Name = "miTop5";
            this.miTop5.Size = new System.Drawing.Size(199, 22);
            this.miTop5.Text = "Топ-5 бійців";
            this.miTop5.Click += new System.EventHandler(this.miTop5_Click);
            // 
            // miStrongest
            // 
            this.miStrongest.Name = "miStrongest";
            this.miStrongest.Size = new System.Drawing.Size(199, 22);
            this.miStrongest.Text = "Найсильніший brawler";
            // 
            // miOther
            // 
            this.miOther.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miClub,
            this.miCompare});
            this.miOther.Name = "miOther";
            this.miOther.Size = new System.Drawing.Size(46, 20);
            this.miOther.Text = "Інше";
            // 
            // miClub
            // 
            this.miClub.Name = "miClub";
            this.miClub.Size = new System.Drawing.Size(210, 22);
            this.miClub.Text = "Інформація про клуб";
            // 
            // miCompare
            // 
            this.miCompare.Name = "miCompare";
            this.miCompare.Size = new System.Drawing.Size(210, 22);
            this.miCompare.Text = "Порівняння двох гравців";
            // 
            // miHelp
            // 
            this.miHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAbout});
            this.miHelp.Name = "miHelp";
            this.miHelp.Size = new System.Drawing.Size(61, 20);
            this.miHelp.Text = "Довідка";
            // 
            // miAbout
            // 
            this.miAbout.Name = "miAbout";
            this.miAbout.Size = new System.Drawing.Size(180, 22);
            this.miAbout.Text = "Про програму";
            // 
            // StatBrawl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 436);
            this.Controls.Add(this.pnlStats);
            this.Controls.Add(this.pnlStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(450, 475);
            this.MinimumSize = new System.Drawing.Size(450, 475);
            this.Name = "StatBrawl";
            this.Text = "StatBrawl";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBrawlers)).EndInit();
            this.pnlStart.ResumeLayout(false);
            this.pnlStart.PerformLayout();
            this.pnlStats.ResumeLayout(false);
            this.pnlStats.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label lblTrophies;
        private System.Windows.Forms.Label lblHighest;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DataGridView dgvBrawlers;
        private System.Windows.Forms.TextBox txtTag;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Panel pnlStart;
        private System.Windows.Forms.Panel pnlStats;
        private System.Windows.Forms.Label lblBrawlersCount;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem miFile;
        private System.Windows.Forms.ToolStripMenuItem miRefresh;
        private System.Windows.Forms.ToolStripMenuItem miBack;
        private System.Windows.Forms.ToolStripMenuItem miExit;
        private System.Windows.Forms.ToolStripMenuItem miStats;
        private System.Windows.Forms.ToolStripMenuItem miTop5;
        private System.Windows.Forms.ToolStripMenuItem miStrongest;
        private System.Windows.Forms.ToolStripMenuItem miOther;
        private System.Windows.Forms.ToolStripMenuItem miClub;
        private System.Windows.Forms.ToolStripMenuItem miCompare;
        private System.Windows.Forms.ToolStripMenuItem miHelp;
        private System.Windows.Forms.ToolStripMenuItem miAbout;
    }
}

