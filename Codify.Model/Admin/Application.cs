using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codify.Entity.Admin
{
    public class Application : BaseEntity
    {
        public int ApplicationId { get; set; }
        public string ApplicationName { get; set; }
    }
}
