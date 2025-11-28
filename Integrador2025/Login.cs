using Integrador2025.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integrador2025
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        public int contador = 3;
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string Usuario = txtUsuario.Text;
            string Password = txtPassword.Text;

            if (Usuario != string.Empty && Password != string.Empty)
            {
                Datos.Dal ObjDal = new Datos.Dal();
                DataSet ObjDS = new DataSet();
                ObjDS = ObjDal.Login(txtUsuario.Text, txtPassword.Text);
                DataTable dtUsuarios = ObjDS.Tables[0];

                if (contador > 0)
                {
                    if (dtUsuarios.Rows.Count == 0)
                    {
                        MessageBox.Show("Datos incorrectos, intente nuevamente.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        contador--;
                    }
                    else
                    {
                        frmPrincipal ObjPrincipal = new frmPrincipal();
                        ObjPrincipal.ShowDialog();
                        LimpiarLogin();
                    }
                }
                else
                {
                    MessageBox.Show("Programa bloqueado, contacte con el administrador.", "ERROR FATAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsuario.Enabled = false;
                    txtPassword.Enabled = false;
                    btnIniciarSesion.Enabled = false;
                    btnRegistrar.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Por favor, complete los campos.", "ERROR", MessageBoxButtons.OK);
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            frmPrincipal funciones = new frmPrincipal();
            funciones.SoloLetras(e);
            funciones.Mayuscula(e);
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            frmPrincipal funciones = new frmPrincipal();
            funciones.Mayuscula(e);
        }

        public void LimpiarLogin()
        {
            txtUsuario.Text = null;
            txtPassword.Text = null;
            txtPassValidar.Text = null;
            txtNombre.Text = null;
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            btnRegistrar.Visible = false;
            btnCancelar.Visible = true;
            btnIniciarSesion.Visible = false;
            btnRegistrarOk.Visible = true;
            txtPassValidar.Visible = true;
            txtNombre.Visible = true;
            LimpiarLogin();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnRegistrar.Visible = true;
            btnCancelar.Visible = false;
            btnIniciarSesion.Visible = true;
            btnRegistrarOk.Visible = false;
            txtPassValidar.Visible = false;
            txtNombre.Visible = false;
            LimpiarLogin();
        }

        private void btnRegistrarOk_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != string.Empty && txtUsuario.Text != string.Empty && txtPassword.Text != string.Empty && txtPassValidar.Text != string.Empty)
            {
                if (txtPassword.Text == txtPassValidar.Text)
                {
                    Dal usuario = new Dal();
                    usuario.Registrar(txtUsuario.Text, txtNombre.Text, txtPassword.Text, lblFecha.Text);
                    LimpiarLogin();
                    MessageBox.Show("Usuario creado exitosamente.", "REGISTRO", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("No coincide la contraseña.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            } else
            {
                MessageBox.Show("Complete los datos, por favor.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            frmPrincipal funciones = new frmPrincipal();
            funciones.SoloLetras(e);
            funciones.Mayuscula(e);
        }

        private void txtPassValidar_KeyPress(object sender, KeyPressEventArgs e)
        {
            frmPrincipal funciones = new frmPrincipal();
            funciones.Mayuscula(e);
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString();
        }
    }
}
