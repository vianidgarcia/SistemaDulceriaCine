namespace SistemaDulceriaCine
{
    partial class FrmDulceria
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
            txtNombre = new TextBox();
            numPrecio = new NumericUpDown();
            numExistencia = new NumericUpDown();
            btnRegistrar = new Button();
            dgvInventario = new DataGridView();
            lblNombre = new Label();
            lblPrecio = new Label();
            lblExistencia = new Label();
            lblProductos = new Label();
            btnEliminar = new Button();
            pnlDatos = new Panel();
            lblDatos = new Label();
            panel1 = new Panel();
            lblExistencias = new Label();
            numCantidad = new NumericUpDown();
            btnAgregarExistencia = new Button();
            btnDisminuirExistencias = new Button();
            ((System.ComponentModel.ISupportInitialize)numPrecio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numExistencia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).BeginInit();
            pnlDatos.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCantidad).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(14, 50);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(120, 23);
            txtNombre.TabIndex = 0;
            // 
            // numPrecio
            // 
            numPrecio.Location = new Point(14, 97);
            numPrecio.Name = "numPrecio";
            numPrecio.Size = new Size(120, 23);
            numPrecio.TabIndex = 1;
            // 
            // numExistencia
            // 
            numExistencia.Location = new Point(14, 146);
            numExistencia.Name = "numExistencia";
            numExistencia.Size = new Size(120, 23);
            numExistencia.TabIndex = 2;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.FromArgb(246, 36, 64);
            btnRegistrar.FlatAppearance.BorderSize = 0;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Ebrima", 9F);
            btnRegistrar.ForeColor = SystemColors.ButtonHighlight;
            btnRegistrar.Location = new Point(315, 510);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(162, 23);
            btnRegistrar.TabIndex = 3;
            btnRegistrar.Text = "Registrar Producto";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // dgvInventario
            // 
            dgvInventario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInventario.BackgroundColor = Color.FromArgb(255, 242, 219);
            dgvInventario.BorderStyle = BorderStyle.None;
            dgvInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventario.Location = new Point(9, 34);
            dgvInventario.Name = "dgvInventario";
            dgvInventario.ReadOnly = true;
            dgvInventario.RowHeadersVisible = false;
            dgvInventario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInventario.Size = new Size(476, 300);
            dgvInventario.TabIndex = 4;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(14, 32);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(50, 15);
            lblNombre.TabIndex = 5;
            lblNombre.Text = "Nombre";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrecio.Location = new Point(14, 79);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(40, 15);
            lblPrecio.TabIndex = 6;
            lblPrecio.Text = "Precio";
            // 
            // lblExistencia
            // 
            lblExistencia.AutoSize = true;
            lblExistencia.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblExistencia.Location = new Point(12, 128);
            lblExistencia.Name = "lblExistencia";
            lblExistencia.Size = new Size(58, 15);
            lblExistencia.TabIndex = 7;
            lblExistencia.Text = "Existencia";
            // 
            // lblProductos
            // 
            lblProductos.AutoSize = true;
            lblProductos.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProductos.Location = new Point(12, 9);
            lblProductos.Name = "lblProductos";
            lblProductos.Size = new Size(122, 15);
            lblProductos.TabIndex = 8;
            lblProductos.Text = "Productos registrados";
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(246, 36, 64);
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Ebrima", 9F);
            btnEliminar.ForeColor = SystemColors.ButtonHighlight;
            btnEliminar.Location = new Point(315, 478);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(162, 23);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar Producto";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // pnlDatos
            // 
            pnlDatos.BackColor = Color.FromArgb(255, 229, 191);
            pnlDatos.Controls.Add(lblDatos);
            pnlDatos.Controls.Add(lblNombre);
            pnlDatos.Controls.Add(lblPrecio);
            pnlDatos.Controls.Add(lblExistencia);
            pnlDatos.Controls.Add(numExistencia);
            pnlDatos.Controls.Add(txtNombre);
            pnlDatos.Controls.Add(numPrecio);
            pnlDatos.Location = new Point(17, 350);
            pnlDatos.Name = "pnlDatos";
            pnlDatos.Size = new Size(286, 183);
            pnlDatos.TabIndex = 10;
            // 
            // lblDatos
            // 
            lblDatos.AutoSize = true;
            lblDatos.Font = new Font("Ebrima", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDatos.ForeColor = Color.FromArgb(216, 36, 104);
            lblDatos.Location = new Point(14, 13);
            lblDatos.Name = "lblDatos";
            lblDatos.Size = new Size(113, 15);
            lblDatos.TabIndex = 11;
            lblDatos.Text = "Datos del producto";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 229, 191);
            panel1.Controls.Add(btnAgregarExistencia);
            panel1.Controls.Add(btnDisminuirExistencias);
            panel1.Controls.Add(lblExistencias);
            panel1.Controls.Add(numCantidad);
            panel1.Location = new Point(315, 350);
            panel1.Name = "panel1";
            panel1.Size = new Size(162, 117);
            panel1.TabIndex = 12;
            // 
            // lblExistencias
            // 
            lblExistencias.AutoSize = true;
            lblExistencias.Font = new Font("Ebrima", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExistencias.ForeColor = Color.FromArgb(216, 36, 104);
            lblExistencias.Location = new Point(12, 8);
            lblExistencias.Name = "lblExistencias";
            lblExistencias.Size = new Size(141, 15);
            lblExistencias.TabIndex = 11;
            lblExistencias.Text = "Existencias del producto";
            // 
            // numericUpDown2
            // 
            numCantidad.Location = new Point(12, 28);
            numCantidad.Name = "numericUpDown2";
            numCantidad.Size = new Size(120, 23);
            numCantidad.TabIndex = 1;
            // 
            // btnAgregarExistencia
            // 
            btnAgregarExistencia.BackColor = Color.FromArgb(246, 36, 64);
            btnAgregarExistencia.FlatAppearance.BorderSize = 0;
            btnAgregarExistencia.FlatStyle = FlatStyle.Flat;
            btnAgregarExistencia.Font = new Font("Ebrima", 9F);
            btnAgregarExistencia.ForeColor = SystemColors.ButtonHighlight;
            btnAgregarExistencia.Location = new Point(12, 57);
            btnAgregarExistencia.Name = "btnAgregarExistencia";
            btnAgregarExistencia.Size = new Size(136, 23);
            btnAgregarExistencia.TabIndex = 14;
            btnAgregarExistencia.Text = "+ Existencias";
            btnAgregarExistencia.UseVisualStyleBackColor = false;
            btnAgregarExistencia.Click += btnAgregarExistencia_Click;
            // 
            // btnDisminuirExistencias
            // 
            btnDisminuirExistencias.BackColor = Color.FromArgb(246, 36, 64);
            btnDisminuirExistencias.FlatAppearance.BorderSize = 0;
            btnDisminuirExistencias.FlatStyle = FlatStyle.Flat;
            btnDisminuirExistencias.Font = new Font("Ebrima", 9F);
            btnDisminuirExistencias.ForeColor = SystemColors.ButtonHighlight;
            btnDisminuirExistencias.Location = new Point(13, 86);
            btnDisminuirExistencias.Name = "btnDisminuirExistencias";
            btnDisminuirExistencias.Size = new Size(136, 23);
            btnDisminuirExistencias.TabIndex = 13;
            btnDisminuirExistencias.Text = "- Existencias";
            btnDisminuirExistencias.UseVisualStyleBackColor = false;
            btnDisminuirExistencias.Click += btnDisminuirExistencias_Click;
            // 
            // FrmDulceria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 250, 243);
            ClientSize = new Size(495, 550);
            Controls.Add(panel1);
            Controls.Add(btnEliminar);
            Controls.Add(lblProductos);
            Controls.Add(btnRegistrar);
            Controls.Add(dgvInventario);
            Controls.Add(pnlDatos);
            Name = "FrmDulceria";
            Text = "Sistema de Dulceria";
            Load += FrmDulceria_Load;
            ((System.ComponentModel.ISupportInitialize)numPrecio).EndInit();
            ((System.ComponentModel.ISupportInitialize)numExistencia).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).EndInit();
            pnlDatos.ResumeLayout(false);
            pnlDatos.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private NumericUpDown numPrecio;
        private NumericUpDown numExistencia;
        private Button btnRegistrar;
        private DataGridView dgvInventario;
        private Label lblNombre;
        private Label lblPrecio;
        private Label lblExistencia;
        private Label lblProductos;
        private Button btnEliminar;
        private Panel pnlDatos;
        private Label lblDatos;
        private Panel panel1;
        private Button btnAgregarExistencia;
        private Button btnDisminuirExistencias;
        private Label lblExistencias;
        private NumericUpDown numCantidad;
    }
}
