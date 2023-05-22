using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    public class Team
    {
        List<Coach> coach { get; set; } = new List<Coach>();
        List<Football_player> players { get; set; } = new List<Football_player>();
    
    }
}
