namespace CRUDDapper
{
    partial class ProductosForn
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
            COMBOSuplidor = new ComboBox();
            userProductoBindingSource = new BindingSource(components);
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            txtReordenaenivel = new TextBox();
            txtNombreProducto = new TextBox();
            txtCatidadporunidad = new TextBox();
            txtprecioporunidad = new TextBox();
            txtUnidadStock = new TextBox();
            txtUnidadesenordenes = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            bindingSource1 = new BindingSource(components);
            button5 = new Button();
            panel1 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userProductoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(451, 127);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(884, 327);
            dataGridView1.TabIndex = 0;
            // 
            // COMBOSuplidor
            // 
            COMBOSuplidor.Anchor = AnchorStyles.None;
            COMBOSuplidor.DataBindings.Add(new Binding("Text", userProductoBindingSource, "IDSuplidor", true));
            COMBOSuplidor.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic);
            COMBOSuplidor.FormattingEnabled = true;
            COMBOSuplidor.Location = new Point(225, 171);
            COMBOSuplidor.Name = "COMBOSuplidor";
            COMBOSuplidor.Size = new Size(163, 31);
            COMBOSuplidor.TabIndex = 46;
            // 
            // userProductoBindingSource
            // 
            userProductoBindingSource.DataSource = typeof(Validator.UserProducto);
            // 
            // comboBox2
            // 
            comboBox2.Anchor = AnchorStyles.None;
            comboBox2.DataBindings.Add(new Binding("Text", userProductoBindingSource, "Interumpido", true));
            comboBox2.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "True", "False" });
            comboBox2.Location = new Point(225, 497);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(163, 31);
            comboBox2.TabIndex = 45;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.None;
            comboBox1.DataBindings.Add(new Binding("Text", userProductoBindingSource, "IDCategoria", true));
            comboBox1.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(222, 224);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(166, 31);
            comboBox1.TabIndex = 44;
            // 
            // txtReordenaenivel
            // 
            txtReordenaenivel.Anchor = AnchorStyles.None;
            txtReordenaenivel.DataBindings.Add(new Binding("Text", userProductoBindingSource, "ReordenarNivel", true));
            txtReordenaenivel.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic);
            txtReordenaenivel.Location = new Point(225, 448);
            txtReordenaenivel.Name = "txtReordenaenivel";
            txtReordenaenivel.Size = new Size(163, 30);
            txtReordenaenivel.TabIndex = 43;
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Anchor = AnchorStyles.None;
            txtNombreProducto.DataBindings.Add(new Binding("Text", userProductoBindingSource, "Nameproducto", true));
            txtNombreProducto.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic);
            txtNombreProducto.Location = new Point(225, 127);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(163, 30);
            txtNombreProducto.TabIndex = 42;
            // 
            // txtCatidadporunidad
            // 
            txtCatidadporunidad.Anchor = AnchorStyles.None;
            txtCatidadporunidad.DataBindings.Add(new Binding("Text", userProductoBindingSource, "Cantidad", true));
            txtCatidadporunidad.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic);
            txtCatidadporunidad.Location = new Point(225, 267);
            txtCatidadporunidad.Name = "txtCatidadporunidad";
            txtCatidadporunidad.Size = new Size(163, 30);
            txtCatidadporunidad.TabIndex = 41;
            // 
            // txtprecioporunidad
            // 
            txtprecioporunidad.Anchor = AnchorStyles.None;
            txtprecioporunidad.DataBindings.Add(new Binding("Text", userProductoBindingSource, "PrecioUnidad", true));
            txtprecioporunidad.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic);
            txtprecioporunidad.Location = new Point(225, 318);
            txtprecioporunidad.Name = "txtprecioporunidad";
            txtprecioporunidad.Size = new Size(163, 30);
            txtprecioporunidad.TabIndex = 40;
            // 
            // txtUnidadStock
            // 
            txtUnidadStock.Anchor = AnchorStyles.None;
            txtUnidadStock.DataBindings.Add(new Binding("Text", userProductoBindingSource, "UnidadesStock", true));
            txtUnidadStock.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic);
            txtUnidadStock.Location = new Point(222, 360);
            txtUnidadStock.Name = "txtUnidadStock";
            txtUnidadStock.Size = new Size(166, 30);
            txtUnidadStock.TabIndex = 39;
            // 
            // txtUnidadesenordenes
            // 
            txtUnidadesenordenes.Anchor = AnchorStyles.None;
            txtUnidadesenordenes.DataBindings.Add(new Binding("Text", userProductoBindingSource, "UnidadesenOrden", true));
            txtUnidadesenordenes.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic);
            txtUnidadesenordenes.Location = new Point(225, 398);
            txtUnidadesenordenes.Name = "txtUnidadesenordenes";
            txtUnidadesenordenes.Size = new Size(163, 30);
            txtUnidadesenordenes.TabIndex = 38;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic);
            label10.Location = new Point(60, 448);
            label10.Name = "label10";
            label10.Size = new Size(143, 23);
            label10.TabIndex = 36;
            label10.Text = "Reordenar nivel";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic);
            label9.Location = new Point(80, 497);
            label9.Name = "label9";
            label9.Size = new Size(123, 23);
            label9.TabIndex = 35;
            label9.Text = "Interrumpido";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic);
            label8.Location = new Point(39, 394);
            label8.Name = "label8";
            label8.Size = new Size(164, 23);
            label8.TabIndex = 34;
            label8.Text = "UnidadesEnOrden";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic);
            label7.Location = new Point(39, 355);
            label7.Name = "label7";
            label7.Size = new Size(164, 23);
            label7.TabIndex = 33;
            label7.Text = "Unidades en Stock";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic);
            label6.Location = new Point(43, 310);
            label6.Name = "label6";
            label6.Size = new Size(160, 23);
            label6.TabIndex = 32;
            label6.Text = "Precio por unidad";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic);
            label5.Location = new Point(16, 260);
            label5.Name = "label5";
            label5.Size = new Size(187, 23);
            label5.TabIndex = 31;
            label5.Text = "Cantidad por unidad ";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(111, 227);
            label4.Name = "label4";
            label4.Size = new Size(92, 23);
            label4.TabIndex = 30;
            label4.Text = "Categoria";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(121, 177);
            label3.Name = "label3";
            label3.Size = new Size(82, 23);
            label3.TabIndex = 29;
            label3.Text = "Suplidor";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(52, 136);
            label2.Name = "label2";
            label2.Size = new Size(151, 23);
            label2.TabIndex = 28;
            label2.Text = "Nonbre producto";
            // 
            // button1
            // 
            button1.Font = new Font("Poor Richard", 13.8F, FontStyle.Bold | FontStyle.Italic);
            button1.Location = new Point(666, 460);
            button1.Name = "button1";
            button1.Size = new Size(199, 60);
            button1.TabIndex = 47;
            button1.Text = "Agregar ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Poor Richard", 13.8F, FontStyle.Bold | FontStyle.Italic);
            button2.Location = new Point(1136, 460);
            button2.Name = "button2";
            button2.Size = new Size(199, 60);
            button2.TabIndex = 48;
            button2.Text = "Modificar ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Poor Richard", 13.8F, FontStyle.Bold | FontStyle.Italic);
            button3.Location = new Point(901, 460);
            button3.Name = "button3";
            button3.Size = new Size(199, 60);
            button3.TabIndex = 49;
            button3.Text = "Eliminar ";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Poor Richard", 13.8F, FontStyle.Bold | FontStyle.Italic);
            button4.Location = new Point(431, 460);
            button4.Name = "button4";
            button4.Size = new Size(199, 60);
            button4.TabIndex = 50;
            button4.Text = "Leer";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Sitka Banner", 13.7999992F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button5.Location = new Point(1348, 550);
            button5.Name = "button5";
            button5.Size = new Size(68, 38);
            button5.TabIndex = 51;
            button5.Text = "Salir ";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.AntiqueWhite;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1416, 93);
            panel1.TabIndex = 52;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Subheading", 36F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(591, 0);
            label1.Name = "label1";
            label1.Size = new Size(314, 87);
            label1.TabIndex = 0;
            label1.Text = "Productos ";
            // 
            // ProductosForn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(1416, 589);
            Controls.Add(panel1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(COMBOSuplidor);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(txtReordenaenivel);
            Controls.Add(txtNombreProducto);
            Controls.Add(txtCatidadporunidad);
            Controls.Add(txtprecioporunidad);
            Controls.Add(txtUnidadStock);
            Controls.Add(txtUnidadesenordenes);
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
            Name = "ProductosForn";
            Text = "ProductosForn";
            Load += ProductosForn_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)userProductoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private ComboBox COMBOSuplidor;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private TextBox txtReordenaenivel;
        private TextBox txtNombreProducto;
        private TextBox txtCatidadporunidad;
        private TextBox txtprecioporunidad;
        private TextBox txtUnidadStock;
        private TextBox txtUnidadesenordenes;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private BindingSource bindingSource1;
        private BindingSource userProductoBindingSource;
        private Button button5;
        private Panel panel1;
        private Label label1;
    }
}