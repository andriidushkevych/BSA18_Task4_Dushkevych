using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.DTOs
{
    public abstract class EntityDTO
    {
        public Guid Id { get; protected set; }
    }
}
