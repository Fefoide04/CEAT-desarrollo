using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Interfaces
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        comandosBD claseConexion = new comandosBD();

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtContrasena.UseSystemPasswordChar = true;
        }

        bool valida = false;
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            valida = claseConexion.IniciarSesion(txtUsuario.Text, txtContrasena.Text);

            if (valida == true)
            {
                LimpiarTextbox();

                lblError.Visible = false;
                Form frmPrincipal = new frm_principal();
                frmPrincipal.Show();
                frmPrincipal.FormClosed += CerrarSesion;
                this.Hide();

            }
            else
            {
                lblError.Visible = true;                
            }
        }

        private void CerrarSesion(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        //Limpia los txt
        public void LimpiarTextbox()
        {
            txtUsuario.Clear();
            txtContrasena.Clear();
        }

        //Si pulsa Enter dentro txtContrasena se presiona automaticamente el boton btnIniciarSesion
        private void txtContrasena_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(13))
            {
                btnIniciarSesion.PerformClick();
            }
        }



    } 



}
