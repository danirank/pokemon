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
        
        public MainWindow()
        {
            InitializeComponent();

            Pokemon kingler = new Pokemon(
                name: "Kingler",
                category: "Pincer",
                number: 99,
                height: 4.3,
                weight: 132.3,
                type: PokemonType.Water,
                hp: 140,
                imagePath: "Images/OIP.jpg",
                description: "Its oversixed claw is very powerfull but when it's not in battle, the claw just gets in the way",
                weakness: PokemonType.Electric,
                attacks: new List<Attack>
                {
                    new Attack("Crabhammer", "Discard the top of opponents deck", 90),
                    new Attack("Guillotine", string.Empty, 220)
                }

            );

            

            DataContext = kingler;

            SetUpWindow(kingler);

        }
        public void SetUpWindow(Pokemon p)
        {
            Name.Text = p.Name;
            Icon.Text = Pokemon.TypeImages[p.Type];
            HP.Text = p.HP.ToString();
            SubInfo.Text = p.SubInfo();
            AttackOneIcon.Text = Pokemon.TypeImages[p.Type];
            AttackOne.Text = p.Attacks[0].Name;
            AttackOneDescription.Text = p.Attacks[0].ADescription;
            AttackOneDmg.Text = p.Attacks[0].Damage.ToString();
            AttackTwoIcon.Text = Pokemon.TypeImages[p.Type];    
            AttackTwo.Text = p.Attacks[1].Name;
            AttackTwoDescription.Text = p.Attacks[1].ADescription;
            AttackTwoDmg.Text = p.Attacks[1].Damage.ToString();
            Description.Text = p.Description;

        }
    }
}