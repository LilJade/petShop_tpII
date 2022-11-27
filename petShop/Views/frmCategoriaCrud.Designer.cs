namespace petShop.Views
{
    partial class frmCategoriaCrud
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
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.txtIdProd = new System.Windows.Forms.TextBox();
            this.txtNombreProd = new System.Windows.Forms.TextBox();
            this.txtEstadoProd = new System.Windows.Forms.TextBox();
            this.btnActivarProd = new System.Windows.Forms.Button();
            this.btnDesactivarProd = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLista
            // 
            this.dgvLista.AllowUserToAddRows = false;
            this.dgvLista.AllowUserToDeleteRows = false;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NOMBRE,
            this.ESTADO});
            this.dgvLista.Location = new System.Drawing.Point(12, 12);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.ReadOnly = true;
            this.dgvLista.Size = new System.Drawing.Size(354, 239);
            this.dgvLista.TabIndex = 0;
            this.dgvLista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLista_CellContentClick);
            // 
            // txtIdProd
            // 
            this.txtIdProd.Location = new System.Drawing.Point(372, 25);
            this.txtIdProd.Name = "txtIdProd";
            this.txtIdProd.Size = new System.Drawing.Size(178, 20);
            this.txtIdProd.TabIndex = 2;
            // 
            // txtNombreProd
            // 
            this.txtNombreProd.Location = new System.Drawing.Point(372, 65);
            this.txtNombreProd.Name = "txtNombreProd";
            this.txtNombreProd.Size = new System.Drawing.Size(178, 20);
            this.txtNombreProd.TabIndex = 3;
            // 
            // txtEstadoProd
            // 
            this.txtEstadoProd.Location = new System.Drawing.Point(372, 101);
            this.txtEstadoProd.Name = "txtEstadoProd";
            this.txtEstadoProd.Size = new System.Drawing.Size(178, 20);
            this.txtEstadoProd.TabIndex = 4;
            // 
            // btnActivarProd
            // 
            this.btnActivarProd.Location = new System.Drawing.Point(372, 128);
            this.btnActivarProd.Name = "btnActivarProd";
            this.btnActivarProd.Size = new System.Drawing.Size(178, 43);
            this.btnActivarProd.TabIndex = 5;
            this.btnActivarProd.Text = "ACTIVAR";
            this.btnActivarProd.UseVisualStyleBackColor = true;
            this.btnActivarProd.Click += new System.EventHandler(this.btnActivarProd_Click);
            // 
            // btnDesactivarProd
            // 
            this.btnDesactivarProd.Location = new System.Drawing.Point(372, 177);
            this.btnDesactivarProd.Name = "btnDesactivarProd";
            this.btnDesactivarProd.Size = new System.Drawing.Size(178, 43);
            this.btnDesactivarProd.TabIndex = 6;
            this.btnDesactivarProd.Text = "DESACTIVAR";
            this.btnDesactivarProd.UseVisualStyleBackColor = true;
            this.btnDesactivarProd.Click += new System.EventHandler(this.btnDesactivarProd_Click);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // NOMBRE
            // 
            this.NOMBRE.HeaderText = "NOMBRE";
            this.NOMBRE.Name = "NOMBRE";
            // 
            // ESTADO
            // 
            this.ESTADO.HeaderText = "ESTADO";
            this.ESTADO.Name = "ESTADO";
            // 
            // frmCategoriaCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 582);
            this.Controls.Add(this.btnDesactivarProd);
            this.Controls.Add(this.btnActivarProd);
            this.Controls.Add(this.txtEstadoProd);
            this.Controls.Add(this.txtNombreProd);
            this.Controls.Add(this.txtIdProd);
            this.Controls.Add(this.dgvLista);
            this.Name = "frmCategoriaCrud";
            this.Text = "frmCategoriaCrud";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.TextBox txtIdProd;
        private System.Windows.Forms.TextBox txtNombreProd;
        private System.Windows.Forms.TextBox txtEstadoProd;
        private System.Windows.Forms.Button btnActivarProd;
        private System.Windows.Forms.Button btnDesactivarProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO;
    }
}