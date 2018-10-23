using System;

namespace Polygons.Library
{
    public class ConcreteRegularPolygon
    {
        public int NumberOfSides { get; set; }

        //automatic property^
        //private int _numberOfSides;

        //public int NumberOfSides
        //{
        //    get { return _numberOfSides; }
        //    set { _numberOfSides = value; }
        //}
        //full property but equivelant

        public int SideLength { get; set; }

        public ConcreteRegularPolygon(int sides, int length)
        {
            NumberOfSides = sides;
            SideLength = length;
        }

        public double GetPerimeter()
        {
            return NumberOfSides * SideLength;
        }

        public virtual double GetArea()
        {
            throw new NotImplementedException();
        }
    }
}
