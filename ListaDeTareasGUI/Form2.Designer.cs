namespace ListaDeTareasGUI
{
    partial class VentanaAgregarTareas
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
            components = new System.ComponentModel.Container();
            RecuadroOpcion1 = new Panel();
            CheckBoxAlta = new CheckBox();
            CheckBoxMedia = new CheckBox();
            CheckBoxBaja = new CheckBox();
            InputDescripcionTarea = new TextBox();
            InputNombreTarea = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            LineaSeparadora2 = new Panel();
            LineaSeparadaora1 = new Panel();
            LabelSubtitulo = new Label();
            LabelBienvenida = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panel2 = new Panel();
            LabelInsertarTarea = new Label();
            panel1 = new Panel();
            LabelVolver = new Label();
            RecuadroOpcion1.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // RecuadroOpcion1
            // 
            RecuadroOpcion1.BackColor = Color.Silver;
            RecuadroOpcion1.Controls.Add(CheckBoxAlta);
            RecuadroOpcion1.Controls.Add(CheckBoxMedia);
            RecuadroOpcion1.Controls.Add(CheckBoxBaja);
            RecuadroOpcion1.Controls.Add(InputDescripcionTarea);
            RecuadroOpcion1.Controls.Add(InputNombreTarea);
            RecuadroOpcion1.Controls.Add(label3);
            RecuadroOpcion1.Controls.Add(label2);
            RecuadroOpcion1.Controls.Add(label1);
            RecuadroOpcion1.Location = new Point(49, 181);
            RecuadroOpcion1.Name = "RecuadroOpcion1";
            RecuadroOpcion1.Size = new Size(460, 408);
            RecuadroOpcion1.TabIndex = 13;
            // 
            // CheckBoxAlta
            // 
            CheckBoxAlta.AccessibleName = "CheckBoxAlta";
            CheckBoxAlta.AutoSize = true;
            CheckBoxAlta.Font = new Font("Lato Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CheckBoxAlta.Location = new Point(273, 352);
            CheckBoxAlta.Name = "CheckBoxAlta";
            CheckBoxAlta.Size = new Size(53, 19);
            CheckBoxAlta.TabIndex = 17;
            CheckBoxAlta.Text = "ALTA";
            CheckBoxAlta.UseVisualStyleBackColor = true;
            // 
            // CheckBoxMedia
            // 
            CheckBoxMedia.AccessibleName = "CheckBoxMedia";
            CheckBoxMedia.AutoSize = true;
            CheckBoxMedia.Font = new Font("Lato Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CheckBoxMedia.Location = new Point(195, 352);
            CheckBoxMedia.Name = "CheckBoxMedia";
            CheckBoxMedia.Size = new Size(64, 19);
            CheckBoxMedia.TabIndex = 14;
            CheckBoxMedia.Text = "MEDIA";
            CheckBoxMedia.UseVisualStyleBackColor = true;
            // 
            // CheckBoxBaja
            // 
            CheckBoxBaja.AccessibleName = "CheckBoxBaja";
            CheckBoxBaja.AutoSize = true;
            CheckBoxBaja.Font = new Font("Lato Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CheckBoxBaja.Location = new Point(122, 352);
            CheckBoxBaja.Name = "CheckBoxBaja";
            CheckBoxBaja.Size = new Size(55, 19);
            CheckBoxBaja.TabIndex = 16;
            CheckBoxBaja.Text = "BAJA";
            CheckBoxBaja.UseVisualStyleBackColor = true;
            // 
            // InputDescripcionTarea
            // 
            InputDescripcionTarea.AccessibleName = "InputDescripcionTarea";
            InputDescripcionTarea.Location = new Point(19, 181);
            InputDescripcionTarea.Multiline = true;
            InputDescripcionTarea.Name = "InputDescripcionTarea";
            InputDescripcionTarea.PlaceholderText = "Escribe una breve descripción sobre tu tarea.";
            InputDescripcionTarea.Size = new Size(417, 95);
            InputDescripcionTarea.TabIndex = 15;
            // 
            // InputNombreTarea
            // 
            InputNombreTarea.AccessibleName = "InputNombreTarea";
            InputNombreTarea.Location = new Point(19, 71);
            InputNombreTarea.Multiline = true;
            InputNombreTarea.Name = "InputNombreTarea";
            InputNombreTarea.PlaceholderText = "Escribe el nombre de la tarea que deseas agregar.";
            InputNombreTarea.Size = new Size(417, 55);
            InputNombreTarea.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lato Light", 10F);
            label3.Location = new Point(19, 314);
            label3.Name = "label3";
            label3.Size = new Size(84, 17);
            label3.TabIndex = 11;
            label3.Text = "PRIORIDAD";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lato Light", 10F);
            label2.Location = new Point(19, 146);
            label2.Name = "label2";
            label2.Size = new Size(99, 17);
            label2.TabIndex = 10;
            label2.Text = "DESCRIPCION";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lato Light", 10F);
            label1.Location = new Point(19, 32);
            label1.Name = "label1";
            label1.Size = new Size(158, 17);
            label1.TabIndex = 9;
            label1.Text = "NOMBRE DE LA TAREA";
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
            LineaSeparadaora1.Location = new Point(49, 157);
            LineaSeparadaora1.Name = "LineaSeparadaora1";
            LineaSeparadaora1.Size = new Size(460, 1);
            LineaSeparadaora1.TabIndex = 11;
            // 
            // LabelSubtitulo
            // 
            LabelSubtitulo.AutoSize = true;
            LabelSubtitulo.BackColor = Color.Transparent;
            LabelSubtitulo.Font = new Font("Ebrima", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelSubtitulo.Location = new Point(341, 120);
            LabelSubtitulo.Name = "LabelSubtitulo";
            LabelSubtitulo.Size = new Size(165, 19);
            LabelSubtitulo.TabIndex = 10;
            LabelSubtitulo.Text = "Planear es el primer paso.";
            // 
            // LabelBienvenida
            // 
            LabelBienvenida.AutoSize = true;
            LabelBienvenida.Font = new Font("Ebrima", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelBienvenida.Location = new Point(36, 40);
            LabelBienvenida.Name = "LabelBienvenida";
            LabelBienvenida.Size = new Size(286, 54);
            LabelBienvenida.TabIndex = 9;
            LabelBienvenida.Text = "Agregar tarea";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(LabelInsertarTarea);
            panel2.Location = new Point(49, 607);
            panel2.Name = "panel2";
            panel2.Size = new Size(460, 48);
            panel2.TabIndex = 15;
            // 
            // LabelInsertarTarea
            // 
            LabelInsertarTarea.AccessibleName = "LabelInsertarTarea";
            LabelInsertarTarea.AutoSize = true;
            LabelInsertarTarea.BackColor = Color.Transparent;
            LabelInsertarTarea.Font = new Font("Lato Light", 10F);
            LabelInsertarTarea.ForeColor = Color.White;
            LabelInsertarTarea.Location = new Point(137, 16);
            LabelInsertarTarea.Name = "LabelInsertarTarea";
            LabelInsertarTarea.Size = new Size(189, 17);
            LabelInsertarTarea.TabIndex = 18;
            LabelInsertarTarea.Text = "AGREGAR TAREA A LA LISTA";
            LabelInsertarTarea.Click += LabelInsertarTarea_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(LabelVolver);
            panel1.Location = new Point(49, 673);
            panel1.Name = "panel1";
            panel1.Size = new Size(460, 48);
            panel1.TabIndex = 19;
            // 
            // LabelVolver
            // 
            LabelVolver.AccessibleName = "LabelVolver";
            LabelVolver.AutoSize = true;
            LabelVolver.BackColor = Color.Transparent;
            LabelVolver.Font = new Font("Lato Light", 10F);
            LabelVolver.ForeColor = Color.White;
            LabelVolver.Location = new Point(199, 15);
            LabelVolver.Name = "LabelVolver";
            LabelVolver.Size = new Size(60, 17);
            LabelVolver.TabIndex = 18;
            LabelVolver.Text = "VOLVER";
            LabelVolver.Click += LabelVolver_Click;
            // 
            // VentanaAgregarTareas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 781);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(RecuadroOpcion1);
            Controls.Add(LineaSeparadora2);
            Controls.Add(LineaSeparadaora1);
            Controls.Add(LabelSubtitulo);
            Controls.Add(LabelBienvenida);
            Name = "VentanaAgregarTareas";
            Text = "Agregar una tarea";
            RecuadroOpcion1.ResumeLayout(false);
            RecuadroOpcion1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel RecuadroOpcion1;
        private Label label1;
        private Panel LineaSeparadora2;
        private Panel LineaSeparadaora1;
        private Label LabelSubtitulo;
        private Label LabelBienvenida;
        private Label label3;
        private Label label2;
        private TextBox InputNombreTarea;
        private System.Windows.Forms.Timer timer1;
        private TextBox InputDescripcionTarea;
        private CheckBox CheckBoxAlta;
        private CheckBox CheckBoxMedia;
        private CheckBox CheckBoxBaja;
        private Panel panel2;
        private Label LabelInsertarTarea;
        private Panel panel1;
        private Label LabelVolver;
    }
}