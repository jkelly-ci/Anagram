namespace Anagram
{
    partial class Form1
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
            this.txtWord1 = new System.Windows.Forms.TextBox();
            this.txtWord2 = new System.Windows.Forms.TextBox();
            this.lblWord1 = new System.Windows.Forms.Label();
            this.lblWord2 = new System.Windows.Forms.Label();
            this.btnIsAnagram = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtWord1
            // 
            this.txtWord1.Location = new System.Drawing.Point(63, 12);
            this.txtWord1.Name = "txtWord1";
            this.txtWord1.Size = new System.Drawing.Size(187, 20);
            this.txtWord1.TabIndex = 0;
            // 
            // txtWord2
            // 
            this.txtWord2.Location = new System.Drawing.Point(63, 38);
            this.txtWord2.Name = "txtWord2";
            this.txtWord2.Size = new System.Drawing.Size(187, 20);
            this.txtWord2.TabIndex = 1;
            // 
            // lblWord1
            // 
            this.lblWord1.AutoSize = true;
            this.lblWord1.Location = new System.Drawing.Point(12, 15);
            this.lblWord1.Name = "lblWord1";
            this.lblWord1.Size = new System.Drawing.Size(45, 13);
            this.lblWord1.TabIndex = 2;
            this.lblWord1.Text = "Word 1:";
            // 
            // lblWord2
            // 
            this.lblWord2.AutoSize = true;
            this.lblWord2.Location = new System.Drawing.Point(12, 41);
            this.lblWord2.Name = "lblWord2";
            this.lblWord2.Size = new System.Drawing.Size(45, 13);
            this.lblWord2.TabIndex = 3;
            this.lblWord2.Text = "Word 2:";
            // 
            // btnIsAnagram
            // 
            this.btnIsAnagram.Location = new System.Drawing.Point(256, 36);
            this.btnIsAnagram.Name = "btnIsAnagram";
            this.btnIsAnagram.Size = new System.Drawing.Size(75, 23);
            this.btnIsAnagram.TabIndex = 4;
            this.btnIsAnagram.Text = "Is Anagram";
            this.btnIsAnagram.UseVisualStyleBackColor = true;
            this.btnIsAnagram.Click += new System.EventHandler(this.btnIsAnagram_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 80);
            this.Controls.Add(this.btnIsAnagram);
            this.Controls.Add(this.lblWord2);
            this.Controls.Add(this.lblWord1);
            this.Controls.Add(this.txtWord2);
            this.Controls.Add(this.txtWord1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtWord1;
        private System.Windows.Forms.TextBox txtWord2;
        private System.Windows.Forms.Label lblWord1;
        private System.Windows.Forms.Label lblWord2;
        private System.Windows.Forms.Button btnIsAnagram;
    }
}

