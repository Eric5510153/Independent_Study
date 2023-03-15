using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace TIDIP_V2.Models
{
    public class Police
    {
        [Key]
        [DisplayName("警察機關編號")]
        public int PoliceID { get; set; }




        [DisplayName("警察機關名稱")]
        [Required]
        public string PoliceName { get; set; }

        [DisplayName("災害事故縣市")]
        public string County_City { get; set; }

        [DisplayName("鄉、鎮、市、區")]
        public string Area { get; set; }


        [DisplayName("警察機關地址")]
        [Required]
        public string PoliceAddress { get; set; }




        [DisplayName("資訊建立時間")]
        [Required]
        public DateTime PoliceCreatedDate { get; set; }




        [DisplayName("警察機關電話")]
        [Required]
        public string PoliceTel { get; set; }

        
     





    }

}