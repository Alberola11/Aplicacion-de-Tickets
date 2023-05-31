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
    public partial class ModificarTickets : Form
    {
        private List<Ticket> ticketList;
        private ControladorBD controladorBD;
        public ModificarTickets(List<Ticket> ticketList, ControladorBD controladorBD)
        {
            InitializeComponent();
            this.ticketList = ticketList;
            this.controladorBD = controladorBD;
            refrescarLista();






        }

        private void refrescarLista()
        {
            refrescaBaseDatos();
            lbLista.Items.Clear();
            for (int i = 0; i < ticketList.Count; i++)
            {
                lbLista.Items.Add(ticketList[i]);
            }
            gbDatosPersonales.Visible = false;
            gbMasInfo.Visible = false;
            btnModificarTicket.Visible = false;
            
        }

        private void refrescaBaseDatos()
        {
            
            ticketList = controladorBD.readTicket();
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

        private void lbLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbLista.SelectedIndex != -1)
            {
                gbDatosPersonales.Visible = true;
                gbMasInfo.Visible = true;
                btnModificarTicket.Visible = true;

                txtNombre.Text = ticketList[lbLista.SelectedIndex].Nombre;
                txtDireccion.Text = ticketList[lbLista.SelectedIndex].Direccion;
                if (ticketList[lbLista.SelectedIndex].Ente=="Particular")
                {
                    rbParticular.Checked = true;
                    txtDni.Text = ticketList[lbLista.SelectedIndex].Identificador;
                }
                else
                {
                    rbEmpresa.Checked = true;
                    txtCif.Text = ticketList[lbLista.SelectedIndex].Identificador;
                }
                txtConcepto.Text = ticketList[lbLista.SelectedIndex].Concepto;
                nudImporteTotal.Value = (decimal)(float)ticketList[lbLista.SelectedIndex].ImporteTotal;
                dtpFecha.Value = ticketList[lbLista.SelectedIndex].Fecha;
                btnModificarTicket.Visible=true;
            }

        }

        private void btnModificarTicket_Click(object sender, EventArgs e)
        {
            if (rbEmpresa.Checked && txtCif.Text != "" && txtCif.Text.Length == 9)
            {
                if (txtConcepto.Text != "" && txtDireccion.Text != "" && txtNombre.Text != "" && nudImporteTotal.Value != 0)
                {
                    Ticket ticket = new Ticket((int)ticketList[lbLista.SelectedIndex].Id, dtpFecha.Value, txtCif.Text, txtConcepto.Text, txtNombre.Text, (float)nudImporteTotal.Value, txtDireccion.Text, rbEmpresa.Tag.ToString());
                   controladorBD.updateTicket(ticket);
                    MessageBox.Show("Ticket modificado con exito");
                    refrescarLista();
                }
                
                else
                {
                    MessageBox.Show("Te faltan datos o has introducido incorrectamente algún parámetro");
                }


            }
            else
            {
                if (rbParticular.Checked && txtDni.Text != "" && txtDni.Text.Length == 9)
                {
                    if (txtConcepto.Text != "" && txtDireccion.Text != "" && txtNombre.Text != "" && nudImporteTotal.Value != 0)
                    {
                        Ticket ticket = new Ticket((int)ticketList[lbLista.SelectedIndex].Id, dtpFecha.Value, txtDni.Text, txtConcepto.Text, txtNombre.Text, (float)nudImporteTotal.Value, txtDireccion.Text, rbParticular.Tag.ToString());
                        controladorBD.updateTicket(ticket);
                        MessageBox.Show("Ticket modificado con exito");
                        refrescarLista();
                    }
                    else
                    {
                        MessageBox.Show("Te faltan datos o has introducido incorrectamente algún parámetro");
                    }
                }
                else
                {
                    MessageBox.Show("Te faltan datos o has introducido incorrectamente algún parámetro");
                }
            }


        }
    }
}
