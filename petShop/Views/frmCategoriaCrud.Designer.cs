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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategoriaCrud));
            this.dgvListaCateg = new System.Windows.Forms.DataGridView();
            this.txtNombreCateg = new System.Windows.Forms.TextBox();
            this.btnGuardarNuevaCateg = new System.Windows.Forms.Button();
            this.btnGuardarCambiosCateg = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblIdCateg = new System.Windows.Forms.Label();
            this.btnNuevaCateg = new System.Windows.Forms.Button();
            this.btnEditarCateg = new System.Windows.Forms.Button();
            this.idCateg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCateg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCateg)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaCateg
            // 
            this.dgvListaCateg.AllowUserToAddRows = false;
            this.dgvListaCateg.AllowUserToDeleteRows = false;
            this.dgvListaCateg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaCateg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCateg,
            this.nombreCateg});
            this.dgvListaCateg.Location = new System.Drawing.Point(12, 95);
            this.dgvListaCateg.Name = "dgvListaCateg";
            this.dgvListaCateg.ReadOnly = true;
            this.dgvListaCateg.Size = new System.Drawing.Size(343, 471);
            this.dgvListaCateg.TabIndex = 0;
            this.dgvListaCateg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaCategorías_CellClick);
            // 
            // txtNombreCateg
            // 
            this.txtNombreCateg.Enabled = false;
            this.txtNombreCateg.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCateg.Location = new System.Drawing.Point(366, 155);
            this.txtNombreCateg.Name = "txtNombreCateg";
            this.txtNombreCateg.Size = new System.Drawing.Size(208, 33);
            this.txtNombreCateg.TabIndex = 2;
            // 
            // btnGuardarNuevaCateg
            // 
            this.btnGuardarNuevaCateg.BackColor = System.Drawing.Color.Lime;
            this.btnGuardarNuevaCateg.Enabled = false;
            this.btnGuardarNuevaCateg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarNuevaCateg.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarNuevaCateg.Location = new System.Drawing.Point(366, 474);
            this.btnGuardarNuevaCateg.Name = "btnGuardarNuevaCateg";
            this.btnGuardarNuevaCateg.Size = new System.Drawing.Size(208, 43);
            this.btnGuardarNuevaCateg.TabIndex = 5;
            this.btnGuardarNuevaCateg.Text = "GUARDAR NUEVO";
            this.btnGuardarNuevaCateg.UseVisualStyleBackColor = false;
            this.btnGuardarNuevaCateg.Click += new System.EventHandler(this.btnGuardarNuevaCateg_Click);
            // 
            // btnGuardarCambiosCateg
            // 
            this.btnGuardarCambiosCateg.BackColor = System.Drawing.Color.Lime;
            this.btnGuardarCambiosCateg.Enabled = false;
            this.btnGuardarCambiosCateg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCambiosCateg.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCambiosCateg.Location = new System.Drawing.Point(366, 523);
            this.btnGuardarCambiosCateg.Name = "btnGuardarCambiosCateg";
            this.btnGuardarCambiosCateg.Size = new System.Drawing.Size(208, 43);
            this.btnGuardarCambiosCateg.TabIndex = 6;
            this.btnGuardarCambiosCateg.Text = "GUARDAR CAMBIOS";
            this.btnGuardarCambiosCateg.UseVisualStyleBackColor = false;
            this.btnGuardarCambiosCateg.Click += new System.EventHandler(this.btnGuardarCambiosCateg_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(591, 89);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 36);
            this.label1.TabIndex = 8;
            this.label1.Text = "Configuración de Categorías";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(548, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(361, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "ID: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(361, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nombre de la categoría: ";
            // 
            // lblIdCateg
            // 
            this.lblIdCateg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIdCateg.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdCateg.Location = new System.Drawing.Point(411, 98);
            this.lblIdCateg.Name = "lblIdCateg";
            this.lblIdCateg.Size = new System.Drawing.Size(163, 22);
            this.lblIdCateg.TabIndex = 10;
            this.lblIdCateg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnNuevaCateg
            // 
            this.btnNuevaCateg.BackColor = System.Drawing.Color.Lime;
            this.btnNuevaCateg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaCateg.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaCateg.Location = new System.Drawing.Point(366, 223);
            this.btnNuevaCateg.Name = "btnNuevaCateg";
            this.btnNuevaCateg.Size = new System.Drawing.Size(209, 43);
            this.btnNuevaCateg.TabIndex = 11;
            this.btnNuevaCateg.Text = "NUEVA CATEGORÍA";
            this.btnNuevaCateg.UseVisualStyleBackColor = false;
            this.btnNuevaCateg.Click += new System.EventHandler(this.btnNuevaCateg_Click);
            // 
            // btnEditarCateg
            // 
            this.btnEditarCateg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEditarCateg.Enabled = false;
            this.btnEditarCateg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarCateg.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarCateg.Location = new System.Drawing.Point(366, 272);
            this.btnEditarCateg.Name = "btnEditarCateg";
            this.btnEditarCateg.Size = new System.Drawing.Size(209, 43);
            this.btnEditarCateg.TabIndex = 12;
            this.btnEditarCateg.Text = "EDITAR";
            this.btnEditarCateg.UseVisualStyleBackColor = false;
            this.btnEditarCateg.Click += new System.EventHandler(this.btnEditarCateg_Click);
            // 
            // idCateg
            // 
            this.idCateg.HeaderText = "ID";
            this.idCateg.Name = "idCateg";
            this.idCateg.ReadOnly = true;
            // 
            // nombreCateg
            // 
            this.nombreCateg.HeaderText = "NOMBRE";
            this.nombreCateg.Name = "nombreCateg";
            this.nombreCateg.ReadOnly = true;
            this.nombreCateg.Width = 200;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(365, 425);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(209, 43);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmCategoriaCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(591, 578);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEditarCateg);
            this.Controls.Add(this.btnNuevaCateg);
            this.Controls.Add(this.lblIdCateg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnGuardarCambiosCateg);
            this.Controls.Add(this.btnGuardarNuevaCateg);
            this.Controls.Add(this.txtNombreCateg);
            this.Controls.Add(this.dgvListaCateg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCategoriaCrud";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCategoriaCrud";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCateg)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaCateg;
        private System.Windows.Forms.TextBox txtNombreCateg;
        private System.Windows.Forms.Button btnGuardarNuevaCateg;
        private System.Windows.Forms.Button btnGuardarCambiosCateg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblIdCateg;
        private System.Windows.Forms.Button btnNuevaCateg;
        private System.Windows.Forms.Button btnEditarCateg;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCateg;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCateg;
        private System.Windows.Forms.Button btnCancelar;
    }
}