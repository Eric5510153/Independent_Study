using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace TIDIP_V2.Models
{
    public class Rescue
    {

        [Key]
        [DisplayName("急救單位編號")]
        public int RescueId { get; set; }



        [DisplayName("急救單位名稱")]
        [Required]
        public string RescueName { get; set; }




        [DisplayName("災害事故縣市")]
        public string County_City { get; set; }




        [DisplayName("鄉、鎮、市、區")]
        public string Area { get; set; }



        [DisplayName("急救單位地址")]
        [Required]
        public string RescueAddress { get; set; }



        [DisplayName("資訊建立時間")]
        [Required]
        public DateTime RescueCreatedDate { get; set; }



        [DisplayName("急救單位電話")]
        [Required]
        public string RescueTel { get; set; }

        //FK

    }
}