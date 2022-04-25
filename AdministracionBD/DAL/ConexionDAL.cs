using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AdministracionBD.DAL
{
    class ConexionDAL
    {
        private string CadenaConexion = "Data Source =.;Initial Catalog=Proyecto_DB; Integrated Security = true";

        SqlConnection Conexion;

        public SqlConnection EstablecerConexion() {
            this.Conexion = new SqlConnection(this.CadenaConexion);
            return this.Conexion;
                }
        public bool ejecutarComandoSinRetornoDatos(string strComando)
                
        {
            try {
               
                SqlCommand Comando = new SqlCommand();

                Comando.CommandText = strComando;
                Comando.Connection = this.EstablecerConexion();
                Conexion.Open();
                Comando.ExecuteNonQuery();
                Conexion.Close();


                return true;
                
            } catch{
                return false;

            }
        }

        //retorno de los datos//

        public DataSet EjecutarSentencia(SqlCommand sqlcommando)
        {
            DataSet DS = new DataSet();
            SqlDataAdapter adaptador = new SqlDataAdapter();

            try {
                SqlCommand Comando = new SqlCommand();
                Comando = sqlcommando;
                Comando.Connection = EstablecerConexion();
                adaptador.SelectCommand = Comando;
                Conexion.Open();
                adaptador.Fill(DS);
                Conexion.Close();
                return DS;

            }
            catch {
                return DS;
            }
        }
    }
}
