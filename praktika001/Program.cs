// string line = Console.ReadLine(); // ввод числа в десятеричной системе 
// int x0 = (int.Parse(line));
// int x = Math.Abs(x0);
// int x1 = 0;
// int x2 = 0;
// int x3 = x;
// // Stack<string> massiv = new Stack<string>();
// List<string> massiv = new List<string>();

// while (x >= 10)
// {
//     x1 = x / 16;
//     x2 = x % 16;
//     if (x2 == 10)
//     {
//         massiv.Add("A");
//     //     massiv.Push("A");
//     }
//     else if (x2 == 11)
//     {
//         massiv.Add("B");

//         // massiv.Push("B");
//     }
//     else if (x2 == 12)
//     {
//         massiv.Add("C");
//         // massiv.Push("C");
//     }
//     else if (x2 == 13)
//     {
//         massiv.Add("D");
//         // massiv.Push("D");
//     }
//     else if (x2 == 14)
//     {
//         massiv.Add("E");
//         // massiv.Push("E");
//     }
//     else if (x2 == 15)
//     {
//         massiv.Add("F");
//         // massiv.Push("F");
//     }

//     else
//     {
//         massiv.Add(Convert.ToString(x2));
//         // massiv.Push(Convert.ToString(x2));
//     }
//     x = x / 16;
// }
// if(x0<0)Console.Write("-");
// while(x3<=9 && 0<=x3 && x0>=0)
// {
//     Console.Write(x3); 
//     break;
// }
// if(x1>0)Console.Write(x1);
// if(x3>=10)
// {  
// massiv.Reverse();
// foreach (var person in massiv)
// {
//     Console.Write(person);
// }
// // foreach (var person in massiv) Console.Write(person);
// }

using System;

public class MainClass
{
    public static string IntToHex(int x)
    {
        string hex = string.Empty;
        var digits = new string[]{"0","1","2","3","4","5","6","7","8","9","a","b","c","d","e","f"};
        
        if(x < 16) { return digits[x];}

        while(x > 0)
        {
            var i = x % 16;
            hex = digits[i] + hex;
            x /= 16;
        }
        
        return hex;
    }
    
    public static void Main()
    {
        string line = Console.ReadLine();
        int x = int.Parse(line);
        Console.WriteLine(IntToHex(x));
    }
}