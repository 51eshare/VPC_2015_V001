using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Entity
{
    public class tbCollect
    {
        public tbCollect()
        {

        }
        [Key]
        public long iCollectId { get; set;}
        public long iShopId { get; set;}

        public long iUserId { get; set;}

        [Editable(false)]
        public DateTime dDate { get; set;}
    }
}
