using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploVentanas
{
    public partial class FPrincipal : Form
    {
        public FPrincipal()
        {
            InitializeComponent();
        }

        private void btnVentanaModal_Click(object sender, EventArgs e)
        {
            // Creamos la ventana...
            FVentanaModal fVentanaModal = new FVentanaModal();

            // y la mostramos formato modal.
            fVentanaModal.ShowDialog();

            // Miramos qué botón han pulsado.
            if (fVentanaModal.DialogResult == DialogResult.OK)
            {
                txtTexto.Text = fVentanaModal.txtTexto.Text;
            }
            else
            {
                txtTexto.Text = "Cancelado por el usuario.";
            }
        }

        private void btnVentanaNoModal_Click(object sender, EventArgs e)
        {
            // Creamos la ventana...
            FVentanaNoModal fVentanaNoModal = new FVentanaNoModal();

            // y la mostramos en formato no modal.
            fVentanaNoModal.Show();

            // Añadimos los procedimientos que se ejecutará cuando nos manden información.
            fVentanaNoModal.EnviandoTexto += new FVentanaNoModal.EnviarTexto(RecibidoTexto);
            fVentanaNoModal.EnviandoClave += new FVentanaNoModal.EnviarClave(RecibidoClave);
        }

        private void RecibidoTexto(string texto)
        {
            // Cuando nos manden texto lo mostraremos.
            txtTexto.Text = texto;
        }

        private void RecibidoClave(string texto)
        {
            // Cuando nos manden texto lo mostraremos.
            txtClave.Text = texto;
        }

        private void btCerrar_Click(object sender, EventArgs e)
        {
            // Creamos el cuadro de diálogo Salir
            DlgSalir dlgSalir = new DlgSalir();

            // Lo mostramos de forma modal.
            dlgSalir.ShowDialog();

            // Si pulsan sobre el botón Sí, cerramos.
            if (dlgSalir.DialogResult == DialogResult.Yes)
                Close();
        }
    }

}
