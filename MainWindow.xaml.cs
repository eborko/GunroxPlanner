using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GunroxPlanner;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void OnMouseEnterButton(object sender, MouseEventArgs e)
    {
        Button button = (Button)sender;
        Image image = (Image)button.Template.FindName("BtnImage", button);
        BitmapImage overImage =
            new BitmapImage(new Uri("Resources/Images/SkillImages/skill_btn_over.png", UriKind.Relative));
        image.Source = overImage;
    }

    private void OnMouseLeaveButton(object sender, MouseEventArgs e)
    {
        Button button = (Button)sender;
        Image image = (Image)button.Template.FindName("BtnImage", button);
        BitmapImage normalImage =
            new BitmapImage(new Uri("Resources/Images/SkillImages/skill_btn_normal.png", UriKind.Relative));
        image.Source = normalImage;
    }

    private void OnMouseLeftDownButton(object sender, MouseButtonEventArgs e)
    {
        Button button = (Button)sender;
        Image image = (Image)button.Template.FindName("BtnImage", button);
        BitmapImage downImage =
            new BitmapImage(new Uri("Resources/Images/SkillImages/skill_btn_down.png", UriKind.Relative));
        image.Source = downImage;
    }

    private void OnMouseLeftUpButton(object sender, MouseButtonEventArgs e)
    {
        Button button = (Button)sender;
        Image image = (Image)button.Template.FindName("BtnImage", button);
        BitmapImage overImage =
            new BitmapImage(new Uri("Resources/Images/SkillImages/skill_btn_over.png", UriKind.Relative));
        image.Source = overImage;
    }
}