using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF6Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (EF6Entities context = new EF6Entities())
            {
                var item = (from batchUploadData in context.BatchUploadData
                            where batchUploadData.BatchUploadData_Id == 2
                            select batchUploadData).FirstOrDefault();

                item.BatchUploadData_Title = "EF6TESTXX";

                context.SaveChanges();
            }
        }
    }
}
