
namespace ExoListes1et2
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CMD_Add = new System.Windows.Forms.Button();
            this.TXT_Saisie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CMD_Switch1to2 = new System.Windows.Forms.Button();
            this.CMD_Switch2to1 = new System.Windows.Forms.Button();
            this.CMD_Del1 = new System.Windows.Forms.Button();
            this.CMD_Del2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CMD_Add);
            this.groupBox1.Controls.Add(this.TXT_Saisie);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(245, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(705, 123);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Saisir un texte pour l\'intégrer à Liste 1";
            // 
            // CMD_Add
            // 
            this.CMD_Add.Enabled = false;
            this.CMD_Add.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMD_Add.Location = new System.Drawing.Point(495, 52);
            this.CMD_Add.Name = "CMD_Add";
            this.CMD_Add.Size = new System.Drawing.Size(177, 32);
            this.CMD_Add.TabIndex = 2;
            this.CMD_Add.Text = "Ajouter";
            this.CMD_Add.UseVisualStyleBackColor = true;
            this.CMD_Add.Click += new System.EventHandler(this.CMD_Add_Click);
            // 
            // TXT_Saisie
            // 
            this.TXT_Saisie.Location = new System.Drawing.Point(168, 50);
            this.TXT_Saisie.Name = "TXT_Saisie";
            this.TXT_Saisie.Size = new System.Drawing.Size(265, 36);
            this.TXT_Saisie.TabIndex = 1;
            this.TXT_Saisie.TextChanged += new System.EventHandler(this.TXT_Saisie_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saisie :";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(106, 216);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(320, 260);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(764, 216);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(320, 260);
            this.listBox2.TabIndex = 2;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(232, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Liste 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(890, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Liste 2";
            // 
            // CMD_Switch1to2
            // 
            this.CMD_Switch1to2.Enabled = false;
            this.CMD_Switch1to2.Location = new System.Drawing.Point(534, 269);
            this.CMD_Switch1to2.Name = "CMD_Switch1to2";
            this.CMD_Switch1to2.Size = new System.Drawing.Size(125, 45);
            this.CMD_Switch1to2.TabIndex = 5;
            this.CMD_Switch1to2.Text = "--->";
            this.CMD_Switch1to2.UseVisualStyleBackColor = true;
            this.CMD_Switch1to2.Click += new System.EventHandler(this.CMD_Switch1to2_Click);
            // 
            // CMD_Switch2to1
            // 
            this.CMD_Switch2to1.Enabled = false;
            this.CMD_Switch2to1.Location = new System.Drawing.Point(534, 354);
            this.CMD_Switch2to1.Name = "CMD_Switch2to1";
            this.CMD_Switch2to1.Size = new System.Drawing.Size(125, 45);
            this.CMD_Switch2to1.TabIndex = 6;
            this.CMD_Switch2to1.Text = "<---";
            this.CMD_Switch2to1.UseVisualStyleBackColor = true;
            this.CMD_Switch2to1.Click += new System.EventHandler(this.CMD_Switch2to1_Click);
            // 
            // CMD_Del1
            // 
            this.CMD_Del1.Enabled = false;
            this.CMD_Del1.Location = new System.Drawing.Point(166, 501);
            this.CMD_Del1.Name = "CMD_Del1";
            this.CMD_Del1.Size = new System.Drawing.Size(200, 42);
            this.CMD_Del1.TabIndex = 7;
            this.CMD_Del1.Text = "Effacer";
            this.CMD_Del1.UseVisualStyleBackColor = true;
            this.CMD_Del1.Click += new System.EventHandler(this.CMD_Del1_Click);
            // 
            // CMD_Del2
            // 
            this.CMD_Del2.Enabled = false;
            this.CMD_Del2.Location = new System.Drawing.Point(824, 501);
            this.CMD_Del2.Name = "CMD_Del2";
            this.CMD_Del2.Size = new System.Drawing.Size(200, 42);
            this.CMD_Del2.TabIndex = 8;
            this.CMD_Del2.Text = "Effacer";
            this.CMD_Del2.UseVisualStyleBackColor = true;
            this.CMD_Del2.Click += new System.EventHandler(this.CMD_Del2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 579);
            this.Controls.Add(this.CMD_Del2);
            this.Controls.Add(this.CMD_Del1);
            this.Controls.Add(this.CMD_Switch2to1);
            this.Controls.Add(this.CMD_Switch1to2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button CMD_Add;
        private System.Windows.Forms.TextBox TXT_Saisie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CMD_Switch1to2;
        private System.Windows.Forms.Button CMD_Switch2to1;
        private System.Windows.Forms.Button CMD_Del1;
        private System.Windows.Forms.Button CMD_Del2;
    }
}

