using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion.Consultas
{
    public partial class Consulta_Stock_Articulos : Form
    {
        public Consulta_Stock_Articulos()
        {
            InitializeComponent();
        }

        //Metodo para ocultar columnas del datagridveiw
        private void OcultarColumnas()
        {
            this.data_Listado.Columns[0].Visible = false;
        }

        //Metodo mostrar
        private void Mostrar()
        {
            this.data_Listado.DataSource = NArticulo.Stock_Articulos();
            this.OcultarColumnas();
            lb_total.Text = "Total de Registros: " + Convert.ToString(data_Listado.Rows.Count);
        }

        private void Consulta_Stock_Articulos_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Mostrar();
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            
        }

        private void boton_Redondo2_Click(object sender, EventArgs e)
        {
            ReporteStock frm = new ReporteStock();
            frm.ShowDialog();
        }

        private void data_Listado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
