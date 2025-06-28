using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestauranteTania
{
    public partial class VentasView : Form
    {
        public VentasView()
        {
            InitializeComponent();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreCliente.Text;

            double total = 0;
            string metodoPago;

            if (cmbMetodoPago.Text == "")
            {
                MessageBox.Show("Escoja un metodo de pago valido", "Syntax Error");
                return;
            }
            metodoPago = cmbMetodoPago.Text;
            if (cbHamburguesa.Checked == true)
            {
                //se suma 6 porque ese es el precio
                //de la hambuguesa

                total += 6;

                //esto es lo mismo que hacer
                //total = total + 6
            }
            if (cbPapas.Checked == true)
            {
                //se suma 1.5 porque ese es el precio
                //de las papas fritas

                total += 1.5;
            }
            if (cbGaseosa.Checked == true)
            {
                //se suma 1 porque ese el el precio
                //de las gaseosa en lata

                total += 1;
            }
            string tipoOrden;
            if (rbComerAqui.Checked == true)
            {
                tipoOrden = "Para comer en restaurante";
            }
            else if (rbParaLlevar.Checked == true)
            {
                tipoOrden = "para llevar";
            }
            else
            {
                MessageBox.Show("Escoja un tipo de orden", "Error");
                return;
            }
            if (total == 0)
            {
                MessageBox.Show("Agregue un producto a la orden", "Error");
            }

            string resultado = $"CLiente:{nombre}\n";
            resultado += $"Tipo de orden:{tipoOrden}\n";
            resultado += $"Productos:\n";
            if (cbHamburguesa.Checked == true)
            {
                resultado += "- Hamburguesa premium - $6.00\n";
            }
            if (cbPapas.Checked == true)
            {
                resultado += "- Papas Fritas - $1.50\n";
            }
            if (cbGaseosa.Checked == true)
            {
                resultado += "- Gaseosa en lata - $1.00\n";
            }
            resultado += $"El total de la orden es ${total}.\n";
            resultado += $"Metodo de pago: {metodoPago}\n";
            resultado += $"¡Grasias por preferirnos, vuelva pronto!\n";

            MessageBox.Show(resultado, "Venta Finalizada");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cbGaseosa.Checked = false;
            cbHamburguesa.Checked = false;
            cbPapas.Checked = false;
            rbComerAqui.Checked = false;
            rbParaLlevar.Checked = false;
            txtNombreCliente.Clear();
        }
    }
}
