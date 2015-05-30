namespace CardGame.View
{
    partial class InserNameForRecord
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
            this.labelYourScore = new System.Windows.Forms.Label();
            this.labelDone = new System.Windows.Forms.Label();
            this.labelYourTime = new System.Windows.Forms.Label();
            this.labelInserName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelYourScore
            // 
            this.labelYourScore.AutoSize = true;
            this.labelYourScore.Font = new System.Drawing.Font("Playbill", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYourScore.Location = new System.Drawing.Point(35, 61);
            this.labelYourScore.Name = "labelYourScore";
            this.labelYourScore.Size = new System.Drawing.Size(102, 27);
            this.labelYourScore.TabIndex = 1;
            this.labelYourScore.Text = "Your score is:";
            // 
            // labelDone
            // 
            this.labelDone.AutoSize = true;
            this.labelDone.Font = new System.Drawing.Font("Playbill", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDone.Location = new System.Drawing.Point(134, 12);
            this.labelDone.Name = "labelDone";
            this.labelDone.Size = new System.Drawing.Size(113, 49);
            this.labelDone.TabIndex = 4;
            this.labelDone.Text = "DONE!!!";
            // 
            // labelYourTime
            // 
            this.labelYourTime.AutoSize = true;
            this.labelYourTime.Font = new System.Drawing.Font("Playbill", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYourTime.Location = new System.Drawing.Point(40, 114);
            this.labelYourTime.Name = "labelYourTime";
            this.labelYourTime.Size = new System.Drawing.Size(97, 27);
            this.labelYourTime.TabIndex = 5;
            this.labelYourTime.Text = "Your time is:";
            // 
            // labelInserName
            // 
            this.labelInserName.AutoSize = true;
            this.labelInserName.Font = new System.Drawing.Font("Playbill", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInserName.Location = new System.Drawing.Point(12, 167);
            this.labelInserName.Name = "labelInserName";
            this.labelInserName.Size = new System.Drawing.Size(125, 27);
            this.labelInserName.TabIndex = 6;
            this.labelInserName.Text = "Insert your name:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(143, 167);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(218, 27);
            this.textBoxName.TabIndex = 7;
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Playbill", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.Location = new System.Drawing.Point(143, 61);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(0, 27);
            this.labelScore.TabIndex = 8;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Playbill", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Location = new System.Drawing.Point(143, 114);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(0, 27);
            this.labelTime.TabIndex = 9;
            // 
            // buttonOk
            // 
            this.buttonOk.Font = new System.Drawing.Font("Playbill", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOk.Location = new System.Drawing.Point(143, 213);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(104, 36);
            this.buttonOk.TabIndex = 10;
            this.buttonOk.Text = "Insert";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // InserNameForRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 261);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelInserName);
            this.Controls.Add(this.labelYourTime);
            this.Controls.Add(this.labelDone);
            this.Controls.Add(this.labelYourScore);
            this.Name = "InserNameForRecord";
            this.Text = "Save";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelYourScore;
        private System.Windows.Forms.Label labelDone;
        private System.Windows.Forms.Label labelYourTime;
        private System.Windows.Forms.Label labelInserName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Button buttonOk;
    }
}