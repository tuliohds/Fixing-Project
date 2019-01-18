using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace Fixing
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Comparação : Page
    {
        public Comparação()
        {
            this.InitializeComponent();
            
            Fixing_Class cFixing = Fixing_Class.getInstance();
            
            txtinicial1.Text = cFixing.ResText1;
            txtinicial2.Text = cFixing.ResText2;
            txtinicial3.Text = cFixing.ResText3;

            txtagora1.Text = cFixing.ResFixText1;
            txtagora2.Text = cFixing.ResFixText2;
            txtagora3.Text = cFixing.ResFixText3;
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Perguntas));
        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
