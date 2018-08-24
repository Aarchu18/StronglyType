using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections;

namespace StronglyType.Models.SportsModel
{
    public class SportsData
    {
        public ArrayList getData()
        {
            ArrayList sportData = new ArrayList();
            SportsList sportList = new SportsList
            {
                sportsPersonId = 1,
                sportPersonName = "Saina Nehwal",
                sportsName = "Badminton",
                doesHeOrShePlayNow = true
            };

            sportData.Add(sportList);

            sportList = new SportsList
            {
                sportsPersonId = 2,
                sportPersonName = "Prakash Padukone",
                sportsName = "Badminton",
                doesHeOrShePlayNow = false
            };

            sportData.Add(sportList);

            sportList = new SportsList
            {
                sportsPersonId = 3,
                sportPersonName = "Pullela Gopichand",
                sportsName = "Badminton",
                doesHeOrShePlayNow = false
            };

            sportData.Add(sportList);

            sportList = new SportsList
            {
                sportsPersonId = 4,
                sportPersonName = "Chetan Anand",
                sportsName = "Badminton",
                doesHeOrShePlayNow = false
            };

            sportData.Add(sportList);

            sportList = new SportsList
            {
                sportsPersonId = 5,
                sportPersonName = "PV Sindhu",
                sportsName = "Badminton",
                doesHeOrShePlayNow = true
            };

            sportData.Add(sportList);

             return sportData;
        }
    }
}
