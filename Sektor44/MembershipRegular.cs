using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sektor44
{
    public class MembershipRegular : Membership
    {
        protected static Dictionary<MembershipType, decimal> RegularPrice = new()
        {
            {MembershipType.Visitor, 500},
            {MembershipType.GroupMonth, 5000},
            {MembershipType.CombinedMonth, 5800 },
            {MembershipType.SoloMonth, 3900},
            {MembershipType.Year, 33000 }
        };

        protected decimal price;
        public override decimal Price { get { return price; } set { price = value; } }

        public MembershipRegular(MembershipType _type, DateTime _startDate, DateTime _endDate, string? _note)
        {
            this.Type = _type;
            this.StartDate = _startDate;
            this.EndDate = _endDate;
            this.Note = _note;
            this.Price = RegularPrice[_type];
        }

    }
}
