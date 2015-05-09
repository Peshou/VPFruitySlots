using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlotsGame
{
    public partial class Game : Form
    {
        private static List<Image> imageList;
        private static Random random;
        private static int[] randomNumbers;
        private static int[] threes;
        private static int[] fours;
        private static int[] fives;
        private static double timerHandleTick;
        private static float whatYouBet;
        private static int spinTiming;
        private static bool isAutoPlaying;
        private static int waitBetweenSpinTiming;
        private static bool firstTime;
        private static int numTimes;
        private static bool firstSpin;
        private static bool boughtCredits;
        private static int linesCounter;
        public Game()
        {
            InitializeComponent();
            imageList = new List<Image>();
            imageList.Add(Properties.Resources.Banana);
            imageList.Add(Properties.Resources.Cresha);
            imageList.Add(Properties.Resources.Grape);
            imageList.Add(Properties.Resources.Jabolko);
            imageList.Add(Properties.Resources.Krusha);
            imageList.Add(Properties.Resources.Lemon);
            imageList.Add(Properties.Resources.Portokal);
            imageList.Add(Properties.Resources.nmSeven);
            imageList.Add(Properties.Resources.Sliva);
            
            threes = new int[] { 3, 4, 7, 7, 3, 2, 8, 10, 6 };
            fours = new int[] { 6, 6, 11, 15, 5, 5, 12, 20, 10 };
            fives = new int[] { 9, 8, 16, 19, 7, 12, 16, 30, 11 };
            firstTime = true;
            whatYouBet = 0;
            spinTiming = 0;
            linesCounter = 1;
            firstSpin = true;
            boughtCredits = false;
            timerHandleTick = 0;
            isAutoPlaying = false;
            randomNumbers = new int[15];
            numTimes = 0;
            random = new Random();
            waitBetweenSpinTiming = 0;
            this.DoubleBuffered = true;
        }

        private void btnHelpAndPayout_Click(object sender, EventArgs e)
        {
            HelpAndWinInfo h = new HelpAndWinInfo();
            h.ShowDialog();
        }


        /*
         *Metod koj go najdov na internet za restartiranje na gifot za pictureBox za spinot, bidejki nemozev
         *100% tochno da go nashteluvam da se vraka u prvobitnata sostojba so tajmerot
         *Kodot e prevzemen od http://stackoverflow.com/questions/17008254/need-to-select-a-frame-in-gif
        */
        private void RestartToFrameIndex(int index)
        {
            pbHandle.Image.SelectActiveFrame(new FrameDimension(pbHandle.Image.FrameDimensionsList[0]), index);
            pbHandle.Image = pbHandle.Image;
        }

        /*
         * Metod koj go koristam za animacijata na rachkata
        */
        private void handleTimer_Tick(object sender, EventArgs e)
        {
            if (timerHandleTick >= 6)
            {
                //tuka go restartiram gifot za nekoj sleden spin
                RestartToFrameIndex(0);
                pbHandle.Enabled = false;
                handleTimer.Enabled = false;
                timerHandleTick = 0;
            }
            else
            {
                timerHandleTick += 1;
                pbHandle.Enabled = true;

            }
        }

        /*
         * Metod so koj proveruvam dali ima dovolno balans za Igranje, ako nema da se iskoristi celiot,
         * a ako toj e 0 da se vrati -vrednost;
        */
        private bool CanYouSpin(float _balance, float _bet)
        {
            if (_balance <= 0)
            {
                return false;
            }
            else
            {
                if (_bet > _balance)
                {
                    return false;
                }
                return true;
            }
        }


        /*
         * Event handler za kliknuvanje na SPIN kopcheto
        */
        private void btnSpin_Click(object sender, EventArgs e)
        {
            if (firstTime)
            {
                tbWin.Text = "";
                labelHello.Text = "You won:";
                firstTime = false;
                labelHello.Visible = false;
                labelYouWon.Visible = true;
            }
            float balance = checkBalance(tbBalance.Text);
            float bet = (float)nudYourBet.Value;
            bool a = CanYouSpin(balance, bet);
            if (a)
            {
                this.BackgroundImage = Properties.Resources.PlayScreen___Copy;
                whatYouBet = bet;
                balance -= whatYouBet;
                tbBalance.Text = balance.ToString();
                spinTimer.Enabled = true;
                handleTimer.Enabled = true;
                btnSpin.Enabled = false;
                
            }
            else
            {
                btnSpin.Enabled = false;
                btnAutoPlay.Enabled = false;
                nudLines.Value = 1;
                nudYourBet.Value = 1;
            }
        }
        private void check()
        {
            float f = checkBalance(tbBalance.Text);
            while (true)
            {
                if (f < (float)nudLines.Value)
                {
                    // POTENCIALEN FATAL EXCEPTION
                        if(f>(int)nudLines.Minimum){
                            nudLines.Value = (int)f;
                        }
                        else
                        {
                            if(nudLines.Value >1)
                            nudLines.Value--;
                        }
                }
                else
                {

                    nudYourBet.Value = (decimal)f;
                    break;

                }
            }
            
        }
      
        /*
         * Metod za maksimalen bet
        */
        private void btnMaxBet_Click(object sender, EventArgs e)
        {
            float f = checkBalance(tbBalance.Text);
            nudYourBet.Value = (decimal)f;
           
        }
      
        
        private void spinTimer_Tick(object sender, EventArgs e)
        {

            if (!isAutoPlaying)
            {
                if (spinTiming <= 20)
                {
                    //prvo so randomNumber generator zemam 15 brojki koi kje bidat slikite od Listata so sliki
                    for (int i = 0; i < 15; i++)
                    {
                        int randomNumber = random.Next(0, 9);
                        randomNumbers[i] = randomNumber;
                    }
                    //posle toa gi postatvuvam slikite so nivnite indeksi od Listata spored random brojkite
                    pb1.Image = imageList[randomNumbers[0]];
                    pb2.Image = imageList[randomNumbers[1]];
                    pb3.Image = imageList[randomNumbers[2]];
                    pb4.Image = imageList[randomNumbers[3]];
                    pb5.Image = imageList[randomNumbers[4]];
                    pb6.Image = imageList[randomNumbers[5]];
                    pb7.Image = imageList[randomNumbers[6]];
                    pb8.Image = imageList[randomNumbers[7]];
                    pb9.Image = imageList[randomNumbers[8]];
                    pb10.Image = imageList[randomNumbers[9]];
                    pb11.Image = imageList[randomNumbers[10]];
                    pb12.Image = imageList[randomNumbers[11]];
                    pb13.Image = imageList[randomNumbers[12]];
                    pb14.Image = imageList[randomNumbers[13]];
                    pb15.Image = imageList[randomNumbers[14]];
                    spinTiming++;
                }
                else
                {

                    //go resetiram tajmerot
                    spinTiming = 0;
                    spinTimer.Enabled = false;
                    CalculateWin(whatYouBet, (int)nudLines.Value, randomNumbers);
                    whatYouBet = 0;
                    if (checkBalance(tbBalance.Text) > 0)
                        btnSpin.Enabled = true;
                }
            }
            else
            {
                if (spinTiming <= 20)
                {

                    //prvo so randomNumber generator zemam 15 brojki koi kje bidat slikite od Listata so sliki
                    for (int i = 0; i < 15; i++)
                    {
                        int randomNumber = random.Next(0, 9);
                        randomNumbers[i] = randomNumber;
                    }


                    //posle toa gi postatvuvam slikite so nivnite indeksi od Listata spored random brojkite
                    pb1.Image = imageList[randomNumbers[0]];
                    pb2.Image = imageList[randomNumbers[1]];
                    pb3.Image = imageList[randomNumbers[2]];
                    pb4.Image = imageList[randomNumbers[3]];
                    pb5.Image = imageList[randomNumbers[4]];
                    pb6.Image = imageList[randomNumbers[5]];
                    pb7.Image = imageList[randomNumbers[6]];
                    pb8.Image = imageList[randomNumbers[7]];
                    pb9.Image = imageList[randomNumbers[8]];
                    pb10.Image = imageList[randomNumbers[9]];
                    pb11.Image = imageList[randomNumbers[10]];
                    pb12.Image = imageList[randomNumbers[11]];
                    pb13.Image = imageList[randomNumbers[12]];
                    pb14.Image = imageList[randomNumbers[13]];
                    pb15.Image = imageList[randomNumbers[14]];
                    spinTiming++;
                    
                }
                else
                {

                    if (numTimes == 1)
                    {

                        //go resetiram tajmerot
                        nudAutoPlay.Value = 1;
                        spinTiming = 0;
                        spinTimer.Enabled = false;
                        changeButtonAutoPlay(false);
                        CalculateWin(whatYouBet, (int)nudLines.Value, randomNumbers);
                        whatYouBet = 0;
                        if (checkBalance(tbBalance.Text) > 0)
                            btnSpin.Enabled = true;
                    }
                    else
                    {

                        CalculateWin(whatYouBet, (int)nudLines.Value, randomNumbers);
                        numTimes--;
                        nudAutoPlay.Value--;
                        spinTiming = 0;
                        spinTimer.Enabled = false;
                        waitBetweenSpinTimer.Enabled = true;
                     

                    }
                }
            }
        }
        /*
         * Metod za promena na tekstot na kopcheto za Autoplay, za vo sluchaj ako sakame da prekineme autoplay
        */
        private void changeButtonAutoPlay(bool what)
        {
            if (what == true)
            {
                btnAutoPlay.Text = "Stop";
                toolTip1.SetToolTip(btnAutoPlay, "Click here to STOP Autoplaying!");
            }
            else
            {
                btnAutoPlay.Text = "Autoplay";
                toolTip1.SetToolTip(btnAutoPlay, "Click here for AUTOPLAY!");
            }
        }

        /*
         * Glaven metod za kalkuliranje na dobivkata
        */
        private void CalculateWin(float _whatYouBet, int lines, int[] _randomNumbers)
        {
            Pen myPen;
            myPen = new Pen(Color.Red);
            myPen.Width = 6;
            Graphics formGraphics = this.CreateGraphics();
         //   formGraphics.DrawRectangle(myPen, 100, 67, 100, 107);


            float win = 0;
       
            while (lines > 0)
            {
               if (lines == 1)
                {
                    myPen.Color = Color.DarkRed;
                    if ((_randomNumbers[5] == _randomNumbers[6]) && (_randomNumbers[5] == _randomNumbers[7]))
                    {
                  
                        Graphics graphics1 = pb6.CreateGraphics();
                        Graphics graphics2 = pb7.CreateGraphics();
                        Graphics graphics3 = pb8.CreateGraphics();
                        graphics1.DrawLine(myPen, 0, 50, 100, 50);
                        graphics2.DrawLine(myPen, 0, 50, 100, 50);
                        graphics3.DrawLine(myPen, 0, 50, 100, 50);
                        formGraphics.DrawLine(myPen, new Point(100, 238), new Point(400, 238));
                        graphics1.Dispose();
                        graphics2.Dispose();
                        graphics3.Dispose();
                        Graphics graphics4 = pb9.CreateGraphics();
                        graphics4.DrawLine(myPen, 0, 50, 100, 50);
                        graphics4.Dispose();
                        Graphics graphics5 = pb10.CreateGraphics();
                        graphics5.DrawLine(myPen, 0, 50, 100, 50);
                        graphics5.Dispose();
                        formGraphics.DrawLine(myPen, new Point(500, 238), new Point(600, 238));
                        if (_randomNumbers[5] == _randomNumbers[8])
                        {
                           
                            if (_randomNumbers[5] == _randomNumbers[9])
                            {
                                
                                win += _whatYouBet * fives[_randomNumbers[5]];
                            }
                            else
                            {
                                formGraphics.DrawLine(myPen, new Point(400, 238), new Point(500, 238));
                                win += _whatYouBet * fours[_randomNumbers[5]];
                            }
                        }
                        else
                        {
                            win += _whatYouBet * threes[_randomNumbers[5]];
                        }
                    }
                }
                else if (lines == 2)
                {
                    myPen.Color = Color.Navy;
                  
                    if ((_randomNumbers[0] == _randomNumbers[1]) && (_randomNumbers[0] == _randomNumbers[2]))
                    {
                        Graphics graphics1 = pb1.CreateGraphics();
                        Graphics graphics2 = pb2.CreateGraphics();
                        Graphics graphics3 = pb3.CreateGraphics();
                        graphics1.DrawLine(myPen, 0, 50, 100, 50);
                        graphics2.DrawLine(myPen, 0, 50, 100, 50);
                        graphics3.DrawLine(myPen, 0, 50, 100, 50);
                        graphics1.Dispose();
                        graphics2.Dispose();
                        graphics3.Dispose();
                        formGraphics.DrawLine(myPen, new Point(100, 120), new Point(400, 120));
                        Graphics graphics4 = pb4.CreateGraphics();
                        graphics4.DrawLine(myPen, 0, 50, 100, 50);
                        graphics4.Dispose();
                        formGraphics.DrawLine(myPen, new Point(400, 120), new Point(500, 120));
                        Graphics graphics5 = pb5.CreateGraphics();
                        graphics5.DrawLine(myPen, 0, 50, 100, 50);
                        graphics5.Dispose();
                        formGraphics.DrawLine(myPen, new Point(500, 120), new Point(600, 120));
                        if (_randomNumbers[0] == _randomNumbers[3])
                        {
                    
                            if (_randomNumbers[0] == _randomNumbers[4])
                            {
                      
                                win += _whatYouBet * fives[_randomNumbers[0]];
                            }
                            else
                            {
                                win += _whatYouBet * fours[_randomNumbers[0]];
                            }
                        }
                        else
                        {
                            win += _whatYouBet * threes[_randomNumbers[0]];
                        }
                    }
                }
                else if (lines == 3)
                {
                    myPen.Color = Color.DimGray;
                    if ((_randomNumbers[10] == _randomNumbers[11]) && (_randomNumbers[10] == _randomNumbers[12]))
                    {
                        Graphics graphics1 = pb11.CreateGraphics();
                        Graphics graphics2 = pb12.CreateGraphics();
                        Graphics graphics3 = pb13.CreateGraphics();
                        graphics1.DrawLine(myPen, 0, 50, 100, 50);
                        graphics2.DrawLine(myPen, 0, 50, 100, 50);
                        graphics3.DrawLine(myPen, 0, 50, 100, 50);
                        formGraphics.DrawLine(myPen, new Point(100, 358), new Point(400, 358));
                        graphics1.Dispose();
                        graphics2.Dispose();
                        graphics3.Dispose();
                        Graphics graphics4 = pb14.CreateGraphics();
                        graphics4.DrawLine(myPen, 0, 50, 100, 50);
                        graphics4.Dispose();
                        formGraphics.DrawLine(myPen, new Point(400, 358), new Point(500, 358));
                        Graphics graphics5 = pb15.CreateGraphics();
                        graphics5.DrawLine(myPen, 0, 50, 100, 50);
                        graphics5.Dispose();
                        formGraphics.DrawLine(myPen, new Point(500, 358), new Point(600, 358));
                        if (_randomNumbers[10] == _randomNumbers[13])
                        {
             
                            if (_randomNumbers[10] == _randomNumbers[14])
                            {
                         
                                win += _whatYouBet * fives[_randomNumbers[10]];
                            }
                            else
                            {
                                win += _whatYouBet * fours[_randomNumbers[10]];
                            }
                        }
                        else
                        {
                            win += _whatYouBet * threes[_randomNumbers[10]];
                        }
                    }
                }
                else if (lines == 4)
               {
                   myPen.Color = Color.DarkGreen;

                    if ((_randomNumbers[0] == _randomNumbers[6]) && (_randomNumbers[0] == _randomNumbers[12]))
                    {
                        Graphics graphics1 = pb1.CreateGraphics();
                        Graphics graphics2 = pb7.CreateGraphics();
                        Graphics graphics3 = pb13.CreateGraphics();
                        graphics1.DrawLine(myPen, 0, 50, 50, 50);
                        graphics1.DrawLine(myPen, 50, 50, 100, 100);
                        graphics2.DrawLine(myPen, 0, 0, 100, 100);
                        graphics3.DrawLine(myPen, 0, 0, 50, 50);
                        graphics3.DrawLine(myPen, 50, 50, 100, 0);
                        formGraphics.DrawLine(myPen, new Point(150, 115), new Point(365, 358));
                        graphics1.Dispose();
                        graphics2.Dispose();
                        graphics3.Dispose();
                        formGraphics.DrawLine(myPen, new Point(408, 315), new Point(500, 200));
                        Graphics graphics4 = pb9.CreateGraphics();
                        graphics4.DrawLine(myPen, 0, 100, 100, 0);
                        graphics4.Dispose();
                        formGraphics.DrawLine(myPen, new Point(505, 205), new Point(600, 100));
                        Graphics graphics5 = pb5.CreateGraphics();
                        graphics5.DrawLine(myPen, 0, 100, 50, 50);
                        graphics5.DrawLine(myPen, 50, 50, 100, 50);
                        graphics5.Dispose();
                     
                        if (_randomNumbers[0] == _randomNumbers[8])
                        {
                            
                  
                            if (_randomNumbers[0] == _randomNumbers[4])
                            {
                              

                                win += _whatYouBet * fives[_randomNumbers[0]];
                            }
                            else
                            {
                                win += _whatYouBet * fours[_randomNumbers[0]];
                            }
                        }
                        else
                        {
                            win += _whatYouBet * threes[_randomNumbers[0]];
                        }
                    }
                }
                else if (lines == 5)
                {
                    myPen.Color = Color.MediumBlue;
                  
                    if ((_randomNumbers[10] == _randomNumbers[6]) && (_randomNumbers[10] == _randomNumbers[2]))
                    {
                        Graphics graphics1 = pb11.CreateGraphics();
                        Graphics graphics2 = pb7.CreateGraphics();
                        Graphics graphics3 = pb3.CreateGraphics();
                        graphics1.DrawLine(myPen, 0, 50, 50, 50);
                        graphics1.DrawLine(myPen, 50, 50, 100, 0);
                        graphics2.DrawLine(myPen, 0, 100, 100, 0);
                        graphics3.DrawLine(myPen, 0, 100, 50, 50);
                        graphics3.DrawLine(myPen, 50, 50, 100, 100);
                        formGraphics.DrawLine(myPen, new Point(150, 365), new Point(365, 120));
                        formGraphics.DrawLine(myPen, new Point(365, 120), new Point(600, 385));
                        graphics1.Dispose();
                        graphics2.Dispose();
                        graphics3.Dispose();
                        Graphics graphics4 = pb9.CreateGraphics();
                        graphics4.DrawLine(myPen, 0, 0, 100, 100);
                        graphics4.Dispose();
                        Graphics graphics5 = pb15.CreateGraphics();
                        graphics5.DrawLine(myPen, 0, 0, 50, 50);
                        graphics5.DrawLine(myPen, 50, 50, 100, 50);
                        graphics5.Dispose();
                       
                        if (_randomNumbers[10] == _randomNumbers[8])
                        {
                            if (_randomNumbers[10] == _randomNumbers[14])
                            {
                                win += _whatYouBet * fives[_randomNumbers[10]];
                            }
                            else
                            {
                                win += _whatYouBet * fours[_randomNumbers[10]];
                            }
                        }
                        else
                        {
                            win += _whatYouBet * threes[_randomNumbers[10]];
                        }
                    }
                }
                else if (lines == 6)
                {
                    myPen.Color = Color.BlueViolet;

                    if ((_randomNumbers[5] == _randomNumbers[1]) && (_randomNumbers[5] == _randomNumbers[2]))
                    {
                        Graphics graphics1 = pb6.CreateGraphics();
                        Graphics graphics2 = pb2.CreateGraphics();
                        Graphics graphics3 = pb3.CreateGraphics();
                        graphics1.DrawLine(myPen, 0, 50, 50, 50);
                        graphics1.DrawLine(myPen, 50, 50, 100, 0);
                        graphics2.DrawLine(myPen, 0, 100, 50, 50);
                        graphics2.DrawLine(myPen, 50, 50, 100, 50);
                        graphics3.DrawLine(myPen, 0, 50, 100, 50);
                        graphics1.Dispose();
                        graphics2.Dispose();
                        graphics3.Dispose();
                        Graphics graphics4 = pb4.CreateGraphics();
                        graphics4.DrawLine(myPen, 0, 50, 50, 50);
                        graphics4.DrawLine(myPen, 50, 50, 100, 100);
                        graphics4.Dispose();
                        Graphics graphics5 = pb10.CreateGraphics();
                        graphics5.DrawLine(myPen, 0, 0, 50, 50);
                        graphics5.DrawLine(myPen, 50, 50, 100, 50);
                        graphics5.Dispose();
                        if (_randomNumbers[5] == _randomNumbers[3])
                        {
                            if (_randomNumbers[5] == _randomNumbers[9])
                            {
                                win += _whatYouBet * fives[_randomNumbers[5]];
                            }
                            else
                            {
                                win += _whatYouBet * fours[_randomNumbers[5]];
                            }
                        }
                        else
                        {
                            win += _whatYouBet * threes[_randomNumbers[5]];
                        }
                    }
                }
                else if (lines == 7)
               {
                   myPen.Color = Color.Lime;
                   

                   if ((_randomNumbers[5] == _randomNumbers[11]) && (_randomNumbers[5] == _randomNumbers[12]))
                    {
                        Graphics graphics1 = pb6.CreateGraphics();
                        Graphics graphics2 = pb12.CreateGraphics();
                        Graphics graphics3 = pb13.CreateGraphics();
                        graphics1.DrawLine(myPen, 0, 50, 50, 50);
                        graphics1.DrawLine(myPen, 50, 50, 100, 100);
                        graphics2.DrawLine(myPen, 0, 0, 50, 50);
                        graphics2.DrawLine(myPen, 50, 50, 100, 50);
                        graphics3.DrawLine(myPen, 0, 50, 100, 50);
                        graphics1.Dispose();
                        graphics2.Dispose();
                        graphics3.Dispose();
                        Graphics graphics4 = pb14.CreateGraphics();
                        graphics4.DrawLine(myPen, 0, 50, 50, 50);
                        graphics4.DrawLine(myPen, 50, 50, 100, 0);
                        graphics4.Dispose();
                        Graphics graphics5 = pb10.CreateGraphics();
                        graphics5.DrawLine(myPen, 0, 100, 50, 50);
                        graphics5.DrawLine(myPen, 50, 50, 100, 50);
                        graphics5.Dispose();

                        if (_randomNumbers[5] == _randomNumbers[13])
                        {
                            if (_randomNumbers[5] == _randomNumbers[9])
                            {
                                win += _whatYouBet * fives[_randomNumbers[5]];
                            }
                            else
                            {
                                win += _whatYouBet * fours[_randomNumbers[5]];
                            }
                        }
                        else
                        {
                            win += _whatYouBet * threes[_randomNumbers[5]];
                        }
                    }
                }
                else if (lines == 8)
                {
                    myPen.Color = Color.Olive;
                  
                    if (_randomNumbers[0] == _randomNumbers[1] && _randomNumbers[0] == _randomNumbers[7])
                    {
                        Graphics graphics1 = pb1.CreateGraphics();
                        Graphics graphics2 = pb2.CreateGraphics();
                        Graphics graphics3 = pb8.CreateGraphics();
                        graphics1.DrawLine(myPen, 0, 50, 100, 50);
                        graphics2.DrawLine(myPen, 0, 50, 50, 50);
                        graphics2.DrawLine(myPen, 50, 50, 100, 100);
                        graphics3.DrawLine(myPen, 0, 0, 100, 100);
                        graphics1.Dispose();
                        graphics2.Dispose();
                        graphics3.Dispose();
                        Graphics graphics4 = pb14.CreateGraphics();
                        graphics4.DrawLine(myPen, 0, 0, 50, 50);
                        graphics4.DrawLine(myPen, 50, 50, 100, 50);
                        graphics4.Dispose();
                        Graphics graphics5 = pb15.CreateGraphics();
                        graphics5.DrawLine(myPen, 0, 50, 100, 50);
                        graphics5.Dispose();
                        if (_randomNumbers[0] == _randomNumbers[13])
                        {
                            if (_randomNumbers[0] == _randomNumbers[14])
                            {
                                win += _whatYouBet * fives[_randomNumbers[0]];
                            }
                            else
                            {
                                win += _whatYouBet * fours[_randomNumbers[0]];
                            }
                        }
                        else
                        {
                            win += _whatYouBet * threes[_randomNumbers[0]];
                        }
                    }
                }
                else if (lines == 9)
                {
                    myPen.Color = Color.Aqua;
                   
                    if (_randomNumbers[10] == _randomNumbers[11] && _randomNumbers[10] == _randomNumbers[7])
                    {
                        Graphics graphics1 = pb11.CreateGraphics();
                        Graphics graphics2 = pb12.CreateGraphics();
                        Graphics graphics3 = pb8.CreateGraphics();
                        graphics1.DrawLine(myPen, 0, 50, 100, 50);
                        graphics2.DrawLine(myPen, 0, 50, 50, 50);
                        graphics2.DrawLine(myPen, 50, 50, 100, 0);
                        graphics3.DrawLine(myPen, 0, 100, 100, 0);
                        graphics1.Dispose();
                        graphics2.Dispose();
                        graphics3.Dispose();
                        Graphics graphics4 = pb4.CreateGraphics();
                        graphics4.DrawLine(myPen, 0, 100, 50, 50);
                        graphics4.DrawLine(myPen, 50, 50, 100, 50);
                        graphics4.Dispose();
                        Graphics graphics5 = pb5.CreateGraphics();
                        graphics5.DrawLine(myPen, 0, 50, 100, 50);
                        graphics5.Dispose();
                        if (_randomNumbers[10] == _randomNumbers[3])
                        {
                            if (_randomNumbers[10] == _randomNumbers[4])
                            {
                                win += _whatYouBet * fives[_randomNumbers[10]];
                            }
                            else
                            {
                                win += _whatYouBet * fours[_randomNumbers[10]];
                            }
                        }
                        else
                        {
                            win += _whatYouBet * threes[_randomNumbers[10]];
                        }
                    }
                }
                else if (lines == 10)
                {
                    myPen.Color = Color.Magenta;
                  
                    if (_randomNumbers[5] == _randomNumbers[11] && _randomNumbers[5] == _randomNumbers[7])
                    {
                        Graphics graphics1 = pb6.CreateGraphics();
                        Graphics graphics2 = pb12.CreateGraphics();
                        Graphics graphics3 = pb8.CreateGraphics();
                        graphics1.DrawLine(myPen, 0, 50, 50, 50);
                        graphics1.DrawLine(myPen, 50, 50, 100, 100);
                        graphics2.DrawLine(myPen, 0, 0, 50, 50);
                        graphics2.DrawLine(myPen, 50, 50, 100, 0);
                        graphics3.DrawLine(myPen, 0, 100, 100, 0);
                        graphics1.Dispose();
                        graphics2.Dispose();
                        graphics3.Dispose();
                        Graphics graphics4 = pb4.CreateGraphics();
                        graphics4.DrawLine(myPen, 0, 100, 50, 50);
                        graphics4.DrawLine(myPen, 50, 50, 100, 100);
                        graphics4.Dispose();
                        Graphics graphics5 = pb10.CreateGraphics();
                        graphics5.DrawLine(myPen, 0, 0, 50, 50);
                        graphics5.DrawLine(myPen, 50, 50, 100, 50);
                        graphics5.Dispose();
                        if (_randomNumbers[5] == _randomNumbers[3])
                        {
                            if (_randomNumbers[5] == _randomNumbers[9])
                            {
                                win += _whatYouBet * fives[_randomNumbers[5]];
                            }
                            else
                            {
                                win += _whatYouBet * fours[_randomNumbers[5]];
                            }
                        }
                        else
                        {
                            win += _whatYouBet * threes[_randomNumbers[5]];
                        }
                    }
                }
                else if (lines == 11)
                {
                    myPen.Color = Color.SaddleBrown;
                   
                    if (_randomNumbers[5] == _randomNumbers[1] && _randomNumbers[5] == _randomNumbers[7])
                    {
                        Graphics graphics1 = pb6.CreateGraphics();
                        Graphics graphics2 = pb2.CreateGraphics();
                        Graphics graphics3 = pb8.CreateGraphics();
                        graphics1.DrawLine(myPen, 0, 50, 50, 50);
                        graphics1.DrawLine(myPen, 50, 50, 100, 0);
                        graphics2.DrawLine(myPen, 0, 100, 50, 50);
                        graphics2.DrawLine(myPen, 50, 50, 100, 100);
                        graphics3.DrawLine(myPen, 0, 0, 100, 100);
                        graphics1.Dispose();
                        graphics2.Dispose();
                        graphics3.Dispose();
                        Graphics graphics4 = pb14.CreateGraphics();
                        graphics4.DrawLine(myPen, 0, 0, 50, 50);
                        graphics4.DrawLine(myPen, 50, 50, 100, 0);
                        graphics4.Dispose();
                        Graphics graphics5 = pb10.CreateGraphics();
                        graphics5.DrawLine(myPen, 0, 100, 50, 50);
                        graphics5.DrawLine(myPen, 50, 50, 100, 50);
                        graphics5.Dispose();
                        if (_randomNumbers[5] == _randomNumbers[13])
                        {
                            if (_randomNumbers[5] == _randomNumbers[9])
                            {
                                win += _whatYouBet * fives[_randomNumbers[5]];
                            }
                            else
                            {
                                win += _whatYouBet * fours[_randomNumbers[5]];
                            }
                        }
                        else
                        {
                            win += _whatYouBet * threes[_randomNumbers[5]];
                        }
                    }
                }
                else if (lines == 12)
                {
                    myPen.Color = Color.SpringGreen;
                   
                    if (_randomNumbers[0] == _randomNumbers[6] && _randomNumbers[0] == _randomNumbers[7])
                    {
                        Graphics graphics1 = pb1.CreateGraphics();
                        Graphics graphics2 = pb7.CreateGraphics();
                        Graphics graphics3 = pb8.CreateGraphics();
                        graphics1.DrawLine(myPen, 0, 50, 50, 50);
                        graphics1.DrawLine(myPen, 50, 50, 100, 100);
                        graphics2.DrawLine(myPen, 0, 0, 50, 50);
                        graphics2.DrawLine(myPen, 50, 50, 100, 50);
                        graphics3.DrawLine(myPen, 0, 50, 100, 50);
                        graphics1.Dispose();
                        graphics2.Dispose();
                        graphics3.Dispose();
                        Graphics graphics4 = pb9.CreateGraphics();
                        graphics4.DrawLine(myPen, 0, 50, 50, 50);
                        graphics4.DrawLine(myPen, 50, 50, 100, 0);
                        graphics4.Dispose();
                        Graphics graphics5 = pb5.CreateGraphics();
                        graphics5.DrawLine(myPen, 0, 100, 50, 50);
                        graphics5.DrawLine(myPen, 50, 50, 100, 50);
                        graphics5.Dispose();
                        if (_randomNumbers[0] == _randomNumbers[8])
                        {
                            if (_randomNumbers[0] == _randomNumbers[4])
                            {
                                win += _whatYouBet * fives[_randomNumbers[0]];
                            }
                            else
                            {
                                win += _whatYouBet * fours[_randomNumbers[0]];
                            }
                        }
                        else
                        {
                            win += _whatYouBet * threes[_randomNumbers[0]];
                        }
                    }
                }
                else if (lines == 13)
                {
                    myPen.Color = Color.OrangeRed;
                    if (_randomNumbers[10] == _randomNumbers[6] && _randomNumbers[10] == _randomNumbers[7])
                    {
                        Graphics graphics1 = pb11.CreateGraphics();
                        Graphics graphics2 = pb7.CreateGraphics();
                        Graphics graphics3 = pb8.CreateGraphics();
                        graphics1.DrawLine(myPen, 0, 50, 50, 50);
                        graphics1.DrawLine(myPen, 50, 50, 100, 0);
                        graphics2.DrawLine(myPen, 0, 100, 50, 50);
                        graphics2.DrawLine(myPen, 50, 50, 100, 50);
                        graphics3.DrawLine(myPen, 0, 50, 100, 50);
                        graphics1.Dispose();
                        graphics2.Dispose();
                        graphics3.Dispose();
                        Graphics graphics4 = pb9.CreateGraphics();
                        graphics4.DrawLine(myPen, 0, 50, 50, 50);
                        graphics4.DrawLine(myPen, 50, 50, 100, 100);
                        graphics4.Dispose();
                        Graphics graphics5 = pb15.CreateGraphics();
                        graphics5.DrawLine(myPen, 0, 0, 50, 50);
                        graphics5.DrawLine(myPen, 50, 50, 100, 50);
                        graphics5.Dispose();
                        if (_randomNumbers[10] == _randomNumbers[8])
                        {
                            if (_randomNumbers[10] == _randomNumbers[14])
                            {
                                win += _whatYouBet * fives[_randomNumbers[10]];
                            }
                            else
                            {
                                win += _whatYouBet * fours[_randomNumbers[10]];
                            }
                        }
                        else
                        {
                            win += _whatYouBet * threes[_randomNumbers[10]];
                        }
                    }
                }
                else if (lines == 14)
               {
                   myPen.Color = Color.Gold;
                  
                   if (_randomNumbers[0] == _randomNumbers[6] && _randomNumbers[0] == _randomNumbers[2])
                    {
                        Graphics graphics1 = pb1.CreateGraphics();
                        Graphics graphics2 = pb7.CreateGraphics();
                        Graphics graphics3 = pb3.CreateGraphics();
                        graphics1.DrawLine(myPen, 0, 50, 50, 50);
                        graphics1.DrawLine(myPen, 50, 50, 100, 100);
                        graphics2.DrawLine(myPen, 0, 0, 50, 50);
                        graphics2.DrawLine(myPen, 50, 50, 100, 0);
                        graphics3.DrawLine(myPen, 0, 100, 50, 50);
                        graphics3.DrawLine(myPen, 50, 50, 100, 100);
                        graphics1.Dispose();
                        graphics2.Dispose();
                        graphics3.Dispose();
                        Graphics graphics4 = pb9.CreateGraphics();
                        graphics4.DrawLine(myPen, 0, 0, 50, 50);
                        graphics4.DrawLine(myPen, 50, 50, 100, 0);
                        graphics4.Dispose();
                        Graphics graphics5 = pb5.CreateGraphics();
                        graphics5.DrawLine(myPen, 0, 100, 50, 50);
                        graphics5.DrawLine(myPen, 50, 50, 100, 50);
                        graphics5.Dispose();

                        if (_randomNumbers[0] == _randomNumbers[8])
                        {
                            if (_randomNumbers[0] == _randomNumbers[4])
                            {
                                win += _whatYouBet * fives[_randomNumbers[0]];
                            }
                            else
                            {
                                win += _whatYouBet * fours[_randomNumbers[0]];
                            }
                        }
                        else
                        {
                            win += _whatYouBet * threes[_randomNumbers[0]];
                        }
                    }
                }
                else if (lines == 15)
                {
                    myPen.Color = Color.DarkOrange;
                    if (_randomNumbers[10] == _randomNumbers[6] && _randomNumbers[10] == _randomNumbers[12])
                    {
                        Graphics graphics1 = pb11.CreateGraphics();
                        Graphics graphics2 = pb7.CreateGraphics();
                        Graphics graphics3 = pb13.CreateGraphics();
                        graphics1.DrawLine(myPen, 0, 50, 50, 50);
                        graphics1.DrawLine(myPen, 50, 50, 100, 0);
                        graphics2.DrawLine(myPen, 0, 100, 50, 50);
                        graphics2.DrawLine(myPen, 50, 50, 100, 100);
                        graphics3.DrawLine(myPen, 0, 0, 50, 50);
                        graphics3.DrawLine(myPen, 50, 50, 100, 0);
                        graphics1.Dispose();
                        graphics2.Dispose();
                        graphics3.Dispose();
                        Graphics graphics4 = pb9.CreateGraphics();
                        graphics4.DrawLine(myPen, 0, 100, 50, 50);
                        graphics4.DrawLine(myPen, 50, 50, 100, 100);
                        graphics4.Dispose();
                        Graphics graphics5 = pb15.CreateGraphics();
                        graphics5.DrawLine(myPen, 0, 0, 50, 50);
                        graphics5.DrawLine(myPen, 50, 50, 100, 50);
                        graphics5.Dispose();
                        if (_randomNumbers[10] == _randomNumbers[8])
                        {
                            if (_randomNumbers[10] == _randomNumbers[14])
                            {
                                win += _whatYouBet * fives[_randomNumbers[10]];
                            }
                            else
                            {
                                win += _whatYouBet * fours[_randomNumbers[10]];
                            }
                        }
                        else
                        {
                            win += _whatYouBet * threes[_randomNumbers[10]];
                          
                        }
                    }
                }
                lines--;
              
            }

            myPen.Dispose();
            formGraphics.Dispose();

            float balance = checkBalance(tbBalance.Text);
            balance += win;
            tbWin.Text= win.ToString();
            tbBalance.Text = balance.ToString();
        }

        /*
         * Metod za zavrshuvanje na igrata
        */
        private void btnEnd_Click(object sender, EventArgs e)
        {
            DialogResult quitResult = MessageBox.Show("Do you really want to stop the game?", "Ending the Game", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (quitResult == System.Windows.Forms.DialogResult.Yes)
            {
                string win = "You won $" + tbBalance.Text;
                MessageBox.Show(win, "End", MessageBoxButtons.OK);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

        }
        /*
         * Glavniot metod za Autoplay
        */
        private void btnAutoPlay_Click(object sender, EventArgs e)
        {
            if (firstTime)
            {
                tbWin.Text = "";
                firstTime = false;
                labelHello.Visible = false;
                labelYouWon.Visible = true;
            }
            if (btnAutoPlay.Text.Equals("Stop"))
            {
                isAutoPlaying = false;
                changeButtonAutoPlay(false);
            }
            else
            {

                numTimes = (int)nudAutoPlay.Value;
                if ((numTimes * (float)nudYourBet.Value) > checkBalance(tbBalance.Text))
                {
                    numTimes = maxSpins(tbBalance.Text, (float)nudYourBet.Value);
                    nudAutoPlay.Value = numTimes;
                }
                whatYouBet = (float)nudYourBet.Value;
                if (numTimes > 0)
                {
                 
                    changeButtonAutoPlay(true);
                    btnSpin.Enabled = false;
                    isAutoPlaying = true;
                    firstSpin = true;
                    waitBetweenSpinTimer.Enabled = true;
                }
            }
        }
        /*
         * Metod za vrakanje najgolem broj na Autospinovi
        */
        private int maxSpins(string balance, float bet)
        {
            float _balance;
            float.TryParse(balance, out _balance);
            return (int)(_balance / bet);
        }
        //Metod za proverka na balansot za da nemora celo vreme so tryParse da se pominuva vnatre vo kodot (da ne se trupa)
        private float checkBalance(string balance)
        {
            float _balance;
            float.TryParse(balance, out _balance);
            return _balance;
        }

        /* 
         * Metod so koj se cheka nekoe vreme pomegju Avtomatski spinovi za da se presmeta dobivkata i da simulira
         * realno igranje na aparat (prviot spin nikogash ne se cheka bidejki nema sho da presmeta).
        */
        private void waitBetweenSpinTimer_Tick(object sender, EventArgs e)
        {
            if (firstSpin == true)
            {
                firstSpin = false;
                float newBalance = checkBalance(tbBalance.Text);
                newBalance -= whatYouBet;
                if (newBalance <= 0)
                {
                    tbBalance.Text = "0";
                }
                else tbBalance.Text = newBalance.ToString();

                spinTimer.Enabled = true;
                handleTimer.Enabled = true;
                waitBetweenSpinTiming = 0;
                waitBetweenSpinTimer.Enabled = false;
                this.BackgroundImage = Properties.Resources.PlayScreen___Copy;
            }
            else
            {
                if (waitBetweenSpinTiming < 15)
                {
                    waitBetweenSpinTiming += 1;
                }
                else
                {
                    float newBalance = checkBalance(tbBalance.Text);
                    newBalance -= whatYouBet;
                    tbBalance.Text = newBalance.ToString();
                    spinTimer.Enabled = true;
                    handleTimer.Enabled = true;
                    waitBetweenSpinTiming = 0;
                    waitBetweenSpinTimer.Enabled = false;
                    this.BackgroundImage = Properties.Resources.PlayScreen___Copy;
                }

            }
        }

        private void tbBalance_TextChanged(object sender, EventArgs e)
        {
            float _balance = checkBalance(tbBalance.Text);
            if (_balance <= 0)
            {
                nudYourBet.Value = nudYourBet.Minimum;
                nudAutoPlay.Enabled = false;
                nudYourBet.Enabled = false;
                nudLines.Enabled = false;
                nudLines.Value = 1;
                btnAutoPlay.Enabled = false;
                btnSpin.Enabled = false;
                btnMaxRaise.Enabled = false;
                nudYourBet.Value = nudYourBet.Minimum;
                btnMaxLines.Enabled = false;
            }
            else
            {
                if (boughtCredits)
                {
                    nudAutoPlay.Enabled = true;
                    nudYourBet.Enabled = true;
                    nudLines.Enabled = true;
                    btnSpin.Enabled = true;
                    btnAutoPlay.Enabled = true;
                    btnMaxLines.Enabled = true;
                    btnMaxRaise.Enabled = true;
                    boughtCredits = false;
                }
            }
        }

        private void btnBuyCredits_Click(object sender, EventArgs e)
        {
            BuyCredits buyForm = new BuyCredits();
            buyForm.ShowDialog();
            if (buyForm.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                boughtCredits = true;
                float balance = checkBalance(tbBalance.Text);
                balance += buyForm.Result;
                tbBalance.Text = balance.ToString();
                if (checkBalance(tbBalance.Text) > 0)
                {
                    nudYourBet.Maximum = (decimal)balance;
                    nudYourBet.Minimum = nudLines.Value;
                    nudYourBet.Value = nudLines.Value;
                }
            }
        }

        private void nudLines_ValueChanged(object sender, EventArgs e)
        {
            CalculateNudYourBet();
        }
        /*
         * Metod so koj se presmetuva uplatata po liniite bidejki za sekoja linija mora da se vlozhi barem 1,
         * minimalnata vrednost mora da bide barem broj na linii*1
         * i inkrementot mora da se zgolemuva soodvetno na brojot na linii
        */
        private void CalculateNudYourBet()
        {


            if (linesCounter > (int)nudLines.Value)
            {

                float thisIncrement = (float)nudYourBet.Increment;
                float thisBet = (float)nudYourBet.Value;
                thisBet /= linesCounter;
                thisIncrement /= linesCounter;
                thisBet *= (int)nudLines.Value;
                thisIncrement *= (int)nudLines.Value;
                if (thisBet > checkBalance(tbBalance.Text))
                {
                    //check();
                    nudYourBet.Maximum = (decimal)checkBalance(tbBalance.Text);
                }
                else
                {
                    nudYourBet.Value = (decimal)thisBet;
                    nudYourBet.Minimum = (int)nudLines.Value;
                }
                nudYourBet.Increment = (decimal)thisIncrement;
                linesCounter = (int)nudLines.Value;
            }
            else
            {
                float thisIncrement = (float)nudYourBet.Increment;
                float thisBet = (float)nudYourBet.Value;
                thisBet /= linesCounter;
                thisIncrement /= linesCounter;
                thisBet *= (int)nudLines.Value;
                thisIncrement *= (int)nudLines.Value;
                if (thisBet > checkBalance(tbBalance.Text))
                {
                    nudYourBet.Value = (decimal)checkBalance(tbBalance.Text);
                    nudYourBet.Maximum = (decimal)checkBalance(tbBalance.Text);
                }
                else
                {
                    nudYourBet.Value = (decimal)thisBet;
                }
                nudYourBet.Increment = (decimal)thisIncrement;
                linesCounter = (int)nudLines.Value;
            }
        }
        private void btnMaxLines_Click(object sender, EventArgs e)
        {
            for (int i = (int)nudLines.Value; i < (int)nudLines.Maximum; i++)
            {
                nudLines.Value += 1;
            }
        }

        private void nudYourBet_ValueChanged(object sender, EventArgs e)
        {
            if (nudYourBet.Value == (decimal)0)
            {
                btnAutoPlay.Enabled = false;
                btnSpin.Enabled = false;
                btnMaxRaise.Enabled = false;
                nudLines.Value = 1;
                nudYourBet.Value = nudYourBet.Minimum;
                btnMaxLines.Enabled = false;
            }
            else
            {
                nudYourBet.Maximum = (decimal)checkBalance(tbBalance.Text);
                if (nudYourBet.Value > (decimal)checkBalance(tbBalance.Text))
                {
                    btnAutoPlay.Enabled = false;
                    btnSpin.Enabled = false;
                    btnMaxRaise.Enabled = false;
                    nudLines.Value = 1;
                    nudYourBet.Value = nudYourBet.Minimum;
                    btnMaxLines.Enabled = false;
                }
                else
                {
                    btnSpin.Enabled = true;
                    btnAutoPlay.Enabled = true;
                    btnMaxLines.Enabled = true;
                    btnMaxRaise.Enabled = true;
                }
            }
        }

        private void nudAutoPlay_ValueChanged(object sender, EventArgs e)
        {
            if (nudAutoPlay.Value == 0)
            {
                isAutoPlaying = false;
                btnAutoPlay.Text = "Autoplay";
                btnAutoPlay.Enabled = false;
            }
            else
            {
                btnAutoPlay.Enabled = true;
            }
        }

        private void Game_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnSpin, "Click here to SPIN!");
            toolTip1.SetToolTip(btnAutoPlay, "Click here for AUTOPLAY!");
            toolTip1.SetToolTip(nudAutoPlay, "Adjust the number of times to Autoplay!");
            toolTip1.SetToolTip(nudYourBet, "Adjust your bet!");
            toolTip1.SetToolTip(nudLines, "Adjust the number of lines to play");
            toolTip1.SetToolTip(btnMaxRaise, "Click here to bet all your balance!");
            toolTip1.SetToolTip(btnMaxLines, "Click here to play the maximum number of lines!");
            toolTip1.SetToolTip(btnEnd, "Quit the game!");
            toolTip1.SetToolTip(btnHelpAndPayout, "View the payout table and the rules!");
            
        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                btnSpin.PerformClick();
            }
        }

      

        

       

   
    }
}
