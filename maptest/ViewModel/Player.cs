using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Plugin.Geolocator;
using Xamarin.Forms.Maps;

namespace maptest.ViewModel
{
    class Player
    {
        public async Task<Position> PlayerPositon()
        {
            var locator = CrossGeolocator.Current;
            locator.DesiredAccuracy = 30;

            var task = await locator.GetPositionAsync(new TimeSpan(0, 0, 1));

            var location = task;

            return new Position(location.Latitude,location.Longitude);
        }
    }
}
