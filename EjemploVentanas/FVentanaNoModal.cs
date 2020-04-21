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
    public partial class FVentanaNoModal : Form
    {    
        // Delegados utilizados para enviar texto a la ventana principal.
        public delegate void EnviarTexto(string texto);
        public delegate void EnviarClave(string texto);

        // Eventos asociados a los delegados para enviar el texto a la ventana principal.
        public event EnviarTexto EnviandoTexto;
        public event EnviarClave EnviandoClave;

        public FVentanaNoModal()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            // Al ser una ventana no modal debemos cerrarla nosotros.
            Close();
        }

        private void txtTexto_KeyUp(object sender, KeyEventArgs e)
        {
            // Evento para enviar texto a la ventana principal.
            // Cada vez que se suelte una tecla en txtTexto envío el texto
            // a la ventana principal.
            EnviandoTexto(txtTexto.Text);
        }

        private void txtClave_KeyUp(object sender, KeyEventArgs e)
        {
            // Idem pero con txtClave..
            EnviandoClave(txtClave.Text);
        }
    }
}
