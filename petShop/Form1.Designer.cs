namespace petShop
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvListaUsuarios = new System.Windows.Forms.DataGridView();
            this.btnAddNormal = new System.Windows.Forms.Button();
            this.btnAddEncrypt = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaUsuarios
            // 
            this.dgvListaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaUsuarios.Location = new System.Drawing.Point(12, 12);
            this.dgvListaUsuarios.Name = "dgvListaUsuarios";
            this.dgvListaUsuarios.Size = new System.Drawing.Size(545, 376);
            this.dgvListaUsuarios.TabIndex = 0;
            this.dgvListaUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaUsuarios_CellContentClick);
            // 
            // btnAddNormal
            // 
            this.btnAddNormal.Location = new System.Drawing.Point(564, 12);
            this.btnAddNormal.Name = "btnAddNormal";
            this.btnAddNormal.Size = new System.Drawing.Size(173, 67);
            this.btnAddNormal.TabIndex = 1;
            this.btnAddNormal.Text = "ADD";
            this.btnAddNormal.UseVisualStyleBackColor = true;
            this.btnAddNormal.Click += new System.EventHandler(this.btnAddNormal_Click);
            // 
            // btnAddEncrypt
            // 
            this.btnAddEncrypt.Location = new System.Drawing.Point(564, 117);
            this.btnAddEncrypt.Name = "btnAddEncrypt";
            this.btnAddEncrypt.Size = new System.Drawing.Size(173, 67);
            this.btnAddEncrypt.TabIndex = 2;
            this.btnAddEncrypt.Text = "ADD ENCRYPT";
            this.btnAddEncrypt.UseVisualStyleBackColor = true;
            this.btnAddEncrypt.Click += new System.EventHandler(this.btnAddEncrypt_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(564, 321);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(173, 67);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 734);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnAddEncrypt);
            this.Controls.Add(this.btnAddNormal);
            this.Controls.Add(this.dgvListaUsuarios);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaUsuarios;
        private System.Windows.Forms.Button btnAddNormal;
        private System.Windows.Forms.Button btnAddEncrypt;
        private System.Windows.Forms.Button btnLogin;
    }
}

