namespace Integrador2025
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            menuStrip1 = new MenuStrip();
            tsmArchivo = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            tbcPrincipal = new TabControl();
            tbcProducto = new TabPage();
            gbxDatosProducto = new GroupBox();
            dgvProductos = new DataGridView();
            gbxBusqueda = new GroupBox();
            btnCerrarBusqueda = new Button();
            txtBuscarP = new TextBox();
            cbxColumna = new ComboBox();
            pbxFotoproductoP = new PictureBox();
            lblNombreP = new Label();
            cbxCategoriaP = new ComboBox();
            lblDescripcionP = new Label();
            cbxSubcategoriaP = new ComboBox();
            lblCategoriaP = new Label();
            txtNombreP = new TextBox();
            lblPrecioVentaP = new Label();
            txtDescripcionP = new TextBox();
            lblMargenP = new Label();
            txtPrecioCostoP = new TextBox();
            lblPrecioBrutoP = new Label();
            txtPrecioBrutoP = new TextBox();
            lblIvaP = new Label();
            txtPrecioVentaP = new TextBox();
            lblProveedorP = new Label();
            txtProveedorP = new TextBox();
            lblPrecioCostoP = new Label();
            txtMargenP = new TextBox();
            lblSubcategoriaP = new Label();
            txtIvaP = new TextBox();
            gbxControles = new GroupBox();
            pbxLogo = new PictureBox();
            lblIndex = new Label();
            btnEliminarP = new Button();
            btnProductos = new Button();
            btnAgregarProductoP = new Button();
            btnModificarP = new Button();
            btnModificarOk = new Button();
            tbcVendedor = new TabPage();
            gbxVendedor = new GroupBox();
            dgvVendedores = new DataGridView();
            gbxBusquedaV = new GroupBox();
            btnBuscarV = new Button();
            txtBuscarV = new TextBox();
            cbxColumnaV = new ComboBox();
            pbxVendedor = new PictureBox();
            lblApellidoV = new Label();
            lblCuitV = new Label();
            mtbCuitV = new MaskedTextBox();
            lblDniV = new Label();
            txtNombreV = new TextBox();
            lblNombreV = new Label();
            txtApellidoV = new TextBox();
            txtDniV = new TextBox();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            lblIndexV = new Label();
            btnEliminarV = new Button();
            btnAgregarV = new Button();
            btnModificarV = new Button();
            btnModificarOkV = new Button();
            tbcClienteIndividuo = new TabPage();
            dgvClientes = new DataGridView();
            tbcClienteEmpresa = new TabPage();
            dgvEmpresas = new DataGridView();
            imageList1 = new ImageList(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            menuStrip1.SuspendLayout();
            tbcPrincipal.SuspendLayout();
            tbcProducto.SuspendLayout();
            gbxDatosProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            gbxBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxFotoproductoP).BeginInit();
            gbxControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxLogo).BeginInit();
            tbcVendedor.SuspendLayout();
            gbxVendedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVendedores).BeginInit();
            gbxBusquedaV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxVendedor).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tbcClienteIndividuo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            tbcClienteEmpresa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmpresas).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { tsmArchivo });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(899, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tsmArchivo
            // 
            tsmArchivo.DropDownItems.AddRange(new ToolStripItem[] { salirToolStripMenuItem });
            tsmArchivo.Name = "tsmArchivo";
            tsmArchivo.Size = new Size(60, 20);
            tsmArchivo.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Image = Properties.Resources.Close;
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.F4;
            salirToolStripMenuItem.Size = new Size(142, 22);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // tbcPrincipal
            // 
            tbcPrincipal.Controls.Add(tbcProducto);
            tbcPrincipal.Controls.Add(tbcVendedor);
            tbcPrincipal.Controls.Add(tbcClienteIndividuo);
            tbcPrincipal.Controls.Add(tbcClienteEmpresa);
            tbcPrincipal.Dock = DockStyle.Fill;
            tbcPrincipal.Font = new Font("Nirmala UI", 10F, FontStyle.Bold);
            tbcPrincipal.ImageList = imageList1;
            tbcPrincipal.ItemSize = new Size(190, 40);
            tbcPrincipal.Location = new Point(0, 24);
            tbcPrincipal.Name = "tbcPrincipal";
            tbcPrincipal.Padding = new Point(2, 2);
            tbcPrincipal.SelectedIndex = 0;
            tbcPrincipal.Size = new Size(899, 531);
            tbcPrincipal.SizeMode = TabSizeMode.Fixed;
            tbcPrincipal.TabIndex = 1;
            // 
            // tbcProducto
            // 
            tbcProducto.BackColor = Color.WhiteSmoke;
            tbcProducto.Controls.Add(gbxDatosProducto);
            tbcProducto.Controls.Add(gbxControles);
            tbcProducto.ImageKey = "Productos.ico";
            tbcProducto.Location = new Point(4, 44);
            tbcProducto.Name = "tbcProducto";
            tbcProducto.Size = new Size(891, 483);
            tbcProducto.TabIndex = 0;
            tbcProducto.Text = "Productos";
            // 
            // gbxDatosProducto
            // 
            gbxDatosProducto.Controls.Add(dgvProductos);
            gbxDatosProducto.Controls.Add(gbxBusqueda);
            gbxDatosProducto.Controls.Add(pbxFotoproductoP);
            gbxDatosProducto.Controls.Add(lblNombreP);
            gbxDatosProducto.Controls.Add(cbxCategoriaP);
            gbxDatosProducto.Controls.Add(lblDescripcionP);
            gbxDatosProducto.Controls.Add(cbxSubcategoriaP);
            gbxDatosProducto.Controls.Add(lblCategoriaP);
            gbxDatosProducto.Controls.Add(txtNombreP);
            gbxDatosProducto.Controls.Add(lblPrecioVentaP);
            gbxDatosProducto.Controls.Add(txtDescripcionP);
            gbxDatosProducto.Controls.Add(lblMargenP);
            gbxDatosProducto.Controls.Add(txtPrecioCostoP);
            gbxDatosProducto.Controls.Add(lblPrecioBrutoP);
            gbxDatosProducto.Controls.Add(txtPrecioBrutoP);
            gbxDatosProducto.Controls.Add(lblIvaP);
            gbxDatosProducto.Controls.Add(txtPrecioVentaP);
            gbxDatosProducto.Controls.Add(lblProveedorP);
            gbxDatosProducto.Controls.Add(txtProveedorP);
            gbxDatosProducto.Controls.Add(lblPrecioCostoP);
            gbxDatosProducto.Controls.Add(txtMargenP);
            gbxDatosProducto.Controls.Add(lblSubcategoriaP);
            gbxDatosProducto.Controls.Add(txtIvaP);
            gbxDatosProducto.Location = new Point(3, 3);
            gbxDatosProducto.Name = "gbxDatosProducto";
            gbxDatosProducto.Size = new Size(726, 472);
            gbxDatosProducto.TabIndex = 24;
            gbxDatosProducto.TabStop = false;
            gbxDatosProducto.Text = "Datos del Producto";
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.AllowUserToResizeRows = false;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvProductos.Location = new Point(0, 0);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Size = new Size(725, 421);
            dgvProductos.TabIndex = 22;
            dgvProductos.Visible = false;
            dgvProductos.CellMouseClick += dgvProductos_CellMouseClick;
            // 
            // gbxBusqueda
            // 
            gbxBusqueda.Controls.Add(btnCerrarBusqueda);
            gbxBusqueda.Controls.Add(txtBuscarP);
            gbxBusqueda.Controls.Add(cbxColumna);
            gbxBusqueda.Location = new Point(1, 417);
            gbxBusqueda.Name = "gbxBusqueda";
            gbxBusqueda.Size = new Size(725, 55);
            gbxBusqueda.TabIndex = 24;
            gbxBusqueda.TabStop = false;
            gbxBusqueda.Visible = false;
            // 
            // btnCerrarBusqueda
            // 
            btnCerrarBusqueda.BackColor = SystemColors.Highlight;
            btnCerrarBusqueda.FlatStyle = FlatStyle.Popup;
            btnCerrarBusqueda.Image = Properties.Resources.lupa;
            btnCerrarBusqueda.ImageAlign = ContentAlignment.BottomCenter;
            btnCerrarBusqueda.Location = new Point(683, 10);
            btnCerrarBusqueda.Name = "btnCerrarBusqueda";
            btnCerrarBusqueda.Size = new Size(42, 40);
            btnCerrarBusqueda.TabIndex = 30;
            btnCerrarBusqueda.TextAlign = ContentAlignment.TopCenter;
            btnCerrarBusqueda.UseVisualStyleBackColor = false;
            btnCerrarBusqueda.Click += btnCerrarBusqueda_Click;
            // 
            // txtBuscarP
            // 
            txtBuscarP.Enabled = false;
            txtBuscarP.Location = new Point(150, 24);
            txtBuscarP.Name = "txtBuscarP";
            txtBuscarP.Size = new Size(527, 25);
            txtBuscarP.TabIndex = 31;
            // 
            // cbxColumna
            // 
            cbxColumna.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxColumna.FormattingEnabled = true;
            cbxColumna.Items.AddRange(new object[] { "ID_PRODUCTO", "NOMBRE", "PROVEEDOR" });
            cbxColumna.Location = new Point(6, 25);
            cbxColumna.Name = "cbxColumna";
            cbxColumna.Size = new Size(133, 25);
            cbxColumna.TabIndex = 29;
            cbxColumna.SelectedIndexChanged += cbxCategoria_SelectedIndexChanged;
            // 
            // pbxFotoproductoP
            // 
            pbxFotoproductoP.BackColor = Color.Silver;
            pbxFotoproductoP.Image = Properties.Resources.Producto_SinFoto;
            pbxFotoproductoP.Location = new Point(457, 21);
            pbxFotoproductoP.Name = "pbxFotoproductoP";
            pbxFotoproductoP.Size = new Size(244, 149);
            pbxFotoproductoP.SizeMode = PictureBoxSizeMode.Zoom;
            pbxFotoproductoP.TabIndex = 20;
            pbxFotoproductoP.TabStop = false;
            // 
            // lblNombreP
            // 
            lblNombreP.AutoSize = true;
            lblNombreP.Font = new Font("Nirmala UI", 8F);
            lblNombreP.Location = new Point(15, 27);
            lblNombreP.Name = "lblNombreP";
            lblNombreP.Size = new Size(54, 13);
            lblNombreP.TabIndex = 0;
            lblNombreP.Text = "NOMBRE";
            // 
            // cbxCategoriaP
            // 
            cbxCategoriaP.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCategoriaP.FormattingEnabled = true;
            cbxCategoriaP.Items.AddRange(new object[] { "CATEGORÍA A", "CATEGORÍA B", "CATEGORÍA C" });
            cbxCategoriaP.Location = new Point(375, 341);
            cbxCategoriaP.Name = "cbxCategoriaP";
            cbxCategoriaP.Size = new Size(212, 25);
            cbxCategoriaP.TabIndex = 19;
            cbxCategoriaP.SelectedIndexChanged += cbxCategoriaP_SelectedIndexChanged;
            // 
            // lblDescripcionP
            // 
            lblDescripcionP.AutoSize = true;
            lblDescripcionP.Font = new Font("Nirmala UI", 8F);
            lblDescripcionP.Location = new Point(15, 224);
            lblDescripcionP.Name = "lblDescripcionP";
            lblDescripcionP.Size = new Size(77, 13);
            lblDescripcionP.TabIndex = 1;
            lblDescripcionP.Text = "DESCRIPCIÓN";
            // 
            // cbxSubcategoriaP
            // 
            cbxSubcategoriaP.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxSubcategoriaP.Enabled = false;
            cbxSubcategoriaP.FormattingEnabled = true;
            cbxSubcategoriaP.Location = new Point(375, 384);
            cbxSubcategoriaP.Name = "cbxSubcategoriaP";
            cbxSubcategoriaP.Size = new Size(212, 25);
            cbxSubcategoriaP.TabIndex = 18;
            // 
            // lblCategoriaP
            // 
            lblCategoriaP.AutoSize = true;
            lblCategoriaP.Font = new Font("Nirmala UI", 8F);
            lblCategoriaP.Location = new Point(272, 344);
            lblCategoriaP.Name = "lblCategoriaP";
            lblCategoriaP.Size = new Size(65, 13);
            lblCategoriaP.TabIndex = 2;
            lblCategoriaP.Text = "CATEGORÍA";
            // 
            // txtNombreP
            // 
            txtNombreP.Location = new Point(119, 21);
            txtNombreP.Name = "txtNombreP";
            txtNombreP.Size = new Size(315, 25);
            txtNombreP.TabIndex = 17;
            txtNombreP.KeyPress += txtNombreP_KeyPress;
            // 
            // lblPrecioVentaP
            // 
            lblPrecioVentaP.AutoSize = true;
            lblPrecioVentaP.Font = new Font("Nirmala UI", 8F);
            lblPrecioVentaP.Location = new Point(15, 347);
            lblPrecioVentaP.Name = "lblPrecioVentaP";
            lblPrecioVentaP.Size = new Size(80, 13);
            lblPrecioVentaP.TabIndex = 3;
            lblPrecioVentaP.Text = "PRECIO VENTA";
            // 
            // txtDescripcionP
            // 
            txtDescripcionP.Location = new Point(119, 224);
            txtDescripcionP.Multiline = true;
            txtDescripcionP.Name = "txtDescripcionP";
            txtDescripcionP.Size = new Size(582, 101);
            txtDescripcionP.TabIndex = 16;
            txtDescripcionP.KeyPress += txtDescripcionP_KeyPress;
            // 
            // lblMargenP
            // 
            lblMargenP.AutoSize = true;
            lblMargenP.Font = new Font("Nirmala UI", 8F);
            lblMargenP.Location = new Point(15, 105);
            lblMargenP.Name = "lblMargenP";
            lblMargenP.Size = new Size(53, 13);
            lblMargenP.TabIndex = 4;
            lblMargenP.Text = "MARGEN";
            // 
            // txtPrecioCostoP
            // 
            txtPrecioCostoP.Location = new Point(119, 60);
            txtPrecioCostoP.Name = "txtPrecioCostoP";
            txtPrecioCostoP.Size = new Size(315, 25);
            txtPrecioCostoP.TabIndex = 15;
            txtPrecioCostoP.KeyPress += txtPrecioCostoP_KeyPress;
            // 
            // lblPrecioBrutoP
            // 
            lblPrecioBrutoP.AutoSize = true;
            lblPrecioBrutoP.Font = new Font("Nirmala UI", 8F);
            lblPrecioBrutoP.Location = new Point(15, 183);
            lblPrecioBrutoP.Name = "lblPrecioBrutoP";
            lblPrecioBrutoP.Size = new Size(84, 13);
            lblPrecioBrutoP.TabIndex = 5;
            lblPrecioBrutoP.Text = "PRECIO BRUTO";
            // 
            // txtPrecioBrutoP
            // 
            txtPrecioBrutoP.Location = new Point(119, 177);
            txtPrecioBrutoP.Name = "txtPrecioBrutoP";
            txtPrecioBrutoP.Size = new Size(315, 25);
            txtPrecioBrutoP.TabIndex = 14;
            txtPrecioBrutoP.KeyPress += txtPrecioBrutoP_KeyPress;
            // 
            // lblIvaP
            // 
            lblIvaP.AutoSize = true;
            lblIvaP.Font = new Font("Nirmala UI", 8F);
            lblIvaP.Location = new Point(15, 387);
            lblIvaP.Name = "lblIvaP";
            lblIvaP.Size = new Size(23, 13);
            lblIvaP.TabIndex = 6;
            lblIvaP.Text = "IVA";
            // 
            // txtPrecioVentaP
            // 
            txtPrecioVentaP.Location = new Point(119, 338);
            txtPrecioVentaP.Name = "txtPrecioVentaP";
            txtPrecioVentaP.Size = new Size(125, 25);
            txtPrecioVentaP.TabIndex = 13;
            txtPrecioVentaP.KeyPress += txtPrecioVentaP_KeyPress;
            // 
            // lblProveedorP
            // 
            lblProveedorP.AutoSize = true;
            lblProveedorP.Font = new Font("Nirmala UI", 8F);
            lblProveedorP.Location = new Point(15, 144);
            lblProveedorP.Name = "lblProveedorP";
            lblProveedorP.Size = new Size(72, 13);
            lblProveedorP.TabIndex = 7;
            lblProveedorP.Text = "PROVEEDOR";
            // 
            // txtProveedorP
            // 
            txtProveedorP.Location = new Point(119, 138);
            txtProveedorP.Name = "txtProveedorP";
            txtProveedorP.Size = new Size(315, 25);
            txtProveedorP.TabIndex = 12;
            txtProveedorP.KeyPress += txtProveedorP_KeyPress;
            // 
            // lblPrecioCostoP
            // 
            lblPrecioCostoP.AutoSize = true;
            lblPrecioCostoP.Font = new Font("Nirmala UI", 8F);
            lblPrecioCostoP.Location = new Point(15, 65);
            lblPrecioCostoP.Name = "lblPrecioCostoP";
            lblPrecioCostoP.Size = new Size(84, 13);
            lblPrecioCostoP.TabIndex = 8;
            lblPrecioCostoP.Text = "PRECIO COSTO";
            // 
            // txtMargenP
            // 
            txtMargenP.Location = new Point(119, 99);
            txtMargenP.Name = "txtMargenP";
            txtMargenP.Size = new Size(315, 25);
            txtMargenP.TabIndex = 11;
            txtMargenP.KeyPress += txtMargenP_KeyPress;
            // 
            // lblSubcategoriaP
            // 
            lblSubcategoriaP.AutoSize = true;
            lblSubcategoriaP.Font = new Font("Nirmala UI", 8F);
            lblSubcategoriaP.Location = new Point(272, 390);
            lblSubcategoriaP.Name = "lblSubcategoriaP";
            lblSubcategoriaP.Size = new Size(86, 13);
            lblSubcategoriaP.TabIndex = 9;
            lblSubcategoriaP.Text = "SUBCATEGORÍA";
            // 
            // txtIvaP
            // 
            txtIvaP.Location = new Point(119, 381);
            txtIvaP.Name = "txtIvaP";
            txtIvaP.Size = new Size(125, 25);
            txtIvaP.TabIndex = 10;
            txtIvaP.KeyPress += txtIvaP_KeyPress;
            // 
            // gbxControles
            // 
            gbxControles.Controls.Add(pbxLogo);
            gbxControles.Controls.Add(lblIndex);
            gbxControles.Controls.Add(btnEliminarP);
            gbxControles.Controls.Add(btnProductos);
            gbxControles.Controls.Add(btnAgregarProductoP);
            gbxControles.Controls.Add(btnModificarP);
            gbxControles.Controls.Add(btnModificarOk);
            gbxControles.Location = new Point(735, 3);
            gbxControles.Name = "gbxControles";
            gbxControles.Size = new Size(153, 480);
            gbxControles.TabIndex = 24;
            gbxControles.TabStop = false;
            gbxControles.Text = "Controles";
            // 
            // pbxLogo
            // 
            pbxLogo.Image = Properties.Resources.solutions;
            pbxLogo.Location = new Point(0, 418);
            pbxLogo.Name = "pbxLogo";
            pbxLogo.Size = new Size(153, 61);
            pbxLogo.TabIndex = 29;
            pbxLogo.TabStop = false;
            // 
            // lblIndex
            // 
            lblIndex.AutoSize = true;
            lblIndex.Location = new Point(0, 346);
            lblIndex.Name = "lblIndex";
            lblIndex.Size = new Size(50, 19);
            lblIndex.TabIndex = 25;
            lblIndex.Text = "label1";
            lblIndex.Visible = false;
            // 
            // btnEliminarP
            // 
            btnEliminarP.Cursor = Cursors.Hand;
            btnEliminarP.Enabled = false;
            btnEliminarP.Image = Properties.Resources.Close;
            btnEliminarP.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminarP.Location = new Point(20, 285);
            btnEliminarP.Name = "btnEliminarP";
            btnEliminarP.Size = new Size(115, 51);
            btnEliminarP.TabIndex = 24;
            btnEliminarP.Text = "Eliminar";
            btnEliminarP.TextAlign = ContentAlignment.MiddleRight;
            btnEliminarP.UseVisualStyleBackColor = true;
            btnEliminarP.Click += btnEliminar_Click;
            // 
            // btnProductos
            // 
            btnProductos.Cursor = Cursors.Hand;
            btnProductos.Image = Properties.Resources.list;
            btnProductos.ImageAlign = ContentAlignment.MiddleLeft;
            btnProductos.Location = new Point(20, 45);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(115, 51);
            btnProductos.TabIndex = 21;
            btnProductos.Text = "Productos";
            btnProductos.TextAlign = ContentAlignment.MiddleRight;
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnAgregarProductoP
            // 
            btnAgregarProductoP.Cursor = Cursors.Hand;
            btnAgregarProductoP.Image = Properties.Resources.add;
            btnAgregarProductoP.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregarProductoP.Location = new Point(20, 125);
            btnAgregarProductoP.Name = "btnAgregarProductoP";
            btnAgregarProductoP.Size = new Size(115, 51);
            btnAgregarProductoP.TabIndex = 23;
            btnAgregarProductoP.Text = "Agregar";
            btnAgregarProductoP.TextAlign = ContentAlignment.MiddleRight;
            btnAgregarProductoP.UseVisualStyleBackColor = true;
            btnAgregarProductoP.Click += btnAgregarProducto_Click;
            // 
            // btnModificarP
            // 
            btnModificarP.Enabled = false;
            btnModificarP.Image = Properties.Resources.anotador;
            btnModificarP.ImageAlign = ContentAlignment.MiddleLeft;
            btnModificarP.Location = new Point(20, 205);
            btnModificarP.Name = "btnModificarP";
            btnModificarP.Size = new Size(115, 51);
            btnModificarP.TabIndex = 26;
            btnModificarP.Text = "Modificar";
            btnModificarP.TextAlign = ContentAlignment.MiddleRight;
            btnModificarP.UseVisualStyleBackColor = true;
            btnModificarP.Click += btnModificar_Click;
            // 
            // btnModificarOk
            // 
            btnModificarOk.Cursor = Cursors.Hand;
            btnModificarOk.Image = (Image)resources.GetObject("btnModificarOk.Image");
            btnModificarOk.ImageAlign = ContentAlignment.MiddleLeft;
            btnModificarOk.Location = new Point(20, 205);
            btnModificarOk.Name = "btnModificarOk";
            btnModificarOk.Size = new Size(115, 51);
            btnModificarOk.TabIndex = 27;
            btnModificarOk.Text = "Modificar";
            btnModificarOk.TextAlign = ContentAlignment.MiddleRight;
            btnModificarOk.UseVisualStyleBackColor = true;
            btnModificarOk.Visible = false;
            btnModificarOk.Click += btnModificarOk_Click;
            // 
            // tbcVendedor
            // 
            tbcVendedor.Controls.Add(gbxVendedor);
            tbcVendedor.Controls.Add(groupBox1);
            tbcVendedor.ImageKey = "Vendedores.ico";
            tbcVendedor.Location = new Point(4, 44);
            tbcVendedor.Name = "tbcVendedor";
            tbcVendedor.Size = new Size(891, 483);
            tbcVendedor.TabIndex = 1;
            tbcVendedor.Text = "Vendedores";
            tbcVendedor.UseVisualStyleBackColor = true;
            // 
            // gbxVendedor
            // 
            gbxVendedor.Controls.Add(dgvVendedores);
            gbxVendedor.Controls.Add(gbxBusquedaV);
            gbxVendedor.Controls.Add(pbxVendedor);
            gbxVendedor.Controls.Add(lblApellidoV);
            gbxVendedor.Controls.Add(lblCuitV);
            gbxVendedor.Controls.Add(mtbCuitV);
            gbxVendedor.Controls.Add(lblDniV);
            gbxVendedor.Controls.Add(txtNombreV);
            gbxVendedor.Controls.Add(lblNombreV);
            gbxVendedor.Controls.Add(txtApellidoV);
            gbxVendedor.Controls.Add(txtDniV);
            gbxVendedor.Location = new Point(3, 3);
            gbxVendedor.Name = "gbxVendedor";
            gbxVendedor.Size = new Size(726, 480);
            gbxVendedor.TabIndex = 26;
            gbxVendedor.TabStop = false;
            gbxVendedor.Text = "Datos del Vendedor";
            // 
            // dgvVendedores
            // 
            dgvVendedores.AllowUserToAddRows = false;
            dgvVendedores.AllowUserToDeleteRows = false;
            dgvVendedores.AllowUserToResizeRows = false;
            dgvVendedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvVendedores.Location = new Point(67, 164);
            dgvVendedores.Name = "dgvVendedores";
            dgvVendedores.ReadOnly = true;
            dgvVendedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVendedores.Size = new Size(600, 263);
            dgvVendedores.TabIndex = 26;
            dgvVendedores.Visible = false;
            dgvVendedores.CellContentClick += dgvVendedores_CellContentClick;
            // 
            // gbxBusquedaV
            // 
            gbxBusquedaV.Controls.Add(btnBuscarV);
            gbxBusquedaV.Controls.Add(txtBuscarV);
            gbxBusquedaV.Controls.Add(cbxColumnaV);
            gbxBusquedaV.Location = new Point(0, 423);
            gbxBusquedaV.Name = "gbxBusquedaV";
            gbxBusquedaV.Size = new Size(725, 55);
            gbxBusquedaV.TabIndex = 25;
            gbxBusquedaV.TabStop = false;
            // 
            // btnBuscarV
            // 
            btnBuscarV.BackColor = SystemColors.Highlight;
            btnBuscarV.FlatStyle = FlatStyle.Popup;
            btnBuscarV.Image = Properties.Resources.lupa;
            btnBuscarV.ImageAlign = ContentAlignment.BottomCenter;
            btnBuscarV.Location = new Point(683, 10);
            btnBuscarV.Name = "btnBuscarV";
            btnBuscarV.Size = new Size(42, 40);
            btnBuscarV.TabIndex = 30;
            btnBuscarV.TextAlign = ContentAlignment.TopCenter;
            btnBuscarV.UseVisualStyleBackColor = false;
            btnBuscarV.Click += btnBuscarV_Click;
            // 
            // txtBuscarV
            // 
            txtBuscarV.Enabled = false;
            txtBuscarV.Location = new Point(150, 24);
            txtBuscarV.Name = "txtBuscarV";
            txtBuscarV.Size = new Size(527, 25);
            txtBuscarV.TabIndex = 31;
            // 
            // cbxColumnaV
            // 
            cbxColumnaV.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxColumnaV.FormattingEnabled = true;
            cbxColumnaV.Items.AddRange(new object[] { "ID_VENDEDOR", "NOMBRE", "APELLIDO", "DNI" });
            cbxColumnaV.Location = new Point(6, 25);
            cbxColumnaV.Name = "cbxColumnaV";
            cbxColumnaV.Size = new Size(133, 25);
            cbxColumnaV.TabIndex = 29;
            cbxColumnaV.SelectedIndexChanged += cbxColumnaV_SelectedIndexChanged;
            // 
            // pbxVendedor
            // 
            pbxVendedor.BackColor = Color.Silver;
            pbxVendedor.Image = Properties.Resources.Vendedor_SinFoto;
            pbxVendedor.Location = new Point(502, 37);
            pbxVendedor.Name = "pbxVendedor";
            pbxVendedor.Size = new Size(206, 121);
            pbxVendedor.SizeMode = PictureBoxSizeMode.Zoom;
            pbxVendedor.TabIndex = 22;
            pbxVendedor.TabStop = false;
            // 
            // lblApellidoV
            // 
            lblApellidoV.AutoSize = true;
            lblApellidoV.Font = new Font("Nirmala UI", 8F);
            lblApellidoV.Location = new Point(17, 77);
            lblApellidoV.Name = "lblApellidoV";
            lblApellidoV.Size = new Size(56, 13);
            lblApellidoV.TabIndex = 1;
            lblApellidoV.Text = "APELLIDO";
            // 
            // lblCuitV
            // 
            lblCuitV.AutoSize = true;
            lblCuitV.Font = new Font("Nirmala UI", 8F);
            lblCuitV.Location = new Point(17, 139);
            lblCuitV.Name = "lblCuitV";
            lblCuitV.Size = new Size(30, 13);
            lblCuitV.TabIndex = 2;
            lblCuitV.Text = "CUIT";
            // 
            // mtbCuitV
            // 
            mtbCuitV.Font = new Font("Nirmala UI", 10F, FontStyle.Bold);
            mtbCuitV.Location = new Point(82, 133);
            mtbCuitV.Mask = "99-99999999-9";
            mtbCuitV.Name = "mtbCuitV";
            mtbCuitV.Size = new Size(120, 25);
            mtbCuitV.TabIndex = 21;
            mtbCuitV.TextAlign = HorizontalAlignment.Center;
            // 
            // lblDniV
            // 
            lblDniV.AutoSize = true;
            lblDniV.Font = new Font("Nirmala UI", 8F);
            lblDniV.Location = new Point(17, 108);
            lblDniV.Name = "lblDniV";
            lblDniV.Size = new Size(26, 13);
            lblDniV.TabIndex = 3;
            lblDniV.Text = "DNI";
            // 
            // txtNombreV
            // 
            txtNombreV.Location = new Point(82, 37);
            txtNombreV.MaxLength = 50;
            txtNombreV.Name = "txtNombreV";
            txtNombreV.Size = new Size(400, 25);
            txtNombreV.TabIndex = 20;
            txtNombreV.KeyPress += txtNombreV_KeyPress;
            // 
            // lblNombreV
            // 
            lblNombreV.AutoSize = true;
            lblNombreV.Font = new Font("Nirmala UI", 8F);
            lblNombreV.Location = new Point(17, 43);
            lblNombreV.Name = "lblNombreV";
            lblNombreV.Size = new Size(54, 13);
            lblNombreV.TabIndex = 4;
            lblNombreV.Text = "NOMBRE";
            // 
            // txtApellidoV
            // 
            txtApellidoV.Location = new Point(82, 71);
            txtApellidoV.MaxLength = 50;
            txtApellidoV.Name = "txtApellidoV";
            txtApellidoV.Size = new Size(400, 25);
            txtApellidoV.TabIndex = 19;
            txtApellidoV.KeyPress += txtApellidoV_KeyPress;
            // 
            // txtDniV
            // 
            txtDniV.Location = new Point(82, 102);
            txtDniV.MaxLength = 8;
            txtDniV.Name = "txtDniV";
            txtDniV.Size = new Size(120, 25);
            txtDniV.TabIndex = 18;
            txtDniV.TextAlign = HorizontalAlignment.Center;
            txtDniV.KeyPress += txtDniV_KeyPress;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(lblIndexV);
            groupBox1.Controls.Add(btnEliminarV);
            groupBox1.Controls.Add(btnAgregarV);
            groupBox1.Controls.Add(btnModificarV);
            groupBox1.Controls.Add(btnModificarOkV);
            groupBox1.Location = new Point(735, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(153, 480);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            groupBox1.Text = "Controles";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.solutions;
            pictureBox1.Location = new Point(0, 417);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(153, 61);
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // lblIndexV
            // 
            lblIndexV.AutoSize = true;
            lblIndexV.Location = new Point(20, 363);
            lblIndexV.Name = "lblIndexV";
            lblIndexV.Size = new Size(50, 19);
            lblIndexV.TabIndex = 25;
            lblIndexV.Text = "label1";
            lblIndexV.Visible = false;
            // 
            // btnEliminarV
            // 
            btnEliminarV.Cursor = Cursors.Hand;
            btnEliminarV.Enabled = false;
            btnEliminarV.Image = Properties.Resources.Close;
            btnEliminarV.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminarV.Location = new Point(20, 277);
            btnEliminarV.Name = "btnEliminarV";
            btnEliminarV.Size = new Size(115, 51);
            btnEliminarV.TabIndex = 24;
            btnEliminarV.Text = "Eliminar";
            btnEliminarV.TextAlign = ContentAlignment.MiddleRight;
            btnEliminarV.UseVisualStyleBackColor = true;
            btnEliminarV.Click += btnEliminarV_Click;
            // 
            // btnAgregarV
            // 
            btnAgregarV.Cursor = Cursors.Hand;
            btnAgregarV.Image = Properties.Resources.add;
            btnAgregarV.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregarV.Location = new Point(20, 37);
            btnAgregarV.Name = "btnAgregarV";
            btnAgregarV.Size = new Size(115, 51);
            btnAgregarV.TabIndex = 23;
            btnAgregarV.Text = "Agregar";
            btnAgregarV.TextAlign = ContentAlignment.MiddleRight;
            btnAgregarV.UseVisualStyleBackColor = true;
            btnAgregarV.Click += btnAgregarV_Click;
            // 
            // btnModificarV
            // 
            btnModificarV.Enabled = false;
            btnModificarV.Image = Properties.Resources.anotador;
            btnModificarV.ImageAlign = ContentAlignment.MiddleLeft;
            btnModificarV.Location = new Point(20, 157);
            btnModificarV.Name = "btnModificarV";
            btnModificarV.Size = new Size(115, 51);
            btnModificarV.TabIndex = 26;
            btnModificarV.Text = "Modificar";
            btnModificarV.TextAlign = ContentAlignment.MiddleRight;
            btnModificarV.UseVisualStyleBackColor = true;
            btnModificarV.Click += btnModificarV_Click;
            // 
            // btnModificarOkV
            // 
            btnModificarOkV.Cursor = Cursors.Hand;
            btnModificarOkV.Image = (Image)resources.GetObject("btnModificarOkV.Image");
            btnModificarOkV.ImageAlign = ContentAlignment.MiddleLeft;
            btnModificarOkV.Location = new Point(20, 157);
            btnModificarOkV.Name = "btnModificarOkV";
            btnModificarOkV.Size = new Size(115, 51);
            btnModificarOkV.TabIndex = 27;
            btnModificarOkV.Text = "Modificar";
            btnModificarOkV.TextAlign = ContentAlignment.MiddleRight;
            btnModificarOkV.UseVisualStyleBackColor = true;
            btnModificarOkV.Visible = false;
            btnModificarOkV.Click += btnModificarOkV_Click;
            // 
            // tbcClienteIndividuo
            // 
            tbcClienteIndividuo.Controls.Add(dgvClientes);
            tbcClienteIndividuo.ImageKey = "Clientes.ico";
            tbcClienteIndividuo.Location = new Point(4, 44);
            tbcClienteIndividuo.Name = "tbcClienteIndividuo";
            tbcClienteIndividuo.Size = new Size(891, 483);
            tbcClienteIndividuo.TabIndex = 2;
            tbcClienteIndividuo.Text = "Clientes";
            tbcClienteIndividuo.UseVisualStyleBackColor = true;
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.AllowUserToResizeRows = false;
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvClientes.Location = new Point(3, 3);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new Size(888, 480);
            dgvClientes.TabIndex = 0;
            // 
            // tbcClienteEmpresa
            // 
            tbcClienteEmpresa.Controls.Add(dgvEmpresas);
            tbcClienteEmpresa.ImageKey = "Empresas.ico";
            tbcClienteEmpresa.Location = new Point(4, 44);
            tbcClienteEmpresa.Name = "tbcClienteEmpresa";
            tbcClienteEmpresa.Size = new Size(891, 483);
            tbcClienteEmpresa.TabIndex = 3;
            tbcClienteEmpresa.Text = "Empresas";
            tbcClienteEmpresa.UseVisualStyleBackColor = true;
            // 
            // dgvEmpresas
            // 
            dgvEmpresas.AllowUserToAddRows = false;
            dgvEmpresas.AllowUserToDeleteRows = false;
            dgvEmpresas.AllowUserToResizeRows = false;
            dgvEmpresas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvEmpresas.Location = new Point(3, 3);
            dgvEmpresas.Name = "dgvEmpresas";
            dgvEmpresas.ReadOnly = true;
            dgvEmpresas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmpresas.Size = new Size(888, 480);
            dgvEmpresas.TabIndex = 1;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "Productos.ico");
            imageList1.Images.SetKeyName(1, "Vendedores.ico");
            imageList1.Images.SetKeyName(2, "Clientes.ico");
            imageList1.Images.SetKeyName(3, "Empresas.ico");
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(899, 555);
            Controls.Add(tbcPrincipal);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "INSUMOS DE COMPUTACIÓN";
            Load += frmPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tbcPrincipal.ResumeLayout(false);
            tbcProducto.ResumeLayout(false);
            gbxDatosProducto.ResumeLayout(false);
            gbxDatosProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            gbxBusqueda.ResumeLayout(false);
            gbxBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxFotoproductoP).EndInit();
            gbxControles.ResumeLayout(false);
            gbxControles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxLogo).EndInit();
            tbcVendedor.ResumeLayout(false);
            gbxVendedor.ResumeLayout(false);
            gbxVendedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVendedores).EndInit();
            gbxBusquedaV.ResumeLayout(false);
            gbxBusquedaV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxVendedor).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tbcClienteIndividuo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            tbcClienteEmpresa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEmpresas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tsmArchivo;
        private TabControl tbcPrincipal;
        private TabPage tbcProducto;
        private TabPage tbcVendedor;
        private TabPage tbcClienteIndividuo;
        private TabPage tbcClienteEmpresa;
        private ImageList imageList1;
        private Label lblPrecioCostoP;
        private Label lblProveedorP;
        private Label lblIvaP;
        private Label lblPrecioBrutoP;
        private Label lblMargenP;
        private Label lblPrecioVentaP;
        private Label lblCategoriaP;
        private Label lblDescripcionP;
        private Label lblNombreP;
        private Label lblSubcategoriaP;
        private ComboBox cbxCategoriaP;
        private ComboBox cbxSubcategoriaP;
        private TextBox txtNombreP;
        private TextBox txtDescripcionP;
        private TextBox txtPrecioCostoP;
        private TextBox txtPrecioBrutoP;
        private TextBox txtPrecioVentaP;
        private TextBox txtProveedorP;
        private TextBox txtMargenP;
        private TextBox txtIvaP;
        private PictureBox pbxFotoproductoP;
        private Label lblNombreV;
        private Label lblDniV;
        private Label lblCuitV;
        private Label lblApellidoV;
        private MaskedTextBox mtbCuitV;
        private TextBox txtNombreV;
        private TextBox txtApellidoV;
        private TextBox txtDniV;
        private PictureBox pbxVendedor;
        private ToolStripMenuItem salirToolStripMenuItem;
        private DataGridView dgvClientes;
        private DataGridView dgvEmpresas;
        private Button btnProductos;
        private ContextMenuStrip contextMenuStrip1;
        private Button btnAgregarProductoP;
        private GroupBox gbxControles;
        private GroupBox gbxDatosProducto;
        private Button btnEliminarP;
        private Label lblIndex;
        private Button btnModificarP;
        private Button btnModificarOk;
        private Button btnCerrarBusqueda;
        private ComboBox cbxColumna;
        private GroupBox gbxBusqueda;
        private TextBox txtBuscarP;
        private PictureBox pbxLogo;
        private DataGridView dgvProductos;
        private GroupBox gbxVendedor;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private Label lblIndexV;
        private Button btnEliminarV;
        private Button btnAgregarV;
        private Button btnModificarV;
        private Button btnModificarOkV;
        private DataGridView dgvVendedores;
        private GroupBox gbxBusquedaV;
        private Button btnBuscarV;
        private TextBox txtBuscarV;
        private ComboBox cbxColumnaV;
    }
}
