using System.Media;
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
    private SoundPlayer _soundPlayer = new SoundPlayer();
    public MainWindow()
    {
        InitializeComponent();
        PlayMusic();
    }

    private void PlayMusic()
    {
        _soundPlayer.SoundLocation = new Uri("Resources/Music/menu.wav", UriKind.Relative).ToString();
        _soundPlayer.PlayLooping();
    }

    protected override void OnClosed(EventArgs e)
    {
        _soundPlayer.Dispose();
        base.OnClosed(e);
    }

    private void PlusMinusButton_OnMouseEnter(object sender, MouseEventArgs e)
    {
        Button button = (Button)sender;
        Image image = (Image)button.Template.FindName("BtnImage", button);
        BitmapImage overImage =
            new BitmapImage(new Uri("Resources/Images/SkillImages/skill_btn_over.png", UriKind.Relative));
        image.Source = overImage;
    }

    private void PlusMinusButton_OnMouseLeave(object sender, MouseEventArgs e)
    {
        Button button = (Button)sender;
        Image image = (Image)button.Template.FindName("BtnImage", button);
        BitmapImage normalImage =
            new BitmapImage(new Uri("Resources/Images/SkillImages/skill_btn_normal.png", UriKind.Relative));
        image.Source = normalImage;
    }

    private void PlusMinusButton_OnMouseDown(object sender, MouseButtonEventArgs e)
    {
        Button button = (Button)sender;
        Image image = (Image)button.Template.FindName("BtnImage", button);
        BitmapImage downImage =
            new BitmapImage(new Uri("Resources/Images/SkillImages/skill_btn_down.png", UriKind.Relative));
        image.Source = downImage;
    }

    private void PlusMinusButton_OnMouseUp(object sender, MouseButtonEventArgs e)
    {
        Button button = (Button)sender;
        Image image = (Image)button.Template.FindName("BtnImage", button);
        BitmapImage overImage =
            new BitmapImage(new Uri("Resources/Images/SkillImages/skill_btn_over.png", UriKind.Relative));
        image.Source = overImage;
    }
    
    private void LArrow_OnMouseEnter(object sender, MouseEventArgs e)
    {
        Button button = (Button)sender;
        Image image = (Image)button.Template.FindName("LeftArrowImage", button);
        BitmapImage overImage =
            new BitmapImage(new Uri("Resources/Images/SkillImages/left_arrow_over.png", UriKind.Relative));
        image.Source = overImage;
    }

    private void LArrow_OnMouseLeave(object sender, MouseEventArgs e)
    {
        Button button = (Button)sender;
        Image image = (Image)button.Template.FindName("LeftArrowImage", button);
        BitmapImage normalImage =
            new BitmapImage(new Uri("Resources/Images/SkillImages/left_arrow_normal.png", UriKind.Relative));
        image.Source = normalImage;
    }

    private void LArrow_OnMouseDown(object sender, MouseButtonEventArgs e)
    {
        Button button = (Button)sender;
        Image image = (Image)button.Template.FindName("LeftArrowImage", button);
        BitmapImage downImage =
            new BitmapImage(new Uri("Resources/Images/SkillImages/left_arrow_down.png", UriKind.Relative));
        image.Source = downImage;
    }

    private void LArrow_OnMouseUp(object sender, MouseButtonEventArgs e)
    {
        Button button = (Button)sender;
        Image image = (Image)button.Template.FindName("LeftArrowImage", button);
        BitmapImage normalImage =
            new BitmapImage(new Uri("Resources/Images/SkillImages/left_arrow_over.png", UriKind.Relative));
        image.Source = normalImage;
    }

    private void RArrow_OnMouseEnter(object sender, MouseEventArgs e)
    {
        Button button = (Button)sender;
        Image image = (Image)button.Template.FindName("RightArrowImage", button);
        BitmapImage normalImage =
            new BitmapImage(new Uri("Resources/Images/SkillImages/right_arrow_over.png", UriKind.Relative));
        image.Source = normalImage;
    }

    private void RArrow_OnMouseLeave(object sender, MouseEventArgs e)
    {
        Button button = (Button)sender;
        Image image = (Image)button.Template.FindName("RightArrowImage", button);
        BitmapImage normalImage =
            new BitmapImage(new Uri("Resources/Images/SkillImages/right_arrow_normal.png", UriKind.Relative));
        image.Source = normalImage;
    }

    private void RArrow_OnMouseDown(object sender, MouseButtonEventArgs e)
    {
        Button button = (Button)sender;
        Image image = (Image)button.Template.FindName("RightArrowImage", button);
        BitmapImage normalImage =
            new BitmapImage(new Uri("Resources/Images/SkillImages/right_arrow_down.png", UriKind.Relative));
        image.Source = normalImage;
    }

    private void RArrow_OnMouseUp(object sender, MouseButtonEventArgs e)
    {
        Button button = (Button)sender;
        Image image = (Image)button.Template.FindName("RightArrowImage", button);
        BitmapImage normalImage =
            new BitmapImage(new Uri("Resources/Images/SkillImages/right_arrow_over.png", UriKind.Relative));
        image.Source = normalImage;
    }
}