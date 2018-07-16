using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAL.Model
{
    public class Entity
    {
        [Key]
        public Guid Id { get; set; }
    }
}
