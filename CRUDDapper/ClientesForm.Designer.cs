namespace CRUDDapper
{
    partial class ClientesForm
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            BtAgregar = new Button();
            BtModificar = new Button();
            BtEliminar = new Button();
            label1 = new Label();
            TxtClienteID = new TextBox();
            TxtNombrecomñia = new TextBox();
            userClienteBindingSource = new BindingSource(components);
            label2 = new Label();
            TxtNombreComtacto = new TextBox();
            label3 = new Label();
            Txtciudad = new TextBox();
            label4 = new Label();
            TxtDireccion = new TextBox();
            label5 = new Label();
            TxtTitulocontacto = new TextBox();
            label6 = new Label();
            TxtCodpostal = new TextBox();
            label7 = new Label();
            Txtciu = new TextBox();
            label8 = new Label();
            TxtTelefono = new TextBox();
            label9 = new Label();
            TxtRegion = new TextBox();
            label10 = new Label();
            label11 = new Label();
            TxtFax = new TextBox();
            bindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userClienteBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(401, 75);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(724, 375);
            dataGridView1.TabIndex = 0;
            // 
            // BtAgregar
            // 
            BtAgregar.Font = new Font("Sitka Heading", 13.7999992F, FontStyle.Italic);
            BtAgregar.Location = new Point(424, 498);
            BtAgregar.Name = "BtAgregar";
            BtAgregar.RightToLeft = RightToLeft.No;
            BtAgregar.Size = new Size(216, 64);
            BtAgregar.TabIndex = 1;
            BtAgregar.Text = "Agregar";
            BtAgregar.UseVisualStyleBackColor = true;
            BtAgregar.Click += BtAgregar_Click;
            // 
            // BtModificar
            // 
            BtModificar.Font = new Font("Sitka Heading", 13.7999992F, FontStyle.Italic);
            BtModificar.Location = new Point(646, 498);
            BtModificar.Name = "BtModificar";
            BtModificar.Size = new Size(216, 64);
            BtModificar.TabIndex = 2;
            BtModificar.Text = "Modificar";
            BtModificar.UseVisualStyleBackColor = true;
            BtModificar.Click += BtModificar_Click;
            // 
            // BtEliminar
            // 
            BtEliminar.Font = new Font("Sitka Heading", 13.7999992F, FontStyle.Italic);
            BtEliminar.Location = new Point(898, 498);
            BtEliminar.Name = "BtEliminar";
            BtEliminar.Size = new Size(216, 64);
            BtEliminar.TabIndex = 3;
            BtEliminar.Text = "Eliminar";
            BtEliminar.UseVisualStyleBackColor = true;
            BtEliminar.Click += BtEliminar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Heading", 16.1999989F, FontStyle.Italic);
            label1.Location = new Point(65, 53);
            label1.Name = "label1";
            label1.Size = new Size(124, 39);
            label1.TabIndex = 4;
            label1.Text = "Cliente ID";
            // 
            // TxtClienteID
            // 
            TxtClienteID.Font = new Font("Sitka Heading", 16.1999989F, FontStyle.Italic);
            TxtClienteID.Location = new Point(234, 49);
            TxtClienteID.Name = "TxtClienteID";
            TxtClienteID.Size = new Size(125, 41);
            TxtClienteID.TabIndex = 5;
            // 
            // TxtNombrecomñia
            // 
            TxtNombrecomñia.DataBindings.Add(new Binding("Text", userClienteBindingSource, "Nombre_Compañia", true));
            TxtNombrecomñia.Font = new Font("Sitka Heading", 16.1999989F, FontStyle.Italic);
            TxtNombrecomñia.Location = new Point(234, 95);
            TxtNombrecomñia.Name = "TxtNombrecomñia";
            TxtNombrecomñia.Size = new Size(125, 41);
            TxtNombrecomñia.TabIndex = 7;
            // 
            // userClienteBindingSource
            // 
            userClienteBindingSource.DataSource = typeof(Validator.UserCliente);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Heading", 16.1999989F, FontStyle.Italic);
            label2.Location = new Point(-33, 92);
            label2.Name = "label2";
            label2.Size = new Size(222, 39);
            label2.TabIndex = 6;
            label2.Text = "Nombre Compañia";
            // 
            // TxtNombreComtacto
            // 
            TxtNombreComtacto.DataBindings.Add(new Binding("Text", userClienteBindingSource, "Nombre_Contacto", true));
            TxtNombreComtacto.Font = new Font("Sitka Heading", 16.1999989F, FontStyle.Italic);
            TxtNombreComtacto.Location = new Point(234, 145);
            TxtNombreComtacto.Name = "TxtNombreComtacto";
            TxtNombreComtacto.Size = new Size(125, 41);
            TxtNombreComtacto.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Heading", 16.1999989F, FontStyle.Italic);
            label3.Location = new Point(-16, 142);
            label3.Name = "label3";
            label3.Size = new Size(205, 39);
            label3.TabIndex = 8;
            label3.Text = "Nombre contacto";
            // 
            // Txtciudad
            // 
            Txtciudad.DataBindings.Add(new Binding("Text", userClienteBindingSource, "Ciudad", true));
            Txtciudad.Font = new Font("Sitka Heading", 16.1999989F, FontStyle.Italic);
            Txtciudad.Location = new Point(234, 302);
            Txtciudad.Name = "Txtciudad";
            Txtciudad.Size = new Size(125, 41);
            Txtciudad.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Heading", 16.1999989F, FontStyle.Italic);
            label4.Location = new Point(95, 299);
            label4.Name = "label4";
            label4.Size = new Size(94, 39);
            label4.TabIndex = 10;
            label4.Text = "Ciudad";
            // 
            // TxtDireccion
            // 
            TxtDireccion.DataBindings.Add(new Binding("Text", userClienteBindingSource, "Dirrecion", true));
            TxtDireccion.Font = new Font("Sitka Heading", 16.1999989F, FontStyle.Italic);
            TxtDireccion.Location = new Point(234, 238);
            TxtDireccion.Name = "TxtDireccion";
            TxtDireccion.Size = new Size(125, 41);
            TxtDireccion.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Heading", 16.1999989F, FontStyle.Italic);
            label5.Location = new Point(63, 242);
            label5.Name = "label5";
            label5.Size = new Size(126, 39);
            label5.TabIndex = 12;
            label5.Text = "Direccion ";
            // 
            // TxtTitulocontacto
            // 
            TxtTitulocontacto.DataBindings.Add(new Binding("Text", userClienteBindingSource, "Titulo_contacto", true));
            TxtTitulocontacto.Font = new Font("Sitka Heading", 16.1999989F, FontStyle.Italic);
            TxtTitulocontacto.Location = new Point(234, 187);
            TxtTitulocontacto.Name = "TxtTitulocontacto";
            TxtTitulocontacto.Size = new Size(125, 41);
            TxtTitulocontacto.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sitka Heading", 16.1999989F, FontStyle.Italic);
            label6.Location = new Point(6, 187);
            label6.Name = "label6";
            label6.Size = new Size(183, 39);
            label6.TabIndex = 14;
            label6.Text = "Titulo contacto";
            // 
            // TxtCodpostal
            // 
            TxtCodpostal.DataBindings.Add(new Binding("Text", userClienteBindingSource, "Codigp_Postal", true));
            TxtCodpostal.Font = new Font("Sitka Heading", 16.1999989F, FontStyle.Italic);
            TxtCodpostal.Location = new Point(234, 398);
            TxtCodpostal.Name = "TxtCodpostal";
            TxtCodpostal.Size = new Size(125, 41);
            TxtCodpostal.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sitka Heading", 16.1999989F, FontStyle.Italic);
            label7.Location = new Point(56, 395);
            label7.Name = "label7";
            label7.Size = new Size(133, 39);
            label7.TabIndex = 22;
            label7.Text = "Cod Postal";
            // 
            // Txtciu
            // 
            Txtciu.DataBindings.Add(new Binding("Text", userClienteBindingSource, "Pais", true));
            Txtciu.Font = new Font("Sitka Heading", 16.1999989F, FontStyle.Italic);
            Txtciu.Location = new Point(234, 445);
            Txtciu.Name = "Txtciu";
            Txtciu.Size = new Size(125, 41);
            Txtciu.TabIndex = 21;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Sitka Heading", 16.1999989F, FontStyle.Italic);
            label8.Location = new Point(127, 442);
            label8.Name = "label8";
            label8.Size = new Size(62, 39);
            label8.TabIndex = 20;
            label8.Text = "Pais";
            // 
            // TxtTelefono
            // 
            TxtTelefono.DataBindings.Add(new Binding("Text", userClienteBindingSource, "Telefono", true));
            TxtTelefono.Font = new Font("Sitka Heading", 16.1999989F, FontStyle.Italic);
            TxtTelefono.Location = new Point(234, 486);
            TxtTelefono.Name = "TxtTelefono";
            TxtTelefono.Size = new Size(125, 41);
            TxtTelefono.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Sitka Heading", 16.1999989F, FontStyle.Italic);
            label9.Location = new Point(80, 486);
            label9.Name = "label9";
            label9.Size = new Size(109, 39);
            label9.TabIndex = 18;
            label9.Text = "Telefono";
            // 
            // TxtRegion
            // 
            TxtRegion.DataBindings.Add(new Binding("Text", userClienteBindingSource, "Region", true));
            TxtRegion.Font = new Font("Sitka Heading", 16.1999989F, FontStyle.Italic);
            TxtRegion.Location = new Point(234, 354);
            TxtRegion.Name = "TxtRegion";
            TxtRegion.Size = new Size(125, 41);
            TxtRegion.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Sitka Heading", 16.1999989F, FontStyle.Italic);
            label10.Location = new Point(97, 344);
            label10.Name = "label10";
            label10.Size = new Size(92, 39);
            label10.TabIndex = 16;
            label10.Text = "Region";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Sitka Heading", 16.1999989F, FontStyle.Italic);
            label11.Location = new Point(133, 523);
            label11.Name = "label11";
            label11.Size = new Size(56, 39);
            label11.TabIndex = 24;
            label11.Text = "Fax";
            // 
            // TxtFax
            // 
            TxtFax.DataBindings.Add(new Binding("Text", userClienteBindingSource, "Fax", true));
            TxtFax.Font = new Font("Sitka Heading", 16.1999989F, FontStyle.Italic);
            TxtFax.Location = new Point(234, 523);
            TxtFax.Name = "TxtFax";
            TxtFax.Size = new Size(125, 41);
            TxtFax.TabIndex = 25;
            // 
            // ClientesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Moccasin;
            ClientSize = new Size(1151, 586);
            Controls.Add(TxtFax);
            Controls.Add(label11);
            Controls.Add(TxtCodpostal);
            Controls.Add(label7);
            Controls.Add(Txtciu);
            Controls.Add(label8);
            Controls.Add(TxtTelefono);
            Controls.Add(label9);
            Controls.Add(TxtRegion);
            Controls.Add(label10);
            Controls.Add(TxtTitulocontacto);
            Controls.Add(label6);
            Controls.Add(TxtDireccion);
            Controls.Add(label5);
            Controls.Add(Txtciudad);
            Controls.Add(label4);
            Controls.Add(TxtNombreComtacto);
            Controls.Add(label3);
            Controls.Add(TxtNombrecomñia);
            Controls.Add(label2);
            Controls.Add(TxtClienteID);
            Controls.Add(label1);
            Controls.Add(BtEliminar);
            Controls.Add(BtModificar);
            Controls.Add(BtAgregar);
            Controls.Add(dataGridView1);
            Name = "ClientesForm";
            Text = "ClientesForm";
            Load += ClientesForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)userClienteBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button BtAgregar;
        private Button BtModificar;
        private Button BtEliminar;
        private Label label1;
        private TextBox TxtClienteID;
        private TextBox TxtNombrecomñia;
        private Label label2;
        private TextBox TxtNombreComtacto;
        private Label label3;
        private TextBox Txtciudad;
        private Label label4;
        private TextBox TxtDireccion;
        private Label label5;
        private TextBox TxtTitulocontacto;
        private Label label6;
        private TextBox TxtCodpostal;
        private Label label7;
        private TextBox Txtciu;
        private Label label8;
        private TextBox TxtTelefono;
        private Label label9;
        private TextBox TxtRegion;
        private Label label10;
        private Label label11;
        private TextBox TxtFax;
        private BindingSource bindingSource1;
        private BindingSource userClienteBindingSource;
    }
}