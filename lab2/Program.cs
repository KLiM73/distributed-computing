using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            User User1 = new User();
            int isRandom, newWidth, newHeight;
            Console.WriteLine("Выберите режим работы приложения:");
            Console.WriteLine("\n1. Автоматический (Количество картинок и их размеры выбираются рандомно)");
            Console.WriteLine("\n2. Ручной (ручное задание параметров)");
            isRandom = Convert.ToInt16(Console.ReadLine());
            Random rand = new Random();
            Resizer Res = new Resizer(rand.Next(1,500), rand.Next(1,500));

            /*Генерация картинок*/
            if (isRandom == 1)
            {
                
                User1.countPictures = rand.Next(1, 10);

                for (int i = 0; i < User1.countPictures; i++)
                {
                    User1.generatePicture(rand.Next(1, 500), rand.Next(1, 500));
                }
            } else
            {
                Console.WriteLine("\nВведите количество генерируемых картинок:");
                User1.countPictures = Convert.ToInt16(Console.ReadLine());
                int width, height = 0;
                for (int i = 0; i < User1.countPictures; i++)
                {
                    Console.WriteLine("\nВведите ширину " + (i+1) + " картинки");
                    width = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("\nВведите высоту " + (i+1) + " картинки");
                    height = Convert.ToInt16(Console.ReadLine());

                    User1.generatePicture(width, height);

                    Console.WriteLine("\nВведите требуемую ширину картинок");
                    newWidth = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("\nВведите требуемую высоту картинок");
                    newHeight = Convert.ToInt16(Console.ReadLine());
                }
            }
            int picturesCounter = 1;
            Console.WriteLine("\nИсходные картинки:");
            foreach (Picture i in User.picturesList)
            {

                Console.WriteLine("\nКартинка №" + picturesCounter + ", высота:" + i.height + ", ширина:" + i.width);
                picturesCounter++;
            }
            

            Thread myThread = new Thread(Res.resize);
            myThread.Start();
            myThread.Join();
            Console.ReadLine();
        }
    }
}
