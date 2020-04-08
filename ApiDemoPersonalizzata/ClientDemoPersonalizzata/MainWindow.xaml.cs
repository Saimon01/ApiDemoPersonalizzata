using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

namespace ClientDemoPersonalizzata
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private async void btnCalcolaPedi_Click(object sender, RoutedEventArgs e)
        {
            double ris1 = 0;
            double metri = Convert.ToDouble(txtMetri.Text);
            HttpClient cliente = new HttpClient();
            string uri1 = $"https://localhost:44399/api/OperationValues/ConvertitoreMetriAPiedi/ConvertitoreMetriAPiedi?metri={metri}";
            HttpResponseMessage response = await cliente.GetAsync(uri1);
            string content = await response.Content.ReadAsStringAsync();
            ris1 = JsonConvert.DeserializeObject<int>(content);
            Dispatcher.Invoke(() => lblRisultatoPiedi.Content = ris1);
        }

        private void btnCalcolaMetri_Click(object sender, RoutedEventArgs e)
        {
            double ris2 = 0;
            double piedi = Convert.ToDouble(txtPiedi.Text);
            HttpClient Cliente2 = new HttpClient();
            string uri2 = $"https://localhost:44399/api/OperationValues/ConvertitorePiediAMetri/ConvertitorePiediAMetri?piedi={piedi}";
        }
    }
}
