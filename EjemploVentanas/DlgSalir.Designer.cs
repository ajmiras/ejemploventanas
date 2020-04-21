namespace EjemploVentanas
{
    partial class DlgSalir
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
            this.btnSi = new System.Windows.Forms.Button();
            this.btNo = new System.Windows.Forms.Button();
            this.lblPregunta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSi
            // 
            this.btnSi.BackColor = System.Drawing.SystemColors.Control;
            this.btnSi.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnSi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSi.Location = new System.Drawing.Point(34, 90);
            this.btnSi.Name = "btnSi";
            this.btnSi.Size = new System.Drawing.Size(58, 27);
            this.btnSi.TabIndex = 0;
            this.btnSi.Text = "Sí";
            this.btnSi.UseVisualStyleBackColor = false;
            // 
            // btNo
            // 
            this.btNo.BackColor = System.Drawing.SystemColors.Control;
            this.btNo.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btNo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btNo.Location = new System.Drawing.Point(125, 90);
            this.btNo.Name = "btNo";
            this.btNo.Size = new System.Drawing.Size(58, 27);
            this.btNo.TabIndex = 0;
            this.btNo.Text = "No";
            this.btNo.UseVisualStyleBackColor = false;
            // 
            // lblPregunta
            // 
            this.lblPregunta.AutoSize = true;
            this.lblPregunta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPregunta.Location = new System.Drawing.Point(31, 33);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(152, 16);
            this.lblPregunta.TabIndex = 2;
            this.lblPregunta.Text = "¿Desea salir de la App?";
            // 
            // DlgSalir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(213, 143);
            this.Controls.Add(this.lblPregunta);
            this.Controls.Add(this.btNo);
            this.Controls.Add(this.btnSi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DlgSalir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salir App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSi;
        private System.Windows.Forms.Button btNo;
        private System.Windows.Forms.Label lblPregunta;
    }
}