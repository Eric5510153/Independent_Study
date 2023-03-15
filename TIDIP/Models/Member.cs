using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TIDIP_V2.Models
{
    public class Member
    {
        //[Key]
        //[DisplayName("會員編號")]
        //public int MbID { get; set; }
        [Key]
        [DisplayName("會員身份證號")]
        [Required(ErrorMessage = "身份證號為必填欄位")]
        [StringLength(10)]
        [CheckIDNumber(ErrorMessage = "身份證格式錯誤")]
        public string MbIdentity { get; set; }




        [DisplayName("會員姓名")]
        [StringLength(40, ErrorMessage = "姓名長度過長")]
        [Required(ErrorMessage = "姓名為必填欄位")]
        public string MbName { get; set; }




        [DisplayName("會員電話")]
        [RegularExpression("[0-9]{10}")]
        [Required(ErrorMessage = "會員電話為必填欄位")]
        public string MbPhone { get; set; }




        [DisplayName("會員電子郵件")]
        [EmailAddress(ErrorMessage = "電子郵件格式錯誤")]
        [Required(ErrorMessage = "電子郵件為必填欄位")]
        public string MbEmail { get; set; }




        [DisplayName("會員生日")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd hh:mm}", ApplyFormatInEditMode = true)]
        [DataType(DataType.DateTime)]
        [Required(ErrorMessage = "生日為必填欄位")]
        
        public DateTime MbBrithday { get; set; }




        [DisplayName("會員註冊日期")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd hh:mm}", ApplyFormatInEditMode = true)]
        [DataType(DataType.DateTime)]
        [Required]
        public DateTime MbCreatedDate  { get; set; }




        [DisplayName("會員帳號")]
        [Required(ErrorMessage = "帳號為必填欄位")]
        [StringLength(20, ErrorMessage = "帳號不可超過20字")]
        [RegularExpression("[A-Za-z]{1}[A-Za-z0-9]{4,19}")]
        public string MbAccount { get; set; }




        [DisplayName("會員密碼")]
        [Required(ErrorMessage = "密碼為必填欄位")]
        public string MbPassword { get; set; }



    }


}