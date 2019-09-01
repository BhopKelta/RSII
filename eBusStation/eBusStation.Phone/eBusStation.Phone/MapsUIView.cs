using System;
using System.Collections.Generic;
using System.Text;
using Mapsui.Styles;

namespace eBusStation.Phone
{
    public class MapsUIView : Xamarin.Forms.View
    {
        public Mapsui.Map NativeMap { get; }
        protected internal MapsUIView()
        {
            NativeMap = new Mapsui.Map();
            //NativeMap.CRS = "EPSG:28992";
            NativeMap.BackColor = Color.Black;
        }
    }
}
