using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Ej1.accesoAdatos
{
    internal class UsuarioDAO
    {


        public static bool ValidarUsuario(string nombreUsuario, string password)
        {
            
            try
            {
                bool result = false;
                string consulta = "SELECT ID FROM Usuarios WHERE Usuario = '" + nombreUsuario + "' AND Pass = '" + password + "'";

                DataTable resultado = Helper.obtenerInstancia().consultar(consulta);



                if (resultado.Rows.Count == 1)
                {

                    result = true;
                }
                else
                {
                    result = false;

                }
                return result;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        //bool result = false;
        //SqlConnection cn = new SqlConnection();
        //cn.ConnectionString = "Data Source=SEBA\\SQLEXPRESS;Initial Catalog=Prueba;Integrated Security=True";

        //try
        //{
        //    cn.Open();
        //    string consulta = "SELECT ID FROM Usuarios WHERE Usuario = '" + nombreUsuario + "' AND Pass = '" + password+ "'";
        //    SqlCommand cmd = new SqlCommand(consulta, cn);

        //    DataTable resultabla = new DataTable();
        //    resultabla.Load(cmd.ExecuteReader());
        //    result = (resultabla.Rows.Count == 1);
        //}
        //catch (SqlException ex)
        //{
        //    MessageBox.Show("Error de base de datos: " + ex.Message);
        //}
        //finally
        //{
        //    if (cn.State == ConnectionState.Open)
        //        cn.Close();
        //}
        //return result;
        //hasta acca


        //catch (Exception ex)
        //{

        //    throw;
        //}




    }
}


