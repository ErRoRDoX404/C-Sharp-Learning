using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Box
    {
        private int length;
        private int height;
        private int width;
        private int volume;

        public int Length
        {
            get => length;
            set => length = value;
        }

        public int Height
        {
            get => height;
            set => height = value;
        }

        public int Width
        {
            get => width;
            set => width = value;
        }

        public int Volume 
        {
            get => Height * Width * Length;
            set => volume = value;
        }


        /*
        public void SetLength(int length)
        {
            this.length = length;
        }

        public int GetLength()
        {
            return this.length;
        }
        */

        public void DisplayInfo()
        {
            Console.WriteLine("Length is {0}, Height is {1}, Width is {2}, so the Volume is {3}.", 
                Length, Height, Width, Volume);
            Console.ReadKey();
        }
    }
}
