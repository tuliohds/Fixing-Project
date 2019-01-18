namespace Fixing
{
    public sealed partial class MainPage : PageBase
    {
        private void Button_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Perguntas));
        }

        private void Button_Click_1(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Dicas));
        }

        private void Button_Click_2(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            Fixing_Class cFixing = Fixing_Class.getInstance();

            if (cFixing.Text1 == null)
            {
                this.Frame.Navigate(typeof(erroFixing));
            }
            else
            {
                this.Frame.Navigate(typeof(Fixe_conhecimento));
            }
        }

        private void Button_Click_3(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Sobre));
        }
    }
}
