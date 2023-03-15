using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace TIDIP_V2.Models
{
    public class Medical
    {

        [Key]
        [DisplayName("醫療單位編號")]
        public int MedicalID { get; set; }




        [Required]
        [DisplayName("醫療單位名稱")]
        public string MedicalName { get; set; }


        [DisplayName("災害事故縣市")]
        public string County_City { get; set; }

        [DisplayName("鄉、鎮、市、區")]
        public string Area { get; set; }

        [DisplayName("醫療單位地址")]
        [Required]
        public string MedicalAddress { get; set; }




        [DisplayName("資訊建立時間")]
        [Required]
        public DateTime MedicalCreatedDate { get; set; }





        [DisplayName("急救單位電話")]
        [Required]
        public string MedicalTel { get; set; }
    }
}