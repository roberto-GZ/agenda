using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace agenda_productos
{
    public partial class Form1 : Form
    {
    
        #region "variables y objetos globales"
        
        Productos productos=new Productos();
        
        #endregion
        
        public Form1()
        {
            InitializeComponent();

            panel_Ingresar.Visible = false;
            panel_mostrar.Visible=false;
            PANEL_INICIO.Visible = true;


            tiempo.Interval=1000;
            tiempo.Enabled=true;
            tiempo.Start();
                
        }

        private void tiempo_Tick(object sender, EventArgs e)
        {
            string tmp = DateTime.Now.ToString();
            char[] separador = { ' ' };
            string[] arreglo = tmp.Split(separador);
            lblHora.Text = arreglo[1];

            string diaSemana = DateTime.Now.DayOfWeek.ToString();
            string diaNumero = DateTime.Now.Day.ToString();
            string mesNumero = DateTime.Now.Month.ToString();

            string diaSemanaEs = "";
            string mesNombre = "";

            switch (diaSemana)
            {
                case "Monday": diaSemanaEs = "LUNES"; break;
                case "Tuesday": diaSemanaEs = "MARTES"; break;
                case "Wednesday": diaSemanaEs = "MIERCOLES"; break;
                case "Thursday": diaSemanaEs = "JUEVES"; break;
                case "Friday": diaSemanaEs = "VIERNES"; break;
                case "Saturday": diaSemanaEs = "SABADO"; break;
                case "Sunday": diaSemanaEs = "DOMINGO"; break;
                default: diaSemanaEs = diaSemana; break;
            };

            switch (mesNumero)
            {
                case "1": mesNombre = "ENERO"; break;
                case "2": mesNombre = "FEBRERO"; break;
                case "3": mesNombre = "MARZO"; break;
                case "4": mesNombre = "ABRIL"; break;
                case "5": mesNombre = "MAYO"; break;
                case "6": mesNombre = "JUNIO"; break;
                case "7": mesNombre = "JULIO"; break;
                case "8": mesNombre = "AGOSTO"; break;
                case "9": mesNombre = "SEPTIEMBRE"; break;
                case "10": mesNombre = "OCTUBRE"; break;
                case "11": mesNombre = "NOVIEMBRE"; break;
                case "12": mesNombre = "DICIEMBRE"; break;
                default: mesNombre = mesNumero; break;
            };

            lblFecha.Text = diaSemanaEs + ", " + diaNumero + " de " + mesNombre;
        }

      
        private void cmd_Agregar_Click(object sender, EventArgs e)
        {
            panel_Ingresar.Visible = true;

        }

        private void cmd_Mostrar_Click(object sender, EventArgs e)
        {
            panel_mostrar.Visible = true;

            gridMostrar.DataSource = productos.mostrarProducto();
            
        }

        private void picturExit_Click(object sender, EventArgs e)
        {
            panel_Ingresar.Visible = false;
            limpiar();
            PANEL_INICIO.Visible = true;
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            productos.nuevoProducto(txtNombre.Text, txtTipo.Text, txtPrecio.Text, txtCant.Text);
            limpiar();
           
            MessageBox.Show("Nuevo producto fue ingresado correctamente", "información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void limpiar()
        {
            txtCant.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtTipo.Text = "";
        }

        private void pictureExit2_Click(object sender, EventArgs e)
        {
            panel_mostrar.Visible = false;
            PANEL_INICIO.Visible = true;
        }

        private void picturEliminar_Click(object sender, EventArgs e)
        {
            Point punto = gridMostrar.CurrentCellAddress;
            int n_fila = punto.Y;
            int n_colum = punto.X;
            
            DialogResult result= MessageBox.Show(("¿ Deseas eliminar el producto: "
            + productos.mostrarProducto().Rows[n_fila]["nombre"]) + "?", "eliminar", 
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                productos.eliminarProducto(n_fila);
            }
        }

        private void picturModif_Click(object sender, EventArgs e)
        {
            Point punto = gridMostrar.CurrentCellAddress;
            int n_fila = punto.Y;
            int n_column = punto.X;

            Modificar mod = new Modificar(productos, n_fila);
            mod.Show();
            //Inicio ini=new Inicio();
            //ini.Show();
                        
        }

        private void cmd_Agregar_Click_1(object sender, EventArgs e)
        {
            panel_Ingresar.Visible = true;
            PANEL_INICIO.Visible = false;
                  
        }

        private void cmd_Mostrar_Click_1(object sender, EventArgs e)
        {
            panel_mostrar.Visible = true;
            PANEL_INICIO.Visible = false;
            //pict_modificar.Visible = false;
            //pict_eliminar.Visible = false;

            gridMostrar.DataSource = productos.mostrarProducto();
        }

  

    

    }
}





 
         