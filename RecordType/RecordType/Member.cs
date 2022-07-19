using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordType
{
    public record Member
    {
  
        public int Id { get; init; }
        public string FirstName { get; init; }
        public string LastName { get; init; }
        public string Address { get; init; }
    }
}
