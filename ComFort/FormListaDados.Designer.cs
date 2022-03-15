namespace ComFort
{
    partial class FormListaDados
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
            this.encomendaDataGridView = new System.Windows.Forms.DataGridView();
            this.sairButton = new System.Windows.Forms.Button();
            this.componenteMenuStrip = new System.Windows.Forms.MenuStrip();
            this.ficheiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.encomendaDataGridView)).BeginInit();
            this.componenteMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // encomendaDataGridView
            // 
            this.encomendaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.encomendaDataGridView.Location = new System.Drawing.Point(12, 37);
            this.encomendaDataGridView.Name = "encomendaDataGridView";
            this.encomendaDataGridView.Size = new System.Drawing.Size(587, 160);
            this.encomendaDataGridView.TabIndex = 1;
            this.encomendaDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.encomendaDataGridView_CellDoubleClick);
            // 
            // sairButton
            // 
            this.sairButton.Location = new System.Drawing.Point(524, 203);
            this.sairButton.Name = "sairButton";
            this.sairButton.Size = new System.Drawing.Size(75, 23);
            this.sairButton.TabIndex = 2;
            this.sairButton.Text = "Sair";
            this.sairButton.UseVisualStyleBackColor = true;
            this.sairButton.Click += new System.EventHandler(this.sairButton_Click);
            // 
            // componenteMenuStrip
            // 
            this.componenteMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ficheiroToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.componenteMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.componenteMenuStrip.Name = "componenteMenuStrip";
            this.componenteMenuStrip.Size = new System.Drawing.Size(611, 24);
            this.componenteMenuStrip.TabIndex = 2;
            this.componenteMenuStrip.Text = "menuStrip1";
            // 
            // ficheiroToolStripMenuItem
            // 
            this.ficheiroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.ficheiroToolStripMenuItem.Name = "ficheiroToolStripMenuItem";
            this.ficheiroToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.ficheiroToolStripMenuItem.Text = "&Ficheiro";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
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
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // FormListaDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 238);
            this.Controls.Add(this.sairButton);
            this.Controls.Add(this.encomendaDataGridView);
            this.Controls.Add(this.componenteMenuStrip);
            this.MainMenuStrip = this.componenteMenuStrip;
            this.Name = "FormListaDados";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ComFort";
            this.Load += new System.EventHandler(this.FormListaDados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.encomendaDataGridView)).EndInit();
            this.componenteMenuStrip.ResumeLayout(false);
            this.componenteMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView encomendaDataGridView;
        private System.Windows.Forms.Button sairButton;
        private System.Windows.Forms.MenuStrip componenteMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ficheiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
    }
}