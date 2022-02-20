using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.IO;

namespace EjercicioMedicamentos
{
    /// <summary>
    /// Lógica de interacción para vtnComprar.xaml
    /// </summary>
    public partial class vtnComprar : Window
    {
        List<Medicamentos> meds = new List<Medicamentos>();

        public vtnComprar(List<Medicamentos> listaMeds)
        {
            meds = listaMeds;
            InitializeComponent();
        }

        private void btnComprar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string path = "D:/Proyectos Progra III/EjercicioMedicamentos/datos.txt";

                int line = -1;

                for (int i = 0; i < meds.Count; i++)
                {
                    if (txbNomC.Text == meds[i].Nombre)
                    {
                        line = i;
                    }
                }

                if (line > -1)
                {
                    string[] lines = File.ReadAllLines(path);
                    int res = meds[line].Cantidad - int.Parse(txbCantidadC.Text);
                    lines[line] = meds[line].Nombre + ";" + res + ";" + meds[line].Precio;
                    File.WriteAllLines(path, lines);
                }

                MessageBox.Show("COMPRA EXITOSA");
                this.Close();
            }
            catch
            {
                MessageBox.Show("ERROR EN LA COMPRA");
            }                       
        }
    }
}
