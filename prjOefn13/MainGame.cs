using System;
using System.Drawing;
using System.Security.Cryptography;
using System.Security.Permissions;
using System.Windows.Forms;
using NAudio.Wave;


namespace prjOefn13
{
    public partial class MainGame : Form
    {
        public int xSpeed = 8;
        public int ySpeed = 8;
        int intPosX, intPosY;
        int intTime = 0;

        public int intDamage = 5;
        public int intBossHealth = 100;

        string strControlss = "";
        public string[] strControls = new string[] {"\"ESCAPE\" = Afsluiten" ,"\"HOME\" = start", "\"END\" = stop", "\"PAGE UP\" = Higher refresh rate (max 1)", "\"PAGE DOWN\" = Lower refresh rate (max 1000)", "\"Z\" = Hogere zwaartekracht rechter onderhoek", "\"S\" = Hogere zwaartekracht linker bovenhoek" };

        Point pntPIC_GET = new Point();
        Random rndPos = new Random();

        System.Media.SoundPlayer musicBattle = new System.Media.SoundPlayer(prjOefn13.Properties.Resources.Battle);
        System.Media.SoundPlayer musicDamage = new System.Media.SoundPlayer(prjOefn13.Properties.Resources.Damage);
        System.Media.SoundPlayer musicVictory = new System.Media.SoundPlayer(prjOefn13.Properties.Resources.Victory);
        System.Media.SoundPlayer musicHereWeGoAgain = new System.Media.SoundPlayer(prjOefn13.Properties.Resources.HereWeGoAgain);

        public void ResetGame()
        {
            intTime = 0;
            prbBossHealth.Value = intBossHealth;
        }
        public void Stop()
        {
            TimerTime.Stop();
            TimerMAIN.Stop();
            musicBattle.Stop();
        }

        public void Exit() 
        {
            Stop();
            MessageBox.Show("Het spel wordt zodadelijk voor je afgesloten.\nBedankt om te spelen!", "Bedankt om et spelen!");
            Environment.Exit(1);
        }

        public void BackMainManu()
        {
            MainMenu frmMainMenu = new MainMenu();
            MessageBox.Show("Je word zodadelijk terug naar de main menu gebracht", "Back to the lobby");
            frmMainMenu.Show();
            this.Close();
        }

        public MainGame()
        {
            InitializeComponent();

            this.CenterToScreen();

            for (int i = 0; i < strControls.Length; i++)
            {
                strControlss += strControls[i] + "\n";
            }

            lblInfo.Text = "Refresh Rate: " + TimerMAIN.Interval + "\n" + "XSpeed = " + xSpeed + "\n" + "YSpeed = " + ySpeed + "\n\n" + strControlss + "\n\n" + "Time: " + intTime + "s";

            intPosX = rndPos.Next(183, 1176);
            intPosY = rndPos.Next(131, 534);

            pntPIC_GET.X = intPosX;
            pntPIC_GET.Y = intPosY;

            picGET.Location = pntPIC_GET;

            prbBossHealth.ForeColor = Color.Red;

            prbBossHealth.Value = intBossHealth;

            lblBossTitle.Text = "Defeat the Kiwi lords' goons";
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            picKaasSnuiver.Location = new Point(ClientSize.Width / 2 - picKaasSnuiver.Width / 2,
                                             ClientSize.Height / 2 - picKaasSnuiver.Height / 2);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DialogResult dlrAgain;

            picKaasSnuiver.Left += xSpeed;
            picKaasSnuiver.Top += ySpeed;

            if (picKaasSnuiver.Left < 0 || picKaasSnuiver.Right > ClientSize.Width)
            {
                xSpeed = -xSpeed;
            }

            if (picKaasSnuiver.Top < 0 || picKaasSnuiver.Bottom > ClientSize.Height)
            {
                ySpeed = -ySpeed;
            }

            if(picKaasSnuiver.Bounds.IntersectsWith(picGET.Bounds))
            {
                intPosX = rndPos.Next(183, 1176);
                intPosY = rndPos.Next(131, 534);

                pntPIC_GET.X = intPosX;
                pntPIC_GET.Y = intPosY;

                picGET.Location = pntPIC_GET;

                if (prbBossHealth.Value != 0)
                {
                    prbBossHealth.Value = prbBossHealth.Value - intDamage;
                }
                else
                {
                    TimerMAIN.Stop();
                    TimerTime.Stop();
                    musicVictory.Play();
                    dlrAgain = MessageBox.Show("Je bent gewonnen! Je hebt de slechte kiwi verslagen!\nBedankt om te spelen. We zijn actief bezig met de volgende updates met veel meer gloed nieuwe en interesaante dingen!\nWil je opnieuw spelen?", "Victory!", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

                    if(dlrAgain == DialogResult.Yes)
                    {
                        ResetGame();
                        musicVictory.Stop();
                        musicHereWeGoAgain.Play();
                    }
                    if(dlrAgain == DialogResult.No)
                    {
                        BackMainManu();
                    }
                }
            }
        }

        private void TimerTime_Tick(object sender, EventArgs e)
        {
            intTime++;
            lblInfo.Text = "Refresh Rate: " + TimerMAIN.Interval + "\n" + "XSpeed = " + xSpeed + "\n" + "YSpeed = " + ySpeed + "\n\n" + strControlss + "\n\n" + "Time: " + intTime + "s";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Z:
                    {
                        xSpeed++;
                        ySpeed++;
                        break;
                    }
                case Keys.S:
                    {
                        xSpeed--;
                        ySpeed--;
                        break;
                    }
                case Keys.End:
                    {
                        TimerMAIN.Stop();
                        break;
                    }
                case Keys.Home:
                    {
                        TimerMAIN.Start();

                        TimerTime.Start();

                        musicBattle.PlayLooping();
                        break;
                    }
                case Keys.PageUp:
                    {
                        if (TimerMAIN.Interval != 1000)
                        {
                            TimerMAIN.Interval = TimerMAIN.Interval + 10;
                        }
                        break;
                    }
                case Keys.PageDown:
                    {
                        if (TimerMAIN.Interval != 1)
                        {
                            TimerMAIN.Interval = TimerMAIN.Interval - 10;
                        }
                        break;
                    }
                 case Keys.Escape:
                    {
                        Exit();
                        break;
                    }
            }
            lblInfo.Text = "Refresh Rate: " + TimerMAIN.Interval + "\n" + "XSpeed = " + xSpeed + "\n" + "YSpeed = " + ySpeed + "\n\n" + strControlss + "\n\n" + "Time: " + intTime + "s";
        }
    }
}
