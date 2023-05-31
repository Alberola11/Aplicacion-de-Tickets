using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinalCA
{
    //Creamos la clase Ticket y cambiamos a public para que pueda ser utilizada en todo el programa
    public class Ticket
    {
        private long id;
        private DateTime fecha;
        private string identificador;
        private string concepto;
        private string nombre;
        private float importeTotal;
        private string direccion;
        private string ente;
        


        //creamos los getters y setters
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Identificador { get => identificador; set => identificador = value; }
        public string Concepto { get => concepto; set => concepto = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public float ImporteTotal { get => importeTotal; set => importeTotal = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Ente { get => ente; set => ente = value; }
        public long Id { get => id; set => id = value; }

        //creamos el constructor
        public Ticket( long ticketId,DateTime fecha, string identificador, string concepto, string nombre, float importeTotal, string direccion,string ente)
        {
           Id = ticketId;
            Fecha = fecha;
            Identificador = identificador;
            Concepto = concepto;
            Nombre = nombre;
            ImporteTotal = importeTotal;
            Direccion = direccion;
            Ente = ente;
        }

   

        public Ticket(string fichero)
        {
            string[] atributos = fichero.Split(';');
            Id=int.Parse(atributos[0]);
            Fecha=DateTime.Parse(atributos[1]);
            Identificador=atributos[2];
            Concepto=atributos[3];
            Nombre=atributos[4];
            ImporteTotal=float.Parse(atributos[5]);
            Direccion=atributos[6];
            Ente=atributos[7];

        }

        public override string ToString()
        {
            return Nombre + " " + Concepto + " " + importeTotal;
        }

        public string codificaTicket()//este para el de escritura. Como vemos escribimmos  separdo n ;
        {
            return Id + ";" + Fecha + ";" + Identificador + ";" + Concepto + ";" + Nombre + ";" + ImporteTotal + ";" + Direccion + ";" + Ente + ";";
        }
    }


}
