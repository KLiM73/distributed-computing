using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class User
    {
        public int countPictures = 0;
        public static List<Picture> picturesList = new List<Picture>();
        public void generatePicture(int width, int height)
        {
            Picture newPicture = new Picture();
            newPicture.width = width;
            newPicture.height = height;
            picturesList.Add(newPicture);
        }
    }
}
