using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Review_Managment
{
    /// <summary>
    /// Solving By LinQ
    /// LINQ stands for Language Integrated Query
    /// </summary>
   public class Program
    {
        /// <summary>
        /// Entry Point of project
        ///  Display and Create table    
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("_______________WELCOME TO THE PRODUCT REVIEW MANAGEMENT___________________");
            //Creating list for adding details 
            //List name ==productReviewList
           
            List<ProductReview> productReviewList = new List<ProductReview>()
            {
                //Adding details to the list
                new ProductReview(){ProductId=1,UserId=12,Rating=5,Review="Good",isLike=true},
                new ProductReview(){ProductId=2,UserId=32,Rating=4,Review="nice",isLike=false},
                new ProductReview(){ProductId=3,UserId=53,Rating=5,Review="Good",isLike=true},
                new ProductReview(){ProductId=4,UserId=44,Rating=4,Review="nice",isLike=true},
                new ProductReview(){ProductId=5,UserId=02,Rating=3,Review="Average",isLike=false},
                new ProductReview(){ProductId=6,UserId=03,Rating=5,Review="Good",isLike=true},
                new ProductReview(){ProductId=7,UserId=14,Rating=4,Review="nice",isLike=false},
                new ProductReview(){ProductId=8,UserId=13,Rating=4,Review="nice",isLike=true},
                new ProductReview(){ProductId=9,UserId=09,Rating=2,Review="Bad",isLike=false},
                new ProductReview(){ProductId=10,UserId=10,Rating=5,Review="Good",isLike=true},
                new ProductReview(){ProductId=11,UserId=12,Rating=5,Review="Good",isLike=true},
                new ProductReview(){ProductId=12,UserId=22,Rating=4,Review="nice",isLike=false},
                new ProductReview(){ProductId=13,UserId=3,Rating=5,Review="Good",isLike=true},
                new ProductReview(){ProductId=14,UserId=41,Rating=4,Review="nice",isLike=true},
                new ProductReview(){ProductId=15,UserId=02,Rating=3,Review="Average",isLike=false},
                new ProductReview(){ProductId=16,UserId=03,Rating=5,Review="Good",isLike=true},
                new ProductReview(){ProductId=17,UserId=14,Rating=4,Review="nice",isLike=false},
                new ProductReview(){ProductId=18,UserId=13,Rating=4,Review="nice",isLike=true},
                new ProductReview(){ProductId=19,UserId=19,Rating=2,Review="Bad",isLike=false},
                new ProductReview(){ProductId=20,UserId=10,Rating=5,Review="Good",isLike=true},
                new ProductReview(){ProductId=26,UserId=03,Rating=5,Review="Good",isLike=true},
                new ProductReview(){ProductId=27,UserId=14,Rating=4,Review="nice",isLike=false},
                new ProductReview(){ProductId=28,UserId=13,Rating=4,Review="nice",isLike=true},
                new ProductReview(){ProductId=29,UserId=9,Rating=2,Review="Bad",isLike=false},
                new ProductReview(){ProductId=25,UserId=10,Rating=5,Review="Good",isLike=true},
            };
            foreach (var list in productReviewList)
            {
                Console.WriteLine("ProductId:-" + list.ProductId + " UserId:-" + list.UserId + " Ratings:-" + list.Rating + " Review:-" + list.Review + " IsLike:-" + list.isLike);
                Console.ReadLine();
            }
        }
            public static void CreateDataTble()//Adding Method For query
        {
            DataTable table = new DataTable();
            table.Columns.Add("ProductID");
            table.Columns.Add("Production");

            table.Rows.Add("1", "Laptop");
            table.Rows.Add("2", "Mobile");
            table.Rows.Add("3", "TV");

        }
        //Adding Display Method 
        //Datatable Represents one table in memory data
        //AsEnumerabel is object where the generic parameter T is datarow
        //Fields column Value in specified row
        public static void DisplayDatatableContent(DataTable table)
        {
            
            var result = from product in table.AsEnumerable() select product.Field<string>("ProductName");//Returning object
            foreach (var res in result)
            {
                Console.WriteLine("ProductName" + res);
                Console.ReadLine();

            }
        }
    }
}