using System;

namespace CG3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Here are definitions of statement, expression, operand, and operators:

            //A statement is a complete thought in a line of code.  It is made up of one or more expressions which in turn is   
            //comprised of operators and operands and will perform some kind of action.  An example of a statment is:
            //Console.WriteLine("What is your name?");

            //An expression names something which is called the operand and provides an action and instructions in the statement.   
            //An expression must have an operand which is the subject but may or may not have an operator.  The subject is provided
            //by the programmer.  An example of an expression is: 
            //Console.WriteLine  or  x + 5

            //An operand is the subject similar to a noun in English.  It is the object or subject of the statement and is typically provided 
            //by the programmer.  An  example of an operand is:
            //myFirstname=Console.ReadLine();  with myFirstname and Console being the operand

            //An operator is a symbol that specifies what is requested or required to perform.  Similar to a verb, it asks for action. 
            //An example of an operator is:
            //myFirstname = Console.ReadLine();  with the =, (), and ; as the operators

            //Code comments are text that explain what the programmer is accomplishing in their following lines of code.
            //They begin with // then the text.  An example of code comments is:
            //Fist ask input from the user for their name. (this is the code comment)
            //Console.WriteLine("What is you name?");      (this is the code)

            //Below is a program to demonstrate the use of statement, expression, operator, and operand along with code comments.

            //First ask the user their name.
            Console.WriteLine("What is you name?");
            //Ask the user to input their name.
            Console.WriteLine("Type your first name");
            //Have the name output to the console.
            string myFirstName = Console.ReadLine();

            //Ask the user to input the last name and have it print to the console.
            Console.WriteLine("Type your last name");
            string myLastName = Console.ReadLine();

            //Have the console greet the user by name.
            Console.WriteLine("Hello, " + myFirstName + " " + myLastName);
            Console.ReadLine();







            
        }
    }
}
