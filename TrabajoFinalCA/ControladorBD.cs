
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinalCA
{
    
    public class ControladorBD
    {
        private MySqlConnection conexion; /*using MySql.Data.MySqlClient;*/
        public ControladorBD()
        {
            //estos pasos obligatorios
            MySqlConnectionStringBuilder connectionStringBuilder = new MySqlConnectionStringBuilder();//le meto esto
            connectionStringBuilder.Server = "localhost";
            connectionStringBuilder.UserID = "root";
            connectionStringBuilder.Password = "";
            connectionStringBuilder.Database = "TrabajoFinalCA";//esta es el nombre de mi base de datos que he creado en el dataGrip
            connectionStringBuilder.Port = 3306;
            conexion = new MySqlConnection(connectionStringBuilder.ToString());
        }

        public Ticket CrearTicket(DateTime fecha, string identificador,string concepto, string nombre,float importeTotal,string direccion, string ente)
        {
              

        conexion.Open();//imprescindible
            string query = "insert into tickets (fecha, identificador, concepto, nombre, importeTotal, direccion, ente) " +
            "values (@fecha, @identificador, @concepto, @nombre, @importeTotal, @direccion, @ente)";
            MySqlCommand mySqlCommand = new MySqlCommand(query, conexion);
            mySqlCommand.Parameters.AddWithValue("@fecha", fecha );
            mySqlCommand.Parameters.AddWithValue("@identificador", identificador);
            mySqlCommand.Parameters.AddWithValue("@concepto",concepto );
            mySqlCommand.Parameters.AddWithValue("@@nombre", nombre);
            mySqlCommand.Parameters.AddWithValue("@importeTotal", importeTotal);
            mySqlCommand.Parameters.AddWithValue("@direccion", direccion);
            mySqlCommand.Parameters.AddWithValue("@ente",ente );
            mySqlCommand.Prepare();
            int affectedRows = mySqlCommand.ExecuteNonQuery();
            long id = mySqlCommand.LastInsertedId;//con este tendremos el utimo id y asi actualizaremos los la bases de datos conforme el ultimo 
            conexion.Close();//imprescindibles
            if (affectedRows == 1)
            {
                return new Ticket(id, fecha, identificador, concepto,nombre,importeTotal,direccion,ente);
            }
            else
            {
                return null;
            }
        }

        public bool updateTicket(Ticket ticket)
        {
            conexion.Open();//imprescindible
            string query = "update tickets set id=@id,fecha= @fecha,identificador= @identificador,concepto= @concepto,nombre= @nombre,importeTotal= @importeTotal,direccion= @direccion,ente= @ente where id=@id";
            MySqlCommand mySqlCommand = new MySqlCommand(query, conexion);
         
            mySqlCommand.Parameters.AddWithValue("@fecha", ticket.Fecha);
            mySqlCommand.Parameters.AddWithValue("@identificador", ticket.Identificador);
            mySqlCommand.Parameters.AddWithValue("@concepto", ticket.Concepto);
            mySqlCommand.Parameters.AddWithValue("@@nombre", ticket.Nombre);
            mySqlCommand.Parameters.AddWithValue("@importeTotal", ticket.ImporteTotal);
            mySqlCommand.Parameters.AddWithValue("@direccion", ticket.Direccion);
            mySqlCommand.Parameters.AddWithValue("@ente", ticket.Ente);
            mySqlCommand.Parameters.AddWithValue("@id", ticket.Id);
            mySqlCommand.Prepare();
            int affectedRows = mySqlCommand.ExecuteNonQuery();
            conexion.Close();//imprescindibles
            return affectedRows == 1;
        }
        public bool deleteTicket(Ticket ticket)
        {
            conexion.Open();//imprescindible
            string query = "delete from  tickets where id=@id";

            MySqlCommand mySqlCommand = new MySqlCommand(query, conexion);
            mySqlCommand.Parameters.AddWithValue("@id", ticket.Id);
            mySqlCommand.Prepare();
            int affectedRows = mySqlCommand.ExecuteNonQuery();
            conexion.Close();
            return affectedRows == 1;
        }
        public List<Ticket> readTicket()
        {
            List<Ticket> ticketList = new List<Ticket>();
            conexion.Open();
            string query = "Select * from tickets";
            MySqlCommand mySqlCommand = new MySqlCommand(query, conexion);
            MySqlDataReader datos = mySqlCommand.ExecuteReader();
            while (datos.Read())//mientras  lee va copiando los datos en el array list
            {
                ticketList.Add(new Ticket(
                    datos.GetInt64("id"),
                    datos.GetDateTime("fecha"),
                    datos.GetString("identificador"),
                      datos.GetString("concepto"),
                        datos.GetString("nombre"),
                    datos.GetFloat("importeTotal"),
                      datos.GetString("direccion"),
                        datos.GetString("ente")
                    )
                );
            }
            conexion.Close();
            return ticketList;
        }
    }
}
