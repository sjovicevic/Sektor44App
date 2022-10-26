using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sektor44.enums;

namespace Sektor44
{
    public class MembershipStudent : Membership
    {

        protected static Dictionary<MembershipType, decimal> StudentPrice = new()
        {
            {MembershipType.Visitor, 450},
            {MembershipType.GroupMonth, 4500},
            {MembershipType.CombinedMonth, 5200 },
            {MembershipType.SoloMonth, 3300},
            {MembershipType.Year, 29000 }
        };

        protected decimal price;
        public override decimal Price { get { return price; } set { price = value; } }

        public MembershipStudent(MembershipType _type, DateTime _startDate, DateTime _endDate, string? _note)
        {
            this.Type = _type;
            this.StartDate = _startDate;
            this.EndDate = _endDate;
            this.Note = _note;
            this.Price = StudentPrice[_type];
        }


    }
}
