using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    public class Referee : Person
    {
        List<Referee> referees { get; set; } = new List<Referee>();

        public Referee()
        {
           
        }
    }
}
