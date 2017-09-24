using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (EF5Entities context = new EF5Entities())
            {
                var item = (from batchUploadData in context.BatchUploadData
                            where batchUploadData.BatchUploadData_Id == 2
                            select batchUploadData).FirstOrDefault();

                item.BatchUploadData_Title = "EF5TEST";

                context.SaveChanges();
            }
        }
    }
}
