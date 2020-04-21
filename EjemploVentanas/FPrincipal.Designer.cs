namespace EjemploVentanas
{
    partial class FPrincipal
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
            this.btnVentanaModal = new System.Windows.Forms.Button();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.btnVentanaNoModal = new System.Windows.Forms.Button();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.lblTexto = new System.Windows.Forms.Label();
            this.btCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVentanaModal
            // 
            this.btnVentanaModal.Location = new System.Drawing.Point(43, 173);
            this.btnVentanaModal.Name = "btnVentanaModal";
            this.btnVentanaModal.Size = new System.Drawing.Size(87, 27);
            this.btnVentanaModal.TabIndex = 0;
            this.btnVentanaModal.Text = "Abrir modal";
            this.btnVentanaModal.UseVisualStyleBackColor = true;
            this.btnVentanaModal.Click += new System.EventHandler(this.btnVentanaModal_Click);
            // 
            // txtTexto
            // 
            this.txtTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtTexto.Location = new System.Drawing.Point(79, 87);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(302, 20);
            this.txtTexto.TabIndex = 1;
            // 
            // btnVentanaNoModal
            // 
            this.btnVentanaNoModal.Location = new System.Drawing.Point(263, 173);
            this.btnVentanaNoModal.Name = "btnVentanaNoModal";
            this.btnVentanaNoModal.Size = new System.Drawing.Size(112, 27);
            this.btnVentanaNoModal.TabIndex = 2;
            this.btnVentanaNoModal.Text = "Abrir no modal";
            this.btnVentanaNoModal.UseVisualStyleBackColor = true;
            this.btnVentanaNoModal.Click += new System.EventHandler(this.btnVentanaNoModal_Click);
            // 
            // txtClave
            // 
            this.txtClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtClave.Location = new System.Drawing.Point(79, 128);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(302, 20);
            this.txtClave.TabIndex = 3;
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(31, 128);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(43, 16);
            this.lblClave.TabIndex = 8;
            this.lblClave.Text = "Clave";
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Location = new System.Drawing.Point(31, 87);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(42, 16);
            this.lblTexto.TabIndex = 7;
            this.lblTexto.Text = "Texto";
            // 
            // btCerrar
            // 
            this.btCerrar.Location = new System.Drawing.Point(15, 12);
            this.btCerrar.Name = "btCerrar";
            this.btCerrar.Size = new System.Drawing.Size(75, 23);
            this.btCerrar.TabIndex = 9;
            this.btCerrar.Text = "Cerrar";
            this.btCerrar.UseVisualStyleBackColor = true;
            this.btCerrar.Click += new System.EventHandler(this.btCerrar_Click);
            // 
            // FPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 239);
            this.Controls.Add(this.btCerrar);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.btnVentanaNoModal);
            this.Controls.Add(this.txtTexto);
            this.Controls.Add(this.btnVentanaModal);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FPrincipal";
            this.Text = "Ventana Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVentanaModal;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.Button btnVentanaNoModal;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.Button btCerrar;
    }
}

