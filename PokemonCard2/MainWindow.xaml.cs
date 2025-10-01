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

namespace PokemonCard2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Pokemon kingler = new Pokemon(
                name: "Kingler",
                category: "Pincer",
                number: 99,
                height: 4.3,
                weight: 132.3,
                type: "Images/WaterIcon.jpg",
                hp: 140,
                imagePath: "Images/OIP.jpg",
                
                description: "Its oversixed claw is very powerfull but when it's not in battle, the claw just gets in the way",
                weakness: "Electric",
                attacks: new List<Attack>
                {
                    new Attack("Crabhammer", "Discard the top of opponents deck", 90),
                    new Attack("Guillotine", string.Empty, 220)
                }
            );
        public MainWindow()
        {
            InitializeComponent();
            
            DataContext = kingler;
            Image.SetBinding(Image.SourceProperty, new Binding("ImagePath"));
            Name.Text = kingler.Name;
            HP.Text = kingler.HP.ToString();
            SubInfo.Text = kingler.SubInfo();
            AttackOne.Text = kingler.Attacks[0].Name;   
            AttackOneDescription.Text = kingler.Attacks[0].ADescription;
            AttackOneDmg.Text = kingler.Attacks[0].Damage.ToString();
            AttackTwo.Text = kingler.Attacks[1].Name;
            AttackTwoDescription.Text = kingler.Attacks[1].ADescription;
            AttackTwoDmg.Text = kingler.Attacks[1].Damage.ToString();



            Description.Text = kingler.Description;

        }
    }
}