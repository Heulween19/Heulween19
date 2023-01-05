using System;

namespace EventBaby
{
    public class Program
    {
       public static void CallFriend(object sender, NewBabyEventArgs e)
        {
            Console.WriteLine("Send a message...");
        }
        static void Main(string[] args)
        {
            Parent p = new Parent();
            p.NewBaby += CallFriend;
            p.NotifyNewBaby("Baby", "Male");

            Console.ReadKey();

        }
    }
}
