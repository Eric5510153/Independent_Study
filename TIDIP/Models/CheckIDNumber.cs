using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TIDIP_V2.Models
{
    
        public class CheckIDNumber : ValidationAttribute
        {
            public CheckIDNumber()
            {
                ErrorMessage = "請輸入正確身分證字號";
            }
            public override bool IsValid(object value)
            {
                string idNumber = value.ToString();

                const string eng = "ABCDEFGHJKLMNPQRSTUVXYZWZIO";
                string t = idNumber.Substring(0, 1);
                int intEng = eng.IndexOf(t) + 10;
                int n1 = intEng / 10;
                int n2 = intEng % 10;

                int sum = 0;


                sum = n1 * 1 + n2 * 9;

                for (int i = 1; i < 9; i++)
                {
                    sum += Convert.ToInt32(idNumber.Substring(i, 1)) * (9 - i);
                }

                sum += Convert.ToInt32(idNumber.Substring(9, 1));

                if (sum % 10 == 0)
                    return true;


                return false;



            }

        }
    }
