namespace ListaDeTareasGUI
{
    partial class VentanaVerTareas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LineaSeparadora2 = new Panel();
            LineaSeparadaora1 = new Panel();
            LabelSubtitulo = new Label();
            LabelBienvenida = new Label();
            label4 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            DataGridVerTareas = new DataGridView();
            panel1 = new Panel();
            LabelVolver = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridVerTareas).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // LineaSeparadora2
            // 
            LineaSeparadora2.BackColor = Color.Black;
            LineaSeparadora2.Location = new Point(49, 738);
            LineaSeparadora2.Name = "LineaSeparadora2";
            LineaSeparadora2.Size = new Size(460, 2);
            LineaSeparadora2.TabIndex = 12;
            // 
            // LineaSeparadaora1
            // 
            LineaSeparadaora1.BackColor = Color.Black;
            LineaSeparadaora1.Location = new Point(49, 159);
            LineaSeparadaora1.Name = "LineaSeparadaora1";
            LineaSeparadaora1.Size = new Size(460, 1);
            LineaSeparadaora1.TabIndex = 11;
            // 
            // LabelSubtitulo
            // 
            LabelSubtitulo.AutoSize = true;
            LabelSubtitulo.BackColor = Color.Transparent;
            LabelSubtitulo.Font = new Font("Ebrima", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelSubtitulo.Location = new Point(289, 120);
            LabelSubtitulo.Name = "LabelSubtitulo";
            LabelSubtitulo.Size = new Size(217, 19);
            LabelSubtitulo.TabIndex = 10;
            LabelSubtitulo.Text = "Todo aquello que se quiere lograr.";
            // 
            // LabelBienvenida
            // 
            LabelBienvenida.AutoSize = true;
            LabelBienvenida.Font = new Font("Ebrima", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelBienvenida.Location = new Point(36, 40);
            LabelBienvenida.Name = "LabelBienvenida";
            LabelBienvenida.Size = new Size(366, 54);
            LabelBienvenida.TabIndex = 9;
            LabelBienvenida.Text = "Tareas pendientes";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Lato Light", 10F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(27, 17);
            label4.Name = "label4";
            label4.Size = new Size(69, 17);
            label4.TabIndex = 18;
            label4.Text = "NOMBRE";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(49, 180);
            panel2.Name = "panel2";
            panel2.Size = new Size(460, 48);
            panel2.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Lato Light", 10F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(347, 17);
            label2.Name = "label2";
            label2.Size = new Size(84, 17);
            label2.TabIndex = 20;
            label2.Text = "PRIORIDAD";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Lato Light", 10F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(178, 17);
            label1.Name = "label1";
            label1.Size = new Size(99, 17);
            label1.TabIndex = 19;
            label1.Text = "DESCRIPCION";
            // 
            // DataGridVerTareas
            // 
            DataGridVerTareas.AccessibleName = "DataGridVerTareas";
            DataGridVerTareas.BackgroundColor = Color.Silver;
            DataGridVerTareas.BorderStyle = BorderStyle.None;
            DataGridVerTareas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridVerTareas.Location = new Point(49, 248);
            DataGridVerTareas.Name = "DataGridVerTareas";
            DataGridVerTareas.Size = new Size(457, 412);
            DataGridVerTareas.TabIndex = 22;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(LabelVolver);
            panel1.Location = new Point(49, 675);
            panel1.Name = "panel1";
            panel1.Size = new Size(457, 48);
            panel1.TabIndex = 21;
            // 
            // LabelVolver
            // 
            LabelVolver.AccessibleDescription = "LabelVolver";
            LabelVolver.AccessibleName = "LabelVolver";
            LabelVolver.AutoSize = true;
            LabelVolver.BackColor = Color.Transparent;
            LabelVolver.Font = new Font("Lato Light", 10F);
            LabelVolver.ForeColor = Color.White;
            LabelVolver.Location = new Point(194, 15);
            LabelVolver.Name = "LabelVolver";
            LabelVolver.Size = new Size(60, 17);
            LabelVolver.TabIndex = 19;
            LabelVolver.Text = "VOLVER";
            LabelVolver.Click += LabelVolver_Click;
            // 
            // VentanaVerTareas
            // 
            AccessibleName = "VentanaVerTareas";
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 781);
            Controls.Add(panel1);
            Controls.Add(DataGridVerTareas);
            Controls.Add(panel2);
            Controls.Add(LineaSeparadora2);
            Controls.Add(LineaSeparadaora1);
            Controls.Add(LabelSubtitulo);
            Controls.Add(LabelBienvenida);
            Name = "VentanaVerTareas";
            Text = "Ver tareas pendientes";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridVerTareas).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel LineaSeparadora2;
        private Panel LineaSeparadaora1;
        private Label LabelSubtitulo;
        private Label LabelBienvenida;
        private Label label4;
        private Panel panel2;
        private Label label2;
        private Label label1;
        private DataGridView DataGridVerTareas;
        private Panel panel1;
        private Label LabelVolver;
    }
}