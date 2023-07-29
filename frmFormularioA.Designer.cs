namespace aplicativoMergeGit
{
    partial class frmFormularioA
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
            this.lblChamaA = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblChamaA
            // 
            this.lblChamaA.AutoSize = true;
            this.lblChamaA.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChamaA.Location = new System.Drawing.Point(58, 227);
            this.lblChamaA.Name = "lblChamaA";
            this.lblChamaA.Size = new System.Drawing.Size(164, 22);
            this.lblChamaA.TabIndex = 0;
            this.lblChamaA.Text = "Chamou o Frm A";
            // 
            // frmFormularioA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 521);
            this.Controls.Add(this.lblChamaA);
            this.Name = "frmFormularioA";
            this.Text = "frmFormularioA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChamaA;
    }
}