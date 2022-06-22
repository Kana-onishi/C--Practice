using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fishing
{
    public partial class FormGame : Form
    {
        //フィールド
        private Iwashi iwashi;              //イワシクラスのインスタンス
        //private Utsubo utsubo;　　　　　　　//ウツボクラスのインスタンス
        private Ankou ankou;                //アンコウクラスのインスタンス
        private int remainingTime = 600;    //残り時間(60秒×1000ms÷100ms周期)
        private bool isDayTime = true;      //昼間はtrue
        private int daytime = DayTime;      //昼間の時間
        private int night = NightTime;      //夜の時間
        private int score = 0;              //得点
        private const int IwashiSpeed = 20; //イワシのスピード
        //private const int UtsuboSpeed = 10; //ウツボのスピード
        private const int AnkouSpeed = 10;   //アンコウのスピード
        private const int DayTime = 100;    //昼間の時間(10秒)
        private const int NightTime = 50;   //夜の時間(5秒)
        public FormGame()
        {
            InitializeComponent();
        }

        private void FormGame_Load(object sender, EventArgs e)
        {
            int formSizeW = this.ClientSize.Width;

            //魚のインスタンスの生成
            int x = pictureBoxIwashi.Location.X;
            int y = pictureBoxIwashi.Location.Y;
            iwashi = new Iwashi(x, y, IwashiSpeed, formSizeW, pictureBoxIwashi);

            //x = pictureBoxUtsubo.Location.X;
            //y = pictureBoxUtsubo.Location.Y;
            //utsubo = new Utsubo(x, y, UtsuboSpeed, formSizeW, pictureBoxUtsubo);

            x = pictureBoxAnkou.Location.X;
            y = pictureBoxAnkou.Location.Y;
            ankou = new Ankou(x, y, AnkouSpeed, formSizeW, pictureBoxAnkou);
        }

        //魚が泳ぐ
        private void SwimFish()
        {
            //魚が泳ぎピクチャーボックスの位置を進める
            iwashi.Swim(out int x1, out int y1);
            iwashi.PictureMove(x1, y1);
            //utsubo.Swim(out int x2, out int y2);
            //utsubo.PictureMove(x2, y2);
            ankou.Swim(out int x3, out int y3);
            ankou.PictureMove(x3, y3);
        }

        //「スタートボタン」クリックのイベントハンドラ
        private void buttonStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
            buttonStart.Enabled = false;

            //魚が泳ぐ
            SwimFish();
        }

        //「タイマー」Tickのイベントハンドラ
        private void timer1_Tick(object sender, EventArgs e)
        {
            //残り時間の表示(100ms単位で起動されるので10で割る) 
            remainingTime--;
            labelRemaining.Text = "残り時間：" + (remainingTime / 10) + "秒";

            if(isDayTime == true) //昼間
            {
                daytime--;
                //昼間終わり
                if(daytime == 0)
                {
                    isDayTime = false;      //夜にする
                    iwashi.Sleep();         //イワシは寝る
                    //utsubo.Sleep();         //ウツボは寝る
                    daytime = DayTime;      //昼間の時間の初期化
                    BackColor = Color.MidnightBlue;
                }
            }
            else  //夜
            {
                night--;
                //夜終わり
                if(night == 0)
                {
                    isDayTime = true;       //昼間にする
                    iwashi.Wakeup();        //イワシは起きる
                    //utsubo.Wakeup();        //ウツボは起きる
                    night = NightTime;      //夜の時間の初期化
                    BackColor = Color.LightSkyBlue;
                }
            }

            //時間切れ
            if(remainingTime / 10 == 0)
            {
                timer1.Stop();
                labelRemaining.Text = "ゲームオーバー";
            }
            else
            {
                //魚が泳ぐ
                SwimFish();
            }
        }

        //「ゲームフォーム」キー押下のイベントハンドラ
        private void FormGame_KeyPress(object sender, KeyPressEventArgs e)
        {
            //数字キーを押下した
            if (e.KeyChar >= '1' && e.KeyChar <= '9')
            {
                //餌を食べる
                score += iwashi.Eat(int.Parse(e.KeyChar.ToString()), pictureBoxEsaS);
                //score += utsubo.Eat(int.Parse(e.KeyChar.ToString()), pictureBoxEsaM);
                score += ankou.Eat(int.Parse(e.KeyChar.ToString()), pictureBoxEsaL);

                labelScore.Text = "得点：" + score;
            }
        }
    }
}
