using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    public class Coach : Person
    {
        List<Coach> coach { get; set; } = new List<Coach>();
        
        public Coach()
        {
           
        }
    }
}
