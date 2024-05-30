using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Media;

namespace prjOefn13
{
    public partial class MainMenu : Form
    {
        public string[,] strControls = new string[,]
        {
            {"\"PAGE DOWN\" = Lower refresh rate (max 1000)\n\"Z\" = Hogere zwaartekracht rechter onderhoek\n\"S\" = Hogere zwaartekracht linker bovenhoek\n" },
            {"\"HOME\" = start\n\"END\" = stop\n\"PAGE UP\" = Higher refresh rate (max 1)" }
        };

        string strControlss;

        SoundPlayer musicMainMenuTheme = new SoundPlayer(prjOefn13.Properties.Resources.Theme);

        public string[,] strPatchNotes = new string[,]
        {
            {"Release Date 13/05/23\nV0.1: Game release. "},
            {"Update 23/05/24\nV0.1.1: Control's weergave nieuwe uitleg & mogelijkheid om speler aan te maken."}
        };

        Speler speler = new Speler();
        public void StopMusic()
        {
            musicMainMenuTheme.Stop();
        }

        public void PlayMusic()
        {
            musicMainMenuTheme.PlayLooping();
        }
        public MainMenu()
        {
            InitializeComponent();
            
            this.CenterToScreen();

            musicMainMenuTheme.PlayLooping();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            MainGame frmMainGame = new MainGame();
            frmMainGame.Show();
            this.Hide();
            StopMusic();
        }

        private void btnMute_Click(object sender, EventArgs e)
        {
            StopMusic();
        }

        private void btnUnmute_Click(object sender, EventArgs e)
        {
            PlayMusic();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            strControlss = strControls[0, 0] + strControls[1, 0];
            MessageBox.Show(strControlss, "Controls");
            strControlss = "";
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnLore_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In the realm of Parmesio, where cheese flowed like rivers and dairy delicacies abounded, resided a noble Kaassnuiver named Brie. With his velvety exterior and pungent aroma, Brie ruled wisely and justly, bringing prosperity and harmony to all his subjects.\r\n\r\nHowever, the realm's tranquility was shattered by the arrival of the tyrannical Kiwi Lord, a villainous figure draped in green fuzz and armed with a sour disposition. Driven by an unquenchable thirst for power, the Kiwi Lord and his minions of moldy grapes and rotten pears launched a treacherous coup.\r\n\r\nAmidst the chaos, Brie was ruthlessly overthrown and exiled to the distant hills of Feta, where he languished in solitude. As darkness enveloped Parmesio, the Kiwi Lord imposed a reign of terror and corrupted the realm's once-pristine produce. Cheese turned rancid, buttermilk became acidic, and even the finest Gouda crumbled into dust.\r\n\r\nDetermined to restore peace and balance, Brie knew he had to return. With the help of loyal allies, including the courageous Cheddar Knight and the cunning Emmental Archer, he assembled a band of valiant warriors to challenge the Kiwi Lord's tyranny.\r\n\r\nAs they marched through the blighted land, Brie encountered countless victims of the Kiwi Lord's cruelty. He witnessed the suffering of the Roquefort Shepherds, whose flocks had been poisoned, and the despair of the Swiss Cheese Monks, whose monastery had been overrun by mold.\r\n\r\nInspired by their plight, Brie rallied his forces and led a charge into the Kiwi Lord's fortress. A fierce battle ensued, with cheese weapons clashing against moldy projectiles. Amidst the chaos, Brie faced the Kiwi Lord in a duel that would determine the fate of Parmesio.\r\n\r\nDrawing upon his wisdom and the power of righteousness, Brie outwitted the Kiwi Lord, trapping him in a vat of bubbling mozzarella. As the corrupt ruler was dragged away, light returned to the realm, and the evil that had consumed it dissipated.\r\n\r\nWith the Kiwi Lord overthrown, Brie reclaimed his rightful place as the guardian of Parmesio. He established a new era of peace and prosperity, where the cheese flowed freely and harmony reigned supreme. And so, the legend of Brie, the noble Kaassnuiver who defeated darkness and restored balance to the realm, was passed down through generations of dairy-loving creatures.\r\n", "Lore");
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Het aanpassen van aspecten in het gevecht zal in een van de volgende updates beschikbaar zijn, dus blij zeker Up-To-Date!", "Komt eraan in de volgende Update!");
        }

        private void btnPatchNotes_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{strPatchNotes[0, 0]}\n\n{strPatchNotes[1, 0]}", "Patch Notes");
        }

        private void btnSpelerInv_Click(object sender, EventArgs e)
        {
            string strSpelerVoornaam, strSpelerNaam;

            strSpelerVoornaam = Interaction.InputBox("Geef voornaam van de speler in.", "invoer");
            speler.SpelerVoornaam = strSpelerVoornaam;

            strSpelerNaam = Interaction.InputBox("Geef naam van de speler in.", "invoer");
            speler.SpelerNaam = strSpelerNaam;
        }

        private void btnSpelerUitv_Click(object sender, EventArgs e)
        {
            MessageBox.Show(speler.VolNaam(),"Naam speler");
        }
    }
}
