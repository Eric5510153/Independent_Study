﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace TIDIP_ADO_NET_V2.Models
{
    public class VMLogin
    {


        [DisplayName("帳號")]
        [Required(ErrorMessage = "請輸入帳號")]
        public string Account { get; set; }
        [DisplayName("密碼")]
        //  [DataType(DataType.Password)]
        [Required(ErrorMessage = "請輸入密碼")]
        public string Password { get; set; }
    }
}