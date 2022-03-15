namespace ComFort
{
    partial class FormAbout
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
            this.numeroAlunoLabel = new System.Windows.Forms.Label();
            this.nomeAlunoLabel = new System.Windows.Forms.Label();
            this.componenteMenuStrip = new System.Windows.Forms.MenuStrip();
            this.ficheiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.componenteMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // numeroAlunoLabel
            // 
            this.numeroAlunoLabel.AutoSize = true;
            this.numeroAlunoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroAlunoLabel.Location = new System.Drawing.Point(91, 45);
            this.numeroAlunoLabel.Name = "numeroAlunoLabel";
            this.numeroAlunoLabel.Size = new System.Drawing.Size(99, 20);
            this.numeroAlunoLabel.TabIndex = 0;
            this.numeroAlunoLabel.Text = "a22001233";
            // 
            // nomeAlunoLabel
            // 
            this.nomeAlunoLabel.AutoSize = true;
            this.nomeAlunoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeAlunoLabel.Location = new System.Drawing.Point(22, 83);
            this.nomeAlunoLabel.Name = "nomeAlunoLabel";
            this.nomeAlunoLabel.Size = new System.Drawing.Size(250, 16);
            this.nomeAlunoLabel.TabIndex = 1;
            this.nomeAlunoLabel.Text = "João Marcos da Costa Moreira Bandeira";
            // 
            // componenteMenuStrip
            // 
            this.componenteMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ficheiroToolStripMenuItem});
            this.componenteMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.componenteMenuStrip.Name = "componenteMenuStrip";
            this.componenteMenuStrip.Size = new System.Drawing.Size(284, 24);
            this.componenteMenuStrip.TabIndex = 2;
            this.componenteMenuStrip.Text = "menuStrip1";
            // 
            // ficheiroToolStripMenuItem
            // 
            this.ficheiroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.ficheiroToolStripMenuItem.Name = "ficheiroToolStripMenuItem";
            this.ficheiroToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.ficheiroToolStripMenuItem.Text = "Ficheiro";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairButton_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.nomeAlunoLabel);
            this.Controls.Add(this.numeroAlunoLabel);
            this.Controls.Add(this.componenteMenuStrip);
            this.MainMenuStrip = this.componenteMenuStrip;
            this.Name = "FormAbout";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ComFort";
            this.componenteMenuStrip.ResumeLayout(false);
            this.componenteMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label numeroAlunoLabel;
        private System.Windows.Forms.Label nomeAlunoLabel;
        private System.Windows.Forms.MenuStrip componenteMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ficheiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}