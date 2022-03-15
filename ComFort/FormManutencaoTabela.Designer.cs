namespace ComFort
{
    partial class FormManutencaoTabela
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
            this.gravarButton = new System.Windows.Forms.Button();
            this.proformaTextBox = new System.Windows.Forms.TextBox();
            this.nomeClienteTextBox = new System.Windows.Forms.TextBox();
            this.dataCompraDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.moradaClienteTextBox = new System.Windows.Forms.TextBox();
            this.contatoClienteTextBox = new System.Windows.Forms.TextBox();
            this.proformaLabel = new System.Windows.Forms.Label();
            this.dataCompraLabel = new System.Windows.Forms.Label();
            this.nomeClienteLabel = new System.Windows.Forms.Label();
            this.nomeProdutoTextBox = new System.Windows.Forms.TextBox();
            this.precoProdutoTextBox = new System.Windows.Forms.TextBox();
            this.moradaClienteLabel = new System.Windows.Forms.Label();
            this.contatoClienteLabel = new System.Windows.Forms.Label();
            this.nomeProdutoLabel = new System.Windows.Forms.Label();
            this.precoProdutoLabel = new System.Windows.Forms.Label();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.sairButton = new System.Windows.Forms.Button();
            this.listaButton = new System.Windows.Forms.Button();
            this.componenteMenuStrip = new System.Windows.Forms.MenuStrip();
            this.ficheiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gravarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manutencaoTabelaErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.dadosClienteGroupBox = new System.Windows.Forms.GroupBox();
            this.dadosProdutoGroupBox = new System.Windows.Forms.GroupBox();
            this.userControlButton = new System.Windows.Forms.Button();
            this.userControlData = new ComFort.UserControlData();
            this.componenteMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manutencaoTabelaErrorProvider)).BeginInit();
            this.dadosClienteGroupBox.SuspendLayout();
            this.dadosProdutoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // gravarButton
            // 
            this.gravarButton.Location = new System.Drawing.Point(353, 174);
            this.gravarButton.Name = "gravarButton";
            this.gravarButton.Size = new System.Drawing.Size(75, 52);
            this.gravarButton.TabIndex = 9;
            this.gravarButton.Text = "Gravar";
            this.gravarButton.UseVisualStyleBackColor = true;
            this.gravarButton.Click += new System.EventHandler(this.gravarButton_Click);
            // 
            // proformaTextBox
            // 
            this.proformaTextBox.Location = new System.Drawing.Point(72, 41);
            this.proformaTextBox.Name = "proformaTextBox";
            this.proformaTextBox.Size = new System.Drawing.Size(129, 20);
            this.proformaTextBox.TabIndex = 1;
            this.proformaTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.proformaTextBox_KeyUp);
            // 
            // nomeClienteTextBox
            // 
            this.nomeClienteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeClienteTextBox.Location = new System.Drawing.Point(62, 28);
            this.nomeClienteTextBox.Name = "nomeClienteTextBox";
            this.nomeClienteTextBox.Size = new System.Drawing.Size(252, 20);
            this.nomeClienteTextBox.TabIndex = 4;
            // 
            // dataCompraDateTimePicker
            // 
            this.dataCompraDateTimePicker.Location = new System.Drawing.Point(381, 41);
            this.dataCompraDateTimePicker.Name = "dataCompraDateTimePicker";
            this.dataCompraDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dataCompraDateTimePicker.TabIndex = 3;
            // 
            // moradaClienteTextBox
            // 
            this.moradaClienteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moradaClienteTextBox.Location = new System.Drawing.Point(62, 55);
            this.moradaClienteTextBox.Name = "moradaClienteTextBox";
            this.moradaClienteTextBox.Size = new System.Drawing.Size(252, 20);
            this.moradaClienteTextBox.TabIndex = 5;
            // 
            // contatoClienteTextBox
            // 
            this.contatoClienteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contatoClienteTextBox.Location = new System.Drawing.Point(62, 81);
            this.contatoClienteTextBox.Name = "contatoClienteTextBox";
            this.contatoClienteTextBox.Size = new System.Drawing.Size(252, 20);
            this.contatoClienteTextBox.TabIndex = 6;
            // 
            // proformaLabel
            // 
            this.proformaLabel.AutoSize = true;
            this.proformaLabel.Location = new System.Drawing.Point(16, 44);
            this.proformaLabel.Name = "proformaLabel";
            this.proformaLabel.Size = new System.Drawing.Size(52, 13);
            this.proformaLabel.TabIndex = 0;
            this.proformaLabel.Text = "Proforma:";
            // 
            // dataCompraLabel
            // 
            this.dataCompraLabel.AutoSize = true;
            this.dataCompraLabel.Location = new System.Drawing.Point(288, 44);
            this.dataCompraLabel.Name = "dataCompraLabel";
            this.dataCompraLabel.Size = new System.Drawing.Size(87, 13);
            this.dataCompraLabel.TabIndex = 0;
            this.dataCompraLabel.Text = "Data de Compra:";
            // 
            // nomeClienteLabel
            // 
            this.nomeClienteLabel.AutoSize = true;
            this.nomeClienteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeClienteLabel.Location = new System.Drawing.Point(6, 31);
            this.nomeClienteLabel.Name = "nomeClienteLabel";
            this.nomeClienteLabel.Size = new System.Drawing.Size(38, 13);
            this.nomeClienteLabel.TabIndex = 0;
            this.nomeClienteLabel.Text = "Nome:";
            // 
            // nomeProdutoTextBox
            // 
            this.nomeProdutoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeProdutoTextBox.Location = new System.Drawing.Point(62, 28);
            this.nomeProdutoTextBox.Name = "nomeProdutoTextBox";
            this.nomeProdutoTextBox.Size = new System.Drawing.Size(185, 20);
            this.nomeProdutoTextBox.TabIndex = 7;
            // 
            // precoProdutoTextBox
            // 
            this.precoProdutoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precoProdutoTextBox.Location = new System.Drawing.Point(62, 54);
            this.precoProdutoTextBox.Name = "precoProdutoTextBox";
            this.precoProdutoTextBox.Size = new System.Drawing.Size(185, 20);
            this.precoProdutoTextBox.TabIndex = 8;
            // 
            // moradaClienteLabel
            // 
            this.moradaClienteLabel.AutoSize = true;
            this.moradaClienteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moradaClienteLabel.Location = new System.Drawing.Point(6, 58);
            this.moradaClienteLabel.Name = "moradaClienteLabel";
            this.moradaClienteLabel.Size = new System.Drawing.Size(46, 13);
            this.moradaClienteLabel.TabIndex = 0;
            this.moradaClienteLabel.Text = "Morada:";
            // 
            // contatoClienteLabel
            // 
            this.contatoClienteLabel.AutoSize = true;
            this.contatoClienteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contatoClienteLabel.Location = new System.Drawing.Point(6, 84);
            this.contatoClienteLabel.Name = "contatoClienteLabel";
            this.contatoClienteLabel.Size = new System.Drawing.Size(47, 13);
            this.contatoClienteLabel.TabIndex = 0;
            this.contatoClienteLabel.Text = "Contato:";
            // 
            // nomeProdutoLabel
            // 
            this.nomeProdutoLabel.AutoSize = true;
            this.nomeProdutoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeProdutoLabel.Location = new System.Drawing.Point(6, 31);
            this.nomeProdutoLabel.Name = "nomeProdutoLabel";
            this.nomeProdutoLabel.Size = new System.Drawing.Size(47, 13);
            this.nomeProdutoLabel.TabIndex = 0;
            this.nomeProdutoLabel.Text = "Produto:";
            // 
            // precoProdutoLabel
            // 
            this.precoProdutoLabel.AutoSize = true;
            this.precoProdutoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precoProdutoLabel.Location = new System.Drawing.Point(6, 57);
            this.precoProdutoLabel.Name = "precoProdutoLabel";
            this.precoProdutoLabel.Size = new System.Drawing.Size(38, 13);
            this.precoProdutoLabel.TabIndex = 0;
            this.precoProdutoLabel.Text = "Preço:";
            // 
            // EliminarButton
            // 
            this.EliminarButton.Location = new System.Drawing.Point(434, 174);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(75, 52);
            this.EliminarButton.TabIndex = 10;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.eliminarButton_Click);
            // 
            // sairButton
            // 
            this.sairButton.Location = new System.Drawing.Point(515, 174);
            this.sairButton.Name = "sairButton";
            this.sairButton.Size = new System.Drawing.Size(75, 52);
            this.sairButton.TabIndex = 11;
            this.sairButton.Text = "Sair";
            this.sairButton.UseVisualStyleBackColor = true;
            this.sairButton.Click += new System.EventHandler(this.sairButton_Click);
            // 
            // listaButton
            // 
            this.listaButton.Location = new System.Drawing.Point(207, 35);
            this.listaButton.Name = "listaButton";
            this.listaButton.Size = new System.Drawing.Size(28, 30);
            this.listaButton.TabIndex = 2;
            this.listaButton.Text = "...";
            this.listaButton.UseVisualStyleBackColor = true;
            this.listaButton.Click += new System.EventHandler(this.listaButton_Click);
            // 
            // componenteMenuStrip
            // 
            this.componenteMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ficheiroToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.componenteMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.componenteMenuStrip.Name = "componenteMenuStrip";
            this.componenteMenuStrip.Size = new System.Drawing.Size(611, 24);
            this.componenteMenuStrip.TabIndex = 20;
            this.componenteMenuStrip.Text = "menuStrip1";
            // 
            // ficheiroToolStripMenuItem
            // 
            this.ficheiroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gravarToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.ficheiroToolStripMenuItem.Name = "ficheiroToolStripMenuItem";
            this.ficheiroToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.ficheiroToolStripMenuItem.Text = "&Ficheiro";
            // 
            // gravarToolStripMenuItem
            // 
            this.gravarToolStripMenuItem.Name = "gravarToolStripMenuItem";
            this.gravarToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.gravarToolStripMenuItem.Text = "&Gravar";
            this.gravarToolStripMenuItem.Click += new System.EventHandler(this.gravarButton_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.eliminarToolStripMenuItem.Text = "&Eliminar";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.sairToolStripMenuItem.Text = "&Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairButton_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "&Ajuda";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.sobreToolStripMenuItem.Text = "Sobre...";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // manutencaoTabelaErrorProvider
            // 
            this.manutencaoTabelaErrorProvider.ContainerControl = this;
            // 
            // dadosClienteGroupBox
            // 
            this.dadosClienteGroupBox.Controls.Add(this.nomeClienteLabel);
            this.dadosClienteGroupBox.Controls.Add(this.nomeClienteTextBox);
            this.dadosClienteGroupBox.Controls.Add(this.moradaClienteTextBox);
            this.dadosClienteGroupBox.Controls.Add(this.contatoClienteTextBox);
            this.dadosClienteGroupBox.Controls.Add(this.moradaClienteLabel);
            this.dadosClienteGroupBox.Controls.Add(this.contatoClienteLabel);
            this.dadosClienteGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dadosClienteGroupBox.Location = new System.Drawing.Point(12, 82);
            this.dadosClienteGroupBox.Name = "dadosClienteGroupBox";
            this.dadosClienteGroupBox.Size = new System.Drawing.Size(326, 115);
            this.dadosClienteGroupBox.TabIndex = 21;
            this.dadosClienteGroupBox.TabStop = false;
            this.dadosClienteGroupBox.Text = "Dados do Cliente:";
            // 
            // dadosProdutoGroupBox
            // 
            this.dadosProdutoGroupBox.Controls.Add(this.nomeProdutoLabel);
            this.dadosProdutoGroupBox.Controls.Add(this.nomeProdutoTextBox);
            this.dadosProdutoGroupBox.Controls.Add(this.precoProdutoTextBox);
            this.dadosProdutoGroupBox.Controls.Add(this.precoProdutoLabel);
            this.dadosProdutoGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dadosProdutoGroupBox.Location = new System.Drawing.Point(344, 82);
            this.dadosProdutoGroupBox.Name = "dadosProdutoGroupBox";
            this.dadosProdutoGroupBox.Size = new System.Drawing.Size(255, 86);
            this.dadosProdutoGroupBox.TabIndex = 22;
            this.dadosProdutoGroupBox.TabStop = false;
            this.dadosProdutoGroupBox.Text = "Dados do Produto";
            // 
            // userControlButton
            // 
            this.userControlButton.Location = new System.Drawing.Point(263, 203);
            this.userControlButton.Name = "userControlButton";
            this.userControlButton.Size = new System.Drawing.Size(75, 23);
            this.userControlButton.TabIndex = 24;
            this.userControlButton.Text = "Verificar";
            this.userControlButton.UseVisualStyleBackColor = true;
            this.userControlButton.Click += new System.EventHandler(this.userControlButton_Click);
            // 
            // userControlData
            // 
            this.userControlData.Location = new System.Drawing.Point(135, 203);
            this.userControlData.Name = "userControlData";
            this.userControlData.Size = new System.Drawing.Size(122, 38);
            this.userControlData.TabIndex = 23;
            this.userControlData.Texto = null;
            // 
            // FormManutencaoTabela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 238);
            this.Controls.Add(this.userControlButton);
            this.Controls.Add(this.userControlData);
            this.Controls.Add(this.dadosProdutoGroupBox);
            this.Controls.Add(this.dadosClienteGroupBox);
            this.Controls.Add(this.listaButton);
            this.Controls.Add(this.sairButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.dataCompraLabel);
            this.Controls.Add(this.proformaLabel);
            this.Controls.Add(this.dataCompraDateTimePicker);
            this.Controls.Add(this.proformaTextBox);
            this.Controls.Add(this.gravarButton);
            this.Controls.Add(this.componenteMenuStrip);
            this.MainMenuStrip = this.componenteMenuStrip;
            this.Name = "FormManutencaoTabela";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ComFort";
            this.componenteMenuStrip.ResumeLayout(false);
            this.componenteMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manutencaoTabelaErrorProvider)).EndInit();
            this.dadosClienteGroupBox.ResumeLayout(false);
            this.dadosClienteGroupBox.PerformLayout();
            this.dadosProdutoGroupBox.ResumeLayout(false);
            this.dadosProdutoGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button gravarButton;
        private System.Windows.Forms.TextBox proformaTextBox;
        private System.Windows.Forms.TextBox nomeClienteTextBox;
        private System.Windows.Forms.DateTimePicker dataCompraDateTimePicker;
        private System.Windows.Forms.TextBox moradaClienteTextBox;
        private System.Windows.Forms.TextBox contatoClienteTextBox;
        private System.Windows.Forms.Label proformaLabel;
        private System.Windows.Forms.Label dataCompraLabel;
        private System.Windows.Forms.Label nomeClienteLabel;
        private System.Windows.Forms.TextBox nomeProdutoTextBox;
        private System.Windows.Forms.TextBox precoProdutoTextBox;
        private System.Windows.Forms.Label moradaClienteLabel;
        private System.Windows.Forms.Label contatoClienteLabel;
        private System.Windows.Forms.Label nomeProdutoLabel;
        private System.Windows.Forms.Label precoProdutoLabel;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button sairButton;
        private System.Windows.Forms.Button listaButton;
        private System.Windows.Forms.MenuStrip componenteMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ficheiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gravarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider manutencaoTabelaErrorProvider;
        private System.Windows.Forms.GroupBox dadosProdutoGroupBox;
        private System.Windows.Forms.GroupBox dadosClienteGroupBox;
        private UserControlData userControlData;
        private System.Windows.Forms.Button userControlButton;
    }
}