using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComFort
{
    public partial class UserControlData : UserControl
    {
        #region Construtores

        public UserControlData()
        {
            InitializeComponent();            
        }

        #endregion

        #region Propriedades

        private string texto;
        public string Texto
        {
            get { return texto; }
            set
            {
                texto = value;
                this.userControlLabel.Text = texto;
            }
        }

        #endregion

        #region Metodos

        public void VerificarInformacao(string texto)
        {
            this.userControlLabel.Text = texto;
        }

        #endregion

        #region Eventos
        public void MudarTexto()
        {
            this.Texto = "Tudo ok e a funcionar";
        }

        #endregion
    }
}
