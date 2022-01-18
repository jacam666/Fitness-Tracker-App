using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessWebApp.NewFolder
{
    public class Note
    {
        public string Message { get; }

        public DateTimeOffset Created { get; }

        public Note(string message)
        {
            Message = message;
            Created = DateTimeOffset.Now;
        }
    }
}
