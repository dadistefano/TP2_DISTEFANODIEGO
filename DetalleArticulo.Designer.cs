namespace TP2_DIEGO_DISTEFANO
{
    partial class DetalleArticulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetalleArticulo));
            this.lbBusqID = new System.Windows.Forms.Label();
            this.txCodigo = new System.Windows.Forms.TextBox();
            this.btBuscarID = new System.Windows.Forms.Button();
            this.picImagenUrl = new System.Windows.Forms.PictureBox();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.btVolver = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picImagenUrl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbBusqID
            // 
            this.lbBusqID.AutoSize = true;
            this.lbBusqID.BackColor = System.Drawing.Color.Transparent;
            this.lbBusqID.Location = new System.Drawing.Point(20, 95);
            this.lbBusqID.Name = "lbBusqID";
            this.lbBusqID.Size = new System.Drawing.Size(127, 13);
            this.lbBusqID.TabIndex = 0;
            this.lbBusqID.Text = "Ingrese el ID ARTICULO:";
            // 
            // txCodigo
            // 
            this.txCodigo.Location = new System.Drawing.Point(23, 111);
            this.txCodigo.Name = "txCodigo";
            this.txCodigo.Size = new System.Drawing.Size(128, 20);
            this.txCodigo.TabIndex = 1;
            // 
            // btBuscarID
            // 
            this.btBuscarID.Location = new System.Drawing.Point(23, 138);
            this.btBuscarID.Name = "btBuscarID";
            this.btBuscarID.Size = new System.Drawing.Size(75, 23);
            this.btBuscarID.TabIndex = 2;
            this.btBuscarID.Text = "Buscar";
            this.btBuscarID.UseVisualStyleBackColor = true;
            this.btBuscarID.Click += new System.EventHandler(this.btBuscarID_Click);
            // 
            // picImagenUrl
            // 
            this.picImagenUrl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picImagenUrl.Location = new System.Drawing.Point(445, 64);
            this.picImagenUrl.Name = "picImagenUrl";
            this.picImagenUrl.Size = new System.Drawing.Size(180, 133);
            this.picImagenUrl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImagenUrl.TabIndex = 3;
            this.picImagenUrl.TabStop = false;
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDetalle.Location = new System.Drawing.Point(23, 210);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalle.Size = new System.Drawing.Size(602, 150);
            this.dgvDetalle.TabIndex = 4;
            // 
            // btVolver
            // 
            this.btVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btVolver.Location = new System.Drawing.Point(529, 366);
            this.btVolver.Name = "btVolver";
            this.btVolver.Size = new System.Drawing.Size(96, 23);
            this.btVolver.TabIndex = 5;
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
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(656, 50);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(-1, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(654, 10);
            this.panel2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "DETALLE DE ARTICULO";
            // 
            // DetalleArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(653, 449);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btVolver);
            this.Controls.Add(this.dgvDetalle);
            this.Controls.Add(this.picImagenUrl);
            this.Controls.Add(this.btBuscarID);
            this.Controls.Add(this.txCodigo);
            this.Controls.Add(this.lbBusqID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DetalleArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DetalleArticulo";
            ((System.ComponentModel.ISupportInitialize)(this.picImagenUrl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbBusqID;
        private System.Windows.Forms.TextBox txCodigo;
        private System.Windows.Forms.Button btBuscarID;
        private System.Windows.Forms.PictureBox picImagenUrl;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.Button btVolver;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
    }
}