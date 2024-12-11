﻿using HSLibrary.Models;
using HSLibrary.Models.Dinghy;
using HSLibrary.Models.Dinghy.Motorized;
using HSLibrary.Services;


namespace HSLibrary
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            MemberRepository memberRepository = new MemberRepository();
            Member JohnCena;
            JohnCena = new Member("John", "Cena", "John@Cena.cn", new DateOnly(1972, 11, 11), "XX-ZZ-YY-CC");
            memberRepository.Add(JohnCena);
            Console.WriteLine($"{JohnCena}");
            JohnCena = new Member("John", "Cena", "John@Cena.cn", new DateOnly(1172, 11, 11), "09126476");
            memberRepository.Add(JohnCena);
            Console.WriteLine($"{memberRepository}");

            DinghyRepository dinghyRepository = new DinghyRepository();
            MDinghy Karen = new MDinghy("Mange ting",FuelType.Diesel,100,20.8,40);
            Dinghy Jytte = new Dinghy(DinghyModel.Feva,"har alt du skal bruge");
            Console.WriteLine();
            Console.WriteLine("Vi tester nu joller");
            Console.WriteLine();
            dinghyRepository.Add(Karen);
            dinghyRepository.Add(Jytte);
            Jytte.NeedRepair("Skal males");

            Console.WriteLine("test af tostring:\n" + dinghyRepository.ToString());

            dinghyRepository.Remove(Karen.Id);
            Console.WriteLine(dinghyRepository.ToString());
            Console.WriteLine();
            Console.WriteLine("Test af get:\n" + dinghyRepository.Get(Jytte.Id));
            Console.WriteLine();
            Console.WriteLine("Test af GetAll:\n" + ListToString(dinghyRepository.GetAll()));
            Console.WriteLine();
            Console.WriteLine("Test af GetAllNeedingRepair:\n" + ListToString(dinghyRepository.GetAllNeedingRepairs()));
            Console.WriteLine();
            Console.WriteLine("Test af GetAllSeaWorthy:\n" + ListToString(dinghyRepository.GetAllSeaWorthy()));
            Console.WriteLine();
            Console.WriteLine("Test af GetAllOfModel\n" + ListToString(dinghyRepository.GetAllOfModel(DinghyModel.Tera)));
            Console.WriteLine();
            Console.WriteLine("Test af repair besked:\n" + Jytte.RepairComment);
            Console.WriteLine();
            Jytte.RepairDinghy("Er malet nu", "Meget flot");
            Console.WriteLine("Test af repairlog:\n" + ListToString(Jytte.RepairLog));

            Console.WriteLine() ;
            Console.WriteLine("Vi tester nu blog" + "\n");
            BlogRepository blogRepo = new BlogRepository();
            Blog nBlog = new Blog(JohnCena, "fø's'da'", "I er ikke inviteret, fordi Kina kan ikke lide jer >:(");
            blogRepo.Add(nBlog);
            Console.WriteLine(blogRepo.ToString() + "\n");
            Blog mBlog = new Blog(JohnCena,"Mikkel's Fø's","den her er i faktisk inviteret til");
            blogRepo.Add(mBlog);
            Console.WriteLine(mBlog.ToString() + "\n");
            Console.WriteLine(mBlog.Text + "\n");
            mBlog.EditText("Nyhed: i må gerne være med!");
            Console.WriteLine("Test af rediger tekst\n" + $"{mBlog}\n{mBlog.Text}" + "\n");
            Console.WriteLine("Test af GetAll\n" + ListToString(blogRepo.GetAll()) + "\n");
            Console.WriteLine("Test af Get\n" + blogRepo.Get(mBlog.Id) + "\n");
            Console.WriteLine("Test af GetAllOnDat\n" + ListToString(blogRepo.GetAllOnDate(DateOnly.FromDateTime(DateTime.Now))) + "\n");
            Console.WriteLine("Test af GetAllByMember\n" + ListToString(blogRepo.GetAllByMember(JohnCena)) + "\n");
            blogRepo.Remove(mBlog.Id);
            Console.WriteLine("Test af Remove\n" + ListToString(blogRepo.GetAll()) + "\n");

           
            Console.WriteLine("\nVi tester nu Booking");
            BookingRepository bookingRepo = new BookingRepository();
            Booking newBooking = new Booking(new DateTime(2024,11,10,10,20,00),new TimeSpan(2,0,0), JohnCena, Jytte);
            Console.WriteLine("\nTest af GetAll\n" + ListToString(bookingRepo.GetAll()));
            bookingRepo.Add(newBooking);
            Console.WriteLine("\nTest af Add\n" + ListToString(bookingRepo.GetAll()));
            Console.WriteLine("\nTest af Get\n\t" + bookingRepo.Get(newBooking.Id));
            
            Console.WriteLine("\nTest af GetallOnDate\n" + ListToString(bookingRepo.GetAllOnDate(new DateOnly(2024,12,12))));
            Console.WriteLine("\nTest af GetAllByMember\n" + ListToString(bookingRepo.GetAllByMember(JohnCena))); /*oh my*/
            Console.WriteLine("\nTest af GetAllByDinghy\n" + ListToString(bookingRepo.GetAllByDinghy(Jytte)));
            bookingRepo.Remove(newBooking.Id);
            Console.WriteLine("\nTest af Remove\n" + ListToString(bookingRepo.GetAll()));


        }
        private static string ListToString<T>(List<T> list)
        {
            string toString = $"Der er {list.Count} elementer:";
            foreach(T @object in list)
            {
                toString += $"\n\t{@object.ToString()}";
            }
            return toString;
        }
    }
}