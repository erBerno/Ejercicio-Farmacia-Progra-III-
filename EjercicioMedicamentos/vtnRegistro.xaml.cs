using System;
using System.Collections.Generic;
using System.IO;
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

namespace EjercicioMedicamentos
{
    /// <summary>
    /// Lógica de interacción para vtnRegistro.xaml
    /// </summary>
    public partial class vtnRegistro : Window
    {
        public vtnRegistro()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                FileStream archivo = new FileStream("D:/Proyectos Progra III/EjercicioMedicamentos/datos.txt", FileMode.Append);
                byte[] datos = Encoding.Default.GetBytes(txbNombre.Text + ";" + txbCantidad.Text + ";" + txbPrecio.Text + "\n");
                archivo.Write(datos, 0, datos.Length);
                archivo.Close();

                MessageBox.Show("REGISTRO EXITOSO");

                txbNombre.Text = null;
                txbPrecio.Text = null;
                txbCantidad.Text = null;
            }
            catch
            {
                MessageBox.Show("ERROR EN EL REGISTRO");
            }
        }
    }
}
