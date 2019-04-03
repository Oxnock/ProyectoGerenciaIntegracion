using MySql.Data.MySqlClient;
using SampleMvcApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleMvcApp.Data
{
    public class sql3283190Context
    {
        public string ConnectionString { get; set; }

        public sql3283190Context(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        public bool BuscarPersonaCorreoValidar(string emailbuscado) // este metodo lo que hace es ver si esta 
        {
            ProfileModel Persona = new ProfileModel();


            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM `usuarios` WHERE Correo = '" + emailbuscado + "'", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        
                        Persona.Name = reader["Nombre"].ToString();

                    }
                }
                if (Persona.Name != null)
                {
                    return true; //retorna true cuando fue encontrado

                }
                
            }

            return false; // retorna false si no fue encontrado

        }

        public void EditarUsuario(string nombre, string apellido1, string apellido2, string telefono, string email)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE `usuarios` SET `Nombre`='" + nombre + "',`Apellido1`='" + apellido1 + "',`Apellido2`='" + apellido2 + "',`NumeroTelefono`='" + telefono + "' WHERE Correo = '" + email + "'", conn);
               
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        //aqui debo darle lo que vale cada valor del modelo 

                    }
                }
            }

        }

        public void InsertFormInicial(string nombre, string apellido1, string apellido2, string telefono, string personaID, string tipoID , string email)
        {
               using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO `usuarios`( `Nombre`, `Apellido1`, `Apellido2`, `NumeroTelefono`, `Cedula`, `TipoCedula`, `Correo`) VALUES( '"+nombre+"','"+apellido1+"','"+apellido2+"','"+telefono+"','"+personaID+"','"+tipoID+"','"+email+"')", conn);
                //MySqlCommand cmd = new MySqlCommand("UPDATE `usuarios` SET `Nombre`='"+nombre+"',`Apellido1`='"+apellido1+"',`Apellido2`='"+apellido2+"',`NumeroTelefono`='"+telefono+"',`Cedula`='"+personaID+"',`TipoCedula`='"+tipoID+"' WHERE Correo = '"+email+"'", conn);
                //    MySqlCommand cmd2 = new MySqlCommand("INSERT INTO  'usuarios'('Apellido1', 'Apellido2', 'NumeroTelefono', 'Cedula', TipoCedula) VALUES('" + apellido1 + "','" + apellido2 + "','" + telefono + "','" + personaID + "','" + tipoID + "') WHERE Correo = '" + email + "'", conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        //aqui debo darle lo que vale cada valor del modelo 

                    }
                }
            }
        }
        public void InsertarUsuarioPrimeraVez(string nombre, string correo, string celular) // aqui lo que hago es insertar un usuario por primera vez
        {
            ProfileModel Persona = new ProfileModel();


            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                
                MySqlCommand cmd = new MySqlCommand("INSERT INTO `usuarios`(`Nombre`, `Correo`, `NumeroTelefono`) VALUES('" + nombre+"','"+correo+ "','"+celular+"')", conn);
                
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        
                        //aqui debo darle lo que vale cada valor del modelo 

                    }
                }

                Persona.Name = nombre;
                Persona.EmailAddress = correo;
                Persona.PhoneNumber = celular;

            }
        }




        public ProfileModel ObtenerPersona(String emailbuscado)
        {
            ProfileModel Persona = new ProfileModel();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM `usuarios` WHERE Correo = '" + emailbuscado + "'", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {


                        Persona.Name = reader["Nombre"].ToString();
                        Persona.FirstLastName = reader["Apellido1"].ToString();
                        Persona.SecondLastName = reader["Apellido2"].ToString();
                        Persona.PersonID = reader["Cedula"].ToString();
                        Persona.EmailAddress = reader["Correo"].ToString();
                        Persona.PhoneNumber = reader["NumeroTelefono"].ToString();
                        Persona.IDType = reader["TipoCedula"].ToString();


                        
                    }
                }
            }
            return Persona;
        }



    }
}
