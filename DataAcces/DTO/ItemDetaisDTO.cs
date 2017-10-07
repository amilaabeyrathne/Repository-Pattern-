using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.DTO
{
    public class ItemDetaisDTO
    {
        public int Item_ID { get; set; }
        public string Item_Name { get; set; }
        public int Item_Price { get; set; }
        public string Image_Name { get; set; }
        public string Description { get; set; }
        public string AddedBy { get; set; }
    }
}

