using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMBL
{

    public enum EntityStateOption
    {
        Active,
        Deleted
    }
    //Cannot be instantiated used for base classes should never be used on its own
    public abstract class EntityBase
    {
        public bool IsNew { get; set; }
        public bool HasChanges { get; set; }
        public EntityStateOption EntityState { get; set; }
        public bool IsValid
        {
            get
            {
                return Validate();
            }
        }

        public abstract bool Validate();
    }
}
