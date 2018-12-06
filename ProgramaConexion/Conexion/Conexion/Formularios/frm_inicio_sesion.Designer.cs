namespace Conexion.Formularios
{
    partial class frm_inicio_sesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_inicio_sesion));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_nombreUsuario = new System.Windows.Forms.Label();
            this.lbl_contraseña = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_iniciarSesion = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanel1.BackgroundImage")));
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.btn_iniciarSesion, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbl_contraseña, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl_nombreUsuario, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, -2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.65079F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.77778F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(661, 362);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lbl_nombreUsuario
            // 
            this.lbl_nombreUsuario.AutoSize = true;
            this.lbl_nombreUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nombreUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_nombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombreUsuario.ForeColor = System.Drawing.Color.White;
            this.lbl_nombreUsuario.Location = new System.Drawing.Point(223, 55);
            this.lbl_nombreUsuario.Name = "lbl_nombreUsuario";
            this.lbl_nombreUsuario.Size = new System.Drawing.Size(214, 36);
            this.lbl_nombreUsuario.TabIndex = 0;
            this.lbl_nombreUsuario.Text = "Nombre de usuario:";
            this.lbl_nombreUsuario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lbl_contraseña
            // 
            this.lbl_contraseña.AutoSize = true;
            this.lbl_contraseña.BackColor = System.Drawing.Color.Transparent;
            this.lbl_contraseña.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contraseña.ForeColor = System.Drawing.Color.White;
            this.lbl_contraseña.Location = new System.Drawing.Point(223, 126);
            this.lbl_contraseña.Name = "lbl_contraseña";
            this.lbl_contraseña.Size = new System.Drawing.Size(214, 46);
            this.lbl_contraseña.TabIndex = 1;
            this.lbl_contraseña.Text = "Contraseña:";
            this.lbl_contraseña.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(223, 94);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(214, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Location = new System.Drawing.Point(223, 175);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(214, 20);
            this.textBox2.TabIndex = 3;
            // 
            // btn_iniciarSesion
            // 
            this.btn_iniciarSesion.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_iniciarSesion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_iniciarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_iniciarSesion.Location = new System.Drawing.Point(223, 258);
            this.btn_iniciarSesion.Name = "btn_iniciarSesion";
            this.btn_iniciarSesion.Size = new System.Drawing.Size(214, 49);
            this.btn_iniciarSesion.TabIndex = 4;
            this.btn_iniciarSesion.Text = "Iniciar sesión";
            this.btn_iniciarSesion.UseVisualStyleBackColor = false;
            // 
            // frm_inicio_sesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 358);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frm_inicio_sesion";
            this.Text = "frm_inicio_sesion";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_iniciarSesion;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbl_contraseña;
        private System.Windows.Forms.Label lbl_nombreUsuario;
        private System.Windows.Forms.TextBox textBox1;
    }
}