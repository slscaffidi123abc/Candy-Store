﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Candy_Store.Data
{
    public class Store
    {

       [Key]
       [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int StoreId { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string State { get; set; }

    }
}
