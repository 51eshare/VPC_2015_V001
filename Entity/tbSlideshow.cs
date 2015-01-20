using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dapper;
using System.Threading.Tasks;

namespace Entity
{
    public class tbSlideshow
    {
        public tbSlideshow()
        {
            Enabled = true;
        }
        [Key]
        public int ID { get; set;}

        /// <summary>
        /// 标题
        /// </summary>
        public string TTitle { get; set; }
        public string URL { get; set;}
        public string Img { get; set;}
        public string NContent { get; set;}
        [Editable(false)]
        public DateTime DDate { get; set;}
        [Editable(false)]
        public bool Enabled { get; set;}
    }
}
