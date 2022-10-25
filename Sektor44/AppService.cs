using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sektor44
{
    public static class AppService
    {
        public static void Start()
        {
            Member stefan = new(1, "Stefan", "Jovicevic", DateTime.Now, "jovicevicst@icloud.com", true, MembershipType.SoloMonth);
            string path = @"C:\Users\Stefan\source\repos\Sektor\Sektor44\misc\fileDatabase.txt";
            FileSavingService fs = new();
            fs.SaveMember(stefan, path);
            

        }
    }
}
