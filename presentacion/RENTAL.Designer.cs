namespace presentacion
{
    partial class RENTAL
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvRental = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblCheckIn = new System.Windows.Forms.Label();
            this.lblCheckOut = new System.Windows.Forms.Label();
            this.lblSpot = new System.Windows.Forms.Label();
            this.lblImporte = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.dtpCheckOut = new System.Windows.Forms.DateTimePicker();
            this.cboSpot = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRental)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRental
            // 
            this.dgvRental.BackgroundColor = System.Drawing.Color.SlateGray;
            this.dgvRental.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRental.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Meiryo UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRental.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRental.GridColor = System.Drawing.Color.PowderBlue;
            this.dgvRental.Location = new System.Drawing.Point(13, 23);
            this.dgvRental.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvRental.Name = "dgvRental";
            this.dgvRental.Size = new System.Drawing.Size(607, 162);
            this.dgvRental.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(657, 297);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(88, 25);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(922, 297);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(88, 25);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(657, 23);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(48, 14);
            this.lblCliente.TabIndex = 6;
            this.lblCliente.Text = "Cliente:";
            // 
            // lblCheckIn
            // 
            this.lblCheckIn.AutoSize = true;
            this.lblCheckIn.Location = new System.Drawing.Point(657, 67);
            this.lblCheckIn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCheckIn.Name = "lblCheckIn";
            this.lblCheckIn.Size = new System.Drawing.Size(58, 14);
            this.lblCheckIn.TabIndex = 7;
            this.lblCheckIn.Text = "Check in:";
            // 
            // lblCheckOut
            // 
            this.lblCheckOut.AutoSize = true;
            this.lblCheckOut.Location = new System.Drawing.Point(657, 117);
            this.lblCheckOut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCheckOut.Name = "lblCheckOut";
            this.lblCheckOut.Size = new System.Drawing.Size(66, 14);
            this.lblCheckOut.TabIndex = 8;
            this.lblCheckOut.Text = "Check out:";
            // 
            // lblSpot
            // 
            this.lblSpot.AutoSize = true;
            this.lblSpot.Location = new System.Drawing.Point(657, 176);
            this.lblSpot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSpot.Name = "lblSpot";
            this.lblSpot.Size = new System.Drawing.Size(37, 14);
            this.lblSpot.TabIndex = 9;
            this.lblSpot.Text = "Spot:";
            // 
            // lblImporte
            // 
            this.lblImporte.AutoSize = true;
            this.lblImporte.Location = new System.Drawing.Point(657, 232);
            this.lblImporte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(56, 14);
            this.lblImporte.TabIndex = 10;
            this.lblImporte.Text = "Importe:";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(777, 23);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(116, 21);
            this.txtCliente.TabIndex = 11;
            // 
            // txtImporte
            // 
            this.txtImporte.Location = new System.Drawing.Point(777, 232);
            this.txtImporte.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(116, 21);
            this.txtImporte.TabIndex = 15;
            // 
            // dtpCheckIn
            // 
            this.dtpCheckIn.Location = new System.Drawing.Point(777, 67);
            this.dtpCheckIn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.Size = new System.Drawing.Size(233, 21);
            this.dtpCheckIn.TabIndex = 16;
            // 
            // dtpCheckOut
            // 
            this.dtpCheckOut.Location = new System.Drawing.Point(777, 117);
            this.dtpCheckOut.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpCheckOut.Name = "dtpCheckOut";
            this.dtpCheckOut.Size = new System.Drawing.Size(233, 21);
            this.dtpCheckOut.TabIndex = 17;
            // 
            // cboSpot
            // 
            this.cboSpot.FormattingEnabled = true;
            this.cboSpot.Location = new System.Drawing.Point(777, 174);
            this.cboSpot.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboSpot.Name = "cboSpot";
            this.cboSpot.Size = new System.Drawing.Size(140, 22);
            this.cboSpot.TabIndex = 18;
            // 
            // RENTAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1027, 495);
            this.Controls.Add(this.cboSpot);
            this.Controls.Add(this.dtpCheckOut);
            this.Controls.Add(this.dtpCheckIn);
            this.Controls.Add(this.txtImporte);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.lblImporte);
            this.Controls.Add(this.lblSpot);
            this.Controls.Add(this.lblCheckOut);
            this.Controls.Add(this.lblCheckIn);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvRental);
            this.Font = new System.Drawing.Font("Meiryo UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "RENTAL";
            this.Text = "RENTAL PANEL";
            this.Load += new System.EventHandler(this.RENTAL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRental)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRental;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblCheckIn;
        private System.Windows.Forms.Label lblCheckOut;
        private System.Windows.Forms.Label lblSpot;
        private System.Windows.Forms.Label lblImporte;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.DateTimePicker dtpCheckIn;
        private System.Windows.Forms.DateTimePicker dtpCheckOut;
        private System.Windows.Forms.ComboBox cboSpot;
    }
}

