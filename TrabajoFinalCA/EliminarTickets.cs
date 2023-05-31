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
    public partial class EliminarTickets : Form
    {
        private List<Ticket> ticketList;
        private float totalPrecio=0;
        private ControladorBD controladorBD;
        public EliminarTickets(List<Ticket> ticketList, ControladorBD controladorBD)
        {
            InitializeComponent();
            this.ticketList = ticketList;
            this.controladorBD = controladorBD;
            esconderDatos_Inicializar();





        }

        private void esconderDatos_Inicializar()
        {
            gbDatosIndividuales.Visible = false;
            lblPrecioTotal.Visible = false;
            txtPrecioTotal.Visible=false;
            lbLista.Items.Clear();
            txtPrecioTotal.Text = "";
            txtConceptoPersonal.Text = "";
            txtDireccion.Text = "";
            txtFecha.Text = "";
            txtIdentificador.Text = "";
            txtImporte.Text = "";
            txtNombre.Text = "";
            txtEnte.Text = "";
            totalPrecio = 0;
            refrescarBaseDatos();
            for (int i = 0; i < ticketList.Count; i++)
            {
                lbLista.Items.Add(ticketList[i]);
            }
           
        }
        private void refrescarBaseDatos()
        {
            //Copio en el ticketList los datos almacenados en la base de datos
            ticketList = controladorBD.readTicket();
        }
        private void lbLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            totalPrecio = 0;
            txtPrecioTotal.Text = "";
            if (lbLista.SelectedIndex != -1)
            {
                gbDatosIndividuales.Visible = true;
                lblPrecioTotal.Visible = true;
                txtPrecioTotal.Visible = true;
                txtImporte.Text = ticketList[lbLista.SelectedIndex].ImporteTotal.ToString();
                txtConceptoPersonal.Text = ticketList[lbLista.SelectedIndex].Concepto;
                txtDireccion.Text = ticketList[lbLista.SelectedIndex].Direccion;
                txtFecha.Text = ticketList[lbLista.SelectedIndex].Fecha.ToString();
                txtIdentificador.Text = ticketList[lbLista.SelectedIndex].Identificador;
                txtNombre.Text = ticketList[lbLista.SelectedIndex].Nombre;
                txtEnte.Text = ticketList[lbLista.SelectedIndex].Ente;
            }
            for (int i = 0; i < ticketList.Count; i++)
            {
                totalPrecio += ticketList[i].ImporteTotal;
            }
            txtPrecioTotal.Text = totalPrecio.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lbLista.SelectedIndex != -1)
            {
                //Antes de eliminar muestro una ventana para asegurar si se quiere eliminar o no
                AlertaEliminar alertaEliminar = new AlertaEliminar();
                DialogResult result = alertaEliminar.ShowDialog();
                if (result == DialogResult.OK)
                { 
                    Ticket ticket = new Ticket(ticketList[lbLista.SelectedIndex].Id, ticketList[lbLista.SelectedIndex].Fecha,
                        ticketList[lbLista.SelectedIndex].Identificador, ticketList[lbLista.SelectedIndex].Concepto, 
                        ticketList[lbLista.SelectedIndex].Nombre,ticketList[lbLista.SelectedIndex].ImporteTotal, 
                        ticketList[lbLista.SelectedIndex].Direccion, ticketList[lbLista.SelectedIndex].Ente);
                        controladorBD.deleteTicket(ticket);//Elimino el ticket selecionado de la base de datos
                    MessageBox.Show("Ticke eliminado con exito");
                    esconderDatos_Inicializar();

                  
                }
            }
            else
            {
                MessageBox.Show("No has selecionado ningún ticket");
            }
        }
    }
    }

