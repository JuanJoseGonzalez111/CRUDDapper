namespace CRUDDapper
{
    partial class RegionTerritoioForms
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
            textBox1 = new TextBox();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewComboBoxColumn();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label3 = new Label();
            button2 = new Button();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Display", 13.7999992F, FontStyle.Italic);
            label1.Location = new Point(88, 122);
            label1.Name = "label1";
            label1.Size = new Size(120, 33);
            label1.TabIndex = 0;
            label1.Text = "Descripción";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Sitka Display", 13.7999992F, FontStyle.Italic);
            textBox1.Location = new Point(219, 122);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(158, 36);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Display", 13.7999992F, FontStyle.Italic);
            label2.Location = new Point(14, 234);
            label2.Name = "label2";
            label2.Size = new Size(214, 33);
            label2.TabIndex = 3;
            label2.Text = "Descripción Territorio";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridView1.Location = new Point(432, 122);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(432, 178);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "TerritoryDescription ";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "TerritoryID";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Op";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Resizable = DataGridViewTriState.True;
            Column3.SortMode = DataGridViewColumnSortMode.Automatic;
            Column3.Width = 125;
            // 
            // button1
            // 
            button1.Font = new Font("Sitka Display", 13.7999992F, FontStyle.Italic);
            button1.Location = new Point(293, 313);
            button1.Name = "button1";
            button1.Size = new Size(94, 43);
            button1.TabIndex = 5;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Sitka Display", 13.7999992F, FontStyle.Italic);
            textBox2.Location = new Point(252, 240);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 36);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Sitka Display", 13.7999992F, FontStyle.Italic);
            textBox3.Location = new Point(252, 198);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 36);
            textBox3.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Display", 13.7999992F, FontStyle.Italic);
            label3.Location = new Point(14, 201);
            label3.Name = "label3";
            label3.Size = new Size(125, 33);
            label3.TabIndex = 7;
            label3.Text = "TerritorioID";
            // 
            // button2
            // 
            button2.Location = new Point(462, 351);
            button2.Name = "button2";
            button2.Size = new Size(132, 70);
            button2.TabIndex = 9;
            button2.Text = "Guardar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Display", 28.1999989F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(376, 9);
            label4.Name = "label4";
            label4.Size = new Size(156, 68);
            label4.TabIndex = 10;
            label4.Text = "Región";
            // 
            // RegionTerritoioForms
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(912, 448);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "RegionTerritoioForms";
            Text = "RegionTerritoioForms";
            Load += RegionTerritoioForms_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private DataGridView dataGridView1;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label3;
        private Button button2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewComboBoxColumn Column3;
        private Label label4;
    }
}