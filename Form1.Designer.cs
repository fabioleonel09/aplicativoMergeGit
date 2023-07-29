namespace aplicativoMergeGit
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnEntrarFormA = new System.Windows.Forms.Button();
            this.btnEntrarFormB = new System.Windows.Forms.Button();
            this.btnEntrarFormC = new System.Windows.Forms.Button();
            this.btnEntrarFormD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(110, 125);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(397, 22);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Sistema de teste para Merge - Git Desktop";
            // 
            // btnEntrarFormA
            // 
            this.btnEntrarFormA.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrarFormA.Location = new System.Drawing.Point(27, 280);
            this.btnEntrarFormA.Name = "btnEntrarFormA";
            this.btnEntrarFormA.Size = new System.Drawing.Size(131, 67);
            this.btnEntrarFormA.TabIndex = 1;
            this.btnEntrarFormA.Text = "Entrar Form A";
            this.btnEntrarFormA.UseVisualStyleBackColor = true;
            this.btnEntrarFormA.Click += new System.EventHandler(this.btnEntrarFormA_Click);
            // 
            // btnEntrarFormB
            // 
            this.btnEntrarFormB.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrarFormB.Location = new System.Drawing.Point(164, 280);
            this.btnEntrarFormB.Name = "btnEntrarFormB";
            this.btnEntrarFormB.Size = new System.Drawing.Size(131, 67);
            this.btnEntrarFormB.TabIndex = 2;
            this.btnEntrarFormB.Text = "Entrar Form B";
            this.btnEntrarFormB.UseVisualStyleBackColor = true;
            // 
            // btnEntrarFormC
            // 
            this.btnEntrarFormC.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrarFormC.Location = new System.Drawing.Point(301, 280);
            this.btnEntrarFormC.Name = "btnEntrarFormC";
            this.btnEntrarFormC.Size = new System.Drawing.Size(131, 67);
            this.btnEntrarFormC.TabIndex = 3;
            this.btnEntrarFormC.Text = "Entrar Form C";
            this.btnEntrarFormC.UseVisualStyleBackColor = true;
            // 
            // btnEntrarFormD
            // 
            this.btnEntrarFormD.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrarFormD.Location = new System.Drawing.Point(438, 280);
            this.btnEntrarFormD.Name = "btnEntrarFormD";
            this.btnEntrarFormD.Size = new System.Drawing.Size(131, 67);
            this.btnEntrarFormD.TabIndex = 4;
            this.btnEntrarFormD.Text = "Entrar Form D";
            this.btnEntrarFormD.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 408);
            this.Controls.Add(this.btnEntrarFormD);
            this.Controls.Add(this.btnEntrarFormC);
            this.Controls.Add(this.btnEntrarFormB);
            this.Controls.Add(this.btnEntrarFormA);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnEntrarFormA;
        private System.Windows.Forms.Button btnEntrarFormB;
        private System.Windows.Forms.Button btnEntrarFormC;
        private System.Windows.Forms.Button btnEntrarFormD;
    }
}

