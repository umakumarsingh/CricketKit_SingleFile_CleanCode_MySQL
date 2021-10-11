using System;
using System.IO;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace CricketKit.Test.TestCases
{
    public class BoundaryTest
    {
        private readonly ITestOutputHelper _output;
        public BoundaryTest(ITestOutputHelper output)
        {
            _output = output;
        }
        static BoundaryTest()
        {
            if (!File.Exists("../../../../output_boundary_revised.txt"))
                try
                {
                    File.Create("../../../../output_boundary_revised.txt").Dispose();
                }
                catch (Exception)
                {

                }
            else
            {
                File.Delete("../../../../output_boundary_revised.txt");
                File.Create("../../../../output_boundary_revised.txt").Dispose();
            }
        }
        /// <summary>
        /// Test to validate using output PurchaseId is correct or not
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> testFor_TryCheckUserOutputIdCorrectOrNot()
        {
            //Arrange
            bool res = false;
            String str1 = "3,12-12-2012,Jack,Bat,1500,7,Ball,60,1,Stump,340,5,helmet,925,5,Pad,600,15";
            string testName;
            testName = TestAPI.GetCurrentMethodName();
            Purchase p = new Purchase();
            //Act
            try
            {
                p = Purchase.obtainPurchaseWithAmount(str1);
                if (p.purchaseId == 3)
                {
                    res = true;
                }
            }
            catch(Exception)
            {
                //Assert
                //final result save in text file if exception raised
                _output.WriteLine(testName + ":Failed");
                await File.AppendAllTextAsync("../../../../output_boundary_revised.txt", "testFor_TryCheckUserinputStringCount=" + res + "\n");
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
            await File.AppendAllTextAsync("../../../../output_boundary_revised.txt", "testFor_TryCheckUserinputStringCount=" + res + "\n");
            return res;
        }
        [Fact]
        public async Task<bool> testFor_TryCheckUserOutputUserCorrectOrNot()
        {
            //Arrange
            bool res = false;
            String str1 = "3,12-12-2012,Jack,Bat,1500,7,Ball,60,1,Stump,340,5,helmet,925,5,Pad,600,15";
            string testName;
            testName = TestAPI.GetCurrentMethodName();
            Purchase p = new Purchase();
            //Act
            try
            {
                p = Purchase.obtainPurchaseWithAmount(str1);
                if (p.userName == "Jack")
                {
                    res = true;
                }
            }
            catch(Exception)
            {
                //Assert
                //final result save in text file if exception raised
                _output.WriteLine(testName + ":Failed");
                await File.AppendAllTextAsync("../../../../output_boundary_revised.txt", "testFor_TryCheckUserOutputUserCorrectOrNot=" + res + "\n");
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
            await File.AppendAllTextAsync("../../../../output_boundary_revised.txt", "testFor_TryCheckUserOutputUserCorrectOrNot=" + res + "\n");
            return res;
        }
        [Fact]
        public async Task<bool> testFor_TryCheckUserOutputTotalAmountCorrectOrNot()
        {
            //Arrange
            bool res = false;
            String str1 = "3,12-12-2012,Jack,Bat,1500,7,Ball,60,1,Stump,340,5,helmet,925,5,Pad,600,15";
            string testName;
            testName = TestAPI.GetCurrentMethodName();
            Purchase p = new Purchase();
            //Act
            try
            {
                p = Purchase.obtainPurchaseWithAmount(str1);
                if (p.totalAmount == 25885)
                {
                    res = true;
                }
            }
            catch(Exception)
            {
                //Assert
                //final result save in text file if exception raised
                await File.AppendAllTextAsync("../../../../output_boundary_revised.txt", "testFor_TryCheckUserOutputTotalAmountCorrectOrNot=" + res + "\n");
                _output.WriteLine(testName + ":Failed");
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
            await File.AppendAllTextAsync("../../../../output_boundary_revised.txt", "testFor_TryCheckUserOutputTotalAmountCorrectOrNot=" + res + "\n");
            return res;
        }
    }
}
