// using System;
// class Program
// {
//     static void Main(string[] args)
//     {
//         double v_max = double.Parse(Console.ReadLine());
//         double v_drink = double.Parse(Console.ReadLine());
//         double v_fill = double.Parse(Console.ReadLine());

//         int t_drink = int.Parse(Console.ReadLine());
//         int t_fill = int.Parse(Console.ReadLine());
//         int t_day = int.Parse(Console.ReadLine());
    
//         double water_left = Water(ref v_max,ref v_drink, ref v_fill, ref t_drink,ref t_fill,ref t_day);
//         if(t_sum == t_day && v_left > v_max)
//         {
//         Console.WriteLine("Enough Water, {0} left",water_left);
//         }
    
//     }


//     static double Water(ref double a,ref double b,ref double c,ref int t_drink,ref int t_fill,ref int t_day)
//     {
//         int v_use = (int)(a/b);
//         int t_sum = v_use*t_drink;
//         double v_left = a-(v_use*b);
//         if((c + v_left) <= a)
//         {
//             double v_refilled = c + v_left;
//             if(v_refilled < b)
//             {
//                 v_refilled = v_refilled + c;
//                 t_sum = t_sum + t_fill;
//             }
//             if(v_refilled >= b)
//             {
//                 if(t_sum + t_drink <= t_day)
//                 {
//                     t_sum = t_sum + t_fill;
//                     Water(ref v_refilled,ref b,ref c);
//                 }
//                 if(t_sum + t_drink > t_day)
//                 {
//                     return v_left;
//                 }
//             }
            
//         }

      
//     }
// }
using System;

class Program
{
    static void Main()
    {
        // Input floating-point numeric types
        Console.Write("Enter the max capacity of the water container: ");
        double Vmax = double.Parse(Console.ReadLine());

        double totalDrinkingWater = 0;

        // Input drinking water for three sessions
        for (int i = 1; i <= 3; i++)
        {
            Console.Write("Enter the amount of drinking water in session {0}: ", i);
            double Vdrink = double.Parse(Console.ReadLine());
            totalDrinkingWater += Vdrink;
        }

        Console.Write("Enter the amount of filling water: ");
        double Vfill = double.Parse(Console.ReadLine());

        // Input integral numeric types
        Console.Write("Enter the time used for drinking water: ");
        int tdrink = int.Parse(Console.ReadLine());

        Console.Write("Enter the time used for refilling water: ");
        int tfill = int.Parse(Console.ReadLine());

        Console.Write("Enter the total time in the day: ");
        int tday = int.Parse(Console.ReadLine());

        // Calculate remaining water
        double Vleft = Vmax - totalDrinkingWater;

        // Check conditions
        if (totalDrinkingWater <= Vmax && tdrink * 3 <= tday && tfill <= tday && Vleft <= Vmax)
        {
            // Check if there is enough water for the day
            if (Vleft >= (Vfill * (tday / (tdrink + tfill)) * 3))
            {
                Console.WriteLine("Enough Water, {0} left", Vleft);
            }
            else
            {
                Console.WriteLine("Not Enough Water");
            }

            // Check if there is overflow when refilling
            if (Vfill * (tday / tfill) * 3 > Vmax)
            {
                Console.WriteLine("Overflow Water");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please make sure all conditions are met.");
        }
    }
}
