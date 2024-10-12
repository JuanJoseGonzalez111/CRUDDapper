namespace CRUDDapper
{
    partial class Orders
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
            btAgregar = new Button();
            bteliminar = new Button();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            OrderID = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { OrderID });
            dataGridView1.Location = new Point(12, 66);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(965, 373);
            dataGridView1.TabIndex = 0;
            // 
            // btAgregar
            // 
            btAgregar.Font = new Font("Sitka Banner", 16.1999989F, FontStyle.Bold | FontStyle.Italic);
            btAgregar.Location = new Point(437, 2);
            btAgregar.Name = "btAgregar";
            btAgregar.Size = new Size(174, 55);
            btAgregar.TabIndex = 1;
            btAgregar.Text = "Agregar";
            btAgregar.UseVisualStyleBackColor = true;
            btAgregar.Click += btAgregar_Click_1;
            // 
            // bteliminar
            // 
            bteliminar.Font = new Font("Sitka Banner", 16.1999989F, FontStyle.Bold | FontStyle.Italic);
            bteliminar.Location = new Point(632, 2);
            bteliminar.Name = "bteliminar";
            bteliminar.Size = new Size(174, 55);
            bteliminar.TabIndex = 2;
            bteliminar.Text = "Eliminar";
            bteliminar.UseVisualStyleBackColor = true;
            bteliminar.Click += bteliminar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Banner", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, -24);
            label1.Name = "label1";
            label1.Size = new Size(187, 87);
            label1.TabIndex = 3;
            label1.Text = "Orden";
            // 
            // button1
            // 
            button1.Font = new Font("Sitka Banner", 16.1999989F, FontStyle.Bold | FontStyle.Italic);
            button1.Location = new Point(812, 0);
            button1.Name = "button1";
            button1.Size = new Size(174, 55);
            button1.TabIndex = 4;
            button1.Text = "Modificar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Sitka Display", 13.7999992F, FontStyle.Italic);
            button2.Location = new Point(159, 445);
            button2.Name = "button2";
            button2.Size = new Size(123, 45);
            button2.TabIndex = 5;
            button2.Text = "Atrás";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Sitka Display", 13.7999992F, FontStyle.Italic);
            button3.Location = new Point(840, 445);
            button3.Name = "button3";
            button3.Size = new Size(123, 45);
            button3.TabIndex = 6;
            button3.Text = "Salir";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // OrderID
            // 
            OrderID.DataPropertyName = "OrderID";
            OrderID.HeaderText = "OrderID";
            OrderID.MinimumWidth = 6;
            OrderID.Name = "OrderID";
            OrderID.Width = 125;
            // 
            // Orders
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(1018, 508);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(bteliminar);
            Controls.Add(btAgregar);
            Controls.Add(dataGridView1);
            Name = "Orders";
            Text = "Orders";
            Load += Orders_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btAgregar;
        private Button bteliminar;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridViewTextBoxColumn OrderID;
    }
}