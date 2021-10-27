using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

namespace Merch_1._0
{
    /// <summary>
    /// Interaction logic for Name_invoeren.xaml
    /// </summary>
    public partial class Name_invoeren : Window
    {
        public static string speler1 = "";
        public static string speler2 = "";

        public Name_invoeren()
        {
            InitializeComponent();


        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 game = new Window1();
            game.Visibility = Visibility.Visible;
            this.Visibility = Visibility.Hidden;

            speler1 = Speler1.Text;
            speler2 = Speler2.Text;

            SetHighScores1();
            SetHighScores2();
        }

        //Connetie opzetten met de database
        Dictionary<string, int> highscores = new Dictionary<string, int>();
        const string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\lvand\\Desktop\\Merge 1.0\\Merch 1.0\\Data\\GameDatabase.mdf\";Integrated Security=True";

        //Opslaan van de naam van speler 2 in de database
        private void SetHighScores1()
        {
            //todo insert into database

            string query1 = "INSERT INTO [Highscores] ([Speler],[Wins]) VALUES (@Name,'1')";


            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(query1);
            command.Parameters.AddWithValue("@Name", Name_invoeren.speler1);


            // SqlCommand command = new SqlCommand();
            try
            {
                command.CommandText = query1;
                command.CommandType = CommandType.Text;
                command.Connection = connection;
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Gelukt!");
            }
            catch (Exception e)
            {
                connection.Close();
                MessageBox.Show(e.Message);
            }
        }
        //Opslaan van de naam van speler 2 in de database
        private void SetHighScores2()
        {
            //todo insert into database

            string query2 = "INSERT INTO [Highscores] ([Speler],[Wins]) VALUES (@Name,'1')";


            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(query2);
            command.Parameters.AddWithValue("@Name", Name_invoeren.speler2);


            // SqlCommand command = new SqlCommand();
            try
            {
                command.CommandText = query2;
                command.CommandType = CommandType.Text;
                command.Connection = connection;
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Gelukt!");
            }
            catch (Exception e)
            {
                connection.Close();
                MessageBox.Show(e.Message);
            }



        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow Start = new MainWindow();
            Start.Visibility = Visibility.Visible;
        }
    }
}