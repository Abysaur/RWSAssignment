using CustomLogicApp.FileReader;
using NUnit.Framework;
using System;
using System.IO;

namespace CaseStudy_TestApp
{
    public class Step1Test
    {
        [Test]
        public void MethodToCheckSuccessMessage()
        {
            string[] fileArray = Directory.GetFiles(Environment.CurrentDirectory, "*.xml", SearchOption.AllDirectories);
            CustomDataReader customDataReader = new CustomDataReader();
            //customDataReader.GetResult(fileArray);
            var actualValue= customDataReader.GetResult(fileArray);
            //Test to Check
            string expectedResult = "success";
            Assert.AreEqual(expectedResult, actualValue);
            
        }
        [Test]
        public void MethodToFailSuccess()
        {
            string[] fileArray = Directory.GetFiles(Environment.CurrentDirectory, "*.xml", SearchOption.AllDirectories);
            CustomDataReader customDataReader = new CustomDataReader();
            //customDataReader.GetResult(fileArray);
            var actualValue = customDataReader.GetResult(fileArray);
            //Test to Check
            string expectedResult = "success";
            Assert.AreNotEqual(expectedResult, actualValue);

        }
    }
}
