using System;
using TigerSpike.IEntity;

namespace TigerSpike.Entities
{
    public abstract class BaseEntity : IEntity<long>
    {
        public long Id { get; set; }

        public override string ToString()
        {
            return Id.ToString();
        }
    }
}
