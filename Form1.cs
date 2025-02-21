namespace Examen1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialogAbrir.ShowDialog();
            if (result == DialogResult.OK)
            {
                
                string file = openFileDialogAbrir.FileName;
                string contenido = File.ReadAllText(file);
                string[] renglones = contenido.Split('\n');
                string[] columnas = renglones[0].Split(',');
                dataGridView1.ColumnCount = columnas.Length;
                dataGridView1.RowCount = renglones.Length;

                for (int i = 0; i < columnas.Length; i++)
                {
                    dataGridView1.Rows[0].Cells[i].Value = columnas[i];
                }
                for (int i = 1; i < (renglones.Length) - 1; i++)
                {
                    columnas = renglones[i].Split(",");
                    for (int j = 0; j < columnas.Length; j++)
                    {
                        dataGridView1.Rows[i].Cells[j].Value = columnas[j];
                        string sexo = dataGridView1.Rows[0].Cells[j].Value.ToString();
                        sexo.Substring(11, 1);
                       if (sexo == "H")
                        {
                            sexo = "HOMBRE";
                        }
                        else
                        {
                            sexo = "MUJER";
                        }
                        MessageBox.Show("El sexo es: " + sexo);
                        
                    }
                }

            }
            else
                MessageBox.Show("Error al abrir el archivo");

        }
        private int CalcularEdad(string curp)
        {
            int año = int.Parse(curp.Substring(4, 2)); 
            int mes = int.Parse(curp.Substring(6, 2));
            int dia = int.Parse(curp.Substring(8, 2)); 

            
            año += (año >= 30) ? 1900 : 2000;

            DateTime fechaNacimiento = new DateTime(año, mes, dia);
            int edad = DateTime.Today.Year - fechaNacimiento.Year;

            
            if (DateTime.Today < fechaNacimiento.AddYears(edad))
            {
                edad--; 
            }

            return edad;
        }

    }
}
