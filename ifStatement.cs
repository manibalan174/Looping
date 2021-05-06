using System;

namespace IfStatemnet
{
    class Program
    {
        public void Meals()
        {
            Console.WriteLine("1.Unlimated Meal \n 2.limated Meal \n 3.Chicken Briyani \n 4.Mutton Briyani \n 5.variety Rice  \n Enter One Option");
            int mealMenu=Convert.ToInt32(Console.ReadLine());
            if(mealMenu == 1)
            {
                Console.WriteLine("! Your Order is Unlimated Meal ! ");
            }
            else if(mealMenu == 2)
            {
                Console.WriteLine("! Your Order is limated Meal ! ");
            }
            else if(mealMenu == 3)
            {
                Console.WriteLine("! Your Order is Chicken Briyani ! ");
            }
             else if(mealMenu == 4)
            {
                Console.WriteLine("! Your Order is Mutton Briyani ! ");
            }
             else if(mealMenu == 5)
            {
                Console.WriteLine("! Your Order is variety Rice ! ");
            }
             else if(mealMenu == 6)
            {
                Console.WriteLine("! You Have  Order All 5 Items ! ");
            }
            if(mealMenu == 0 || mealMenu >= 7)
            {
                  Console.WriteLine("! Please Enter Given 5 Option Any one ! ");
            }
        }
           public void Dinner()
           {
              Console.WriteLine("1.Parota \n 2.Thosa \n 3.Idlye \n 4.Chapathi \n 5.Fried Rices 6.All Items  \n Enter One Option");
            int dinnerMenu=Convert.ToInt32(Console.ReadLine());
            switch(dinnerMenu){
                 case 0:
                  Console.WriteLine("! Enter Given 5 Option Any one ! ");
                  break;
                case 1:
                  Console.WriteLine("! Your Order Parota ! ");
                  break;
                case 2:
                  Console.WriteLine("! Your Order is Thosa ! ");
                  break;
                case 3:
                  Console.WriteLine("! Your Order is Idlye ! ");
                  break;
                case 4:
                  Console.WriteLine("! Your Order is Chapathi ! ");
                  break;
                case 5:
                  Console.WriteLine("! Your Order is Fried Rices  ! ");
                  break;
                case 6:
                  Console.WriteLine("! You Have  Order All 5 Items ! ");
                  break;
                case  > 6:
                  Console.WriteLine("! Please Enter Given 5 Option Any one ! ");
                  break;
                // default:
                //     Console.WriteLine("! Enter Given 5 Option Any one ! ");
                // break;
           }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("1. Meals \t 2.Dinner \n Please Enter One Option");
            int Values=Convert.ToInt32(Console.ReadLine());
             Program P = new  Program();
             if(Values == 0 || Values >= 3)
             {
               Console.WriteLine("! Please Enter Given 2 Option Any one ! ");
             }
            else if(Values == 1)
            {
                P.Meals();
            }
            else
            {
                 P.Dinner();
            }
        }
    }
}    
