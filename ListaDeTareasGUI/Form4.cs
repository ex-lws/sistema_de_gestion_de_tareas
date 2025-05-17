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
    public partial class VentanaCompletarTarea : Form
    {

        // Variables globales
        String rutaBaseDeDatos = "ListaDeTareas.db";



        public VentanaCompletarTarea()
        {

            InitializeComponent();
            ConfigurarDataGridView();
            CargarTareas();
        }

        // Metodos para poder ver el contenido de la base de datos en el data grid.

        private void LabelCompletarTarea_Click(object sender, EventArgs e)
        {
            int idTarea = Convert.ToInt32(InputIdTarea.Text.Trim());

            DialogResult resultado = MessageBox.Show(
            "¿Deseas completar dicha tarea?",
            "Confirmación",
            MessageBoxButtons.OKCancel);

            if (resultado == DialogResult.OK)
            {
                // El usuario hizo clic en OK
                //GestorBaseDatos.ActualizarListaTareas();         
                GestorBaseDatos.ElminarTarea(idTarea);
                CargarTareas();
            } 

            else
            {
                // El usuario hizo clic en Cancel o cerró el diálogo
                Console.WriteLine("Operación cancelada...");
            }
        }

        public void ConfigurarDataGridView()
        {
            // Ocultar encabezados y mostrar unicamente las filas o registros.
            DataGridVerTareasPendientes.ColumnHeadersVisible = false;
            DataGridVerTareasPendientes.RowHeadersVisible = false;
            DataGridVerTareasPendientes.ScrollBars = ScrollBars.Vertical; // Solo scroll vertical
            DataGridVerTareasPendientes.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Configuración de apariencia
            DataGridVerTareasPendientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridVerTareasPendientes.DefaultCellStyle.Font = new Font("Lato", 10);
            DataGridVerTareasPendientes.BackgroundColor = SystemColors.Window;
            DataGridVerTareasPendientes.BorderStyle = BorderStyle.None;
            DataGridVerTareasPendientes.CellBorderStyle = DataGridViewCellBorderStyle.None;
            DataGridVerTareasPendientes.DefaultCellStyle.Padding = new Padding(5);
            DataGridVerTareasPendientes.RowTemplate.Height = 35;
        }

        public void CargarTareas()
        {
            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection("Data Source=" + rutaBaseDeDatos + ";Version=3;"))
                {
                    conexion.Open();
                    string codigoSQL = "SELECT * FROM Tareas";

                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(codigoSQL, conexion);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    DataGridVerTareasPendientes.DataSource = dt;

                    // Ajustar el alto de las filas para mejor visualización
                    DataGridVerTareasPendientes.RowTemplate.Height = 60;
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
