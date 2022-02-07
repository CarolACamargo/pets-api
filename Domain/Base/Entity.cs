using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Base
{
    public class Entity
    {
        public Entity()
        {}

        public Guid Id { get; protected set; } 
    }
}
