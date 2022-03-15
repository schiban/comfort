using System;
using System.Windows.Forms;

namespace ComFort
{
    public partial class FormAbout : Form
    {
        #region Construtores
        public FormAbout()
        {
            InitializeComponent();
        }

        #endregion

        #region Metodos

        private void Sair()
        {
            this.Close();
        }

        #endregion

        #region Eventos
        private void sairButton_Click(object sender, EventArgs e)
        {
            this.Sair();
        }

        #endregion

    }
}
