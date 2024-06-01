using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Ej1.accesoAdatos;
using Ej1.Entidades;

namespace Ej1.accesoAdatos
{
    class Helper
    {

        private static Helper instancia;
        private SqlConnection conexion;
        private SqlCommand comando;
        private string cadenaConexion;

        private Helper()
        {
            conexion = new SqlConnection();
            comando = new SqlCommand();
            cadenaConexion = "Data Source=SEBA\\SQLEXPRESS;Initial Catalog=Prueba;Integrated Security=True";
        }
        public static Helper obtenerInstancia()
        {
            if (instancia == null)
                instancia = new Helper();
            return instancia;
        }

        public DataTable consultar(string consultaSQL)
        {
            conexion = new SqlConnection();
            conexion.ConnectionString = cadenaConexion;
            conexion.Open();

            comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
            comando.CommandText = consultaSQL;

            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());

            conexion.Close();

            return tabla;
        }
        public int actualizar(string consultaSQL)
        {
            int filasAfectadas = 1;
            conexion.ConnectionString = cadenaConexion;
            conexion.Open();

            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
            comando.CommandText = consultaSQL;
            filasAfectadas = comando.ExecuteNonQuery();

            conexion.Close();
            return filasAfectadas;
        }

    }
}


