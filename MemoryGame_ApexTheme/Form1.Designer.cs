namespace MemoryGame_ApexTheme
{
    partial class Form1
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
            this.TurnEasyMode = new System.Windows.Forms.Button();
            this.TurnNormalMode = new System.Windows.Forms.Button();
            this.TurnHardMode = new System.Windows.Forms.Button();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.Copyright = new System.Windows.Forms.ToolStripButton();
            this.Contributors = new System.Windows.Forms.ToolStripButton();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // TurnEasyMode
            // 
            this.TurnEasyMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.TurnEasyMode.Location = new System.Drawing.Point(30, 75);
            this.TurnEasyMode.Name = "TurnEasyMode";
            this.TurnEasyMode.Size = new System.Drawing.Size(75, 23);
            this.TurnEasyMode.TabIndex = 0;
            this.TurnEasyMode.Text = "Easy";
            this.TurnEasyMode.UseVisualStyleBackColor = true;
            this.TurnEasyMode.Click += new System.EventHandler(this.TurnEasyMode_Click);
            // 
            // TurnNormalMode
            // 
            this.TurnNormalMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.TurnNormalMode.Location = new System.Drawing.Point(225, 75);
            this.TurnNormalMode.Name = "TurnNormalMode";
            this.TurnNormalMode.Size = new System.Drawing.Size(75, 23);
            this.TurnNormalMode.TabIndex = 1;
            this.TurnNormalMode.Text = "Normal";
            this.TurnNormalMode.UseVisualStyleBackColor = true;
            this.TurnNormalMode.Click += new System.EventHandler(this.TurnNormalMode_Click);
            // 
            // TurnHardMode
            // 
            this.TurnHardMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.TurnHardMode.Location = new System.Drawing.Point(127, 164);
            this.TurnHardMode.Name = "TurnHardMode";
            this.TurnHardMode.Size = new System.Drawing.Size(75, 23);
            this.TurnHardMode.TabIndex = 2;
            this.TurnHardMode.Text = "Hard";
            this.TurnHardMode.UseVisualStyleBackColor = true;
            this.TurnHardMode.Click += new System.EventHandler(this.TurnHardMode_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Copyright,
            this.Contributors});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(339, 25);
            this.toolStrip.TabIndex = 3;
            this.toolStrip.Text = "toolStrip1";
            // 
            // Copyright
            // 
            this.Copyright.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Copyright.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Copyright.Name = "Copyright";
            this.Copyright.Size = new System.Drawing.Size(85, 22);
            this.Copyright.Text = "CopyrightInfo";
            this.Copyright.Click += new System.EventHandler(this.Copyright_Click);
            // 
            // Contributors
            // 
            this.Contributors.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Contributors.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Contributors.Name = "Contributors";
            this.Contributors.Size = new System.Drawing.Size(109, 22);
            this.Contributors.Text = "Code Contributors";
            this.Contributors.Click += new System.EventHandler(this.Contributors_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::MemoryGame_ApexTheme.Properties.Resources.Theme;
            this.ClientSize = new System.Drawing.Size(339, 280);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.TurnHardMode);
            this.Controls.Add(this.TurnNormalMode);
            this.Controls.Add(this.TurnEasyMode);
            this.MaximumSize = new System.Drawing.Size(355, 318);
            this.MinimumSize = new System.Drawing.Size(355, 318);
            this.Name = "Form1";
            this.Text = "PlayMemory";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TurnEasyMode;
        private System.Windows.Forms.Button TurnNormalMode;
        private System.Windows.Forms.Button TurnHardMode;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton Copyright;
        private System.Windows.Forms.ToolStripButton Contributors;
    }
}

