namespace AcmTeacherApi.Models
{
    public class Visitor: EntityBase
    {
        #region [Properties]

        public string Name { get; set; }
        public string LastName { get; set; }
        public string Document { get; set; }
        public string PhoneNumber { get; set; }
        public string MobileNumber { get; set; }

        #endregion

        #region [Ctor]

        public Visitor()
        {

        }

        #endregion
    }
}
