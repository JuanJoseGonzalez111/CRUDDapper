using CRUDDapper.Datos;
using CRUDDapper.Validator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CRUDDapper
{
    public partial class EmpleadoForm : Form
    {
        private Empleado _Empleado = new Empleado();
        private readonly IEmpleadoData _empleadoData1;
        public EmpleadoForm(IEmpleadoData empleadoData)
        {
            InitializeComponent();
            this._empleadoData1 = empleadoData;
        }

        private void EmpleadoForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _empleadoData1.LoadEmpleado();
            _empleadoData1.cargarcombo(comboBox1);
            _empleadoData1.cargarcomboTe(comboBox2);
            empleadoBindingSource.Add(_Empleado);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp|Todos los archivos|*.*";
            openFileDialog.Title = "Seleccionar imagen";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                string rutaImagen = openFileDialog.FileName;

                try
                {

                    if (EsImagen(rutaImagen))
                    {

                        using (Image imagen = Image.FromFile(rutaImagen))
                        {

                            pictureBox1.Image = new Bitmap(imagen);

                        }
                    }
                    else
                    {
                        MessageBox.Show("El archivo seleccionado no es una imagen válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la imagen: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private bool EsImagen(string rutaArchivo)
        {
            try
            {
                using (var img = Image.FromFile(rutaArchivo))
                {
                    return img.RawFormat.Guid == System.Drawing.Imaging.ImageFormat.Jpeg.Guid ||
                           img.RawFormat.Guid == System.Drawing.Imaging.ImageFormat.Png.Guid ||
                           img.RawFormat.Guid == System.Drawing.Imaging.ImageFormat.Bmp.Guid ||
                           img.RawFormat.Guid == System.Drawing.Imaging.ImageFormat.Gif.Guid ||
                           img.RawFormat.Guid == System.Drawing.Imaging.ImageFormat.Tiff.Guid;
                }
            }
            catch
            {
                return false;
            }
        }

        private void BtAgregar_Click(object sender, EventArgs e)
        {
            byte[] imagenBytes = null;
            if (pictureBox1.Image != null)
            {
                using (MemoryStream stream = new MemoryStream())
                {
                    pictureBox1.Image.Save(stream, ImageFormat.Jpeg);
                    imagenBytes = stream.ToArray();
                }
            }
            var Territoriotable = new DataTable();
            Territoriotable.Columns.Add("Territorio");

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    Territoriotable.Rows.Add(
                        row.Cells["Territorio"].Value

                    );
                }

            }

            var empleadoValidator = new EmpleadoValidator();

            var ValidatorResult = empleadoValidator.Validate(_Empleado);
            if (ValidatorResult.IsValid)
            {

                _empleadoData1.InsertarEmpleadoYTerritorios(Txtnombre.Text, Txtapellido.Text, Txtitulo.Text, txtcortesia.Text, dateTimePicker1.Value, dateTimePicker2.Value,
                      Txtdirrecion.Text, txtciudad.Text, txtregion.Text, txtcodpos.Text, txtpais.Text, Txttelefono.Text, txtextens.Text, imagenBytes, txtNotas.Text, int.Parse(comboBox1.Text), Territoriotable);
                MessageBox.Show("Empleado guardado correctamnete ");
                dataGridView1.DataSource = _empleadoData1.LoadEmpleado();

            }
            {
                var message = string.Join("\n", ValidatorResult.Errors.Select(a => a.ErrorMessage));
                MessageBox.Show(message, "Validation Error ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void BtEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {

                int employeeId = Convert.ToInt32(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells["EmployeeID"].Value);

                _empleadoData1.DeleteEmployee(employeeId);


                dataGridView1.DataSource = _empleadoData1.LoadEmpleado();

                MessageBox.Show("Empleado eliminado correctamente.", "Eliminación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un empleado antes de intentar eliminarlo.", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtModificar_Click(object sender, EventArgs e)
        {
            byte[] imagenBytes = null;
            if (pictureBox1.Image != null)
            {
                using (MemoryStream stream = new MemoryStream())
                {
                    pictureBox1.Image.Save(stream, ImageFormat.Jpeg);
                    imagenBytes = stream.ToArray();
                }
            }
            if (dataGridView1.SelectedCells.Count > 0)
            {

                int employeeId = Convert.ToInt32(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells["EmployeeID"].Value);


                dataGridView1.DataSource = _empleadoData1.LoadEmpleado();
                Limpiar();
                MessageBox.Show("Empleado actualizado  correctamente.", "Actualizacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un empleado antes de intentar actualizarlo.", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        public void Limpiar()
        {
            Txtnombre.Text = "";
            Txtapellido.Text = "";
            Txttelefono.Text = "";
            txtciudad.Text = " ";
            txtregion.Text = " ";
            txtcodpos.Text = " ";
            txtpais.Text = " ";
            txtNotas.Text = " ";
            txtextens.Text = " ";
            txtcortesia.Text = " ";
            Txtcodigopostal.Text = " ";
            Txtitulo.Text = " ";


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {


            string teritorio = (string)comboBox2.Text;

            _ = dataGridView1.Rows.Add(new object[] { teritorio, "Eliminar" });

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
