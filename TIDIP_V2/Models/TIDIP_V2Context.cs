using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TIDIP_V2.Models
{
    public class TIDIP_V2Context:DbContext
    {
        public TIDIP_V2Context() : base("name=TIDIP_V2Connection")
        { 

        }

        public virtual DbSet<Admin> Admin { get; set; }
        public virtual DbSet<Member> Member { get; set; }
        public virtual DbSet<Disaster_Accident> Disaster_Accident { get; set; }
        public virtual DbSet<Disaster_Accident_Type> Disaster_Accident_Type { get; set; }
        public virtual DbSet<Police> Police { get; set; }
        public virtual DbSet<Rescue> Rescue { get; set; }
        public virtual DbSet<Medical> Medical { get; set; }
    }
}