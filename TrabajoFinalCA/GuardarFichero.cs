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
    public partial class GuardarFichero : Form
    {
        private ControladorBD controladorBD;
        private List<Ticket> ticketList;
        public  static string rutaFile = "";
        public GuardarFichero(List<Ticket> ticketList, ControladorBD controladorBD)
        {
            InitializeComponent();
            this.ticketList = ticketList;
            this.controladorBD = controladorBD;
            refrescarBaseDatos();

        }
        private void refrescarBaseDatos()
        {
            ticketList = controladorBD.readTicket();
        }
        private void btnCrear_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Guardar Copia de Seguridad";
            saveFileDialog.Filter = "BackUp Files (*.bck)|*.bck";
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.InitialDirectory = @"c:\kk";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
               
                //Con la ruta creo el fichero
                rutaFile = saveFileDialog.FileName;
                añadirFichero();
               


            }

        }
        private void añadirFichero()
        {

            if (rutaFile != "")
            {
                //Creo el fichero y copio los datos del TickeList en el fichero
                StreamWriter copiaBackUP = File.CreateText(rutaFile);
                foreach (Ticket ticket in ticketList)
                {
                    copiaBackUP.WriteLine(ticket.codificaTicket());
                }
                copiaBackUP.Close();
                refrescarBaseDatos();
            }
            else
            {
                MessageBox.Show("No se ha selecionado correctamente un fichero");
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No olvides que es importante hacer una copia de seguridad para manetener los datos a salvo");
        }

      
        
    }
}
