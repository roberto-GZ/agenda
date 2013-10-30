using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.IO;

namespace agenda_productos
{
    public class Productos
    {
        DataTable tablaProd = new DataTable();

        public Productos()
        {
            tablaProd.Columns.Add(new DataColumn("nombre"));
            tablaProd.Columns.Add(new DataColumn("tipo"));
            tablaProd.Columns.Add(new DataColumn("precUnit"));
            tablaProd.Columns.Add(new DataColumn("cantidad"));

            if (File.Exists(@"datosAgenda.dat"))
            {
                cargarArchivo();
            }
        }

        public void nuevoProducto(string nomb, string tip, string precio, string cant)
        {
            registrarProducto(nomb, tip, precio, cant);
            guardarArchivo();
        }

        public void eliminarProducto(int index)
        {
            tablaProd.Rows[index].Delete();
            guardarArchivo();
        }

        public DataTable mostrarProducto()
        {
            return tablaProd;
        }

        private void registrarProducto(string nomb, string tip, string precio, string cant)
        {
            DataRow fila = tablaProd.NewRow();
            fila["nombre"] = nomb;
            fila["tipo"] = tip;
            fila["precUnit"] =precio;
            fila["cantidad"] = cant;

            tablaProd.Rows.Add(fila);
        }

        public void guardarEnFichero()
        {
            guardarArchivo();
        }

        private void guardarArchivo()
        {
            StreamWriter escribir = new StreamWriter(@"datosAgenda.dat", false);
            for (int x=0; x < tablaProd.Rows.Count;x++)
            {
                string tmp = tablaProd.Rows[x]["nombre"].ToString();
                tmp += "|" + tablaProd.Rows[x]["tipo"].ToString();
                tmp += "|" + tablaProd.Rows[x]["precUnit"].ToString();
                tmp += "|" + tablaProd.Rows[x]["cantidad"].ToString();
                escribir.WriteLine(tmp);
            }
            escribir.Close();
 
        }

        private void cargarArchivo()
        {
            StreamReader leer = new StreamReader(@"datosAgenda.dat");
            while (!leer.EndOfStream)
            {
                string texto = leer.ReadLine();
                char[] separador = { '|' };
                string[] arregloDatos = texto.Split(separador);
                registrarProducto(arregloDatos[0], arregloDatos[1], arregloDatos[2], arregloDatos[3]);
            }
            leer.Close();
        }
    }
}
