using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaDeTareasGUI
{
    public partial class VentanaVerTareas : Form

    {
        // Variables globales
        String rutaBaseDeDatos = "ListaDeTareas.db";

        public VentanaVerTareas()
        {
            // Metodos que necesito para poder cargar la base de datos y mostrar las tareas.

            InitializeComponent();
            ConfigurarDataGridView();
            CargarTareas();
        }

        private void ConfigurarDataGridView()
        {
            // Ocultar encabezados y mostrar unicamente las filas o registros.
            DataGridVerTareas.ColumnHeadersVisible = false;
            DataGridVerTareas.RowHeadersVisible = false;
            DataGridVerTareas.ScrollBars = ScrollBars.Vertical; // Solo scroll vertical
            DataGridVerTareas.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Configuración de apariencia
            DataGridVerTareas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridVerTareas.DefaultCellStyle.Font = new Font("Lato", 10);
            DataGridVerTareas.BackgroundColor = SystemColors.Window;
            DataGridVerTareas.BorderStyle = BorderStyle.None;
            DataGridVerTareas.CellBorderStyle = DataGridViewCellBorderStyle.None;
            DataGridVerTareas.DefaultCellStyle.Padding = new Padding(5);
            DataGridVerTareas.RowTemplate.Height = 35;
        }

        private void CargarTareas()
        {
            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection("Data Source=" + rutaBaseDeDatos + ";Version=3;"))
                {
                    conexion.Open();
                    string codigoSQL = "SELECT nombreTarea, descripcionTarea, prioridadTarea FROM Tareas";

                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(codigoSQL, conexion);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    DataGridVerTareas.DataSource = dt;

                    // Ajustar el alto de las filas para mejor visualización
                    DataGridVerTareas.RowTemplate.Height = 60;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar tareas: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LabelVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaMenuPrincipal ventanaMenuPrincipal = new VentanaMenuPrincipal();
            ventanaMenuPrincipal.ShowDialog();
        }
    }
}
