using CamadaNegocio;
using System;
using System.Data;
using System.Windows.Forms;

namespace ComFort
{
    public partial class FormManutencaoTabela : Form
    {

        #region Construtores
        public FormManutencaoTabela()
        {
            InitializeComponent();
        }        

        #endregion

        #region Metodos

        private void Gravar()
        {
            if (this.DadosValidos())
            {
                string erro = string.Empty;
                string proforma = this.proformaTextBox.Text;
                DateTime dataCompra = this.dataCompraDateTimePicker.Value;
                string nomeCliente = this.nomeClienteTextBox.Text;
                string moradaCliente = this.moradaClienteTextBox.Text;                
                int contatoCliente = int.Parse(this.contatoClienteTextBox.Text);
                string nomeProduto = this.nomeProdutoTextBox.Text;
                float precoProduto = float.Parse(this.precoProdutoTextBox.Text);

                bool resultado = Encomenda.Gravar(proforma, dataCompra, nomeCliente, moradaCliente, contatoCliente, nomeProduto, precoProduto, out erro);
                if (resultado == true)
                {
                    MessageBox.Show("Gravado com sucesso");
                }
                else
                {
                    MessageBox.Show("Erro a gravar " + erro);
                }
            }
        }

        private bool DadosValidos()
        {
            bool resultado = true;

            string proforma = this.proformaTextBox.Text;
            string nomeCliente = this.nomeClienteTextBox.Text;

            this.manutencaoTabelaErrorProvider.Clear();

            if (string.IsNullOrWhiteSpace(proforma))
            {
                this.manutencaoTabelaErrorProvider.SetError(this.proformaTextBox, "Codigo inválido");
                resultado = false;
            }
            if (string.IsNullOrEmpty(nomeCliente))
            {
                this.manutencaoTabelaErrorProvider.SetError(this.nomeClienteTextBox, "Nome cliente inválido");
                resultado = false;
            }

            return resultado;
        }

        private void Eliminar()
        {
            if (this.DadosValidos())
            {
                string erro = string.Empty;
                string proforma = this.proformaTextBox.Text;

                bool resultado = Encomenda.Eliminar(proforma, out erro);
                if (resultado == true)
                {
                    MessageBox.Show("Eliminado com sucesso");
                }
                else
                {
                    MessageBox.Show("Erro ao eliminar o registo " + erro);
                }
            }
        }

        private void ObterEncomenda()
        {
            string proforma = this.proformaTextBox.Text;

            if (!string.IsNullOrEmpty(proforma))
            {
                string erro = string.Empty;

                Encomenda encomenda = Encomenda.Obter(proforma, out erro);
                if (encomenda == null)
                {
                    MessageBox.Show(string.Format("Encomenda [{0}] não existe na BD. Erro[{1}]", proforma, erro));
                }
                else
                {
                    this.MostrarEncomenda(encomenda);
                }
            }
        }
        private void MostrarEncomenda(Encomenda encomenda)
        {
            if (encomenda != null)
            {
                this.proformaTextBox.Text = encomenda.Proforma;
                this.dataCompraDateTimePicker.Value = encomenda.DataCompra;
                this.nomeClienteTextBox.Text = encomenda.NomeCliente;
                this.moradaClienteTextBox.Text = encomenda.MoradaCliente;
                this.contatoClienteTextBox.Text = encomenda.ContatoCliente.ToString();
                this.nomeProdutoTextBox.Text = encomenda.NomeProduto;
                this.precoProdutoTextBox.Text = encomenda.PrecoProduto.ToString();
            }
        }

        private void Listar()
        {
            string erro = string.Empty;
            DataTable dataTable = Encomenda.ObterLista(out erro);

            FormListaDados formLista = new FormListaDados(dataTable);

            DialogResult result = formLista.ShowDialog();
            if (result == DialogResult.OK)
            {
                string proforma = formLista.ProformaSelecionada;
                Encomenda encomenda = Encomenda.Obter(proforma, out erro);
                if (encomenda != null)
                {
                    this.MostrarEncomenda(encomenda);
                }
            }
        }

        private void Sair()
        {
            this.Close();
        }

        #endregion

        #region Eventos

        private void gravarButton_Click(object sender, EventArgs e)
        {
            this.Gravar();
        }

        private void eliminarButton_Click(object sender, EventArgs e)
        {
            this.Eliminar();
        }

        private void proformaTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ObterEncomenda();
            }
        }

        private void listaButton_Click(object sender, EventArgs e)
        {
            this.Listar();
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
        private void userControlButton_Click(object sender, EventArgs e)
        {
            this.userControlData.MudarTexto();
        }

        #endregion

    }
}
