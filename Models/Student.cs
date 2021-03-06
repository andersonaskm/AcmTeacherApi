﻿namespace AcmTeacherApi.Models
{
    public class Student: EntityBase
    {
        #region [Properties]

        public string Name { get; set; }
        public string FullName { get; set; }
        public string Document { get; set; }
        public string PhoneNumber { get; set; }
        public string MobileNumber { get; set; }
        public string Email { get; set; }
        public Plan CurrentPlan { get; set; }

        #endregion

        #region [Ctor]

        public Student()
        {
            
        }

        #endregion        
    }
}
