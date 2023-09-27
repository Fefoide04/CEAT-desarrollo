namespace Interfaces
{
    partial class frm_relevamientoRA
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtg_relevamientoCaracterizacion = new System.Windows.Forms.DataGridView();
            this.pnl_encabezadoRelevamientoRA = new System.Windows.Forms.Panel();
            this.dtg_relevamientoTurno = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_relevamientoCaracterizacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_relevamientoTurno)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_relevamientoCaracterizacion
            // 
            this.dtg_relevamientoCaracterizacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_relevamientoCaracterizacion.Location = new System.Drawing.Point(29, 121);
            this.dtg_relevamientoCaracterizacion.Name = "dtg_relevamientoCaracterizacion";
            this.dtg_relevamientoCaracterizacion.Size = new System.Drawing.Size(383, 317);
            this.dtg_relevamientoCaracterizacion.TabIndex = 0;
            // 
            // pnl_encabezadoRelevamientoRA
            // 
            this.pnl_encabezadoRelevamientoRA.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_encabezadoRelevamientoRA.Location = new System.Drawing.Point(0, 0);
            this.pnl_encabezadoRelevamientoRA.Name = "pnl_encabezadoRelevamientoRA";
            this.pnl_encabezadoRelevamientoRA.Size = new System.Drawing.Size(880, 100);
            this.pnl_encabezadoRelevamientoRA.TabIndex = 1;
            // 
            // dtg_relevamientoTurno
            // 
            this.dtg_relevamientoTurno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_relevamientoTurno.Location = new System.Drawing.Point(447, 121);
            this.dtg_relevamientoTurno.Name = "dtg_relevamientoTurno";
            this.dtg_relevamientoTurno.Size = new System.Drawing.Size(203, 317);
            this.dtg_relevamientoTurno.TabIndex = 2;
            // 
            // frm_relevamientoRA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 530);
            this.Controls.Add(this.dtg_relevamientoTurno);
            this.Controls.Add(this.pnl_encabezadoRelevamientoRA);
            this.Controls.Add(this.dtg_relevamientoCaracterizacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_relevamientoRA";
            this.Text = "frm_relevamientoRA";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_relevamientoCaracterizacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_relevamientoTurno)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_relevamientoCaracterizacion;
        private System.Windows.Forms.Panel pnl_encabezadoRelevamientoRA;
        private System.Windows.Forms.DataGridView dtg_relevamientoTurno;
    }
}