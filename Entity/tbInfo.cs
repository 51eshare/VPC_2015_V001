using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dapper;
using System.Threading.Tasks;

namespace Entity
{
    public class tbInfo
    {
        public tbInfo()
        {
            Enabled = true;
        }
        [Key]
        public int ID { get; set;}
        public string TTitle { get; set; }
        public int InfoType { get; set;}
        [Editable(false)]
        public string sInfoType { get; set; }
        public string CContent { get; set;}
        [Editable(false)]
        public DateTime DDate { get; set;}
        [Editable(false)]
        public bool Enabled { get; set; }
    }
}
