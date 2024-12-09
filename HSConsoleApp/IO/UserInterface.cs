using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HSLibrary.Models;
using HSLibrary.Interfaces;
using HSLibrary.Services;
using HSConsoleApp.IO;


namespace HSConsoleApp
{
    public class UserInterface
    {
        private Input _input;
        private Output _output;

        private IBlogRepository _blogRepository;
        private IBookingRepository _bookingRepository;
        private IDinghyRepository _dinghyRepository;
        private IEventRepository _eventRepository;
        private IMemberRepository _memberRepository;
        private ITeamRepository _teamRepository;

        private Member _currentUser;

        public UserInterface()
        {
            _blogRepository = new BlogRepository();
            _bookingRepository = new BookingRepository();
            _dinghyRepository = new DinghyRepository();
            _eventRepository = new EventRepository();
            _memberRepository = new MemberRepository();
            _teamRepository = new TeamRepository();
            _input = new Input();
            _output = new Output();
        }

        public void ManageCurrentUser()
        {
            if (_currentUser == null)
            {
                Login();
            }
            else
            {
                Logout();
            }
        }
        private void Login()
        {
            _currentUser = DisplayAndSelectFromList(_memberRepository.GetAll());
        }
        private void Logout()
        {
            _currentUser = null;
        }

        public void OpenMenu()
        {
            //1. Manage current user
            //2. - 7. Manage the repositories
            //Q. Quit (break;)
            string answer;
            string question;
            while (true)
            {
                question = $"Bruger: " + (_currentUser == null ? "Ingen" : _currentUser.Name);
                question += $"\nHvad ønsker du at gøre?";
                question += $"\n\t1. " + (_currentUser == null ? "Login" : "Logud");
                question += $"\n\t2. Åben Blogkataloget";
                question += $"\n\t3. Åben Bookingkataloget";
                question += $"\n\t4. Åben Jollekataloget";
                question += $"\n\t5. Åben Begivenhedskataloget";
                question += $"\n\t6. Åben Medlemskataloget";
                question += $"\n\t7. Åben Holdkataloget";
                question += $"\n\tq. AFSLUT";
                _output.Write(question);
                answer = _input.Read();
                switch (answer)
                {
                    case "1":
                        ManageCurrentUser();
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "5":
                        break;
                    case "6":
                        break;
                    case "7":
                        break;
                }
                if (answer == "q") break;
            }
        }

        private T DisplayAndSelectFromList<T>(List<T> list)
        {
            _output.Write("Vælg fra følgende liste:");
            _output.DisplayList(list);
            return _input.SelectFromList(list);
        }

        private void OpenSubmenuBlogRepository()
        {
            _output.Write(_blogRepository.ToString());
            string answer;
            string question = "";
            question += $"Hvad ønsker du at gøre i dette katalog?";
            question += $"\n\t1. Opret nyt BlogOpslag";
            question += $"\n\t2. Slet BlogOpslag";
            question += $"\n\t3. Vis specifikt BlogPost";
            question += $"\n\t4. Vis BlogOpslag fra dato";
            question += $"\n\t5. Vis BlogOpslag fra medlem";
            question += $"\n\tq. TILBAGE";
            _output.Write(question);
            while (true)
            {
                answer = _input.Read();
                switch(answer)
                {
                    case "1":
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "5":
                        break;
                }
                if (answer == "q") break;
            }
        }
        private void OpenSubmenuBookingRepository()
        {
            _output.Write(_bookingRepository.ToString());
            string answer;
            string question = "";
            question += $"Hvad ønsker du at gøre i dette katalog?";
            question += $"\n\t1. Opret ny booking";
            question += $"\n\t2. Slet booking";
            question += $"\n\t3. Vis booking fra Id";
            question += $"\n\t4. Vis bookinger";
            question += $"\n\t5. Vis bookinger fra dato";
            question += $"\n\t6. Vis bookinger for bestemt medlem";
            question += $"\n\t7. Vis bookinger for bestemt jolle";
            question += $"\n\tq. TILBAGE";
            _output.Write(question);
            while (true)
            {
                answer = _input.Read();
                switch (answer)
                {
                    case "1":
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "5":
                        break;
                    case "6":
                        break;
                    case "7":
                        break;
                }
                if (answer == "q") break;
            }
        }
        private void OpenSubmenuDinghyRepository()
        {
            _output.Write(_dinghyRepository.ToString());
            string answer;
            string question = "";
            question += $"Hvad ønsker du at gøre i dette katalog?";
            question += $"\n\t1. Tilføj jolle";
            question += $"\n\t2. Slet jolle";
            question += $"\n\t3. Vis jolle fra Id";
            question += $"\n\t4. Vis joller";
            question += $"\n\t5. Vis joller som skal repereres";
            question += $"\n\t6. Vis sejlklare joller";
            question += $"\n\t7. Vis jolle(r) fra model";
            question += $"\n\tq. TILBAGE";
            _output.Write(question);
            while (true)
            {
                answer = _input.Read();
                switch (answer)
                {
                    case "1":
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "5":
                        break;
                    case "6":
                        break;
                    case "7":
                        break;
                }
                if (answer == "q") break;
            }
        }
        private void OpenSubmenuEventRepository()
        {
            _output.Write(_eventRepository.ToString());
            string answer;
            string question = "";
            question += $"Hvad ønsker du at gøre i dette katalog?";
            question += $"\n\t1. ";
            question += $"\n\tq. TILBAGE";
            _output.Write(question);
            while (true)
            {
                answer = _input.Read();
                switch (answer)
                {
                    case "1":
                        break;
                }
                if (answer == "q") break;
            }
        }
        private void OpenSubmenuMemberRepository()
        {
            _output.Write(_memberRepository.ToString());
            string answer;
            string question = "";
            question += $"Hvad ønsker du at gøre i dette katalog?";
            question += $"\n\t1. ";
            question += $"\n\tq. TILBAGE";
            _output.Write(question);
            while (true)
            {
                answer = _input.Read();
                switch (answer)
                {
                    case "1":
                        break;
                }
                if (answer == "q") break;
            }
        }
        private void OpenSubmenuTeamRepository()
        {
            _output.Write(_teamRepository.ToString());
            string answer;
            string question = "";
            question += $"Hvad ønsker du at gøre i dette katalog?";
            question += $"\n\t1. ";
            question += $"\n\tq. TILBAGE";
            _output.Write(question);
            while (true)
            {
                answer = _input.Read();
                switch (answer)
                {
                    case "1":
                        break;
                }
                if (answer == "q") break;
            }
        }

    }
}
