namespace Dictionaries
{
    partial class FormOef4
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
            this.numGetal = new System.Windows.Forms.NumericUpDown();
            this.lblGetal = new System.Windows.Forms.Label();
            this.btnAdd100 = new System.Windows.Forms.Button();
            this.btnAdd1000 = new System.Windows.Forms.Button();
            this.btnAddMld = new System.Windows.Forms.Button();
            this.btnAddMil = new System.Windows.Forms.Button();
            this.btnAddBld = new System.Windows.Forms.Button();
            this.btnAddBil = new System.Windows.Forms.Button();
            this.btnAddTril = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numGetal)).BeginInit();
            this.SuspendLayout();
            // 
            // numGetal
            // 
            this.numGetal.Location = new System.Drawing.Point(12, 12);
            this.numGetal.Maximum = new decimal(new int[] {
            268435455,
            1042612833,
            542101086,
            0});
            this.numGetal.Name = "numGetal";
            this.numGetal.Size = new System.Drawing.Size(309, 20);
            this.numGetal.TabIndex = 0;
            this.numGetal.ValueChanged += new System.EventHandler(this.numGetal_ValueChanged);
            // 
            // lblGetal
            // 
            this.lblGetal.AutoSize = true;
            this.lblGetal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGetal.Location = new System.Drawing.Point(12, 53);
            this.lblGetal.Name = "lblGetal";
            this.lblGetal.Size = new System.Drawing.Size(41, 13);
            this.lblGetal.TabIndex = 1;
            this.lblGetal.Text = "label1";
            // 
            // btnAdd100
            // 
            this.btnAdd100.BackColor = System.Drawing.Color.SeaShell;
            this.btnAdd100.Location = new System.Drawing.Point(327, 7);
            this.btnAdd100.Name = "btnAdd100";
            this.btnAdd100.Size = new System.Drawing.Size(64, 27);
            this.btnAdd100.TabIndex = 2;
            this.btnAdd100.Text = "+100";
            this.btnAdd100.UseVisualStyleBackColor = false;
            this.btnAdd100.Click += new System.EventHandler(this.btnAdd100_Click);
            // 
            // btnAdd1000
            // 
            this.btnAdd1000.BackColor = System.Drawing.Color.OldLace;
            this.btnAdd1000.Location = new System.Drawing.Point(397, 7);
            this.btnAdd1000.Name = "btnAdd1000";
            this.btnAdd1000.Size = new System.Drawing.Size(64, 27);
            this.btnAdd1000.TabIndex = 3;
            this.btnAdd1000.Text = "+1000";
            this.btnAdd1000.UseVisualStyleBackColor = false;
            this.btnAdd1000.Click += new System.EventHandler(this.btnAdd1000_Click);
            // 
            // btnAddMld
            // 
            this.btnAddMld.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnAddMld.Location = new System.Drawing.Point(537, 7);
            this.btnAddMld.Name = "btnAddMld";
            this.btnAddMld.Size = new System.Drawing.Size(64, 27);
            this.btnAddMld.TabIndex = 5;
            this.btnAddMld.Text = "+1 miljard";
            this.btnAddMld.UseVisualStyleBackColor = false;
            this.btnAddMld.Click += new System.EventHandler(this.btnAddMld_Click);
            // 
            // btnAddMil
            // 
            this.btnAddMil.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnAddMil.Location = new System.Drawing.Point(467, 7);
            this.btnAddMil.Name = "btnAddMil";
            this.btnAddMil.Size = new System.Drawing.Size(64, 27);
            this.btnAddMil.TabIndex = 4;
            this.btnAddMil.Text = "+1 miljoen";
            this.btnAddMil.UseVisualStyleBackColor = false;
            this.btnAddMil.Click += new System.EventHandler(this.btnAddMil_Click);
            // 
            // btnAddBld
            // 
            this.btnAddBld.BackColor = System.Drawing.Color.BurlyWood;
            this.btnAddBld.Location = new System.Drawing.Point(677, 7);
            this.btnAddBld.Name = "btnAddBld";
            this.btnAddBld.Size = new System.Drawing.Size(64, 27);
            this.btnAddBld.TabIndex = 7;
            this.btnAddBld.Text = "+1 biljard";
            this.btnAddBld.UseVisualStyleBackColor = false;
            this.btnAddBld.Click += new System.EventHandler(this.btnAddBld_Click);
            // 
            // btnAddBil
            // 
            this.btnAddBil.BackColor = System.Drawing.Color.Bisque;
            this.btnAddBil.Location = new System.Drawing.Point(607, 7);
            this.btnAddBil.Name = "btnAddBil";
            this.btnAddBil.Size = new System.Drawing.Size(64, 27);
            this.btnAddBil.TabIndex = 6;
            this.btnAddBil.Text = "+1 biljoen";
            this.btnAddBil.UseVisualStyleBackColor = false;
            this.btnAddBil.Click += new System.EventHandler(this.btnAddBil_Click);
            // 
            // btnAddTril
            // 
            this.btnAddTril.BackColor = System.Drawing.Color.Tan;
            this.btnAddTril.Location = new System.Drawing.Point(747, 7);
            this.btnAddTril.Name = "btnAddTril";
            this.btnAddTril.Size = new System.Drawing.Size(64, 27);
            this.btnAddTril.TabIndex = 8;
            this.btnAddTril.Text = "+1 triljoen";
            this.btnAddTril.UseVisualStyleBackColor = false;
            this.btnAddTril.Click += new System.EventHandler(this.btnAddTril_Click);
            // 
            // FormOef4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 94);
            this.Controls.Add(this.btnAddTril);
            this.Controls.Add(this.btnAddBld);
            this.Controls.Add(this.btnAddBil);
            this.Controls.Add(this.btnAddMld);
            this.Controls.Add(this.btnAddMil);
            this.Controls.Add(this.btnAdd1000);
            this.Controls.Add(this.btnAdd100);
            this.Controls.Add(this.lblGetal);
            this.Controls.Add(this.numGetal);
            this.Name = "FormOef4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Oefening 4";
            this.Load += new System.EventHandler(this.FormOef4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numGetal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numGetal;
        private System.Windows.Forms.Label lblGetal;
        private System.Windows.Forms.Button btnAdd100;
        private System.Windows.Forms.Button btnAdd1000;
        private System.Windows.Forms.Button btnAddMld;
        private System.Windows.Forms.Button btnAddMil;
        private System.Windows.Forms.Button btnAddBld;
        private System.Windows.Forms.Button btnAddBil;
        private System.Windows.Forms.Button btnAddTril;
    }
}