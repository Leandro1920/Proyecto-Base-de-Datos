using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdministracionBD.BLL;
using AdministracionBD.DAL;


namespace AdministracionBD.PL
{
    public partial class frmDepartamentos : Form
    {

        DepartamentosDAL oDepartamentosDAL;
        public frmDepartamentos()
        {
            oDepartamentosDAL = new DepartamentosDAL(); 
            InitializeComponent();
            dgvDepartamentos.DataSource = oDepartamentosDAL.MostrarDepartamentos().Tables[0];
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
                                
            MessageBox.Show("Conectado..." );
            oDepartamentosDAL.Agregar(recuperarInformacion());
            dgvDepartamentos.DataSource = oDepartamentosDAL.MostrarDepartamentos().Tables[0];
        }
        //Obtener la informacion de la interfaz grafica

        private DepartamentoBLL recuperarInformacion()
        {
            DepartamentoBLL oDepartamentoBLL = new DepartamentoBLL();
            int ID = 0; int.TryParse(txtID.Text, out ID);
            oDepartamentoBLL.ID = ID;

            oDepartamentoBLL.Departamento = txtNombre.Text;

          
            return oDepartamentoBLL;
            }

        private void Seleccionar(object sender, DataGridViewCellMouseEventArgs e)
        {
            int indice = e.RowIndex;

            txtID.Text = dgvDepartamentos.Rows[indice].Cells[0].Value.ToString();
            txtNombre.Text = dgvDepartamentos.Rows[indice].Cells[1].Value.ToString();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            oDepartamentosDAL.Eliminar(recuperarInformacion());
            dgvDepartamentos.DataSource = oDepartamentosDAL.MostrarDepartamentos().Tables[0];
        }
    }
    }

