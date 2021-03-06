﻿using System;
using System.Collections.Generic;

namespace AcmTeacherApi.Models
{
    public class Teacher: EntityBase
    {
        #region [Properties]
        
        public string Name { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public DateTime HiredAt { get; set; }
        public ICollection<Theme> Themes { get; private set; }

        #endregion

        #region [Ctor]

        public Teacher()
        {            
            Themes = new List<Theme>();
        }

        #endregion
    }
}
