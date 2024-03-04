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
            Txtdescripcion = new TextBox();
            userCategoriaBindingSource = new BindingSource(components);
            txtxNombre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            bindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userCategoriaBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // Leer
            // 
            Leer.AutoSize = true;
            Leer.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            Leer.Location = new Point(688, 364);
            Leer.Name = "Leer";
            Leer.Size = new Size(113, 38);
            Leer.TabIndex = 0;
            Leer.Text = "leer";
            Leer.UseVisualStyleBackColor = true;
            Leer.Click += button1_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = SystemColors.ButtonFace;
            dataGridView2.BorderStyle = BorderStyle.Fixed3D;
            dataGridView2.CausesValidation = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(12, 138);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(823, 192);
            dataGridView2.TabIndex = 2;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // BTeliminar
            // 
            BTeliminar.AutoSize = true;
            BTeliminar.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            BTeliminar.Location = new Point(493, 364);
            BTeliminar.Name = "BTeliminar";
            BTeliminar.Size = new Size(105, 38);
            BTeliminar.TabIndex = 3;
            BTeliminar.Text = "Eliminar";
            BTeliminar.UseVisualStyleBackColor = true;
            BTeliminar.Click += BTeliminar_Click;
            // 
            // BTactualizar
            // 
            BTactualizar.AutoSize = true;
            BTactualizar.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            BTactualizar.Location = new Point(292, 364);
            BTactualizar.Name = "BTactualizar";
            BTactualizar.Size = new Size(128, 38);
            BTactualizar.TabIndex = 5;
            BTactualizar.Text = "Actualizar";
            BTactualizar.UseVisualStyleBackColor = true;
            BTactualizar.Click += BTactualizar_Click;
            // 
            // BTagregar
            // 
            BTagregar.AutoSize = true;
            BTagregar.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            BTagregar.Location = new Point(67, 364);
            BTagregar.Name = "BTagregar";
            BTagregar.Size = new Size(105, 38);
            BTagregar.TabIndex = 6;
            BTagregar.Text = "Agregar";
            BTagregar.UseVisualStyleBackColor = true;
            BTagregar.Click += BTagregar_Click;
            // 
            // Txtdescripcion
            // 
            Txtdescripcion.DataBindings.Add(new Binding("Text", userCategoriaBindingSource, "Descripcion", true));
            Txtdescripcion.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic);
            Txtdescripcion.Location = new Point(603, 66);
            Txtdescripcion.Name = "Txtdescripcion";
            Txtdescripcion.Size = new Size(138, 30);
            Txtdescripcion.TabIndex = 7;
            // 
            // userCategoriaBindingSource
            // 
            userCategoriaBindingSource.DataSource = typeof(Validator.UserCategoria);
            // 
            // txtxNombre
            // 
            txtxNombre.DataBindings.Add(new Binding("Text", userCategoriaBindingSource, "Categoriname", true));
            txtxNombre.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic);
            txtxNombre.Location = new Point(197, 66);
            txtxNombre.Name = "txtxNombre";
            txtxNombre.Size = new Size(138, 30);
            txtxNombre.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(416, 60);
            label1.Name = "label1";
            label1.Size = new Size(165, 36);
            label1.TabIndex = 9;
            label1.Text = "Descripcion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Times New Roman", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(62, 66);
            label2.Name = "label2";
            label2.Size = new Size(118, 36);
            label2.TabIndex = 10;
            label2.Text = "Nombre";
            // 
            // CategoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(847, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtxNombre);
            Controls.Add(Txtdescripcion);
            Controls.Add(BTagregar);
            Controls.Add(BTactualizar);
            Controls.Add(BTeliminar);
            Controls.Add(dataGridView2);
            Controls.Add(Leer);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "CategoryForm";
            Text = "Categories";
            Load += CategoryForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)userCategoriaBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Leer;
        private DataGridView dataGridView2;
        private Button BTeliminar;
        private Button BTactualizar;
        private Button BTagregar;
        private TextBox Txtdescripcion;
        private TextBox txtxNombre;
        private Label label1;
        private Label label2;
        private BindingSource userCategoriaBindingSource;
        private BindingSource bindingSource1;
    }
}