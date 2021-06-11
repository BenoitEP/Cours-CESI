
namespace GestStagiaire
{
    partial class FMenu
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.applicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fermerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionStagiaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.créationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ficheStagiaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeStagiaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.TSL_NbStag = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicToolStripMenuItem,
            this.gestionStagiaireToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // applicToolStripMenuItem
            // 
            this.applicToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ouvrirToolStripMenuItem,
            this.fermerToolStripMenuItem});
            this.applicToolStripMenuItem.Name = "applicToolStripMenuItem";
            this.applicToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.applicToolStripMenuItem.Text = "Application";
            // 
            // ouvrirToolStripMenuItem
            // 
            this.ouvrirToolStripMenuItem.Name = "ouvrirToolStripMenuItem";
            this.ouvrirToolStripMenuItem.Size = new System.Drawing.Size(138, 26);
            this.ouvrirToolStripMenuItem.Text = "Ouvrir";
            // 
            // fermerToolStripMenuItem
            // 
            this.fermerToolStripMenuItem.Name = "fermerToolStripMenuItem";
            this.fermerToolStripMenuItem.Size = new System.Drawing.Size(138, 26);
            this.fermerToolStripMenuItem.Text = "Fermer";
            this.fermerToolStripMenuItem.Click += new System.EventHandler(this.fermerToolStripMenuItem_Click);
            // 
            // gestionStagiaireToolStripMenuItem
            // 
            this.gestionStagiaireToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.créationToolStripMenuItem,
            this.ficheStagiaireToolStripMenuItem,
            this.listeStagiaireToolStripMenuItem});
            this.gestionStagiaireToolStripMenuItem.Name = "gestionStagiaireToolStripMenuItem";
            this.gestionStagiaireToolStripMenuItem.Size = new System.Drawing.Size(136, 24);
            this.gestionStagiaireToolStripMenuItem.Text = "Gestion Stagiaire";
            this.gestionStagiaireToolStripMenuItem.Click += new System.EventHandler(this.gestionStagiaireToolStripMenuItem_Click);
            // 
            // créationToolStripMenuItem
            // 
            this.créationToolStripMenuItem.Name = "créationToolStripMenuItem";
            this.créationToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.créationToolStripMenuItem.Text = "Création";
            this.créationToolStripMenuItem.Click += new System.EventHandler(this.créationToolStripMenuItem_Click);
            // 
            // ficheStagiaireToolStripMenuItem
            // 
            this.ficheStagiaireToolStripMenuItem.Name = "ficheStagiaireToolStripMenuItem";
            this.ficheStagiaireToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.ficheStagiaireToolStripMenuItem.Text = "Fiche stagiaire";
            this.ficheStagiaireToolStripMenuItem.Click += new System.EventHandler(this.ficheStagiaireToolStripMenuItem_Click);
            // 
            // listeStagiaireToolStripMenuItem
            // 
            this.listeStagiaireToolStripMenuItem.Name = "listeStagiaireToolStripMenuItem";
            this.listeStagiaireToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.listeStagiaireToolStripMenuItem.Text = "Liste stagiaire";
            this.listeStagiaireToolStripMenuItem.Click += new System.EventHandler(this.listeStagiaireToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSL_NbStag});
            this.statusStrip1.Location = new System.Drawing.Point(0, 424);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // TSL_NbStag
            // 
            this.TSL_NbStag.Name = "TSL_NbStag";
            this.TSL_NbStag.Size = new System.Drawing.Size(151, 20);
            this.TSL_NbStag.Text = "toolStripStatusLabel1";
            // 
            // FMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FMenu";
            this.Text = "Application de gestion des stagiaires";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem applicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ouvrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fermerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionStagiaireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem créationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ficheStagiaireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeStagiaireToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel TSL_NbStag;
    }
}

