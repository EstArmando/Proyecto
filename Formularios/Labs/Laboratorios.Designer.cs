namespace Proyecto.Formularios.Labs
{
    partial class Laboratorios
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtID = new TextBox();
            txtNombre = new TextBox();
            txtUbicación = new TextBox();
            txtCapacidad = new TextBox();
            txtResponsable = new TextBox();
            btnNuevo = new Button();
            btnActualizar = new Button();
            dtLabs = new DataGridView();
            btnCerrar = new Button();
            btnAbrir = new Button();
            btnInfo = new Button();
            lblUsuario = new Label();
            btnCerrarSes = new Button();
            btnReporte = new Button();
            ((System.ComponentModel.ISupportInitialize)dtLabs).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 98);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 148);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 203);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 2;
            label3.Text = "Ubicación:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(385, 98);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 3;
            label4.Text = "Capacidad:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(385, 148);
            label5.Name = "label5";
            label5.Size = new Size(76, 15);
            label5.TabIndex = 4;
            label5.Text = "Responsable:";
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(105, 95);
            txtID.Name = "txtID";
            txtID.Size = new Size(71, 23);
            txtID.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(105, 145);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(218, 23);
            txtNombre.TabIndex = 6;
            // 
            // txtUbicación
            // 
            txtUbicación.Location = new Point(105, 200);
            txtUbicación.Name = "txtUbicación";
            txtUbicación.Size = new Size(218, 23);
            txtUbicación.TabIndex = 7;
            // 
            // txtCapacidad
            // 
            txtCapacidad.Location = new Point(471, 95);
            txtCapacidad.Name = "txtCapacidad";
            txtCapacidad.Size = new Size(75, 23);
            txtCapacidad.TabIndex = 8;
            // 
            // txtResponsable
            // 
            txtResponsable.Location = new Point(471, 145);
            txtResponsable.Name = "txtResponsable";
            txtResponsable.Size = new Size(252, 23);
            txtResponsable.TabIndex = 9;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(456, 203);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 10;
            btnNuevo.Text = "Crear";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(633, 203);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 11;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // dtLabs
            // 
            dtLabs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtLabs.Location = new Point(12, 260);
            dtLabs.Name = "dtLabs";
            dtLabs.Size = new Size(657, 254);
            dtLabs.TabIndex = 12;
            dtLabs.CellClick += dtLabs_CellClick;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(701, 354);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(75, 23);
            btnCerrar.TabIndex = 13;
            btnCerrar.Text = "Cerrar Lab";
            btnCerrar.UseVisualStyleBackColor = true;
            // 
            // btnAbrir
            // 
            btnAbrir.Location = new Point(701, 302);
            btnAbrir.Name = "btnAbrir";
            btnAbrir.Size = new Size(75, 23);
            btnAbrir.TabIndex = 14;
            btnAbrir.Text = "Abrir Lab";
            btnAbrir.UseVisualStyleBackColor = true;
            // 
            // btnInfo
            // 
            btnInfo.Location = new Point(694, 401);
            btnInfo.Name = "btnInfo";
            btnInfo.Size = new Size(94, 49);
            btnInfo.TabIndex = 15;
            btnInfo.Text = "Información Lab";
            btnInfo.UseVisualStyleBackColor = true;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(12, 28);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(129, 30);
            lblUsuario.TabIndex = 16;
            lblUsuario.Text = "Bienvenido:";
            // 
            // btnCerrarSes
            // 
            btnCerrarSes.Location = new Point(694, 465);
            btnCerrarSes.Name = "btnCerrarSes";
            btnCerrarSes.Size = new Size(94, 33);
            btnCerrarSes.TabIndex = 17;
            btnCerrarSes.Text = "Cerrar Sesion";
            btnCerrarSes.UseVisualStyleBackColor = true;
            btnCerrarSes.Click += btnCerrarSes_Click;
            // 
            // btnReporte
            // 
            btnReporte.Location = new Point(623, 36);
            btnReporte.Name = "btnReporte";
            btnReporte.Size = new Size(143, 23);
            btnReporte.TabIndex = 18;
            btnReporte.Text = "Generar reporte";
            btnReporte.UseVisualStyleBackColor = true;
            // 
            // Laboratorios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 529);
            Controls.Add(btnReporte);
            Controls.Add(btnCerrarSes);
            Controls.Add(lblUsuario);
            Controls.Add(btnInfo);
            Controls.Add(btnAbrir);
            Controls.Add(btnCerrar);
            Controls.Add(dtLabs);
            Controls.Add(btnActualizar);
            Controls.Add(btnNuevo);
            Controls.Add(txtResponsable);
            Controls.Add(txtCapacidad);
            Controls.Add(txtUbicación);
            Controls.Add(txtNombre);
            Controls.Add(txtID);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Laboratorios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Laboratorios";
            FormClosing += Laboratorios_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dtLabs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtID;
        private TextBox txtNombre;
        private TextBox txtUbicación;
        private TextBox txtCapacidad;
        private TextBox txtResponsable;
        private Button btnNuevo;
        private Button btnActualizar;
        private DataGridView dtLabs;
        private Button btnCerrar;
        private Button btnAbrir;
        private Button btnInfo;
        private Label lblUsuario;
        private Button btnCerrarSes;
        private Button btnReporte;
    }
}