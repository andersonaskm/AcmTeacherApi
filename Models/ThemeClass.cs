using System;

namespace AcmTeacherApi.Models
{
    public class ThemeClass: EntityBase
    {

        #region [Properties]

        public Theme Theme { get; set; }
        public Teacher Teacher { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        #endregion
    }
}
