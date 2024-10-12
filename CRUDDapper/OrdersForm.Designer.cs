namespace CRUDDapper
{
    partial class txtRegionEnvio
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
            label1 = new Label();
            TxtPaisEnvio = new TextBox();
            userOrdenesBindingSource = new BindingSource(components);
            label2 = new Label();
            TxtNombreEnvio = new TextBox();
            label3 = new Label();
            TxtFlete = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            DateFechadeorden = new DateTimePicker();
            DateFEcharequerida = new DateTimePicker();
            dateFechaenvio = new DateTimePicker();
            CbCLienteID = new ComboBox();
            CbEmpleadoId = new ComboBox();
            CbShipvia = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            txtregiondeenvio = new TextBox();
            TxtCodPostal = new TextBox();
            Txtciudadenvio = new TextBox();
            TxtDireccionEnvio = new TextBox();
            dataGridView2 = new DataGridView();
            ProductID = new DataGridViewTextBoxColumn();
            UnitPrice = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Discount = new DataGridViewTextBoxColumn();
            Op = new DataGridViewButtonColumn();
            button2 = new Button();
            comboBox1 = new ComboBox();
            label14 = new Label();
            label15 = new Label();
            textBox1 = new TextBox();
            label16 = new Label();
            textBox2 = new TextBox();
            button4 = new Button();
            panel1 = new Panel();
            label17 = new Label();
            panel2 = new Panel();
            label20 = new Label();
            textBox3 = new TextBox();
            label19 = new Label();
            label18 = new Label();
            button1 = new Button();
            panel3 = new Panel();
            button3 = new Button();
            bindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)userOrdenesBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poor Richard", 12F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(54, 12);
            label1.Name = "label1";
            label1.Size = new Size(73, 23);
            label1.TabIndex = 1;
            label1.Text = "Cliente";
            // 
            // TxtPaisEnvio
            // 
            TxtPaisEnvio.DataBindings.Add(new Binding("Text", userOrdenesBindingSource, "Shipcomtry", true));
            TxtPaisEnvio.Location = new Point(199, 450);
            TxtPaisEnvio.Name = "TxtPaisEnvio";
            TxtPaisEnvio.Size = new Size(110, 25);
            TxtPaisEnvio.TabIndex = 4;
            // 
            // userOrdenesBindingSource
            // 
            userOrdenesBindingSource.DataSource = typeof(Validator.UserOrdenes);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poor Richard", 12F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(15, 124);
            label2.Name = "label2";
            label2.Size = new Size(152, 23);
            label2.TabIndex = 3;
            label2.Text = "Fecha Requerida";
            // 
            // TxtNombreEnvio
            // 
            TxtNombreEnvio.DataBindings.Add(new Binding("Text", userOrdenesBindingSource, "ShiName", true));
            TxtNombreEnvio.Location = new Point(198, 299);
            TxtNombreEnvio.Name = "TxtNombreEnvio";
            TxtNombreEnvio.Size = new Size(110, 25);
            TxtNombreEnvio.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poor Richard", 12F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(36, 170);
            label3.Name = "label3";
            label3.Size = new Size(135, 23);
            label3.TabIndex = 5;
            label3.Text = "Facha de envío";
            // 
            // TxtFlete
            // 
            TxtFlete.DataBindings.Add(new Binding("Text", userOrdenesBindingSource, "Freigt", true));
            TxtFlete.Location = new Point(198, 254);
            TxtFlete.Name = "TxtFlete";
            TxtFlete.Size = new Size(110, 25);
            TxtFlete.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poor Richard", 12F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(20, 77);
            label4.Name = "label4";
            label4.Size = new Size(147, 23);
            label4.TabIndex = 7;
            label4.Text = "Fecha de Orden ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poor Richard", 12F, FontStyle.Bold | FontStyle.Italic);
            label5.Location = new Point(24, 45);
            label5.Name = "label5";
            label5.Size = new Size(98, 23);
            label5.TabIndex = 9;
            label5.Text = "Empleado ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Poor Richard", 12F, FontStyle.Bold | FontStyle.Italic);
            label6.Location = new Point(93, 211);
            label6.Name = "label6";
            label6.Size = new Size(78, 23);
            label6.TabIndex = 11;
            label6.Text = "ShipVia";
            // 
            // DateFechadeorden
            // 
            DateFechadeorden.DataBindings.Add(new Binding("Text", userOrdenesBindingSource, "OrderDate", true));
            DateFechadeorden.Location = new Point(190, 75);
            DateFechadeorden.Name = "DateFechadeorden";
            DateFechadeorden.Size = new Size(220, 25);
            DateFechadeorden.TabIndex = 13;
            // 
            // DateFEcharequerida
            // 
            DateFEcharequerida.DataBindings.Add(new Binding("Text", userOrdenesBindingSource, "RequireDate", true));
            DateFEcharequerida.Location = new Point(190, 122);
            DateFEcharequerida.Name = "DateFEcharequerida";
            DateFEcharequerida.Size = new Size(220, 25);
            DateFEcharequerida.TabIndex = 14;
            // 
            // dateFechaenvio
            // 
            dateFechaenvio.DataBindings.Add(new Binding("Text", userOrdenesBindingSource, "ShippedDate", true));
            dateFechaenvio.Location = new Point(198, 168);
            dateFechaenvio.Name = "dateFechaenvio";
            dateFechaenvio.Size = new Size(220, 25);
            dateFechaenvio.TabIndex = 15;
            // 
            // CbCLienteID
            // 
            CbCLienteID.DataBindings.Add(new Binding("Text", userOrdenesBindingSource, "CustomerID", true));
            CbCLienteID.FormattingEnabled = true;
            CbCLienteID.Location = new Point(184, 3);
            CbCLienteID.Name = "CbCLienteID";
            CbCLienteID.Size = new Size(133, 25);
            CbCLienteID.TabIndex = 16;
            // 
            // CbEmpleadoId
            // 
            CbEmpleadoId.DataBindings.Add(new Binding("Text", userOrdenesBindingSource, "EmpleoyessID", true));
            CbEmpleadoId.FormattingEnabled = true;
            CbEmpleadoId.Location = new Point(190, 41);
            CbEmpleadoId.Name = "CbEmpleadoId";
            CbEmpleadoId.Size = new Size(152, 25);
            CbEmpleadoId.TabIndex = 17;
            // 
            // CbShipvia
            // 
            CbShipvia.DataBindings.Add(new Binding("Text", userOrdenesBindingSource, "ShoVIa", true));
            CbShipvia.FormattingEnabled = true;
            CbShipvia.Location = new Point(198, 213);
            CbShipvia.Name = "CbShipvia";
            CbShipvia.Size = new Size(133, 25);
            CbShipvia.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Poor Richard", 12F, FontStyle.Bold | FontStyle.Italic);
            label7.Location = new Point(32, 373);
            label7.Name = "label7";
            label7.Size = new Size(148, 23);
            label7.TabIndex = 19;
            label7.Text = "CIudad de envio";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Poor Richard", 12F, FontStyle.Bold | FontStyle.Italic);
            label8.Location = new Point(24, 340);
            label8.Name = "label8";
            label8.Size = new Size(166, 23);
            label8.TabIndex = 20;
            label8.Text = "Dirección de envío";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Poor Richard", 12F, FontStyle.Bold | FontStyle.Italic);
            label9.Location = new Point(28, 295);
            label9.Name = "label9";
            label9.Size = new Size(152, 23);
            label9.TabIndex = 21;
            label9.Text = "Nombre de envio";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Poor Richard", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label10.Location = new Point(114, 257);
            label10.Name = "label10";
            label10.Size = new Size(53, 23);
            label10.TabIndex = 22;
            label10.Text = "Flete";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Poor Richard", 12F, FontStyle.Bold | FontStyle.Italic);
            label11.Location = new Point(36, 405);
            label11.Name = "label11";
            label11.Size = new Size(144, 23);
            label11.TabIndex = 23;
            label11.Text = "Región de envio";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Poor Richard", 12F, FontStyle.Bold | FontStyle.Italic);
            label12.Location = new Point(8, 491);
            label12.Name = "label12";
            label12.Size = new Size(175, 23);
            label12.TabIndex = 24;
            label12.Text = "Cod Postal de envio";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Poor Richard", 12F, FontStyle.Bold | FontStyle.Italic);
            label13.Location = new Point(57, 448);
            label13.Name = "label13";
            label13.Size = new Size(119, 23);
            label13.TabIndex = 25;
            label13.Text = "Pais de envio";
            // 
            // txtregiondeenvio
            // 
            txtregiondeenvio.DataBindings.Add(new Binding("Text", userOrdenesBindingSource, "Shipregion", true));
            txtregiondeenvio.Location = new Point(199, 409);
            txtregiondeenvio.Name = "txtregiondeenvio";
            txtregiondeenvio.Size = new Size(110, 25);
            txtregiondeenvio.TabIndex = 12;
            // 
            // TxtCodPostal
            // 
            TxtCodPostal.DataBindings.Add(new Binding("Text", userOrdenesBindingSource, "ShipPostalcode", true));
            TxtCodPostal.Location = new Point(199, 493);
            TxtCodPostal.Name = "TxtCodPostal";
            TxtCodPostal.Size = new Size(110, 25);
            TxtCodPostal.TabIndex = 26;
            // 
            // Txtciudadenvio
            // 
            Txtciudadenvio.DataBindings.Add(new Binding("Text", userOrdenesBindingSource, "ShiCity", true));
            Txtciudadenvio.Location = new Point(199, 376);
            Txtciudadenvio.Name = "Txtciudadenvio";
            Txtciudadenvio.Size = new Size(110, 25);
            Txtciudadenvio.TabIndex = 27;
            // 
            // TxtDireccionEnvio
            // 
            TxtDireccionEnvio.DataBindings.Add(new Binding("Text", userOrdenesBindingSource, "Shipaddress", true));
            TxtDireccionEnvio.Location = new Point(199, 341);
            TxtDireccionEnvio.Name = "TxtDireccionEnvio";
            TxtDireccionEnvio.Size = new Size(110, 25);
            TxtDireccionEnvio.TabIndex = 28;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.BackgroundColor = SystemColors.Info;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { ProductID, UnitPrice, Quantity, Discount, Op });
            dataGridView2.GridColor = SystemColors.HotTrack;
            dataGridView2.Location = new Point(33, 253);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(675, 161);
            dataGridView2.TabIndex = 38;
            dataGridView2.CellClick += dataGridView2_CellClick;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // ProductID
            // 
            ProductID.HeaderText = "ProductID";
            ProductID.MinimumWidth = 6;
            ProductID.Name = "ProductID";
            ProductID.Width = 125;
            // 
            // UnitPrice
            // 
            UnitPrice.HeaderText = "UnitPrice";
            UnitPrice.MinimumWidth = 6;
            UnitPrice.Name = "UnitPrice";
            UnitPrice.Width = 125;
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Quantity";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            Quantity.Width = 125;
            // 
            // Discount
            // 
            Discount.HeaderText = "Discount";
            Discount.MinimumWidth = 6;
            Discount.Name = "Discount";
            Discount.Width = 125;
            // 
            // Op
            // 
            Op.HeaderText = "Op";
            Op.MinimumWidth = 6;
            Op.Name = "Op";
            Op.Resizable = DataGridViewTriState.True;
            Op.SortMode = DataGridViewColumnSortMode.Automatic;
            Op.Width = 125;
            // 
            // button2
            // 
            button2.Font = new Font("Modern No. 20", 16.2F, FontStyle.Bold | FontStyle.Italic);
            button2.Location = new Point(483, 591);
            button2.Name = "button2";
            button2.Size = new Size(220, 72);
            button2.TabIndex = 39;
            button2.Text = "Guardar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(279, 62);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(152, 25);
            comboBox1.TabIndex = 42;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Poor Richard", 12F, FontStyle.Bold | FontStyle.Italic);
            label14.Location = new Point(173, 66);
            label14.Name = "label14";
            label14.Size = new Size(86, 23);
            label14.TabIndex = 41;
            label14.Text = "Producto";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Poor Richard", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label15.Location = new Point(180, 146);
            label15.Name = "label15";
            label15.Size = new Size(93, 23);
            label15.TabIndex = 44;
            label15.Text = "Cantidad ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(279, 147);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(110, 25);
            textBox1.TabIndex = 43;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Poor Richard", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label16.Location = new Point(180, 102);
            label16.Name = "label16";
            label16.Size = new Size(63, 23);
            label16.TabIndex = 46;
            label16.Text = "Precio";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(279, 100);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(110, 25);
            textBox2.TabIndex = 45;
            // 
            // button4
            // 
            button4.Font = new Font("Sitka Display", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(491, 177);
            button4.Name = "button4";
            button4.Size = new Size(64, 56);
            button4.TabIndex = 47;
            button4.Text = "Add";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Honeydew;
            panel1.Controls.Add(TxtCodPostal);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(TxtPaisEnvio);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(TxtNombreEnvio);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(TxtFlete);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtregiondeenvio);
            panel1.Controls.Add(TxtDireccionEnvio);
            panel1.Controls.Add(DateFechadeorden);
            panel1.Controls.Add(Txtciudadenvio);
            panel1.Controls.Add(DateFEcharequerida);
            panel1.Controls.Add(dateFechaenvio);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(CbCLienteID);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(CbEmpleadoId);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(CbShipvia);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Location = new Point(3, 121);
            panel1.Name = "panel1";
            panel1.Size = new Size(430, 539);
            panel1.TabIndex = 48;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Sitka Banner", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label17.Location = new Point(200, -4);
            label17.Name = "label17";
            label17.Size = new Size(276, 58);
            label17.TabIndex = 49;
            label17.Text = "Detalle de orde ";
            // 
            // panel2
            // 
            panel2.BackColor = Color.SeaShell;
            panel2.Controls.Add(label20);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(label19);
            panel2.Controls.Add(label17);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(dataGridView2);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(label16);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label15);
            panel2.Location = new Point(439, 121);
            panel2.Name = "panel2";
            panel2.Size = new Size(729, 461);
            panel2.TabIndex = 50;
            panel2.Paint += panel2_Paint;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(100, 94);
            label20.Name = "label20";
            label20.Size = new Size(50, 17);
            label20.TabIndex = 52;
            label20.Text = "label20";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(279, 200);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(110, 25);
            textBox3.TabIndex = 50;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Poor Richard", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label19.Location = new Point(180, 199);
            label19.Name = "label19";
            label19.Size = new Size(84, 23);
            label19.TabIndex = 51;
            label19.Text = "Discount";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Sitka Banner", 25.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label18.Location = new Point(133, 42);
            label18.Name = "label18";
            label18.Size = new Size(257, 62);
            label18.TabIndex = 51;
            label18.Text = "Añadir orden";
            // 
            // button1
            // 
            button1.Font = new Font("Perpetua", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(1050, 608);
            button1.Name = "button1";
            button1.Size = new Size(115, 52);
            button1.TabIndex = 52;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Linen;
            panel3.Controls.Add(button3);
            panel3.Controls.Add(label18);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(1165, 115);
            panel3.TabIndex = 53;
            // 
            // button3
            // 
            button3.Font = new Font("Perpetua", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button3.Location = new Point(0, 9);
            button3.Name = "button3";
            button3.Size = new Size(70, 39);
            button3.TabIndex = 53;
            button3.Text = "Atras";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // txtRegionEnvio
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1174, 672);
            Controls.Add(panel3);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button2);
            Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "txtRegionEnvio";
            Text = "OrdersForm";
            Load += OrdersForm_Load;
            ((System.ComponentModel.ISupportInitialize)userOrdenesBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private TextBox TxtPaisEnvio;
        private Label label2;
        private TextBox TxtNombreEnvio;
        private Label label3;
        private TextBox TxtFlete;
        private Label label4;
        private Label label5;
        private Label label6;
        private DateTimePicker DateFechadeorden;
        private DateTimePicker DateFEcharequerida;
        private DateTimePicker dateFechaenvio;
        private ComboBox CbCLienteID;
        private ComboBox CbEmpleadoId;
        private ComboBox CbShipvia;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox txtregiondeenvio;
        private TextBox TxtCodPostal;
        private TextBox Txtciudadenvio;
        private TextBox TxtDireccionEnvio;
        private DataGridView dataGridView2;
        private Button button2;
        private ComboBox comboBox1;
        private Label label14;
        private Label label15;
        private TextBox textBox1;
        private Label label16;
        private TextBox textBox2;
        private Button button4;
        private Panel panel1;
        private Label label17;
        private Panel panel2;
        private Label label18;
        private Button button1;
        private DataGridViewTextBoxColumn ProductID;
        private DataGridViewTextBoxColumn UnitPrice;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Discount;
        private DataGridViewButtonColumn Op;
        private TextBox textBox3;
        private Label label19;
        private Panel panel3;
        private BindingSource bindingSource1;
        private BindingSource userOrdenesBindingSource;
        private Label label20;
        private Button button3;
    }
}