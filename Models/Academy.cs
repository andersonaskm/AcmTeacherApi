using System.Collections.Generic;

namespace AcmTeacherApi.Models
{
    public class Academy: EntityBase
    {
        #region [Properties]
       
        public string Name { get; set; }
        public ICollection<Plan> Plans { get; private set; }

        #endregion

        #region [Ctor]

        public Academy()
        {
            Plans = new List<Plan>();
        }

        #endregion
    }
}
