namespace ListaDeTareasGUI
{
    partial class VentanaMenuPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaMenuPrincipal));
            LabelBienvenida = new Label();
            LabelSubtitulo = new Label();
            LineaSeparadaora1 = new Panel();
            LineaSeparadora2 = new Panel();
            PanelAñadirTarea = new Panel();
            LabelAñadirTarea = new Label();
            panel1 = new Panel();
            ImgAñadirTarea = new PictureBox();
            PanelVerTareas = new Panel();
            LabelVerTareas = new Label();
            PanelCompletarTareas = new Panel();
            LabelCompletarTareas = new Label();
            panel2 = new Panel();
            ImgVerTarea = new PictureBox();
            panel3 = new Panel();
            ImgCompletarTarea = new PictureBox();
            PanelAñadirTarea.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ImgAñadirTarea).BeginInit();
            PanelVerTareas.SuspendLayout();
            PanelCompletarTareas.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ImgVerTarea).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ImgCompletarTarea).BeginInit();
            SuspendLayout();
            // 
            // LabelBienvenida
            // 
            LabelBienvenida.AutoSize = true;
            LabelBienvenida.Font = new Font("Ebrima", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelBienvenida.Location = new Point(31, 35);
            LabelBienvenida.Name = "LabelBienvenida";
            LabelBienvenida.Size = new Size(322, 54);
            LabelBienvenida.TabIndex = 1;
            LabelBienvenida.Text = "¡Hola de nuevo!";
            // 
            // LabelSubtitulo
            // 
            LabelSubtitulo.AutoSize = true;
            LabelSubtitulo.BackColor = Color.Transparent;
            LabelSubtitulo.Font = new Font("Ebrima", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelSubtitulo.Location = new Point(255, 115);
            LabelSubtitulo.Name = "LabelSubtitulo";
            LabelSubtitulo.Size = new Size(246, 19);
            LabelSubtitulo.TabIndex = 2;
            LabelSubtitulo.Text = "Todos tus pendientes en un sólo lugar.";
            // 
            // LineaSeparadaora1
            // 
            LineaSeparadaora1.BackColor = Color.Black;
            LineaSeparadaora1.Location = new Point(44, 154);
            LineaSeparadaora1.Name = "LineaSeparadaora1";
            LineaSeparadaora1.Size = new Size(460, 1);
            LineaSeparadaora1.TabIndex = 3;
            // 
            // LineaSeparadora2
            // 
            LineaSeparadora2.BackColor = Color.Black;
            LineaSeparadora2.Location = new Point(44, 733);
            LineaSeparadora2.Name = "LineaSeparadora2";
            LineaSeparadora2.Size = new Size(460, 2);
            LineaSeparadora2.TabIndex = 4;
            // 
            // PanelAñadirTarea
            // 
            PanelAñadirTarea.AccessibleDescription = "PanelAñadirTarea";
            PanelAñadirTarea.AccessibleName = "PanelAñadirTarea";
            PanelAñadirTarea.BackColor = Color.Gainsboro;
            PanelAñadirTarea.Controls.Add(LabelAñadirTarea);
            PanelAñadirTarea.Controls.Add(panel1);
            PanelAñadirTarea.Location = new Point(44, 176);
            PanelAñadirTarea.Name = "PanelAñadirTarea";
            PanelAñadirTarea.Size = new Size(460, 159);
            PanelAñadirTarea.TabIndex = 5;
            // 
            // LabelAñadirTarea
            // 
            LabelAñadirTarea.AccessibleName = "LabelAñadirTarea";
            LabelAñadirTarea.AutoSize = true;
            LabelAñadirTarea.Font = new Font("Lato Light", 10F);
            LabelAñadirTarea.Location = new Point(101, 72);
            LabelAñadirTarea.Name = "LabelAñadirTarea";
            LabelAñadirTarea.Size = new Size(107, 17);
            LabelAñadirTarea.TabIndex = 9;
            LabelAñadirTarea.Text = "AÑADIR TAREA";
            LabelAñadirTarea.Click += LabelAñadirTarea_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(ImgAñadirTarea);
            panel1.Location = new Point(312, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(148, 159);
            panel1.TabIndex = 6;
            // 
            // ImgAñadirTarea
            // 
            ImgAñadirTarea.AccessibleName = "ImgAñadirTarea";
            ImgAñadirTarea.Image = (Image)resources.GetObject("ImgAñadirTarea.Image");
            ImgAñadirTarea.Location = new Point(26, 28);
            ImgAñadirTarea.Name = "ImgAñadirTarea";
            ImgAñadirTarea.Size = new Size(100, 100);
            ImgAñadirTarea.SizeMode = PictureBoxSizeMode.AutoSize;
            ImgAñadirTarea.TabIndex = 7;
            ImgAñadirTarea.TabStop = false;
            ImgAñadirTarea.Click += ImgAñadirTarea_Click;
            // 
            // PanelVerTareas
            // 
            PanelVerTareas.AccessibleName = "PanelVerTareas";
            PanelVerTareas.BackColor = Color.LightGray;
            PanelVerTareas.Controls.Add(LabelVerTareas);
            PanelVerTareas.Location = new Point(44, 359);
            PanelVerTareas.Name = "PanelVerTareas";
            PanelVerTareas.Size = new Size(460, 159);
            PanelVerTareas.TabIndex = 6;
            // 
            // LabelVerTareas
            // 
            LabelVerTareas.AccessibleName = "LabelVerTareas";
            LabelVerTareas.AutoSize = true;
            LabelVerTareas.Font = new Font("Lato Light", 10F);
            LabelVerTareas.Location = new Point(108, 71);
            LabelVerTareas.Name = "LabelVerTareas";
            LabelVerTareas.Size = new Size(92, 17);
            LabelVerTareas.TabIndex = 10;
            LabelVerTareas.Text = "PENDIENTES";
            LabelVerTareas.Click += LabelVerTareas_Click;
            // 
            // PanelCompletarTareas
            // 
            PanelCompletarTareas.AccessibleName = "PanelCompletarTareas";
            PanelCompletarTareas.BackColor = Color.Silver;
            PanelCompletarTareas.Controls.Add(LabelCompletarTareas);
            PanelCompletarTareas.Location = new Point(44, 537);
            PanelCompletarTareas.Name = "PanelCompletarTareas";
            PanelCompletarTareas.Size = new Size(460, 159);
            PanelCompletarTareas.TabIndex = 7;
            // 
            // LabelCompletarTareas
            // 
            LabelCompletarTareas.AccessibleName = "LabelCompletarTareas";
            LabelCompletarTareas.AutoSize = true;
            LabelCompletarTareas.Font = new Font("Lato Light", 10F);
            LabelCompletarTareas.Location = new Point(108, 67);
            LabelCompletarTareas.Name = "LabelCompletarTareas";
            LabelCompletarTareas.Size = new Size(89, 17);
            LabelCompletarTareas.TabIndex = 11;
            LabelCompletarTareas.Text = "COMPLETAR";
            LabelCompletarTareas.Click += LabelCompletarTareas_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(ImgVerTarea);
            panel2.Location = new Point(356, 359);
            panel2.Name = "panel2";
            panel2.Size = new Size(148, 159);
            panel2.TabIndex = 7;
            // 
            // ImgVerTarea
            // 
            ImgVerTarea.AccessibleName = "ImgAñadirTarea";
            ImgVerTarea.Image = (Image)resources.GetObject("ImgVerTarea.Image");
            ImgVerTarea.Location = new Point(26, 31);
            ImgVerTarea.Name = "ImgVerTarea";
            ImgVerTarea.Size = new Size(100, 100);
            ImgVerTarea.SizeMode = PictureBoxSizeMode.AutoSize;
            ImgVerTarea.TabIndex = 8;
            ImgVerTarea.TabStop = false;
            ImgVerTarea.Click += ImgVerTarea_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Controls.Add(ImgCompletarTarea);
            panel3.Location = new Point(356, 537);
            panel3.Name = "panel3";
            panel3.Size = new Size(148, 159);
            panel3.TabIndex = 8;
            // 
            // ImgCompletarTarea
            // 
            ImgCompletarTarea.AccessibleName = "ImgAñadirTarea";
            ImgCompletarTarea.Image = (Image)resources.GetObject("ImgCompletarTarea.Image");
            ImgCompletarTarea.Location = new Point(26, 30);
            ImgCompletarTarea.Name = "ImgCompletarTarea";
            ImgCompletarTarea.Size = new Size(100, 100);
            ImgCompletarTarea.SizeMode = PictureBoxSizeMode.AutoSize;
            ImgCompletarTarea.TabIndex = 9;
            ImgCompletarTarea.TabStop = false;
            ImgCompletarTarea.Click += ImgCompletarTarea_Click;
            // 
            // VentanaMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 781);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(PanelCompletarTareas);
            Controls.Add(PanelVerTareas);
            Controls.Add(PanelAñadirTarea);
            Controls.Add(LineaSeparadora2);
            Controls.Add(LineaSeparadaora1);
            Controls.Add(LabelSubtitulo);
            Controls.Add(LabelBienvenida);
            Name = "VentanaMenuPrincipal";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Menu Principal";
            TransparencyKey = Color.White;
            PanelAñadirTarea.ResumeLayout(false);
            PanelAñadirTarea.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ImgAñadirTarea).EndInit();
            PanelVerTareas.ResumeLayout(false);
            PanelVerTareas.PerformLayout();
            PanelCompletarTareas.ResumeLayout(false);
            PanelCompletarTareas.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ImgVerTarea).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ImgCompletarTarea).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label LabelBienvenida;
        private Label LabelSubtitulo;
        private Panel LineaSeparadaora1;
        private Panel LineaSeparadora2;
        private Panel PanelAñadirTarea;
        private Panel PanelVerTareas;
        private Panel PanelCompletarTareas;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private PictureBox ImgAñadirTarea;
        private PictureBox ImgVerTarea;
        private PictureBox ImgCompletarTarea;
        private Label LabelAñadirTarea;
        private Label LabelVerTareas;
        private Label LabelCompletarTareas;
    }
}
