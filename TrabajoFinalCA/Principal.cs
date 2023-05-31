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
    public partial class Principal : Form
    {
       
        private  List<Ticket> ticketList;
       
        private ControladorBD controladorBD;
        public Principal()
        {
            InitializeComponent();
            controladorBD = new ControladorBD();
            ticketList = new List<Ticket>();
            refrescarTickelist();
           
        }

        private void refrescarTickelist()
        {
            ticketList = controladorBD.readTicket();
        }

        private void crearTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
                    refrescarTickelist();
                    CrearTicket crearTicket = new CrearTicket(ticketList,controladorBD);
                    crearTicket.MdiParent = this;
                    crearTicket.Show();
                     
        }

        private void consultarTicketsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Solamente se podrá acceder si se ha insertado un ticket en el Array. Si es 0 te mostrará una ventana de alerta
            if (ticketList.Count == 0)
            {
                DialogAlert alert = new DialogAlert();
                alert.ShowDialog();
            }
            else
            {
                refrescarTickelist();
                ConsultarTickets consultarTicket = new ConsultarTickets(ticketList,controladorBD);
                consultarTicket.MdiParent = this;
                consultarTicket.Show();
               
            }
            
        }

        private void modificarTicketsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //Solamente se podrá acceder si se ha insertado un ticket en el Array. Si es 0 te mostrará una ventana de alerta
            if (ticketList.Count == 0)
            {
                DialogAlert alert = new DialogAlert();
                alert.ShowDialog();
            }
            else
            {
                refrescarTickelist();
                ModificarTickets modificarTickets = new ModificarTickets(ticketList, controladorBD);
                modificarTickets.MdiParent = this;
                modificarTickets.Show();
               
            }
        }

        private void eliminarTicketsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Solamente se podrá acceder si se ha insertado un ticket en el Array. Si es 0 te mostrará una ventana de alerta
            if (ticketList.Count == 0)
            {
                DialogAlert alert = new DialogAlert();
                alert.ShowDialog();
            }
            else
            {
                refrescarTickelist();
                EliminarTickets eliminarTickets = new EliminarTickets(ticketList,controladorBD);
                eliminarTickets.MdiParent = this;
                eliminarTickets.Show();
                
            }
        }

        private void abrirOCrearFicheroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //te abre una ventana para poder crear un fichero  ya existente
            refrescarTickelist();
            GuardarFichero guardarFichero = new GuardarFichero(ticketList,controladorBD);

            DialogResult dialogResult = guardarFichero.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                MessageBox.Show("Copia realizada con exito");
            }
        }

       

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Antes de cerrar el programa debes guardar una copia de seguridad");
            refrescarTickelist();
            GuardarFichero guardarFichero = new GuardarFichero(ticketList, controladorBD);

            DialogResult dialogResult = guardarFichero.ShowDialog();
            //Si guardas el fichero correctamente te permite cerrar el programa
            if (dialogResult == DialogResult.OK)
            {
                if (GuardarFichero.rutaFile != "")
                {
                    MessageBox.Show("Copia realizada con exito");
                    MessageBox.Show("Que tengas un buen día, adios");
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel=true;
                    MessageBox.Show("Antes de cerrar el programa debes guardar una copia de seguridad");
                }
           

            }
            else
            {
                e.Cancel = true;
                MessageBox.Show("Antes de cerrar el programa debes guardar una copia de seguridad");
            }
        }
    }
}
