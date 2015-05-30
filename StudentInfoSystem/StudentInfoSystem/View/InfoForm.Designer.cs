namespace StudentInfoSystem.View
{
    partial class InfoForm
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
            this.btnFont = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.richTextBoxText = new System.Windows.Forms.RichTextBox();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.btnSave = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonCenter = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFont
            // 
            this.btnFont.BackgroundImage = global::StudentInfoSystem.Properties.Resources.font;
            this.btnFont.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFont.Location = new System.Drawing.Point(237, 223);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(42, 42);
            this.btnFont.TabIndex = 0;
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // btnColor
            // 
            this.btnColor.BackgroundImage = global::StudentInfoSystem.Properties.Resources.color;
            this.btnColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnColor.Location = new System.Drawing.Point(285, 223);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(45, 42);
            this.btnColor.TabIndex = 1;
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // richTextBoxText
            // 
            this.richTextBoxText.Location = new System.Drawing.Point(12, 12);
            this.richTextBoxText.Name = "richTextBoxText";
            this.richTextBoxText.Size = new System.Drawing.Size(548, 205);
            this.richTextBoxText.TabIndex = 2;
            this.richTextBoxText.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = global::StudentInfoSystem.Properties.Resources.save;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSave.Location = new System.Drawing.Point(516, 223);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(45, 42);
            this.btnSave.TabIndex = 3;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Location = new System.Drawing.Point(13, 223);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(75, 23);
            this.buttonLeft.TabIndex = 4;
            this.buttonLeft.Text = "Left";
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // buttonCenter
            // 
            this.buttonCenter.Location = new System.Drawing.Point(13, 252);
            this.buttonCenter.Name = "buttonCenter";
            this.buttonCenter.Size = new System.Drawing.Size(75, 23);
            this.buttonCenter.TabIndex = 5;
            this.buttonCenter.Text = "Center";
            this.buttonCenter.UseVisualStyleBackColor = true;
            this.buttonCenter.Click += new System.EventHandler(this.buttonCenter_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Location = new System.Drawing.Point(13, 281);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(75, 23);
            this.buttonRight.TabIndex = 6;
            this.buttonRight.Text = "Right";
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // InfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 317);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonCenter);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.richTextBoxText);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.btnFont);
            this.Name = "InfoForm";
            this.Text = "InfoForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.RichTextBox richTextBoxText;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonCenter;
        private System.Windows.Forms.Button buttonRight;
    }
}