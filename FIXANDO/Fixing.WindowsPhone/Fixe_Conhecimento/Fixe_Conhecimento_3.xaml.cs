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

namespace Fixing.Fixe_Conhecimento
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Fixe_Conhecimento_3 : Page
    {
        public Fixe_Conhecimento_3()
        {
            this.InitializeComponent();
            Fixing_Class cFixing = Fixing_Class.getInstance();
            TextoPergunta3.Text = cFixing.Text3;


        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void Textboxfixing3_TextChanged(object sender, TextChangedEventArgs e)
        {
            Fixing_Class cFixing = Fixing_Class.getInstance();
            cFixing.ResFixText3 = Textboxfixing3.Text; // Aqui você pegará o valor do TEXTBOX
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Comparação));
        }
    }
}
