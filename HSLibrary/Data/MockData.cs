using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HSLibrary.Models;

namespace HSLibrary.MockData
{
    public class MockData
    {
        #region Instance fields
        private static Dictionary<int, Member> _memberData =
            new Dictionary<int, Member>()
            {
            { 0, new Member("Mikkel","Barfod", "gg@gamermail.com", new DateOnly(1999, 12, 15) , "20202020") },
            { 1, new Member("Chad","Gaylord Smith", "LordOfTheGaymers@gamermail.com", new DateOnly(1961,10,25), "42069420") },
            { 2, new Member("Carina", "Carina", "CarinaDenFlotte.420@gmail.com", new DateOnly(1892,11,02), "60606969" )},
            { 3, new Member("Theodore", "Kaczynski", "UncleTed@Boston.com", new DateOnly (1942, 5, 22), "10062023") }
            };

        private static Dictionary<int, Team> _teamData =
            new Dictionary<int, Team>
            {
     

            };
        #endregion

        #region Properties
        public static Dictionary<int, Member> CustomerData
        {
            get { return _memberData; }
        }


        public staticDictionary<int, Team> MenuItemData
        {
            get { return _teamData; }
        }
        #endregion

    }
}
