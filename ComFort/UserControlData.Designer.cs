namespace ComFort
{
    partial class UserControlData
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.userControlLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userControlLabel
            // 
            this.userControlLabel.AutoSize = true;
            this.userControlLabel.Location = new System.Drawing.Point(7, 4);
            this.userControlLabel.Name = "userControlLabel";
            this.userControlLabel.Size = new System.Drawing.Size(35, 13);
            this.userControlLabel.TabIndex = 0;
            this.userControlLabel.Text = "label1";
            // 
            // UserControlData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.userControlLabel);
            this.Name = "UserControlData";
            this.Size = new System.Drawing.Size(203, 21);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userControlLabel;
    }
}
