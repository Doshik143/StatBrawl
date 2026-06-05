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
            this.txtTag = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lblTrophies = new System.Windows.Forms.Label();
            this.lblHighest = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.dgvBrawlers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBrawlers)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTag
            // 
            this.txtTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtTag.Location = new System.Drawing.Point(12, 28);
            this.txtTag.Name = "txtTag";
            this.txtTag.Size = new System.Drawing.Size(175, 26);
            this.txtTag.TabIndex = 0;
            this.txtTag.Text = "#";
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLoad.Location = new System.Drawing.Point(237, 28);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(175, 26);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Отримати статистику";
            this.btnLoad.UseVisualStyleBackColor = true;
            // 
            // lblTrophies
            // 
            this.lblTrophies.AutoSize = true;
            this.lblTrophies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTrophies.Location = new System.Drawing.Point(31, 102);
            this.lblTrophies.Name = "lblTrophies";
            this.lblTrophies.Size = new System.Drawing.Size(56, 20);
            this.lblTrophies.TabIndex = 2;
            this.lblTrophies.Text = "Кубки:";
            // 
            // lblHighest
            // 
            this.lblHighest.AutoSize = true;
            this.lblHighest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHighest.Location = new System.Drawing.Point(18, 128);
            this.lblHighest.Name = "lblHighest";
            this.lblHighest.Size = new System.Drawing.Size(69, 20);
            this.lblHighest.TabIndex = 3;
            this.lblHighest.Text = "Рекорд:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.Location = new System.Drawing.Point(46, 76);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 20);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Ім\'я:";
            // 
            // dgvBrawlers
            // 
            this.dgvBrawlers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBrawlers.Location = new System.Drawing.Point(12, 165);
            this.dgvBrawlers.Name = "dgvBrawlers";
            this.dgvBrawlers.Size = new System.Drawing.Size(400, 200);
            this.dgvBrawlers.TabIndex = 5;
            // 
            // StatBrawl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 386);
            this.Controls.Add(this.dgvBrawlers);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblHighest);
            this.Controls.Add(this.lblTrophies);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.txtTag);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(450, 425);
            this.MinimumSize = new System.Drawing.Size(450, 425);
            this.Name = "StatBrawl";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBrawlers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTag;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label lblTrophies;
        private System.Windows.Forms.Label lblHighest;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DataGridView dgvBrawlers;
    }
}

