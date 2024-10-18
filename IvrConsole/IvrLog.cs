using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvrConsole
{
    [Table("IvrLog")]
    public class IvrLog
    {
        [Key]
        public int Id { get; set; }
        public string ArayanNo { get; set; }
        public string ArananNo { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int IvrNo { get; set; }
    }
}
