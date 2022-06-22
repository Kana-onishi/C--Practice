using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fishing
{
    internal class Ankou:Fish
    {
        private PictureBox picture;
        public Ankou(int x, int y, int speed, int formsizeW, PictureBox picture)
            : base(x, y, speed, formsizeW, picture) { this.picture = picture; }

        public override int Eat(int key, PictureBox picture)
        {
            return base.Eat(key, picture);
        }
    }
}
