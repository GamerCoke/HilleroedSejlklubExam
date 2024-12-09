using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HSLibrary.Models;
using HSLibrary.Interfaces;
using HSConsoleApp.IO;


namespace HSConsoleApp
{
    public class UserInterface
    {
        private Input _input;
        private Output _output;
        public UserInterface()
        {
            _input = new Input();
            _output = new Output();
        }
    }
}
