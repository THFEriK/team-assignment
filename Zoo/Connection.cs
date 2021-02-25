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
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;



namespace Zoo
{
    class Connection
    {
        private MySqlConnection conn; 
        private async Task ConnectAsync()
        {
            try
            {
                conn = new MySqlConnection("SERVER = localhost; UID=root; PWD=; DATABASE=zoo");
                await conn.OpenAsync();
            }
            catch (MySqlException ex)
            {
                Error(ex.Message.ToString());
            }
        }
        public async Task AddSpeciesAsync(TextBox tx)
        {
            await ConnectAsync();
            string sql = String.Format("INSERT INTO species (id, speciesName) VALUES(NULL, '{0}')", tx.Text);
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            try
            {
                await cmd.ExecuteNonQueryAsync();
            }
            catch (MySqlException ex)
            {
                Error(ex.Message.ToString());
            }
            await conn.CloseAsync();
        }
       
        public async Task AddAnimalAsync(TextBox tx, ComboBox cb, ComboBox cb1, ComboBox cb2)
        {
            await ConnectAsync();
            string sql = String.Format("INSERT INTO animal(id, animalName, species_id, habitat_id, rate_id) VALUES(NULL, '{0}', {1}, {2}, {3})", tx.Text, cb.SelectedValue, cb1.SelectedValue, cb2.SelectedValue);
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            try
            {
                await cmd.ExecuteNonQueryAsync();
            }
            catch (Exception ex)
            {
                Error(ex.Message.ToString());
            }

            await conn.CloseAsync();
        }
        
        public async Task FillComboBoxAsync(ComboBox cb, string column1,string column2, string table)
        {
            await ConnectAsync();
            string sql = String.Format("SELECT {0}, {1} FROM {2}", column1, column2, table);
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            await da.FillAsync(ds);

            cb.ItemsSource = ds.Tables[0].DefaultView;
            cb.DisplayMemberPath = ds.Tables[0].Columns[1].ToString();
            cb.SelectedValuePath = ds.Tables[0].Columns[0].ToString();

            await conn.CloseAsync();
        }

        private void Error(string ex)
        {
            MessageBox.Show(ex, "Hiba!", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        public async Task FillListBoxAsync(ListBox lb, string sql)
        {
            await ConnectAsync();

            var da = new MySqlDataAdapter(sql, conn);
            var ds = new DataSet();

            await da.FillAsync(ds);
            lb.ItemsSource = ds.Tables[0].DefaultView;
            lb.DisplayMemberPath = ds.Tables[0].Columns[1].ToString();
            lb.SelectedValuePath = ds.Tables[0].Columns[0].ToString();

            await conn.CloseAsync();
        }

        public async Task FillDataGridAsync(DataGrid dg)
        {
            await ConnectAsync();

            var sql = "SELECT animalName, speciesName, habitat, rate FROM animal LEFT JOIN species ON animal.species_id = species.id LEFT JOIN habitat ON animal.habitat_id = habitat.id LEFT JOIN rate ON animal.rate_id = rate.id";
            var da = new MySqlDataAdapter(sql, conn);
            var dt = new DataTable();

            await da.FillAsync(dt);
            dg.ItemsSource = dt.DefaultView;
            dg.SelectedValue = dt.Columns[0].ToString();

            await conn.CloseAsync();
        }
    }
}
