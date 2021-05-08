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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace GALADARBS4
{
    /// <summary>
    /// Interaction logic for Spele1.xaml
    /// </summary>
    public partial class Spele1 : Window
    {
        public Spele1()
        {
            InitializeComponent();

        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }

        public static long credits = 100;
        public static long total = 0;
        public static int bet = 5;

        int viens, divi, tris, cetri, pieci, sesi, septini, astoni, devini, desmit, vpadsmit, dpadsmit;
        #region Bet5-40

        private void forty_Click(object sender, RoutedEventArgs e)
        {
            bet = 40;
            two.Content = "Bet: 40";
            gr1.Visibility = Visibility.Hidden;
            gr2.Visibility = Visibility.Hidden;
            gr3.Visibility = Visibility.Hidden;
            gr4.Visibility = Visibility.Visible;
        }

        private void twenty_Click(object sender, RoutedEventArgs e)
        {
            bet = 20;
            two.Content = "Bet: 20";
            gr1.Visibility = Visibility.Hidden;
            gr2.Visibility = Visibility.Hidden;
            gr3.Visibility = Visibility.Visible;
            gr4.Visibility = Visibility.Hidden;
        }

        private void ten_Click(object sender, RoutedEventArgs e)
        {
            bet = 10;
            two.Content = "Bet: 10";
            gr1.Visibility = Visibility.Hidden;
            gr2.Visibility = Visibility.Visible;
            gr3.Visibility = Visibility.Hidden;
            gr4.Visibility = Visibility.Hidden;
        }

        private void five_Click(object sender, RoutedEventArgs e)
        {
            bet = 5;
            two.Content = "Bet: 5";
            gr1.Visibility = Visibility.Visible;
            gr2.Visibility = Visibility.Hidden;
            gr3.Visibility = Visibility.Hidden;
            gr4.Visibility = Visibility.Hidden;
        }
        #endregion
        private void RandomPic(int imageSwitch, Image box)
        {

            switch (imageSwitch)
            {
                case 1:
                    box.Source = new BitmapImage(new Uri(@"C:\Users\User\Desktop\UNI\2. kurss\Programmesana\Gala darbs\Ikonas\1.png"));

                    break;
                case 2:
                    box.Source = new BitmapImage(new Uri(@"C:\Users\User\Desktop\UNI\2. kurss\Programmesana\Gala darbs\Ikonas\2.png"));

                    break;
                case 3:
                    box.Source = new BitmapImage(new Uri(@"C:\Users\User\Desktop\UNI\2. kurss\Programmesana\Gala darbs\Ikonas\3.png"));

                    break;
                case 4:
                    box.Source = new BitmapImage(new Uri(@"C:\Users\User\Desktop\UNI\2. kurss\Programmesana\Gala darbs\Ikonas\4.png"));
                    break;

            }
        }
        private void Total(int bet, int likme)
        {
            if (bet==5)
            {
                total = total + likme;
            }
            else if(bet==10)
            {
                total = total + likme * 2;
            }
            else if (bet == 20)
            {
                total = total + likme * 4;
            }
            else
            {
                total = total + likme * 8;
            }

        }
        void BorderBrush(params Border[] bor)
        {
            for (int i = 0; i < bor.Length; i++)
            {
                bor[i].BorderBrush = Brushes.Green;
                bor[i].BorderThickness = new Thickness(5);
            }
        }
        void BorderBrushBack(params Border[] bor)
        {
            for (int i = 0; i < bor.Length; i++)
            {
                bor[i].BorderBrush = Brushes.Black;
                bor[i].BorderThickness = new Thickness(3);
            }
        }
       
        private void Anim(DoubleAnimation trans, Image image1, Image image2, Image image3, Image image4)
        {
            image1.BeginAnimation(HeightProperty, trans);
            image2.BeginAnimation(HeightProperty, trans);
            image3.BeginAnimation(HeightProperty, trans);
            image4.BeginAnimation(HeightProperty, trans);
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            viens = random.Next(1, 5);
            divi = random.Next(1, 5);
            tris = random.Next(1, 5);
            cetri = random.Next(1, 5);
            pieci = random.Next(1, 5);
            sesi = random.Next(1, 5);
            septini = random.Next(1, 5);
            astoni = random.Next(1, 5);
            devini = random.Next(1, 5);
            desmit = random.Next(1, 5);
            vpadsmit = random.Next(1, 5);
            dpadsmit = random.Next(1, 5);


            #region RandomPic
            if (credits >= bet)
            {
                credits = credits - bet;
                one.Content = "Credits: " + credits.ToString();
                #region RandomPic

                if (box1.Source != null)
                {
                    RandomPic(viens, box1);
                }
                if (box11.Source != null)
                {
                    RandomPic(pieci, box11);
                }
                if (box111.Source != null)
                {
                    RandomPic(devini, box111);
                }
                if (box2.Source != null)
                {
                    RandomPic(divi, box2);
                }
                if (box22.Source != null)
                {
                    RandomPic(sesi, box22);
                }
                if (box222.Source != null)
                {
                    RandomPic(desmit, box222);
                }
                if (box3.Source != null)
                {
                    RandomPic(tris, box3);
                }
                if (box33.Source != null)
                {
                    RandomPic(septini, box33);
                }
                if (box333.Source != null)
                {
                    RandomPic(vpadsmit, box333);
                }
                if (box4.Source != null)
                {
                    RandomPic(cetri, box4);
                }
                if (box44.Source != null)
                {
                    RandomPic(astoni, box44);
                }
                if (box444.Source != null)
                {
                    RandomPic(dpadsmit, box444);
                }
                #endregion
                #endregion


                total = 0;
                DoubleAnimation trans = new DoubleAnimation();
                trans.From = 140;
                trans.To = 100;
                trans.Duration = new Duration(TimeSpan.FromSeconds(1));
                trans.AutoReverse = true;
                trans.RepeatBehavior = new RepeatBehavior(1);

                #region Bet5
                if (bet == 5 || bet == 10 || bet == 20 || bet == 40)
                {
                    if (viens==4&&divi==4)
                    {
                        Total(bet, 10);
                        BorderBrush(b1, b2);
                        Anim(trans, box1, box2, box1, box2);
                    }
                    else
                    {
                        BorderBrushBack(b1, b2, b3, b4);
                    }
                    if (pieci == 4 && sesi == 4)
                    {
                        Total(bet, 10);
                        BorderBrush(b5, b6);
                        Anim(trans, box11, box22, box11, box22);
                    }
                    else
                    {
                        BorderBrushBack(b5, b6, b7, b8);
                    }
                    if (devini == 4 && desmit == 4)
                    {
                        Total(bet, 10);
                        BorderBrush(b9, b10);
                        Anim(trans, box111, box222, box111, box222);
                    }
                    else
                    {
                        BorderBrushBack(b9, b10, b11, b12);
                    }
                    //////////////////////////////////////////////////////////////////////////////////////
                    if (viens == 1 && divi == 1 && tris == 1 || viens == 3 && divi == 3 && tris == 3)
                    {
                        Total(bet, 20);
                        BorderBrush(b1, b2, b3);
                        Anim(trans, box1, box2, box3, box1);
                    }
                    if (pieci == 1 && sesi == 1 && septini == 1 || pieci == 3 && sesi == 3 && septini == 3)
                    {
                        Total(bet, 20);
                        BorderBrush(b5, b6, b7);
                        Anim(trans, box11, box22, box33, box11);
                    }
                    if (devini == 1 && desmit == 1 && vpadsmit == 1 || devini == 3 && desmit == 3 && vpadsmit == 3)
                    {
                        Total(bet, 20);
                        BorderBrush(b9, b10, b11);
                        Anim(trans, box111, box222, box333, box111);
                    }
                    if (viens == 2 && divi == 2 && tris == 2)
                    {
                        Total(bet, 40);
                        BorderBrush(b1, b2, b3);
                        Anim(trans, box1, box2, box3, box1);
                    }
                    if (pieci == 2 && sesi == 2 && septini == 2)
                    {
                        Total(bet, 40);
                        BorderBrush(b5, b6, b7);
                        Anim(trans, box11, box22, box33, box11);
                    }
                    if (devini == 2 && desmit == 2 && vpadsmit == 2)
                    {
                        Total(bet, 40);
                        BorderBrush(b9, b10, b11);
                        Anim(trans, box111, box222, box333, box111);
                    }
                    if (viens == 4 && divi == 4 && tris == 4)
                    {
                        Total(bet, 40);
                        BorderBrush(b1, b2, b3);
                        Anim(trans, box1, box2, box3, box1);
                    }
                    if (pieci == 4 && sesi == 4 && septini == 4)
                    {
                        Total(bet, 40);
                        BorderBrush(b5, b6, b7);
                        Anim(trans, box11, box22, box33, box11);
                    }
                    if (devini == 4 && desmit == 4 && vpadsmit == 4)
                    {
                        Total(bet, 40);
                        BorderBrush(b9, b10, b11);
                        Anim(trans, box111, box222, box333, box111);
                    }
                    //////////////////////////////////////////////////////////////////////////////////////////////////
                    if (viens == 1 && divi == 1 && tris == 1 && cetri == 1 || viens == 3 && divi == 3 && tris == 3 && cetri == 3)
                    {
                        Total(bet, 70);
                        BorderBrush(b1, b2, b3, b4);
                        Anim(trans, box1, box2, box3, box4);
                    }
                    if (pieci == 1 && sesi == 1 && septini == 1 && astoni == 1 || pieci == 3 && sesi == 3 && septini == 3 && astoni == 3)
                    {
                        Total(bet, 70);
                        BorderBrush(b5, b6, b7, b8);
                        Anim(trans, box11, box22, box33, box44);
                    }
                    if (devini == 1 && desmit == 1 && vpadsmit == 1 && dpadsmit == 1 || devini == 3 && desmit == 3 && vpadsmit == 3 && dpadsmit == 3)
                    {
                        Total(bet, 70);
                        BorderBrush(b9, b10, b11, b12);
                        Anim(trans, box111, box222, box333, box444);
                    }
                    if (viens == 2 && divi == 2 && tris == 2 && cetri == 2)
                    {
                        Total(bet, 80);
                        BorderBrush(b1, b2, b3, b4);
                        Anim(trans, box1, box2, box3, box4);
                    }
                    if (pieci == 2 && sesi == 2 && septini == 2 && astoni == 2)
                    {
                        Total(bet, 80);
                        BorderBrush(b5, b6, b7, b8);
                        Anim(trans, box11, box22, box33, box44);
                    }
                    if (devini == 2 && desmit == 2 && vpadsmit == 2 && dpadsmit == 2)
                    {
                        Total(bet, 80);
                        BorderBrush(b9, b10, b11, b12);
                        Anim(trans, box111, box222, box333, box444);
                    }
                    if (viens == 4 && divi == 4 && tris == 4 && cetri == 4)
                    {
                        Total(bet, 90);
                        BorderBrush(b1, b2, b3, b4);
                        Anim(trans, box1, box2, box3, box4);
                    }
                    if (pieci == 4 && sesi == 4 && septini == 4 && astoni == 4)
                    {
                        Total(bet, 90);
                        BorderBrush(b5, b6, b7, b8);
                        Anim(trans, box11, box22, box33, box44);
                    }
                    if (devini == 4 && desmit == 4 && vpadsmit == 4 && dpadsmit == 4)
                    {
                        Total(bet, 90);
                        BorderBrush(b9, b10, b11, b12);
                        Anim(trans, box111, box222, box333, box444);
                    }
                }
                #endregion


                if ((string)btn1.Content == "Spin")
                {
                    btn1.Content = "Spin again";
                    da.From = -350;
                    da.To = 10;
                    da.Duration = new Duration(TimeSpan.FromSeconds(0.1));
                    stackPanel1.BeginAnimation(Canvas.TopProperty, da);
                }
                else if ((string)btn1.Content == "Spin again")
                {
                    de.From = 10;
                    de.To = 400;
                    de.Duration = new Duration(TimeSpan.FromSeconds(0.05));
                    stackPanel1.BeginAnimation(Canvas.TopProperty, de);

                }

                credits = credits + total;
                three.Content = "Win: " + total.ToString();
                one.Content = "Credits: " + credits.ToString();
            }
            else
            {
                lielais.Visibility = Visibility.Visible;
            }
            de.Completed += new EventHandler(de_Completed);
        }

        DoubleAnimation da = new DoubleAnimation();
        DoubleAnimation de = new DoubleAnimation();

        public void de_Completed(object sender, EventArgs e)
        {
            stackPanel1.BeginAnimation(Canvas.TopProperty, da);
        }

    }
}
