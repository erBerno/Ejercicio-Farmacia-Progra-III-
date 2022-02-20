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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EjercicioMedicamentos
{
    /// <summary>
    /// 1.Escribir unprograma WPF que administre el registro y recuperación de medicamentos de una 
    /// farmacia a través de las siguientes operaciones:a.Registro de medicamentos con los siguientes datos:
    /// nombre del medicamento, cantidad en existencia y precio.b.Búsquedapor nombre de medicamento.c.Búsquedapor 
    /// preciode medicamento.d.Actualización de existencias. El usuario indica un medicamento y la cantidad a comprar. 
    /// Si la cantidad en existencia es suficiente, el programa decrementa la cantidad registrada del medicamento y
    /// muestra en pantalla la cantidad restante despuésde la venta.
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnVerStock_Click(object sender, RoutedEventArgs e)
        {
            Stock stock = new Stock();
            stock.ShowDialog();
        }

        private void btnRegistrar_Click(object sender, RoutedEventArgs e)
        {
            vtnRegistro vtnRegistro = new vtnRegistro();
            vtnRegistro.ShowDialog();
        }
    }
}
