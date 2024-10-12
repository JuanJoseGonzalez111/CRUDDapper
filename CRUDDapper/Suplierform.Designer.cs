namespace CRUDDapper
{
    partial class Suplierform
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
            txtCodigopostal = new TextBox();
            userSuplidoresBindingSource = new BindingSource(components);
            txtHomepage = new TextBox();
            txtFax = new TextBox();
            txtcontatoTitle = new TextBox();
            txtRegion = new TextBox();
            txtNombreconta = new TextBox();
            txtPais = new TextBox();
            txtciudad = new TextBox();
            txttelefono = new TextBox();
            txtDirrecion = new TextBox();
            txtNombreCon = new TextBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            BtAgregar = new Button();
            BtEliminar = new Button();
            Btmodificar = new Button();
            button1 = new Button();
            bindingSource1 = new BindingSource(components);
            panel1 = new Panel();
            label1 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userSuplidoresBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(424, 101);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(813, 351);
            dataGridView1.TabIndex = 0;
            // 
            // txtCodigopostal
            // 
            txtCodigopostal.Anchor = AnchorStyles.None;
            txtCodigopostal.DataBindings.Add(new Binding("Text", userSuplidoresBindingSource, "COd_postal", true));
            txtCodigopostal.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic);
            txtCodigopostal.Location = new Point(215, 380);
            txtCodigopostal.Name = "txtCodigopostal";
            txtCodigopostal.Size = new Size(155, 30);
            txtCodigopostal.TabIndex = 47;
            // 
            // userSuplidoresBindingSource
            // 
            userSuplidoresBindingSource.DataSource = typeof(Validator.UserSuplidores);
            // 
            // txtHomepage
            // 
            txtHomepage.Anchor = AnchorStyles.None;
            txtHomepage.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic);
            txtHomepage.Location = new Point(215, 501);
            txtHomepage.Name = "txtHomepage";
            txtHomepage.Size = new Size(155, 30);
            txtHomepage.TabIndex = 46;
            // 
            // txtFax
            // 
            txtFax.Anchor = AnchorStyles.None;
            txtFax.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic);
            txtFax.Location = new Point(215, 547);
            txtFax.Name = "txtFax";
            txtFax.Size = new Size(155, 30);
            txtFax.TabIndex = 45;
            // 
            // txtcontatoTitle
            // 
            txtcontatoTitle.Anchor = AnchorStyles.None;
            txtcontatoTitle.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic);
            txtcontatoTitle.Location = new Point(215, 339);
            txtcontatoTitle.Name = "txtcontatoTitle";
            txtcontatoTitle.Size = new Size(155, 30);
            txtcontatoTitle.TabIndex = 44;
            // 
            // txtRegion
            // 
            txtRegion.Anchor = AnchorStyles.None;
            txtRegion.DataBindings.Add(new Binding("Text", userSuplidoresBindingSource, "Region", true));
            txtRegion.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic);
            txtRegion.Location = new Point(215, 181);
            txtRegion.Name = "txtRegion";
            txtRegion.Size = new Size(155, 30);
            txtRegion.TabIndex = 43;
            // 
            // txtNombreconta
            // 
            txtNombreconta.Anchor = AnchorStyles.None;
            txtNombreconta.DataBindings.Add(new Binding("Text", userSuplidoresBindingSource, "Nombrecontacto", true));
            txtNombreconta.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic);
            txtNombreconta.Location = new Point(215, 130);
            txtNombreconta.Name = "txtNombreconta";
            txtNombreconta.Size = new Size(155, 30);
            txtNombreconta.TabIndex = 42;
            // 
            // txtPais
            // 
            txtPais.Anchor = AnchorStyles.None;
            txtPais.DataBindings.Add(new Binding("Text", userSuplidoresBindingSource, "Pais", true));
            txtPais.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic);
            txtPais.Location = new Point(215, 467);
            txtPais.Name = "txtPais";
            txtPais.Size = new Size(155, 30);
            txtPais.TabIndex = 41;
            // 
            // txtciudad
            // 
            txtciudad.Anchor = AnchorStyles.None;
            txtciudad.BackColor = Color.White;
            txtciudad.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic);
            txtciudad.Location = new Point(215, 426);
            txtciudad.Name = "txtciudad";
            txtciudad.Size = new Size(155, 30);
            txtciudad.TabIndex = 40;
            // 
            // txttelefono
            // 
            txttelefono.Anchor = AnchorStyles.None;
            txttelefono.DataBindings.Add(new Binding("Text", userSuplidoresBindingSource, "telefono", true));
            txttelefono.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic);
            txttelefono.Location = new Point(215, 290);
            txttelefono.Name = "txttelefono";
            txttelefono.Size = new Size(155, 30);
            txttelefono.TabIndex = 39;
            // 
            // txtDirrecion
            // 
            txtDirrecion.Anchor = AnchorStyles.None;
            txtDirrecion.DataBindings.Add(new Binding("Text", userSuplidoresBindingSource, "direccion", true));
            txtDirrecion.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic);
            txtDirrecion.Location = new Point(215, 239);
            txtDirrecion.Name = "txtDirrecion";
            txtDirrecion.Size = new Size(155, 30);
            txtDirrecion.TabIndex = 38;
            // 
            // txtNombreCon
            // 
            txtNombreCon.Anchor = AnchorStyles.None;
            txtNombreCon.DataBindings.Add(new Binding("Text", userSuplidoresBindingSource, "Nombrecompañia", true));
            txtNombreCon.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic);
            txtNombreCon.Location = new Point(215, 92);
            txtNombreCon.Name = "txtNombreCon";
            txtNombreCon.Size = new Size(155, 30);
            txtNombreCon.TabIndex = 37;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.None;
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic);
            label12.Location = new Point(101, 504);
            label12.Name = "label12";
            label12.Size = new Size(102, 23);
            label12.TabIndex = 35;
            label12.Text = "HomePage";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic);
            label11.Location = new Point(107, 429);
            label11.Name = "label11";
            label11.Size = new Size(70, 23);
            label11.TabIndex = 34;
            label11.Text = "Ciudad";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic);
            label10.Location = new Point(107, 246);
            label10.Name = "label10";
            label10.Size = new Size(96, 23);
            label10.TabIndex = 33;
            label10.Text = "Dirrecion ";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic);
            label9.Location = new Point(118, 183);
            label9.Name = "label9";
            label9.Size = new Size(69, 23);
            label9.TabIndex = 32;
            label9.Text = "Region";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic);
            label8.Location = new Point(53, 380);
            label8.Name = "label8";
            label8.Size = new Size(124, 23);
            label8.TabIndex = 31;
            label8.Text = "Codigo postal";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic);
            label7.Location = new Point(126, 467);
            label7.Name = "label7";
            label7.Size = new Size(51, 23);
            label7.TabIndex = 30;
            label7.Text = "Pais ";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic);
            label6.Location = new Point(37, 342);
            label6.Name = "label6";
            label6.Size = new Size(140, 23);
            label6.TabIndex = 29;
            label6.Text = "Titulo Contacto";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic);
            label5.Location = new Point(95, 293);
            label5.Name = "label5";
            label5.Size = new Size(82, 23);
            label5.TabIndex = 28;
            label5.Text = "Telefono";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(134, 547);
            label4.Name = "label4";
            label4.Size = new Size(43, 23);
            label4.TabIndex = 27;
            label4.Text = "Fax";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(34, 130);
            label3.Name = "label3";
            label3.Size = new Size(153, 23);
            label3.TabIndex = 26;
            label3.Text = "Nombre contacto";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(19, 88);
            label2.Name = "label2";
            label2.Size = new Size(168, 23);
            label2.TabIndex = 25;
            label2.Text = "Nombre Compañia";
            // 
            // BtAgregar
            // 
            BtAgregar.Font = new Font("Modern No. 20", 13.7999992F, FontStyle.Bold | FontStyle.Italic);
            BtAgregar.Location = new Point(627, 483);
            BtAgregar.Name = "BtAgregar";
            BtAgregar.Size = new Size(145, 61);
            BtAgregar.TabIndex = 48;
            BtAgregar.Text = "Agregar";
            BtAgregar.UseVisualStyleBackColor = true;
            BtAgregar.Click += BtAgregar_Click;
            // 
            // BtEliminar
            // 
            BtEliminar.Font = new Font("Modern No. 20", 13.7999992F, FontStyle.Bold | FontStyle.Italic);
            BtEliminar.Location = new Point(1023, 483);
            BtEliminar.Name = "BtEliminar";
            BtEliminar.Size = new Size(145, 61);
            BtEliminar.TabIndex = 49;
            BtEliminar.Text = "Eliminar";
            BtEliminar.UseVisualStyleBackColor = true;
            BtEliminar.Click += BtEliminar_Click;
            // 
            // Btmodificar
            // 
            Btmodificar.Font = new Font("Modern No. 20", 13.7999992F, FontStyle.Bold | FontStyle.Italic);
            Btmodificar.Location = new Point(835, 483);
            Btmodificar.Name = "Btmodificar";
            Btmodificar.Size = new Size(145, 61);
            Btmodificar.TabIndex = 50;
            Btmodificar.Text = "Modificar";
            Btmodificar.UseVisualStyleBackColor = true;
            Btmodificar.Click += Btmodificar_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Modern No. 20", 13.7999992F, FontStyle.Bold | FontStyle.Italic);
            button1.Location = new Point(414, 483);
            button1.Name = "button1";
            button1.Size = new Size(145, 61);
            button1.TabIndex = 51;
            button1.Text = "Leer";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.OldLace;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(5, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1359, 78);
            panel1.TabIndex = 52;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Subheading", 28.1999989F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(565, 6);
            label1.Name = "label1";
            label1.Size = new Size(243, 68);
            label1.TabIndex = 0;
            label1.Text = "Suplidores";
            // 
            // button2
            // 
            button2.Font = new Font("Sitka Banner", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.Location = new Point(1278, 541);
            button2.Name = "button2";
            button2.Size = new Size(65, 36);
            button2.TabIndex = 53;
            button2.Text = "Salir ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Suplierform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(1355, 589);
            Controls.Add(button2);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(Btmodificar);
            Controls.Add(BtEliminar);
            Controls.Add(BtAgregar);
            Controls.Add(txtCodigopostal);
            Controls.Add(txtHomepage);
            Controls.Add(txtFax);
            Controls.Add(txtcontatoTitle);
            Controls.Add(txtRegion);
            Controls.Add(txtNombreconta);
            Controls.Add(txtPais);
            Controls.Add(txtciudad);
            Controls.Add(txttelefono);
            Controls.Add(txtDirrecion);
            Controls.Add(txtNombreCon);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Name = "Suplierform";
            Text = "Suplierform";
            Load += Suplierform_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)userSuplidoresBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtCodigopostal;
        private TextBox txtHomepage;
        private TextBox txtFax;
        private TextBox txtcontatoTitle;
        private TextBox txtRegion;
        private TextBox txtNombreconta;
        private TextBox txtPais;
        private TextBox txtciudad;
        private TextBox txttelefono;
        private TextBox txtDirrecion;
        private TextBox txtNombreCon;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button BtAgregar;
        private Button BtEliminar;
        private Button Btmodificar;
        private Button button1;
        private BindingSource bindingSource1;
        private BindingSource userSuplidoresBindingSource;
        private Panel panel1;
        private Label label1;
        private Button button2;
    }
}