namespace TP2_DIEGO_DISTEFANO
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.btListar = new System.Windows.Forms.Button();
            this.btAgregarArt = new System.Windows.Forms.Button();
            this.btBuscarArticulo = new System.Windows.Forms.Button();
            this.btDetalleArticulo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btSalir = new System.Windows.Forms.Button();
            this.btEliminarArt = new System.Windows.Forms.Button();
            this.btModificarArticulo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btListar
            // 
            this.btListar.BackColor = System.Drawing.Color.Transparent;
            this.btListar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btListar.Location = new System.Drawing.Point(15, 69);
            this.btListar.Name = "btListar";
            this.btListar.Size = new System.Drawing.Size(133, 23);
            this.btListar.TabIndex = 0;
            this.btListar.Text = "Listado Articulos";
            this.btListar.UseVisualStyleBackColor = false;
            this.btListar.Click += new System.EventHandler(this.btListar_Click);
            // 
            // btAgregarArt
            // 
            this.btAgregarArt.Location = new System.Drawing.Point(15, 100);
            this.btAgregarArt.Name = "btAgregarArt";
            this.btAgregarArt.Size = new System.Drawing.Size(133, 23);
            this.btAgregarArt.TabIndex = 1;
            this.btAgregarArt.Text = "Agregar Articulo";
            this.btAgregarArt.UseVisualStyleBackColor = true;
            this.btAgregarArt.Click += new System.EventHandler(this.button1_Click);
            // 
            // btBuscarArticulo
            // 
            this.btBuscarArticulo.Location = new System.Drawing.Point(15, 189);
            this.btBuscarArticulo.Name = "btBuscarArticulo";
            this.btBuscarArticulo.Size = new System.Drawing.Size(133, 23);
            this.btBuscarArticulo.TabIndex = 2;
            this.btBuscarArticulo.Text = "Buscar Articulo";
            this.btBuscarArticulo.UseVisualStyleBackColor = true;
            this.btBuscarArticulo.Click += new System.EventHandler(this.btBuscarArticulo_Click);
            // 
            // btDetalleArticulo
            // 
            this.btDetalleArticulo.Location = new System.Drawing.Point(15, 221);
            this.btDetalleArticulo.Name = "btDetalleArticulo";
            this.btDetalleArticulo.Size = new System.Drawing.Size(133, 23);
            this.btDetalleArticulo.TabIndex = 3;
            this.btDetalleArticulo.Text = "Detalle Articulo";
            this.btDetalleArticulo.UseVisualStyleBackColor = true;
            this.btDetalleArticulo.Click += new System.EventHandler(this.btDetalleArticulo_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(878, 41);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(657, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "TP2_DIEGO_DISTEFANO";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.btSalir);
            this.panel2.Controls.Add(this.btEliminarArt);
            this.panel2.Controls.Add(this.btModificarArticulo);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btBuscarArticulo);
            this.panel2.Controls.Add(this.btListar);
            this.panel2.Controls.Add(this.btDetalleArticulo);
            this.panel2.Controls.Add(this.btAgregarArt);
            this.panel2.Location = new System.Drawing.Point(-3, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(173, 414);
            this.panel2.TabIndex = 5;
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(15, 346);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(133, 23);
            this.btSalir.TabIndex = 7;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // btEliminarArt
            // 
            this.btEliminarArt.BackColor = System.Drawing.Color.Transparent;
            this.btEliminarArt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btEliminarArt.Location = new System.Drawing.Point(15, 159);
            this.btEliminarArt.Name = "btEliminarArt";
            this.btEliminarArt.Size = new System.Drawing.Size(133, 23);
            this.btEliminarArt.TabIndex = 6;
            this.btEliminarArt.Text = "Eliminar Articulo";
            this.btEliminarArt.UseVisualStyleBackColor = false;
            this.btEliminarArt.Click += new System.EventHandler(this.btEliminarArt_Click);
            // 
            // btModificarArticulo
            // 
            this.btModificarArticulo.BackColor = System.Drawing.Color.Transparent;
            this.btModificarArticulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btModificarArticulo.Location = new System.Drawing.Point(15, 129);
            this.btModificarArticulo.Name = "btModificarArticulo";
            this.btModificarArticulo.Size = new System.Drawing.Size(133, 23);
            this.btModificarArticulo.TabIndex = 5;
            this.btModificarArticulo.Text = "Modificar Articulo";
            this.btModificarArticulo.UseVisualStyleBackColor = false;
            this.btModificarArticulo.Click += new System.EventHandler(this.btModificarArticulo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(29, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "MENU";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Location = new System.Drawing.Point(161, 38);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(710, 414);
            this.panel3.TabIndex = 6;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btListar;
        private System.Windows.Forms.Button btAgregarArt;
        private System.Windows.Forms.Button btBuscarArticulo;
        private System.Windows.Forms.Button btDetalleArticulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btEliminarArt;
        private System.Windows.Forms.Button btModificarArticulo;
        private System.Windows.Forms.Button btSalir;
    }
}