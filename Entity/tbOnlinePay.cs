using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class tbOnlinePay
    {
        public tbOnlinePay()
        {

        }
        [Key]
        public long ID { get; set;}
        public decimal Price { get; set;}
        public long IOrder { get; set;}
        public int PayType { get; set;}
        [Editable(false)]
        public DateTime PDate { get; set;}
    }
}
