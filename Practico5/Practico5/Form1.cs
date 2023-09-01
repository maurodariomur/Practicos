using Microsoft.VisualBasic.ApplicationServices;
using System.Data;
using System.Windows.Forms;

namespace Practico5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Filtra por tipos de archivo de imagen
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedImagePath = openFileDialog.FileName;

                // Mostrar la imagen en el PictureBox
                PUsuario.Image = Image.FromFile(selectedImagePath);

                // Mostrar la ruta del archivo en el TextBox
                TFoto.Text = selectedImagePath;

            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (TNombre.SelectionStart == 0) // Verificar si es la primera letra
            {
                e.KeyChar = char.ToUpper(e.KeyChar); // Convertir a mayúscula
            }
            else if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (TApellido.SelectionStart == 0)
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
            else if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nombre = TNombre.Text;
            string apellido = TApellido.Text;
            DateTime fecha = DTFecha.Value;
            string genero = "";
            string saldo = TSaldo.Text;
            Image foto = PUsuario.Image;
            string url = TFoto.Text;

            if (RHombre.Checked)
            {
                genero = "Hombre";
            }
            else if (RMujer.Checked)
            {
                genero = "Mujer";
            }

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido) || string.IsNullOrWhiteSpace(genero) || string.IsNullOrWhiteSpace(saldo) || string.IsNullOrWhiteSpace(url))
            {
                MessageBox.Show("Por Favor completar todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Agregar una nueva fila al DataGridView con los datos recolectados
                int rowIndex = dataGridView1.Rows.Add();

                // Asignar los valores a las celdas correspondientes
                dataGridView1.Rows[rowIndex].Cells["Nombre"].Value = nombre;
                dataGridView1.Rows[rowIndex].Cells["Apellido"].Value = apellido;
                dataGridView1.Rows[rowIndex].Cells["FechaNacimiento"].Value = fecha.ToString("dd/MM/yyyy");
                dataGridView1.Rows[rowIndex].Cells["Eliminar"].Value = "Eliminar"; // Botón de eliminar
                dataGridView1.Rows[rowIndex].Cells["Sexo"].Value = genero;
                dataGridView1.Rows[rowIndex].Cells["Saldo"].Value = saldo;
                dataGridView1.Rows[rowIndex].Cells["Foto"].Value = ResizeImage(foto, 50, 50); // Redimensiona la imagen
                dataGridView1.Rows[rowIndex].Cells["Ruta"].Value = url;

                // Verificar si el saldo es menor o igual a 50 y cambiar el color de la fila
                if (Convert.ToInt32(saldo) <= 50)
                {
                    dataGridView1.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Red;
                }
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                // Limpiar los campos del formulario después de guardar
                dataGridView1.Update();
                TNombre.Clear();
                TApellido.Clear();
                DTFecha.Value = DateTime.Now;
                TSaldo.Clear();
                RHombre.Checked = false;
                RMujer.Checked = false;
                TFoto.Clear();

                string executablePath = AppDomain.CurrentDomain.BaseDirectory;
                string imagePath = Path.Combine(executablePath, "imagenes\\usuario.png");
                imagePath = imagePath.Replace("\\bin\\Debug\\net7.0-windows\\", "\\");
                PUsuario.Image = Image.FromFile(imagePath);

            }

        }

        private Image ResizeImage(Image image, int width, int height)
        {
            Bitmap resizedImage = new Bitmap(width, height);
            using (Graphics graphics = Graphics.FromImage(resizedImage))
            {
                graphics.DrawImage(image, 0, 0, width, height);
            }
            return resizedImage;
        }

        private void TFoto_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TSaldo_TextChanged(object sender, EventArgs e)
        {

        }

        private void TSaldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.ScrollBars = ScrollBars.Both;
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["Eliminar"].Index)
            {
                dataGridView1.Rows.RemoveAt(e.RowIndex);
            }

        }

        private void dataGridView1_AutoSizeRowsModeChanged(object sender, DataGridViewAutoSizeModeEventArgs e)
        {

        }
    }
}