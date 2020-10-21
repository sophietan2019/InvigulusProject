using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ExamTakenManager
    {
        public static List<DAL.ExamTaken> GetSelected(int examid) 
        {
            var db = new InvigulusDBEntities();
            var examTakens = db.ExamTakens.Where(e => e.ExamID == examid).ToList();
            return examTakens;
        }
    }
}
