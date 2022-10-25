using Sektor44.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sektor44
{
    public class FileSavingService : ISave
    {
        public void SaveMember(Member member, string path)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(path))
                {
                    writer.WriteLine($"{member.MemberID}, {member.FirstName}, {member.LastName}, {member.Email}, {member.FirstEntrance}, {member.MemberMembership.Type}, {member.MemberMembership.Price}");
                }
                Console.WriteLine("Input sucessfully saved.");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"{ex.GetType} exception says {ex.Message}");
            }
        }
    }
}
