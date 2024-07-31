using System.ComponentModel.DataAnnotations;

namespace Milestone_1_assessment
{
    class Books
    {

        //+++++Variables*****//
        public string StrBookName;
        public string StrISBNNo;        
        public string StrPublisher;        
        public string StrLanguage;
        public string StrLOT;
        public string StrSummary;
        public string StrPrice;
        public string StrBookId;
        public string StrNoOfPages;

        //+++++Constructor*****//
        public Books()
        {
            StrLanguage = "English";
            StrLOT = "Technical";
        }

        //+++++Function to get details about the book as user input*****// 
        public Books GetBookDetails()
        {
            bool BoolLoopContinue = true;
            do
            {
                Console.WriteLine("Enter Book ID: ");
                StrBookId = Console.ReadLine();
                if (String.IsNullOrEmpty(StrBookId.Trim()))
                {
                    Console.WriteLine("Book ID is mandatory. Please enter again. ");
                }
                else
                {
                    int IntDigitCount=0;
                    foreach (char a in StrBookId)
                    {
                        if (char.IsDigit(a))
                            IntDigitCount++;                        
                    }
                    if (IntDigitCount != 5)
                        Console.WriteLine("Book ID should have 5 digits only. Please enter again. ");
                    else
                        BoolLoopContinue = false;
                }
            } while(BoolLoopContinue);

            BoolLoopContinue = true;
            do
            {
                Console.WriteLine("Enter Book Name: ");
                StrBookName = Console.ReadLine();
                if (String.IsNullOrEmpty(StrBookName.Trim()))
                {
                    Console.WriteLine("Book Name is mandatory. Please enter again. ");
                }
                else
                {
                   BoolLoopContinue = false;
                }
            } while (BoolLoopContinue);

            Console.WriteLine("Enter ISBN No.: ");
            StrISBNNo = Console.ReadLine();
            Console.WriteLine("Enter Publisher: ");
            StrPublisher = Console.ReadLine();
            Console.WriteLine("Enter Language (press Enter to use default value): ");
            string StrLang = Console.ReadLine().Trim();
            StrLanguage = String.IsNullOrEmpty(StrLang)?StrLanguage:StrLang;
            BoolLoopContinue = true;
            do
            {
                Console.WriteLine("Enter LOT (press Enter to use default value): ");
                string StrLT = Console.ReadLine().Trim();
                if (String.IsNullOrEmpty(StrLT.Trim()))
                {
                    //Use default value from constructor
                    BoolLoopContinue = false;
                }
                else 
                {
                    String[] ArrExpectedLOTValues = { ".NET", "JAVA", "IMS", "V&V", "BI", "RDMS" };
                    if (!ArrExpectedLOTValues.Contains(StrLT.Trim()))
                        Console.WriteLine("LOT value not as expected (\".NET\", \"JAVA\", \"IMS\", \"V&V\", \"BI\", \"RDMS\"). Please enter again. ");
                    else
                    {
                        StrLOT = StrLT.Trim();
                        BoolLoopContinue = false;
                    }
                        
                }
            } while (BoolLoopContinue);            
            Console.WriteLine("Enter Summary: ");
            StrSummary = Console.ReadLine();
            Console.WriteLine("Enter Price: ");
            StrPrice = Console.ReadLine();
            Console.WriteLine("Enter Number of Pages: ");
            StrNoOfPages = Console.ReadLine();
            return this;
        }
    }
    internal class BookAssessment
    {
        static void Main(string[] args)
        {
            int OptionSelected = 0;
            List<Books> BooksList = new List<Books>();
            while (OptionSelected != 4)
            {
                Console.WriteLine("\n--Menu--\n1.Add Book\n2.Delete Employee\n3.Display Books\n4.Exit");
                OptionSelected = int.Parse(Console.ReadLine());
                switch (OptionSelected)
                {
                    case 1:
                        //+++++Add book*****//
                        Books Book = new Books();                                            
                        BooksList.Add(Book.GetBookDetails());
                        break;
                    case 2:
                        //+++++Delete book*****//
                        Console.WriteLine("\nEnter Book ID of book to be deleted: ");
                        string StrBookIDDel = Console.ReadLine();
                        List<Books> TempBookList = new List<Books>();
                        bool BoolDeleted=false;
                        TempBookList.AddRange(BooksList);
                        foreach (Books Bk in BooksList)
                        {
                            if (Bk.StrBookId == StrBookIDDel)
                            {
                                TempBookList.Remove(Bk);
                                Console.WriteLine("Delete completed");
                                BoolDeleted = true;
                            }
                        }
                        if(BoolDeleted)
                            BooksList = TempBookList;
                        else
                            Console.WriteLine("Item to be deleted not found");
                        break;
                    case 3:
                        //+++++Display book*****//
                        if (BooksList.Count == 0)
                            Console.WriteLine("No books in collection");
                        else
                            foreach (Books Bk in BooksList)
                            {
                                Console.WriteLine("--------------------------------");
                                Console.WriteLine("Book ID: " + Bk.StrBookId + "\nBook Name: " + Bk.StrBookName + "\nISBN No.: "
                                    + Bk.StrISBNNo + "\nPublisher: " + Bk.StrPublisher + "\nLanguage: " + Bk.StrLanguage
                                    + "\nLOT: " + Bk.StrLOT + "\nSummary: " + Bk.StrSummary
                                    + "\nPrice: " + Bk.StrPrice + "\nNoOfPages: " + Bk.StrNoOfPages);
                            }
                        break;
                    case 4:
                        //+++++Exit menu*****//
                        break;
                    default:
                        //+++++Invalid selection*****//
                        Console.WriteLine("Invalid option selected");
                        break;
                }
            }
        }
    }
}