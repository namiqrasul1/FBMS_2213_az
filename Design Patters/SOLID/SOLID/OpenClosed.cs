﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{

    //    /// <summary>
    //    /// Bad Example
    //    /// </summary>

    //    //public class Circle
    //    //{
    //    //    public double Radius { get; set; }
    //    //}

    //    //public class Rectangle
    //    //{
    //    //    public double Height { get; set; }
    //    //    public double Width { get; set; }
    //    //}

    //    //public class Triangle
    //    //{
    //    //    // some code
    //    //}

    //    //public class Calc
    //    //{
    //    //    public double CalcArea(object figure)
    //    //    {
    //    //        if (figure is Rectangle r)
    //    //            return r.Height * r.Width;
    //    //        else if (figure is Circle c) 
    //    //            return 3.14 * c.Radius * c.Radius;
    //    //        throw new ArgumentException("it is not figure");
    //    //    }
    //    //}

    //    /// <summary>
    //    /// Good Example
    //    /// </summary>
    //    /// 

    //    public interface ICalcArea
    //    {
    //        double CalcArea();
    //    }
    //    public class Circle : ICalcArea
    //    {
    //        public double Radius { get; set; }

    //        public double CalcArea() => 3.14 * Radius * Radius;
    //    }

    //    public class Rectangle : ICalcArea
    //    {
    //        public double Height { get; set; }
    //        public double Width { get; set; }

    //        public double CalcArea() => Height * Width;
    //    }

    //    public class Triangle : ICalcArea
    //    {
    //        // some code
    //        public double CalcArea()
    //        {
    //            throw new NotImplementedException();
    //        }
    //    }

    //    public static class Calc
    //    {
    //        public static double CalcArea(ICalcArea figure) => figure.CalcArea();
    //    }

    //    /// <summary>
    //    /// Bad Exaple
    //    /// </summary>

    public class Developer
    {
        public static int GlobalId = 0;
        public class PositionInfo
        {
            public double Bonus { get; set; }
            public string Name { get; set; }

            public PositionInfo() { }

            public PositionInfo(string name, double bonus)
            {
                Bonus = bonus;
                Name = name;
            }
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public PositionInfo Position { get; set; }

        public double Salary { get; set; }


        public double CalcBonus() => Salary * Position.Bonus;

        public Developer() { }


    }

    public class Program
    {


    }
}
