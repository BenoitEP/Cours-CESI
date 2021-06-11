
namespace GestStagiaire
{
    partial class F_Choix
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
            this.CbStagiaire = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CbStagiaire
            // 
            this.CbStagiaire.FormattingEnabled = true;
            this.CbStagiaire.Location = new System.Drawing.Point(63, 29);
            this.CbStagiaire.Name = "CbStagiaire";
            this.CbStagiaire.Size = new System.Drawing.Size(594, 24);
            this.CbStagiaire.TabIndex = 0;
            this.CbStagiaire.SelectedIndexChanged += new System.EventHandler(this.CbStagiaire_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(230, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(229, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "Valider";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // F_Choix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 182);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CbStagiaire);
            this.Name = "F_Choix";
            this.Text = "Choix du stagiaire";
            this.Load += new System.EventHandler(this.F_Choix_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CbStagiaire;
        private System.Windows.Forms.Button button1;
    }
}