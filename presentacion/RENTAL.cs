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
            cargar();
            ocultarColumnas();
        }

        private void cargar()
        {
            RentNegocio negocio = new RentNegocio();
            SpotNegocio spotNegocio = new SpotNegocio();
            try
            {
                listaRent = negocio.listar();
                dgvRental.DataSource = listaRent;
                dgvRental.Columns[2].Width = 140;
                //Spot spot = new Spot();
                cboSpot.DataSource = spotNegocio.listar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Rent rent = new Rent();
            RentNegocio negocio = new RentNegocio();

            try
            {
                rent.Cliente = txtCliente.Text;
                rent.CheckIn = dtpCheckIn.Value;
                rent.CheckOut = dtpCheckOut.Value;
                rent.Spot = (Spot)cboSpot.SelectedItem;
                rent.Importe = decimal.Parse(txtImporte.Text);

                negocio.agregar(rent);
                MessageBox.Show("Agregado Exitosamente");
                listaRent = negocio.listar();
                dgvRental.DataSource = listaRent;
            }
            catch (Exception ex)
            {

                throw ex; 
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            RentNegocio negocio = new RentNegocio();
            Rent seleccionado;

            try
            {
                DialogResult respuesta = MessageBox.Show("Desea eliminar el articulo", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Rent)dgvRental.CurrentRow.DataBoundItem;
                    negocio.eliminar(seleccionado.Id);
                    listaRent = negocio.listar();
                    dgvRental.DataSource = listaRent;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void ocultarColumnas()
        {
            dgvRental.Columns["Id"].Visible = false;
        }
    }
}
