using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ExamineeManager
    {
        public static List<Examinee> GetAll()
        {
            var db = new InvigulusDBEntities();
            var examinees=db.Examinees.ToList();
            return examinees;
        }
    }
}
