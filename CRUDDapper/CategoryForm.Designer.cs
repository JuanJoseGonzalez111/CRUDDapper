namespace CRUDDapper
{
    partial class CategoryForm
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
            Leer = new Button();
            dataGridView2 = new DataGridView();
            BTeliminar = new Button();
            BTactualizar = new Button();
            BTagregar = new Button();
            userCategoriaBindingSource = new BindingSource(components);
            bindingSource1 = new BindingSource(components);
            label3 = new Label();
            panel2 = new Panel();
            button1 = new Button();
            label1 = new Label();
            txtxNombre = new TextBox();
            label2 = new Label();
            Txtdescripcion = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userCategoriaBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // Leer
            // 
            Leer.AutoSize = true;
            Leer.BackColor = Color.Transparent;
            Leer.Font = new Font("Sitka Heading Semibold", 16.1999989F, FontStyle.Bold);
            Leer.Location = new Point(424, 441);
            Leer.Name = "Leer";
            Leer.Size = new Size(134, 67);
            Leer.TabIndex = 0;
            Leer.Text = "leer";
            Leer.UseVisualStyleBackColor = false;
            Leer.Click += button1_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.BackgroundColor = SystemColors.ButtonFace;
            dataGridView2.BorderStyle = BorderStyle.Fixed3D;
            dataGridView2.CausesValidation = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(411, 94);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(713, 324);
            dataGridView2.TabIndex = 2;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // BTeliminar
            // 
            BTeliminar.AutoSize = true;
            BTeliminar.BackColor = Color.Transparent;
            BTeliminar.Font = new Font("Sitka Heading Semibold", 16.1999989F, FontStyle.Bold);
            BTeliminar.Location = new Point(928, 442);
            BTeliminar.Name = "BTeliminar";
            BTeliminar.Size = new Size(129, 64);
            BTeliminar.TabIndex = 3;
            BTeliminar.Text = "Eliminar";
            BTeliminar.UseVisualStyleBackColor = false;
            BTeliminar.Click += BTeliminar_Click;
            // 
            // BTactualizar
            // 
            BTactualizar.AutoSize = true;
            BTactualizar.BackColor = Color.Transparent;
            BTactualizar.Font = new Font("Sitka Heading Semibold", 16.1999989F, FontStyle.Bold);
            BTactualizar.Location = new Point(756, 441);
            BTactualizar.Name = "BTactualizar";
            BTactualizar.Size = new Size(143, 64);
            BTactualizar.TabIndex = 5;
            BTactualizar.Text = "Actualizar";
            BTactualizar.UseVisualStyleBackColor = false;
            BTactualizar.Click += BTactualizar_Click;
            // 
            // BTagregar
            // 
            BTagregar.AutoSize = true;
            BTagregar.BackColor = Color.Transparent;
            BTagregar.Font = new Font("Sitka Heading Semibold", 16.1999989F, FontStyle.Bold);
            BTagregar.Location = new Point(587, 444);
            BTagregar.Name = "BTagregar";
            BTagregar.Size = new Size(130, 64);
            BTagregar.TabIndex = 6;
            BTagregar.Text = "Agregar";
            BTagregar.UseVisualStyleBackColor = false;
            BTagregar.Click += BTagregar_Click;
            // 
            // userCategoriaBindingSource
            // 
            userCategoriaBindingSource.DataSource = typeof(Validator.UserCategoria);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Banner", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(482, 0);
            label3.Name = "label3";
            label3.Size = new Size(274, 87);
            label3.TabIndex = 12;
            label3.Text = "Categoria";
            // 
            // panel2
            // 
            panel2.BackColor = Color.OldLace;
            panel2.Controls.Add(label3);
            panel2.Location = new Point(-3, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(1163, 87);
            panel2.TabIndex = 13;
            // 
            // button1
            // 
            button1.Font = new Font("Sitka Banner Semibold", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(1075, 535);
            button1.Name = "button1";
            button1.Size = new Size(85, 52);
            button1.TabIndex = 13;
            button1.Text = "Sallir ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 292);
            label1.Name = "label1";
            label1.Size = new Size(165, 36);
            label1.TabIndex = 9;
            label1.Text = "Descripción";
            // 
            // txtxNombre
            // 
            txtxNombre.DataBindings.Add(new Binding("Text", userCategoriaBindingSource, "Categoriname", true));
            txtxNombre.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic);
            txtxNombre.Location = new Point(203, 204);
            txtxNombre.Name = "txtxNombre";
            txtxNombre.Size = new Size(170, 30);
            txtxNombre.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Times New Roman", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(17, 204);
            label2.Name = "label2";
            label2.Size = new Size(118, 36);
            label2.TabIndex = 10;
            label2.Text = "Nombre";
            // 
            // Txtdescripcion
            // 
            Txtdescripcion.DataBindings.Add(new Binding("Text", userCategoriaBindingSource, "Descripcion", true));
            Txtdescripcion.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic);
            Txtdescripcion.Location = new Point(222, 298);
            Txtdescripcion.Name = "Txtdescripcion";
            Txtdescripcion.Size = new Size(151, 30);
            Txtdescripcion.TabIndex = 7;
            // 
            // CategoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(1161, 586);
            Controls.Add(button1);
            Controls.Add(Txtdescripcion);
            Controls.Add(label1);
            Controls.Add(BTeliminar);
            Controls.Add(label2);
            Controls.Add(BTactualizar);
            Controls.Add(txtxNombre);
            Controls.Add(dataGridView2);
            Controls.Add(BTagregar);
            Controls.Add(Leer);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "CategoryForm";
            Text = "Categories";
            Load += CategoryForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)userCategoriaBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Leer;
        private DataGridView dataGridView2;
        private Button BTeliminar;
        private Button BTactualizar;
        private Button BTagregar;
        private BindingSource userCategoriaBindingSource;
        private BindingSource bindingSource1;
        private Label label3;
        private Panel panel2;
        private Button button1;
        private Label label1;
        private TextBox txtxNombre;
        private Label label2;
        private TextBox Txtdescripcion;
    }
}