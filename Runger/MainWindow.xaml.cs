using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using System.IO;
using Microsoft.Win32;

namespace Runger
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            storeagain = false;            
            newgame = true;
            nickname = "*noname*";
            wave = 1;
            runs = 0;
            energyblock = 0;
            debris = 0;
            debrisofmeteorit = 0;
            slimeofuo = 0;
            partofmonolith = 0;
            minRandom = 100;
            maxRandom = 300;
            lvlweapon = 1;
            lvlhpship = 1;
            lvlspeedbullet = 1;
            lvlpowerb = 1;
            costpowerb = -30000;
            costspeedbullet = -5000;
            costweapon = -3000;
            costhpship = -3000;
            senemyspeedbullet1 = 1;
            senemyspeedbullet2 = 1;
            speedbullet = 1;
            bossspeedbullet = 1;
            timebossspeedbullet = 10;
            timespeedbullet = 10;
            timese1speedbullet = 10;
            timese2speedbullet = 10;
            intervalboss = 30;
            intervalse1 = 30;
            intervalse2 = 30;
            chpboss = 100;
            schpboss = chpboss;
            chpsenemy1 = 50;
            schpsenemy1 = chpsenemy1;
            chpsenemy2 = 50;
            schpsenemy2 = chpsenemy2;
            chpship = 20;
            schpship = chpship;
            csdamage = 5;
            cbdamage = 10;
            cse1damage = 5;
            cse2damage = 5;
            mainmenumedia.Volume = 0.3;
            NTrack = 1;
            TimeMusic();
        }
        #region AllElements 
        MediaPlayer mainmenumedia = new MediaPlayer();
        MediaPlayer hit = new MediaPlayer();
        MediaPlayer startmenu = new MediaPlayer();
        MediaPlayer blip = new MediaPlayer();
        MediaPlayer butclk = new MediaPlayer();
        MediaPlayer store = new MediaPlayer();
        MediaPlayer shotse1 = new MediaPlayer();
        MediaPlayer shotse2 = new MediaPlayer();
        MediaPlayer shotboss = new MediaPlayer();
        MediaPlayer shotship = new MediaPlayer();
        MediaPlayer sboom = new MediaPlayer();
        string nickname, lname;
        bool newgame,
        meteorittimeron,
        storeagain,
        ssanticheat,
        manticheat,
        banticheat,
        se1anticheat,
        se2anticheat,
        sstesttime,
        btesttime,
        bstesttime,
        se1testtime,
        se1stesttime,
        se2testtime,
        se2stesttime,
        gotoright,
        gotorightsenemy1,
        gotoleftsenemy2,
        bosstimeron,
        bossbullettimeron,
        ssbullettimeron,
        senemytimeron1,
        senemytimeron2,
        senemybullettimeron1,
        senemybullettimeron2,
        meteorittesttime;
        Label hpboss,
        hpsship,
        hpsenemy1,
        hpsenemy2;
        int CNTrack,
            colsim,
         NTrack,
         sscountbullets,
         bcountbullets,
         se1countbullets,
         se2countbullets,
         mcountbullets,
         speedbullet,
         bossspeedbullet,
         senemyspeedbullet1,
         senemyspeedbullet2,
         wave,
         runs,
         giveruns,
         storeobject,
         energyblock,
         giveenergyblock,
         debris,
         givedebris,
         debrisofmeteorit,
         givedebrisofmeteorit,
         slimeofuo,
         giveslimeofuo,
         partofmonolith,
         givepartofmonolith,
         minRandom,
         maxRandom,
         chance,
         timespeedbullet,
         timebossspeedbullet,
         timese1speedbullet,
         timese2speedbullet,
         intervalboss,
         intervalse1,
         intervalse2,
         lvlweapon,
         costweapon,
         lvlhpship,
         costhpship,
         lvlspeedbullet,
         costspeedbullet,
         lvlpowerb,
         costpowerb,
         metx,
         mspd,
         mtimespd;
        Random rndcountloot = new Random();
        Random rndloot = new Random();
        Random rndmusic = new Random();
        Random metrnd = new Random();
        Rect SSRect,
         SSBullet,
         BBullet,
         SSBoss,
         Recthpbosspolosblk,
         Recthpsspolosblk,
         Rectsenemy1,
         Rectsenemybullet1,
         Rectsenemy2,
         Rectsenemybullet2,
         MRect;
        DispatcherTimer bulletTimer,
         bossTimer,
         bossbulletTimer,
         senemyTimer1,
         senemybulletTimer1,
         senemyTimer2,
         senemybulletTimer2,
         TimerMusic,
         MeteoritTimer;
        Image FonPole,
        ssbullet,
        bbullet,
        boss,
        spaceship,
        boom,
        senemy1,
        senemy2,
        senemybullet1,
        senemybullet2,
        meteorit;
        double chpsenemy1,
         schpsenemy1,
         schpsenemy2,
         chpsenemy2,
         chpboss,
         schpboss,
         chpship,
         schpship,
         csdamage,
         cbdamage,
         cse1damage,
         cse2damage,
         phpsenemy1,
         phpsenemy2,
         phpboss,
         phpship,
         pse1damage,
         pse2damage,
         psdamage,
         psse1damage,
         psse2damage,
         pbdamage,
         minuswidthhpbosspolos,
         minuswidthhpsenemy1polos,
         minuswidthhpsenemy2polos,
         bminuswidthhpshippolos,
         se1minuswidthhpshippolos,
         se2minuswidthhpshippolos,
         widthhpboss,
         widthhpsship,
         widthhpsenemy1,
         widthhpsenemy2;                
        Rectangle hpbosspolos,
        hpsenemy1polos,
        hpsenemy2polos,
        hpbosspolosblk,
        hpsshippolos,
        hpsshippolosblk;
        #endregion
        #region MusicStation
        private void TimeMusic()
        {
            TimerMusic = new DispatcherTimer();
            TimerMusic.Tick += TimerMusic_Tick;
            TimerMusic.Interval = new TimeSpan(0,0,0,1,0);
            TimerMusic.IsEnabled = true;
        }
        private void TimerMusic_Tick(object sender, EventArgs e) //1-6 only menu 7-8 - store 
        {
            if (NTrack == 1)
            {
                mainmenumedia.Open(new Uri(@"..\..\music\Bossfight - Intro.mp3", UriKind.Relative));
                mainmenumedia.Play();
                NTrack = 0;
                CNTrack = 1;
            }
            if (NTrack == 2)
            {
                mainmenumedia.Open(new Uri(@"..\..\music\F.O.O.L - Criminals.mp3", UriKind.Relative));
                mainmenumedia.Play();
                NTrack = 0;
                CNTrack = 1;
            }
            if (NTrack == 3)
            {
                mainmenumedia.Open(new Uri(@"..\..\music\F.O.O.L - Time Spender.mp3", UriKind.Relative));
                mainmenumedia.Play();
                NTrack = 0;
                CNTrack = 1;
            }
            if (NTrack == 4)
            {
                mainmenumedia.Open(new Uri(@"..\..\music\Pax Impera, ZABO - Aftermath.mp3", UriKind.Relative));
                mainmenumedia.Play();
                NTrack = 0;
                CNTrack = 1;
            }
            if (NTrack == 5)
            {
                mainmenumedia.Open(new Uri(@"..\..\music\F.O.O.L - Conflict.mp3", UriKind.Relative));
                mainmenumedia.Play();
                NTrack = 0;
                CNTrack = 1;
            }
                if (NTrack == 6) 
            {
                mainmenumedia.Open(new Uri(@"..\..\music\Bossfight - Outro.mp3", UriKind.Relative));
                mainmenumedia.Play();
                NTrack = 0;
                CNTrack = 1;
            }
            if (NTrack == 7) 
            {
                mainmenumedia.Open(new Uri(@"..\..\music\Bossfight, F.O.O.L - Mercy.mp3", UriKind.Relative));
                mainmenumedia.Play();
                NTrack = 0;
                CNTrack = 2;
            }
            if (NTrack == 8) 
            {
                mainmenumedia.Open(new Uri(@"..\..\music\F.O.O.L, Power Glove - Mercenary.mp3", UriKind.Relative)); 
                mainmenumedia.Play();
                NTrack = 0;
                CNTrack = 2;
            }
            if (NTrack == 9) 
            {
                mainmenumedia.Open(new Uri(@"..\..\music\Satara - Flame On.mp3", UriKind.Relative));
                mainmenumedia.Play();
                NTrack = 0;
                CNTrack = 2;
            }
            if (NTrack == 10) 
            {
                mainmenumedia.Open(new Uri(@"..\..\music\Bossfight - Carol of the Cartels.mp3", UriKind.Relative));
                mainmenumedia.Play();
                NTrack = 0;
                CNTrack = 3;
            }
            if (NTrack == 11) 
            {
                mainmenumedia.Open(new Uri(@"..\..\music\BassnPanda - Mirai.mp3", UriKind.Relative));
                mainmenumedia.Play();
                NTrack = 0;
                CNTrack = 3;
            }
            if (NTrack == 12) 
            {
                mainmenumedia.Open(new Uri(@"..\..\music\Buku - Death Rattle.mp3", UriKind.Relative));
                mainmenumedia.Play();
                NTrack = 0;
                CNTrack = 3;
            }
            if (NTrack == 13) 
            {
                mainmenumedia.Open(new Uri(@"..\..\music\Infraction - Cyber Attack.mp3", UriKind.Relative));
                mainmenumedia.Play();
                NTrack = 0;
                CNTrack = 3;
            }
            if (NTrack == 14) 
            {
                mainmenumedia.Open(new Uri(@"..\..\music\Far Out - Strike.mp3", UriKind.Relative));
                mainmenumedia.Play();
                NTrack = 0;
                CNTrack = 3;
            }
            if (NTrack == 15) 
            {
                mainmenumedia.Open(new Uri(@"..\..\music\F.O.O.L - Revenger.mp3", UriKind.Relative));
                mainmenumedia.Play();
                NTrack = 0;
                CNTrack = 4;
            }
            if (NTrack == 16) 
            {
                mainmenumedia.Open(new Uri(@"..\..\music\Gress - VLST.mp3", UriKind.Relative));
                mainmenumedia.Play();
                NTrack = 0;
                CNTrack = 4;
            }
            if (NTrack == 17) 
            {
                mainmenumedia.Open(new Uri(@"..\..\music\KROWW - Call Of The Void.mp3", UriKind.Relative));
                mainmenumedia.Play();
                NTrack = 0;
                CNTrack = 4;
            }
            if (NTrack == 18) 
            {
                mainmenumedia.Open(new Uri(@"..\..\music\Bossfight - Endgame.mp3", UriKind.Relative));
                mainmenumedia.Play();
                NTrack = 0;
                CNTrack = 4;
            }
            if (NTrack == 19)
            {
                mainmenumedia.Open(new Uri(@"..\..\music\ShockOne, Blanke - Follow Me.mp3", UriKind.Relative));
                mainmenumedia.Play();
                NTrack = 0;
                CNTrack = 5;
            }
            if (mainmenumedia.NaturalDuration.HasTimeSpan == true)
                if (mainmenumedia.Position == mainmenumedia.NaturalDuration.TimeSpan)
                {
                if(CNTrack == 1) NTrack = rndmusic.Next(1, 6);
                if (CNTrack == 2) NTrack = rndmusic.Next(7, 9);
                if (CNTrack == 3) NTrack = rndmusic.Next(10, 14);
                if (CNTrack == 4) NTrack = rndmusic.Next(15, 18);
                if (CNTrack == 5) NTrack = 19;
                }
        }
        #endregion
        //Black&Yellow - смена цвета при наведении указателем мыши в главном меню на название игры
        #region Black&Yellow 
        private void SaveGame_MouseEnter(object sender, MouseEventArgs e)
        {
            SaveGame.Foreground = Brushes.Black;
            blip.Open(new Uri(@"..\..\sound\blipbut.wav", UriKind.Relative));
            blip.Play();
        }

        private void SaveGame_MouseLeave(object sender, MouseEventArgs e)
        {
            SaveGame.Foreground = Brushes.Yellow;
        }

        private void Stats_MouseEnter(object sender, MouseEventArgs e)
        {
            Stats.Foreground = Brushes.Black;
            blip.Open(new Uri(@"..\..\sound\blipbut.wav", UriKind.Relative));
            blip.Play();
        }

        private void Stats_MouseLeave(object sender, MouseEventArgs e)
        {
            Stats.Foreground = Brushes.Yellow;
        }

        private void Play_MouseEnter(object sender, MouseEventArgs e)
        {
            Gplay.Foreground = Brushes.Black;
            blip.Open(new Uri(@"..\..\sound\blipbut.wav", UriKind.Relative));
            blip.Play();
        }

        private void Play_MouseLeave(object sender, MouseEventArgs e)
        {
            Gplay.Foreground = Brushes.Yellow;
        }
        private void LoadGame_MouseEnter(object sender, MouseEventArgs e)
        {
            LoadGame.Foreground = Brushes.Black;
            blip.Open(new Uri(@"..\..\sound\blipbut.wav", UriKind.Relative));
            blip.Play();
        }

        private void LoadGame_MouseLeave(object sender, MouseEventArgs e)
        {
            LoadGame.Foreground = Brushes.Yellow;
        }

        private void Rules_MouseEnter(object sender, MouseEventArgs e)
        {
            Store.Foreground = Brushes.Black;
            blip.Open(new Uri(@"..\..\sound\blipbut.wav", UriKind.Relative));
            blip.Play();
        }

        private void Rules_MouseLeave(object sender, MouseEventArgs e)
        {
            Store.Foreground = Brushes.Yellow;
        }

        private void Exit_MouseEnter(object sender, MouseEventArgs e)
        {
            Exit.Foreground = Brushes.Black;
            blip.Open(new Uri(@"..\..\sound\blipbut.wav", UriKind.Relative));
            blip.Play();
        }

        private void Exit_MouseLeave(object sender, MouseEventArgs e)
        {
            Exit.Foreground = Brushes.Yellow;
        }
        #endregion
        /*Сделать прокачку для маневренности корабля.*/       
        
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            butclk.Open(new Uri(@"..\..\sound\buttonclick.wav", UriKind.Relative));
            butclk.Play();
            this.Close();
        }
        //Рандомные цвета при наведении на куб(монолит)
        #region RandomColorsForCubeAndText
        private void Runger_MouseDown(object sender, MouseButtonEventArgs e)
        {
            byte green, red, blue;
            Random rnd = new Random();
            green = Convert.ToByte(rnd.Next(0, 255));
            red = Convert.ToByte(rnd.Next(0, 255));
            blue = Convert.ToByte(rnd.Next(0, 255));
            Runger.Foreground = new SolidColorBrush(Color.FromRgb(red, green, blue));
        }

        private void Rec3_MouseEnter(object sender, MouseEventArgs e)
        {
            byte green, red, blue;
            Random rnd = new Random();
            green = Convert.ToByte(rnd.Next(0, 255));
            red = Convert.ToByte(rnd.Next(0, 255));
            blue = Convert.ToByte(rnd.Next(0, 255));
            rec3.Fill = new SolidColorBrush(Color.FromRgb(red, green, blue));
        }

        private void Rec2_MouseEnter(object sender, MouseEventArgs e)
        {
            byte green, red, blue;
            Random rnd = new Random();
            green = Convert.ToByte(rnd.Next(0, 255));
            red = Convert.ToByte(rnd.Next(0, 255));
            blue = Convert.ToByte(rnd.Next(0, 255));
            rec2.Fill = new SolidColorBrush(Color.FromRgb(red, green, blue));
        }

        private void Rec1_MouseEnter(object sender, MouseEventArgs e)
        {
            byte green, red, blue;
            Random rnd = new Random();
            green = Convert.ToByte(rnd.Next(0, 255));
            red = Convert.ToByte(rnd.Next(0, 255));
            blue = Convert.ToByte(rnd.Next(0, 255));
            rec1.Fill = new SolidColorBrush(Color.FromRgb(red, green, blue));
        }
        #endregion
        #region NewGameMenu
        private void NCreate_Click(object sender, RoutedEventArgs e)
        {
            lname = NNick.Text;            
            for (int i = 0; i < lname.Length; i++)
            {
                if (Convert.ToString(lname[i]) == " ") colsim++;
            }
            if ((NNick.Text == null) || (lname.Length == colsim)) MessageBox.Show("Введите нормальный nickname :c", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            else
            {
                butclk.Open(new Uri(@"..\..\sound\buttonclick.wav", UriKind.Relative));
                butclk.Play();
                NGame.Visibility = Visibility.Hidden;
                newgame = false;
                nickname = NNick.Text;
            }
        }

        private void NCancel_Click(object sender, RoutedEventArgs e)
        {
            butclk.Open(new Uri(@"..\..\sound\buttonclick.wav", UriKind.Relative));
            butclk.Play();
            NGame.Visibility = Visibility.Hidden;
            NNick.Clear();
        }
        #endregion

        #region PlaySettings
        private void Play_Click(object sender, RoutedEventArgs e)
        {
            if (newgame == true)
            {
                NGame.Visibility = Visibility.Visible;
                colsim = 0;
            }
            else
            {
                if (EndGame.Visibility == Visibility.Visible) EndGame.Visibility = Visibility.Hidden;
                mainmenumedia.Stop();
                butclk.Open(new Uri(@"..\..\sound\buttonclick.wav", UriKind.Relative));
                butclk.Play();
                startmenu.Open(new Uri(@"..\..\sound\playnw.wav", UriKind.Relative));
                startmenu.Play();
                meteorittesttime = false;
                sstesttime = false;
                btesttime = false;
                bstesttime = false;
                se1testtime = false;
                se1stesttime = false;
                se2testtime = false;
                se2stesttime = false;
                Pause.IsEnabled = true;
                MainMenu.Visibility = Visibility.Hidden;
                Ggame.Visibility = Visibility.Visible;
                SSRect = new Rect(371, 30, 50, 50);
                SSBoss = new Rect(283, 320, 215, 144);
                Recthpbosspolosblk = new Rect(0, 385, 794, 30);
                Recthpsspolosblk = new Rect(0, 0, 794, 30);
                Rectsenemy1 = new Rect(130, 260, 50, 50);
                Rectsenemy2 = new Rect(600, 260, 50, 50);
                MRect = new Rect(0, 335, 50, 50);
                sscountbullets = 0;
                bcountbullets = 0;
                se1countbullets = 0;
                se2countbullets = 0;
                mcountbullets = 0;
                chpboss = schpboss;
                chpsenemy1 = schpsenemy1;
                chpsenemy2 = schpsenemy2;
                chpship = schpship;
                phpboss = 100;
                phpsenemy1 = 100;
                phpsenemy2 = 100;
                phpship = 100;
                mtimespd = intervalboss;
                psdamage = csdamage / chpboss * 100;
                psse1damage = csdamage / chpsenemy1 * 100;
                psse2damage = csdamage / chpsenemy2 * 100;
                pbdamage = cbdamage / chpship * 100;
                pse1damage = cse1damage / chpship * 100;
                pse2damage = cse2damage / chpship * 100;
                psdamage = csdamage / chpboss * 100;
                gotoright = false;
                FonPole = new Image
                {
                    Source = new BitmapImage(new Uri("images\\space.jpg", UriKind.Relative)),
                    Height = 421,
                    Width = 794,
                    Stretch = Stretch.Fill,
                };
                Canvas.SetLeft(FonPole, 0);
                Canvas.SetTop(FonPole, 0);
                Ggame.Children.Add(FonPole);
                hpbosspolosblk = new Rectangle
                {
                    Fill = Brushes.Black,
                    Width = 784,
                    Height = 28,
                };
                Canvas.SetLeft(hpbosspolosblk, 0);
                Canvas.SetTop(hpbosspolosblk, 0);
                Ggame.Children.Add(hpbosspolosblk);
                hpsshippolosblk = new Rectangle
                {
                    Fill = Brushes.Black,
                    Width = 784,
                    Height = 28,
                };
                Canvas.SetLeft(hpsshippolosblk, 0);
                Canvas.SetBottom(hpsshippolosblk, 0);
                Ggame.Children.Add(hpsshippolosblk);
                hpsshippolos = new Rectangle
                {
                    Fill = Brushes.Green,
                    Width = 784,
                    Height = 28,
                    Stroke = Brushes.Black,
                    StrokeThickness = 3,

                };
                Canvas.SetLeft(hpsshippolos, 0);
                Canvas.SetBottom(hpsshippolos, 0);
                Ggame.Children.Add(hpsshippolos);
                bminuswidthhpshippolos = (hpsshippolos.Width * pbdamage / 100);
                hpsship = new Label
                {
                    Content = "100%",
                    Width = 784,
                    Height = 28,
                    Background = null,
                    FontWeight = FontWeights.Bold,
                    FontSize = 16,
                    BorderBrush = null,
                    Foreground = Brushes.LightGreen,
                    HorizontalContentAlignment = HorizontalAlignment.Center,
                };
                Canvas.SetLeft(hpsship, 0);
                Canvas.SetBottom(hpsship, 0);
                Ggame.Children.Add(hpsship);

                spaceship = new Image
                {
                    Source = new BitmapImage(new Uri("images\\spaceship.png", UriKind.Relative)),
                    Height = 50,
                    Width = 50,
                    Stretch = Stretch.Fill,
                    RenderTransformOrigin = new Point(0.434, 0.408),
                };
                Canvas.SetLeft(spaceship, 371);
                Canvas.SetBottom(spaceship, 30);
                Ggame.Children.Add(spaceship);
                if ((wave % 5) == 0)
                {
                    mtimespd = intervalboss;
                    NTrack = rndmusic.Next(15, 18);
                    boss = new Image
                    {
                        Source = new BitmapImage(new Uri("images\\boss.png", UriKind.Relative)),
                        Height = 144,
                        Width = 215,
                        Stretch = Stretch.Fill,
                    };
                    Canvas.SetLeft(boss, 283);
                    Canvas.SetTop(boss, 0);
                    Ggame.Children.Add(boss);
                    hpbosspolos = new Rectangle
                    {
                        Fill = Brushes.Red,
                        Width = 784,
                        Height = 28,
                        Stroke = Brushes.Black,
                        StrokeThickness = 3,
                    };
                    Canvas.SetTop(hpbosspolos, 0);
                    Canvas.SetLeft(hpbosspolos, 0);
                    Ggame.Children.Add(hpbosspolos);
                    minuswidthhpbosspolos = (hpbosspolos.Width * psdamage / 100);
                    hpboss = new Label
                    {
                        Content = "100%",
                        Width = 784,
                        Height = 28,
                        Background = null,
                        FontWeight = FontWeights.Bold,
                        FontSize = 16,
                        BorderBrush = null,
                        Foreground = Brushes.LightBlue,
                        HorizontalContentAlignment = HorizontalAlignment.Center,
                    };
                    Ggame.Children.Add(hpboss);
                }
                else if ((wave % 5) != 0)
                {
                    mtimespd = intervalse1;
                    NTrack = rndmusic.Next(10, 14);
                    senemy1 = new Image
                    {
                        Source = new BitmapImage(new Uri("images\\smallenemy.png", UriKind.Relative)),
                        Height = 50,
                        Width = 50,
                        Stretch = Stretch.Fill,
                    };
                    Canvas.SetLeft(senemy1, 130);
                    Canvas.SetTop(senemy1, 110);
                    Ggame.Children.Add(senemy1);
                    senemy2 = new Image
                    {
                        Source = new BitmapImage(new Uri("images\\smallenemy.png", UriKind.Relative)),
                        Height = 50,
                        Width = 50,
                        Stretch = Stretch.Fill,
                    };
                    Canvas.SetLeft(senemy2, 600);
                    Canvas.SetTop(senemy2, 110);
                    Ggame.Children.Add(senemy2);
                    se1minuswidthhpshippolos = (hpsshippolos.Width * pse1damage / 100);
                    se2minuswidthhpshippolos = (hpsshippolos.Width * pse2damage / 100);
                    hpsenemy1polos = new Rectangle
                    {
                        Fill = Brushes.Red,
                        Width = 392,
                        Height = 28,
                        Stroke = Brushes.Black,
                        StrokeThickness = 3,
                    };
                    Canvas.SetTop(hpsenemy1polos, 0);
                    Canvas.SetLeft(hpsenemy1polos, 0);
                    Ggame.Children.Add(hpsenemy1polos);
                    minuswidthhpsenemy1polos = (hpsenemy1polos.Width * psse1damage / 100);
                    hpsenemy2polos = new Rectangle
                    {
                        Fill = Brushes.Red,
                        Width = 392,
                        Height = 28,
                        Stroke = Brushes.Black,
                        StrokeThickness = 3,
                    };
                    Canvas.SetTop(hpsenemy2polos, 0);
                    Canvas.SetLeft(hpsenemy2polos, 392);
                    Ggame.Children.Add(hpsenemy2polos);
                    minuswidthhpsenemy2polos = (hpsenemy2polos.Width * psse2damage / 100);
                    hpsenemy1 = new Label
                    {
                        Content = "100%",
                        Width = 392,
                        Height = 28,
                        Background = null,
                        FontWeight = FontWeights.Bold,
                        FontSize = 16,
                        BorderBrush = null,
                        Foreground = Brushes.LightBlue,
                        HorizontalContentAlignment = HorizontalAlignment.Center,
                    };
                    Ggame.Children.Add(hpsenemy1);
                    hpsenemy2 = new Label
                    {
                        Content = "100%",
                        Width = 392,
                        Height = 28,
                        Background = null,
                        FontWeight = FontWeights.Bold,
                        FontSize = 16,
                        BorderBrush = null,
                        Foreground = Brushes.LightBlue,
                        HorizontalContentAlignment = HorizontalAlignment.Center,
                    };
                    Canvas.SetLeft(hpsenemy2, 392);
                    Ggame.Children.Add(hpsenemy2);
                }
                UFO();
            }
        }
        #endregion
        private void UFO()
        {
            se1stesttime = false;
            se2stesttime = false;
            bstesttime = false;
            meteorittesttime = false;
            if ((wave % 5) == 0) SpeedBoss();
            else if ((wave % 5) != 0)
            {
                SpeedSEnemy1();
                SpeedSEnemy2();                
            }
            Meteorit();
        }
        #region Meteorit
        private void Meteorit()
        {
            meteorittimeron = true;
                if (meteorittesttime == true) MeteoritTimer.IsEnabled = false;
            MeteoritTimer = new DispatcherTimer();
            MeteoritTimer.Tick += MeteoritTimer_Tick;
            MeteoritTimer.Interval = new TimeSpan(0, 0, 0, 0, mtimespd);
            MeteoritTimer.IsEnabled = true;
        }
        private void MeteoritTimer_Tick(object sender, EventArgs e)
        {
            meteorittesttime = true;
            if (mcountbullets == 1) mcountbullets = 1;
            else
            {
                meteorittesttime = false;
                manticheat = true;
                mcountbullets = 1;
                RotateTransform rmeteorit = new RotateTransform(-90);
                meteorit = new Image
                {
                    Stretch = Stretch.Fill,
                    Width = 70,
                    Height = 70,
                    Source = new BitmapImage(new Uri("images\\fireball.png", UriKind.Relative)),                    
                };
                metx = metrnd.Next(50, 734);
                mspd = metrnd.Next(1, 3);
                MRect = new Rect(metx, 285, 10, 10);
                Canvas.SetBottom(meteorit, MRect.Y);
                Canvas.SetLeft(meteorit, MRect.X - 27);
                Ggame.Children.Add(meteorit);                
            }
            MeteoritSpd();
        }
           private  void MeteoritSpd()
            {
                MRect.Y -= mspd;
                Canvas.SetBottom(meteorit, MRect.Y -10);
                MAppleToPlayerOrNo();
            }
           private  void MAppleToPlayerOrNo()
            {
                if (MRect.IntersectsWith(SSRect) == true)
                {
                    if (manticheat == false) MeteoritTimer.IsEnabled = false;
                    else
                    {
                        MeteoritTimer.IsEnabled = false;
                        Ggame.Children.Remove(meteorit);
                        hpsship.Content = "0%";
                        hpsshippolos.Width = 0;
                        if ((wave % 5) == 0)
                        {
                            bossbulletTimer.IsEnabled = false;
                            bossTimer.IsEnabled = false;
                        }
                        if ((wave % 5) != 0)
                        {
                            senemybulletTimer1.IsEnabled = false;
                            senemyTimer1.IsEnabled = false;
                            senemybulletTimer2.IsEnabled = false;
                            senemyTimer2.IsEnabled = false;
                        }
                        boom = new Image
                            {
                                Source = new BitmapImage(new Uri("images\\bigbom.png", UriKind.Relative)),
                                Stretch = Stretch.Fill,
                                Width = 50,
                                Height = 50,
                            };
                            Canvas.SetBottom(boom, SSRect.Y);
                            Canvas.SetLeft(boom, SSRect.X);
                            Ggame.Children.Add(boom);
                            sboom.Open(new Uri(@"..\..\sound\boom.wav", UriKind.Relative));
                            sboom.Play();
                            NextWave.Content = "Try Again";
                            EndGame.Visibility = Visibility.Visible;
                            MessageBox.Show("К сожалению, вы проиграли :c\nВ результате сражения вы ничего не получили", "YOU LOSE ^.^", MessageBoxButton.OK, MessageBoxImage.Error);
                        
                    }
                }
                else if (MRect.IntersectsWith(Recthpsspolosblk) == true)
                {
                    if (manticheat == false) MeteoritTimer.IsEnabled = false;
                    else
                    {                        
                        Ggame.Children.Remove(meteorit);
                        mcountbullets = 0;
                        manticheat = false;
                        meteorittesttime = true;
                    }
                }
            }
#endregion

        #region BossSettings
        private void SpeedBoss()
        {
            bosstimeron = true;
            if (bstesttime == true) bossTimer.IsEnabled = false;
            bossTimer = new DispatcherTimer();
            bossTimer.Tick += BossTimer_Tick;
            bossTimer.Interval = new TimeSpan(0, 0, 0, 0, intervalboss);
            bossTimer.IsEnabled = true;
        }
        private void BossTimer_Tick(object sender, EventArgs e)
        {
            if (gotoright == true) Canvas.SetLeft(boss, SSBoss.X += 1);
            else if (gotoright == false) Canvas.SetLeft(boss, SSBoss.X -= 1);
            if (SSBoss.X == 0) gotoright = true;
            else if (SSBoss.X == 565) gotoright = false;
            bstesttime = true;
            if (bcountbullets == 1) bcountbullets = 1;
            else
            {
                btesttime = false;
                banticheat = true;
                bcountbullets = 1;
                bbullet = new Image
                {
                    Stretch = Stretch.Fill,
                    Width = 25,
                    Height = 25,
                    Source = new BitmapImage(new Uri("images\\bullet.png", UriKind.Relative)),
                };
                BBullet = new Rect(SSBoss.X + 105, SSBoss.Y - 22, 15, 15);
                Canvas.SetBottom(bbullet, BBullet.Y);
                Canvas.SetLeft(bbullet, BBullet.X);
                Ggame.Children.Add(bbullet);
                shotboss.Open(new Uri(@"..\..\sound\startfire.wav", UriKind.Relative));
                shotboss.Play();
                Speedbulletboss();                
            }
        }
        
        private void Speedbulletboss()
        {
            bossbullettimeron = true;
            if (btesttime == true) bossbulletTimer.IsEnabled = false;
            bossbulletTimer = new DispatcherTimer();
            bossbulletTimer.Tick += BossbulletTimer_Tick;
            bossbulletTimer.Interval = new TimeSpan(0, 0, 0, 0, timebossspeedbullet);
            bossbulletTimer.IsEnabled = true;
        }
            private void BossbulletTimer_Tick(object sender, EventArgs e)
            {
            Canvas.SetBottom(bbullet, BBullet.Y -= bossspeedbullet);            
            AppleToPlayerOrNo();
            }
        private void AppleToPlayerOrNo()
        {            
                if (BBullet.IntersectsWith(SSRect) == true)
                {
                    if (banticheat == false) bossbulletTimer.IsEnabled = false;
                    else
                    {
                        bossbulletTimer.IsEnabled = false;
                        Ggame.Children.Remove(bbullet);
                    hit.Open(new Uri(@"..\..\sound\hit.wav", UriKind.Relative));
                    hit.Play();
                    chpship -= cbdamage;
                        phpship = Math.Round(phpship - pbdamage, 0);
                        widthhpsship = hpsshippolos.Width;
                        if ((widthhpsship - Convert.ToInt32(bminuswidthhpshippolos) > 0)) hpsshippolos.Width -= Convert.ToInt32(bminuswidthhpshippolos);                        
                        if (chpship <= 0)
                        {
                            hpsship.Content = "0%";
                            hpsshippolos.Width = 0;
                            bossbulletTimer.IsEnabled = false;
                            bossTimer.IsEnabled = false;
                        MeteoritTimer.IsEnabled = false;
                        boom = new Image
                        {
                            Source = new BitmapImage(new Uri("images\\bigbom.png", UriKind.Relative)),
                            Stretch = Stretch.Fill,
                            Width = 50,
                            Height = 50,
                        };
                        Canvas.SetBottom(boom, SSRect.Y);
                        Canvas.SetLeft(boom, SSRect.X);
                        Ggame.Children.Add(boom);
                        sboom.Open(new Uri(@"..\..\sound\boom.wav", UriKind.Relative));
                        sboom.Play();
                        NextWave.Content = "Try Again";
                        EndGame.Visibility = Visibility.Visible;
                        MessageBox.Show("К сожалению, вы проиграли :c\nВ результате сражения вы ничего не получили", "YOU LOSE ^.^",MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                        else hpsship.Content = Convert.ToString(phpship + "%");
                        bcountbullets = 0;
                        banticheat = false;
                        btesttime = true;
                    }
                }
                else if (BBullet.IntersectsWith(Recthpsspolosblk) == true)
                {
                    if (banticheat == false) bossbulletTimer.IsEnabled = false;
                    else
                    {
                        bossbulletTimer.IsEnabled = false;
                        Ggame.Children.Remove(bbullet);
                        bcountbullets = 0;
                        banticheat = false;
                        btesttime = true;
                    }
                }            
        }
        #endregion
        #region SEnemy1Settings
        private void SpeedSEnemy1()
        {
            senemytimeron1 = true;
            if (se1stesttime == true) senemyTimer1.IsEnabled = false;
            senemyTimer1 = new DispatcherTimer();
            senemyTimer1.Tick += SenemyTimer1_Tick;
            senemyTimer1.Interval = new TimeSpan(0, 0, 0, 0, intervalse1);
            senemyTimer1.IsEnabled = true;
        }
        private void SenemyTimer1_Tick(object sender, EventArgs e)
        {

            if (gotorightsenemy1 == true) Canvas.SetLeft(senemy1, Rectsenemy1.X += 1);
            else if (gotorightsenemy1 == false) Canvas.SetLeft(senemy1, Rectsenemy1.X -= 1);
            if (Rectsenemy1.X == 0) gotorightsenemy1 = true;
            else if (Rectsenemy1.X == 310) gotorightsenemy1 = false;
            se1stesttime = true;
            if (se1countbullets == 1) se1countbullets = 1;
            else
            {
                se1testtime = false;
                se1anticheat = true;
                se1countbullets = 1;
                senemybullet1 = new Image
                {
                    Stretch = Stretch.Fill,
                    Width = 15,
                    Height = 15,
                    Source = new BitmapImage(new Uri("images\\bullet.png", UriKind.Relative)),
                };
                Rectsenemybullet1 = new Rect(Rectsenemy1.X + 17, Rectsenemy1.Y - 15, 15, 15);
                Canvas.SetBottom(senemybullet1, Rectsenemybullet1.Y);
                Canvas.SetLeft(senemybullet1, Rectsenemybullet1.X);
                Ggame.Children.Add(senemybullet1);
                shotse1.Open(new Uri(@"..\..\sound\startfire.wav", UriKind.Relative));
                shotse1.Play();
                Speedbulletsenemy1();
            }
        }            

        private void Speedbulletsenemy1()
        {
            senemybullettimeron1 = true;            
            if (se1testtime == true) senemybulletTimer1.IsEnabled = false;
            senemybulletTimer1 = new DispatcherTimer();
            senemybulletTimer1.Tick += SenemybulletTimer1_Tick;
            senemybulletTimer1.Interval = new TimeSpan(0, 0, 0, 0, timese1speedbullet);
            senemybulletTimer1.IsEnabled = true;

        }
        private void SenemybulletTimer1_Tick(object sender, EventArgs e)
        {
            Canvas.SetBottom(senemybullet1, Rectsenemybullet1.Y -= senemyspeedbullet1);
            AppleToPlayerOrNoSmallEnemy1();
        }
        private void AppleToPlayerOrNoSmallEnemy1()
        {
            if (Rectsenemybullet1.IntersectsWith(SSRect) == true)
            {
                if (se1anticheat == false) senemybulletTimer1.IsEnabled = false;
                else
                {
                    senemybulletTimer1.IsEnabled = false;
                    Ggame.Children.Remove(senemybullet1);
                    hit.Open(new Uri(@"..\..\sound\hit.wav", UriKind.Relative));
                    hit.Play();
                    chpship -= cse1damage;
                    phpship = Math.Round(phpship - pse1damage, 0);
                    widthhpsship = hpsshippolos.Width;
                    if ((widthhpsship - Convert.ToInt32(se1minuswidthhpshippolos) > 0)) hpsshippolos.Width -= Convert.ToInt32(se1minuswidthhpshippolos);
                    if (chpship <= 0)
                    {
                        hpsship.Content = "0%";
                        hpsshippolos.Width = 0;
                        senemybulletTimer1.IsEnabled = false;
                        senemyTimer1.IsEnabled = false;
                        senemybulletTimer2.IsEnabled = false;
                        senemyTimer2.IsEnabled = false;
                        MeteoritTimer.IsEnabled = false;
                        boom = new Image
                        {
                            Source = new BitmapImage(new Uri("images\\bigbom.png", UriKind.Relative)),
                            Stretch = Stretch.Fill,
                            Width = 50,
                            Height = 50,
                        };
                        Canvas.SetBottom(boom, SSRect.Y);
                        Canvas.SetLeft(boom, SSRect.X);
                        Ggame.Children.Add(boom);
                        sboom.Open(new Uri(@"..\..\sound\boom.wav", UriKind.Relative));
                        sboom.Play();
                        NextWave.Content = "Try Again";
                        EndGame.Visibility = Visibility.Visible;
                        MessageBox.Show("К сожалению, вы проиграли :c\nВ результате сражения вы ничего не получили", "YOU LOSE ^.^", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    else hpsship.Content = Convert.ToString(phpship + "%");
                    se1countbullets = 0;
                    se1anticheat = false;
                    se1testtime = true;
                }
            }
            else if (Rectsenemybullet1.IntersectsWith(Recthpsspolosblk) == true)
            {
                if (se1anticheat == false) senemybulletTimer1.IsEnabled = false;
                else
                {
                    senemybulletTimer1.IsEnabled = false;
                    Ggame.Children.Remove(senemybullet1);
                    se1countbullets = 0;
                    se1anticheat = false;
                    se1testtime = true;
                }
            }
        }
        #endregion
        #region SEnemy2Settings
        private void SpeedSEnemy2()
        {
            senemytimeron2 = true;
            if (se2stesttime == true) senemyTimer2.IsEnabled = false;
            senemyTimer2 = new DispatcherTimer();
            senemyTimer2.Tick += SenemyTimer2_Tick;
            senemyTimer2.Interval = new TimeSpan(0, 0, 0, 0, intervalse2);
            senemyTimer2.IsEnabled = true;
        }
        private void SenemyTimer2_Tick(object sender, EventArgs e)
        {
            if (gotoleftsenemy2 == true) Canvas.SetLeft(senemy2, Rectsenemy2.X -= 1);
            else if (gotoleftsenemy2 == false) Canvas.SetLeft(senemy2, Rectsenemy2.X += 1);
            if (Rectsenemy2.X == 370) gotoleftsenemy2 = false;
            else if (Rectsenemy2.X == 740) gotoleftsenemy2 = true;
            se2stesttime = true;
            if (se2countbullets == 1) se2countbullets = 1;
            else
            {
                se2testtime = false;
                se2anticheat = true;
                se2countbullets = 1;
                senemybullet2 = new Image
                {
                    Stretch = Stretch.Fill,
                    Width = 15,
                    Height = 15,
                    Source = new BitmapImage(new Uri("images\\bullet.png", UriKind.Relative)),
                };
                Rectsenemybullet2 = new Rect(Rectsenemy2.X + 17, Rectsenemy2.Y - 15, 15, 15);
                Canvas.SetBottom(senemybullet2, Rectsenemybullet2.Y);
                Canvas.SetLeft(senemybullet2, Rectsenemybullet2.X);
                shotse2.Open(new Uri(@"..\..\sound\startfire.wav", UriKind.Relative));
                shotse2.Play();
                Ggame.Children.Add(senemybullet2);
                Speedbulletsenemy2();
            }
        }

        private void Speedbulletsenemy2()
        {
            senemybullettimeron2 = true;
            if (se2testtime == true) senemybulletTimer2.IsEnabled = false;
            senemybulletTimer2 = new DispatcherTimer();
            senemybulletTimer2.Tick += SenemybulletTimer2_Tick;
            senemybulletTimer2.Interval = new TimeSpan(0, 0, 0, 0, timese2speedbullet);
            senemybulletTimer2.IsEnabled = true;

        }
        private void SenemybulletTimer2_Tick(object sender, EventArgs e)
        {
            Canvas.SetBottom(senemybullet2, Rectsenemybullet2.Y -= senemyspeedbullet2);
            AppleToPlayerOrNoSmallEnemy2();
        }
        private void AppleToPlayerOrNoSmallEnemy2()
        {
            if (Rectsenemybullet2.IntersectsWith(SSRect) == true)
            {
                if (se2anticheat == false) senemybulletTimer2.IsEnabled = false;
                else
                {
                    senemybulletTimer2.IsEnabled = false;
                    Ggame.Children.Remove(senemybullet2);
                    hit.Open(new Uri(@"..\..\sound\hit.wav", UriKind.Relative));
                    hit.Play();
                    chpship -= cse2damage;
                    phpship = Math.Round(phpship - pse2damage, 0);
                    widthhpsship = hpsshippolos.Width;
                    if ((widthhpsship - Convert.ToInt32(se2minuswidthhpshippolos) > 0)) hpsshippolos.Width -= Convert.ToInt32(se2minuswidthhpshippolos);
                    if (chpship <= 0)
                    {
                        hpsship.Content = "0%";
                        hpsshippolos.Width = 0;
                        senemybulletTimer1.IsEnabled = false;
                        senemyTimer1.IsEnabled = false;
                        senemybulletTimer2.IsEnabled = false;
                        senemyTimer2.IsEnabled = false;
                        MeteoritTimer.IsEnabled = false;
                        boom = new Image
                        {
                            Source = new BitmapImage(new Uri("images\\bigbom.png", UriKind.Relative)),
                            Stretch = Stretch.Fill,
                            Width = 50,
                            Height = 50,
                        };
                        Canvas.SetBottom(boom, SSRect.Y);
                        Canvas.SetLeft(boom, SSRect.X);
                        Ggame.Children.Add(boom);
                        sboom.Open(new Uri(@"..\..\sound\boom.wav", UriKind.Relative));
                        sboom.Play();
                        NextWave.Content = "Try Again";
                        EndGame.Visibility = Visibility.Visible;
                        MessageBox.Show("К сожалению, вы проиграли :c\nВ результате сражения вы ничего не получили", "YOU LOSE ^.^", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    else hpsship.Content = Convert.ToString(phpship + "%");
                    se2countbullets = 0;
                    se2anticheat = false;
                    se2testtime = true;
                }
            }
            else if (Rectsenemybullet2.IntersectsWith(Recthpsspolosblk) == true)
            {
                if (se2anticheat == false) senemybulletTimer2.IsEnabled = false;
                else
                {
                    senemybulletTimer2.IsEnabled = false;
                    Ggame.Children.Remove(senemybullet2);
                    se2countbullets = 0;
                    se2anticheat = false;
                    se2testtime = true;
                }
            }
        }
        #endregion
        private void Pause_Click(object sender, RoutedEventArgs e)
        {
            if (EndGame.Visibility == Visibility.Visible) EndGame.Visibility = Visibility.Visible;
            else
            {
                MenuPause.Visibility = Visibility.Visible;
                if (MenuPause.Visibility == Visibility.Visible)
                {
                    if (senemytimeron1 == true) senemyTimer1.IsEnabled = false;
                    if (senemybullettimeron1 == true) senemybulletTimer1.IsEnabled = false;
                    if (senemytimeron2 == true) senemyTimer2.IsEnabled = false;
                    if (senemybullettimeron2 == true) senemybulletTimer2.IsEnabled = false;
                    if (bossbullettimeron == true) bossbulletTimer.IsEnabled = false;
                    if (bosstimeron == true) bossTimer.IsEnabled = false;
                    if (ssbullettimeron == true) bulletTimer.IsEnabled = false;
                    if (meteorittimeron == true) MeteoritTimer.IsEnabled = false;
                }
            }
            }
        #region SpaceShipSettings
        private void MainWin_KeyDown(object sender, KeyEventArgs e)
        {
            if (Pause.IsEnabled == true)
            {
                if (MenuPause.Visibility == Visibility.Visible || EndGame.Visibility == Visibility.Visible) MessageBox.Show("Хватит искать здесь баги :D\nИх здесь нет... Ну почти :3","Великодушное обращение к игроку ^.^",MessageBoxButton.OK, MessageBoxImage.Information);
                else
                {
                    if (e.Key == Key.Left)
                    {
                        SSRect.X -= 10;
                        if (SSRect.X <= 0) SSRect.X = 744;
                        else Canvas.SetLeft(spaceship, SSRect.X);
                    }

                    if (e.Key == Key.Right)
                    {
                        SSRect.X += 10;
                        if (SSRect.X >= 744) SSRect.X = 0;
                        else Canvas.SetLeft(spaceship, SSRect.X);
                    }

                    if (e.Key == Key.Up)
                    {
                        if (sscountbullets == 1) sscountbullets = 1;
                        else
                        {
                            shotse1.Open(new Uri(@"..\..\sound\startfire.wav", UriKind.Relative));
                            shotse1.Play();
                            sstesttime = false;
                            ssanticheat = true;
                            sscountbullets = 1;
                            ssbullet = new Image
                            {
                                Stretch = Stretch.Fill,
                                Width = 5,
                                Height = 5,
                                Source = new BitmapImage(new Uri("images\\bullet.png", UriKind.Relative)),
                            };
                            SSBullet = new Rect(SSRect.X + 23, SSRect.Y + 50, 5, 5);
                            Canvas.SetBottom(ssbullet, SSBullet.Y);
                            Canvas.SetLeft(ssbullet, SSBullet.X);
                            Ggame.Children.Add(ssbullet);
                            Speedbullet();
                        }

                    }
                }
            }
        }
            private void Speedbullet()
            {
                ssbullettimeron = true;
                if (sstesttime == true) bulletTimer.IsEnabled = false;
                bulletTimer = new DispatcherTimer();
                bulletTimer.Tick += Speedbullet_Tick;
                bulletTimer.Interval = new TimeSpan(0, 0, 0, 0, timespeedbullet);
                bulletTimer.IsEnabled = true;
            }
            private void Speedbullet_Tick(object sender, EventArgs e)
            {
                Canvas.SetBottom(ssbullet, SSBullet.Y += speedbullet);
                AppleToBossOrNo();
            }
            private void AppleToBossOrNo()
            {
                #region WaveSenemy1
                if ((wave % 5) != 0)
                    if (SSBullet.IntersectsWith(Rectsenemy1) == true)
                    {
                        if (ssanticheat == false) bulletTimer.IsEnabled = false;
                        else
                        {
                            bulletTimer.IsEnabled = false;
                            Ggame.Children.Remove(ssbullet);
                        hit.Open(new Uri(@"..\..\sound\hit.wav", UriKind.Relative));
                        hit.Play();
                        chpsenemy1 -= csdamage;
                            phpsenemy1 = Math.Round(phpsenemy1 - psse1damage, 0);
                            widthhpsenemy1 = hpsenemy1polos.Width;
                            if ((widthhpsenemy1 - Convert.ToInt32(minuswidthhpsenemy1polos) > 0)) hpsenemy1polos.Width -= Convert.ToInt32(minuswidthhpsenemy1polos);
                            if (chpsenemy1 <= 0)
                            {
                                hpsenemy1.Content = "0%";
                                hpsenemy1polos.Width = 0;
                                senemybulletTimer1.IsEnabled = false;
                                senemyTimer1.IsEnabled = false;
                                boom = new Image
                                {
                                    Source = new BitmapImage(new Uri("images\\bigbom.png", UriKind.Relative)),
                                    Stretch = Stretch.Fill,
                                    Width = 50,
                                    Height = 50,
                                };
                                Canvas.SetBottom(boom, Rectsenemy1.Y - 5);
                                Canvas.SetLeft(boom, Rectsenemy1.X);
                                Ggame.Children.Add(boom);
                            sboom.Open(new Uri(@"..\..\sound\boom.wav", UriKind.Relative));
                            sboom.Play();
                            Ggame.Children.Remove(senemybullet1);
                                if ((Convert.ToString(hpsenemy1.Content) == "0%") && (Convert.ToString(hpsenemy2.Content) == "0%"))
                                {
                                MeteoritTimer.IsEnabled = false;
                                wave += 1;
                                WaveCount.Content = "Wave:" + wave;
                                WaveCountShadow.Content = "Wave:" + wave;
                                schpsenemy1 += 5;
                                cse1damage++;
                                schpsenemy2 += 5;
                                cse2damage++;
                                giveruns = rndcountloot.Next(Convert.ToInt32(minRandom), Convert.ToInt32(maxRandom));
                                runs += giveruns;
                                minRandom += 100;
                                maxRandom += 200;
                                giveenergyblock = rndcountloot.Next(0, 3);
                                energyblock += giveenergyblock;
                                givedebris = rndcountloot.Next(0, 3);
                                debris += givedebris;
                                givedebrisofmeteorit = rndcountloot.Next(0, 1);
                                debrisofmeteorit += givedebrisofmeteorit;
                                giveslimeofuo = rndcountloot.Next(0, 2);
                                slimeofuo += giveslimeofuo;
                                chance = rndloot.Next(1, 20);
                                if (chance == 5)
                                {
                                    givepartofmonolith = 1;
                                    partofmonolith += givepartofmonolith;
                                }
                                NextWave.Content = "Next Wave";
                                EndGame.Visibility = Visibility.Visible;
                                MessageBox.Show($"Получено денег: {giveruns} Ru\nЛут:\n-Получено энергоблоков: {giveenergyblock}x\n-Получено обломков НЛО: {givedebris}x\n-Получено осколков метеорита: {givedebrisofmeteorit}x\n-Получено кусочков инопланетной слизи: {giveslimeofuo}x\n-Получено частей монолита: {givepartofmonolith}x", "YOU WIN ^.^", MessageBoxButton.OK, MessageBoxImage.Information);
                            }
                        }
                            else hpsenemy1.Content = Convert.ToString(phpsenemy1 + "%");
                            sscountbullets = 0;
                            ssanticheat = false;
                            sstesttime = true;
                        }
                    }
                    else if (SSBullet.IntersectsWith(Recthpbosspolosblk) == true)
                    {
                        if (ssanticheat == false) bulletTimer.IsEnabled = false;
                        else
                        {
                            bulletTimer.IsEnabled = false;
                            Ggame.Children.Remove(ssbullet);
                            sscountbullets = 0;
                            ssanticheat = false;
                            sstesttime = true;
                        }
                    }
                #endregion

                #region WaveSenemy2
                if ((wave % 5) != 0)
                    if (SSBullet.IntersectsWith(Rectsenemy2) == true)
                    {
                        if (ssanticheat == false) bulletTimer.IsEnabled = false;
                        else
                        {
                            bulletTimer.IsEnabled = false;
                            Ggame.Children.Remove(ssbullet);
                        hit.Open(new Uri(@"..\..\sound\hit.wav", UriKind.Relative));
                        hit.Play();
                        chpsenemy2 -= csdamage;
                            phpsenemy2 = Math.Round(phpsenemy2 - psse2damage, 0);
                            widthhpsenemy2 = hpsenemy2polos.Width;
                            if ((widthhpsenemy2 - Convert.ToInt32(minuswidthhpsenemy2polos) > 0)) hpsenemy2polos.Width -= Convert.ToInt32(minuswidthhpsenemy2polos);
                            if (chpsenemy2 <= 0)
                            {
                                hpsenemy2.Content = "0%";
                                hpsenemy2polos.Width = 0;
                                senemybulletTimer2.IsEnabled = false;
                                senemyTimer2.IsEnabled = false;
                                boom = new Image
                                {
                                    Source = new BitmapImage(new Uri("images\\bigbom.png", UriKind.Relative)),
                                    Stretch = Stretch.Fill,
                                    Width = 50,
                                    Height = 50,
                                };
                                Canvas.SetBottom(boom, Rectsenemy2.Y - 5);
                                Canvas.SetLeft(boom, Rectsenemy2.X);
                                Ggame.Children.Add(boom);
                            sboom.Open(new Uri(@"..\..\sound\boom.wav", UriKind.Relative));
                            sboom.Play();
                            Ggame.Children.Remove(senemybullet2);
                                if ((Convert.ToString(hpsenemy1.Content) == "0%") && (Convert.ToString(hpsenemy2.Content) == "0%"))
                                {
                                MeteoritTimer.IsEnabled = false;
                                wave += 1;
                                WaveCount.Content = "Wave:" + wave;
                                WaveCountShadow.Content = "Wave:" + wave;
                                schpsenemy1 += 5;
                                cse1damage++;
                                schpsenemy2 += 5;
                                cse2damage++;
                                giveruns = rndcountloot.Next(Convert.ToInt32(minRandom), Convert.ToInt32(maxRandom));
                                runs += giveruns;
                                minRandom += 100;
                                maxRandom += 200;
                                giveenergyblock = rndcountloot.Next(0, 3);
                                energyblock += giveenergyblock;
                                givedebris = rndcountloot.Next(0, 3);
                                debris += givedebris;
                                givedebrisofmeteorit = rndcountloot.Next(0, 1);
                                debrisofmeteorit += givedebrisofmeteorit;
                                giveslimeofuo = rndcountloot.Next(0, 2);
                                slimeofuo += giveslimeofuo;
                                chance = rndloot.Next(1, 20);
                                if (chance == 5)
                                {
                                    givepartofmonolith = 1;
                                    partofmonolith += givepartofmonolith;
                                }
                                NextWave.Content = "Next Wave";
                                EndGame.Visibility = Visibility.Visible;
                                MessageBox.Show($"Получено денег: {giveruns} Ru\nЛут:\n-Получено энергоблоков: {giveenergyblock}x\n-Получено обломков НЛО: {givedebris}x\n-Получено осколков метеорита: {givedebrisofmeteorit}x\n-Получено кусочков инопланетной слизи: {giveslimeofuo}x\n-Получено частей монолита: {givepartofmonolith}x", "YOU WIN ^.^", MessageBoxButton.OK, MessageBoxImage.Information);                            
                                }
                            }
                            else hpsenemy2.Content = Convert.ToString(phpsenemy2 + "%");
                            sscountbullets = 0;
                            ssanticheat = false;
                            sstesttime = true;
                        }
                    }
                    else if (SSBullet.IntersectsWith(Recthpbosspolosblk) == true)
                    {
                        if (ssanticheat == false) bulletTimer.IsEnabled = false;
                        else
                        {
                            bulletTimer.IsEnabled = false;
                            Ggame.Children.Remove(ssbullet);
                            sscountbullets = 0;
                            ssanticheat = false;
                            sstesttime = true;
                        }
                    }
                #endregion

                #region BossWave
                if ((wave % 5) == 0)
                    if (SSBullet.IntersectsWith(SSBoss) == true)
                    {
                        if (ssanticheat == false) bulletTimer.IsEnabled = false;
                        else
                        {
                            bulletTimer.IsEnabled = false;
                            Ggame.Children.Remove(ssbullet);
                        hit.Open(new Uri(@"..\..\sound\hit.wav", UriKind.Relative));
                        hit.Play();
                        chpboss -= csdamage;
                            phpboss = Math.Round(phpboss - psdamage, 0);
                            widthhpboss = hpbosspolos.Width;
                            if ((widthhpboss - Convert.ToInt32(minuswidthhpbosspolos) > 0)) hpbosspolos.Width -= Convert.ToInt32(minuswidthhpbosspolos);
                            if (chpboss <= 0)
                            {
                            MeteoritTimer.IsEnabled = false;
                            hpboss.Content = "0%";
                                hpbosspolos.Width = 0;
                                bossTimer.IsEnabled = false;
                                bossbulletTimer.IsEnabled = false;
                                boom = new Image
                                {
                                    Source = new BitmapImage(new Uri("images\\bigbom.png", UriKind.Relative)),
                                    Stretch = Stretch.Fill,
                                    Width = 150,
                                    Height = 150,
                                };
                                Canvas.SetBottom(boom, SSBoss.Y - 70);
                                Canvas.SetLeft(boom, SSBoss.X + 40);
                                Ggame.Children.Add(boom);
                            sboom.Open(new Uri(@"..\..\sound\boom.wav", UriKind.Relative));
                            sboom.Play();
                            Ggame.Children.Remove(bbullet);
                            wave += 1;                           
                            WaveCount.Content = "Wave:" + wave;
                            WaveCountShadow.Content = "Wave:" + wave;
                            schpboss += 10;
                            cbdamage += 5;
                            if (((wave % 100) == 0) && (wave < 600))
                            {
                                senemyspeedbullet2++;
                                senemyspeedbullet1++;
                                bossspeedbullet++;
                            }
                            if (((wave % 100) == 0) && (wave < 1000))
                            {
                                timese1speedbullet--;
                                timese2speedbullet--;
                                timebossspeedbullet--;
                            }
                            if (((wave % 100) == 0) && (wave < 1300))
                            {
                                intervalse2 -= 2;
                                intervalse1 -= 2;
                                intervalboss -= 2;
                            }
                            giveruns = rndcountloot.Next(Convert.ToInt32(minRandom+500), Convert.ToInt32(maxRandom+1000));
                            runs += giveruns;
                            minRandom += 200;
                            maxRandom += 400;
                            giveenergyblock = rndcountloot.Next(0, 10);
                            energyblock += giveenergyblock;
                            givedebris = rndcountloot.Next(0, 10);
                            debris += givedebris;
                            givedebrisofmeteorit = rndcountloot.Next(0, 5);
                            debrisofmeteorit += givedebrisofmeteorit;
                            giveslimeofuo = rndcountloot.Next(0, 7);
                            slimeofuo += giveslimeofuo;
                            chance = rndloot.Next(1, 10);
                            if (chance == 5)
                            {
                                givepartofmonolith = 1;
                                partofmonolith += givepartofmonolith;
                            }
                            NextWave.Content = "Next Wave";
                            EndGame.Visibility = Visibility.Visible;
                            MessageBox.Show($"Получено денег: {giveruns} Ru\nЛут:\n-Получено энергоблоков: {giveenergyblock}x\n-Получено обломков НЛО: {givedebris}x\n-Получено осколков метеорита: {givedebrisofmeteorit}x\n-Получено кусочков инопланетной слизи: {giveslimeofuo}x\n-Получено частей монолита: {givepartofmonolith}x", "YOU WIN ^.^", MessageBoxButton.OK, MessageBoxImage.Information);
                            }
                            else hpboss.Content = Convert.ToString(phpboss + "%");
                            sscountbullets = 0;
                            ssanticheat = false;
                            sstesttime = true;
                        }
                    }
                    else if (SSBullet.IntersectsWith(Recthpbosspolosblk) == true)
                    {
                        if (ssanticheat == false) bulletTimer.IsEnabled = false;
                        else
                        {
                            bulletTimer.IsEnabled = false;
                            Ggame.Children.Remove(ssbullet);
                            sscountbullets = 0;
                            ssanticheat = false;
                            sstesttime = true;
                        }
                    }

            }
            #endregion
        
        #endregion

        #region MenuPause
        private void Exittomainmenu_Click(object sender, RoutedEventArgs e)
        {
            butclk.Open(new Uri(@"..\..\sound\buttonclick.wav", UriKind.Relative));
            butclk.Play();
            Ggame.Visibility = Visibility.Hidden;
            MainMenu.Visibility = Visibility.Visible;
            MenuPause.Visibility = Visibility.Hidden;
            if (MenuPause.Visibility == Visibility.Visible) MenuPause.Visibility = Visibility.Hidden;
            if (EndGame.Visibility == Visibility.Visible) EndGame.Visibility = Visibility.Hidden;
            Pause.IsEnabled = false;
            mainmenumedia.Stop();
            NTrack = rndmusic.Next(1, 6);
            Ggame.Children.Clear();            
        }

        private void Continue_Click(object sender, RoutedEventArgs e)
        {
            butclk.Open(new Uri(@"..\..\sound\buttonclick.wav", UriKind.Relative));
            butclk.Play();
            if (senemytimeron1 == true && (Convert.ToString(hpsenemy1.Content) !="0%")) senemyTimer1.IsEnabled = true;
            if (senemybullettimeron1 == true && (Convert.ToString(hpsenemy1.Content) != "0%")) senemybulletTimer1.IsEnabled = true;
            if (senemytimeron2 == true && (Convert.ToString(hpsenemy2.Content) != "0%")) senemyTimer2.IsEnabled = true;
            if (senemybullettimeron2 == true && (Convert.ToString(hpsenemy2.Content) != "0%")) senemybulletTimer2.IsEnabled = true;
            if (bossbullettimeron == true) bossbulletTimer.IsEnabled = true;
            if (bosstimeron == true) bossTimer.IsEnabled = true;
            if (ssbullettimeron == true)  bulletTimer.IsEnabled = true;
            if (meteorittimeron == true) MeteoritTimer.IsEnabled = true;
            if (MenuPause.Visibility == Visibility.Visible) MenuPause.Visibility = Visibility.Hidden;
            if (EndGame.Visibility == Visibility.Visible) EndGame.Visibility = Visibility.Hidden;
        }
        #endregion
        #region Save And Load
        private void LoadGame_Click(object sender, RoutedEventArgs e)
        {
            butclk.Open(new Uri(@"..\..\sound\buttonclick.wav", UriKind.Relative));
            butclk.Play();
            OpenFileDialog open = new OpenFileDialog
            {
                Title = "Загрузка игры",
                Filter = "Сохранение игры(*.rugsave*) |*.rugsave",
                DefaultExt = ".rugsave",
            };
            if (open.ShowDialog() == true)
            {
                StreamReader gsread = new StreamReader(open.FileName);
                nickname = Convert.ToString(gsread.ReadLine());
                newgame = Convert.ToBoolean(gsread.ReadLine());
                storeagain = Convert.ToBoolean(gsread.ReadLine());
                wave = Convert.ToInt32(gsread.ReadLine());
                runs = Convert.ToInt32(gsread.ReadLine()); 
                energyblock = Convert.ToInt32(gsread.ReadLine());
                debris = Convert.ToInt32(gsread.ReadLine());
                debrisofmeteorit = Convert.ToInt32(gsread.ReadLine());
                slimeofuo = Convert.ToInt32(gsread.ReadLine());
                partofmonolith = Convert.ToInt32(gsread.ReadLine());
                minRandom = Convert.ToInt32(gsread.ReadLine());
                maxRandom = Convert.ToInt32(gsread.ReadLine());
                senemyspeedbullet1 = Convert.ToInt32(gsread.ReadLine());
                senemyspeedbullet2 = Convert.ToInt32(gsread.ReadLine());
                speedbullet = Convert.ToInt32(gsread.ReadLine());
                bossspeedbullet = Convert.ToInt32(gsread.ReadLine());
                timebossspeedbullet = Convert.ToInt32(gsread.ReadLine());
                timespeedbullet = Convert.ToInt32(gsread.ReadLine());
                timese1speedbullet = Convert.ToInt32(gsread.ReadLine());
                timese2speedbullet = Convert.ToInt32(gsread.ReadLine());
                intervalboss = Convert.ToInt32(gsread.ReadLine());
                intervalse1 = Convert.ToInt32(gsread.ReadLine());
                intervalse2 = Convert.ToInt32(gsread.ReadLine());
                schpboss = Convert.ToInt32(gsread.ReadLine());
                schpsenemy1 = Convert.ToInt32(gsread.ReadLine());
                schpsenemy2 = Convert.ToInt32(gsread.ReadLine());
                schpship = Convert.ToInt32(gsread.ReadLine());
                csdamage = Convert.ToInt32(gsread.ReadLine());
                cbdamage = Convert.ToInt32(gsread.ReadLine());
                cse1damage = Convert.ToInt32(gsread.ReadLine());
                cse2damage = Convert.ToInt32(gsread.ReadLine());
                lvlweapon = Convert.ToInt32(gsread.ReadLine());
                costweapon = Convert.ToInt32(gsread.ReadLine());
                lvlhpship = Convert.ToInt32(gsread.ReadLine());
                costhpship = Convert.ToInt32(gsread.ReadLine());
                lvlspeedbullet = Convert.ToInt32(gsread.ReadLine());
                costspeedbullet = Convert.ToInt32(gsread.ReadLine());
                lvlpowerb = Convert.ToInt32(gsread.ReadLine());
                costpowerb = Convert.ToInt32(gsread.ReadLine());
                WaveCount.Content = "Wave:" + wave;
                WaveCountShadow.Content = "Wave:" + wave;
                gsread.Close();
            }
        }

        private void SaveGame_Click(object sender, RoutedEventArgs e)
        {
            butclk.Open(new Uri(@"..\..\sound\buttonclick.wav", UriKind.Relative));
            butclk.Play();
            SaveFileDialog save = new SaveFileDialog
            {
                Title = "Сохранение игры",
                Filter = "Сохранение игры(*.rugsave*) |*.rugsave",
                DefaultExt = ".rugsave",
            };
            if (save.ShowDialog() == true)
            {
                StreamWriter gssave = new StreamWriter(save.FileName);
                gssave.WriteLine(nickname);
                gssave.WriteLine(newgame);
                gssave.WriteLine(storeagain);
                gssave.WriteLine(wave);
                gssave.WriteLine(runs);
                gssave.WriteLine(energyblock);
                gssave.WriteLine(debris);
                gssave.WriteLine(debrisofmeteorit);
                gssave.WriteLine(slimeofuo);
                gssave.WriteLine(partofmonolith);
                gssave.WriteLine(minRandom);
                gssave.WriteLine(maxRandom);
                gssave.WriteLine(senemyspeedbullet1);
                gssave.WriteLine(senemyspeedbullet2);
                gssave.WriteLine(speedbullet);
                gssave.WriteLine(bossspeedbullet);
                gssave.WriteLine(timebossspeedbullet);
                gssave.WriteLine(timespeedbullet);
                gssave.WriteLine(timese1speedbullet);
                gssave.WriteLine(timese2speedbullet);
                gssave.WriteLine(intervalboss);
                gssave.WriteLine(intervalse1);
                gssave.WriteLine(intervalse2);
                gssave.WriteLine(schpboss);
                gssave.WriteLine(schpsenemy1);
                gssave.WriteLine(schpsenemy2);
                gssave.WriteLine(schpship);
                gssave.WriteLine(csdamage);
                gssave.WriteLine(cbdamage);
                gssave.WriteLine(cse1damage);
                gssave.WriteLine(cse2damage);
                gssave.WriteLine(lvlweapon);
                gssave.WriteLine(costweapon);
                gssave.WriteLine(lvlhpship);
                gssave.WriteLine(costhpship);
                gssave.WriteLine(lvlspeedbullet);
                gssave.WriteLine(costspeedbullet);
                gssave.WriteLine(lvlpowerb);
                gssave.WriteLine(costpowerb);
                gssave.Close();
            }
        }
        #endregion
        #region Store
        private void Store_Click(object sender, RoutedEventArgs e)
        {
            if (wave == 1) MessageBox.Show("Магазин недоступен. Необходимо пройти первую волну для калибровки вашего скилла.", "Внимание", MessageBoxButton.OK, MessageBoxImage.Warning);
            else
            {
                butclk.Open(new Uri(@"..\..\sound\buttonclick.wav", UriKind.Relative));
                butclk.Play();
                mainmenumedia.Stop();
                NTrack = rndmusic.Next(7, 9);                
                MainMenu.Visibility = Visibility.Hidden;
                storeandupgrader.Visibility = Visibility.Visible;
                if (storeagain == false)
                {
                    MessageBox.Show("Это магазин. Здесь вы можете приобрести нужные товары у продавца(или продать свои). Они обновляются с каждым заходом в магазин. Никто не знает, откуда он моментально берет свои товары :D\n-Для того,чтобы купить интересующие вас товары - кликните на товар и нажмите \"Купить\"\n-Для того, чтобы продать ненужные предметы - кликните на них и нажмите \"Продать\"", "Космический магазин", MessageBoxButton.OK, MessageBoxImage.Question);
                    storeagain = true;
                }
                for (int i = 0; i < energyblock; i++) Ship.Items.Add("Энергетический блок(+500 Ru)");
                for (int i = 0; i < debris; i++) Ship.Items.Add("Обломки НЛО(+300 Ru)");
                for (int i = 0; i < debrisofmeteorit; i++) Ship.Items.Add("Осколки метеорита(+2000 Ru)");
                for (int i = 0; i < slimeofuo; i++) Ship.Items.Add("Кусочек инопланетной слизи(+1000 Ru)");
                for (int i = 0; i < partofmonolith; i++) Ship.Items.Add("Часть монолита(+15000 Ru)");
                runsinstore.Text = runs.ToString() + " Ru";
                Seller.Items.Add($"Оружие {lvlweapon}ур.({costweapon} Ru)({csdamage}(+5) D)");
                Seller.Items.Add($"Укрепление корабля {lvlhpship}ур.({costhpship} Ru)({schpship}(+10) HP)");
                if (timespeedbullet > 1) Seller.Items.Add($"Скорость пули {lvlspeedbullet}ур.({costspeedbullet} Ru)({timespeedbullet}(-1) ms)");
                if (speedbullet < 5)  Seller.Items.Add($"Мощность выстрела {lvlpowerb}ур.({costpowerb} Ru)({speedbullet}(+1) SpS)");
            }
        }

        private void Backtommenu_Click(object sender, RoutedEventArgs e)
        {
            butclk.Open(new Uri(@"..\..\sound\buttonclick.wav", UriKind.Relative));
            butclk.Play();
            MainMenu.Visibility = Visibility.Visible;
            storeandupgrader.Visibility = Visibility.Hidden;
            Seller.Items.Clear();
            Ship.Items.Clear();
            runsinstore.Clear();
            mainmenumedia.Stop();
            NTrack = rndmusic.Next(1, 6);
        }

        private void Sell_Click(object sender, RoutedEventArgs e)
        {
            if (Ship.SelectedItem != null)
            {
                store.Open(new Uri(@"..\..\sound\sell.mp3", UriKind.Relative));
                store.Play();
                if (Convert.ToString(Ship.SelectedItem) == "Энергетический блок(+500 Ru)")
                {
                    storeobject = 500;
                    energyblock -= 1;
                }
                if (Convert.ToString(Ship.SelectedItem) == "Обломки НЛО(+300 Ru)")
                {
                    storeobject = 300;
                    debris -= 1;
                }
                if (Convert.ToString(Ship.SelectedItem) == "Осколки метеорита(+2000 Ru)")
                {
                    storeobject = 2000;
                    debrisofmeteorit -= 1;
                }
                if (Convert.ToString(Ship.SelectedItem) == "Кусочек инопланетной слизи(+1000 Ru)")
                {
                    storeobject = 1000;
                    slimeofuo -= 1;
                }
                if (Convert.ToString(Ship.SelectedItem) == "Часть монолита(+15000 Ru)")
                {
                    storeobject = 15000;
                    partofmonolith -= 1;
                }
                Ship.Items.RemoveAt(Ship.SelectedIndex);
                runsinstore.Text = runsinstore.Text.Replace("Ru", "");
                runsinstore.Text = Convert.ToString(Convert.ToInt32(runsinstore.Text) + storeobject) + " Ru";
                runs += storeobject;
            }
            else
            {
                store.Open(new Uri(@"..\..\sound\cancel.mp3", UriKind.Relative));
                store.Play();
            }
        }

        private void Buy_Click(object sender, RoutedEventArgs e)
        {
            if (Seller.SelectedItem != null)
            {
                store.Open(new Uri(@"..\..\sound\buy.mp3", UriKind.Relative));
                store.Play();
                if (Convert.ToString(Seller.SelectedItem) == ($"Оружие {lvlweapon}ур.({costweapon} Ru)({csdamage}(+5) D)"))
                {
                    storeobject = costweapon;
                    lvlweapon++;
                    csdamage += 5;
                    costweapon -= 500;
                }
                if (Convert.ToString(Seller.SelectedItem) == ($"Укрепление корабля {lvlhpship}ур.({costhpship} Ru)({schpship}(+10) HP)"))
                {
                    storeobject = costhpship;                    
                    lvlhpship++;
                    schpship += 10;
                    costhpship -= 300;
                }
                if (Convert.ToString(Seller.SelectedItem) == ($"Скорость пули {lvlspeedbullet}ур.({costspeedbullet} Ru)({timespeedbullet}(-1) ms)"))
                {                    
                    storeobject = costspeedbullet;
                    lvlspeedbullet++;
                    timespeedbullet--;
                    costspeedbullet -= 2000;                    
                }
                if (Convert.ToString(Seller.SelectedItem) == ($"Мощность выстрела {lvlpowerb}ур.({costpowerb} Ru)({speedbullet}(+1) SpS)"))
                {
                    storeobject = costpowerb;
                    lvlpowerb++;
                    speedbullet++;
                    costpowerb -= 10000;
                }
                Seller.Items.RemoveAt(Seller.SelectedIndex);
                runsinstore.Text = runsinstore.Text.Replace("Ru", "");
                runsinstore.Text = Convert.ToString(Convert.ToInt32(runsinstore.Text) + storeobject) + " Ru";
                runs += storeobject;
            }
            else
            {
                store.Open(new Uri(@"..\..\sound\cancel.mp3", UriKind.Relative));
                store.Play();
            }
        }
        #endregion

        private void Continue_MouseEnter(object sender, MouseEventArgs e)
        {
            blip.Open(new Uri(@"..\..\sound\blipbut.wav", UriKind.Relative));
            blip.Play();
        }

        private void Stats_Click(object sender, RoutedEventArgs e)
        {
            butclk.Open(new Uri(@"..\..\sound\buttonclick.wav", UriKind.Relative));
            butclk.Play();
            MessageBox.Show($"Имя: {nickname}\nУкрепление корабля({lvlhpship} ур.): {schpship}\nОружие({lvlweapon} ур.): {csdamage}\nСкорость пули({lvlspeedbullet} ур.): {timespeedbullet}\nМощность выстрела({lvlpowerb} ур.): {speedbullet})\nВолна: {wave}\nБоссов побеждено: {wave/5}","Stats");
        }

        private void Abrog_Click(object sender, RoutedEventArgs e)
        {
            mainmenumedia.Stop();
            NTrack = 19;
            AboutProgrammer win1 = new AboutProgrammer();
            if (win1.ShowDialog() == true) win1.Activate();
            else
            {
                mainmenumedia.Stop();
                NTrack = 1;
            }
        }

    }
}
