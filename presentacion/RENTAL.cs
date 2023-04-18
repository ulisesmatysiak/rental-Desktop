using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace presentacion
{
    public partial class RENTAL : Form
    {
        List<Rent> listaRent;
        public RENTAL()
        {
            InitializeComponent();
        }

        private void RENTAL_Load(object sender, EventArgs e)
        {
            RentNegocio negocio = new RentNegocio();
            try
            {
                listaRent = negocio.listar();
                dgvRental.DataSource = listaRent;
            }
            catch (Exception ex)
            {
                throw ex;
            }      
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
                   
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
