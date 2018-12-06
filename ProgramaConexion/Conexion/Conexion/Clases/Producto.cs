﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conexion.Clases
{
    public class Producto
    {
        public string id_producto { get; set; }
        public string nombre_producto { get; set; }
        public int cantidad { get; set; }
        public float precio_compra { get; set; }
        public float precio_venta { get; set; }
        public string departamento { get; set; }

        public Producto(string id_producto)
        {
            this.id_producto = id_producto;
        }


        //regresa un bool para asegurarse de que se este ejecutando de manera correcta el metodo
        public bool agregarProducto()
        {
            string query = "INSERT INTO producto(id_producto, Nombre, Unidad, Cantidad, Precio_compra, Precio_venta, Departamento) values('"
                +this.id_producto +"', '" + this.nombre_producto + "', '" +this.cantidad.ToString() + "', '"
                +this.cantidad.ToString() + "', '" +this.precio_compra.ToString() + "', '" +this.precio_venta.ToString()
                + "', '" +this.departamento.ToString()+ "')";
            return Conection.sharedInstance.ejecutarQuery(query);
        }


        //regresa un bool para asegurarse de que se este ejecutando de manera correcta el metodo
        public bool eliminarProducto()
        {
            string query = " DELETE FROM producto WHERE id_producto = '"+this.id_producto;         
                 return Conection.sharedInstance.ejecutarQuery(query);
        }


        //regresa un bool para asegurarse de que se este ejecutando de manera correcta el metodo 
        public bool modificarProducto()
        {
            string query = "update producto set descripcion_producto ='"+this.nombre_producto+",cantidad ="+this.cantidad.ToString()+",precio_compra ="+this.precio_compra.ToString()+",precio_venta="+this.precio_venta.ToString()+"',departamento ='"+this.departamento + "'  where id_producto ='" + this.id_producto;
            return Conection.sharedInstance.ejecutarQuery(query);
        }



    }
}
