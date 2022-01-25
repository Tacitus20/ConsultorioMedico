namespace ConsultorioMedico.Vistas
{
    partial class FrmCobro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCobro));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnImpfact = new System.Windows.Forms.Button();
            this.btngrddatos = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblfolio = new System.Windows.Forms.Label();
            this.lblidDepto = new System.Windows.Forms.Label();
            this.btnagregar = new System.Windows.Forms.Button();
            this.txtsubtotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtimporte = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtdescrip = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtconcepto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdomicilio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvConceptos = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Op = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.CbDoctor = new System.Windows.Forms.ComboBox();
            this.chkMostra = new System.Windows.Forms.CheckBox();
            this.chkConsulta = new System.Windows.Forms.CheckBox();
            this.txtCodigoBarra = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.chkServ = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConceptos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnImpfact);
            this.groupBox1.Controls.Add(this.btngrddatos);
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btnImprimir);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Location = new System.Drawing.Point(13, 1);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(878, 115);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " ";
            // 
            // btnImpfact
            // 
            this.btnImpfact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImpfact.Enabled = false;
            this.btnImpfact.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImpfact.Image = ((System.Drawing.Image)(resources.GetObject("btnImpfact.Image")));
            this.btnImpfact.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImpfact.Location = new System.Drawing.Point(646, 21);
            this.btnImpfact.Margin = new System.Windows.Forms.Padding(4);
            this.btnImpfact.Name = "btnImpfact";
            this.btnImpfact.Size = new System.Drawing.Size(104, 54);
            this.btnImpfact.TabIndex = 109;
            this.btnImpfact.Text = "Imprimir   factura";
            this.btnImpfact.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImpfact.UseVisualStyleBackColor = true;
            // 
            // btngrddatos
            // 
            this.btngrddatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngrddatos.Image = ((System.Drawing.Image)(resources.GetObject("btngrddatos.Image")));
            this.btngrddatos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btngrddatos.Location = new System.Drawing.Point(426, 21);
            this.btngrddatos.Margin = new System.Windows.Forms.Padding(4);
            this.btngrddatos.Name = "btngrddatos";
            this.btngrddatos.Size = new System.Drawing.Size(104, 54);
            this.btngrddatos.TabIndex = 107;
            this.btngrddatos.Text = "Guardar ";
            this.btngrddatos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btngrddatos.UseVisualStyleBackColor = true;
            this.btngrddatos.Click += new System.EventHandler(this.btngrddatos_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(763, 21);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(104, 54);
            this.btnSalir.TabIndex = 18;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.Location = new System.Drawing.Point(536, 21);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(4);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(104, 54);
            this.btnImprimir.TabIndex = 2;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnBuscar.Location = new System.Drawing.Point(314, 21);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(104, 54);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblfolio);
            this.groupBox5.Location = new System.Drawing.Point(584, 133);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(93, 39);
            this.groupBox5.TabIndex = 127;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Folio";
            // 
            // lblfolio
            // 
            this.lblfolio.AutoSize = true;
            this.lblfolio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfolio.ForeColor = System.Drawing.Color.Red;
            this.lblfolio.Location = new System.Drawing.Point(24, 16);
            this.lblfolio.Name = "lblfolio";
            this.lblfolio.Size = new System.Drawing.Size(63, 16);
            this.lblfolio.TabIndex = 0;
            this.lblfolio.Text = "A-12345";
            // 
            // lblidDepto
            // 
            this.lblidDepto.AutoSize = true;
            this.lblidDepto.Location = new System.Drawing.Point(512, 255);
            this.lblidDepto.Name = "lblidDepto";
            this.lblidDepto.Size = new System.Drawing.Size(0, 13);
            this.lblidDepto.TabIndex = 126;
            this.lblidDepto.Visible = false;
            // 
            // btnagregar
            // 
            this.btnagregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnagregar.Location = new System.Drawing.Point(853, 336);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(38, 39);
            this.btnagregar.TabIndex = 125;
            this.btnagregar.Text = "+";
            this.btnagregar.UseVisualStyleBackColor = false;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // txtsubtotal
            // 
            this.txtsubtotal.Location = new System.Drawing.Point(736, 346);
            this.txtsubtotal.Name = "txtsubtotal";
            this.txtsubtotal.Size = new System.Drawing.Size(111, 20);
            this.txtsubtotal.TabIndex = 124;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(740, 330);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 123;
            this.label8.Text = "Subtotal";
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(619, 346);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(111, 20);
            this.txtcantidad.TabIndex = 122;
            this.txtcantidad.Leave += new System.EventHandler(this.txtcantidad_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(625, 330);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 121;
            this.label7.Text = "Cantidad:";
            // 
            // txtimporte
            // 
            this.txtimporte.Location = new System.Drawing.Point(502, 346);
            this.txtimporte.Name = "txtimporte";
            this.txtimporte.Size = new System.Drawing.Size(111, 20);
            this.txtimporte.TabIndex = 120;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(506, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 119;
            this.label6.Text = "Importe";
            // 
            // txtdescrip
            // 
            this.txtdescrip.Location = new System.Drawing.Point(179, 346);
            this.txtdescrip.Name = "txtdescrip";
            this.txtdescrip.Size = new System.Drawing.Size(317, 20);
            this.txtdescrip.TabIndex = 118;
            this.txtdescrip.TextChanged += new System.EventHandler(this.txtdescrip_TextChanged);
            this.txtdescrip.Leave += new System.EventHandler(this.txtdescrip_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(176, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 117;
            this.label5.Text = "Descripción";
            // 
            // txtconcepto
            // 
            this.txtconcepto.Location = new System.Drawing.Point(148, 272);
            this.txtconcepto.Name = "txtconcepto";
            this.txtconcepto.Size = new System.Drawing.Size(317, 20);
            this.txtconcepto.TabIndex = 114;
            this.txtconcepto.Leave += new System.EventHandler(this.txtconcepto_Leave_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 113;
            this.label3.Text = "Concepto: ";
            // 
            // txtdomicilio
            // 
            this.txtdomicilio.Location = new System.Drawing.Point(148, 227);
            this.txtdomicilio.Multiline = true;
            this.txtdomicilio.Name = "txtdomicilio";
            this.txtdomicilio.Size = new System.Drawing.Size(317, 39);
            this.txtdomicilio.TabIndex = 112;
            this.txtdomicilio.Leave += new System.EventHandler(this.txtdomicilio_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 111;
            this.label2.Text = "Domicilio: ";
            // 
            // txtnombre
            // 
            this.txtnombre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtnombre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtnombre.Location = new System.Drawing.Point(148, 201);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(317, 20);
            this.txtnombre.TabIndex = 110;
            this.txtnombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnombre_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 109;
            this.label1.Text = "Nombre del paciente: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label10.Location = new System.Drawing.Point(675, 567);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 16);
            this.label10.TabIndex = 131;
            this.label10.Text = "$";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTotal.Location = new System.Drawing.Point(694, 567);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(36, 16);
            this.lblTotal.TabIndex = 130;
            this.lblTotal.Text = "0.00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(620, 567);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 16);
            this.label9.TabIndex = 129;
            this.label9.Text = "Total:";
            // 
            // dgvConceptos
            // 
            this.dgvConceptos.AllowUserToAddRows = false;
            this.dgvConceptos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConceptos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Medicamento,
            this.Descripcion,
            this.Importe,
            this.Cantidad,
            this.Subtotal,
            this.Op});
            this.dgvConceptos.Location = new System.Drawing.Point(39, 392);
            this.dgvConceptos.Name = "dgvConceptos";
            this.dgvConceptos.Size = new System.Drawing.Size(852, 150);
            this.dgvConceptos.TabIndex = 128;
            this.dgvConceptos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConceptos_CellClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Medicamento
            // 
            this.Medicamento.HeaderText = "idMedicamento";
            this.Medicamento.Name = "Medicamento";
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 200;
            // 
            // Importe
            // 
            this.Importe.HeaderText = "Importe";
            this.Importe.Name = "Importe";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Subtotal
            // 
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.Name = "Subtotal";
            // 
            // Op
            // 
            this.Op.HeaderText = "Op";
            this.Op.Name = "Op";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 132;
            this.label4.Text = "Doctor:";
            // 
            // CbDoctor
            // 
            this.CbDoctor.FormattingEnabled = true;
            this.CbDoctor.Location = new System.Drawing.Point(148, 171);
            this.CbDoctor.Name = "CbDoctor";
            this.CbDoctor.Size = new System.Drawing.Size(192, 21);
            this.CbDoctor.TabIndex = 133;
            // 
            // chkMostra
            // 
            this.chkMostra.AutoSize = true;
            this.chkMostra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMostra.Location = new System.Drawing.Point(47, 133);
            this.chkMostra.Name = "chkMostra";
            this.chkMostra.Size = new System.Drawing.Size(151, 19);
            this.chkMostra.TabIndex = 134;
            this.chkMostra.Text = "Venta de mostrador";
            this.chkMostra.UseVisualStyleBackColor = true;
            // 
            // chkConsulta
            // 
            this.chkConsulta.AutoSize = true;
            this.chkConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkConsulta.Location = new System.Drawing.Point(220, 133);
            this.chkConsulta.Name = "chkConsulta";
            this.chkConsulta.Size = new System.Drawing.Size(145, 19);
            this.chkConsulta.TabIndex = 135;
            this.chkConsulta.Text = "Venta por consulta";
            this.chkConsulta.UseVisualStyleBackColor = true;
            // 
            // txtCodigoBarra
            // 
            this.txtCodigoBarra.Location = new System.Drawing.Point(47, 346);
            this.txtCodigoBarra.Name = "txtCodigoBarra";
            this.txtCodigoBarra.Size = new System.Drawing.Size(126, 20);
            this.txtCodigoBarra.TabIndex = 137;
            this.txtCodigoBarra.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigoBarra_KeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(44, 330);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 13);
            this.label11.TabIndex = 136;
            this.label11.Text = "Codígo de barras";
            // 
            // chkServ
            // 
            this.chkServ.AutoSize = true;
            this.chkServ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkServ.Location = new System.Drawing.Point(396, 133);
            this.chkServ.Name = "chkServ";
            this.chkServ.Size = new System.Drawing.Size(147, 19);
            this.chkServ.TabIndex = 138;
            this.chkServ.Text = "Venta por servicios";
            this.chkServ.UseVisualStyleBackColor = true;
            // 
            // FrmCobro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 592);
            this.Controls.Add(this.chkServ);
            this.Controls.Add(this.txtCodigoBarra);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.chkConsulta);
            this.Controls.Add(this.chkMostra);
            this.Controls.Add(this.CbDoctor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgvConceptos);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.lblidDepto);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.txtsubtotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtimporte);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtdescrip);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtconcepto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtdomicilio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmCobro";
            this.Text = "Cobro";
            this.Load += new System.EventHandler(this.FrmCobro_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConceptos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnImpfact;
        private System.Windows.Forms.Button btngrddatos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblfolio;
        private System.Windows.Forms.Label lblidDepto;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.TextBox txtsubtotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtimporte;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtdescrip;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtconcepto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtdomicilio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvConceptos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.DataGridViewButtonColumn Op;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CbDoctor;
        private System.Windows.Forms.CheckBox chkMostra;
        private System.Windows.Forms.CheckBox chkConsulta;
        private System.Windows.Forms.TextBox txtCodigoBarra;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox chkServ;
    }
}