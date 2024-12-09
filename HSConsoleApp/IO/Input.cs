﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSConsoleApp.IO
{
    public class Input
    {
        public string Read()
        {
            return Console.ReadLine();
        }

        public T SelectFromList<T>(List<T> list)
        {
            int selectedId;
            while (true)
            {
                selectedId = int.Parse(Read());
                if (selectedId < 0 || selectedId >= list.Count) continue;
                return list[selectedId];
            }
        }
    }
}
