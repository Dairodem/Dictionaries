namespace Dictionaries
{
    partial class FormOef1
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
            this.cbGetallen = new System.Windows.Forms.ComboBox();
            this.lblGetal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbGetallen
            // 
            this.cbGetallen.FormattingEnabled = true;
            this.cbGetallen.Location = new System.Drawing.Point(13, 13);
            this.cbGetallen.Name = "cbGetallen";
            this.cbGetallen.Size = new System.Drawing.Size(53, 21);
            this.cbGetallen.TabIndex = 0;
            this.cbGetallen.SelectedIndexChanged += new System.EventHandler(this.cbGetallen_SelectedIndexChanged);
            // 
            // lblGetal
            // 
            this.lblGetal.AutoSize = true;
            this.lblGetal.Location = new System.Drawing.Point(100, 16);
            this.lblGetal.Name = "lblGetal";
            this.lblGetal.Size = new System.Drawing.Size(35, 13);
            this.lblGetal.TabIndex = 1;
            this.lblGetal.Text = "label1";
            // 
            // FormOef1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 54);
            this.Controls.Add(this.lblGetal);
            this.Controls.Add(this.cbGetallen);
            this.Name = "FormOef1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Oefening 1";
            this.Load += new System.EventHandler(this.FormOef1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbGetallen;
        private System.Windows.Forms.Label lblGetal;
    }
}