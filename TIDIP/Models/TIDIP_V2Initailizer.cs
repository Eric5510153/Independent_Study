using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Xml.Linq;
using System.Security.Principal;
using System.Web.Helpers;

namespace TIDIP_V2.Models
{
    public class TIDIP_V2Initailizer : DropCreateDatabaseIfModelChanges<TIDIP_V2Context>

    {
        protected override void Seed(TIDIP_V2Context db)
        {
            base.Seed(db);
        


        List<Admin> admin = new List<Admin>
        
        {
            new Admin
            {
                AdIdentity="T125251895",
                AdName="盧奕廷",
                AdBrithday=Convert.ToDateTime("1997/12/19"),
                AdCreatedDate= DateTime.Today,
                AdEmail="2105105173@nkust.edu.tw",
                AdAccount="Eric5510153",
                AdPassword="T125251895"
                
                }

        };
         admin.ForEach(s => db.Admin.Add(s));
         db.SaveChanges();




        List<Member> member = new List<Member>

        {
            new Member
            {
                   MbIdentity = "T125251895",
                   MbName="盧奕廷",
                   MbPhone="0989989215",
                   MbEmail="2105105173@nkust.edu.tw",
                   MbBrithday=Convert.ToDateTime("1997/12/19"),
                   MbCreatedDate= DateTime.Today,
                   MbAccount = "Eric5510153",
                   MbPassword = "T125251895"


            }
        };
            member.ForEach(s => db.Member.Add(s));
            db.SaveChanges();

        /*
            List<Area> area = new List<Area>

        {
              new Area
              {

              AreaID="100",
              AreaName="臺北市中正區"

              },
              new Area
              {

              AreaID="103",
              AreaName="臺北市大同區"

              }

        };

          
            area.ForEach(s => db.Area.Add(s));
            db.SaveChanges();
        */

            List<Disaster_Accident_Type> disaster_accident_type = new List<Disaster_Accident_Type>
            {

                new Disaster_Accident_Type
                {

                    DATypeID="A",
                    
                    DATypeName="火災"

                },
                new Disaster_Accident_Type
                {

                    DATypeID="B",
                    DATypeName="地震"

                }


            };

            disaster_accident_type.ForEach(s => db.Disaster_Accident_Type.Add(s));
            db.SaveChanges();



            //List<County_City> county_city = new List<County_City>
            //{

            //    new County_City
            //    {
            //        County_CityID="C",
            //        County_CityName="基隆市"
            //    },
            //    new County_City
            //    {
            //        County_CityID="A",
            //        County_CityName="臺北市"
            //    },

            //    new County_City
            //    {
            //        County_CityID="F",
            //        County_CityName="新北市"
            //    },

            //    new County_City
            //    {
            //        County_CityID="H",
            //        County_CityName="桃園市"
            //    },
            //    new County_City
            //    {
            //        County_CityID="J",
            //        County_CityName="新竹縣"
            //    },
            //    new County_City
            //    {
            //        County_CityID="O",
            //        County_CityName="新竹市"
            //    },
            //    new County_City
            //    {
            //        County_CityID="K",
            //        County_CityName="苗栗縣"
            //    },
            //    new County_City
            //    {
            //        County_CityID="B",
            //        County_CityName="臺中市"
            //    },
            //    new County_City
            //    {
            //        County_CityID="M",
            //        County_CityName="南投縣"
            //    },
            //    new County_City
            //    {
            //        County_CityID="N",
            //        County_CityName="彰化縣"
            //    },
            //    new County_City
            //    {
            //        County_CityID="P",
            //        County_CityName="雲林縣"
            //    },
            //    new County_City
            //    {
            //        County_CityID="Q",
            //        County_CityName="嘉義縣"
            //    },
            //    new County_City
            //    {
            //        County_CityID="I",
            //        County_CityName="嘉義市"
            //    },
            //    new County_City
            //    {
            //        County_CityID="D",
            //        County_CityName="台南市"
            //    },
            //    new County_City
            //    {
            //        County_CityID="E",
            //        County_CityName="高雄市"
            //    },
            //    new County_City
            //    {
            //        County_CityID="T",
            //        County_CityName="屏東縣"
            //    },
            //    new County_City
            //    {
            //        County_CityID="V",
            //        County_CityName="台東縣"
            //    },
            //    new County_City
            //    {
            //        County_CityID="U",
            //        County_CityName="花蓮縣"
            //    },
            //    new County_City
            //    {
            //        County_CityID="G",
            //        County_CityName="宜蘭縣"
            //    },
            //    new County_City
            //    {
            //        County_CityID="X",
            //        County_CityName="澎湖縣"
            //    },
            //    new County_City
            //    {
            //        County_CityID="W",
            //        County_CityName="金門縣"
            //    },
            //    new County_City
            //    {
            //        County_CityID="Z",
            //        County_CityName="連江縣"
            //    },

            //};

            //county_city.ForEach(s => db.County_City.Add(s));
            //db.SaveChanges();

















        }

    }

}