namespace Conexion.Formularios
{
    partial class frm_ventas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ventas));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Id_producto = new System.Windows.Forms.Label();
            this.tb_id_producto = new System.Windows.Forms.TextBox();
            this.tb_nombre = new System.Windows.Forms.TextBox();
            this.Cantidad = new System.Windows.Forms.Label();
            this.Precio = new System.Windows.Forms.Label();
            this.tb_precio = new System.Windows.Forms.TextBox();
            this.btn_realizar_venta = new System.Windows.Forms.Button();
            this.btn_visualizar_ventas = new System.Windows.Forms.Button();
            this.Nombre = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanel1.BackgroundImage")));
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.99035F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.84888F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.Id_producto, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tb_id_producto, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tb_nombre, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.Cantidad, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Precio, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.tb_precio, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_realizar_venta, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_visualizar_ventas, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.Nombre, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboBox1, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.35211F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.22535F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.79603F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.91218F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(622, 353);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // Id_producto
            // 
            this.Id_producto.AutoSize = true;
            this.Id_producto.BackColor = System.Drawing.Color.Transparent;
            this.Id_producto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Id_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id_producto.ForeColor = System.Drawing.Color.Black;
            this.Id_producto.Location = new System.Drawing.Point(3, 0);
            this.Id_producto.Name = "Id_producto";
            this.Id_producto.Size = new System.Drawing.Size(149, 89);
            this.Id_producto.TabIndex = 0;
            this.Id_producto.Text = "id_Producto:";
            this.Id_producto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tb_id_producto
            // 
            this.tb_id_producto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_id_producto.Location = new System.Drawing.Point(158, 3);
            this.tb_id_producto.Name = "tb_id_producto";
            this.tb_id_producto.Size = new System.Drawing.Size(137, 20);
            this.tb_id_producto.TabIndex = 4;
            // 
            // tb_nombre
            // 
            this.tb_nombre.Location = new System.Drawing.Point(468, 3);
            this.tb_nombre.Name = "tb_nombre";
            this.tb_nombre.Size = new System.Drawing.Size(130, 20);
            this.tb_nombre.TabIndex = 5;
            this.tb_nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSize = true;
            this.Cantidad.BackColor = System.Drawing.Color.Transparent;
            this.Cantidad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cantidad.Location = new System.Drawing.Point(3, 89);
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Size = new System.Drawing.Size(149, 85);
            this.Cantidad.TabIndex = 2;
            this.Cantidad.Text = "Cantidad:";
            this.Cantidad.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Precio
            // 
            this.Precio.AutoSize = true;
            this.Precio.BackColor = System.Drawing.Color.Transparent;
            this.Precio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Precio.Location = new System.Drawing.Point(301, 89);
            this.Precio.Name = "Precio";
            this.Precio.Size = new System.Drawing.Size(161, 85);
            this.Precio.TabIndex = 3;
            this.Precio.Text = "Precio:";
            this.Precio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tb_precio
            // 
            this.tb_precio.Location = new System.Drawing.Point(468, 92);
            this.tb_precio.Name = "tb_precio";
            this.tb_precio.Size = new System.Drawing.Size(130, 20);
            this.tb_precio.TabIndex = 7;
            // 
            // btn_realizar_venta
            // 
            this.btn_realizar_venta.BackColor = System.Drawing.Color.SandyBrown;
            this.btn_realizar_venta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_realizar_venta.Location = new System.Drawing.Point(158, 177);
            this.btn_realizar_venta.Name = "btn_realizar_venta";
            this.btn_realizar_venta.Size = new System.Drawing.Size(137, 53);
            this.btn_realizar_venta.TabIndex = 8;
            this.btn_realizar_venta.Text = "Realizar_venta";
            this.btn_realizar_venta.UseVisualStyleBackColor = false;
            // 
            // btn_visualizar_ventas
            // 
            this.btn_visualizar_ventas.BackColor = System.Drawing.Color.SandyBrown;
            this.btn_visualizar_ventas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_visualizar_ventas.Location = new System.Drawing.Point(301, 177);
            this.btn_visualizar_ventas.Name = "btn_visualizar_ventas";
            this.btn_visualizar_ventas.Size = new System.Drawing.Size(145, 53);
            this.btn_visualizar_ventas.TabIndex = 9;
            this.btn_visualizar_ventas.Text = "visualizar_ventas";
            this.btn_visualizar_ventas.UseVisualStyleBackColor = false;
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.BackColor = System.Drawing.Color.Transparent;
            this.Nombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.Location = new System.Drawing.Point(301, 0);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(161, 89);
            this.Nombre.TabIndex = 1;
            this.Nombre.Text = "Nombre:";
            this.Nombre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
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
            this.comboBox1.Location = new System.Drawing.Point(158, 92);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(137, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // frm_ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 356);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frm_ventas";
            this.Text = "frm_ventas";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Id_producto;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label Cantidad;
        private System.Windows.Forms.Label Precio;
        private System.Windows.Forms.TextBox tb_id_producto;
        private System.Windows.Forms.TextBox tb_nombre;
        private System.Windows.Forms.TextBox tb_precio;
        private System.Windows.Forms.Button btn_realizar_venta;
        private System.Windows.Forms.Button btn_visualizar_ventas;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}