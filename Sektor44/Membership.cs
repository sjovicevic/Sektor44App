using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sektor44.enums;

namespace Sektor44
{
    public abstract class Membership
    {
        protected MembershipType type;
        protected DateTime startDate;
        protected DateTime endDate;
        protected string? note;
        public MembershipType Type { get; set; }
        public abstract decimal Price { get; set; }


        public DateTime StartDate { get { return startDate; } set { startDate = value; } }
        public DateTime EndDate { get { return endDate; } set { endDate = value; } }
        public string? Note { get { return note; } set { note = value; } }


    }
}
