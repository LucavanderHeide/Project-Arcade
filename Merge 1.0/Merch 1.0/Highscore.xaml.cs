using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
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

namespace Merch_1._0
{
    /// <summary>
    /// Interaction logic for Highscore.xaml
    /// </summary>
    public partial class Highscore : Window
    {
        Dictionary<string, int> highscores = new Dictionary<string, int>();
        const string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\lvand\\Desktop\\Merge 1.0\\Merch 1.0\\Data\\GameDatabase.mdf\";Integrated Security=True";
                                                                                            //C:\Users\lvand\Desktop\Merge 1.0\Merch 1.0\Data\GameDatabase.mdf

        public Highscore()
        {
            InitializeComponent();

            GetHighScores();
            CreateLabels();
        }

        private void Refresh_Click(object sender, RoutedEventArgs e)
        {
            GetHighScores();
            CreateLabels();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Visibility = Visibility.Visible;
            this.Close();

        }

        private void Insert_Click(object sender, RoutedEventArgs e)
        {
            SetHighScores();
        }
        private void GetHighScores()
        {
            highscores.Clear();

            string query = "SELECT Speler,Wins FROM dbo.Highscores;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                //Call read before accesing data
                while (reader.Read())
                {
                    highscores.Add((string)reader[0], (int)reader[1]);
                }

                //Cal Close when done reading.
                reader.Close();
            }
        }

        private void SetHighScores()
        {
            //todo insert into database

            string query1 = "INSERT INTO [Highscores] ([Player],[Wins]) VALUES ('Jan','42')";
            string query2 = "INSERT INTO [Highscores] ([Player],[Wins]) VALUES ('Piet','43')";

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand();
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


        private void CreateLabels()
        {
            HighScoresPanel.Children.Clear();

            var sortedHighscores = from wins in highscores orderby wins.Value descending select wins;
            foreach (KeyValuePair<string, int> highscore in sortedHighscores)
            {
                Label label = new Label();
                label.Content = highscore.Key + "                                      " + highscore.Value;
                label.HorizontalAlignment = HorizontalAlignment.Center;
                label.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFF9F9F9"));
                HighScoresPanel.Children.Add(label);
            }

        }

    }


}

