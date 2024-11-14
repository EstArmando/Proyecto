namespace Proyecto.Formularios.UsuariosForm
{
    partial class Usuarios
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
            menuStrip1 = new MenuStrip();
            toolLabs = new ToolStripMenuItem();
            toolUsuarios = new ToolStripMenuItem();
            lblUsuario = new Label();
            btnCerrarSes = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolLabs, toolUsuarios });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 20;
            menuStrip1.Text = "menu";
            // 
            // toolLabs
            // 
            toolLabs.Name = "toolLabs";
            toolLabs.Size = new Size(85, 20);
            toolLabs.Text = "Laboratorios";
            toolLabs.Click += toolLabs_Click;
            // 
            // toolUsuarios
            // 
            toolUsuarios.Name = "toolUsuarios";
            toolUsuarios.Size = new Size(64, 20);
            toolUsuarios.Text = "Usuarios";
            toolUsuarios.Click += toolUsuarios_Click;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(12, 37);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(129, 30);
            lblUsuario.TabIndex = 21;
            lblUsuario.Text = "Bienvenido:";
            // 
            // btnCerrarSes
            // 
            btnCerrarSes.Location = new Point(685, 475);
            btnCerrarSes.Name = "btnCerrarSes";
            btnCerrarSes.Size = new Size(94, 33);
            btnCerrarSes.TabIndex = 22;
            btnCerrarSes.Text = "Cerrar Sesion";
            btnCerrarSes.UseVisualStyleBackColor = true;
            btnCerrarSes.Click += btnCerrarSes_Click;
            // 
            // Usuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 529);
            Controls.Add(btnCerrarSes);
            Controls.Add(lblUsuario);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Usuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Usuarios";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolLabs;
        private ToolStripMenuItem toolUsuarios;
        private Label lblUsuario;
        private Button btnCerrarSes;
    }
}