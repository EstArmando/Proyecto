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
            label1 = new Label();
            txtID = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtNombre = new TextBox();
            txtCorreo = new TextBox();
            label4 = new Label();
            txtContraseña = new TextBox();
            btnCrear = new Button();
            btnEliminar = new Button();
            dtUsuarios = new DataGridView();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtUsuarios).BeginInit();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 82);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 23;
            label1.Text = "ID:";
            // 
            // txtID
            // 
            txtID.Location = new Point(85, 79);
            txtID.Name = "txtID";
            txtID.Size = new Size(97, 23);
            txtID.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(404, 82);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 25;
            label3.Text = "Correo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 131);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 24;
            label2.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(85, 128);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(259, 23);
            txtNombre.TabIndex = 27;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(480, 79);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(258, 23);
            txtCorreo.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(404, 131);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 29;
            label4.Text = "Contraseña:";
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(480, 128);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(258, 23);
            txtContraseña.TabIndex = 30;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(256, 179);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(75, 23);
            btnCrear.TabIndex = 31;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(471, 179);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 32;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // dtUsuarios
            // 
            dtUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtUsuarios.Location = new Point(12, 221);
            dtUsuarios.Name = "dtUsuarios";
            dtUsuarios.Size = new Size(564, 287);
            dtUsuarios.TabIndex = 33;
            // 
            // Usuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 529);
            Controls.Add(dtUsuarios);
            Controls.Add(btnEliminar);
            Controls.Add(btnCrear);
            Controls.Add(txtContraseña);
            Controls.Add(label4);
            Controls.Add(txtCorreo);
            Controls.Add(txtNombre);
            Controls.Add(txtID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCerrarSes);
            Controls.Add(lblUsuario);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Usuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Usuarios";
            FormClosing += Usuarios_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolLabs;
        private ToolStripMenuItem toolUsuarios;
        private Label lblUsuario;
        private Button btnCerrarSes;
        private Label label1;
        private TextBox txtID;
        private Label label3;
        private Label label2;
        private TextBox txtNombre;
        private TextBox txtCorreo;
        private Label label4;
        private TextBox txtContraseña;
        private Button btnCrear;
        private Button btnEliminar;
        private DataGridView dtUsuarios;
    }
}