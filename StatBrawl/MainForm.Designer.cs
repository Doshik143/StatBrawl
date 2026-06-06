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
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.статистикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.іншеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.довідкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оновитиСтатистикуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.повернутисяДоПошукуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вихідToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.графікКубківToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.топ5БійцівToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.найсильнішийBrawlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.інформаціяПроКлубToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.порівнянняДвохГравцівToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проПрограмуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.файлToolStripMenuItem,
            this.статистикаToolStripMenuItem,
            this.іншеToolStripMenuItem,
            this.довідкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(434, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оновитиСтатистикуToolStripMenuItem,
            this.очиститиToolStripMenuItem,
            this.повернутисяДоПошукуToolStripMenuItem,
            this.вихідToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // статистикаToolStripMenuItem
            // 
            this.статистикаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.графікКубківToolStripMenuItem,
            this.топ5БійцівToolStripMenuItem,
            this.найсильнішийBrawlerToolStripMenuItem});
            this.статистикаToolStripMenuItem.Name = "статистикаToolStripMenuItem";
            this.статистикаToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.статистикаToolStripMenuItem.Text = "Статистика";
            // 
            // іншеToolStripMenuItem
            // 
            this.іншеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.інформаціяПроКлубToolStripMenuItem,
            this.порівнянняДвохГравцівToolStripMenuItem});
            this.іншеToolStripMenuItem.Name = "іншеToolStripMenuItem";
            this.іншеToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.іншеToolStripMenuItem.Text = "Інше";
            // 
            // довідкаToolStripMenuItem
            // 
            this.довідкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.проПрограмуToolStripMenuItem});
            this.довідкаToolStripMenuItem.Name = "довідкаToolStripMenuItem";
            this.довідкаToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.довідкаToolStripMenuItem.Text = "Довідка";
            // 
            // оновитиСтатистикуToolStripMenuItem
            // 
            this.оновитиСтатистикуToolStripMenuItem.Name = "оновитиСтатистикуToolStripMenuItem";
            this.оновитиСтатистикуToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.оновитиСтатистикуToolStripMenuItem.Text = "Оновити статистику";
            // 
            // очиститиToolStripMenuItem
            // 
            this.очиститиToolStripMenuItem.Name = "очиститиToolStripMenuItem";
            this.очиститиToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.очиститиToolStripMenuItem.Text = "Очистити";
            // 
            // повернутисяДоПошукуToolStripMenuItem
            // 
            this.повернутисяДоПошукуToolStripMenuItem.Name = "повернутисяДоПошукуToolStripMenuItem";
            this.повернутисяДоПошукуToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.повернутисяДоПошукуToolStripMenuItem.Text = "Повернутися до пошуку";
            // 
            // вихідToolStripMenuItem
            // 
            this.вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            this.вихідToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.вихідToolStripMenuItem.Text = "Вихід";
            // 
            // графікКубківToolStripMenuItem
            // 
            this.графікКубківToolStripMenuItem.Name = "графікКубківToolStripMenuItem";
            this.графікКубківToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.графікКубківToolStripMenuItem.Text = "Графік кубків";
            // 
            // топ5БійцівToolStripMenuItem
            // 
            this.топ5БійцівToolStripMenuItem.Name = "топ5БійцівToolStripMenuItem";
            this.топ5БійцівToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.топ5БійцівToolStripMenuItem.Text = "Топ-5 бійців";
            // 
            // найсильнішийBrawlerToolStripMenuItem
            // 
            this.найсильнішийBrawlerToolStripMenuItem.Name = "найсильнішийBrawlerToolStripMenuItem";
            this.найсильнішийBrawlerToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.найсильнішийBrawlerToolStripMenuItem.Text = "Найсильніший brawler";
            // 
            // інформаціяПроКлубToolStripMenuItem
            // 
            this.інформаціяПроКлубToolStripMenuItem.Name = "інформаціяПроКлубToolStripMenuItem";
            this.інформаціяПроКлубToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.інформаціяПроКлубToolStripMenuItem.Text = "Інформація про клуб";
            // 
            // порівнянняДвохГравцівToolStripMenuItem
            // 
            this.порівнянняДвохГравцівToolStripMenuItem.Name = "порівнянняДвохГравцівToolStripMenuItem";
            this.порівнянняДвохГравцівToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.порівнянняДвохГравцівToolStripMenuItem.Text = "Порівняння двох гравців";
            // 
            // проПрограмуToolStripMenuItem
            // 
            this.проПрограмуToolStripMenuItem.Name = "проПрограмуToolStripMenuItem";
            this.проПрограмуToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.проПрограмуToolStripMenuItem.Text = "Про програму";
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
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оновитиСтатистикуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem повернутисяДоПошукуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вихідToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem статистикаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem графікКубківToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem топ5БійцівToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem найсильнішийBrawlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem іншеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem інформаціяПроКлубToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem порівнянняДвохГравцівToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem довідкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проПрограмуToolStripMenuItem;
    }
}

