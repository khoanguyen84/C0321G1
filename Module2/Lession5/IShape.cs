namespace Lession5
{
    public interface IMath{

    }
    public interface IShape{
        double GetArea();
        double GetPrimer();
    }


    public class Rectangle : IShape{
        public double Length;
        public double Width;
        public Rectangle(double length, double width){
            Length = length;
            Width = width;
        }
        public double GetArea(){
            return (Length + Width) *2;
        }
        public double GetPrimer(){
            return Length*Width;
        }
    }

    public class Square : Rectangle, IShape, IMath
    {
        public double Side;
        public Square(double side1, double side2): base(side1, side2){

        }

        public double GetArea(){
            return 2*Side;
        }
    }
}