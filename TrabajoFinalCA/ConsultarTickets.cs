using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoFinalCA
{
    public partial class ConsultarTickets : Form
    {
        private ControladorBD controladorBD;
        private List<Ticket> ticketList;
        private float totalPrecio = 0;
        private List<Ticket> ticketListAuxiliar=new List<Ticket>();//con este List copio los valores del ListPrincipal para poder acceder facilmente al listBox y que no me explote el programa
        public ConsultarTickets(List<Ticket> ticketList, ControladorBD controladorBD)
        {

            InitializeComponent();
            this.controladorBD = controladorBD;
            this.ticketList = ticketList;
            
            esconderDatos_Inicializar();//inicializo los valores

        }

        private void esconderDatos_Inicializar()
        {
            ticketList = controladorBD.readTicket();
            lbLista.Visible = false;
            gbDatosIndividuales.Visible = false;
            lbLista.Items.Clear();
            totalPrecio = 0;
            txtPrecioTotal.Text = "";
            txtConceptoPersonal.Text = "";
            txtDireccion.Text = "";
            txtFecha.Text = "";
            txtIdentificador.Text = "";
            txtImporte.Text = "";
            txtNombre.Text = "";
            txtEnte.Text = "";
            ticketListAuxiliar.Clear();//cada vez que muestro los datos y cambio de radio button limpio todo el contendio del TicketListAuxiliar

        }

        private void rbListaCompleta_CheckedChanged(object sender, EventArgs e)
        {
            esconderDatos_Inicializar();
            if (rbListaCompleta.Checked)
            {
                for (int i = 0; i < ticketList.Count; i++)
                {
                    lbLista.Items.Add(ticketList[i]);
                    totalPrecio += ticketList[i].ImporteTotal;

                }
                lbLista.Visible = true;
                txtPrecioTotal.Text = totalPrecio.ToString();

            }
            else
            {
                esconderDatos_Inicializar();
            }
        }

        private void lbLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rbListaCompleta.Checked)
            {
                if (lbLista.SelectedIndex != -1)
                {
                    mostrarDatos();
                }
            }

            if (rbListaConcepto.Checked)
            {
                if(lbLista.SelectedIndex != -1)
                {

                    mostrarDatos();

                }
            }

            if (rbListaFecha.Checked)
            {
                if(lbLista.SelectedIndex != -1)
                {
                    mostrarDatos();
                }
            }

            if (rbEmpresa.Checked)
            {
                if (lbLista.SelectedIndex != -1)
                {
                    mostrarDatos();
                }
            }

            if (rbParticular.Checked)
            {
                if (lbLista.SelectedIndex != -1)
                {
                    mostrarDatos();
                }
            }
           
        }
        void mostrarDatos()//muestro los datos del List auxiliar o del List principal segun el radio button selecionado
        {
            if (ticketListAuxiliar.Count == 0)//Segun el radio button selecionado, si hay coincidencias se rellenará y mostrara el else
            {
                gbDatosIndividuales.Visible = true;
                txtImporte.Text = ticketList[lbLista.SelectedIndex].ImporteTotal.ToString();
                txtConceptoPersonal.Text = ticketList[lbLista.SelectedIndex].Concepto;
                txtDireccion.Text = ticketList[lbLista.SelectedIndex].Direccion;
                txtFecha.Text = ticketList[lbLista.SelectedIndex].Fecha.ToString();
                txtIdentificador.Text = ticketList[lbLista.SelectedIndex].Identificador;
                txtNombre.Text = ticketList[lbLista.SelectedIndex].Nombre;
                txtEnte.Text = ticketList[lbLista.SelectedIndex].Ente;
            }
            else
            {
                gbDatosIndividuales.Visible = true;
                txtImporte.Text = ticketListAuxiliar[lbLista.SelectedIndex].ImporteTotal.ToString();
                txtConceptoPersonal.Text = ticketListAuxiliar[lbLista.SelectedIndex].Concepto;
                txtDireccion.Text = ticketListAuxiliar[lbLista.SelectedIndex].Direccion;
                txtFecha.Text = ticketListAuxiliar[lbLista.SelectedIndex].Fecha.ToString();
                txtIdentificador.Text = ticketListAuxiliar[lbLista.SelectedIndex].Identificador;
                txtNombre.Text = ticketListAuxiliar[lbLista.SelectedIndex].Nombre;
                txtEnte.Text = ticketListAuxiliar[lbLista.SelectedIndex].Ente;
            }
            
        }

        private void rbListaConcepto_CheckedChanged(object sender, EventArgs e)
        {
            esconderDatos_Inicializar();
            if (rbListaConcepto.Checked)
            {
                DialogConcepto dialogConcepto = new DialogConcepto();//Abro una ventana para escribir el concepto
                DialogResult result = dialogConcepto.ShowDialog();

                if (result == DialogResult.OK)
                {
                    lbLista.Visible = true;
                    string concepto = dialogConcepto.txtConcepto.Text;
                    for (int i = 0; i < ticketList.Count; i++)
                    {
                        if (ticketList[i].Concepto == dialogConcepto.txtConcepto.Text)
                        {
                            ticketListAuxiliar.Add(ticketList[i]);
                            lbLista.Items.Add(ticketList[i].ToString());
                            totalPrecio += ticketList[i].ImporteTotal;
                        }
                    }
                    txtPrecioTotal.Text = totalPrecio.ToString();
                    if(lbLista.Items.Count == 0)
                    {
                        MessageBox.Show("No hay elementos con esos parametros");
                    }

                }
                else
                {
                    esconderDatos_Inicializar();
                }

            }
        }

        private void rbListaFecha_CheckedChanged(object sender, EventArgs e)
        {
            esconderDatos_Inicializar();
            if (rbListaFecha.Checked)
            {
                DialogFecha dialogFecha = new DialogFecha();//Abro una ventana para escribir el concepto
                DialogResult result = dialogFecha.ShowDialog();
                if(result == DialogResult.OK)
                {
                    lbLista.Visible=true;
                    DateTime inicio=dialogFecha.dtpInicio.Value;
                    DateTime fin=dialogFecha.dtpFin.Value;
                    for (int i = 0; i < ticketList.Count; i++)
                    {
                        if(ticketList[i].Fecha>=inicio && ticketList[i].Fecha <= fin)
                        {
                            ticketListAuxiliar.Add(ticketList[i]);
                            lbLista.Items.Add(ticketList[i].ToString());
                            totalPrecio += ticketList[i].ImporteTotal;
                        }
                        txtPrecioTotal.Text = totalPrecio.ToString();
                    }
                    if (lbLista.Items.Count == 0)
                    {
                        MessageBox.Show("No hay elementos con esos parametros");
                    }
                }
                else
                {
                    esconderDatos_Inicializar();
                }
            }
        }

        private void rbParticular_CheckedChanged(object sender, EventArgs e)
        {
           
            if (rbParticular.Checked)
            {
                esconderDatos_Inicializar();
                lbLista.Visible = true;
                for(int i = 0; i < ticketList.Count; i++)
                {
                    if(ticketList[i].Ente == "Particular")
                    {
                        ticketListAuxiliar.Add(ticketList[i]);
                        lbLista.Items.Add(ticketList[i].ToString());
                        totalPrecio += ticketList[i].ImporteTotal;
                    }
                    txtPrecioTotal.Text=totalPrecio.ToString();
                }
                if(lbLista.Items.Count == 0)
                {
                    MessageBox.Show("No hay elementos con esos parametros");
                }
                
            }
            else
            {
                esconderDatos_Inicializar();
            }

        }

        private void rbEmpresa_CheckedChanged(object sender, EventArgs e)
        {
           
            if (rbEmpresa.Checked)
               
            {
                esconderDatos_Inicializar();
                lbLista.Visible = true;
                for (int i = 0; i < ticketList.Count; i++)
                {
                    if (ticketList[i].Ente == "Empresa")
                    {
                        ticketListAuxiliar.Add(ticketList[i]);
                        lbLista.Items.Add(ticketList[i].ToString());
                        totalPrecio += ticketList[i].ImporteTotal;
                    }
                    txtPrecioTotal.Text = totalPrecio.ToString();
                }
                if (lbLista.Items.Count == 0)
                {
                    MessageBox.Show("No hay elementos con esos parametros");
                }
                
            }
            else
            {
                esconderDatos_Inicializar();
            }
        }
    }
}
