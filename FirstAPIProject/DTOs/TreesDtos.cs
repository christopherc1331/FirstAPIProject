using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstAPIProject.DTOs
{
   public class TreeDto
    {
        public string TreeName { get; set; }

        public List<string> Seasons { get; set; }

        public int Age { get; set; }
    }
}
