using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Model
{
    public abstract class Entity
    {
        public Guid Id { get; protected set; }
    }
}
