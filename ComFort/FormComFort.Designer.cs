namespace ComFort
{
    partial class FormComFort
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
            this.manutencaoTabelaButton = new System.Windows.Forms.Button();
            this.listaDadosButton = new System.Windows.Forms.Button();
            this.aboutButton = new System.Windows.Forms.Button();
            this.sairButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // manutencaoTabelaButton
            // 
            this.manutencaoTabelaButton.Location = new System.Drawing.Point(77, 22);
            this.manutencaoTabelaButton.Name = "manutencaoTabelaButton";
            this.manutencaoTabelaButton.Size = new System.Drawing.Size(132, 23);
            this.manutencaoTabelaButton.TabIndex = 1;
            this.manutencaoTabelaButton.Text = "Manutenção Tabela";
            this.manutencaoTabelaButton.UseVisualStyleBackColor = true;
            this.manutencaoTabelaButton.Click += new System.EventHandler(this.manutencaoTabelaButton_Click);
            // 
            // listaDadosButton
            // 
            this.listaDadosButton.Location = new System.Drawing.Point(77, 51);
            this.listaDadosButton.Name = "listaDadosButton";
            this.listaDadosButton.Size = new System.Drawing.Size(132, 23);
            this.listaDadosButton.TabIndex = 2;
            this.listaDadosButton.Text = "Lista de Dados";
            this.listaDadosButton.UseVisualStyleBackColor = true;
            this.listaDadosButton.Click += new System.EventHandler(this.listaDadosButton_Click);
            // 
            // aboutButton
            // 
            this.aboutButton.Location = new System.Drawing.Point(77, 80);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(132, 23);
            this.aboutButton.TabIndex = 3;
            this.aboutButton.Text = "Sobre";
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // sairButton
            // 
            this.sairButton.Location = new System.Drawing.Point(77, 109);
            this.sairButton.Name = "sairButton";
            this.sairButton.Size = new System.Drawing.Size(132, 23);
            this.sairButton.TabIndex = 4;
            this.sairButton.Text = "Sair";
            this.sairButton.UseVisualStyleBackColor = true;
            this.sairButton.Click += new System.EventHandler(this.sairButton_Click);
            // 
            // FormComFort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.sairButton);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.listaDadosButton);
            this.Controls.Add(this.manutencaoTabelaButton);
            this.Name = "FormComFort";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ComFort";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button manutencaoTabelaButton;
        private System.Windows.Forms.Button listaDadosButton;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.Button sairButton;
    }
}

