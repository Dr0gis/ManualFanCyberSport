namespace CourseProject0_1
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.PictureBoxPlayers = new System.Windows.Forms.PictureBox();
            this.labelCSGO = new System.Windows.Forms.Label();
            this.labelDota2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxPlayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBoxPlayers
            // 
            this.PictureBoxPlayers.BackColor = System.Drawing.Color.Transparent;
            this.PictureBoxPlayers.Image = global::CourseProject0_1.Properties.Resources._54d10b;
            this.PictureBoxPlayers.Location = new System.Drawing.Point(526, 12);
            this.PictureBoxPlayers.Name = "PictureBoxPlayers";
            this.PictureBoxPlayers.Size = new System.Drawing.Size(325, 282);
            this.PictureBoxPlayers.TabIndex = 0;
            this.PictureBoxPlayers.TabStop = false;
            // 
            // labelCSGO
            // 
            this.labelCSGO.AutoSize = true;
            this.labelCSGO.BackColor = System.Drawing.Color.Transparent;
            this.labelCSGO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelCSGO.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCSGO.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelCSGO.Location = new System.Drawing.Point(1092, 596);
            this.labelCSGO.Name = "labelCSGO";
            this.labelCSGO.Size = new System.Drawing.Size(83, 26);
            this.labelCSGO.TabIndex = 7;
            this.labelCSGO.Text = "CS:GO";
            this.labelCSGO.Click += new System.EventHandler(this.labelCSGO_Click);
            // 
            // labelDota2
            // 
            this.labelDota2.AutoSize = true;
            this.labelDota2.BackColor = System.Drawing.Color.Transparent;
            this.labelDota2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelDota2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDota2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelDota2.Location = new System.Drawing.Point(195, 584);
            this.labelDota2.Name = "labelDota2";
            this.labelDota2.Size = new System.Drawing.Size(76, 26);
            this.labelDota2.TabIndex = 6;
            this.labelDota2.Text = "Dota 2";
            this.labelDota2.Click += new System.EventHandler(this.labelDota2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::CourseProject0_1.Properties.Resources.dota2logo100;
            this.pictureBox2.Location = new System.Drawing.Point(182, 480);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(102, 101);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.labelDota2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::CourseProject0_1.Properties.Resources.csgologo100;
            this.pictureBox3.Location = new System.Drawing.Point(1018, 480);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(235, 113);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.labelCSGO_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.labelCSGO);
            this.Controls.Add(this.labelDota2);
            this.Controls.Add(this.PictureBoxPlayers);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Справочник Фаната";
            this.Load += new System.EventHandler(this.MainFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxPlayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBoxPlayers;
        private System.Windows.Forms.Label labelCSGO;
        private System.Windows.Forms.Label labelDota2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

