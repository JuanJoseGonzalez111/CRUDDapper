namespace CRUDDapper
{
    partial class EmpleadoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmpleadoForm));
            dataGridView1 = new DataGridView();
            Territorio = new DataGridViewTextBoxColumn();
            Op = new DataGridViewButtonColumn();
            BtEliminar = new Button();
            BtModificar = new Button();
            BtAgregar = new Button();
            label1 = new Label();
            Txtitulo = new TextBox();
            empleadoBindingSource = new BindingSource(components);
            Txtnombre = new TextBox();
            label2 = new Label();
            Txttelefono = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            Txtapellido = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label14 = new Label();
            Txtcodigopostal = new TextBox();
            Txtdirrecion = new TextBox();
            pictureBox1 = new PictureBox();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            button1 = new Button();
            txtciudad = new TextBox();
            txtpais = new TextBox();
            txtcodpos = new TextBox();
            txtregion = new TextBox();
            txtcortesia = new TextBox();
            label16 = new Label();
            txtextens = new TextBox();
            label17 = new Label();
            txtNotas = new TextBox();
            button2 = new Button();
            panel1 = new Panel();
            label13 = new Label();
            comboBox1 = new ComboBox();
            label15 = new Label();
            button3 = new Button();
            label18 = new Label();
            comboBox2 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)empleadoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.BackgroundColor = SystemColors.HighlightText;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Territorio, Op });
            dataGridView1.GridColor = Color.Crimson;
            dataGridView1.Location = new Point(898, 274);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(428, 237);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Territorio
            // 
            Territorio.HeaderText = "Territorio";
            Territorio.MinimumWidth = 6;
            Territorio.Name = "Territorio";
            Territorio.ReadOnly = true;
            Territorio.Width = 125;
            // 
            // Op
            // 
            Op.HeaderText = "Op";
            Op.MinimumWidth = 6;
            Op.Name = "Op";
            Op.ReadOnly = true;
            Op.Width = 125;
            // 
            // BtEliminar
            // 
            BtEliminar.Font = new Font("Sitka Heading", 13.7999992F, FontStyle.Italic);
            BtEliminar.Location = new Point(1148, 542);
            BtEliminar.Name = "BtEliminar";
            BtEliminar.Size = new Size(204, 84);
            BtEliminar.TabIndex = 6;
            BtEliminar.Text = "Eliminar";
            BtEliminar.UseVisualStyleBackColor = true;
            BtEliminar.Click += BtEliminar_Click;
            // 
            // BtModificar
            // 
            BtModificar.Font = new Font("Sitka Heading", 13.7999992F, FontStyle.Italic);
            BtModificar.Location = new Point(938, 542);
            BtModificar.Name = "BtModificar";
            BtModificar.Size = new Size(204, 84);
            BtModificar.TabIndex = 5;
            BtModificar.Text = "Modificar";
            BtModificar.UseVisualStyleBackColor = true;
            BtModificar.Click += BtModificar_Click;
            // 
            // BtAgregar
            // 
            BtAgregar.Font = new Font("Sitka Heading", 13.7999992F, FontStyle.Italic);
            BtAgregar.Location = new Point(751, 542);
            BtAgregar.Name = "BtAgregar";
            BtAgregar.RightToLeft = RightToLeft.No;
            BtAgregar.Size = new Size(170, 84);
            BtAgregar.TabIndex = 4;
            BtAgregar.Text = "Agregar";
            BtAgregar.UseVisualStyleBackColor = true;
            BtAgregar.Click += BtAgregar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Display", 12F, FontStyle.Italic);
            label1.Location = new Point(130, 186);
            label1.Name = "label1";
            label1.Size = new Size(59, 29);
            label1.TabIndex = 7;
            label1.Text = "Titulo";
            // 
            // Txtitulo
            // 
            Txtitulo.DataBindings.Add(new Binding("Text", empleadoBindingSource, "Title", true));
            Txtitulo.Font = new Font("Sitka Display", 12F, FontStyle.Italic);
            Txtitulo.Location = new Point(232, 186);
            Txtitulo.Name = "Txtitulo";
            Txtitulo.Size = new Size(125, 33);
            Txtitulo.TabIndex = 8;
            // 
            // empleadoBindingSource
            // 
            empleadoBindingSource.DataSource = typeof(Validator.Empleado);
            // 
            // Txtnombre
            // 
            Txtnombre.DataBindings.Add(new Binding("Text", empleadoBindingSource, "LastName", true));
            Txtnombre.Font = new Font("Sitka Display", 12F, FontStyle.Italic);
            Txtnombre.Location = new Point(232, 94);
            Txtnombre.Name = "Txtnombre";
            Txtnombre.Size = new Size(125, 33);
            Txtnombre.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Display", 12F, FontStyle.Italic);
            label2.Location = new Point(108, 94);
            label2.Name = "label2";
            label2.Size = new Size(81, 29);
            label2.TabIndex = 9;
            label2.Text = "Nombre ";
            // 
            // Txttelefono
            // 
            Txttelefono.Font = new Font("Sitka Display", 12F, FontStyle.Italic);
            Txttelefono.Location = new Point(232, 514);
            Txttelefono.Name = "Txttelefono";
            Txttelefono.Size = new Size(125, 33);
            Txttelefono.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Display", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(372, 397);
            label3.Name = "label3";
            label3.Size = new Size(57, 29);
            label3.TabIndex = 11;
            label3.Text = "Photo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Display", 12F, FontStyle.Italic);
            label4.Location = new Point(2, 314);
            label4.Name = "label4";
            label4.Size = new Size(187, 29);
            label4.TabIndex = 13;
            label4.Text = "Fecha de contratacion ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Display", 12F, FontStyle.Italic);
            label5.Location = new Point(19, 274);
            label5.Name = "label5";
            label5.Size = new Size(170, 29);
            label5.TabIndex = 15;
            label5.Text = "Fecha de nacimiento";
            // 
            // Txtapellido
            // 
            Txtapellido.AcceptsReturn = true;
            Txtapellido.DataBindings.Add(new Binding("Text", empleadoBindingSource, "FirstName", true));
            Txtapellido.Font = new Font("Sitka Display", 12F, FontStyle.Italic);
            Txtapellido.Location = new Point(232, 142);
            Txtapellido.Name = "Txtapellido";
            Txtapellido.Size = new Size(125, 33);
            Txtapellido.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sitka Display", 12F, FontStyle.Italic);
            label6.Location = new Point(113, 142);
            label6.Name = "label6";
            label6.Size = new Size(76, 29);
            label6.TabIndex = 17;
            label6.Text = "Apellido";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sitka Display", 12F, FontStyle.Italic);
            label7.Location = new Point(133, 419);
            label7.Name = "label7";
            label7.Size = new Size(45, 29);
            label7.TabIndex = 19;
            label7.Text = "Pais";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Sitka Display", 12F, FontStyle.Italic);
            label8.Location = new Point(368, 145);
            label8.Name = "label8";
            label8.Size = new Size(119, 29);
            label8.TabIndex = 20;
            label8.Text = "Codigo postal";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Sitka Display", 12F, FontStyle.Italic);
            label9.Location = new Point(105, 467);
            label9.Name = "label9";
            label9.Size = new Size(73, 29);
            label9.TabIndex = 21;
            label9.Text = "Ciudad ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Sitka Display", 12F, FontStyle.Italic);
            label10.Location = new Point(415, 105);
            label10.Name = "label10";
            label10.Size = new Size(72, 29);
            label10.TabIndex = 22;
            label10.Text = "Region ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Sitka Display", 12F, FontStyle.Italic);
            label11.Location = new Point(91, 377);
            label11.Name = "label11";
            label11.Size = new Size(87, 29);
            label11.TabIndex = 23;
            label11.Text = "Dirrecion";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Sitka Display", 12F, FontStyle.Italic);
            label12.Location = new Point(424, 186);
            label12.Name = "label12";
            label12.Size = new Size(63, 29);
            label12.TabIndex = 24;
            label12.Text = "Notas ";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Sitka Display", 12F, FontStyle.Italic);
            label14.Location = new Point(47, 514);
            label14.Name = "label14";
            label14.Size = new Size(140, 29);
            label14.TabIndex = 26;
            label14.Text = "Telefono de casa";
            // 
            // Txtcodigopostal
            // 
            Txtcodigopostal.Font = new Font("Sitka Display", 12F, FontStyle.Italic);
            Txtcodigopostal.Location = new Point(681, 83);
            Txtcodigopostal.Name = "Txtcodigopostal";
            Txtcodigopostal.Size = new Size(125, 33);
            Txtcodigopostal.TabIndex = 30;
            // 
            // Txtdirrecion
            // 
            Txtdirrecion.DataBindings.Add(new Binding("Text", empleadoBindingSource, "Address", true));
            Txtdirrecion.Font = new Font("Sitka Display", 12F, FontStyle.Italic);
            Txtdirrecion.Location = new Point(232, 374);
            Txtdirrecion.Name = "Txtdirrecion";
            Txtdirrecion.Size = new Size(125, 33);
            Txtdirrecion.TabIndex = 28;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.AntiqueWhite;
            pictureBox1.Location = new Point(435, 342);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(246, 223);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 33;
            pictureBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.DataBindings.Add(new Binding("Text", empleadoBindingSource, "BirthDate", true));
            dateTimePicker1.Font = new Font("Sitka Display", 12F, FontStyle.Italic);
            dateTimePicker1.Location = new Point(232, 274);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(125, 33);
            dateTimePicker1.TabIndex = 37;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.DataBindings.Add(new Binding("Text", empleadoBindingSource, "HireDate", true));
            dateTimePicker2.Font = new Font("Sitka Display", 12F, FontStyle.Italic);
            dateTimePicker2.Location = new Point(232, 317);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(125, 33);
            dateTimePicker2.TabIndex = 38;
            // 
            // button1
            // 
            button1.Location = new Point(476, 571);
            button1.Name = "button1";
            button1.Size = new Size(155, 43);
            button1.TabIndex = 39;
            button1.Text = "Cargar imagen ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtciudad
            // 
            txtciudad.DataBindings.Add(new Binding("Text", empleadoBindingSource, "City", true));
            txtciudad.Font = new Font("Sitka Display", 12F, FontStyle.Italic);
            txtciudad.Location = new Point(232, 463);
            txtciudad.Name = "txtciudad";
            txtciudad.Size = new Size(125, 33);
            txtciudad.TabIndex = 41;
            // 
            // txtpais
            // 
            txtpais.DataBindings.Add(new Binding("Text", empleadoBindingSource, "Country", true));
            txtpais.Font = new Font("Sitka Display", 12F, FontStyle.Italic);
            txtpais.Location = new Point(232, 418);
            txtpais.Name = "txtpais";
            txtpais.Size = new Size(125, 33);
            txtpais.TabIndex = 40;
            // 
            // txtcodpos
            // 
            txtcodpos.DataBindings.Add(new Binding("Text", empleadoBindingSource, "PostalCode", true));
            txtcodpos.Font = new Font("Sitka Display", 12F, FontStyle.Italic);
            txtcodpos.Location = new Point(515, 141);
            txtcodpos.Name = "txtcodpos";
            txtcodpos.Size = new Size(125, 33);
            txtcodpos.TabIndex = 43;
            // 
            // txtregion
            // 
            txtregion.DataBindings.Add(new Binding("Text", empleadoBindingSource, "Region", true));
            txtregion.Font = new Font("Sitka Display", 12F, FontStyle.Italic);
            txtregion.Location = new Point(515, 96);
            txtregion.Name = "txtregion";
            txtregion.Size = new Size(125, 33);
            txtregion.TabIndex = 42;
            // 
            // txtcortesia
            // 
            txtcortesia.DataBindings.Add(new Binding("Text", empleadoBindingSource, "TitleOfCourtesy", true));
            txtcortesia.Font = new Font("Sitka Display", 12F, FontStyle.Italic);
            txtcortesia.Location = new Point(232, 235);
            txtcortesia.Name = "txtcortesia";
            txtcortesia.Size = new Size(125, 33);
            txtcortesia.TabIndex = 45;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Sitka Display", 12F, FontStyle.Italic);
            label16.Location = new Point(41, 235);
            label16.Name = "label16";
            label16.Size = new Size(148, 29);
            label16.TabIndex = 44;
            label16.Text = "Titulo de cortesia";
            // 
            // txtextens
            // 
            txtextens.DataBindings.Add(new Binding("Text", empleadoBindingSource, "Extension", true));
            txtextens.Font = new Font("Sitka Display", 12F, FontStyle.Italic);
            txtextens.Location = new Point(232, 571);
            txtextens.Name = "txtextens";
            txtextens.Size = new Size(125, 33);
            txtextens.TabIndex = 47;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Sitka Display", 12F, FontStyle.Italic);
            label17.Location = new Point(113, 571);
            label17.Name = "label17";
            label17.Size = new Size(94, 29);
            label17.TabIndex = 46;
            label17.Text = "Extension ";
            // 
            // txtNotas
            // 
            txtNotas.DataBindings.Add(new Binding("Text", empleadoBindingSource, "Notes", true));
            txtNotas.Font = new Font("Sitka Display", 12F, FontStyle.Italic);
            txtNotas.Location = new Point(515, 186);
            txtNotas.Name = "txtNotas";
            txtNotas.Size = new Size(125, 33);
            txtNotas.TabIndex = 48;
            // 
            // button2
            // 
            button2.Font = new Font("Sitka Heading", 13.7999992F, FontStyle.Italic);
            button2.Location = new Point(1107, 660);
            button2.Name = "button2";
            button2.Size = new Size(164, 48);
            button2.TabIndex = 49;
            button2.Text = "Volver al inicio ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Peru;
            panel1.Controls.Add(label13);
            panel1.Location = new Point(2, 2);
            panel1.Name = "panel1";
            panel1.RightToLeft = RightToLeft.No;
            panel1.Size = new Size(1381, 86);
            panel1.TabIndex = 50;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Sitka Display", 28.1999989F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label13.Location = new Point(570, 7);
            label13.Name = "label13";
            label13.Size = new Size(221, 68);
            label13.TabIndex = 23;
            label13.Text = "Empleado.";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(516, 231);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 51;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Sitka Display", 12F, FontStyle.Italic);
            label15.Location = new Point(424, 231);
            label15.Name = "label15";
            label15.Size = new Size(75, 29);
            label15.TabIndex = 52;
            label15.Text = "Reporta";
            // 
            // button3
            // 
            button3.Location = new Point(1204, 205);
            button3.Name = "button3";
            button3.Size = new Size(94, 40);
            button3.TabIndex = 53;
            button3.Text = "Agregar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Sitka Display", 12F, FontStyle.Italic);
            label18.Location = new Point(871, 149);
            label18.Name = "label18";
            label18.Size = new Size(94, 29);
            label18.TabIndex = 55;
            label18.Text = "Territorio ";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(991, 149);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 54;
            // 
            // EmpleadoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(1385, 695);
            Controls.Add(label18);
            Controls.Add(comboBox2);
            Controls.Add(button3);
            Controls.Add(label15);
            Controls.Add(comboBox1);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(txtNotas);
            Controls.Add(txtextens);
            Controls.Add(label17);
            Controls.Add(txtcortesia);
            Controls.Add(label16);
            Controls.Add(txtcodpos);
            Controls.Add(txtregion);
            Controls.Add(txtciudad);
            Controls.Add(txtpais);
            Controls.Add(button1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(pictureBox1);
            Controls.Add(Txtdirrecion);
            Controls.Add(label14);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(Txtapellido);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(Txttelefono);
            Controls.Add(label3);
            Controls.Add(Txtnombre);
            Controls.Add(label2);
            Controls.Add(Txtitulo);
            Controls.Add(label1);
            Controls.Add(BtEliminar);
            Controls.Add(BtModificar);
            Controls.Add(BtAgregar);
            Controls.Add(dataGridView1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EmpleadoForm";
            Text = "EmpleadoForm";
            Load += EmpleadoForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)empleadoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button BtEliminar;
        private Button BtModificar;
        private Button BtAgregar;
        private Label label1;
        private TextBox Txtitulo;
        private TextBox Txtnombre;
        private Label label2;
        private TextBox Txttelefono;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox5;
        private Label label5;
        private TextBox Txtapellido;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label14;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox Txtcodigopostal;
        private TextBox textBox10;
        private TextBox Txtdirrecion;
        private PictureBox pictureBox1;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Button button1;
        private TextBox txtciudad;
        private TextBox txtpais;
        private TextBox txtcodpos;
        private TextBox txtregion;
        private TextBox txtcortesia;
        private Label label16;
        private TextBox txtextens;
        private Label label17;
        private TextBox txtNotas;
        private Button button2;
        private Panel panel1;
        private Label label13;
        private BindingSource empleadoBindingSource;
        private ComboBox comboBox1;
        private Label label15;
        private Button button3;
        private Label label18;
        private ComboBox comboBox2;
        private DataGridViewTextBoxColumn Territorio;
        private DataGridViewButtonColumn Op;
    }
}