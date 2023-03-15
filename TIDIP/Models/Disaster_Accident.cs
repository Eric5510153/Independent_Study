using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TIDIP_V2.Models
{
    public class Disaster_Accident
    {
        [Key]
        [DisplayName("災害事故資訊編號")]
        public int  DAID { get; set; }




        [DisplayName("災害事故位置")]
        [StringLength(50, ErrorMessage = "位置敘述過長")]
        [Required(ErrorMessage = "位置為必填欄位")]
        public string DALocation { get; set; }


        [DisplayName("災害事故縣市")]
        public string County_City { get; set; }

        [DisplayName("鄉、鎮、市、區")]
        public string Area { get; set; }


        [DisplayName("資訊建立時間")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd hh:mm}", ApplyFormatInEditMode = true)]
        [DataType(DataType.DateTime)]
        [Required]
        public DateTime DACreatedDate { get; set; }




        [DisplayName("災害事故簡述")]
        [StringLength(100, ErrorMessage = "簡述過長")]
        [Required(ErrorMessage = "簡述為必填欄位")]
        public string DAMessage { get; set; }






        //FK
        
        public string MbIdentity { get; set; }
        
        public string DATypeID { get; set; }
        
       

        //關聯
        public virtual Member Member { get; set; }
        
        public virtual Disaster_Accident_Type Disaster_Acciden_Type { get; set; }
        
    }
}