namespace Dictionaries
{
    partial class FormOef3
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
            this.cbWoorden = new System.Windows.Forms.ComboBox();
            this.lblVertalng = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbWoorden
            // 
            this.cbWoorden.FormattingEnabled = true;
            this.cbWoorden.Location = new System.Drawing.Point(13, 13);
            this.cbWoorden.Name = "cbWoorden";
            this.cbWoorden.Size = new System.Drawing.Size(201, 21);
            this.cbWoorden.TabIndex = 0;
            this.cbWoorden.SelectedIndexChanged += new System.EventHandler(this.cbWoorden_SelectedIndexChanged);
            // 
            // lblVertalng
            // 
            this.lblVertalng.AutoSize = true;
            this.lblVertalng.Location = new System.Drawing.Point(24, 41);
            this.lblVertalng.Name = "lblVertalng";
            this.lblVertalng.Size = new System.Drawing.Size(59, 13);
            this.lblVertalng.TabIndex = 1;
            this.lblVertalng.Text = "vertalingen";
            // 
            // FormOef3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 160);
            this.Controls.Add(this.lblVertalng);
            this.Controls.Add(this.cbWoorden);
            this.Name = "FormOef3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Oefening 3";
            this.Load += new System.EventHandler(this.FormOef3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbWoorden;
        private System.Windows.Forms.Label lblVertalng;
    }
}