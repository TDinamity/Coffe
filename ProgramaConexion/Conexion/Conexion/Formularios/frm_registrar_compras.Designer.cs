namespace Conexion.Formularios
{
    partial class frm_registrar_compras
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_registrar_compras));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tb_cantidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_producto = new System.Windows.Forms.TextBox();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.tb_codigo = new System.Windows.Forms.TextBox();
            this.bt_registrar = new System.Windows.Forms.Button();
            this.bt_consultar = new System.Windows.Forms.Button();
            this.lbl_producto = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanel1.BackgroundImage")));
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.tb_cantidad, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tb_producto, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_codigo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tb_codigo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.bt_registrar, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.bt_consultar, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl_producto, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.75F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(620, 297);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // tb_cantidad
            // 
            this.tb_cantidad.Location = new System.Drawing.Point(146, 76);
            this.tb_cantidad.Name = "tb_cantidad";
            this.tb_cantidad.Size = new System.Drawing.Size(130, 20);
            this.tb_cantidad.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cantidad";
            // 
            // tb_producto
            // 
            this.tb_producto.Location = new System.Drawing.Point(432, 3);
            this.tb_producto.Name = "tb_producto";
            this.tb_producto.Size = new System.Drawing.Size(130, 20);
            this.tb_producto.TabIndex = 3;
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo.Location = new System.Drawing.Point(3, 0);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(65, 20);
            this.lbl_codigo.TabIndex = 0;
            this.lbl_codigo.Text = "Código";
            this.lbl_codigo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tb_codigo
            // 
            this.tb_codigo.ForeColor = System.Drawing.Color.Transparent;
            this.tb_codigo.Location = new System.Drawing.Point(146, 3);
            this.tb_codigo.Name = "tb_codigo";
            this.tb_codigo.Size = new System.Drawing.Size(130, 20);
            this.tb_codigo.TabIndex = 2;
            // 
            // bt_registrar
            // 
            this.bt_registrar.BackColor = System.Drawing.Color.SandyBrown;
            this.bt_registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_registrar.Location = new System.Drawing.Point(289, 222);
            this.bt_registrar.Name = "bt_registrar";
            this.bt_registrar.Size = new System.Drawing.Size(137, 58);
            this.bt_registrar.TabIndex = 7;
            this.bt_registrar.Text = "Registrar";
            this.bt_registrar.UseVisualStyleBackColor = false;
            // 
            // bt_consultar
            // 
            this.bt_consultar.BackColor = System.Drawing.Color.SandyBrown;
            this.bt_consultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_consultar.Location = new System.Drawing.Point(146, 222);
            this.bt_consultar.Name = "bt_consultar";
            this.bt_consultar.Size = new System.Drawing.Size(137, 58);
            this.bt_consultar.TabIndex = 6;
            this.bt_consultar.Text = "Consular";
            this.bt_consultar.UseVisualStyleBackColor = false;
            this.bt_consultar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_producto
            // 
            this.lbl_producto.AutoSize = true;
            this.lbl_producto.BackColor = System.Drawing.Color.Transparent;
            this.lbl_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_producto.Location = new System.Drawing.Point(289, 0);
            this.lbl_producto.Name = "lbl_producto";
            this.lbl_producto.Size = new System.Drawing.Size(81, 20);
            this.lbl_producto.TabIndex = 1;
            this.lbl_producto.Text = "Producto";
            this.lbl_producto.Click += new System.EventHandler(this.label2_Click);
            // 
            // frm_registrar_compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(620, 297);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frm_registrar_compras";
            this.Text = "frm_registrar_compras";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.Label lbl_producto;
        private System.Windows.Forms.TextBox tb_producto;
        private System.Windows.Forms.TextBox tb_codigo;
        private System.Windows.Forms.TextBox tb_cantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_consultar;
        private System.Windows.Forms.Button bt_registrar;
    }
}