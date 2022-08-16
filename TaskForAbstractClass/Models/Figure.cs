using System;
using System.Collections.Generic;
using System.Text;

namespace TaskForAbstractClass.Models
{
    abstract class Figure
    {
        public abstract void CalcArea();
    }

    class Square:Figure
    {
        private double _side;
        public Square(double Side)
        {
            this.Side = Side;
        }
        

        public double Side {
            get 
            {
                return _side;
            }
            set 
            {
                if (value>=0)
                {
                    _side=value;
                }
            }
                        }

        public override void CalcArea()
        {
            Console.WriteLine(Side*Side);
        }
    }

    class Rectangular:Figure
    {
        private double _width;
        private double _length;
       
        

        public double Width {
            get 
            { 
                return _width;
            }
            set 
            {
                if (value>=0)
                {
                    _width = value;
                }
            } 
        }
        public double Length
        {
            get
            {
                return _length;
            }
            set
            {
                if (value >= 0)
                {
                    _length = value;
                }
            }
        }
        public Rectangular(double Width, double Length)
        {
            this.Width = Width;
            this.Length = Length;
        }
        public override void CalcArea()
        {

            Console.WriteLine(_width*_length);
        }
        
    }
}
