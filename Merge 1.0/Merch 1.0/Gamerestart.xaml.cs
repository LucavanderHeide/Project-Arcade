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
    /// Interaction logic for Gamerestart.xaml
    /// </summary>
    public partial class Gamerestart : Window
    {
        public Gamerestart()
        {
            InitializeComponent();
            SetHighScores1();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Name_invoeren game = new Name_invoeren();
            game.Visibility = Visibility.Visible;
            this.Visibility = Visibility.Hidden;

        }



        //Connetie opzetten met de database
        Dictionary<string, int> highscores = new Dictionary<string, int>();
        const string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\lvand\\Desktop\\Merge 1.0\\Merch 1.0\\Data\\GameDatabase.mdf\";Integrated Security=True";
        //  D:\School\Jaar 1\Merge 1.0\Merch 1.0\Data\GameDatabase.mdf
        //Opslaan van de naam van speler 2 in de database
        private void SetHighScores1()
        {
            //todo insert into database

            string query1 = "INSERT INTO [Highscores] ([Speler],[Wins]) VALUES (@Name, @Wins)";


            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(query1);
            command.Parameters.AddWithValue("@Name", Name_invoeren.speler1);
            command.Parameters.AddWithValue("@Wins", Window1.winp2);


            // SqlCommand command = new SqlCommand();
            try
            {
                command.CommandText = query1;
                command.CommandType = CommandType.Text;
                command.Connection = connection;
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                
            }
            catch (Exception e)
            {
                connection.Close();
                
            }
        }
    }
}
