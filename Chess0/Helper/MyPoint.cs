﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess0.Helper
{

    public class MyPoint
    {
        private double x;
        public double X { get => x; set=>x=value; }

        private double y;
        public double Y { get=>y; set=>y=value; }


        public MyPoint(double x, double y)
         {
            X = x;
            Y = y;
         }

        public static MyPoint operator /(MyPoint a, double b)
        {
               return new MyPoint(a.X / b, a.Y / b);
        }

        public static MyPoint operator -(MyPoint a, MyPoint b)
        {
            return new MyPoint(a.X - b.X, a.Y - b.Y);
        }

         public static MyPoint operator *(MyPoint a, double b)
         {
                return new MyPoint(a.X * b, a.Y * b);
         }


         public static MyPoint operator *(MyPoint a, MyPoint b)
         {
            return new MyPoint(a.X * b.X, a.Y * b.Y);
         }

        public static MyPoint operator +(MyPoint a, MyPoint b)
            {
                return new MyPoint(a.X + b.X, a.Y + b.Y);
            }

        public static bool operator ==(MyPoint a, MyPoint b)
        {
            if (Object.ReferenceEquals(a, null))
                return Object.ReferenceEquals(b, null);
            else if(Object.ReferenceEquals(b, null))
                return Object.ReferenceEquals(a, null);


            return a.X == b.X && a.Y == b.Y;

        }
        public static bool operator !=(MyPoint a, MyPoint b)
        {
           
                return !(a==b);
          
        }

        public override bool Equals(object obj)
        {


            return this == obj as MyPoint;

        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
    
}
