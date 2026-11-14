namespace Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  Q1
            //Create a Book class with a Title (string) and Pages (int). Create a Book object and store it in a variable of type object. Print it.
            /*
            object obj = new Book { Title = "Route", Pages = 464 };
            Console.WriteLine(obj);
            */
            #endregion

            #region Q2
            //Using the Book class above, print the result of calling ToString(), Equals() (compare book with itself), GetHashCode(), and GetType() on book
            /*
            Book book = new Book { Title = "Route", Pages = 464 };
            Console.WriteLine(book.ToString());
            Console.WriteLine(book.Equals(book));
            Console.WriteLine(book.GetHashCode());
            Console.WriteLine(book.GetType());
            */
            #endregion

            #region Q3
            //ook at the line below. Is it a compile-time error, a runtime error, or a logical error? Fix it. int pages = "464";
            //Compile-time error — you can't put text (string) into an int variable int pages = 464;
            /*
           // int pages = "464"; --> Compile time error

           int pages = 464;        // التصليح
           Console.WriteLine(pages);
            */
            #endregion

            #region Q4
            //Write code that divides 10 by 0 inside a try block, catches the exception, prints "Cannot divide by zero", and then prints "Done" in a finally block
            /*
            try
            {
                int zero = 0;
                Console.WriteLine(10 / zero);
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Cannot Divide by Zero");
            }
            finally
            {
                Console.WriteLine("Done");
            }
            */
            #endregion

            #region Q5
            //Declare an int pages = 300; then store it in a double variable without using a cast
            /*
             int pages = 300;
             double d = pages;  --> Safe Casting 
             Console.WriteLine(pages);
             Console.WriteLine(d);
             */
            #endregion

            #region Q6
            //Declare a double price = 49.99; then convert it into an int using a cast.
            /*
            double price = 49.99;
            int p = (int)price;
            Console.WriteLine(price);
            Console.WriteLine(p);
            */
            #endregion

            #region Q7
            //Given string pagesText = "464";, convert it into an int using the Convert class
            /*
            string pagesText = "464";
            int pages = Convert.ToInt32(pagesText);
            Console.WriteLine(pagesText);
            Console.WriteLine(pages +1);
            */
            #endregion

            #region Q8 مش فاهمه 
            //Given string yearText = "2023";, convert it using int.Parse(). Then given string badText = 
            //"abc";, use int.TryParse() to safely try converting it, and print "Invalid number" if it fails
            /*
            string yearText = "2023";
            int year = int.Parse(yearText);
            Console.WriteLine($"parsed year : {year}");

            string badText = "abc";
            Console.WriteLine(int.TryParse(badText, out int number) ? $"Converted : {number}": "Invalid number");
            */
            #endregion

            #region َQ9
            //Given int pages = 464;, convert it into a string using ToString() and print its type using GetType() to prove it's now a string.
            /*
            int pages = 464;
            string s = pages.ToString();
            Console.WriteLine(s.GetType());  
            */
            #endregion

            #region Q10
            //Declare int copies = 100;. Box it into an object variable, then unbox it back into a new int variable, and print both

            /*
            int copies = 100;
            object boxed = copies;       

            int unboxed = (int)boxed;     

            Console.WriteLine(boxed);
            Console.WriteLine(unboxed);
            */
            #endregion

            #region Q11
            //Declare an int? year = null;. Print whether it has a value, then assign it 2023 and print its value
            /*
            int? year = null;
            Console.WriteLine(year.HasValue);  
            year = 2023;
            Console.WriteLine(year.Value);    
            */
            #endregion

            #region Q12
            //Declare a string? reviewer = null;. Print whether it is null
            /*
            string? reviewer = null;
            Console.WriteLine(reviewer is null);
            */
            #endregion

            #region Q13
            // Declare a Book? book = null;. Use ?. to safely read book.Title without crashing the program, and print the result.
            /*
            Book? book = null;
            string? title = book?.Title;   
            Console.WriteLine(title);  
            */
            #endregion

            #region Q14
            //Using title from the previous question, use ?? to print "Untitled" if title is null. Then use ?? = to assign title the value "Untitled" only if it's still null.

            /*
            Console.WriteLine(title ?? "Untitled");   
            title ??= "Untitled";                     
            Console.WriteLine(title);  
            */
            #endregion

            #region Q15
            // Given string? name = "Ahmed"; (you are sure it's not null here), assign it to a non-nullable string confirmedName using the ! operator.
            /*
            string? name = "Ahmed";
            string confirmedName = name!;
            Console.WriteLine(name);
            Console.WriteLine(confirmedName);
            */
            #endregion


        }
    }
}

