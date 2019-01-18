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
    public sealed partial class Fixe_conhecimento : Page
    {
        public Fixe_conhecimento()
        {
            this.InitializeComponent();

            Fixing_Class cFixing = Fixing_Class.getInstance();
            TextoPergunta.Text = cFixing.Text1;
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void TextoPergunta_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Fixe_Conhecimento.Fixe_Conhecimento_2));
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            Fixing_Class cFixing = Fixing_Class.getInstance();
            cFixing.ResFixText1 = Textboxfixing1.Text; // Aqui você pegará o valor do TEXTBOX
        }
    }
}
