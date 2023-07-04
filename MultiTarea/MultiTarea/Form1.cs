namespace MultiTarea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string ruta = @"C:\Users\Administrador\Source\Repos\MultiTarea\";
        string archivo = "Archivo.txt";


        private void Escribir()
        {
            int linea = Convert.ToInt32(Numbertxt.Text);
            progress.Maximum = linea;

            Thread escribirThread = new Thread(() =>
            {
                using (StreamWriter escribir = new StreamWriter(ruta + archivo))
                {
                    try
                    {
                        for (int x = 1; x <= linea; x++)
                        { 
                            escribir.WriteLine("Linea: " + x.ToString());
                            progress.Invoke((MethodInvoker)(() => progress.Value = x));
                            int resultado = x * 100 / linea;
                            progresstext.Invoke((MethodInvoker)(() => progresstext.Text = resultado.ToString() + "%"));
                        }

                        escribir.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            });

            escribirThread.Start();
        }


        private void Numbertxt_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Numbertxt.Text))
                Iniciarbtn.Enabled = false;
            else
                Iniciarbtn.Enabled = true;
        }

        private void Iniciarbtn_Click(object sender, EventArgs e)
        {
            FileStream fs;

            if (Numbertxt.Text == "")
            {
                MessageBox.Show("Complete con un número mayor a 0 para poder continuar");
            }
            else
            {
                try
                {
                    if (File.Exists(ruta))
                    {
                        fs = File.Create(ruta + archivo);
                        fs.Close();
                        MessageBox.Show("archivo creado correctamente");
                        Escribir();
                    }
                    else
                    {
                        Directory.CreateDirectory(ruta);
                        fs = File.Create(ruta + archivo);
                        fs.Close();
                        MessageBox.Show("Archivo creado correctamente");
                        Escribir();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error crítico");
                }
            }
        }
    }
}