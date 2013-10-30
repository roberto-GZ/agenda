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
    public partial class Modificar : Form
    {
        Productos producto_tmp;
        int index;
                
        public Modificar(Productos pproduc, int index)
        {
            InitializeComponent();
            producto_tmp = pproduc;
            this.index = index;


            txtNombre.Text = producto_tmp.mostrarProducto().Rows[index]["nombre"].ToString();
            txtTipo.Text = producto_tmp.mostrarProducto().Rows[index]["tipo"].ToString();
            txtPrecio.Text = producto_tmp.mostrarProducto().Rows[index]["precUnit"].ToString();
            txtCant.Text = producto_tmp.mostrarProducto().Rows[index]["cantidad"].ToString();
        }


        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            producto_tmp.mostrarProducto().Rows[index]["nombre"] = txtNombre.Text;
            producto_tmp.mostrarProducto().Rows[index]["tipo"] = txtTipo.Text;
            producto_tmp.mostrarProducto().Rows[index]["precUnit"] = txtPrecio.Text;
            producto_tmp.mostrarProducto().Rows[index]["cantidad"] = txtCant.Text;

            DialogResult result = MessageBox.Show("Los datos han sido modificados", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (result == DialogResult.OK)
            {
                producto_tmp.guardarEnFichero();
                this.Close();
            }
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
