using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace lab2
{
    class Resizer
    {
        int w;
        int h;
        public Resizer(int w, int h)
        {
            this.w = w;
            this.h = h;
        }
        public void resize()
        {


            foreach (Picture i in User.picturesList)
            {
                i.width = w;
                i.height = h;
            }

            Console.WriteLine("\nКартинки после ресайза:");
            int picturesCounter = 1;
            foreach (Picture i in User.picturesList)
            {
                Console.WriteLine("\nКартинка №" + picturesCounter + ", высота:" + i.height + ", ширина:" + i.width);
                picturesCounter++;
            }
        }
    }
}
