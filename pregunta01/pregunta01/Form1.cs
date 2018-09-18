using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pregunta01
{
    public partial class Form1 : Form
    {
        List<clsTiCKET> tickets = new List<clsTiCKET>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
         
            
            clsTiCKET tic = tickets.Find(x=> x.numeroTicket == int.Parse(txtNumeroTicket.Text));       
            if (tic==null)
            {
                clsTiCKET t = new clsTiCKET();
                t.numeroTicket = int.Parse(txtNumeroTicket.Text);
                t.fechaTicket = dtpVehiculo.Value;
                t.tipoVehiculo = cboTipoVehiculo.Text;
                

                tickets.Add(t);

                dgvRegistroPeajes.DataSource = null;
                dgvRegistroPeajes.DataSource = tickets;
            }
            else
            {
                MessageBox.Show("Numero exixtente");
            }

            


            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumeroTicket.Clear();
           
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            clsTiCKET tic = tickets.Find(x => x.numeroTicket == int.Parse(txtNumeroTicket.Text));
            if (tic != null)
            {
                tickets.Remove(tic);

                dgvRegistroPeajes.DataSource = null;
                dgvRegistroPeajes.DataSource = tickets;
            }
            else
            {
                MessageBox.Show("No esta registrado");
            }

            
            
        }
    }
}
