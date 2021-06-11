
namespace GestStagiaire
{
    partial class F_AfficheAuto
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idStagiaireDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomStagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomStagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateNaissanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tStagiaireBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stagiaireDataSet = new GestStagiaire.StagiaireDataSet();
            this.tStagiaireTableAdapter = new GestStagiaire.StagiaireDataSetTableAdapters.TStagiaireTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tStagiaireBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stagiaireDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idStagiaireDataGridViewTextBoxColumn,
            this.nomStagDataGridViewTextBoxColumn,
            this.prenomStagDataGridViewTextBoxColumn,
            this.sectionDataGridViewTextBoxColumn,
            this.dateNaissanceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tStagiaireBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(27, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1130, 302);
            this.dataGridView1.TabIndex = 0;
            // 
            // idStagiaireDataGridViewTextBoxColumn
            // 
            this.idStagiaireDataGridViewTextBoxColumn.DataPropertyName = "id_Stagiaire";
            this.idStagiaireDataGridViewTextBoxColumn.HeaderText = "id_Stagiaire";
            this.idStagiaireDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idStagiaireDataGridViewTextBoxColumn.Name = "idStagiaireDataGridViewTextBoxColumn";
            this.idStagiaireDataGridViewTextBoxColumn.Width = 125;
            // 
            // nomStagDataGridViewTextBoxColumn
            // 
            this.nomStagDataGridViewTextBoxColumn.DataPropertyName = "NomStag";
            this.nomStagDataGridViewTextBoxColumn.HeaderText = "NomStag";
            this.nomStagDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomStagDataGridViewTextBoxColumn.Name = "nomStagDataGridViewTextBoxColumn";
            this.nomStagDataGridViewTextBoxColumn.Width = 125;
            // 
            // prenomStagDataGridViewTextBoxColumn
            // 
            this.prenomStagDataGridViewTextBoxColumn.DataPropertyName = "PrenomStag";
            this.prenomStagDataGridViewTextBoxColumn.HeaderText = "PrenomStag";
            this.prenomStagDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prenomStagDataGridViewTextBoxColumn.Name = "prenomStagDataGridViewTextBoxColumn";
            this.prenomStagDataGridViewTextBoxColumn.Width = 125;
            // 
            // sectionDataGridViewTextBoxColumn
            // 
            this.sectionDataGridViewTextBoxColumn.DataPropertyName = "Section";
            this.sectionDataGridViewTextBoxColumn.HeaderText = "Section";
            this.sectionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sectionDataGridViewTextBoxColumn.Name = "sectionDataGridViewTextBoxColumn";
            this.sectionDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateNaissanceDataGridViewTextBoxColumn
            // 
            this.dateNaissanceDataGridViewTextBoxColumn.DataPropertyName = "DateNaissance";
            this.dateNaissanceDataGridViewTextBoxColumn.HeaderText = "DateNaissance";
            this.dateNaissanceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateNaissanceDataGridViewTextBoxColumn.Name = "dateNaissanceDataGridViewTextBoxColumn";
            this.dateNaissanceDataGridViewTextBoxColumn.Width = 125;
            // 
            // tStagiaireBindingSource
            // 
            this.tStagiaireBindingSource.DataMember = "TStagiaire";
            this.tStagiaireBindingSource.DataSource = this.stagiaireDataSet;
            // 
            // stagiaireDataSet
            // 
            this.stagiaireDataSet.DataSetName = "StagiaireDataSet";
            this.stagiaireDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tStagiaireTableAdapter
            // 
            this.tStagiaireTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(397, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(374, 58);
            this.button1.TabIndex = 1;
            this.button1.Text = "Fermer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // F_AfficheAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 491);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "F_AfficheAuto";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.F_AfficheAuto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tStagiaireBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stagiaireDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private StagiaireDataSet stagiaireDataSet;
        private System.Windows.Forms.BindingSource tStagiaireBindingSource;
        private StagiaireDataSetTableAdapters.TStagiaireTableAdapter tStagiaireTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idStagiaireDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomStagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomStagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateNaissanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}