using System;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;

namespace CamadaNegocio
{
    public class EncomendaCollection : Collection<Encomenda>
    {

        #region Construtores
        public EncomendaCollection(){}

        public EncomendaCollection(DataTable dataTable)
            : this()
        {
            this.CarregarLista(dataTable);
        }

        #endregion

        #region Metodos

        public void CarregarLista(DataTable dataTable)
        { 
            // PERCORRER CADA ELEMENTO DO DATATABLE
            foreach (DataRow dataRow in dataTable.AsEnumerable())
            {
                // LÊ OS CAMPOS DA TABELA COMFORT
                string proforma = dataRow.Field<string>("Proforma");
                DateTime dataCompra = dataRow.Field<DateTime>("DataCompra");
                string nomeCliente = dataRow.Field<string>("NomeCliente");
                string moradaCliente = dataRow.Field<string>("MoradaCliente");
                int contatoCliente = dataRow.Field<int>("ContatoCliente");
                string nomeProduto = dataRow.Field<string>("NomeProduto");
                float precoProduto = dataRow.Field<float>("PrecoProduto");

                Encomenda encomenda = new Encomenda(
                    proforma,
                    dataCompra,
                    nomeCliente, 
                    moradaCliente,
                    contatoCliente,
                    nomeProduto,
                    precoProduto
                    );

                // ADICIONAR À LISTA
                this.Add(encomenda);
            }
        }        

        #endregion

    }
}
