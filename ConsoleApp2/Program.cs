using ConsoleApp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Services.Description;

namespace ConsoleApp2
{
    public class Program
    {

        static void Main(string[] args)
        {
            LibraryContext libraryContext = new LibraryContext();
            Library library = new Library(libraryContext);
            ILibrary library1 = (ILibrary)library;

            MembersList member = new MembersList(libraryContext);
            IMembersList member1 = (IMembersList)member;

            List<Book> bookData = library1.GetAllBooks();

            if (bookData.Count == 0)
            {
                     List<Book> booklist = new List<Book>
                 {
                 new Book { BookName = "Roman e tarikhi" ,BookAuthor = "Gyorgy Lukacs", BookTranslator = "Omid Mehrgan", BookSubjects = "Naghd", BookPublisher = "Sales", BookDate = 1388, Booklink = "http://Trainbit.com/files/4474851484/رمان_تارخ.pdf" },
                 new Book { BookName = "Tajrobe-ye Modernite", BookAuthor = "Martial Berman", BookTranslator = "Morad FarhadPour", BookSubjects = "Tarikh", BookPublisher = "Tarh e nou", BookDate = 1379, Booklink = "http://Trainbit.com/files/2474851484/تجربه_مدرنته.pdf" },
                 new Book { BookName = "Az In Avesta", BookAuthor = "Akhavan e Sales", BookTranslator = "", BookSubjects = "Sheer", BookPublisher = "Morvarid", BookDate = 1360, Booklink = "http://Trainbit.com/files/9374851484/از_ان_اوستا.pdf" },
                 new Book { BookName = "Malven Mimirad", BookAuthor = "Samuel Beeket", BookTranslator = "Soheid Somi", BookSubjects = "Dastan", BookPublisher = "Sales", BookDate = 1388, Booklink = "http://Trainbit.com/files/4974851484/ملون_م_مرد.pdf" },
                 new Book { BookName = "Jamee Shenasi e Roman", BookAuthor = "Gyorgy Lukacs", BookTranslator = "Mohammad Jafar Pouyandeh", BookSubjects = "Adabiat", BookPublisher = "Mahi", BookDate = 1387, Booklink = "http://Trainbit.com/files/0974851484/جامعه_شناس_رمان.pdf" },
                 new Book { BookName = "Dar Bandar e Abi e Chashmanat", BookAuthor = "Nazzar Ghabbani", BookTranslator = "Ahmad Pouri", BookSubjects = "Sheer", BookPublisher = "Chashmeh", BookDate = 1383, Booklink = "http://Trainbit.com/files/7174851484/در_بندر_اب_شمانت.pdf" },
                 new Book { BookName = "Majmoueye Ashaar", BookAuthor = "Farrokhi e Yazdi", BookTranslator = "", BookSubjects = "Sheer", BookPublisher = "Negah", BookDate = 1380, Booklink = "http://Trainbit.com/files/5374851484/مجموعه_اشعار_فرخ_زد.pdf" },
                 new Book { BookName = "Ghessahaye Koutah", BookAuthor = "Mohammad Ali Jamalzadeh", BookTranslator = "", BookSubjects = "Dastan", BookPublisher = "Sokhan", BookDate = 1380, Booklink = "http://Trainbit.com/files/0674851484/Ghesehaye__Kootah.pdf" },
                 new Book { BookName = "Ghesseye Ma Be Sar Resid", BookAuthor = "Mohammad Ali Jamalzadeh", BookTranslator = "", BookSubjects = "Dastan", BookPublisher = "Sokhan", BookDate = 1379, Booklink = "http://Trainbit.com/files/9974851484/Gheseye_Ma_Be_Sar__Resid.pdf" },
                 new Book { BookName = "Aarash", BookAuthor = "Bahram Beyzaii", BookTranslator = "", BookSubjects = "Dastan", BookPublisher = "Niloufar", BookDate = 1373, Booklink = "https://trainbit.com/files/2974851484/%D8%A7%D8%B1%D8%B4.pdf" }
                 };

                foreach(var book in booklist)
                {
                    library1.Insert(book);
                }
            }

            List<Member> MembersList = member1.GetAllMembers();

            if(MembersList.Count == 0)
            {
                List<Member> memberList = new List<Member>
                {
                    new Member {MembersName = "Ali" ,MemberslastName = "ZahedPur" ,Membersmobilenumbe = "09152365485" ,Memberspassword = "s123"},
                    new Member {MembersName = "Ziba" ,MemberslastName = "Rezaii" ,Membersmobilenumbe = "09362569874" ,Memberspassword = "Ziba25"},
                    new Member {MembersName = "Sara" ,MemberslastName = "Hasani" ,Membersmobilenumbe = "09102255636" ,Memberspassword = "Barf54"},
                };

                foreach(var eachMember in memberList)
                {
                    member1.Insert(eachMember);
                }
            }



            try
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Please Select Your Choice");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Select 1 For Library");
                Console.WriteLine("Select 2 For Member");

                int Selection = Convert.ToInt32(Console.ReadLine());

                if (Selection > 2)
                {
                    Console.WriteLine("Your Choice Is Incorrect");
                    Thread.Sleep(3000);
                    Environment.Exit(0);
                }

                if (Selection == 1)
                {

                    int choice = 0;
                    try
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("welcome to Collective library");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("select 1 to show book list");
                        Console.WriteLine("select 2 to show one book detail by your choice");
                        Console.WriteLine("select 3 to add a book");
                        Console.WriteLine("select 4 to update a book");
                        Console.WriteLine("select 5 to delete a book");
                        choice = Convert.ToInt32(Console.ReadLine());
                        if (choice > 5)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Your Choice Is Incorrect");
                            Thread.Sleep(3000);
                            Environment.Exit(0);
                        }
                    }
                    catch
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Your Choice Is Incorrect");
                    }



                    if (choice == 1 || choice == 2 || choice == 3 || choice == 4 || choice == 5)
                    {
                        switch (choice)
                        {
                            case 1:
                                {
                                    List<Book> Books = library1.GetAllBooks();
                                   
                                    foreach(var a in Books)
                                    {
                                        Console.WriteLine("BookId={0} BookName={1} BookAuthor={2} BookTranslator={3} BookPublisher={4} BookSubjects={5} BookDate={6} BookLink={7}", a.BookID, a.BookName, a.BookAuthor, a.BookTranslator, a.BookPublisher, a.BookSubjects, a.BookDate, a.Booklink);
                                        Console.WriteLine("----------------------------------------------------------------------");
                                    }
                                    break;
                                }
                            case 2:
                                {
                                    Console.WriteLine("please insert bookid");
                                    int bookid = Convert.ToInt32(Console.ReadLine());
                                    Book a = library1.GetBookById(bookid);
                                    Console.WriteLine("BookId={0} BookName={1} BookAuthor={2} BookTranslator={3} BookPublisher={4} BookSubjects={5} BookDate={6} BookLink={7}", a.BookID, a.BookName, a.BookAuthor, a.BookTranslator, a.BookPublisher, a.BookSubjects, a.BookDate, a.Booklink);
                                    break;
                                }
                            case 3:
                                {

                                    Console.WriteLine("Please Enter books name");
                                    string bookname = Console.ReadLine();
                                    Console.WriteLine("Please Enter books author name ");
                                    string bookauthor = Console.ReadLine();
                                    Console.WriteLine("Please Enter books translator name ");
                                    string booktranslator = Console.ReadLine();
                                    Console.WriteLine("Please Enter books publisher name");
                                    string bookpublisher = Console.ReadLine();
                                    Console.WriteLine("Please Enter books subject ");
                                    string booksubjects = Console.ReadLine();
                                    Console.WriteLine("Please Enter books data");
                                    int bookdata = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Please Enter books Link");
                                    string bookLink = Console.ReadLine();


                                    Book book = new Book();


                                    book.BookName = bookname;
                                    book.BookAuthor = bookauthor;
                                    book.BookTranslator = booktranslator;
                                    book.BookPublisher = bookpublisher;
                                    book.BookSubjects = booksubjects;
                                    book.BookDate = bookdata;
                                    book.Booklink = bookLink;



                                    library1.Insert(book);
                                    break;
                                }
                            case 4:
                                {
                                    Console.WriteLine("please insert bookid");
                                    int bookid = Convert.ToInt32(Console.ReadLine());
                                    Book oldBook = library1.GetBookById(bookid);
                                    Console.WriteLine("BookId={0} BookName={1} BookAuthor={2} BookTranslator={3} BookPublisher={4} BookSubjects={5} BookDate={6} BookLink={7}", oldBook.BookID, oldBook.BookName, oldBook.BookAuthor, oldBook.BookTranslator, oldBook.BookPublisher, oldBook.BookSubjects, oldBook.BookDate, oldBook.Booklink);
                                    Console.WriteLine("-----------------------------------------");
                                    Console.WriteLine("Please Enter books name");
                                    string bookname = Console.ReadLine();
                                    Console.WriteLine("Please Enter books author name ");
                                    string bookauthor = Console.ReadLine();
                                    Console.WriteLine("Please Enter books translator name ");
                                    string booktranslator = Console.ReadLine();
                                    Console.WriteLine("Please Enter books publisher name");
                                    string bookpublisher = Console.ReadLine();
                                    Console.WriteLine("Please Enter books subject ");
                                    string booksubjects = Console.ReadLine();
                                    Console.WriteLine("Please Enter books data");
                                    int bookdata = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Please Enter books link ");
                                    string booklink = Console.ReadLine();

                                    Book newbook = new Book();

                                    newbook.BookName = bookname;
                                    newbook.BookAuthor = bookauthor;
                                    newbook.BookTranslator = booktranslator;
                                    newbook.BookPublisher = bookpublisher;
                                    newbook.BookSubjects = booksubjects;
                                    newbook.Booklink = booklink;
                                    newbook.BookDate = bookdata;

                                    library1.Update(bookid, newbook);
                                    break;
                                }
                            case 5:
                                {
                                    Console.WriteLine("please insert bookid");
                                    int bookid = Convert.ToInt32(Console.ReadLine());
                                    Book book = library1.GetBookById(bookid);
                                    library1.Delete(book);
                                    break;
                                }



                        }
                    }
                }
                else if (Selection == 2)
                {
                    int choice = 0;
                    try
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("welcome to Members List");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("select 1 to show Members list");
                        Console.WriteLine("select 2 to show one Member detail by your choice");
                        Console.WriteLine("select 3 to add a Member");
                        Console.WriteLine("select 4 to update a Member");
                        Console.WriteLine("select 5 to delete a Member");
                        choice = Convert.ToInt32(Console.ReadLine());
                        if (choice > 5)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Your Choice Is Incorrect");
                            Thread.Sleep(3000);
                            Environment.Exit(0);
                        }
                    }
                    catch
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Your Choice Is Incorrect");
                    }



                    if (choice == 1 || choice == 2 || choice == 3 || choice == 4 || choice == 5)
                    {
                        switch (choice)
                        {
                            case 1:
                                {
                                    List<Member> Members = member1.GetAllMembers();
                                    Members.ForEach
                                     (
                                       a => Console.WriteLine("MembersId={0} MembersName={1} MemberslastName={2} Membersmobilenumber={3} Memberspassword={4}", a.MembersId, a.MembersName, a.MemberslastName, a.Membersmobilenumbe, a.Memberspassword)
                                     );
                                    break;
                                }
                            case 2:
                                {
                                    Console.WriteLine("please insert MemberId");
                                    int memberid = Convert.ToInt32(Console.ReadLine());
                                    Member a = member1.GetMemberById(memberid);
                                    Console.WriteLine("MembersId={0} MembersName={1} MemberslastName={2} Membersmobilenumber={3} Memberspassword={4}", a.MembersId, a.MembersName, a.MemberslastName, a.Membersmobilenumbe, a.Memberspassword);
                                    break;
                                }
                            case 3:
                                {

                                    Console.WriteLine("Please Enter Name");
                                    string memberName = Console.ReadLine();
                                    Console.WriteLine("Please Enter last Name");
                                    string memberLastname = Console.ReadLine();
                                    Console.WriteLine("Please Enter Mobile Number");
                                    string memberMobileNumber = Console.ReadLine();
                                    Console.WriteLine("Please Enter Password");
                                    string memberPassword = Console.ReadLine();



                                    Member newmember = new Member();


                                    newmember.MembersName = memberName;
                                    newmember.MemberslastName = memberLastname;
                                    newmember.Membersmobilenumbe = memberMobileNumber;
                                    newmember.Memberspassword = memberPassword;



                                    member1.Insert(newmember);
                                    break;
                                }
                            case 4:
                                {
                                    Console.WriteLine("please insert MemberId");
                                    int memberId = Convert.ToInt32(Console.ReadLine());

                                    Member OldMember = member1.GetMemberById(memberId);
                                    Console.WriteLine("MembersId={0} MembersName={1} MemberslastName={2} Membersmobilenumber={3} Memberspassword={4}", OldMember.MembersId, OldMember.MembersName, OldMember.MemberslastName, OldMember.Membersmobilenumbe, OldMember.Memberspassword);
                                    Console.WriteLine("-----------------------------------------");
                                    Console.WriteLine("Please Enter Name");
                                    string memberName = Console.ReadLine();
                                    Console.WriteLine("Please Enter last Name");
                                    string memberLastname = Console.ReadLine();
                                    Console.WriteLine("Please Enter Mobile Number");
                                    string memberMobileNumber = Console.ReadLine();
                                    Console.WriteLine("Please Enter Password");
                                    string memberPassword = Console.ReadLine();

                                    Member newmember = new Member();

                                    newmember.MembersName = memberName;
                                    newmember.MemberslastName = memberLastname;
                                    newmember.Membersmobilenumbe = memberMobileNumber;
                                    newmember.Memberspassword = memberPassword;


                                    member1.Update(memberId, newmember);
                                    break;
                                }
                            case 5:
                                {
                                    Console.WriteLine("please insert memberId");
                                    int memberId = Convert.ToInt32(Console.ReadLine());
                                    Member oldmember = member1.GetMemberById(memberId);
                                    member1.Delete(oldmember);
                                    break;
                                }



                        }
                    }
                }

            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Your Choice Is Incorrect");
            }
            Console.ReadKey();
        }
    }
}
