using System;
using System.Collections;
using System.Collections.Generic;

namespace BowlingLeague.Models.ViewModels
{
    //The purpose of this view is to let us have multiple models in our views.
    public class IndexViewModel
    {
        public List<Bowler> Bowlers { get; set; }

        public PageNumbering PageNumbering { get; set; }

        public string TeamName { get; set; }
    }
}
