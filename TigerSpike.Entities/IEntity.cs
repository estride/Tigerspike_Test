using System;

namespace TigerSpike.IEntity
{
    public interface IEntity<T>
    {
        T Id { get; }
    }
}
