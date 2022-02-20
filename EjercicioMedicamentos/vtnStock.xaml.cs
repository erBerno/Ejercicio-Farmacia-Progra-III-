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
    /// Lógica de interacción para Stock.xaml
    /// </summary>
    public partial class Stock : Window
    {
        List<Medicamentos> listaMedicamentos = new List<Medicamentos>();

        public Stock()
        {
            InitializeComponent();
            ResetGrid();
        }

        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {
            List<Medicamentos> medFinded = new List<Medicamentos>();

            if (rdNombre.IsChecked == true)
            {
                foreach (Medicamentos nom in listaMedicamentos)
                {
                    if (nom.Nombre == txbBuscar.Text)
                    {
                        medFinded.Add(new Medicamentos()
                        {
                            Nombre = nom.Nombre,
                            Cantidad = nom.Cantidad,
                            Precio = nom.Precio,
                        });
                        DataGrid.ItemsSource = null;
                        DataGrid.ItemsSource = medFinded;
                        txbBuscar.Text = null;
                        rdNombre.IsChecked = null;
                    }
                }
            } else if (rdPrecio.IsChecked == true)
            {
                foreach (Medicamentos pr in listaMedicamentos)
                {
                    if (pr.Precio == int.Parse(txbBuscar.Text))
                    {
                        medFinded.Add(new Medicamentos()
                        {
                            Nombre = pr.Nombre,
                            Cantidad = pr.Cantidad,
                            Precio = pr.Precio,
                        });
                        DataGrid.ItemsSource = null;
                        DataGrid.ItemsSource = medFinded;
                        txbBuscar.Text = null;
                        rdPrecio.IsChecked = null;
                    }
                }
            }
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            DataGrid.ItemsSource = null;
            listaMedicamentos.Clear();
            ResetGrid();
        }

        private void btnComprar_Click(object sender, RoutedEventArgs e)
        {
            vtnComprar vtnComprar = new vtnComprar(listaMedicamentos);
            vtnComprar.ShowDialog();
        }

        public void ResetGrid()
        {
            string path = "D:/Proyectos Progra III/EjercicioMedicamentos/datos.txt";

            using (StreamReader sr = File.OpenText(path))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    string[] parte = s.Split(';');

                    listaMedicamentos.Add(new Medicamentos()
                    {
                        Nombre = parte[0],
                        Cantidad = int.Parse(parte[1]),
                        Precio = int.Parse(parte[2])
                    });
                }
            }
            DataGrid.ItemsSource = listaMedicamentos;
        }
    }
}
