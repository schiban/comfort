using System;
using System.Data;

namespace CamadaNegocio
{
    public class Encomenda
    {

        #region Construtores


        // CONSTRUTOR COM DADOS VAZIOS / 0
        public Encomenda()
        {
            this.proforma = string.Empty;
            this.dataCompra = new DateTime(2000, 1, 1);
            this.nomeCliente = string.Empty;
            this.moradaCliente = string.Empty;
            this.contatoCliente = 0;
            this.nomeProduto = string.Empty;
            this.precoProduto = 0;
        }

        public Encomenda(string proforma, DateTime dataCompra, string nomeCliente, string moradaCliente,
                         int contatoCliente, string nomeProduto, float precoProduto)
            : this()
        {
            this.proforma = proforma;
            this.dataCompra = dataCompra;
            this.nomeCliente = nomeCliente;
            this.moradaCliente = moradaCliente;
            this.contatoCliente = contatoCliente;
            this.nomeProduto = nomeProduto;
            this.precoProduto = precoProduto;
        }

        #endregion

        #region Propriedades

        private string proforma;
        public string Proforma
        {
            get { return proforma; }
            set { proforma = value; }
        }

        private DateTime dataCompra;
        public DateTime DataCompra
        {
            get { return dataCompra; }
            set { dataCompra = value; }
        }

        private string nomeCliente;

        public string NomeCliente
        {
            get { return nomeCliente; }
            set { nomeCliente = value; }
        }

        private string moradaCliente;

        public string MoradaCliente
        {
            get { return moradaCliente; }
            set { moradaCliente = value; }
        }

        private int contatoCliente;
        public int ContatoCliente
        {
            get { return contatoCliente; }
            set { contatoCliente = value; }
        }

        private string nomeProduto;
        public string NomeProduto
        {
            get { return nomeProduto; }
            set { nomeProduto = value; }
        }

        private float precoProduto;

        public float PrecoProduto
        {
            get { return precoProduto; }
            set { precoProduto = value; }
        }

        #endregion

        #region Metodos

        /// <summary>
        /// MÉTODO GRAVAR, QUE OBTEM OS VALORES E OS INTRODUZ NA BASE DE DADOS
        /// </summary>
        /// <param name="erro"></param>
        /// <returns></returns>
        public bool Gravar(out string erro)
        {
            bool resultado = false;
            erro = string.Empty;
            CamadaDados.Encomenda encomenda = new CamadaDados.Encomenda();

            resultado = encomenda.Gravar(this.Proforma, this.DataCompra, this.NomeCliente, this.MoradaCliente, this.ContatoCliente,
                                                                         this.NomeProduto, this.PrecoProduto, out erro);

            return resultado;
        }   
        
      
        public static bool Gravar(string proforma, DateTime dataCompra, string nomeCliente, string moradaCliente, int contatoCliente,
                                                                        string nomeProduto, float precoProduto, out string erro)
        {
            if (CamadaDados.Encomenda.GravarEncomenda(proforma, dataCompra, nomeCliente, moradaCliente, contatoCliente,
                                                                            nomeProduto, precoProduto, out erro))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="proforma">NÚMERO DA PROFORMA</param>
        /// <param name="dataCompra">DATA DA COMPRA DA ENCOMENDA</param>
        /// <param name="nomeCliente">NOME DO CLIENTE QUE EFETUOU A COMPRA</param>
        /// <param name="moradaCliente">MORADA DO CLIENTE</param>
        /// <param name="contatoCliente">CONTATO DO CLIENTE</param>
        /// <param name="nomeProduto">NOME DO PRODUTO A ADQUIRIR</param>
        /// <param name="precoProduto">PRECO DO PRODUTO EM QUESTÃO</param>
        /// <param name="erro"></param>
        /// <returns></returns>


        public static bool Eliminar(string proforma, out string erro)
        {
            if (CamadaDados.Encomenda.EliminarEncomenda(proforma, out erro))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static DataTable ObterLista(out string erro)
        {
            DataTable dataTable = CamadaDados.Encomenda.ObterLista(out erro);
            return dataTable;
        }

        public static Encomenda Obter(string proforma, out string erro)
        {
            Encomenda encomenda = null;
            erro = string.Empty;

            DateTime dataCompra = new DateTime(2000, 1, 1);
            string nomeCliente = string.Empty;
            string moradaCliente = string.Empty;
            int contatoCliente = 0;
            string nomeProduto = string.Empty;
            float precoProduto = 0;

            bool ok = CamadaDados.Encomenda.ObterEncomenda(proforma, ref dataCompra, ref nomeCliente, ref moradaCliente, ref contatoCliente,
                                                                                     ref nomeProduto, ref precoProduto, out erro);
            if (ok)
            {
                encomenda = new Encomenda(
                    proforma,
                    dataCompra,
                    nomeCliente,
                    moradaCliente,
                    contatoCliente,
                    nomeProduto,
                    precoProduto);
            }

            return encomenda;
        }    
        
        

        #endregion

    }
}
