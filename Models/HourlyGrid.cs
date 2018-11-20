using System.Collections.Generic;

namespace AcmTeacherApi.Models
{
    public class HourlyGrid: EntityBase
    {
        #region [Properties]

        public int Week { get; set; }
        public int Year { get; set; }
        public ICollection<ThemeClass> ThemeClasses { get; private set; }

        #endregion

        #region [Ctor]

        public HourlyGrid()
        {
            ThemeClasses = new List<ThemeClass>();
        }

        #endregion
    }
}
