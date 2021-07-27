//1.Events

//Create multiple  string manipulation methods like
//a ) Removes white spaces with underscore 
//b)  String reverse 
//c)  join multiple strings 
//d)  find the character and number of occurrence in a string /  text 
//Try to access these methods using Events 

namespace Day15_1
{


    public class Program
    {

        static void Main(string[] args)
        {



            //creating objects for first event
            //Handler handler = new Handler();
            //Notification notification = new Notification();
            //handler.MyEvent += notification.WhiteSpaceEvent;
            //handler.MyEvent += notification.ReverseStringEvent;//calling another event because we made delegate to point for 2 functions
            //handler.WhiteSpace();

            //creating object for second event
            Handler handler = new Handler();
            Notification notification = new Notification();
            handler.MyEvent += notification.ReverseStringEvent;
            handler.ReverseString();









            //creating object for  delegates
            //to find out white space
            //Handler obj = new Handler();
            //StringMethod del = new StringMethod(obj.WhiteSpace);
            //del();

            //string reverse
            //Handler obj = new Handler();
            //StringMethod del = new StringMethod(obj.ReverseString);
            //del();

            //find the character and number of occurrence in a string /  text 
            //Handler obj = new Handler();
            //StringMethod del = new StringMethod(obj.OccurenceMethod);
            //del();


            //for join method
            //Handler obj = new Handler();
            //StringMethod del = new StringMethod(obj.JoinMultipleString);
            //del();









            //for multiple delegate , follow syntax only because, multiple delegate contains same input for all the methods
            //StringMethod del = new StringMethod(obj.WhiteSpace);
            //del += obj.ReverseString; 
            //del += obj.OccurenceMethod;
            //del(str);

        }

    }
}
