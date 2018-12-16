namespace AsfandMalik
{
    partial class RöstresultatForm
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
            this.lbPartiList = new System.Windows.Forms.ListBox();
            this.btnRapportera = new System.Windows.Forms.Button();
            this.lblPartiNamn = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAntalRöster = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbPartiList
            // 
            this.lbPartiList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPartiList.FormattingEnabled = true;
            this.lbPartiList.ItemHeight = 16;
            this.lbPartiList.Location = new System.Drawing.Point(32, 30);
            this.lbPartiList.Name = "lbPartiList";
            this.lbPartiList.Size = new System.Drawing.Size(189, 244);
            this.lbPartiList.TabIndex = 0;
            this.lbPartiList.SelectedIndexChanged += new System.EventHandler(this.lbPartiList_SelectedIndexChanged);
            // 
            // btnRapportera
            // 
            this.btnRapportera.Location = new System.Drawing.Point(249, 248);
            this.btnRapportera.Name = "btnRapportera";
            this.btnRapportera.Size = new System.Drawing.Size(138, 32);
            this.btnRapportera.TabIndex = 1;
            this.btnRapportera.Text = "Rapportera";
            this.btnRapportera.UseVisualStyleBackColor = true;
            this.btnRapportera.Click += new System.EventHandler(this.btnRapportera_Click);
            // 
            // lblPartiNamn
            // 
            this.lblPartiNamn.AutoSize = true;
            this.lblPartiNamn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartiNamn.Location = new System.Drawing.Point(249, 173);
            this.lblPartiNamn.Name = "lblPartiNamn";
            this.lblPartiNamn.Size = new System.Drawing.Size(0, 16);
            this.lblPartiNamn.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(249, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Antal röster";
            // 
            // tbAntalRöster
            // 
            this.tbAntalRöster.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAntalRöster.Location = new System.Drawing.Point(252, 218);
            this.tbAntalRöster.Name = "tbAntalRöster";
            this.tbAntalRöster.Size = new System.Drawing.Size(135, 21);
            this.tbAntalRöster.TabIndex = 3;
            // 
            // RöstresultatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 331);
            this.Controls.Add(this.tbAntalRöster);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPartiNamn);
            this.Controls.Add(this.btnRapportera);
            this.Controls.Add(this.lbPartiList);
            this.Name = "RöstresultatForm";
            this.Text = "Röstresultat";
            this.Load += new System.EventHandler(this.Röstresultat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbPartiList;
        private System.Windows.Forms.Button btnRapportera;
        private System.Windows.Forms.Label lblPartiNamn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAntalRöster;
    }
}