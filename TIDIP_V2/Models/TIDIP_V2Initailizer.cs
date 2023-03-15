using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

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













        }


    }
}