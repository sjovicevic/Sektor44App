using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sektor44.interfaces
{
    internal interface ISave
    {
        public void SaveMember(Member member, string path);
    }
}
