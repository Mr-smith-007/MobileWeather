using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobileWeather
{
    public partial class MainPage : ContentPage
    {
        public const string BUTTON_TEXT = "Get weather";
        public MainPage()
        {
            InitializeComponent();
        }
                
        private void LoadWeather(object sender, EventArgs e)
        {            
            var layout = new Grid();            
            layout.BackgroundColor = Color.Black;
                        
            var upperBox = new BoxView { BackgroundColor = Color.Bisque };            
            var upperHeader = new Label() { 
                                    Text = $"{Environment.NewLine}Inside", 
                                    HorizontalTextAlignment = TextAlignment.Center, 
                                    VerticalTextAlignment = TextAlignment.Start, 
                                    FontSize = 45,
                                    TextColor = Color.FromRgb(48, 48, 48) };            
            var upperText = new Label() { 
                                  Text = $"{Environment.NewLine}+ 26 °C  ", 
                                  HorizontalTextAlignment = TextAlignment.End,
                                  VerticalTextAlignment = TextAlignment.Center, 
                                  FontSize = 105, 
                                  TextColor = Color.FromRgb(48, 48, 48) };
            
            layout.Children.Add(upperBox, 0, 0);
            layout.Children.Add(upperHeader, 0, 0);
            layout.Children.Add(upperText, 0, 0);

            
            var middleBox = new BoxView { BackgroundColor = Color.LightBlue };
            var middleHeader = new Label() { 
                                     Text = $"{Environment.NewLine} Outside", 
                                     HorizontalTextAlignment = TextAlignment.Center, 
                                     VerticalTextAlignment = TextAlignment.Start, 
                                     FontSize = 45, 
                                     TextColor = Color.FromRgb(48, 48, 48) };
            var middleText = new Label() { 
                                   Text = $"{Environment.NewLine}- 15 °C  ", 
                                   HorizontalTextAlignment = TextAlignment.End, 
                                   VerticalTextAlignment = TextAlignment.Center, 
                                   FontSize = 105, 
                                   TextColor = Color.FromRgb(48, 48, 48) };
            layout.Children.Add(middleBox, 0, 1);
            layout.Children.Add(middleHeader, 0, 1);
            layout.Children.Add(middleText, 0, 1);
                        
            var bottomBox = new BoxView { BackgroundColor = Color.DarkCyan };
            var bottomHeader = new Label() { 
                                     Text = $"{Environment.NewLine} Pressure", 
                                     HorizontalTextAlignment = TextAlignment.Center, 
                                     FontSize = 45, 
                                     TextColor = Color.FromRgb(48, 48, 48) };
            var bottomText = new Label() {
                                   Text = $"{Environment.NewLine}760 mm ", 
                                   HorizontalTextAlignment = TextAlignment.End, 
                                   VerticalTextAlignment = TextAlignment.Center, 
                                   FontSize = 100, 
                                   TextColor = Color.FromRgb(48, 48, 48) };
            layout.Children.Add(bottomBox, 0, 2);
            layout.Children.Add(bottomHeader, 0, 2);
            layout.Children.Add(bottomText, 0, 2);
                        
            this.Content = layout;
        }
    }
}
