using System;

namespace Day15_1
{
    public class Notification
    {


        public void WhiteSpaceEvent()
        {
            Console.WriteLine("from white space event");
        }
        public void ReverseStringEvent()
        {
            Console.WriteLine("from reverse string event");
        }
        public void JoinStringEvent()
        {
            Console.WriteLine("from join string event");
        }
        public void OccurenceEvent()
        {
            Console.WriteLine("from character occurence event");
        }


        //public event StringMethod StringMethodEventHandler;
        //public void NotifyStringMethod(string x)
        //{
        //    if (StringMethodEventHandler != null)
        //    {
        //        StringMethodEventHandler(x);
        //    }
        //}
    }
}
