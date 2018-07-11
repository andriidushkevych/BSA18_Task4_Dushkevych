using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model
{
    public abstract class Entity
    {
        public Guid Id { get; protected set; }
    }
}
