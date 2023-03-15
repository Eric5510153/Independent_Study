using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TIDIP_V2.Models
{
    public class Admin
    {
        //[Key]
        //[DisplayName("管理員編號")]
        //public int AdId { get; set; }

        [Key]
        [DisplayName("管理員身份證號")]
        [Required(ErrorMessage = "身份證號為必填欄位")]
        [StringLength(10)]
        [CheckIDNumber(ErrorMessage = "身份證格式錯誤")]
        public string AdIdentity { get; set; }


        [DisplayName("管理員姓名")]
        [StringLength(40, ErrorMessage = "姓名長度過長")]
        [Required(ErrorMessage = "姓名為必填欄位")]
        public string AdName { get; set; }

       


        [DisplayName("管理員生日")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd hh:mm}", ApplyFormatInEditMode = true)]
        [DataType(DataType.DateTime)]
        [Required(ErrorMessage = "生日為必填欄位")]
        public DateTime AdBrithday { get; set; }




        [DisplayName("建立管理員日期")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd hh:mm}", ApplyFormatInEditMode = true)]
        [DataType(DataType.DateTime)]
        [Required]
        public DateTime AdCreatedDate { get; set; }




        [DisplayName("管理員帳號")]
        [Required(ErrorMessage = "帳號為必填欄位")]
        [StringLength(20, ErrorMessage = "帳號不可超過20字")]
        [RegularExpression("[A-Za-z]{1}[A-Za-z0-9]{4,19}")]
        public string AdAccount { get; set; }




        [DisplayName("管理員密碼")]
        [Required(ErrorMessage = "密碼為必填欄位")]
        public string AdPassword { get; set; }




        [DisplayName("管理員電子郵件")]
        [Required(ErrorMessage = "電子郵件為必填欄位")]
        [EmailAddress(ErrorMessage = "電子郵件格式錯誤")]
        public string AdEmail { get; set; }




        
        
    }

    
}