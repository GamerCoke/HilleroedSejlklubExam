using HSLibrary.Models;
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
        }
    }
}