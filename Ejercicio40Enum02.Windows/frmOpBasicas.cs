using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio40Enum.Windows
{
    public partial class frmOpBasicas : Form
    {
        public frmOpBasicas()
        {
            InitializeComponent();
        }
        Operacion operacionSeleccionada;
        private void btnSuma_Click(object sender, EventArgs e)
        {
            var numero1 = int.Parse(txtNumero1.Text);
            var numero2 = int.Parse(txtNumero2.Text);
            var suma = CalcularSuma(numero1, numero2);
            
            MessageBox.Show($"La suma es {suma}", "Resultado",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            InicializarControles();
        }
        
        private void InicializarControles()
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            txtNumero1.Focus();
        }
        private int CalcularSuma(int numero1, int numero2) => numero1 + numero2;
        private int CalcularResta(int numero1, int numero2) => numero1 - numero2;
        private int CalcularProducto(int numero1, int numero2) => numero1 * numero2;
        private int CalcularCociente(int numero1, int numero2) => numero1 / numero2;
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            InicializarControles();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            var numero1 = int.Parse(txtNumero1.Text);
            var numero2 = int.Parse(txtNumero2.Text);
            var resta = CalcularResta(numero1, numero2);
            MessageBox.Show($"La resta es {resta}", "Resultado",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            InicializarControles();

        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            var numero1 = int.Parse(txtNumero1.Text);
            var numero2 = int.Parse(txtNumero2.Text);
            var producto = CalcularProducto(numero1, numero2);
            MessageBox.Show($"El producto es {producto}", "Resultado",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            InicializarControles();

        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            var numero1 = int.Parse(txtNumero1.Text);
            var numero2 = int.Parse(txtNumero2.Text);
            //var division = numero1 /numero2;
            var division = CalcularCociente(numero1, numero2);
            MessageBox.Show($"El cociente es {division}", "Resultado",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            InicializarControles();

        }

        private void frmOpBasicas_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Desea salir del programa?",
                "Pregunta",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;//cancela el evento de cierre del form
            }
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
