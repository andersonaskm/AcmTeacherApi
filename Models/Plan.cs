using System.Collections.Generic;

namespace AcmTeacherApi.Models
{
    public class Plan: EntityBase
    {
        #region [Properties]
        
        public string Name { get; set; }
        public ICollection<Theme> Themes { get; private set; }
        public ICollection<Student> Students { get; private set; }

        #endregion

        #region [Ctor]

        public Plan()
        {
            Themes = new List<Theme>();
            Students = new List<Student>();
        }

        #endregion
    }
}
