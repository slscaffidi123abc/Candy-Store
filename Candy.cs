using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Candy_Store.Data
{
    public class Candy
    {
      

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CandyId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        //foreign connects Manufacturer Table
        public int MID { get; set; }
        [ForeignKey("MID")]
        public Manufacturers Manufacturers { get; set; }

        //foreign key connects Store Table
        public int StoreId { get; set; }
        [ForeignKey("StoreId")]
        public Store Stores { get; set; }



    }
}
