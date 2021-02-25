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
        private MySqlConnection conn = new MySqlConnection("SERVER = localhost; UID=root; PWD=; DATABASE=zoo");
        private void Connect()
        {
            try
            {
                conn.Open();
            }
            catch (MySqlException ex)
            {
                Error(ex.Message.ToString());
            }
        }
        public void AddSpecies(TextBox tx)
        {
            Connect();
            string sql = String.Format("INSERT INTO species (id, speciesName) VALUES(NULL, '{0}')", tx.Text);
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                Error(ex.Message.ToString());
            }
            conn.Close();
        }
       
        public void AddAnimal(TextBox tx, ComboBox cb, ComboBox cb1, ComboBox cb2)
        {
            Connect();
            string sql = String.Format("INSERT INTO animal(id, animalName, species_id, habitat_id, rate_id) VALUES(NULL, '{0}', {1}, {2}, {3})", tx.Text, cb.SelectedValue, cb1.SelectedValue, cb2.SelectedValue);
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Error(ex.Message.ToString());
            }
            
            conn.Close();
        }
        
        public void FillComboBox(ComboBox cb, string column1,string column2, string table)
        {
            Connect();
            string sql = String.Format("SELECT {0}, {1} FROM {2}", column1, column2, table);
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);

            cb.ItemsSource = ds.Tables[0].DefaultView;
            cb.DisplayMemberPath = ds.Tables[0].Columns[1].ToString();
            cb.SelectedValuePath = ds.Tables[0].Columns[0].ToString();

            conn.Close();
        }

        private void Error(string ex)
        {
            MessageBox.Show(ex, "Hiba!", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        public void FillListBox(ListBox lb, string sql)
        {
            Connect();
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            lb.ItemsSource = ds.Tables[0].DefaultView;
            lb.DisplayMemberPath = ds.Tables[0].Columns[1].ToString();
            lb.SelectedValuePath = ds.Tables[0].Columns[0].ToString();
            conn.Close();
        }
    }
}
