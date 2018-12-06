using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using System.Configuration;
namespace Conexion.Clases
{
    class ControlCompraVenta
    {
        public Producto producto { get; set; }
        public float cantidad { get; set; }
        public DateTime fecha_venta { get; set; }

        public ControlCompraVenta(string id_producto, int cantidad)
        {
            this.producto = new Producto(id_producto);
            this.fecha_venta = DateTime.Now;
            this.cantidad = cantidad;
        }

        public bool registrarVenta()
        {
            string query = "INSERT INTO ventas(id_producto, precio, fecha_compra, cantidad) Values('"+this.producto.id_producto +"', "+this.producto.precio_venta.ToString()+", '"+this.fecha_venta +"', "+this.cantidad.ToString()+"')";
            if (Conection.sharedInstance.ejecutarQuery(query))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool registrarCompra()
        {
            //basicamente es lo mismo que en registrarVenta solo cambiar lo de la tabla
            string query = "INSERT INTO ventas(id_producto, precio, fecha_compra, cantidad) Values('" + this.producto.id_producto + "', " + this.producto.precio_venta.ToString() + ", '" + this.fecha_venta + "', " + this.cantidad.ToString() + "')";
            if (Conection.sharedInstance.ejecutarQuery(query))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void editarCompra()
        {
            //Ingresar solo un update
        }

        public void editarVenta()
        {
            //Ingresar solo un update
        }

        public DataTable visualizarCompras()
        {
            try
            {
                string query = "SELECT * FROM ventas";
                return Conection.sharedInstance.consultarTabla(query);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public DataTable visualizarVentas()
        {
            try
            {
                string query = "SELECT * FROM compras";
                return Conection.sharedInstance.consultarTabla(query);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
