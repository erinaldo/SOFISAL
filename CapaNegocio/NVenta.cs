﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class NVenta
    {
        //Metodo Insertar que llama al metodo insertar de la clase DVenta de la CapaDatos
        public static string Insertar(int idCliente, int idTrabajador, DateTime fecha, string tipo_comprobante, string serie, string correlativo,
            decimal iGV,decimal pago, DataTable dtDetalles)
        {
            DVenta Obj = new DVenta();
            Obj.IdCliente = idCliente;
            Obj.IdTrabajador = idTrabajador;
            Obj.Fecha = fecha;
            Obj.Tipo_comprobante = tipo_comprobante;
            Obj.Serie = serie;
            Obj.Correlativo = correlativo;
            Obj.IGV = iGV;
            Obj.Pago = pago;
            
            List<DDetalle_Venta> detalles = new List<DDetalle_Venta>();
            foreach (DataRow row in dtDetalles.Rows)
            {
                DDetalle_Venta detalle = new DDetalle_Venta();
                detalle.IdDetall_ingreso = Convert.ToInt32(row["IdDetalle_ingreso"].ToString());
                detalle.Cantidad = Convert.ToInt32(row["Cantidad"].ToString());
                detalle.Precio_venta = Convert.ToDecimal(row["Precio_venta"].ToString());
                detalle.Descuento = Convert.ToDecimal(row["Descuento"].ToString());
                detalles.Add(detalle);

            }
            return Obj.Insertar(Obj, detalles);
        }

        //Metodo Eliminar que llama al metodo Anular de la clase DVenta de la CapaDatos
        public static string Eliminar(int idVenta)
        {
            DVenta Obj = new DVenta();
            Obj.IdVenta = idVenta;
            return Obj.Elminar(Obj);
        }

        //Metodo Mostrar que llama al metodo Mostrar de la clase DVenta de la CapaDatos
        public static DataTable Mostrar()
        {
            return new DVenta().Mostrar();
        }

        //Metodo BuscarNombre que llama al metodo BuscarFechas de la clase DVenta de la CapaDatos
        public static DataTable BuscarFechas(string textobuscar, string textobuscar2)
        {
            DVenta Obj = new DVenta();
            return Obj.BuscarFechas(textobuscar, textobuscar2);
        }

        //Metodo MostrarDetalle que llama al metodo BuscarNombre de la clase DVenta de la CapaDatos
        public static DataTable MostrarDetalle(string textobuscar)
        {
            DVenta Obj = new DVenta();
            return Obj.MostrarDetalle(textobuscar);
        }

        //Metodo MostrarDetalle que llama al metodo BuscarNombre de la clase DVenta de la CapaDatos
        public static DataTable MostrarArticulo_Venta_Nombre(string textobuscar)
        {
            DVenta Obj = new DVenta();
            return Obj.MostrarArticulo_Venta_Nombre(textobuscar);
        }

        //Metodo MostrarDetalle que llama al metodo BuscarNombre de la clase DVenta de la CapaDatos
        public static DataTable MostrarArticulo_Venta_Codigo(string textobuscar)
        {
            DVenta Obj = new DVenta();
            return Obj.MostrarArticulo_Venta_codigo(textobuscar);
        }
    }
}
