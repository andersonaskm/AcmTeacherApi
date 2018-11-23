using System.Collections.Generic;

namespace AcmTeacherApi.Models
{
    /// <summary>
    /// Themes are sports modalities who people get engaged through an academy plan.
    /// </summary>
    public class Theme: EntityBase
    {
        #region [Properties]
        
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Subject> Subjects { get; private set; }

        #endregion

        #region [Ctor]

        public Theme()
        {            
            Subjects = new List<Subject>();
        }

        #endregion
    }
}
