namespace ListaDeTareasGUI
{
    public partial class VentanaMenuPrincipal : Form
    {
        public VentanaMenuPrincipal()
        {
            InitializeComponent();
        }

        // Instancias de las demas ventanas.
        VentanaAgregarTareas ventanaAgregarTareas = new VentanaAgregarTareas();
        VentanaVerTareas ventanaVerTareas = new VentanaVerTareas();
        VentanaCompletarTarea ventanaCompletarTarea = new VentanaCompletarTarea();

        // Elementos y eventos para abrir la ventana de agregar tareas.
        private void LabelA�adirTarea_Click(object sender, EventArgs e)
        {
            this.Hide();
            ventanaAgregarTareas.ShowDialog();
            
        }

        private void ImgA�adirTarea_Click(object sender, EventArgs e)
        {
            this.Hide();
            ventanaAgregarTareas.ShowDialog();
            
        }


        // Elementos y eventos para abrir la ventana de ver tareas pendientes.

        private void LabelVerTareas_Click(object sender, EventArgs e)
        {
            this.Hide();
            ventanaVerTareas.ShowDialog();
            
        }

        private void ImgVerTarea_Click(object sender, EventArgs e)
        {
            this.Hide();
            ventanaVerTareas.ShowDialog();
            
        }


        // Elementos y eventos para abrir la ventana de completar tareas pendientes.

        private void LabelCompletarTareas_Click(object sender, EventArgs e)
        {
            this.Hide();
            ventanaCompletarTarea.ShowDialog();
            
        }

        private void ImgCompletarTarea_Click(object sender, EventArgs e)
        {
            this.Hide();
            ventanaCompletarTarea.ShowDialog();
            
        }
    }
}
