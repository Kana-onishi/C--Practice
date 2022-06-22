using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fishing
{
    internal class Fish
    {
        private PictureBox picture;

        public Fish(int x, int y, int speed, int formsizeW, PictureBox picture)
        {
            X = x;
            Y = y;
            Speed = speed;
            FormsizeW = formsizeW;
            this.picture = picture;
        }

        public int X { get; set; }
        public int Y { get; set; }
        public int Speed { get; set; }
        public int FormsizeW { get; set; }

        public void Swim(out int x, out int y)
        {

            //現在地をスピード分進める
            X += Speed;

            //右端に着いたら座標をリセット
            if (X >= FormsizeW+picture.Width)
            {
                X = 0-picture.Width;
                if(picture.Visible == false)
                {
                    picture.Visible = true;
                }
            }

            x = X;
            y = Y;
        }
        
        //ピクチャーボックスを移動する
        public void PictureMove(int x, int y)
        {
            picture.Location = new System.Drawing.Point(x, y);
        }

        public virtual int Eat(int key, PictureBox esa_picture)
        {
            int score = 0;
            
            int fish_right = X + picture.Width;//魚の右端の座標
            int esa_rignt = esa_picture.Location.X + esa_picture.Width;//餌の右端の座標
            //魚の画像と餌の画像が完全に重なってから30ピクセルの間ならば
            if(fish_right >= esa_rignt && fish_right <= (esa_rignt + 30))
            {
                //引数のキーがスコアになる
                score = key;

                //魚が左端に戻るor 見えなくなる
                //picture.Visible = false;//見えなくなる
                X = 0 - picture.Width;//左端に戻る
            }

            return score;
        }
    }
}
