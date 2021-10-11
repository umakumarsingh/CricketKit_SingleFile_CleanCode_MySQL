using System;
using System.Collections.Generic;
using MySqlConnector;

namespace CricketKit
{
    public class Purchase
    {
        /// <summary>
        /// List of entities for purchase details
        /// </summary>
        public int purchaseId { get; set; }
        public string purchaseDate { get; set; }
        public double totalAmount { get; set; }
        public string userName { get; set; }

        /// <summary>
        /// print the purchase records of user
        /// </summary>
        /// <returns></returns>
        override
        public string ToString()
        {
            //do code here.
            throw new NotImplementedException();
        }
        /// <summary>
        /// get purchase details of provideed data as string and return purchase object
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static Purchase obtainPurchaseWithAmount(string str)
        {
            //do code here.
            throw new NotImplementedException();
        }
        /// <summary>
        /// store and save the purchase details in mysql database table
        /// </summary>
        /// <param name="purchaseDetail"></param>
        public static bool StorePurchaseDetails(Purchase purchase)
        {
            //do code here.
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get purchased details from mysql table
        /// </summary>
        /// <returns></returns>
        public static List<Purchase> GetPurchaseDetails()
        {
            //do code here.
            throw new NotImplementedException();
        }
    }
}