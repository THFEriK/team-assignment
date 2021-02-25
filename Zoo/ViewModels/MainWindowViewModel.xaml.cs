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
using Zoo.ViewModels;

namespace Zoo.ViewModels
{
    /// <summary>
    /// Interaction logic for MainWindowViewModel.xaml
    /// </summary>
    public partial class MainWindowViewModel : UserControl
    {
        Connection conn = new Connection();

        public MainWindowViewModel()
        {
            InitializeComponent();            
        }

        private void NewAnimalBtn_Click(object sender, RoutedEventArgs e)
        {
            var SubWindow = new AddNewAnimalViewModel(); 
            this.Content = SubWindow;            
        }

        private async void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            await conn.FillListBoxAsync(SpeciesLb, "SELECT id, speciesName FROM species");
            await conn.FillDataGridAsync(AnimalsDg);
        }
    }
}
