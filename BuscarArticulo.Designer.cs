namespace TP2_DIEGO_DISTEFANO
{
    partial class BuscarArticulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarArticulo));
            this.lbBuscarXcodigo = new System.Windows.Forms.Label();
            this.txBuscarCodigo = new System.Windows.Forms.TextBox();
            this.btBuscarXCodigo = new System.Windows.Forms.Button();
            this.dgvBuscar = new System.Windows.Forms.DataGridView();
            this.btVolver = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btBuscarMarca = new System.Windows.Forms.Button();
            this.txBuscarMarca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btBuscarCategoria = new System.Windows.Forms.Button();
            this.txBuscarCategoria = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscar)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbBuscarXcodigo
            // 
            this.lbBuscarXcodigo.AutoSize = true;
            this.lbBuscarXcodigo.BackColor = System.Drawing.Color.Transparent;
            this.lbBuscarXcodigo.Location = new System.Drawing.Point(16, 69);
            this.lbBuscarXcodigo.Name = "lbBuscarXcodigo";
            this.lbBuscarXcodigo.Size = new System.Drawing.Size(97, 13);
            this.lbBuscarXcodigo.TabIndex = 0;
            this.lbBuscarXcodigo.Text = "Buscar por Codigo:";
            // 
            // txBuscarCodigo
            // 
            this.txBuscarCodigo.Location = new System.Drawing.Point(180, 62);
            this.txBuscarCodigo.Name = "txBuscarCodigo";
            this.txBuscarCodigo.Size = new System.Drawing.Size(147, 20);
            this.txBuscarCodigo.TabIndex = 1;
            // 
            // btBuscarXCodigo
            // 
            this.btBuscarXCodigo.Location = new System.Drawing.Point(333, 59);
            this.btBuscarXCodigo.Name = "btBuscarXCodigo";
            this.btBuscarXCodigo.Size = new System.Drawing.Size(103, 23);
            this.btBuscarXCodigo.TabIndex = 2;
            this.btBuscarXCodigo.Text = "Buscar";
            this.btBuscarXCodigo.UseVisualStyleBackColor = true;
            this.btBuscarXCodigo.Click += new System.EventHandler(this.btBuscarXCodigo_Click);
            // 
            // dgvBuscar
            // 
            this.dgvBuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscar.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvBuscar.Location = new System.Drawing.Point(12, 154);
            this.dgvBuscar.Name = "dgvBuscar";
            this.dgvBuscar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvBuscar.Size = new System.Drawing.Size(700, 256);
            this.dgvBuscar.TabIndex = 3;
            // 
            // btVolver
            // 
            this.btVolver.Location = new System.Drawing.Point(604, 416);
            this.btVolver.Name = "btVolver";
            this.btVolver.Size = new System.Drawing.Size(108, 23);
            this.btVolver.TabIndex = 4;
            this.btVolver.Text = "Volver";
            this.btVolver.UseVisualStyleBackColor = true;
            this.btVolver.Click += new System.EventHandler(this.btVolver_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(727, 56);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "BUSCAR ARCHIVO";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(3, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(725, 12);
            this.panel2.TabIndex = 6;
            // 
            // btBuscarMarca
            // 
            this.btBuscarMarca.Location = new System.Drawing.Point(333, 84);
            this.btBuscarMarca.Name = "btBuscarMarca";
            this.btBuscarMarca.Size = new System.Drawing.Size(103, 23);
            this.btBuscarMarca.TabIndex = 8;
            this.btBuscarMarca.Text = "Buscar";
            this.btBuscarMarca.UseVisualStyleBackColor = true;
            this.btBuscarMarca.Click += new System.EventHandler(this.button1_Click);
            // 
            // txBuscarMarca
            // 
            this.txBuscarMarca.Location = new System.Drawing.Point(180, 87);
            this.txBuscarMarca.Name = "txBuscarMarca";
            this.txBuscarMarca.Size = new System.Drawing.Size(147, 20);
            this.txBuscarMarca.TabIndex = 7;
            this.txBuscarMarca.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(16, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Buscar por Nombre de Marca:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btBuscarCategoria
            // 
            this.btBuscarCategoria.Location = new System.Drawing.Point(333, 109);
            this.btBuscarCategoria.Name = "btBuscarCategoria";
            this.btBuscarCategoria.Size = new System.Drawing.Size(103, 23);
            this.btBuscarCategoria.TabIndex = 11;
            this.btBuscarCategoria.Text = "Buscar";
            this.btBuscarCategoria.UseVisualStyleBackColor = true;
            this.btBuscarCategoria.Click += new System.EventHandler(this.btBuscarCategoria_Click);
            // 
            // txBuscarCategoria
            // 
            this.txBuscarCategoria.Location = new System.Drawing.Point(180, 112);
            this.txBuscarCategoria.Name = "txBuscarCategoria";
            this.txBuscarCategoria.Size = new System.Drawing.Size(147, 20);
            this.txBuscarCategoria.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(16, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Buscar por Nombre de Categoria:";
            // 
            // BuscarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(725, 450);
            this.Controls.Add(this.btBuscarCategoria);
            this.Controls.Add(this.txBuscarCategoria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btBuscarMarca);
            this.Controls.Add(this.txBuscarMarca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btVolver);
            this.Controls.Add(this.dgvBuscar);
            this.Controls.Add(this.btBuscarXCodigo);
            this.Controls.Add(this.txBuscarCodigo);
            this.Controls.Add(this.lbBuscarXcodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(725, 450);
            this.MinimumSize = new System.Drawing.Size(725, 450);
            this.Name = "BuscarArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuscarArticulo";
            this.Load += new System.EventHandler(this.BuscarArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbBuscarXcodigo;
        private System.Windows.Forms.TextBox txBuscarCodigo;
        private System.Windows.Forms.Button btBuscarXCodigo;
        private System.Windows.Forms.DataGridView dgvBuscar;
        private System.Windows.Forms.Button btVolver;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btBuscarMarca;
        private System.Windows.Forms.TextBox txBuscarMarca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btBuscarCategoria;
        private System.Windows.Forms.TextBox txBuscarCategoria;
        private System.Windows.Forms.Label label3;
    }
}