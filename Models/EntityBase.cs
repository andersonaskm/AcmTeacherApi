using System;

namespace AcmTeacherApi.Models
{
    public abstract class EntityBase
    {
        #region [Properties]

        public Guid Id { get; set; }
        public bool Enabled { get; set; }
        public DateTime CreatedAt { get; private set; }

        #endregion

        #region [Ctor]

        public EntityBase()
        {
            CreatedAt = DateTime.UtcNow;
        }

        #endregion
    }
}
