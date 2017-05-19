using System;
using System.Collections.Generic;

namespace Automato.App.Domain.Entities
{
    public class Result
    {
        public List<String> Lines { get; private set; }
        public Result()
        {
            Lines = new List<String>();
        }

        public void AddLine(string line)
        {
            Lines.Add(line);
        }
    }
}