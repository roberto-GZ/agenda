namespace agenda_productos
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
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.picturExit = new System.Windows.Forms.PictureBox();
            this.panel_Ingresar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.txtCant = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAgregProd = new System.Windows.Forms.Label();
            this.panel_mostrar = new System.Windows.Forms.Panel();
            this.pictureExit2 = new System.Windows.Forms.PictureBox();
            this.picturEliminar = new System.Windows.Forms.PictureBox();
            this.picturModif = new System.Windows.Forms.PictureBox();
            this.gridMostrar = new System.Windows.Forms.DataGridView();
            this.tiempo = new System.Windows.Forms.Timer(this.components);
            this.PANEL_INICIO = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cmd_Mostrar = new System.Windows.Forms.Button();
            this.cmd_Agregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picturExit)).BeginInit();
            this.panel_Ingresar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_mostrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureExit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturModif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMostrar)).BeginInit();
            this.PANEL_INICIO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(413, 0);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(56, 16);
            this.lblHora.TabIndex = 11;
            this.lblHora.Text = "00:00:00";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(66, 16);
            this.lblFecha.TabIndex = 12;
            this.lblFecha.Text = "día, fecha";
            // 
            // picturExit
            // 
            this.picturExit.Image = ((System.Drawing.Image)(resources.GetObject("picturExit.Image")));
            this.picturExit.Location = new System.Drawing.Point(383, 188);
            this.picturExit.Name = "picturExit";
            this.picturExit.Size = new System.Drawing.Size(48, 58);
            this.picturExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturExit.TabIndex = 13;
            this.picturExit.TabStop = false;
            this.picturExit.Click += new System.EventHandler(this.picturExit_Click);
            // 
            // panel_Ingresar
            // 
            this.panel_Ingresar.Controls.Add(this.pictureBox1);
            this.panel_Ingresar.Controls.Add(this.picturExit);
            this.panel_Ingresar.Controls.Add(this.cmdGuardar);
            this.panel_Ingresar.Controls.Add(this.txtCant);
            this.panel_Ingresar.Controls.Add(this.label4);
            this.panel_Ingresar.Controls.Add(this.txtPrecio);
            this.panel_Ingresar.Controls.Add(this.txtTipo);
            this.panel_Ingresar.Controls.Add(this.txtNombre);
            this.panel_Ingresar.Controls.Add(this.label3);
            this.panel_Ingresar.Controls.Add(this.label2);
            this.panel_Ingresar.Controls.Add(this.label1);
            this.panel_Ingresar.Controls.Add(this.lblAgregProd);
            this.panel_Ingresar.Location = new System.Drawing.Point(15, 29);
            this.panel_Ingresar.Name = "panel_Ingresar";
            this.panel_Ingresar.Size = new System.Drawing.Size(454, 249);
            this.panel_Ingresar.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(229, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 87);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdGuardar.BackgroundImage")));
            this.cmdGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdGuardar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardar.Location = new System.Drawing.Point(74, 177);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(90, 32);
            this.cmdGuardar.TabIndex = 20;
            this.cmdGuardar.Text = "Guardar ";
            this.cmdGuardar.UseVisualStyleBackColor = true;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // txtCant
            // 
            this.txtCant.Location = new System.Drawing.Point(102, 133);
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(100, 20);
            this.txtCant.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Cantidad :";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(102, 102);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 17;
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(102, 71);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(100, 20);
            this.txtTipo.TabIndex = 16;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(102, 44);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "P.U. en s/. :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tipo :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nombre :";
            // 
            // lblAgregProd
            // 
            this.lblAgregProd.AutoSize = true;
            this.lblAgregProd.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregProd.Location = new System.Drawing.Point(24, 9);
            this.lblAgregProd.Name = "lblAgregProd";
            this.lblAgregProd.Size = new System.Drawing.Size(129, 19);
            this.lblAgregProd.TabIndex = 11;
            this.lblAgregProd.Text = "Ingresar Producto";
            // 
            // panel_mostrar
            // 
            this.panel_mostrar.Controls.Add(this.pictureExit2);
            this.panel_mostrar.Controls.Add(this.picturEliminar);
            this.panel_mostrar.Controls.Add(this.picturModif);
            this.panel_mostrar.Controls.Add(this.gridMostrar);
            this.panel_mostrar.Location = new System.Drawing.Point(15, 44);
            this.panel_mostrar.Name = "panel_mostrar";
            this.panel_mostrar.Size = new System.Drawing.Size(454, 224);
            this.panel_mostrar.TabIndex = 15;
            // 
            // pictureExit2
            // 
            this.pictureExit2.Image = ((System.Drawing.Image)(resources.GetObject("pictureExit2.Image")));
            this.pictureExit2.Location = new System.Drawing.Point(383, 166);
            this.pictureExit2.Name = "pictureExit2";
            this.pictureExit2.Size = new System.Drawing.Size(48, 55);
            this.pictureExit2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureExit2.TabIndex = 14;
            this.pictureExit2.TabStop = false;
            this.pictureExit2.Click += new System.EventHandler(this.pictureExit2_Click);
            // 
            // picturEliminar
            // 
            this.picturEliminar.Image = global::agenda_productos.Properties.Resources.Error_2;
            this.picturEliminar.Location = new System.Drawing.Point(102, 166);
            this.picturEliminar.Name = "picturEliminar";
            this.picturEliminar.Size = new System.Drawing.Size(68, 58);
            this.picturEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturEliminar.TabIndex = 2;
            this.picturEliminar.TabStop = false;
            this.picturEliminar.Click += new System.EventHandler(this.picturEliminar_Click);
            // 
            // picturModif
            // 
            this.picturModif.Image = global::agenda_productos.Properties.Resources.Note_Book;
            this.picturModif.Location = new System.Drawing.Point(28, 166);
            this.picturModif.Name = "picturModif";
            this.picturModif.Size = new System.Drawing.Size(68, 58);
            this.picturModif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturModif.TabIndex = 1;
            this.picturModif.TabStop = false;
            this.picturModif.Click += new System.EventHandler(this.picturModif_Click);
            // 
            // gridMostrar
            // 
            this.gridMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMostrar.Location = new System.Drawing.Point(28, 19);
            this.gridMostrar.Name = "gridMostrar";
            this.gridMostrar.Size = new System.Drawing.Size(403, 141);
            this.gridMostrar.TabIndex = 0;
            // 
            // tiempo
            // 
            this.tiempo.Tick += new System.EventHandler(this.tiempo_Tick);
            // 
            // PANEL_INICIO
            // 
            this.PANEL_INICIO.Controls.Add(this.pictureBox3);
            this.PANEL_INICIO.Controls.Add(this.pictureBox2);
            this.PANEL_INICIO.Controls.Add(this.cmd_Mostrar);
            this.PANEL_INICIO.Controls.Add(this.cmd_Agregar);
            this.PANEL_INICIO.Location = new System.Drawing.Point(52, 59);
            this.PANEL_INICIO.Name = "PANEL_INICIO";
            this.PANEL_INICIO.Size = new System.Drawing.Size(370, 209);
            this.PANEL_INICIO.TabIndex = 27;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::agenda_productos.Properties.Resources.Search_1;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(223, 32);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(118, 121);
            this.pictureBox3.TabIndex = 30;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::agenda_productos.Properties.Resources.apple_dvd;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(15, 32);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(118, 121);
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // cmd_Mostrar
            // 
            this.cmd_Mostrar.Location = new System.Drawing.Point(223, 165);
            this.cmd_Mostrar.Name = "cmd_Mostrar";
            this.cmd_Mostrar.Size = new System.Drawing.Size(118, 35);
            this.cmd_Mostrar.TabIndex = 28;
            this.cmd_Mostrar.Text = "Mostrar";
            this.cmd_Mostrar.UseVisualStyleBackColor = true;
            this.cmd_Mostrar.Click += new System.EventHandler(this.cmd_Mostrar_Click_1);
            // 
            // cmd_Agregar
            // 
            this.cmd_Agregar.Location = new System.Drawing.Point(15, 165);
            this.cmd_Agregar.Name = "cmd_Agregar";
            this.cmd_Agregar.Size = new System.Drawing.Size(118, 35);
            this.cmd_Agregar.TabIndex = 27;
            this.cmd_Agregar.Text = "Agregar Nuevo Producto";
            this.cmd_Agregar.UseVisualStyleBackColor = true;
            this.cmd_Agregar.Click += new System.EventHandler(this.cmd_Agregar_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::agenda_productos.Properties.Resources.VisualPaneles;
            this.ClientSize = new System.Drawing.Size(479, 290);
            this.Controls.Add(this.PANEL_INICIO);
            this.Controls.Add(this.panel_mostrar);
            this.Controls.Add(this.panel_Ingresar);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblHora);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picturExit)).EndInit();
            this.panel_Ingresar.ResumeLayout(false);
            this.panel_Ingresar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_mostrar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureExit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturModif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMostrar)).EndInit();
            this.PANEL_INICIO.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.PictureBox picturExit;
        private System.Windows.Forms.Panel panel_Ingresar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.TextBox txtCant;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAgregProd;
        private System.Windows.Forms.Panel panel_mostrar;
        private System.Windows.Forms.DataGridView gridMostrar;
        private System.Windows.Forms.PictureBox picturEliminar;
        private System.Windows.Forms.PictureBox picturModif;
        private System.Windows.Forms.PictureBox pictureExit2;
        private System.Windows.Forms.Timer tiempo;
        private System.Windows.Forms.Panel PANEL_INICIO;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button cmd_Mostrar;
        private System.Windows.Forms.Button cmd_Agregar;
    }
}

