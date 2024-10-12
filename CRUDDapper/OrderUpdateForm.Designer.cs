namespace CRUDDapper
{
    partial class OrderUpdateForm
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
            label1 = new Label();
            panel3 = new Panel();
            label18 = new Label();
            panel2 = new Panel();
            textBox3 = new TextBox();
            label19 = new Label();
            label17 = new Label();
            button4 = new Button();
            dataGridView2 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            ProductID = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            UnitPrice = new DataGridViewTextBoxColumn();
            Discount = new DataGridViewTextBoxColumn();
            Op = new DataGridViewButtonColumn();
            label14 = new Label();
            label16 = new Label();
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label15 = new Label();
            panel1 = new Panel();
            TxtCodPostal = new TextBox();
            label2 = new Label();
            label3 = new Label();
            TxtPaisEnvio = new TextBox();
            label4 = new Label();
            TxtNombreEnvio = new TextBox();
            label5 = new Label();
            TxtFlete = new TextBox();
            label6 = new Label();
            label7 = new Label();
            txtregiondeenvio = new TextBox();
            TxtDireccionEnvio = new TextBox();
            DateFechadeorden = new DateTimePicker();
            Txtciudadenvio = new TextBox();
            DateFEcharequerida = new DateTimePicker();
            dateFechaenvio = new DateTimePicker();
            label13 = new Label();
            CbCLienteID = new ComboBox();
            label12 = new Label();
            CbEmpleadoId = new ComboBox();
            label11 = new Label();
            CbShipvia = new ComboBox();
            label10 = new Label();
            label8 = new Label();
            label9 = new Label();
            label21 = new Label();
            button1 = new Button();
            button2 = new Button();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 124);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Linen;
            panel3.Controls.Add(label18);
            panel3.Location = new Point(-1, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(1165, 67);
            panel3.TabIndex = 56;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Sitka Banner", 25.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label18.Location = new Point(127, 5);
            label18.Name = "label18";
            label18.Size = new Size(257, 62);
            label18.TabIndex = 51;
            label18.Text = "Añadir orden";
            // 
            // panel2
            // 
            panel2.BackColor = Color.SeaShell;
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(label19);
            panel2.Controls.Add(label17);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(dataGridView2);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(label16);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label15);
            panel2.Location = new Point(435, 74);
            panel2.Name = "panel2";
            panel2.Size = new Size(729, 461);
            panel2.TabIndex = 55;
            panel2.Paint += panel2_Paint;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(279, 200);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(110, 27);
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
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.BackgroundColor = SystemColors.Info;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column1, ProductID, Quantity, UnitPrice, Discount, Op });
            dataGridView2.GridColor = SystemColors.HotTrack;
            dataGridView2.Location = new Point(54, 295);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(675, 158);
            dataGridView2.TabIndex = 38;
            dataGridView2.CellClick += dataGridView2_CellClick;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick_1;
            // 
            // Column1
            // 
            Column1.HeaderText = "OrderID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // ProductID
            // 
            ProductID.DataPropertyName = "ProductId";
            ProductID.HeaderText = "ProductID";
            ProductID.MinimumWidth = 6;
            ProductID.Name = "ProductID";
            ProductID.Width = 125;
            // 
            // Quantity
            // 
            Quantity.DataPropertyName = "Quantity";
            Quantity.HeaderText = "Quantity";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            Quantity.Width = 125;
            // 
            // UnitPrice
            // 
            UnitPrice.DataPropertyName = "unitPrice";
            UnitPrice.HeaderText = "UnitPrice";
            UnitPrice.MinimumWidth = 6;
            UnitPrice.Name = "UnitPrice";
            UnitPrice.Width = 125;
            // 
            // Discount
            // 
            Discount.DataPropertyName = "Discount";
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
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(279, 62);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(152, 28);
            comboBox1.TabIndex = 42;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(293, 145);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(110, 27);
            textBox2.TabIndex = 45;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(293, 98);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(110, 27);
            textBox1.TabIndex = 43;
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
            // panel1
            // 
            panel1.BackColor = Color.Honeydew;
            panel1.Controls.Add(TxtCodPostal);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(TxtPaisEnvio);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(TxtNombreEnvio);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(TxtFlete);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label7);
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
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label21);
            panel1.Location = new Point(-1, 74);
            panel1.Name = "panel1";
            panel1.Size = new Size(430, 539);
            panel1.TabIndex = 54;
            // 
            // TxtCodPostal
            // 
            TxtCodPostal.Location = new Point(199, 493);
            TxtCodPostal.Name = "TxtCodPostal";
            TxtCodPostal.Size = new Size(110, 27);
            TxtCodPostal.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poor Richard", 12F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(54, 12);
            label2.Name = "label2";
            label2.Size = new Size(73, 23);
            label2.TabIndex = 1;
            label2.Text = "Cliente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poor Richard", 12F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(15, 124);
            label3.Name = "label3";
            label3.Size = new Size(152, 23);
            label3.TabIndex = 3;
            label3.Text = "Fecha Requerida";
            // 
            // TxtPaisEnvio
            // 
            TxtPaisEnvio.Location = new Point(199, 450);
            TxtPaisEnvio.Name = "TxtPaisEnvio";
            TxtPaisEnvio.Size = new Size(110, 27);
            TxtPaisEnvio.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poor Richard", 12F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(36, 170);
            label4.Name = "label4";
            label4.Size = new Size(135, 23);
            label4.TabIndex = 5;
            label4.Text = "Facha de envío";
            // 
            // TxtNombreEnvio
            // 
            TxtNombreEnvio.Location = new Point(198, 299);
            TxtNombreEnvio.Name = "TxtNombreEnvio";
            TxtNombreEnvio.Size = new Size(110, 27);
            TxtNombreEnvio.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poor Richard", 12F, FontStyle.Bold | FontStyle.Italic);
            label5.Location = new Point(20, 77);
            label5.Name = "label5";
            label5.Size = new Size(147, 23);
            label5.TabIndex = 7;
            label5.Text = "Fecha de Orden ";
            // 
            // TxtFlete
            // 
            TxtFlete.Location = new Point(198, 254);
            TxtFlete.Name = "TxtFlete";
            TxtFlete.Size = new Size(110, 27);
            TxtFlete.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Poor Richard", 12F, FontStyle.Bold | FontStyle.Italic);
            label6.Location = new Point(24, 45);
            label6.Name = "label6";
            label6.Size = new Size(98, 23);
            label6.TabIndex = 9;
            label6.Text = "Empleado ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Poor Richard", 12F, FontStyle.Bold | FontStyle.Italic);
            label7.Location = new Point(93, 211);
            label7.Name = "label7";
            label7.Size = new Size(78, 23);
            label7.TabIndex = 11;
            label7.Text = "ShipVia";
            // 
            // txtregiondeenvio
            // 
            txtregiondeenvio.Location = new Point(199, 409);
            txtregiondeenvio.Name = "txtregiondeenvio";
            txtregiondeenvio.Size = new Size(110, 27);
            txtregiondeenvio.TabIndex = 12;
            // 
            // TxtDireccionEnvio
            // 
            TxtDireccionEnvio.Location = new Point(199, 341);
            TxtDireccionEnvio.Name = "TxtDireccionEnvio";
            TxtDireccionEnvio.Size = new Size(110, 27);
            TxtDireccionEnvio.TabIndex = 28;
            // 
            // DateFechadeorden
            // 
            DateFechadeorden.Location = new Point(190, 75);
            DateFechadeorden.Name = "DateFechadeorden";
            DateFechadeorden.Size = new Size(220, 27);
            DateFechadeorden.TabIndex = 13;
            // 
            // Txtciudadenvio
            // 
            Txtciudadenvio.Location = new Point(199, 376);
            Txtciudadenvio.Name = "Txtciudadenvio";
            Txtciudadenvio.Size = new Size(110, 27);
            Txtciudadenvio.TabIndex = 27;
            // 
            // DateFEcharequerida
            // 
            DateFEcharequerida.Location = new Point(190, 122);
            DateFEcharequerida.Name = "DateFEcharequerida";
            DateFEcharequerida.Size = new Size(220, 27);
            DateFEcharequerida.TabIndex = 14;
            // 
            // dateFechaenvio
            // 
            dateFechaenvio.Location = new Point(198, 168);
            dateFechaenvio.Name = "dateFechaenvio";
            dateFechaenvio.Size = new Size(220, 27);
            dateFechaenvio.TabIndex = 15;
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
            // CbCLienteID
            // 
            CbCLienteID.FormattingEnabled = true;
            CbCLienteID.Location = new Point(184, 3);
            CbCLienteID.Name = "CbCLienteID";
            CbCLienteID.Size = new Size(133, 28);
            CbCLienteID.TabIndex = 16;
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
            // CbEmpleadoId
            // 
            CbEmpleadoId.FormattingEnabled = true;
            CbEmpleadoId.Location = new Point(190, 41);
            CbEmpleadoId.Name = "CbEmpleadoId";
            CbEmpleadoId.Size = new Size(152, 28);
            CbEmpleadoId.TabIndex = 17;
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
            // CbShipvia
            // 
            CbShipvia.FormattingEnabled = true;
            CbShipvia.Location = new Point(198, 213);
            CbShipvia.Name = "CbShipvia";
            CbShipvia.Size = new Size(133, 28);
            CbShipvia.TabIndex = 18;
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
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Poor Richard", 12F, FontStyle.Bold | FontStyle.Italic);
            label8.Location = new Point(32, 373);
            label8.Name = "label8";
            label8.Size = new Size(148, 23);
            label8.TabIndex = 19;
            label8.Text = "CIudad de envio";
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
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Poor Richard", 12F, FontStyle.Bold | FontStyle.Italic);
            label21.Location = new Point(24, 340);
            label21.Name = "label21";
            label21.Size = new Size(166, 23);
            label21.TabIndex = 20;
            label21.Text = "Dirección de envío";
            // 
            // button1
            // 
            button1.Font = new Font("Sitka Subheading", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(699, 547);
            button1.Name = "button1";
            button1.Size = new Size(139, 54);
            button1.TabIndex = 57;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Sitka Subheading", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.Location = new Point(1083, 567);
            button2.Name = "button2";
            button2.Size = new Size(67, 36);
            button2.TabIndex = 58;
            button2.Text = "Salir";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // OrderUpdateForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1162, 613);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "OrderUpdateForm";
            Text = "OrderUpdateForm";
            Load += OrderUpdateForm_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel3;
        private Label label18;
        private Panel panel2;
        private TextBox textBox3;
        private Label label19;
        private Label label17;
        private Button button4;
        private DataGridView dataGridView2;
        private Label label14;
        private Label label16;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label15;
        private Panel panel1;
        private TextBox TxtCodPostal;
        private Label label2;
        private Label label3;
        private TextBox TxtPaisEnvio;
        private Label label4;
        private TextBox TxtNombreEnvio;
        private Label label5;
        private TextBox TxtFlete;
        private Label label6;
        private Label label7;
        private TextBox txtregiondeenvio;
        private TextBox TxtDireccionEnvio;
        private DateTimePicker DateFechadeorden;
        private TextBox Txtciudadenvio;
        private DateTimePicker DateFEcharequerida;
        private DateTimePicker dateFechaenvio;
        private Label label13;
        private ComboBox CbCLienteID;
        private Label label12;
        private ComboBox CbEmpleadoId;
        private Label label11;
        private ComboBox CbShipvia;
        private Label label10;
        private Label label8;
        private Label label9;
        private Label label21;
        private Button button1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn ProductID;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn UnitPrice;
        private DataGridViewTextBoxColumn Discount;
        private DataGridViewButtonColumn Op;
        private Button button2;
    }
}