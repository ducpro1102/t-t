﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebModel
{
    public class House
    {
        public decimal hou_ID { get; set; }
        public decimal cus_ID { get; set; }
        public decimal street_ID { get; set; }
        public decimal district_ID { get; set; }
        public decimal province_ID { get; set; }
        public decimal area_ID { get; set; }
        public decimal ward_ID { get; set; }
        public string address_detail { get; set; }
        public decimal floor_area { get; set; }
        public decimal u_floor_area { get; set; }
        public decimal horizontal { get; set; }
        public decimal verical { get; set; }
        public decimal house_category { get; set; }
        public decimal nobedroom { get; set; }
        public decimal notoilet { get; set; }
        public string direction { get; set; }
    }
}
