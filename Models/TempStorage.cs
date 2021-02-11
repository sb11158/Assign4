using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assign4.Models
{
    public class TempStorage
    {
        private static List<Suggestions> suggestions = new List<Suggestions>();

        public static IEnumerable<Suggestions> Suggestions => suggestions;

        public static void AddApplication(Suggestions suggestion)
        {
            suggestions.Add(suggestion);
        }
    }
}
