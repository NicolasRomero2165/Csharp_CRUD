using Integrador2025.Datos;
using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Integrador2025
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Cerrar sesión?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) { Close(); }
        }

        public void SoloLetras(KeyPressEventArgs e) //Escribe en mayúsculas
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '\"')
            {
                e.Handled = true;
            }
        }

        public void Mayuscula(KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }

        public void SoloNumeros(KeyPressEventArgs e) //Escribe en mayúsculas
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == ',' || e.KeyChar == '.')
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtNombreP_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
            Mayuscula(e);
        }

        private void txtPrecioCostoP_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }
        private void txtDescripcionP_KeyPress(object sender, KeyPressEventArgs e)
        {
            Mayuscula(e);
        }

        private void txtMargenP_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtIvaP_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtPrecioBrutoP_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtPrecioVentaP_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtProveedorP_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
            Mayuscula(e);
        }

        private void txtNombreV_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
            Mayuscula(e);
        }

        private void txtApellidoV_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
            Mayuscula(e);
        }

        private void txtDniV_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            Datos.Dal ObjDalCliente = new Datos.Dal();
            DataSet ObjDSCliente = new DataSet();
            ObjDSCliente = ObjDalCliente.ListaCliente();
            DataTable dtCliente = ObjDSCliente.Tables[0];
            dgvClientes.DataSource = dtCliente;

            Datos.Dal ObjDalEmpresa = new Datos.Dal();
            DataSet ObjDSEmpresa = new DataSet();
            ObjDSEmpresa = ObjDalEmpresa.ListaEmpresa();
            DataTable dtEmpresa = ObjDSEmpresa.Tables[0];
            dgvEmpresas.DataSource = dtEmpresa;

            ActualizarVendedores();
        }

        public void ActualizarVendedores()
        {
            dgvVendedores.Visible = true;
            Datos.Dal ObjDalProductos = new Datos.Dal();
            DataSet ObjDSProductos = new DataSet();
            ObjDSProductos = ObjDalProductos.ListaVendedores();
            DataTable dtProductos = ObjDSProductos.Tables[0];
            dgvVendedores.DataSource = dtProductos;
        }

        public void ActualizarProductos()
        {
            dgvProductos.Visible = true;
            Datos.Dal ObjDalProductos = new Datos.Dal();
            DataSet ObjDSProductos = new DataSet();
            ObjDSProductos = ObjDalProductos.ListaProductos();
            DataTable dtProductos = ObjDSProductos.Tables[0];
            dgvProductos.DataSource = dtProductos;
        }
        private void btnProductos_Click(object sender, EventArgs e)
        {
            if (dgvProductos.Visible == false)
            {
                ActualizarProductos();
                btnAgregarProductoP.Enabled = false;
                gbxBusqueda.Visible = true;
                btnAgregarProductoP.Enabled = false;
            }
            else
            {
                dgvProductos.Visible = false;
                btnAgregarProductoP.Enabled = true;
                BotonesInactivos();
                gbxBusqueda.Visible = false;
            }
        }

        public void BotonesInactivos()
        {
            btnEliminarP.Enabled = false;
            btnModificarP.Enabled = false;
        }
        public void BotonesInactivosV()
        {
            btnEliminarV.Enabled = false;
            btnModificarV.Enabled = false;
        }
        public void BotonesActivos()
        {
            btnEliminarP.Enabled = true;
            btnModificarP.Enabled = true;
        }
        public void BotonesActivosV()
        {
            btnEliminarV.Enabled = true;
            btnModificarV.Enabled = true;
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            Datos.Dal ObjDal = new Dal();
            if (txtNombreP.Text != string.Empty && txtDescripcionP.Text != string.Empty && txtPrecioCostoP.Text != string.Empty && txtMargenP.Text != string.Empty && txtIvaP.Text != string.Empty
                && txtPrecioBrutoP.Text != string.Empty && txtPrecioVentaP.Text != string.Empty && txtProveedorP.Text != string.Empty && cbxCategoriaP.Text != string.Empty && cbxSubcategoriaP.Text != string.Empty)
            {
                DialogResult result = MessageBox.Show("¿Agregar producto a la base de datos?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    ObjDal.AgregarProducto(txtNombreP.Text, txtDescripcionP.Text, Convert.ToDecimal(txtPrecioCostoP.Text), Convert.ToDouble(txtMargenP.Text),
                        Convert.ToDouble(txtIvaP.Text), Convert.ToDecimal(txtPrecioBrutoP.Text), Convert.ToDecimal(txtPrecioVentaP.Text),
                        txtProveedorP.Text, cbxCategoriaP.Text, cbxSubcategoriaP.Text);
                    LimpiarProductos();
                    ActualizarProductos();
                }
            }
            else
            {
                MessageBox.Show("Faltan completar datos.", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(lblIndex.Text);
            DialogResult result = MessageBox.Show("¿Eliminar el producto " + index + "?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Datos.Dal ObjDalProductos = new Datos.Dal();
                ObjDalProductos.EliminarProducto(index);
                ActualizarProductos();
                BotonesInactivos();
            }
        }

        private void dgvProductos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            BotonesActivos();
            if (e.RowIndex >= 0)  // evita los encabezados
            {
                int indice = e.RowIndex;
                var filaSeleccionada = dgvProductos.Rows[indice];
                // Ejemplo de acceso a celdas
                lblIndex.Text = filaSeleccionada.Cells["ID_PRODUCTO"].Value?.ToString();
            }

        }
        public void BotonesModificarOkSi()
        {
            btnModificarP.Visible = false;
            btnModificarOk.Visible = true;
        }
        public void BotonesModificarOkNo()
        {
            btnModificarP.Visible = true;
            btnModificarOk.Visible = false;
        }
        public void BotonesModificarOkSiV()
        {
            btnModificarV.Visible = false;
            btnModificarOkV.Visible = true;
        }
        public void BotonesModificarOkNoV()
        {
            btnModificarV.Visible = true;
            btnModificarOkV.Visible = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            dgvProductos.Visible = false;
            lblIndex.Text = dgvProductos.SelectedCells[0].Value.ToString();
            txtNombreP.Text = dgvProductos.SelectedCells[1].Value.ToString();
            txtDescripcionP.Text = dgvProductos.SelectedCells[2].Value.ToString();
            txtPrecioCostoP.Text = dgvProductos.SelectedCells[3].Value.ToString();
            txtMargenP.Text = dgvProductos.SelectedCells[4].Value.ToString();
            txtIvaP.Text = dgvProductos.SelectedCells[5].Value.ToString();
            txtPrecioBrutoP.Text = dgvProductos.SelectedCells[6].Value.ToString();
            txtPrecioVentaP.Text = dgvProductos.SelectedCells[7].Value.ToString();
            txtProveedorP.Text = dgvProductos.SelectedCells[8].Value.ToString();
            cbxCategoriaP.Text = dgvProductos.SelectedCells[9].Value.ToString();
            cbxSubcategoriaP.Text = dgvProductos.SelectedCells[10].Value.ToString();
            BotonesInactivos();
            BotonesModificarOkSi();
        }
        public void LimpiarProductos()
        {
            lblIndex.Text = string.Empty;
            txtNombreP.Text = string.Empty;
            txtDescripcionP.Text = string.Empty;
            txtPrecioCostoP.Text = string.Empty;
            txtMargenP.Text = string.Empty;
            txtIvaP.Text = string.Empty;
            txtPrecioBrutoP.Text = string.Empty;
            txtPrecioVentaP.Text = string.Empty;
            txtProveedorP.Text = string.Empty;
            cbxCategoriaP.Text = null;
            cbxSubcategoriaP.Text = null;
        }

        public void LimpiarVendedor()
        {
            txtNombreV.Text = string.Empty;
            txtApellidoV.Text = string.Empty;
            txtDniV.Text = string.Empty;
            mtbCuitV.Text = string.Empty;
        }
        private void btnModificarOk_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(lblIndex.Text);
            DialogResult result = MessageBox.Show("¿Modificar el producto " + index + "?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Datos.Dal ObjProductos = new Datos.Dal();
                ObjProductos.ModificarProductos(index, txtNombreP.Text, txtDescripcionP.Text, Convert.ToDecimal(txtPrecioCostoP.Text), Convert.ToDouble(txtMargenP.Text),
                    Convert.ToDouble(txtIvaP.Text), Convert.ToDecimal(txtPrecioBrutoP.Text), Convert.ToDecimal(txtPrecioVentaP.Text),
                    txtProveedorP.Text, cbxCategoriaP.Text, cbxSubcategoriaP.Text);
                ActualizarProductos();
                BotonesInactivos();
                BotonesModificarOkNo();
                LimpiarProductos();
            }
            else
            {
                LimpiarProductos();
                BotonesInactivos();
                BotonesModificarOkNo();
            }
        }

        private void Categorias() //Función de mostrar las localidades según la provincia
        {
            string Provincia = cbxCategoriaP.Text;
            switch (Provincia)
            {
                case "CATEGORÍA A":
                    cbxSubcategoriaP.Items.Clear();
                    string[] CategoriasA = { "CATEGORÍA A.A", "CATEGORÍA A.B", "CATEGORÍA A.C" };
                    cbxSubcategoriaP.Items.AddRange(CategoriasA);
                    cbxSubcategoriaP.Enabled = true;
                    break;
                case "CATEGORÍA B":
                    cbxSubcategoriaP.Items.Clear();
                    string[] CategoriasB = { "CATEGORÍA B.B", "CATEGORÍA B.C" };
                    cbxSubcategoriaP.Items.AddRange(CategoriasB);
                    cbxSubcategoriaP.Enabled = true;
                    break;
                case "CATEGORÍA C":
                    cbxSubcategoriaP.Items.Clear();
                    string[] CategoriasC = { "CATEGORÍA C.C" };
                    cbxSubcategoriaP.Items.AddRange(CategoriasC);
                    cbxSubcategoriaP.Enabled = true;
                    break;
                default:
                    break;

            }
        }
        private void cbxCategoriaP_SelectedIndexChanged(object sender, EventArgs e)
        {
            Categorias();
        }

        private void btnCerrarBusqueda_Click(object sender, EventArgs e)
        {
            string dato = txtBuscarP.Text;
            string columna = cbxColumna.Text;
            Datos.Dal ObjDalProductos = new Datos.Dal();
            DataSet ObjDSProductos = new DataSet();
            ObjDSProductos = ObjDalProductos.BuscarProducto(dato, columna);
            DataTable dtProductos = ObjDSProductos.Tables[0];
            dgvProductos.DataSource = dtProductos;
            BotonesInactivos();
        }

        private void cbxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBuscarP.Enabled = true;
        }

        private void btnBuscarV_Click(object sender, EventArgs e)
        {
            string dato = txtBuscarV.Text;
            string columna = cbxColumnaV.Text;
            Datos.Dal ObjDalVendedores = new Datos.Dal();
            DataSet ObjDSVendedores = new DataSet();
            ObjDSVendedores = ObjDalVendedores.BuscarVendedor(dato, columna);
            DataTable dtVendedores = ObjDSVendedores.Tables[0];
            dgvVendedores.DataSource = dtVendedores;
            BotonesInactivosV();
        }

        private void btnEliminarV_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(lblIndexV.Text);
            DialogResult result = MessageBox.Show("¿Eliminar el vendedor " + index + "?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Datos.Dal ObjDalVendedores = new Datos.Dal();
                ObjDalVendedores.EliminarVendedor(index);
                ActualizarVendedores();
                BotonesInactivosV();
            }
        }

        private void btnAgregarV_Click(object sender, EventArgs e)
        {
            Datos.Dal ObjDal = new Dal();
            if (txtNombreV.Text != string.Empty && txtApellidoV.Text != string.Empty && txtDniV.Text != string.Empty && mtbCuitV.Text != string.Empty)
            {
                DialogResult result = MessageBox.Show("¿Agregar vendedor a la base de datos?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    ObjDal.AgregarVendedor(txtNombreV.Text, txtApellidoV.Text, txtDniV.Text, mtbCuitV.Text);
                    LimpiarVendedor();
                    ActualizarVendedores();
                }
            }
            else
            {
                MessageBox.Show("Faltan completar datos.", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void BotonesBusquedaSi() 
        {
            gbxBusquedaV.Enabled = true;
            btnAgregarV.Enabled = true;
        }
        public void BotonesBusquedaNo()
        {
            gbxBusquedaV.Enabled = false;
            btnAgregarV.Enabled = false;
        }
        private void btnModificarV_Click(object sender, EventArgs e)
        {
            lblIndexV.Text = dgvVendedores.SelectedCells[0].Value.ToString();
            txtNombreV.Text = dgvVendedores.SelectedCells[1].Value.ToString();
            txtApellidoV.Text = dgvVendedores.SelectedCells[2].Value.ToString();
            txtDniV.Text = dgvVendedores.SelectedCells[3].Value.ToString();
            mtbCuitV.Text = dgvVendedores.SelectedCells[4].Value.ToString();
            BotonesInactivosV();
            BotonesModificarOkSiV();
            BotonesBusquedaNo();
        }

        private void dgvVendedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BotonesActivosV();
            if (e.RowIndex >= 0)  // evita los encabezados
            {
                int indice = e.RowIndex;
                var filaSeleccionada = dgvVendedores.Rows[indice];
                // Ejemplo de acceso a celdas
                lblIndexV.Text = filaSeleccionada.Cells["ID_VENDEDOR"].Value?.ToString();
            }
        }

        private void cbxColumnaV_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBuscarV.Enabled = true;
        }

        private void btnModificarOkV_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(lblIndexV.Text);
            DialogResult result = MessageBox.Show("¿Modificar el vendedor " + index + "?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Datos.Dal ObjProductos = new Datos.Dal();
                ObjProductos.ModificarVendedor(index, txtNombreV.Text, txtApellidoV.Text, txtDniV.Text, mtbCuitV.Text);
                ActualizarVendedores();
                BotonesModificarOkNoV();
                LimpiarVendedor();
                BotonesBusquedaSi();
            }
            else
            {
                LimpiarVendedor();
                BotonesInactivosV();
                BotonesModificarOkNoV();
                BotonesBusquedaSi();
                gbxBusquedaV.Enabled = true;
            }
        }
    }
}
