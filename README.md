# Super Fruity Slots – Игра за слот машина

<b>Семинарска задача по предметот Визуелно програмирање</b>


Опис на играта „Super Fruity Slots - Игра за Слот машина“
----------------------------------------

  Семинарската задача ја опфаќа добро познатата игра која луѓето ја играат во казината - Слот машината. 
Целта на оваа игра е да се погодат исти објекти, односно ист вид на овошје или бројот 7 (бројот одсекогаш бил познат во скоро сите игри на слот машините). Со погодок на 3, 4 или 5 исти овошја, играчот добива "пари" во износ од неговиот влог * вредноста за погодениот знак. Кога играчот ќе снема пари, нема да има шанса да "врти".
  Јас играта ја имплементирав многу слично како и другите, а има мноогу голем број на игри за слот машина, со разлика на тоа дека во Super Fruity Slots нема можност за бесплатни вртења и нема Joker знак (знак кој се совпаѓа со сите други). Постојат 8 видови на овошје во играта како и бројот 7. Овошјата се: Банана, Цреша, Грозје, Јаболко, Круша, Лимон, Портокал и Слива.

Објаснување на имлементацијата на играта
----------------------------------------

Играта е изработена во програмскиот јазик C#. Се состои од четири прозори (форми). 
Главната форма (првата форма) е главното мени каде се гледаат три можни опции:

  * <b>Play</b> – копче за почеток на нова игра
  * <b>Rules / Payout</b> – копче за информации за правилата на играта, кои се линиите на кои се игра играта, и која е добивката од 3,4,5 исти овошја на една линија (за влог "1").
  * <b>Quit</b> – копче за излез од играта

<img src="http://imagizer.imageshack.us/v2/614x425q90/673/ET8koc.png"/>

Со кликање на опцијата <b><i>Play</i></b> се отвара втората форма во која е сместена самата игра. За почеток на играта, играчот добива бесплатни 500 кредити за да може да почне со играњето. 
Во оваа форма има повеќе копчиња кои корисникот може да ги селектира, како и неколку Numeric UpDown контроли за селектирање на бројот на линии, влогот, и опцијата за автоматско играње (Autoplay).
Копчињата кои може да се селектираат се:
  * <b>Quit Game</b> - копче за завршување на играта и враќање во главното мени.
  * <b>Max Lines</b> - копче за селектирање на максималниот број на линии за играње (15).
  * <b>Bet MAX</b> - копче за селектирање на максималниот влог за следното вртење (максимумот е секако целата билансна состојба).
  * <b>Autoplay</b> - копче кое со селектираниот број на игри врти без помош или интеракција со корисникот и работи на истиот начин како кога корисникот сам би играл.
  * <b>Spin</b> - копче со кое корисникот означува почеток на ново вртење со бројот на линии и влогот.
  * <b>Buy more credits?</b> - копче со кое се отвара нова форма за купување кредити во случај корисникот да ги изгуби неговите при играње.
  * <b>Rules / Payout</b> - копче за навигација во нова форма (истата ја има и во главното мени) каде што корисникот може да се запознае со правилата на играње, кои се линиите на кои се игра играта, и која е добивката од 3,4,5 исти овошја на една линија (за влог "1").
  
<img src="http://imagizer.imageshack.us/a/img537/957/wZVb3m.png"/>

  При првото уклучување на играта, сите слики се поставени на прашалници, додека при кликање на копчето <b><i>Spin</i></b>, или на SPACE на тастатурата (користење на Space е исто како и кликање на копчето Spin), играта после првото вртење ги заменува прашалниците со вистински вредности. Истото може да се случи и со кликање на копчето <b><i>Autoplay</i></b>.

<img src="http://imagizer.imageshack.us/a/img673/768/CJntgV.png"/>

  Во групата <b>Balance</b> во долниот лев дел на апликацијата, играчот може да види колку има преостанат кредит со кој може да игра.
  
  Лево од копчето за Rules / Payout корисникот може да види колку кредити добил од неговото последно вртење.
  
За играта да изгледа дека е слична со тие што вистински можат да се играат во казината, на десната страна на играта има рачка која ќе се анимира на секое вртење, и ќе изгледа како човекот да ја повлекол самата рачка.

Кога корисникот ќе сврти и ќе погоди овошја, тој ќе ја добие вредноста за неговата добивка како и визуелен приказ на која линија ги погодил овошјата (секоја линија кореспондира со сопствена боја). Овој приказ ќе се чува на екранот се додека не се изведе следно вртење.

<img src="http://imagizer.imageshack.us/a/img912/5908/iMPhZH.png"/>

Кога играчот не е сигурен на која линија да игра, или воопшто кои се линиите, со кликање на копчето <b><i>Rules / Payout</i></b> тој може да ја отвори следната форма за приказ на сите информации за помош. Таа се состои од приказ за добивките за секое овошје и бројот седум, слика за тоа кои линии каде даваат добивка, и How to Play помош, како и копче <b><i>Close</i></b> со кое се гаси формата и играчот се враќа во главниот прозорец за играње.

<img src="http://imagizer.imageshack.us/a/img913/4783/O9fGgV.png"/>

Кога играчот ќе ги изгуби сите кредити со кликање на копчето <b><i>Buy more credits?</i></b>, тој ја отвара формата за купување на кредити, а таа е едноставна форма која валидира дали се внесени цифри и дали вредноста на цифрите е поголема од 0. Оваа форма има едно копче: 
  * <b><i>Proceed</i></b> - копче за валидирање на внесената вредност и продолжување кон прозорот за играње со ново "купените" кредити.

<img src="http://imagizer.imageshack.us/a/img905/7330/QZ19PL.png"/>



Подетален опис за изворниот код
-------------------------------

Најголемиот проблем при имплементирање на играта беше начинот на кој сликите ќе ги добиваат своите вредности, и потоа калкулирање на нивната добивка како и исцртување на линиите на кои е добиена добивка.
Овој проблем е решен со имплементирање на листа од слики кои со Timer и Random вредности ротираат во циклуси за накрај да ги добијат нивните последни вредности и тие да се пратат на функција за пресметување на добивка, функција која од сликите има нивни кореспондирачки добивки за 3,4,5 линии. Во оваа функција вредностите од сликите се споредуваат и доколку има погодок се зголемува вредноста на добивката (Влог * добивка за 3,4 или 5 линии).
Доколку постои добивка на формата се исцртуваат линии со координати кои кореспондираат со тие на сликите поставени на формата и играчот добива приказ на тоа која линија ја погодил. Сликите се цртаат со користење на Graphics.DrawLine функцијата и се пребришуваат при секое ново вртење.

Во функцијата подоле, односно настанот каде што Тајмерот за вртење е активиран, се случува големиот дел од програмата односно претставување на сликите за вртење пред корисникот чии вредности понатаму се препраќаат во друга функција чија должност е пресметување на целата добивка и исцртување на линиите. Настанот во кодот доле се дели на два дела, едниот дел е кога играчот ќе го кликне копчето <b>Spin</b>, а другиот кога ќе го кликне копчето <b>Autoplay</b>. Едниствената работа која дава до знаење што е кликнато е променливата <b>```isAutoPlaying```</b>. Кога таа е ```false```, промената на сликите и пресметките се врши еднаш, а ако е ```true``` пресметката се врши и повторува за бројот на вртења кој е селектиран пред да се кликне копчето <b>Autoplay</b>. Истотака треба да се напомене дека кога играчот ќе ја користи Autoplay функцијата на играта, пред секое вртење освен првото, има мал временски период на чекање (направен со друг ```Timer```) за да му даде на играчот доволно време да ви дали погодил некоја линија и да види која е таа. 
За да се добие визуелна слика дека сликите се вртат подолго време, тајмерот ги врти и ре-пресметува повеќе пати пред да ги добијат нивните последни вредности пред пресметка на добивката.
```c#
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
```
Со функција наречена ```CalculateNudYourBet```, јас го зголемувам влогот пропорционално со бројот на линии, што значи дека од 1$, тој на 15 линии ќе се зголеми на 15$ итн, истотака бидејќи користам броеви со децимална запирка, инкрементирањето на влогот ќе се зголеми истотака пропорционално, така што ако на една линија се зголемувал за 0,20$, за две линии зголемувањето ќе биде 0,40$ итн.
<br>Иако немора, во Super Fruity Slots оставив можност да се вложува помалку од зададените линии, односно дури и со 1$ смее да се игра на сите 15 линии за играта да остане интересна.

Уште една функција која би сакал да ја објаснам е функцијата односно настанот за кликање на копчето за Autoplay, каде што предходно треба да биде селектиран бројот на пати кој корисникот би сакал автоматски да се одиграат. Идејата за оваа функција е секако автоматски да може да се игра, но ако играчот сака да прекине и тој да го притисне копчето за Spin, во секој момент да може да го прекине вртењето (секако ако во истиот момент веќе се врти, треба да заврши постоечкото вртење). Затоа кога копчето Autoplay е стисната, неговото име се менува во Stop, и обратно. Истотака се менуваат и вредностите за ```isAutoplaying``` кој е објаснет во примерот погоре. Потоа треба да се провери дали уствари играчот со неговите вредности има можност да врти повеќе пати, и ако играчот внел повеќе пати да врти отколку што вистински може, бројот на автоматски вртења да се промени соодветно. Затоа се проверува влогот, и ако тој помножен со бројот на автоматски вртења е поголем од билансот, преку функцијата ```MaxSpins(string balance,float bet)``` да се добие бројот на можни вртења откако ќе се парсира билансот секако, ```(int)((float)balance / bet)```.
<br>Откако ќе се добијат сите овие вредности, се превзема влогот и ако бројот на вртења од предходната функција е поголем од 0, процедурата на автоматски вртења може да започне, а ако е обратно тоа нема да се случи и копчето за Autoplay ќе биде оневозможено се додека не се добијат коректни вредности.
```c#
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
```

Изработил
--------------

Стефан Пешиќ - 133048

Оваа игра е развиена само за образовни цели!
