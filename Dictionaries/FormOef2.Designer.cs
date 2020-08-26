namespace Dictionaries
{
    partial class FormOef2
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
            this.lblEngels = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
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
            // lblEngels
            // 
            this.lblEngels.AutoSize = true;
            this.lblEngels.Location = new System.Drawing.Point(26, 55);
            this.lblEngels.Name = "lblEngels";
            this.lblEngels.Size = new System.Drawing.Size(41, 13);
            this.lblEngels.TabIndex = 1;
            this.lblEngels.Text = "English";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(13, 114);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(97, 30);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Voeg Woord Toe";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(134, 114);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(97, 30);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Verwijder";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // FormOef2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 156);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblEngels);
            this.Controls.Add(this.cbWoorden);
            this.Name = "FormOef2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Oefening 2";
            this.Load += new System.EventHandler(this.FormOef2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbWoorden;
        private System.Windows.Forms.Label lblEngels;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
    }
}