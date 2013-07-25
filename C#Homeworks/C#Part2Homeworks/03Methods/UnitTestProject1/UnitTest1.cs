using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestName1()
        {
            string name = "";
            Hello.PrintName(name);
           
        }
        [TestMethod]
        public void TestName2()
        {
            string name = null;
            Hello.PrintName(name);
        }
        [TestMethod]
        public void TestName3()
        {
            string name = "'@13jl04546fjhkhgk*7645";
            Hello.PrintName(name);
           
        }

    }
}
