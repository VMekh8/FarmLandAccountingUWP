
using Windows.UI;
using Windows.UI.Core;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;

namespace FarmLandAccountingUWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void NavButton_Hover (object sender, PointerRoutedEventArgs e)
        {
            RelativePanel panel = sender as RelativePanel;

            panel.Background = new SolidColorBrush(Colors.DarkViolet);
        }

        private void NavButton_Cancel (object sender, PointerRoutedEventArgs e)
        {
            RelativePanel panel = sender as RelativePanel;

            panel.Background = new SolidColorBrush(Colors.Transparent); 
        }
    }
}
