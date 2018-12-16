namespace AsfandMalik
{
    partial class Folkomröstning
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
            this.alternativA = new System.Windows.Forms.RadioButton();
            this.alternativB = new System.Windows.Forms.RadioButton();
            this.alternativC = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.gbRost = new System.Windows.Forms.GroupBox();
            this.lblTack = new System.Windows.Forms.Label();
            this.lnlRöstaigen = new System.Windows.Forms.LinkLabel();
            this.gbRost.SuspendLayout();
            this.SuspendLayout();
            // 
            // alternativA
            // 
            this.alternativA.AutoSize = true;
            this.alternativA.Location = new System.Drawing.Point(17, 21);
            this.alternativA.Name = "alternativA";
            this.alternativA.Size = new System.Drawing.Size(44, 19);
            this.alternativA.TabIndex = 0;
            this.alternativA.TabStop = true;
            this.alternativA.Text = "Nej";
            this.alternativA.UseVisualStyleBackColor = true;
            // 
            // alternativB
            // 
            this.alternativB.AutoSize = true;
            this.alternativB.Location = new System.Drawing.Point(17, 45);
            this.alternativB.Name = "alternativB";
            this.alternativB.Size = new System.Drawing.Size(38, 19);
            this.alternativB.TabIndex = 1;
            this.alternativB.TabStop = true;
            this.alternativB.Text = "Ja";
            this.alternativB.UseVisualStyleBackColor = true;
            // 
            // alternativC
            // 
            this.alternativC.AutoSize = true;
            this.alternativC.Location = new System.Drawing.Point(17, 68);
            this.alternativC.Name = "alternativC";
            this.alternativC.Size = new System.Drawing.Size(84, 19);
            this.alternativC.TabIndex = 1;
            this.alternativC.TabStop = true;
            this.alternativC.Text = "Ingen åsikt";
            this.alternativC.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(134, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "Rösta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gbRost
            // 
            this.gbRost.Controls.Add(this.alternativC);
            this.gbRost.Controls.Add(this.alternativA);
            this.gbRost.Controls.Add(this.alternativB);
            this.gbRost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRost.Location = new System.Drawing.Point(118, 69);
            this.gbRost.Name = "gbRost";
            this.gbRost.Size = new System.Drawing.Size(139, 98);
            this.gbRost.TabIndex = 3;
            this.gbRost.TabStop = false;
            // 
            // lblTack
            // 
            this.lblTack.AutoSize = true;
            this.lblTack.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTack.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTack.Location = new System.Drawing.Point(99, 217);
            this.lblTack.Name = "lblTack";
            this.lblTack.Size = new System.Drawing.Size(0, 19);
            this.lblTack.TabIndex = 4;
            // 
            // lnlRöstaigen
            // 
            this.lnlRöstaigen.AutoSize = true;
            this.lnlRöstaigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnlRöstaigen.Location = new System.Drawing.Point(143, 54);
            this.lnlRöstaigen.Name = "lnlRöstaigen";
            this.lnlRöstaigen.Size = new System.Drawing.Size(86, 20);
            this.lnlRöstaigen.TabIndex = 5;
            this.lnlRöstaigen.TabStop = true;
            this.lnlRöstaigen.Text = "Rösta igen";
            this.lnlRöstaigen.Visible = false;
            this.lnlRöstaigen.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnlRöstaigen_LinkClicked);
            // 
            // Folkomröstning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 308);
            this.Controls.Add(this.lnlRöstaigen);
            this.Controls.Add(this.lblTack);
            this.Controls.Add(this.gbRost);
            this.Controls.Add(this.button1);
            this.Name = "Folkomröstning";
            this.Text = "Folkomröstning";
            this.gbRost.ResumeLayout(false);
            this.gbRost.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton alternativA;
        private System.Windows.Forms.RadioButton alternativB;
        private System.Windows.Forms.RadioButton alternativC;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gbRost;
        private System.Windows.Forms.Label lblTack;
        private System.Windows.Forms.LinkLabel lnlRöstaigen;
    }
}