using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TrabajoFinalCA
{
    public partial class CrearTicket : Form
    {
        private List<Ticket> ticketList;
        private ControladorBD controladorBD;
        public CrearTicket(List<Ticket>ticketList, ControladorBD controladorBD)
        {
            InitializeComponent();
            this.ticketList = ticketList;
            this.controladorBD = controladorBD;
        }

        private void btnCrearTicket_Click(object sender, EventArgs e)
        {
            

            if(rbEmpresa.Checked && txtCif.Text != "" && txtCif.Text.Length==9)
            {
                if(txtConcepto.Text !="" && txtDireccion.Text !="" && txtNombre.Text != "" && nudImporteTotal.Value!=0)
                {
                    //Añado el ticket en el List a la vez que creo el Ticket
                   ticketList.Add(controladorBD.CrearTicket(dtpFecha.Value, txtCif.Text, txtConcepto.Text, txtNombre.Text, (float)nudImporteTotal.Value, txtDireccion.Text, rbEmpresa.Tag.ToString()));
                    MessageBox.Show("Ticket creado con exito");
                    this.Close();
                 
                }
                else
                {
                    MessageBox.Show("Te faltan datos o has introducido incorrectamente algún parámetro");
                }
            }
            else
            {
                if(rbParticular.Checked && txtDni.Text != "" && txtDni.Text.Length==9)
                {
                    if (txtConcepto.Text != "" && txtDireccion.Text != "" && txtNombre.Text != "" && nudImporteTotal.Value != 0)
                    {
                        //Añado el ticket en el List a la vez que creo el Ticket
                        ticketList.Add(controladorBD.CrearTicket(dtpFecha.Value, txtDni.Text, txtConcepto.Text, txtNombre.Text, (float)nudImporteTotal.Value, txtDireccion.Text, rbParticular.Tag.ToString()));
                        MessageBox.Show("Ticket creado con exito");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Te faltan datos  o has introducido incorrectamente algún parámetro");
                    }
                }
                else
                {
                    MessageBox.Show("Te faltan datos  o has introducido incorrectamente algún parámetro");
                }
               
            }
          


        }
        private void rbEmpresa_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEmpresa.Checked)
            {
                txtCif.ReadOnly = false;
            }
            else
            {
                txtCif.ReadOnly = true;
                txtCif.Clear();
            }
        }

        private void rbParticular_CheckedChanged(object sender, EventArgs e)
        {
            if (rbParticular.Checked)
            {
                txtDni.ReadOnly = false;
            }
            else
            {
                txtDni.ReadOnly = true;
                txtDni.Clear();
            }
        }
    }
}
