using DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ExamAdministratorManager
    {
        private static InvigulusDBEntities db = new InvigulusDBEntities();

        public static ExamAdministrator GetByEmail(string email)
        {
            var admin = db.ExamAdministrators.SingleOrDefault(a => a.ExaminerEmail == email);
            return admin;
        }

        public static ExamAdministrator GetByID(int id)
        {
            var admin = db.ExamAdministrators.SingleOrDefault(a => a.ExaminerID== id);
            return admin;
        }

        public static void Update(ExamAdministrator examadmin)
        {
            
                var entity = db.ExamAdministrators.SingleOrDefault(e => e.ExaminerID == examadmin.ExaminerID);

                db.Entry(entity).CurrentValues.SetValues(examadmin);

                db.SaveChanges();
            

            //catch (DbEntityValidationException ex)
            //{
            //    foreach (var errors in ex.EntityValidationErrors)
            //    {
            //        foreach (var validationError in errors.ValidationErrors)
            //        {
            //            // get the error message 
            //            string errorMessage = validationError.ErrorMessage;
            //        }
            //    }
            //}

        }
    }
}
