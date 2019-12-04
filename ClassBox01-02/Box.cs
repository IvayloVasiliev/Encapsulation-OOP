using System;
using System.Collections.Generic;
using System.Text;

namespace ClassBox01_02
{
    public class Box
    {
        private double length;
        private double width;
        private double hight;

        public Box(double length, double width, double hight)
        {
            Length = length;
            Width = width;
            Hight = hight;
        }

        public double Length
        {
            get => length;
            set
            {
                if (value <= 0.0)
                {
                    throw new ArgumentException();
                }
                length = value;
            }
        }
        public double Width
        {
            get => width; 
            set
            {
                if (value <= 0.0)
                {
                    throw new ArgumentException();
                }
                width = value;
            }
        }
        public double Hight
        {
            get => hight; 
            set
            {
                if (value <= 0.0)
                {
                    throw new ArgumentException();
                }
                hight = value;
            }
        }

        public double GetSurfaceArea()
        { 
            return 2 * Length * Width + 2 * Length * Hight + 2 * Width * Hight;
        }

        public double GetLateralSurfaceArea()
        {
            return 2 * Length * Hight + 2 * Width * Hight;
        }

        public double GetVolume()
        {
            return  Width * Length * Hight;
        }

        public override string ToString()
        {
            return $"Surface Area – {GetSurfaceArea():f2}\nLateral Surface Area – {GetLateralSurfaceArea():f2}"+
                $"\nVolume – { GetVolume():f2}";
        }
    }
}
