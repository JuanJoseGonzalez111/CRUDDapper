namespace CRUDDapper
{
    partial class RedionTerriUpdate
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
            button2 = new Button();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewComboBoxColumn();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(95, 335);
            button2.Name = "button2";
            button2.Size = new Size(132, 70);
            button2.TabIndex = 18;
            button2.Text = "Guardar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Sitka Display", 13.7999992F, FontStyle.Italic);
            textBox3.Location = new Point(592, 42);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 36);
            textBox3.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Display", 13.7999992F, FontStyle.Italic);
            label3.Location = new Point(354, 45);
            label3.Name = "label3";
            label3.Size = new Size(125, 33);
            label3.TabIndex = 16;
            label3.Text = "TerritorioID";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Sitka Display", 13.7999992F, FontStyle.Italic);
            textBox2.Location = new Point(592, 84);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 36);
            textBox2.TabIndex = 15;
            // 
            // button1
            // 
            button1.Font = new Font("Sitka Display", 13.7999992F, FontStyle.Italic);
            button1.Location = new Point(742, 113);
            button1.Name = "button1";
            button1.Size = new Size(94, 43);
            button1.TabIndex = 14;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridView1.Location = new Point(282, 175);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(476, 144);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "TerritoryDescription";
            Column1.HeaderText = "TerritoryDescription ";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "TerritoryID";
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Display", 13.7999992F, FontStyle.Italic);
            label2.Location = new Point(354, 78);
            label2.Name = "label2";
            label2.Size = new Size(214, 33);
            label2.TabIndex = 12;
            label2.Text = "Descripción Territorio";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Sitka Display", 13.7999992F, FontStyle.Italic);
            textBox1.Location = new Point(156, 49);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(158, 36);
            textBox1.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Display", 13.7999992F, FontStyle.Italic);
            label1.Location = new Point(-12, 60);
            label1.Name = "label1";
            label1.Size = new Size(120, 33);
            label1.TabIndex = 10;
            label1.Text = "Descripción";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Display", 13.7999992F, FontStyle.Italic);
            label4.Location = new Point(113, 213);
            label4.Name = "label4";
            label4.Size = new Size(0, 33);
            label4.TabIndex = 19;
            // 
            // RedionTerriUpdate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(905, 450);
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
            Name = "RedionTerriUpdate";
            Text = "Modificar territorio";
            Load += RedionTerriUpdate_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private Button button1;
        private DataGridView dataGridView1;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private Label label4;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewComboBoxColumn Column3;
    }
}