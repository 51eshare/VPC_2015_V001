using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class tbpickCommission
    {
        public tbpickCommission()
        {

        }
        [Key]
        public long pickCommissionId { get; set;}
        public long Uid { get; set;}
        [Editable(false)]
        public string sLoginId { get; set;}
        public decimal Nprice { get; set;}
        [Editable(false)]
        public DateTime DDate { get; set;}
        private int _SState = 1;
        [Editable(false)]
        public int SState
        {
            get { return _SState; }
            set { _SState = value; }
        }
        [Editable(false)]
        public string sStatus
        { get; set;}
    }
}
