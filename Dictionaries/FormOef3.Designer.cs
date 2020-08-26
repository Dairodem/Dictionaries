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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbWoorden
            // 
            this.cbWoorden.FormattingEnabled = true;
            this.cbWoorden.Location = new System.Drawing.Point(13, 13);
            this.cbWoorden.Name = "cbWoorden";
            this.cbWoorden.Size = new System.Drawing.Size(218, 21);
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
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(13, 118);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(97, 30);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Voeg Woord Toe";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(134, 118);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(97, 30);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Verwijder";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FormOef3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 156);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
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
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
    }
}