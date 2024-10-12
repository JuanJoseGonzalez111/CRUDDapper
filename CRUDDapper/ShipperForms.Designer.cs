namespace CRUDDapper
{
    partial class ShipperForms
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
            txtCompaniname = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtTelefono = new TextBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtCompaniname
            // 
            txtCompaniname.Location = new Point(297, 110);
            txtCompaniname.Name = "txtCompaniname";
            txtCompaniname.Size = new Size(125, 27);
            txtCompaniname.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Heading", 16.1999989F, FontStyle.Italic);
            label1.Location = new Point(19, 110);
            label1.Name = "label1";
            label1.Size = new Size(250, 39);
            label1.TabIndex = 1;
            label1.Text = "Nombre de compañia";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Heading", 16.1999989F, FontStyle.Italic);
            label2.Location = new Point(168, 174);
            label2.Name = "label2";
            label2.Size = new Size(109, 39);
            label2.TabIndex = 3;
            label2.Text = "Telefono";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(305, 174);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(125, 27);
            txtTelefono.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(535, 66);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(524, 184);
            dataGridView1.TabIndex = 4;
            // 
            // button1
            // 
            button1.Font = new Font("Sitka Heading", 16.1999989F, FontStyle.Italic);
            button1.Location = new Point(231, 287);
            button1.Name = "button1";
            button1.Size = new Size(215, 69);
            button1.TabIndex = 5;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Sitka Heading", 16.1999989F, FontStyle.Italic);
            button2.Location = new Point(474, 287);
            button2.Name = "button2";
            button2.Size = new Size(215, 69);
            button2.TabIndex = 6;
            button2.Text = "Modificar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Sitka Heading", 16.1999989F, FontStyle.Italic);
            button3.Location = new Point(714, 287);
            button3.Name = "button3";
            button3.Size = new Size(215, 69);
            button3.TabIndex = 7;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // ShipperForms
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(1110, 420);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(txtTelefono);
            Controls.Add(label1);
            Controls.Add(txtCompaniname);
            Name = "ShipperForms";
            Text = "Shipper";
            Load += ShipperForms_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCompaniname;
        private Label label1;
        private Label label2;
        private TextBox txtTelefono;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}