using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skillmineproject2.EventsAndDeligets
{
    
    class StuentPassorFail
    {
        public delegate void MyDel();
        public class Stud
        {
            public event MyDel Pass; // declaration of event
            public event MyDel Fail;
            public void Accept(int marks)
            {
                if (marks >= 40)
                {
                    Pass(); //raise an event
                }
                else
                {
                    Fail();
                }
            }
        }
        public static class Message
        {
            public static void PassMessage()
            {
                Console.WriteLine("Great ! you are pass");
            }
            public static void FailMessage()
            {
                Console.WriteLine("Sorry ! you are Fail");
            }
        }
        public class Program
        {

            static void Main(string[] args)
            {
                Stud s1 = new Stud();

                s1.Pass += new MyDel(Message.PassMessage); // bind event with delegate
                s1.Fail += new MyDel(Message.FailMessage);

                Console.WriteLine("Enter the marks");
                int marks = Convert.ToInt32(Console.ReadLine());

                s1.Accept(marks);
            }


        }
    }

}

