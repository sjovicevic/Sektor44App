using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Sektor44
{
    public class Member
    {
        private int memberId;

        public int MemberID
        {
            get { return memberId; }
            set
            {
                if (value < 1)
                    throw new ArgumentOutOfRangeException("Member ID is not valid.");
                memberId = value;
            }
        }

        protected string? firstName;

        public string? FirstName
        {
            get { return firstName; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentNullException("First name cannot be null.");
                firstName = value;
            }
        }

        protected string? lastName;
        public string? LastName
        {
            get { return lastName; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Last name cannot be null.");
                lastName = value;
            }
        }


        protected DateTime firstEntrance;
        public DateTime FirstEntrance { get { return firstEntrance; } set { firstEntrance = DateTime.Now; } }

        protected string? email;
        public string? Email
        {
            get { return email; }
            set { if (value == null) email = "Unknown"; else email = value; }
        }

        protected bool student;
        public bool Student { get { return student; } set { student = value; } }

        protected Membership? memberMembership;
        public Membership? MemberMembership { get { return memberMembership; } set { memberMembership = value; } }

 
        protected delegate Membership GetMembership(bool x, MembershipType memType);

        protected static Membership DelBoy(bool x, MembershipType memType)
        {
            if (x)
            {
                return new MembershipStudent(memType, DateTime.Now, DateTime.Now, "new user");
            }
            else
                return new MembershipRegular(memType, DateTime.Now, DateTime.Now, "new regular user");
        }
        

        public Member(int _memberID, string? _firstName, string? _lastName, DateTime _firstEntrance, string? _email, bool _student, MembershipType _membership)
        {
            GetMembership getmem = DelBoy;
            this.MemberID = _memberID;
            this.FirstName = _firstName;
            this.LastName = _lastName;
            this.FirstEntrance = _firstEntrance;
            this.Email = _email;
            this.Student = _student;
            this.MemberMembership = getmem(_student, _membership);
        }




    }
}
