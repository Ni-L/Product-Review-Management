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
            // RetrivedBaseOnRatingProductId(productReviewList);
            //IterateoverProductList(productReviewList);           
            //Calling Top records
            //RetrivedTop3RecordsFromList(productReviewList);
            // CountingProductId(productReviewList);
            //RetrivedProductIdAndReview(productReviewList);
            SkiipingRecord(productReviewList);
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
        //UC1
        public static void IterateoverProductList(List<ProductReview> productReviews)
        {
            foreach (ProductReview product in productReviews)
            {
                Console.WriteLine("ProductId: " + product.ProductId + "\t" + "USerId " + product.UserId + "\t" + "Review" + product.Review + "\t" + "Rating" + product.Rating + "\t" + "ISLike" + product.isLike);
            }
        }
        //UC2
        //Select record by order by clause
        public static void RetrivedTop3RecordsFromList(List<ProductReview> productReviews)
        {
            try
            {

                //using Query Syntax
                var result = (from product in productReviews orderby product.Rating descending select product).Take(3);
                Console.WriteLine("********************Top Three Records**********************");

                foreach (ProductReview product in result)
                {
                    Console.WriteLine("| ProductId: " + product.ProductId + "\t" + "USerId " + product.UserId + "\t" + "Review" + product.Review + "\t" + "Rating" + product.Rating + "\t" + "ISLike" + product.isLike);
                    Console.ReadLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //UC3
        //Base on Rating 
        //Using Lamda Expression
        public static void RetrivedBaseOnRatingProductId(List<ProductReview> productReviews)
        {
            try
            {
                Console.WriteLine("**********************RetrivedBaseOnRatingProductId****************");
                //Query by Lamda Expression
                var data = (productReviews.Where(r => r.Rating > 3 && (r.ProductId == 1 || r.ProductId == 4 || r.ProductId == 9))).ToList();
               // var recordedData = (from product in productReviews
                                   // where product.Rating > 3 && (product.ProductId == 1 || product.ProductId == 4 || product.ProductId == 9)
                                    // select product);

                foreach (var element in data)
                {
                    Console.WriteLine("ProductId:-" + element.ProductId + " UserId:-" + element.UserId + " Ratings:-" + element.Rating + " Review:-" + element.Review + " IsLike:-" + element.isLike);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //Uc4
        //For Count
        //use Lamda Expression for Query
        public static void CountingProductId(List<ProductReview> productReviews)
        {
            try
            {
                Console.WriteLine("*********************CountingProductId***********************");
                var recordData = productReviews.GroupBy(r => r.UserId).Select(r => new { productId = r.Key, count = r.Count() });

                foreach (var element in recordData)
                {
                    Console.WriteLine("UserId:-" + element.productId + " Count:-" + element.count);
                    Console.ReadLine();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //UC5
        //RetrivedProductIdAndReview
        public static void RetrivedProductIdAndReview(List<ProductReview> productreview)
        {
            try
            {

                Console.WriteLine("***************RetrivedProductIdAndReview*******************");
                var recordData = productreview.Select(r => new { r.ProductId, r.Review });

                foreach (var element in recordData)
                {
                    Console.WriteLine("product Id:-" + element.ProductId + " Review :-" + element.Review);
                    Console.ReadLine();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void SkiipingRecord(List<ProductReview> productReviews)
        {
            try
            {
                Console.WriteLine("**********************SkiipingRecord****************");
                var recordedData = (from products in productReviews
                                    select products).Skip(5);
                foreach (var element in recordedData)
                {
                    Console.WriteLine("ProductId:-" + element.ProductId + " UserId:-" + element.UserId + " Ratings:-" + element.Rating + " Review:-" + element.Review + " IsLike:-" + element.isLike);
                    Console.ReadLine();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

}