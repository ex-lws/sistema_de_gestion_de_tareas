namespace ListaDeTareasGUI
{
    partial class VentanaCompletarTarea
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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            DataGridVerTareasPendientes = new DataGridView();
            panel3 = new Panel();
            LabelCompletarTarea = new Label();
            InputIdTarea = new TextBox();
            label5 = new Label();
            LabelVolver = new Label();
            panel1 = new Panel();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridVerTareasPendientes).BeginInit();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // LineaSeparadora2
            // 
            LineaSeparadora2.BackColor = Color.Black;
            LineaSeparadora2.Location = new Point(49, 738);
            LineaSeparadora2.Name = "LineaSeparadora2";
            LineaSeparadora2.Size = new Size(460, 2);
            LineaSeparadora2.TabIndex = 26;
            // 
            // LineaSeparadaora1
            // 
            LineaSeparadaora1.BackColor = Color.Black;
            LineaSeparadaora1.Location = new Point(49, 159);
            LineaSeparadaora1.Name = "LineaSeparadaora1";
            LineaSeparadaora1.Size = new Size(460, 1);
            LineaSeparadaora1.TabIndex = 25;
            // 
            // LabelSubtitulo
            // 
            LabelSubtitulo.AutoSize = true;
            LabelSubtitulo.BackColor = Color.Transparent;
            LabelSubtitulo.Font = new Font("Ebrima", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelSubtitulo.Location = new Point(285, 120);
            LabelSubtitulo.Name = "LabelSubtitulo";
            LabelSubtitulo.Size = new Size(221, 19);
            LabelSubtitulo.TabIndex = 24;
            LabelSubtitulo.Text = "Logrando cada y una de las metas.";
            // 
            // LabelBienvenida
            // 
            LabelBienvenida.AutoSize = true;
            LabelBienvenida.Font = new Font("Ebrima", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelBienvenida.Location = new Point(36, 40);
            LabelBienvenida.Name = "LabelBienvenida";
            LabelBienvenida.Size = new Size(411, 54);
            LabelBienvenida.TabIndex = 23;
            LabelBienvenida.Text = "Completar una tarea";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Lato Light", 10F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(103, 17);
            label4.Name = "label4";
            label4.Size = new Size(69, 17);
            label4.TabIndex = 18;
            label4.Text = "NOMBRE";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(49, 272);
            panel2.Name = "panel2";
            panel2.Size = new Size(457, 48);
            panel2.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Lato Light", 10F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(27, 17);
            label3.Name = "label3";
            label3.Size = new Size(30, 17);
            label3.TabIndex = 21;
            label3.Text = "No.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Lato Light", 10F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(345, 17);
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
            label1.Location = new Point(217, 17);
            label1.Name = "label1";
            label1.Size = new Size(99, 17);
            label1.TabIndex = 19;
            label1.Text = "DESCRIPCION";
            // 
            // DataGridVerTareasPendientes
            // 
            DataGridVerTareasPendientes.AccessibleDescription = "DataGridVerTareasPendientes";
            DataGridVerTareasPendientes.AccessibleName = "DataGridVerTareasPendientes";
            DataGridVerTareasPendientes.BackgroundColor = Color.Silver;
            DataGridVerTareasPendientes.BorderStyle = BorderStyle.None;
            DataGridVerTareasPendientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridVerTareasPendientes.Location = new Point(49, 335);
            DataGridVerTareasPendientes.Name = "DataGridVerTareasPendientes";
            DataGridVerTareasPendientes.Size = new Size(457, 289);
            DataGridVerTareasPendientes.TabIndex = 29;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Controls.Add(LabelCompletarTarea);
            panel3.Location = new Point(49, 630);
            panel3.Name = "panel3";
            panel3.Size = new Size(457, 48);
            panel3.TabIndex = 29;
            // 
            // LabelCompletarTarea
            // 
            LabelCompletarTarea.AccessibleDescription = "LabelCompletarTarea";
            LabelCompletarTarea.AccessibleName = "LabelCompletarTarea";
            LabelCompletarTarea.AutoSize = true;
            LabelCompletarTarea.BackColor = Color.Transparent;
            LabelCompletarTarea.Font = new Font("Lato Light", 10F);
            LabelCompletarTarea.ForeColor = Color.White;
            LabelCompletarTarea.Location = new Point(189, 16);
            LabelCompletarTarea.Name = "LabelCompletarTarea";
            LabelCompletarTarea.Size = new Size(89, 17);
            LabelCompletarTarea.TabIndex = 18;
            LabelCompletarTarea.Text = "COMPLETAR";
            LabelCompletarTarea.Click += LabelCompletarTarea_Click;
            // 
            // InputIdTarea
            // 
            InputIdTarea.AccessibleDescription = "InputIdTarea";
            InputIdTarea.AccessibleName = "InputIdTarea";
            InputIdTarea.BackColor = Color.LightGray;
            InputIdTarea.Location = new Point(49, 210);
            InputIdTarea.Multiline = true;
            InputIdTarea.Name = "InputIdTarea";
            InputIdTarea.PlaceholderText = "Escribe el número de la tarea que deseas completar.";
            InputIdTarea.Size = new Size(457, 44);
            InputIdTarea.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lato Light", 10F);
            label5.Location = new Point(49, 180);
            label5.Name = "label5";
            label5.Size = new Size(159, 17);
            label5.TabIndex = 19;
            label5.Text = "NUMERO DE LA TAREA";
            // 
            // LabelVolver
            // 
            LabelVolver.AccessibleDescription = "LabelVolver";
            LabelVolver.AccessibleName = "LabelVolver";
            LabelVolver.AutoSize = true;
            LabelVolver.BackColor = Color.Transparent;
            LabelVolver.Font = new Font("Lato Light", 10F);
            LabelVolver.ForeColor = Color.White;
            LabelVolver.Location = new Point(199, 16);
            LabelVolver.Name = "LabelVolver";
            LabelVolver.Size = new Size(60, 17);
            LabelVolver.TabIndex = 18;
            LabelVolver.Text = "VOLVER";
            LabelVolver.Click += LabelVolver_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(LabelVolver);
            panel1.Location = new Point(49, 684);
            panel1.Name = "panel1";
            panel1.Size = new Size(457, 48);
            panel1.TabIndex = 30;
            // 
            // VentanaCompletarTarea
            // 
            AccessibleName = "VentanaCompletarTarea";
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 781);
            Controls.Add(panel1);
            Controls.Add(InputIdTarea);
            Controls.Add(label5);
            Controls.Add(panel3);
            Controls.Add(LineaSeparadora2);
            Controls.Add(LineaSeparadaora1);
            Controls.Add(LabelSubtitulo);
            Controls.Add(LabelBienvenida);
            Controls.Add(panel2);
            Controls.Add(DataGridVerTareasPendientes);
            Name = "VentanaCompletarTarea";
            Text = "Form4";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridVerTareasPendientes).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
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
        private DataGridView DataGridVerTareasPendientes;
        private Panel panel3;
        private Label LabelCompletarTarea;
        private TextBox InputIdTarea;
        private Label label5;
        private Label label3;
        private Label LabelVolver;
        private Panel panel1;
    }
}