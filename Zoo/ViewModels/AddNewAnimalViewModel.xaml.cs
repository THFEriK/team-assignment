using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Threading;

namespace Zoo.ViewModels
{
    /// <summary>
    /// Interaction logic for AddNewAnimalViewModel.xaml
    /// </summary>
    public partial class AddNewAnimalViewModel : UserControl
    {
        Connection conn = new Connection();
        public AddNewAnimalViewModel()
        {            
            InitializeComponent();            
        }

        private void NameTb_GotFocus(object sender, RoutedEventArgs e)
        {
            if (NameTb.Text == "Állat neve")
            {
                NameTb.Text = "";
                NameTb.Foreground = new SolidColorBrush(Colors.Black);
            }
        }

        private void NameTb_LostFocus(object sender, RoutedEventArgs e)
        {
            if (NameTb.Text == "")
            {
                NameTb.Text = "Állat neve";
                NameTb.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            var MainView = new MainWindowViewModel();
            this.Content = MainView;
        }

        private void AddNewSpeciesBtn_Click(object sender, RoutedEventArgs e)
        {            
            var SubWindow = new AddNewSpeciesViewModel();
            this.Content = SubWindow;
        }

        private async void NewAnimalBtn_Click(object sender, RoutedEventArgs e)
        {
            await conn.AddAnimalAsync(NameTb, SpeciesCb, ContinentCb, VulnerableRateCb);
        }

        private async void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            await conn.FillComboBoxAsync(SpeciesCb, "id", "speciesName", "species");
            await conn.FillComboBoxAsync(ContinentCb, "id", "habitat", "habitat");
            await conn.FillComboBoxAsync(VulnerableRateCb, "id", "rate", "rate");
            await conn.FillListBoxAsync(AnimalsLb, "SELECT animal.id, CONCAT_WS(' - ', animalName, speciesName) FROM animal LEFT JOIN species ON animal.species_id = species.id");

            var dt = new DispatcherTimer();
            dt.Interval = TimeSpan.FromSeconds(10);
            dt.Tick += dtTimer;
            dt.Start();
        }

        private async void dtTimer(object sender, EventArgs e)
        {
            await conn.FillListBoxAsync(AnimalsLb, "SELECT animal.id, CONCAT_WS(' - ', animalName, speciesName) FROM animal LEFT JOIN species ON animal.species_id = species.id");
        }
    }
}
