using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace memory_game
{
    internal class Card
    {
        public ImageSource source;
        public bool onReverse;

        public Card(String source)
        {
            this.source = new BitmapImage(new Uri(source, UriKind.Relative));
            this.onReverse = true;
        }
        public ImageSource Reverse()
        {
            if (onReverse)
            {
                return source;
                onReverse = false;
            }
            else
            {
                ImageSource odwrot = new BitmapImage(new Uri("odwrot.png", UriKind.Relative));
                return odwrot;
                onReverse = true;
            }
        }
    }
}
