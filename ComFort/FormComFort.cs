using CamadaNegocio;
using System;
using System.Data;
using System.Windows.Forms;

namespace ComFort
{
    public partial class FormComFort : Form
    {

        #region Construtores

        public FormComFort()
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

        private void manutencaoTabelaButton_Click(object sender, EventArgs e)
        {
            FormManutencaoTabela formManutencaoTabela = new FormManutencaoTabela();

            formManutencaoTabela.ShowDialog();
        }

        private void listaDadosButton_Click(object sender, EventArgs e)
        {
            string erro = string.Empty;

            DataTable dataTable = Encomenda.ObterLista(out erro);

            FormListaDados formListaDados = new FormListaDados(dataTable);

            formListaDados.ShowDialog();
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();

            formAbout.ShowDialog();
        }

        private void sairButton_Click(object sender, EventArgs e)
        {
            this.Sair();
        }

        #endregion

    }
}
