namespace CourseProject0_1
{
    partial class FormHelp
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
            this.PictureBoxPlayers = new System.Windows.Forms.PictureBox();
            this.labelDota2 = new System.Windows.Forms.Label();
            this.labelPredictionResult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxPlayers)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBoxPlayers
            // 
            this.PictureBoxPlayers.BackColor = System.Drawing.Color.Transparent;
            this.PictureBoxPlayers.Image = global::CourseProject0_1.Properties.Resources._54d10b;
            this.PictureBoxPlayers.Location = new System.Drawing.Point(2, 2);
            this.PictureBoxPlayers.Name = "PictureBoxPlayers";
            this.PictureBoxPlayers.Size = new System.Drawing.Size(325, 282);
            this.PictureBoxPlayers.TabIndex = 1;
            this.PictureBoxPlayers.TabStop = false;
            // 
            // labelDota2
            // 
            this.labelDota2.AutoSize = true;
            this.labelDota2.BackColor = System.Drawing.Color.Transparent;
            this.labelDota2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelDota2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDota2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelDota2.Location = new System.Drawing.Point(394, 26);
            this.labelDota2.Name = "labelDota2";
            this.labelDota2.Size = new System.Drawing.Size(248, 26);
            this.labelDota2.TabIndex = 7;
            this.labelDota2.Text = "Manual Fun Cyber Sport";
            // 
            // labelPredictionResult
            // 
            this.labelPredictionResult.AutoSize = true;
            this.labelPredictionResult.BackColor = System.Drawing.Color.Transparent;
            this.labelPredictionResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPredictionResult.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelPredictionResult.Location = new System.Drawing.Point(463, 65);
            this.labelPredictionResult.Name = "labelPredictionResult";
            this.labelPredictionResult.Size = new System.Drawing.Size(90, 20);
            this.labelPredictionResult.TabIndex = 196;
            this.labelPredictionResult.Text = "Версия 0.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(370, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 20);
            this.label1.TabIndex = 197;
            this.label1.Text = "Сушинский Игорь. ХНУРЭ. ПИ-15-2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(426, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 20);
            this.label2.TabIndex = 198;
            this.label2.Text = "Справочник Фаната";
            // 
            // FormHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(672, 286);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPredictionResult);
            this.Controls.Add(this.labelDota2);
            this.Controls.Add(this.PictureBoxPlayers);
            this.Name = "FormHelp";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxPlayers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBoxPlayers;
        private System.Windows.Forms.Label labelDota2;
        public System.Windows.Forms.Label labelPredictionResult;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
    }
}