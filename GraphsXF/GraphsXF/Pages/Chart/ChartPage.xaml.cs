using Microcharts;
using SkiaSharp;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Entry = Microcharts.Entry;

namespace GraphsXF
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChartPage : ContentPage
    {
        public ChartPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            var entries = new List<Entry>();

            Random rand = new Random();

            var colors = new[]
            {
                SKColors.Red,
                SKColors.Green,
                SKColors.PapayaWhip,
                SKColors.Maroon,
                SKColors.Orchid,
                SKColors.SlateBlue,
                SKColors.Teal,
                SKColors.YellowGreen,
                SKColors.SaddleBrown,
                SKColors.PaleTurquoise
            };

            for (int i = 0; i < 10; i++)
            {
                var date = DateTime.Now.AddYears(i);

                var value = rand.Next(1, 400);

                entries.Add(new Entry(value)
                {
                    Label = date.Year.ToString(),
                    ValueLabel = value.ToString(),
                    Color = colors[i]
                });
            }
                       
            barChart.Chart = new BarChart()
            {
                Entries = entries
            };

            pointChart.Chart = new PointChart()
            {
                Entries = entries
            };

            lineChart.Chart = new LineChart()
            {
                Entries = entries
            };

            donutChart.Chart = new DonutChart()
            {
                Entries = entries
            };

            radialGaugeChart.Chart = new RadialGaugeChart()
            {
                Entries = entries
            };

            radarChart.Chart = new RadarChart()
            {
                Entries = entries
            };
        }
    }
}