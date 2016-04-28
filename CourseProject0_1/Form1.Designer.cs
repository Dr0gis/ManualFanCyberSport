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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ListDota2Player = new System.Windows.Forms.ListBox();
            this.textBoxExample = new System.Windows.Forms.RichTextBox();
            this.ListCSGOPlayer = new System.Windows.Forms.ListBox();
            this.labelDota2 = new System.Windows.Forms.Label();
            this.labelCSGO = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(211, -30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(334, 227);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ListDota2Player
            // 
            this.ListDota2Player.BackColor = System.Drawing.Color.White;
            this.ListDota2Player.ForeColor = System.Drawing.SystemColors.InfoText;
            this.ListDota2Player.FormattingEnabled = true;
            this.ListDota2Player.Location = new System.Drawing.Point(12, 48);
            this.ListDota2Player.Name = "ListDota2Player";
            this.ListDota2Player.Size = new System.Drawing.Size(190, 459);
            this.ListDota2Player.Sorted = true;
            this.ListDota2Player.TabIndex = 1;
            // 
            // textBoxExample
            // 
            this.textBoxExample.Location = new System.Drawing.Point(236, 233);
            this.textBoxExample.Name = "textBoxExample";
            this.textBoxExample.Size = new System.Drawing.Size(296, 274);
            this.textBoxExample.TabIndex = 4;
            this.textBoxExample.Text = "";
            // 
            // ListCSGOPlayer
            // 
            this.ListCSGOPlayer.FormattingEnabled = true;
            this.ListCSGOPlayer.Location = new System.Drawing.Point(558, 48);
            this.ListCSGOPlayer.Name = "ListCSGOPlayer";
            this.ListCSGOPlayer.Size = new System.Drawing.Size(190, 459);
            this.ListCSGOPlayer.TabIndex = 5;
            // 
            // labelDota2
            // 
            this.labelDota2.AutoSize = true;
            this.labelDota2.BackColor = System.Drawing.Color.Transparent;
            this.labelDota2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDota2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelDota2.Location = new System.Drawing.Point(61, 9);
            this.labelDota2.Name = "labelDota2";
            this.labelDota2.Size = new System.Drawing.Size(76, 26);
            this.labelDota2.TabIndex = 6;
            this.labelDota2.Text = "Dota 2";
            // 
            // labelCSGO
            // 
            this.labelCSGO.AutoSize = true;
            this.labelCSGO.BackColor = System.Drawing.Color.Transparent;
            this.labelCSGO.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCSGO.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelCSGO.Location = new System.Drawing.Point(618, 9);
            this.labelCSGO.Name = "labelCSGO";
            this.labelCSGO.Size = new System.Drawing.Size(83, 26);
            this.labelCSGO.TabIndex = 7;
            this.labelCSGO.Text = "CS:GO";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(760, 519);
            this.Controls.Add(this.labelCSGO);
            this.Controls.Add(this.labelDota2);
            this.Controls.Add(this.ListCSGOPlayer);
            this.Controls.Add(this.textBoxExample);
            this.Controls.Add(this.ListDota2Player);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainForm";
            this.Text = "Справочник Фаната";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox ListDota2Player;
        private System.Windows.Forms.RichTextBox textBoxExample;
        private System.Windows.Forms.ListBox ListCSGOPlayer;
        private System.Windows.Forms.Label labelDota2;
        private System.Windows.Forms.Label labelCSGO;
    }
}

