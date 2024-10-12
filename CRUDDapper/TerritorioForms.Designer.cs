namespace CRUDDapper
{
    partial class TerritorioForms
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
            txtTerritorioDescrip = new TextBox();
            txtTerritorioID = new TextBox();
            label3 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            Btmodificar = new Button();
            BtEliminar = new Button();
            BtAgregar = new Button();
            label6 = new Label();
            CbShipvia = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtTerritorioDescrip
            // 
            txtTerritorioDescrip.Anchor = AnchorStyles.None;
            txtTerritorioDescrip.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic);
            txtTerritorioDescrip.Location = new Point(222, 167);
            txtTerritorioDescrip.Name = "txtTerritorioDescrip";
            txtTerritorioDescrip.Size = new Size(120, 30);
            txtTerritorioDescrip.TabIndex = 47;
            // 
            // txtTerritorioID
            // 
            txtTerritorioID.Anchor = AnchorStyles.None;
            txtTerritorioID.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic);
            txtTerritorioID.Location = new Point(222, 129);
            txtTerritorioID.Name = "txtTerritorioID";
            txtTerritorioID.Size = new Size(120, 30);
            txtTerritorioID.TabIndex = 46;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(5, 174);
            label3.Name = "label3";
            label3.Size = new Size(196, 23);
            label3.TabIndex = 45;
            label3.Text = "Territorio Descripción";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(88, 132);
            label2.Name = "label2";
            label2.Size = new Size(118, 23);
            label2.TabIndex = 44;
            label2.Text = "Territorio ID";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(372, 82);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(467, 187);
            dataGridView1.TabIndex = 43;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Btmodificar
            // 
            Btmodificar.Font = new Font("Modern No. 20", 13.7999992F, FontStyle.Bold | FontStyle.Italic);
            Btmodificar.Location = new Point(490, 287);
            Btmodificar.Name = "Btmodificar";
            Btmodificar.Size = new Size(145, 61);
            Btmodificar.TabIndex = 54;
            Btmodificar.Text = "Modificar";
            Btmodificar.UseVisualStyleBackColor = true;
            Btmodificar.Click += Btmodificar_Click;
            // 
            // BtEliminar
            // 
            BtEliminar.Font = new Font("Modern No. 20", 13.7999992F, FontStyle.Bold | FontStyle.Italic);
            BtEliminar.Location = new Point(685, 287);
            BtEliminar.Name = "BtEliminar";
            BtEliminar.Size = new Size(145, 61);
            BtEliminar.TabIndex = 53;
            BtEliminar.Text = "Eliminar";
            BtEliminar.UseVisualStyleBackColor = true;
            BtEliminar.Click += BtEliminar_Click;
            // 
            // BtAgregar
            // 
            BtAgregar.Font = new Font("Modern No. 20", 13.7999992F, FontStyle.Bold | FontStyle.Italic);
            BtAgregar.Location = new Point(282, 287);
            BtAgregar.Name = "BtAgregar";
            BtAgregar.Size = new Size(145, 61);
            BtAgregar.TabIndex = 52;
            BtAgregar.Text = "Agregar";
            BtAgregar.UseVisualStyleBackColor = true;
            BtAgregar.Click += BtAgregar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Poor Richard", 12F, FontStyle.Bold | FontStyle.Italic);
            label6.Location = new Point(95, 200);
            label6.Name = "label6";
            label6.Size = new Size(97, 23);
            label6.TabIndex = 56;
            label6.Text = "Región ID ";
            // 
            // CbShipvia
            // 
            CbShipvia.FormattingEnabled = true;
            CbShipvia.Location = new Point(208, 212);
            CbShipvia.Name = "CbShipvia";
            CbShipvia.Size = new Size(133, 28);
            CbShipvia.TabIndex = 57;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(224, 14);
            label1.Name = "label1";
            label1.Size = new Size(221, 52);
            label1.TabIndex = 58;
            label1.Text = "Territorio ";
            // 
            // TerritorioForms
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(940, 363);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(CbShipvia);
            Controls.Add(Btmodificar);
            Controls.Add(BtEliminar);
            Controls.Add(BtAgregar);
            Controls.Add(txtTerritorioDescrip);
            Controls.Add(txtTerritorioID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Name = "TerritorioForms";
            Text = "TerritorioForms";
            Load += TerritorioForms_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTerritorioDescrip;
        private TextBox txtTerritorioID;
        private Label label3;
        private Label label2;
        private DataGridView dataGridView1;
        private Button Btmodificar;
        private Button BtEliminar;
        private Button BtAgregar;
        private Label label6;
        private ComboBox CbShipvia;
        private Label label1;
    }
}