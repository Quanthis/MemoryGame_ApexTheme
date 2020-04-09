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
            this.SuspendLayout();
            // 
            // TurnEasyMode
            // 
            this.TurnEasyMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.TurnEasyMode.Location = new System.Drawing.Point(50, 100);
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
            this.TurnNormalMode.Location = new System.Drawing.Point(202, 100);
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
            this.TurnHardMode.Location = new System.Drawing.Point(354, 100);
            this.TurnHardMode.Name = "TurnHardMode";
            this.TurnHardMode.Size = new System.Drawing.Size(75, 23);
            this.TurnHardMode.TabIndex = 2;
            this.TurnHardMode.Text = "Hard";
            this.TurnHardMode.UseVisualStyleBackColor = true;
            this.TurnHardMode.Click += new System.EventHandler(this.TurnHardMode_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::MemoryGame_ApexTheme.Properties.Resources.QuestionMark;
            this.ClientSize = new System.Drawing.Size(464, 222);
            this.Controls.Add(this.TurnHardMode);
            this.Controls.Add(this.TurnNormalMode);
            this.Controls.Add(this.TurnEasyMode);
            this.Name = "Form1";
            this.Text = "PlayMemory";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TurnEasyMode;
        private System.Windows.Forms.Button TurnNormalMode;
        private System.Windows.Forms.Button TurnHardMode;
    }
}

