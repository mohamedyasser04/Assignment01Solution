namespace Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  Q1
            /*
            object obj = new Book { Title = "Route", Pages = 464 };
            Console.WriteLine(obj);
            */
            #endregion

            #region Q2
            /*
            Book book = new Book { Title = "Route", Pages = 464 };
            Console.WriteLine(book.ToString());
            Console.WriteLine(book.Equals(book));
            Console.WriteLine(book.GetHashCode());
            Console.WriteLine(book.GetType());
            */
            #endregion

            #region Q3
            /*
           // int pages = "464"; --> Compile time error

           int pages = 464;        // التصليح
           Console.WriteLine(pages);
            */
            #endregion

            #region Q4
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
            /*
             int pages = 300;
             double d = pages;  --> Safe Casting 
             Console.WriteLine(pages);
             Console.WriteLine(d);
             */
            #endregion

            #region Q6
            /*
            double price = 49.99;
            int p = (int)price;
            Console.WriteLine(price);
            Console.WriteLine(p);
            */
            #endregion

            #region Q7
            /*
            string pagesText = "464";
            int pages = Convert.ToInt32(pagesText);
            Console.WriteLine(pagesText);
            Console.WriteLine(pages +1);
            */
            #endregion

            #region Q8 مش فاهمه 
            /*
            string yearText = "2023";
            int year = int.Parse(yearText);
            Console.WriteLine($"parsed year : {year}");

            string badText = "abc";
            Console.WriteLine(int.TryParse(badText, out int number) ? $"Converted : {number}": "Invalid number");
            */
            #endregion

            #region َQ9
            /*
            int pages = 464;
            string s = pages.ToString();
            Console.WriteLine(s.GetType());  
            */
            #endregion

            #region Q10
            /*
            int copies = 100;
            object boxed = copies;       

            int unboxed = (int)boxed;     

            Console.WriteLine(boxed);
            Console.WriteLine(unboxed);
            */
            #endregion

            #region Q11
            /*
            int? year = null;
            Console.WriteLine(year.HasValue);  
            year = 2023;
            Console.WriteLine(year.Value);    
            */
            #endregion

            #region Q12
            /*
            string? reviewer = null;
            Console.WriteLine(reviewer is null);
            */
            #endregion

            #region Q13
            /*
            Book? book = null;
            string? title = book?.Title;   
            Console.WriteLine(title);  
            */
            #endregion

            #region Q14
            /*
            Console.WriteLine(title ?? "Untitled");   
            title ??= "Untitled";                     
            Console.WriteLine(title);  
            */
            #endregion

            #region Q15
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

