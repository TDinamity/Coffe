namespace Cafeteria
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.lbl_articulo = new System.Windows.Forms.Label();
            this.lbl_costoUnitario = new System.Windows.Forms.Label();
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.lbl_fechaCompra = new System.Windows.Forms.Label();
            this.lbl_fechaCaducidad = new System.Windows.Forms.Label();
            this.lbl_proveedor = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_fechaCompra = new System.Windows.Forms.DateTimePicker();
            this.dtp_fechaCaducidad = new System.Windows.Forms.DateTimePicker();
            this.cmb_proveedor = new System.Windows.Forms.ComboBox();
            this.cmb_margenGanancia = new System.Windows.Forms.ComboBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Location = new System.Drawing.Point(51, 53);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(40, 13);
            this.lbl_codigo.TabIndex = 0;
            this.lbl_codigo.Text = "Código";
            this.lbl_codigo.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_articulo
            // 
            this.lbl_articulo.AutoSize = true;
            this.lbl_articulo.Location = new System.Drawing.Point(51, 84);
            this.lbl_articulo.Name = "lbl_articulo";
            this.lbl_articulo.Size = new System.Drawing.Size(44, 13);
            this.lbl_articulo.TabIndex = 1;
            this.lbl_articulo.Text = "Artículo";
            // 
            // lbl_costoUnitario
            // 
            this.lbl_costoUnitario.AutoSize = true;
            this.lbl_costoUnitario.Location = new System.Drawing.Point(51, 113);
            this.lbl_costoUnitario.Name = "lbl_costoUnitario";
            this.lbl_costoUnitario.Size = new System.Drawing.Size(71, 13);
            this.lbl_costoUnitario.TabIndex = 2;
            this.lbl_costoUnitario.Text = "Costo unitario";
            // 
            // lbl_cantidad
            // 
            this.lbl_cantidad.AutoSize = true;
            this.lbl_cantidad.Location = new System.Drawing.Point(51, 144);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Size = new System.Drawing.Size(49, 13);
            this.lbl_cantidad.TabIndex = 3;
            this.lbl_cantidad.Text = "Cantidad";
            // 
            // lbl_fechaCompra
            // 
            this.lbl_fechaCompra.AutoSize = true;
            this.lbl_fechaCompra.Location = new System.Drawing.Point(51, 175);
            this.lbl_fechaCompra.Name = "lbl_fechaCompra";
            this.lbl_fechaCompra.Size = new System.Drawing.Size(90, 13);
            this.lbl_fechaCompra.TabIndex = 4;
            this.lbl_fechaCompra.Text = "Fecha de compra";
            // 
            // lbl_fechaCaducidad
            // 
            this.lbl_fechaCaducidad.AutoSize = true;
            this.lbl_fechaCaducidad.Location = new System.Drawing.Point(51, 210);
            this.lbl_fechaCaducidad.Name = "lbl_fechaCaducidad";
            this.lbl_fechaCaducidad.Size = new System.Drawing.Size(105, 13);
            this.lbl_fechaCaducidad.TabIndex = 5;
            this.lbl_fechaCaducidad.Text = "Fecha de caducidad";
            // 
            // lbl_proveedor
            // 
            this.lbl_proveedor.AutoSize = true;
            this.lbl_proveedor.Location = new System.Drawing.Point(51, 239);
            this.lbl_proveedor.Name = "lbl_proveedor";
            this.lbl_proveedor.Size = new System.Drawing.Size(56, 13);
            this.lbl_proveedor.TabIndex = 6;
            this.lbl_proveedor.Text = "Proveedor";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(106, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(353, 20);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(106, 84);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(353, 20);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(128, 113);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(331, 20);
            this.textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(116, 141);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(343, 20);
            this.textBox4.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Margen de ganancia";
            // 
            // dtp_fechaCompra
            // 
            this.dtp_fechaCompra.Location = new System.Drawing.Point(147, 172);
            this.dtp_fechaCompra.Name = "dtp_fechaCompra";
            this.dtp_fechaCompra.Size = new System.Drawing.Size(312, 20);
            this.dtp_fechaCompra.TabIndex = 15;
            // 
            // dtp_fechaCaducidad
            // 
            this.dtp_fechaCaducidad.Location = new System.Drawing.Point(162, 207);
            this.dtp_fechaCaducidad.Name = "dtp_fechaCaducidad";
            this.dtp_fechaCaducidad.Size = new System.Drawing.Size(297, 20);
            this.dtp_fechaCaducidad.TabIndex = 16;
            // 
            // cmb_proveedor
            // 
            this.cmb_proveedor.FormattingEnabled = true;
            this.cmb_proveedor.Items.AddRange(new object[] {
            "Pepsi",
            "Gamesa",
            "Danone",
            "Barcel",
            "Sabritas",
            "Sams"});
            this.cmb_proveedor.Location = new System.Drawing.Point(113, 236);
            this.cmb_proveedor.Name = "cmb_proveedor";
            this.cmb_proveedor.Size = new System.Drawing.Size(346, 21);
            this.cmb_proveedor.TabIndex = 17;
            this.cmb_proveedor.SelectedIndexChanged += new System.EventHandler(this.cmb_proveedor_SelectedIndexChanged);
            // 
            // cmb_margenGanancia
            // 
            this.cmb_margenGanancia.FormattingEnabled = true;
            this.cmb_margenGanancia.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmb_margenGanancia.Location = new System.Drawing.Point(338, 297);
            this.cmb_margenGanancia.Name = "cmb_margenGanancia";
            this.cmb_margenGanancia.Size = new System.Drawing.Size(121, 21);
            this.cmb_margenGanancia.TabIndex = 18;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(67, 391);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(89, 44);
            this.btn_buscar.TabIndex = 19;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(220, 391);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(89, 44);
            this.btn_guardar.TabIndex = 20;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(370, 391);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(89, 44);
            this.btn_eliminar.TabIndex = 21;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 498);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.cmb_margenGanancia);
            this.Controls.Add(this.cmb_proveedor);
            this.Controls.Add(this.dtp_fechaCaducidad);
            this.Controls.Add(this.dtp_fechaCompra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_proveedor);
            this.Controls.Add(this.lbl_fechaCaducidad);
            this.Controls.Add(this.lbl_fechaCompra);
            this.Controls.Add(this.lbl_cantidad);
            this.Controls.Add(this.lbl_costoUnitario);
            this.Controls.Add(this.lbl_articulo);
            this.Controls.Add(this.lbl_codigo);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Entrada de artículos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.Label lbl_articulo;
        private System.Windows.Forms.Label lbl_costoUnitario;
        private System.Windows.Forms.Label lbl_cantidad;
        private System.Windows.Forms.Label lbl_fechaCompra;
        private System.Windows.Forms.Label lbl_fechaCaducidad;
        private System.Windows.Forms.Label lbl_proveedor;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_fechaCompra;
        private System.Windows.Forms.DateTimePicker dtp_fechaCaducidad;
        private System.Windows.Forms.ComboBox cmb_proveedor;
        private System.Windows.Forms.ComboBox cmb_margenGanancia;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_eliminar;
    }
}

