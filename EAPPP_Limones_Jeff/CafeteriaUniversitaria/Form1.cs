using System;
using System.Windows.Forms;

namespace CafeteriaUniversitaria
{
    public partial class Form1 : Form
    {
        double precio = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lvCatalogo.Columns.Add("Producto", 180);
            lvCatalogo.Columns.Add("Precio", 80);

            AgregarProducto("Empanada de queso", 1.25);
            AgregarProducto("Sánduche de pollo", 2.50);
            AgregarProducto("Bolón de verde mixto", 2.25);
            AgregarProducto("Humita tradicional", 1.50);
            AgregarProducto("Tostada con queso", 1.00);
            AgregarProducto("Café pasado", 0.85);
            AgregarProducto("Chocolate caliente", 1.35);
            AgregarProducto("Jugo natural (naranja/mora)", 1.50);
            AgregarProducto("Batido de fruta", 2.00);
            AgregarProducto("Botella de agua", 0.75);

            lvPedido.Columns.Add("Producto", 145);
            lvPedido.Columns.Add("Cant.", 50);
            lvPedido.Columns.Add("Subtotal", 75);

            rbtnMostrador.Checked = true;
            chkPostre.Checked = false;
            chkServilletas.Checked = false;
            btnAgregar.Enabled = false;
            btnQuitar.Enabled = false;
            lblTotal.Text = "Total: $0.00";
            lblEstado.Text = "Estado: Seleccione un producto.";
        }

        private void AgregarProducto(string nombre, double p)
        {
            ListViewItem item = new ListViewItem(nombre);
            item.SubItems.Add("$" + p.ToString("0.00"));
            lvCatalogo.Items.Add(item);
        }

        private void lvCatalogo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvCatalogo.SelectedItems.Count > 0)
            {
                txtProducto.Text = lvCatalogo.SelectedItems[0].Text;
                string textoPrecio = lvCatalogo.SelectedItems[0].SubItems[1].Text.Replace("$", "");
                precio = double.Parse(textoPrecio);

                ComprobarAgregar();
                lblEstado.Text = "Estado: Producto seleccionado (" + txtProducto.Text + ").";
            }
            else
            {
                txtProducto.Text = "";
                precio = 0;
                btnAgregar.Enabled = false;
            }
        }

        private void lvPedido_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvPedido.SelectedItems.Count > 0)
            {
                btnQuitar.Enabled = true;
            }
            else
            {
                btnQuitar.Enabled = false;
            }
        }

        private void txtCantidad_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (btnLimpiar.Focused)
            {
                return;
            }

            int c;
            if (!int.TryParse(txtCantidad.Text, out c) || c < 1)
            {
                e.Cancel = true;
                lblEstado.Text = "Error: La cantidad debe ser un entero mayor o igual a 1.";
                txtCantidad.SelectAll();
            }
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            ComprobarAgregar();
        }

        private void txtProducto_TextChanged(object sender, EventArgs e)
        {
            ComprobarAgregar();
        }

        private void ComprobarAgregar()
        {
            int c;
            if (txtProducto.Text != "" && int.TryParse(txtCantidad.Text, out c) && c >= 1)
            {
                btnAgregar.Enabled = true;
            }
            else
            {
                btnAgregar.Enabled = false;
            }
        }

        private void rbtnMostrador_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnMostrador.Checked == true)
            {
                ActualizarTotal();
                lblEstado.Text = "Opción aplicada: Retiro en mostrador.";
            }
        }

        private void rbtnEntrega_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnEntrega.Checked == true)
            {
                ActualizarTotal();
                lblEstado.Text = "Opción aplicada: Entrega en aula (+$0.50).";
            }
        }

        private void chkPostre_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarTotal();
            if (chkPostre.Checked == true)
            {
                lblEstado.Text = "Opción aplicada: Postre del día (+$1.00).";
            }
            else
            {
                lblEstado.Text = "Opción removida: Postre del día.";
            }
        }

        private void chkServilletas_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarTotal();
            if (chkServilletas.Checked == true)
            {
                lblEstado.Text = "Opción aplicada: Servilletas / Cubiertos.";
            }
            else
            {
                lblEstado.Text = "Opción removida: Servilletas / Cubiertos.";
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtCliente.Text.Trim() == "")
            {
                lblEstado.Text = "Error: Ingrese el nombre del cliente.";
                txtCliente.Focus();
                return;
            }

            if (txtProducto.Text == "")
            {
                lblEstado.Text = "Error: Seleccione un producto.";
                return;
            }

            int c;
            if (!int.TryParse(txtCantidad.Text, out c) || c < 1)
            {
                lblEstado.Text = "Error: La cantidad debe ser un entero mayor o igual a 1.";
                txtCantidad.Focus();
                return;
            }

            double sub = c * precio;

            ListViewItem fila = new ListViewItem(txtProducto.Text);
            fila.SubItems.Add(c.ToString());
            fila.SubItems.Add("$" + sub.ToString("0.00"));
            lvPedido.Items.Add(fila);

            ActualizarTotal();
            lblEstado.Text = "Estado: " + txtProducto.Text + " agregado.";
            txtCantidad.Text = "1";
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (lvPedido.SelectedItems.Count > 0)
            {
                string prod = lvPedido.SelectedItems[0].Text;
                lvPedido.Items.Remove(lvPedido.SelectedItems[0]);
                ActualizarTotal();
                btnQuitar.Enabled = false;
                lblEstado.Text = "Estado: " + prod + " eliminado.";
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lvPedido.Items.Clear();
            txtCliente.Text = "";
            txtProducto.Text = "";
            lvCatalogo.SelectedItems.Clear();
            precio = 0;

            txtCantidad.Text = "1";
            rbtnMostrador.Checked = true;
            chkPostre.Checked = false;
            chkServilletas.Checked = false;

            btnAgregar.Enabled = false;
            btnQuitar.Enabled = false;

            ActualizarTotal();
            lblEstado.Text = "Estado: Pedido reiniciado.";
        }

        private void ActualizarTotal()
        {
            double total = 0;

            for (int i = 0; i < lvPedido.Items.Count; i++)
            {
                string val = lvPedido.Items[i].SubItems[2].Text.Replace("$", "");
                total = total + double.Parse(val);
            }

            if (rbtnEntrega.Checked == true)
            {
                total = total + 0.50;
            }

            if (chkPostre.Checked == true)
            {
                total = total + 1.00;
            }

            lblTotal.Text = "Total: $" + total.ToString("0.00");
        }
    }
}