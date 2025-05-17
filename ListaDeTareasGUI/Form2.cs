using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaDeTareasGUI
{
    public partial class VentanaAgregarTareas : Form
    {
        public VentanaAgregarTareas()
        {
            InitializeComponent();
        }

        private void LabelInsertarTarea_Click(object sender, EventArgs e)
        {
            //Recabar informacion

            // Nombre de la tarea
            string nombreTarea = InputNombreTarea.Text.Trim();
            if (nombreTarea == "")
            {
                MessageBox.Show("Favor de ingresar un nombre a la tarea.");
            }

            // Descripcion de la tarea
            string descripcionTarea = InputDescripcionTarea.Text.Trim();
            if (descripcionTarea == "")
            {
                MessageBox.Show("Favor de ingresar una descripcion a la tarea.");
            }

            // Prioridad de la tarea

            String prioridadTarea = "Sin prioridad";

            if (CheckBoxBaja.Checked)
            {
                prioridadTarea = "Baja";
            }
            else if (CheckBoxMedia.Checked)
            {
                prioridadTarea = "Media";
            }
            else if (CheckBoxAlta.Checked)
            {
                prioridadTarea = "Alta";
            }

            else
            {

                MessageBox.Show("Favor de seleccionar un nivel de prioridad.");

            }

            // Insertar en la base de datos si se confirma la tarea.

            DialogResult resultado = MessageBox.Show(
            "¿Desea agregar la siguiente tarea?",
            "Confirmación",
            MessageBoxButtons.OKCancel);

            if (resultado == DialogResult.OK)
            {
                // El usuario hizo clic en OK
                GestorBaseDatos.InsertarTarea(nombreTarea, descripcionTarea, prioridadTarea);

            }
            else
            {
                // El usuario hizo clic en Cancel o cerró el diálogo
                Console.WriteLine("Operación cancelada");
            }

        }

        private void LabelVolver_Click(object sender, EventArgs e)
        {

            this.Hide();
            GestorBaseDatos.ActualizarTareas();
            VentanaMenuPrincipal ventanaMenuPrincipal = new VentanaMenuPrincipal();
            ventanaMenuPrincipal.ShowDialog();
        }
    }
}
