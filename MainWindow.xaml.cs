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

namespace memory_game
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Card> characters = new List<Card>();
        Card[] randomCharacters = new Card[12];
        int counter = 0;
        int lastIdCLicked = -1;
        public MainWindow()
        {
            MessageBox.Show("cokolwiek");
            InitializeComponent();
            for (int i = 0; i <= 2; i++)
			{
                characters.Add(new Card("calcharo.png"));
                characters.Add(new Card("carlotta.png"));
                characters.Add(new Card("yinlin.png"));
                characters.Add(new Card("chixia.png"));
                characters.Add(new Card("yangyang.png"));
                characters.Add(new Card("calcharo.png"));
			}
            shuffle();
        }
        public void shuffle()
        {
            int i = 0;
            while (i < 12)
            {
                int rand = new Random().Next(0, 11);
                if (randomCharacters[rand] == null)
                {
                    randomCharacters[rand] = characters[i];
                    i++;
                }
            }
            foreach (var item in randomCharacters)
	{
                MessageBox.Show(item.ToString());
	}
        }

        private void choose(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            WrapPanel container = panel;
            int id = container.Children.IndexOf(button);
            if (lastIdCLicked != id)
            {
                lastIdCLicked = id;
                Image image = button.Content as Image;
                image.Source = randomCharacters[id].Reverse();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button bu = sender as Button;
        }
    }
}
