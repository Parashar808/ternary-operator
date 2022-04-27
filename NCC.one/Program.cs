using System;
namespace ConsoleApp
{
    public class PRogram{
    public static void Main(){
       Console.WriteLine("i am a boy .");
       test();
        return ;

    }
    public static void test(){
        Console.WriteLine("enter 1 ,2 or 3");
          int inputUser = Convert.ToInt32(Console.ReadLine());
          string result = (inputUser == 1)? "ONE": (inputUser==2)? "two":(inputUser==3)? "three" : "invalid";
        Console.WriteLine(result);

}
    

    }

}