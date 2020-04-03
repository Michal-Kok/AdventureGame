namespace AdventureGame
{
    partial class AdventureGame
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_HitPoints = new System.Windows.Forms.Label();
            this.lbl_Gold = new System.Windows.Forms.Label();
            this.lbl_Experience = new System.Windows.Forms.Label();
            this.lbl_Level = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Hit Points:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Gold:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Experience:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "Level:";
            // 
            // lbl_HitPoints
            // 
            this.lbl_HitPoints.AutoSize = true;
            this.lbl_HitPoints.Location = new System.Drawing.Point(110, 19);
            this.lbl_HitPoints.Name = "lbl_HitPoints";
            this.lbl_HitPoints.Size = new System.Drawing.Size(0, 17);
            this.lbl_HitPoints.TabIndex = 4;
            // 
            // lbl_Gold
            // 
            this.lbl_Gold.AutoSize = true;
            this.lbl_Gold.Location = new System.Drawing.Point(110, 45);
            this.lbl_Gold.Name = "lbl_Gold";
            this.lbl_Gold.Size = new System.Drawing.Size(0, 17);
            this.lbl_Gold.TabIndex = 5;
            // 
            // lbl_Experience
            // 
            this.lbl_Experience.AutoSize = true;
            this.lbl_Experience.Location = new System.Drawing.Point(110, 73);
            this.lbl_Experience.Name = "lbl_Experience";
            this.lbl_Experience.Size = new System.Drawing.Size(0, 17);
            this.lbl_Experience.TabIndex = 6;
            // 
            // lbl_Level
            // 
            this.lbl_Level.AutoSize = true;
            this.lbl_Level.Location = new System.Drawing.Point(110, 99);
            this.lbl_Level.Name = "lbl_Level";
            this.lbl_Level.Size = new System.Drawing.Size(0, 17);
            this.lbl_Level.TabIndex = 7;
            // 
            // AdventureGame
            // 
            this.ClientSize = new System.Drawing.Size(717, 643);
            this.Controls.Add(this.lbl_Level);
            this.Controls.Add(this.lbl_Experience);
            this.Controls.Add(this.lbl_Gold);
            this.Controls.Add(this.lbl_HitPoints);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Name = "AdventureGame";
            this.Text = "Adventure Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblHitPoints;
        private System.Windows.Forms.Label lblGold;
        private System.Windows.Forms.Label lblExperience;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_HitPoints;
        private System.Windows.Forms.Label lbl_Gold;
        private System.Windows.Forms.Label lbl_Experience;
        private System.Windows.Forms.Label lbl_Level;
    }
}

