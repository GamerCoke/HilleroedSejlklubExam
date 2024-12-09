using HSLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSLibrary.Models
{
    public class Member
    {
        private static int _count = 0;
        private string _firstName;
        private string _lastName;
       
        

        public int Id { get; }
        public string Name { get { return _firstName + " " + _lastName; } }
        public string Email { get; }
        public bool IsActiveTrainer { get; set; }
        public DateOnly Birthday { get; }
        public bool IsAdmin { get; set; }
        public string Phone { get; }
        public bool HasKey { get; set; }
        public int Age
        {
            get
            {
                return (int)((DateTime.Now - Birthday.ToDateTime(new TimeOnly(0, 0, 0, 0, 0))).TotalDays / 365.25d);
            }
        }

        public Member(string fistName, string lastName, string email, DateOnly birthday, string phone)
        {
            Id = _count++;
            _firstName = fistName;
            _lastName = lastName;
            Email = email;
            IsActiveTrainer = false;
            HasKey = false;
            Birthday = birthday;
            IsAdmin = false;
            Phone = phone;
            HasKey = false;
        }

        public void BuyKey()
        {
            HasKey = true;
        }
        public override string ToString()
        {
            return $"ID: {Id} | Navn: {Name} | Email: {Email} | Telefonnummer: {Phone} | Fødselsdato: {Birthday} | Har nøgle: {HasKey}";
        }
    }
}
