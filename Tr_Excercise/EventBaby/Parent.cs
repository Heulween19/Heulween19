using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBaby
{
    public delegate void EventNewBaby(object sender, NewBabyEventArgs e);

    
    public class Parent
    {
        public event EventNewBaby NewBaby;
        protected virtual void OnNewBAby(NewBabyEventArgs e)
        {
            if (NewBaby != null)
                NewBaby(this, e);
        }

        public void NotifyNewBaby(string Name,string Gender)
        {
            NewBabyEventArgs e = new NewBabyEventArgs(Name,Gender);
            Console.WriteLine($"Baby Info {e.Name} {e.Gender}");
            OnNewBAby(e);
        }
    }
    
    public class NewBabyEventArgs
    {
        public string Name;
        public string Gender;

        public NewBabyEventArgs(string name,string gender)
        {
            Name = name;
            Gender = gender;
        }
    }

}
