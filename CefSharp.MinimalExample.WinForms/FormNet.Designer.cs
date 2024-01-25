namespace CefSharp.MinimalExample.WinForms
{
    partial class FormNet
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
            this.cefPanel = new System.Windows.Forms.Panel();
            this.browserPanel = new System.Windows.Forms.Panel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.button1 = new System.Windows.Forms.Button();
            this.cefPanel.SuspendLayout();
            this.browserPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // cefPanel
            // 
            this.cefPanel.Controls.Add(this.browserPanel);
            this.cefPanel.Location = new System.Drawing.Point(12, 12);
            this.cefPanel.Name = "cefPanel";
            this.cefPanel.Size = new System.Drawing.Size(776, 426);
            this.cefPanel.TabIndex = 2;
            // 
            // browserPanel
            // 
            this.browserPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.browserPanel.Controls.Add(this.button1);
            this.browserPanel.Controls.Add(this.webBrowser1);
            this.browserPanel.Location = new System.Drawing.Point(22, 15);
            this.browserPanel.Name = "browserPanel";
            this.browserPanel.Size = new System.Drawing.Size(754, 411);
            this.browserPanel.TabIndex = 1;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(25, 28);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(713, 380);
            this.webBrowser1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(604, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormNet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cefPanel);
            this.Name = "FormNet";
            this.Text = "FormNet";
            this.cefPanel.ResumeLayout(false);
            this.browserPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel cefPanel;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Panel browserPanel;
    }
}