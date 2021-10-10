using System;
using System.IO;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace CricketKit.Test.TestCases
{
    public class ExceptionalTest
    {
        private readonly ITestOutputHelper _output;
        public ExceptionalTest(ITestOutputHelper output)
        {
            _output = output;
        }
        static ExceptionalTest()
        {
            if (!File.Exists("../../../../output_exception_revised.txt"))
                try
                {
                    File.Create("../../../../output_exception_revised.txt").Dispose();
                }
                catch (Exception)
                {

                }
            else
            {
                File.Delete("../../../../output_exception_revised.txt");
                File.Create("../../../../output_exception_revised.txt").Dispose();
            }
        }
        /// <summary>
        /// Test user input count is <= 15 or not
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> testFor_TryCheckUserinputStringCount()
        {
            //Arrange
            bool res = false;
            string testName;
            testName = TestAPI.GetCurrentMethodName();
            string str1 = "3,12-12-2012,Jack,Bat,1500,7,Ball,60,1,Stump,340,5,helmet,925,5,Pad,600,15";
            string[] collectionVal = str1.Split(',');
            //Act
            try
            {
                if (collectionVal != null)
                {
                    if (collectionVal.Length <= 18)
                    {
                        res = true;
                    }
                }
            }
            catch (Exception)
            {
                //final result save in text file if exception raised
                _output.WriteLine(testName + ":Failed");
                await File.AppendAllTextAsync("../../../../output_exception_revised.txt", "testFor_TryCheckUserinputStringCount=" + res + "\n");
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
            await File.AppendAllTextAsync("../../../../output_exception_revised.txt", "testFor_TryCheckUserinputStringCount=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Try to test and check output in correct count
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> testFor_TryCheckOutputInCorrectCount()
        {
            //Arrange
            bool res = false;
            string str1 = "3,12-12-2012,Jack,Bat,1500,7,Ball,60,1,Stump,340,5,helmet,925,5,Pad,600,15";
            string testName;
            testName = TestAPI.GetCurrentMethodName();
            Purchase p = new Purchase();
            p = Purchase.obtainPurchaseWithAmount(str1);
            string finalOutput = p.ToString();
            string[] collectionVal = finalOutput.Split(',');
            //Act
            try
            {
                if (collectionVal != null)
                {
                    if (collectionVal.Length == 3)
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
                await File.AppendAllTextAsync("../../../../output_exception_revised.txt", "testFor_TryCheckOutputInCorrectCount=" + res + "\n");
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
            await File.AppendAllTextAsync("../../../../output_exception_revised.txt", "testFor_TryCheckOutputInCorrectCount=" + res + "\n");
            return res;
        }
    }
}
