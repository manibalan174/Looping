using System;

namespace access
{
    class Program
    {
    public int xValues=3;    
    private int yValues=2;
    protected int ZValues=4;
    public void Add()
    {
      int TValues= xValues + ZValues;
      Console.WriteLine("Addition:"+ TValues);
    }
     private void Subraction()
    {
    
      int TValues= xValues - yValues;
      int Answer  = TValues - ZValues;
      Console.WriteLine("Subraction:"+ Answer);
    }
     protected void multiple()
    {
      int TValues= xValues * ZValues;
      Console.WriteLine("multiple:"+ TValues);
    }
   // static void Main(string[] mani)
    //{
    //    Program D = new Program();
    //      D.Add();
    //      D.multiple();
   // }
    }

    class Demo : Program
    {
        public void Division()
        {
            int dValues=12,d1Values=13;
            int dAnswser=dValues / d1Values;
            Console.WriteLine("Division:"+dAnswser);
        }
        static void Main()
        {
            Demo D1 = new Demo();
            D1.Add();
            D1.Division();
            D1.multiple();
        }
       }
    }
