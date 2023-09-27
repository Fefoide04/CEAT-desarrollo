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
    public partial class frm_seleccionarTipoReporte : Form
    {
        public frm_seleccionarTipoReporte()
        {
            InitializeComponent();

            btn_reporteGeneral.BackColor = variables.colores.primaryHighlightColor;
            btn_listado.BackColor = variables.colores.primaryBaseColor;
            btn_regresar.BackColor = variables.colores.primarySelectedColor;
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            metodos.cambiarFormulario(metodos.devolverFormularioPorCadena(btn_regresar.Tag.ToString()), variables.panelPrincipal);
        }

        private void btn_reporteGeneral_Click(object sender, EventArgs e)
        {
            metodos.cambiarFormulario(metodos.devolverFormularioPorCadena(btn_reporteGeneral.Tag.ToString()), variables.panelPrincipal);
        }
    }
}
