namespace CardGame
{
    partial class Difficulty
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonNormal = new System.Windows.Forms.Button();
            this.buttonHard = new System.Windows.Forms.Button();
            this.buttonEasy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Playbill", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(53, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select your difficulty";
            // 
            // buttonNormal
            // 
            this.buttonNormal.Font = new System.Drawing.Font("Playbill", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNormal.Location = new System.Drawing.Point(12, 117);
            this.buttonNormal.Name = "buttonNormal";
            this.buttonNormal.Size = new System.Drawing.Size(260, 55);
            this.buttonNormal.TabIndex = 4;
            this.buttonNormal.Text = "Normal";
            this.buttonNormal.UseVisualStyleBackColor = true;
            this.buttonNormal.Click += new System.EventHandler(this.buttonNormal_Click);
            // 
            // buttonHard
            // 
            this.buttonHard.Font = new System.Drawing.Font("Playbill", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHard.Location = new System.Drawing.Point(12, 178);
            this.buttonHard.Name = "buttonHard";
            this.buttonHard.Size = new System.Drawing.Size(260, 55);
            this.buttonHard.TabIndex = 5;
            this.buttonHard.Text = "Hard";
            this.buttonHard.UseVisualStyleBackColor = true;
            this.buttonHard.Click += new System.EventHandler(this.buttonHard_Click);
            // 
            // buttonEasy
            // 
            this.buttonEasy.Font = new System.Drawing.Font("Playbill", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEasy.Location = new System.Drawing.Point(12, 56);
            this.buttonEasy.Name = "buttonEasy";
            this.buttonEasy.Size = new System.Drawing.Size(260, 55);
            this.buttonEasy.TabIndex = 0;
            this.buttonEasy.Text = "Easy";
            this.buttonEasy.UseVisualStyleBackColor = true;
            this.buttonEasy.Click += new System.EventHandler(this.buttonEasy_Click);
            // 
            // Difficulty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(284, 247);
            this.Controls.Add(this.buttonHard);
            this.Controls.Add(this.buttonNormal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonEasy);
            this.Name = "Difficulty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Difficulty";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEasy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonNormal;
        private System.Windows.Forms.Button buttonHard;
    }
}