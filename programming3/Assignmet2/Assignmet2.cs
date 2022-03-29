using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    #region Person
    public class Person
    {
        protected int age;  //an field

        //age setter
        public void SetAge(int age)
        { this.age = age; }


        //Greet function
        public void Greet()
        {
            Console.WriteLine("Hello");
        }
    }
    #endregion

    #region Professor
    public class Professor : Person
    {
        public void Explain() //Explain method
        {
            Console.WriteLine("I'm explaining on the screen");
        }
    }
    #endregion

    #region Student
    public class Student : Person
    {
        public void Study()     //study method
        {
            Console.WriteLine("I'm studying");
        }

        public void ShowAge()   //showAge method
        {
            Console.WriteLine($"My age is: {age} years old");
        }
    }
    #endregion

    #region StudentProfessorTest
    internal class StudentProfessorTest
    {
        static void Main(string[] args)
        {
            Person person = new Person();       //an object form Person Class
            person.Greet();                     //calling Greet method

            Console.WriteLine("---------------------------------------------------");

            Student student = new Student();        //an object from Student Class
            student.SetAge(20);                     //calling SetAge method
            student.Greet();                        //calling Greet method
            student.ShowAge();                      //calling ShowAge method

            Console.WriteLine("---------------------------------------------------");

            Professor professor = new Professor();        //an object form Professor Class
            professor.SetAge(35);                        //calling setAge method
            professor.Greet();                          //calling Greet method
            professor.Explain();                       //calling Explain method

            Console.WriteLine("---------------------------------------------------");
        }
    }
    #endregion
}
