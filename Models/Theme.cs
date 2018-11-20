using System;
using System.Collections.Generic;

namespace AcmTeacherApi.Models
{
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
