using DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL
{
    public class ExamManager
    {
      private static InvigulusDBEntities db = new InvigulusDBEntities();
        public static List<Exam> GetAllByExaminerID(int id)
        {
            var exams = db.Exams.Where(e => e.ExaminerID == id).ToList();
            return exams;
                    
        }

        public static void Add(Exam exam)
        {
            db.Exams.Add(exam);
            db.SaveChanges();
        }

        public static void Delete(int id)
        {

            var entity = db.Exams.SingleOrDefault(e => e.ExamID == id);
            db.Exams.Remove(entity);
            db.SaveChanges();
        }

        public static void Update(Exam exam)
        {
            var entity = db.Exams.SingleOrDefault(e => e.ExamID == exam.ExamID);
           
            db.Entry(entity).CurrentValues.SetValues(exam);

            db.SaveChanges();
        }

        public static Exam GetSelectedExam(int id)
        {
            var exam = db.Exams.SingleOrDefault(e => e.ExamID == id);
            return exam;
        }
        public static  Array GetExamID(int examinerId)
        {
            var exams = db.Exams.Where(e => e.ExaminerID == examinerId).Select
                (p => p.ExamID).ToArray();
            return exams;
        }
    }
}
