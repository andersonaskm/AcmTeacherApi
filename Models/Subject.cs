using System;
using System.Collections.Generic;

namespace AcmTeacherApi.Models
{
    public class Subject: EntityBase
    {
        #region [Properties]
        
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Content> Contents { get; private set; }

        #endregion

        #region [Ctor]

        public Subject()
        {            
            Contents = new List<Content>();
        }

        #endregion
    }
}
