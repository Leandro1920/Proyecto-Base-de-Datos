using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using AdministracionBD.BLL;

namespace AdministracionBD.DAL
{
    class DepartamentosDAL
    {
        ConexionDAL conexion = new ConexionDAL();

        public DepartamentosDAL()
        {
            conexion = new ConexionDAL();
        }
        public bool Agregar(DepartamentoBLL oDepartamentoBLL)
        {
          return  conexion.ejecutarComandoSinRetornoDatos("insert into departamentos (departamento) Values ('"+oDepartamentoBLL.Departamento+"')");

        }
        public int Eliminar(DepartamentoBLL oDepartamentoBLL)
        {
            conexion.ejecutarComandoSinRetornoDatos("delete from departamentos where ID= "+oDepartamentoBLL.ID);

            return 1;
        }
        public DataSet MostrarDepartamentos()
        {
            SqlCommand sentencia = new SqlCommand("Select * from Departamentos");

            return conexion.EjecutarSentencia(sentencia);
        }
    }
}
