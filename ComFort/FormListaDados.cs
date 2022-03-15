using System;
using System.Data;
using System.Windows.Forms;

namespace ComFort
{
    public partial class FormListaDados : Form
    {

        #region Construtores

        public FormListaDados(DataTable dataTable)
        {
            InitializeComponent();

            this.Dados = dataTable;
        }

        #endregion

        #region Propriedades

        private DataTable Dados { get; set; }

        public string ProformaSelecionada { get; set; }

        #endregion

        #region Metodos

        private void FormatarGrelha()
        {
            this.encomendaDataGridView.AutoGenerateColumns = false;
            this.encomendaDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.encomendaDataGridView.ReadOnly = true;

            this.AddColuna(100, "Proforma", "Proforma", DataGridViewAutoSizeColumnMode.None);
            this.AddColuna(100, "Data Compra", "DataCompra", DataGridViewAutoSizeColumnMode.None);
            this.AddColuna(100, "Nome", "NomeCliente", DataGridViewAutoSizeColumnMode.None);
            this.AddColuna(100, "Morada", "MoradaCliente", DataGridViewAutoSizeColumnMode.None);
            this.AddColuna(100, "Contato", "ContatoCliente", DataGridViewAutoSizeColumnMode.None);
            this.AddColuna(100, "Produto", "NomeProduto", DataGridViewAutoSizeColumnMode.None);
            this.AddColuna(100, "Preço", "PrecoProduto", DataGridViewAutoSizeColumnMode.None);

        }

        private void AddColuna(int tamanho, string header, string campo, DataGridViewAutoSizeColumnMode modo)
        {
            DataGridViewColumn column = new DataGridViewTextBoxColumn();

            column.Width = tamanho;
            column.HeaderText = header;
            column.DataPropertyName = campo;
            column.AutoSizeMode = modo;

            this.encomendaDataGridView.Columns.Add(column);
        }

        private void Sair()
        {
            this.Close();
        }

        #endregion

        #region Eventos

        private void FormListaDados_Load(object sender, EventArgs e)
        {
            this.FormatarGrelha();

            this.encomendaDataGridView.DataSource = this.Dados;
        }

        private void encomendaDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.encomendaDataGridView.SelectedRows != null &&
                this.encomendaDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow row = this.encomendaDataGridView.SelectedRows[0];
                if (row != null)
                {
                    this.ProformaSelecionada = (string)row.Cells[0].Value;
                    this.DialogResult = DialogResult.OK;
                }
            }
        }        

        private void sairButton_Click(object sender, EventArgs e)
        {
            this.Sair();
        }

        #endregion

    }
}
