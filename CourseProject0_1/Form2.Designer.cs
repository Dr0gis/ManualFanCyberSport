namespace CourseProject0_1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.labelDota2 = new System.Windows.Forms.Label();
            this.textBoxExample = new System.Windows.Forms.RichTextBox();
            this.ListDota2Player = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDota2
            // 
            this.labelDota2.AutoSize = true;
            this.labelDota2.BackColor = System.Drawing.Color.Transparent;
            this.labelDota2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDota2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelDota2.Location = new System.Drawing.Point(-79, -99);
            this.labelDota2.Name = "labelDota2";
            this.labelDota2.Size = new System.Drawing.Size(76, 26);
            this.labelDota2.TabIndex = 10;
            this.labelDota2.Text = "Dota 2";
            // 
            // textBoxExample
            // 
            this.textBoxExample.Location = new System.Drawing.Point(408, 235);
            this.textBoxExample.Name = "textBoxExample";
            this.textBoxExample.Size = new System.Drawing.Size(341, 274);
            this.textBoxExample.TabIndex = 9;
            this.textBoxExample.Text = "";
            // 
            // ListDota2Player
            // 
            this.ListDota2Player.BackColor = System.Drawing.Color.White;
            this.ListDota2Player.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ListDota2Player.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListDota2Player.ForeColor = System.Drawing.SystemColors.InfoText;
            this.ListDota2Player.FormattingEnabled = true;
            this.ListDota2Player.HorizontalScrollbar = true;
            this.ListDota2Player.ItemHeight = 20;
            this.ListDota2Player.Location = new System.Drawing.Point(12, 85);
            this.ListDota2Player.Name = "ListDota2Player";
            this.ListDota2Player.Size = new System.Drawing.Size(228, 424);
            this.ListDota2Player.Sorted = true;
            this.ListDota2Player.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(408, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(334, 227);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(80, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 26);
            this.label1.TabIndex = 11;
            this.label1.Text = "Dota 2";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(754, 521);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelDota2);
            this.Controls.Add(this.textBoxExample);
            this.Controls.Add(this.ListDota2Player);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDota2;
        private System.Windows.Forms.RichTextBox textBoxExample;
        private System.Windows.Forms.ListBox ListDota2Player;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}