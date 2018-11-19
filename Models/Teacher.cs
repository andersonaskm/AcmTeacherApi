using System;

namespace AcmTeacherApi.Models 
{
    
    public class Teacher 
    {

        #region [Properties]

        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool Enabled { get; set; }
        public DateTime CreatedAt {get; set;}

        #endregion

    }


}