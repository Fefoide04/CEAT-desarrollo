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
    public partial class frm_visualizacionEstudiantes : Form
    {
        public frm_visualizacionEstudiantes()
        {
            InitializeComponent();
        }

        private void btn_irConsultas_Click(object sender, EventArgs e)
        {
            metodos.cambiarFormulario(metodos.devolverFormularioPorCadena(btn_irConsultas.Tag.ToString()), variables.panelPrincipal);
        }

        private void btn_agregarEstudiantes_Click(object sender, EventArgs e)
        {
            metodos.cambiarFormulario(metodos.devolverFormularioPorCadena(btn_agregarEstudiantes.Tag.ToString()), variables.panelPrincipal);
        }
    }
}
