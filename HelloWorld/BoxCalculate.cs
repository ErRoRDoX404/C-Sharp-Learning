using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class BoxCalculate
    {
        static void NotMain(string[] args) // Change "NotMain" to "Main" to use
        {
            Box box1 = new Box();
            box1.Length = 5;
            box1.Height = 3;
            box1.Width = 4;
            box1.DisplayInfo();
        }
    }
}
