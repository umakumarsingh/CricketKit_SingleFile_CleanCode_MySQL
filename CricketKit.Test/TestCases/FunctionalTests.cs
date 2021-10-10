using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace CricketKit.Test.TestCases
{
    public class FunctionalTests
    {
        private readonly ITestOutputHelper _output;
        public FunctionalTests(ITestOutputHelper output)
        {
            _output = output;
        }
        static FunctionalTests()
        {
            if (!File.Exists("../../../../output_revised.txt"))
                try
                {
                    File.Create("../../../../output_revised.txt").Dispose();
                }
                catch (Exception)
                {

                }
            else
            {
                File.Delete("../../../../output_revised.txt");
                File.Create("../../../../output_revised.txt").Dispose();
            }
        }
        /// <summary>
        /// Try to test if string array try to parse or not
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> testFor_TryParseStringArrytoInt()
        {
            //Arrange
            bool res = false;
            string testName;
            testName = TestAPI.GetCurrentMethodName();
            String str1 = "3,12-12-2012,Jack,Bat,1500,7,Ball,60,1,Stump,340,5,helmet,925,5,Pad,600,15";
            string[] collectionVal = str1.Split(',');
            //Act
            try
            {
                if (collectionVal != null)
                {
                    int.TryParse(collectionVal[0], out int resultId);
                    if (resultId == 3 && collectionVal.Length <= 18)
                    {
                        res = true;
                    }
                }
            }
            catch (Exception)
            {
                //Assert
                //final result save in text file if exception raised
                _output.WriteLine(testName + ":Failed");
                await File.AppendAllTextAsync("../../../../output_revised.txt", "testFor_TryParseStringArrytoInt=" + res + "\n");
                return false;
            }
            ///Assert
            ///Write final test result
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await File.AppendAllTextAsync("../../../../output_revised.txt", "testFor_TryParseStringArrytoInt=" + res + "\n");
            return res;
        }
        /// <summary>
        /// test the obtainPurchaseWithAmount method that return correct object or not
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> testFor_obtainPurchaseWithAmountReturnObject()
        {
            //Arrange
            bool res = false;
            string testName;
            testName = TestAPI.GetCurrentMethodName();
            String str1 = "3,12-12-2012,Jack,Bat,1500,7,Ball,60,1,Stump,340,5,helmet,925,5,Pad,600,15";
            Purchase p = new Purchase();
            try
            {
                p = Purchase.obtainPurchaseWithAmount(str1);
                //Act
                if (p != null)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                ///Write test result if any exception occur
                _output.WriteLine(testName + ":Failed");
                await File.AppendAllTextAsync("../../../../output_revised.txt", "testFor_obtainPurchaseWithAmountReturnObject=" + res + "\n");
                return false;
            }
            ///Assert
            ///Write final test result
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await File.AppendAllTextAsync("../../../../output_revised.txt", "testFor_obtainPurchaseWithAmountReturnObject=" + res + "\n");
            return res;
        }
        /// <summary>
        /// To check store purchase details is return true or not, if data is stored or not
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> testFor_storePurchaseDetails_ReturnBoolStatus()
        {
            //Arrange
            bool res = false;
            string testName;
            testName = TestAPI.GetCurrentMethodName();
            string str1 = "100,12-12-2012,Jack,Bat,1500,7,Ball,60,1,Stump,340,5,helmet,925,5,Pad,600,15";
            Purchase p = new Purchase();
            try
            {
                p = Purchase.obtainPurchaseWithAmount(str1);
                res = Purchase.StorePurchaseDetails(p);
                //Act
                if (res == true)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                ///Write test result if any exception occur
                _output.WriteLine(testName + ":Failed");
                await File.AppendAllTextAsync("../../../../output_revised.txt", "testFor_storePurchaseDetails_ReturnBoolStatus=" + res + "\n");
                return false;
            }
            ///Assert
            ///Write final test result
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await File.AppendAllTextAsync("../../../../output_revised.txt", "testFor_storePurchaseDetails_ReturnBoolStatus=" + res + "\n");
            return res;
        }
        /// <summary>
        /// To check store purchase details is return true or not, if data is stored is retrive or not
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> testFor_showPurchaseDetails_ReturnBoolStatus()
        {
            //Arrange
            bool res = false;
            List<Purchase> purchaseDetails = new List<Purchase>();
            string testName;
            testName = TestAPI.GetCurrentMethodName();
            string str1 = "100,12-12-2012,Jack,Bat,1500,7,Ball,60,1,Stump,340,5,helmet,925,5,Pad,600,15";
            Purchase p = new Purchase();
            try
            {
                p = Purchase.obtainPurchaseWithAmount(str1);
                purchaseDetails = Purchase.GetPurchaseDetails();
                //Act
                if (purchaseDetails.Count > 0)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                ///Write test result if any exception occur
                _output.WriteLine(testName + ":Failed");
                await File.AppendAllTextAsync("../../../../output_revised.txt", "testFor_storePurchaseDetails_ReturnBoolStatus=" + res + "\n");
                return false;
            }
            ///Assert
            ///Write final test result
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await File.AppendAllTextAsync("../../../../output_revised.txt", "testFor_storePurchaseDetails_ReturnBoolStatus=" + res + "\n");
            return res;
        }
    }
}
