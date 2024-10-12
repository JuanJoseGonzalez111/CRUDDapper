namespace CRUDDapper
{
    partial class EmpleadoinicioForms
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
            dataGridView1 = new DataGridView();
            BtEliminar = new Button();
            BtModificar = new Button();
            BtAgregar = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(27, 103);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(761, 335);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // BtEliminar
            // 
            BtEliminar.Font = new Font("Sitka Heading", 13.7999992F, FontStyle.Italic);
            BtEliminar.Location = new Point(662, 21);
            BtEliminar.Name = "BtEliminar";
            BtEliminar.Size = new Size(111, 55);
            BtEliminar.TabIndex = 9;
            BtEliminar.Text = "Eliminar";
            BtEliminar.UseVisualStyleBackColor = true;
            BtEliminar.Click += BtEliminar_Click;
            // 
            // BtModificar
            // 
            BtModificar.Font = new Font("Sitka Heading", 13.7999992F, FontStyle.Italic);
            BtModificar.Location = new Point(537, 21);
            BtModificar.Name = "BtModificar";
            BtModificar.Size = new Size(111, 55);
            BtModificar.TabIndex = 8;
            BtModificar.Text = "Modificar";
            BtModificar.UseVisualStyleBackColor = true;
            BtModificar.Click += BtModificar_Click;
            // 
            // BtAgregar
            // 
            BtAgregar.Font = new Font("Sitka Heading", 13.7999992F, FontStyle.Italic);
            BtAgregar.Location = new Point(401, 21);
            BtAgregar.Name = "BtAgregar";
            BtAgregar.RightToLeft = RightToLeft.No;
            BtAgregar.Size = new Size(111, 55);
            BtAgregar.TabIndex = 7;
            BtAgregar.Text = "Agregar";
            BtAgregar.UseVisualStyleBackColor = true;
            BtAgregar.Click += BtAgregar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Heading", 28.1999989F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(44, 9);
            label1.Name = "label1";
            label1.Size = new Size(219, 68);
            label1.TabIndex = 10;
            label1.Text = "Empleado";
            // 
            // EmpleadoinicioForms
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(BtEliminar);
            Controls.Add(BtModificar);
            Controls.Add(BtAgregar);
            Controls.Add(dataGridView1);
            Name = "EmpleadoinicioForms";
            Text = "EmpleadoinicioForms";
            Load += EmpleadoinicioForms_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button BtEliminar;
        private Button BtModificar;
        private Button BtAgregar;
        private Label label1;
    }
}