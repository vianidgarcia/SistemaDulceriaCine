namespace SimulacionCine
{
    partial class MenuPrincipal
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
            Button btnCine;
            lblMenu = new Label();
            btnSalir = new Button();
            btnCine = new Button();
            SuspendLayout();
            // 
            // btnCine
            // 
            btnCine.BackColor = Color.FromArgb(192, 0, 0);
            btnCine.FlatStyle = FlatStyle.Flat;
            btnCine.Font = new Font("Ebrima", 9F);
            btnCine.ForeColor = Color.White;
            btnCine.Location = new Point(121, 115);
            btnCine.Name = "btnCine";
            btnCine.Size = new Size(150, 23);
            btnCine.TabIndex = 1;
            btnCine.Text = "Probar";
            btnCine.UseVisualStyleBackColor = false;
            btnCine.Click += btnCine_Click;
            // 
            // lblMenu
            // 
            lblMenu.AutoSize = true;
            lblMenu.Font = new Font("Haettenschweiler", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMenu.ForeColor = Color.FromArgb(246, 36, 64);
            lblMenu.Location = new Point(49, 46);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new Size(301, 50);
            lblMenu.TabIndex = 0;
            lblMenu.Text = "Gestion de Dulceria";
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(255, 229, 191);
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Ebrima", 9F);
            btnSalir.ForeColor = Color.FromArgb(84, 26, 26);
            btnSalir.Location = new Point(121, 144);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(150, 23);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 250, 243);
            ClientSize = new Size(395, 205);
            Controls.Add(btnSalir);
            Controls.Add(btnCine);
            Controls.Add(lblMenu);
            Name = "MenuPrincipal";
            ShowIcon = false;
            Text = "Menú Principal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMenu;
        private Button btnCine;
        private Button btnSalir;
    }
}
