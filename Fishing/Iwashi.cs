using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fishing
{
    internal class Iwashi : Fish
    {
        private bool eat = true;
        private PictureBox picture;
        public Iwashi(int x, int y, int speed, int formsizeW, PictureBox picture)
            :base(x, y, speed, formsizeW, picture){
            this.picture = picture;
        }

        public void Sleep()//回遊はするが餌は食べない状態になる
        {
            eat = false;
        }

        public void Wakeup()
        {
            eat = true;
        }

        public override int Eat(int key, PictureBox esa_picture)//0,1,2,3のキーを押したときに餌を食べる
        {
            int score = 0;
            int fish_right = X + picture.Width;//魚の右端の座標
            int esa_rignt = esa_picture.Location.X + esa_picture.Width;//餌の右端の座標
            if (eat == true)
            {
                //魚の画像と餌の画像が完全に重なってから30ピクセルの間ならば
                if (key == 0 || key == 1 || key == 2 || key == 3)
                {
                    if (fish_right >= esa_rignt && fish_right <= (esa_rignt + 30))
                    {
                        //引数のキーがスコアになる
                        score = key;

                        //魚が左端に戻るor見えなくなる
                        picture.Visible = false;
                        //X=0-picture.Width;//左端に戻る
                    }
                }
            }
            
           

            return score;
        }

    }
}
