using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightProject
{
    public class CircleFactory
    {
        private static Dictionary<string, Circle> _circleMap = new Dictionary<string, Circle>();

        private static string[] colors = new string[] { "Red", "Green", "Blue", "Yellow", "Black", "White" };

        public static Circle GetCircle(string color)
        {
            Circle circle = null;
            if (_circleMap.ContainsKey(color))
            {
                circle = _circleMap[color];
            }
            else
            {
                circle = new Circle(color);
                _circleMap[color] = circle;
                Console.WriteLine($"Creating circle of color : {color}");
            }
            return circle;
        }

        public static string GetRandomColor()
        {
            Random random = new Random();
            return colors[random.Next(colors.Length)];
        }

        public static int GetRandomX()
        {
            Random random = new Random();
            return random.Next(100);
        }

        public static int GetRandomY()
        {
            Random random = new Random();
            return random.Next(100);
        }
    }
}
