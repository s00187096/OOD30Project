using _30project_gametracker;
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

namespace project_gametracker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<games> allgames = new List<games>();
        List<games> unfinishedgames = new List<games>();
        List<games> finishedgames = new List<games>();

        private ComboBox comboBox;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ComboBox_Copy2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TextBox_Copy4_TextChanged(object sender, TextChangedEventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }
        private List<games> Creategames()
        {
            List<games> allActivities = new List<games>();
            //horror
            games h1 = new games()
            {
                Name = "Alien Isolation",
                Description = "in search for your mother you are sent to a space colony where a hostile predator stalks you.",

                Genre1 = GameGenre.Horror
                
            };
            games h2 = new games()
            {
                Name = "Outlast",
                Description = "a journalist gets a tip that something isnt right in the insane asylum in town and goes to investigate",

                Genre1 = GameGenre.Horror

            };
            //rpg
            games rpg1 = new games()
            {
                Name = "Fire Emblem Awakening",
                Description = "strategy rpg where a mysterious character from the future appears to stop the death of a royal family memeber",
                Genre1 = GameGenre.RPG
            };
            //action
            games a1 = new games()
            {
                Name = "Metal Gear Rising",
                Description = "after the shut down of the patriots a new threat tries to take control of the global markets for private milatary contracts",
                
                 Genre1= GameGenre.Action
                
            };
            games a2 = new games()
            {
                Name = "Bayonetta",
                Description = "a witch who made a deal with demons has to find out where she came from while angels attack her at every turn",

                Genre1 = GameGenre.Action

            };
            //action adventure
            games AA1 = new games()
            {
                Name = "The legend of Zelda:Breath of the wild",
                Description = "after 100 years you awaken to a land some what familiar and have to save it from a great calamity",
                Genre1 = GameGenre.Action_adventure
            };
            //strategy
            games s1 = new games()
            {
                Name = "Fire emblem Birthright",
                Description = "a kidnapped prince returns to his kingdom and sets out a war on the kingdom that took him from his family",
                Genre1 = GameGenre.Strategy
            };
            games s2 = new games()
            {
                Name = "Fire emblem conquest",
                Description = "a kidnapped prince goes to war with his alleged family to take over their kingdom",
                Genre1 = GameGenre.Strategy
            };






            //horror
            allgames.Add(h1);
            allgames.Add(h2);

           //action
            allgames.Add(a1);
            allgames.Add(a2);

           //action adventure
            allgames.Add(AA1);

           //rpg
            allgames.Add(rpg1);

            //strategy
            allgames.Add(s1);
            allgames.Add(s2);
            

            return allgames;
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //create activities

            allgames = Creategames();


            //display
            AllBox.ItemsSource = allgames;
        }

        private void AllBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
