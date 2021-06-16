
namespace Calculette3chiffres
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_A = new System.Windows.Forms.TextBox();
            this.TB_B = new System.Windows.Forms.TextBox();
            this.TB_C = new System.Windows.Forms.TextBox();
            this.CMD_Calculate = new System.Windows.Forms.Button();
            this.LB_Min = new System.Windows.Forms.Label();
            this.LB_Max = new System.Windows.Forms.Label();
            this.LB_Sum = new System.Windows.Forms.Label();
            this.LB_Avg = new System.Windows.Forms.Label();
            this.LB_Prd = new System.Windows.Forms.Label();
            this.CMD_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(307, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(494, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "C";
            // 
            // TB_A
            // 
            this.TB_A.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_A.Location = new System.Drawing.Point(86, 92);
            this.TB_A.Name = "TB_A";
            this.TB_A.Size = new System.Drawing.Size(118, 30);
            this.TB_A.TabIndex = 3;
            // 
            // TB_B
            // 
            this.TB_B.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_B.Location = new System.Drawing.Point(264, 92);
            this.TB_B.Name = "TB_B";
            this.TB_B.Size = new System.Drawing.Size(118, 30);
            this.TB_B.TabIndex = 4;
            // 
            // TB_C
            // 
            this.TB_C.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_C.Location = new System.Drawing.Point(449, 92);
            this.TB_C.Name = "TB_C";
            this.TB_C.Size = new System.Drawing.Size(118, 30);
            this.TB_C.TabIndex = 5;
            // 
            // CMD_Calculate
            // 
            this.CMD_Calculate.Enabled = false;
            this.CMD_Calculate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMD_Calculate.Location = new System.Drawing.Point(248, 157);
            this.CMD_Calculate.Name = "CMD_Calculate";
            this.CMD_Calculate.Size = new System.Drawing.Size(147, 44);
            this.CMD_Calculate.TabIndex = 6;
            this.CMD_Calculate.Text = "Calculer";
            this.CMD_Calculate.UseVisualStyleBackColor = true;
            this.CMD_Calculate.Click += new System.EventHandler(this.CMD_Calculate_Click);
            // 
            // LB_Min
            // 
            this.LB_Min.AutoSize = true;
            this.LB_Min.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Min.Location = new System.Drawing.Point(121, 267);
            this.LB_Min.Name = "LB_Min";
            this.LB_Min.Size = new System.Drawing.Size(0, 24);
            this.LB_Min.TabIndex = 7;
            // 
            // LB_Max
            // 
            this.LB_Max.AutoSize = true;
            this.LB_Max.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Max.Location = new System.Drawing.Point(121, 310);
            this.LB_Max.Name = "LB_Max";
            this.LB_Max.Size = new System.Drawing.Size(0, 24);
            this.LB_Max.TabIndex = 8;
            // 
            // LB_Sum
            // 
            this.LB_Sum.AutoSize = true;
            this.LB_Sum.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Sum.Location = new System.Drawing.Point(121, 353);
            this.LB_Sum.Name = "LB_Sum";
            this.LB_Sum.Size = new System.Drawing.Size(0, 24);
            this.LB_Sum.TabIndex = 9;
            // 
            // LB_Avg
            // 
            this.LB_Avg.AutoSize = true;
            this.LB_Avg.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Avg.Location = new System.Drawing.Point(121, 396);
            this.LB_Avg.Name = "LB_Avg";
            this.LB_Avg.Size = new System.Drawing.Size(0, 24);
            this.LB_Avg.TabIndex = 10;
            // 
            // LB_Prd
            // 
            this.LB_Prd.AutoSize = true;
            this.LB_Prd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Prd.Location = new System.Drawing.Point(121, 439);
            this.LB_Prd.Name = "LB_Prd";
            this.LB_Prd.Size = new System.Drawing.Size(0, 24);
            this.LB_Prd.TabIndex = 11;
            // 
            // CMD_Exit
            // 
            this.CMD_Exit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMD_Exit.Location = new System.Drawing.Point(227, 486);
            this.CMD_Exit.Name = "CMD_Exit";
            this.CMD_Exit.Size = new System.Drawing.Size(207, 41);
            this.CMD_Exit.TabIndex = 12;
            this.CMD_Exit.Text = "Quitter";
            this.CMD_Exit.UseVisualStyleBackColor = true;
            this.CMD_Exit.Click += new System.EventHandler(this.CMD_Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 536);
            this.Controls.Add(this.CMD_Exit);
            this.Controls.Add(this.LB_Prd);
            this.Controls.Add(this.LB_Avg);
            this.Controls.Add(this.LB_Sum);
            this.Controls.Add(this.LB_Max);
            this.Controls.Add(this.LB_Min);
            this.Controls.Add(this.CMD_Calculate);
            this.Controls.Add(this.TB_C);
            this.Controls.Add(this.TB_B);
            this.Controls.Add(this.TB_A);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Calculatrice";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_A;
        private System.Windows.Forms.TextBox TB_B;
        private System.Windows.Forms.TextBox TB_C;
        private System.Windows.Forms.Button CMD_Calculate;
        private System.Windows.Forms.Label LB_Min;
        private System.Windows.Forms.Label LB_Max;
        private System.Windows.Forms.Label LB_Sum;
        private System.Windows.Forms.Label LB_Avg;
        private System.Windows.Forms.Label LB_Prd;
        private System.Windows.Forms.Button CMD_Exit;
    }
}

