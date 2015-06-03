using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Data
{
    class DataInfo
    {
        public void AddNewRecord(string name, int score, DateTime time)
        {
            ResultDataContext db = new ResultDataContext();
            Result result = new Result();

            result.Name = name;
            result.Score = score;
            result.Time = time;

            try
            {
                db.Results.InsertOnSubmit(result);
                db.SubmitChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static List<Result> GetAllRecords()
        {
            ResultDataContext db = new ResultDataContext();
            var queryResult = (from result in db.GetTable<Result>()
                               select result)
                                .OrderBy(result => result.Time.Second)
                                .ThenBy(result=> result.Time.Millisecond)
                               .ToList<Result>();
            return queryResult;
        }
    }
}
