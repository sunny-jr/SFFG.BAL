using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFFG.BAL.Message
{
    public class BaseMessage
    {
        public string type { get; set; } = String.Empty;
        public string message { get; set; } = String.Empty;
    }
}
