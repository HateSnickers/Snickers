using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPlayground
{
    internal class Rectangle
    {
            public float width;
            public float height;

            public Rectangle(float width, float height)
            {
                SetDimensions(width, height);
            }

            public void SetDimensions(float newWidth, float newHeight)
            {
                if (newWidth > 0 && newHeight > 0)
                {
                    width = newWidth;
                    height = newHeight;
                }
                else
                {
                    Console.WriteLine("Šířka a výška musí být kladné hodnoty.");
                }
            }

            public float CalculateArea()
            {
            float WidthForCalc = width;
            float HeightForCalc = height;
            float Calc = WidthForCalc * HeightForCalc;
            Console.WriteLine($"Obdélník má obsah {Calc}cm2");
            return Calc;

            }

            public void DetermineRectangleType()
            {
                if (width > height)
                {
                    Console.WriteLine("Obdélník je na ležato (landscape).");
                }
                else if (height > width)
                {
                    Console.WriteLine("Obdélník stojí (portrait).");
                }
                else
                {
                    Console.WriteLine("Je to čtverec (square).");
                }
            }
            
    }
}
