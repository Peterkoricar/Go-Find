using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace maptest.ViewModel
{
    public class Navigation : INotifyPropertyChanged
    {
        private Color _color = Color.FromHex("#B1B108");
        public Color Color
        {
            get => _color;
            set
            {
                if (value == _color)
                    return;

                _color = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Color)));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

       /* public void Find(Position item)
        {
            var player = new Player();

            double time = DateTime.Now.Ticks;
            //double blinktime = time + (((item.Latitude + item.Longitude) - (player.PlayerPositon().Result.Longitude + player.PlayerPositon().Result.Latitude)) / 100000);
            double blinktime = 1;
            if (blinktime < 0)
            {
                blinktime = -blinktime;
            }
            while (time <= blinktime)
            {
                if (time == blinktime)
                {
                    Color = Color.White;
                }
            }
            Color = Color.FromRgba(255, 177, 177, 08);
        }*/
    }
}
