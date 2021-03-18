using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LUG_PIM3_Ana_Laura_Moyano.Test
{
    [TestClass]
    public class RegexTest
    {
        [TestMethod]
        public void ValidarCorreo()
        {
            Regex regex = new Regex(@"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*@((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))\z");
            Assert.IsTrue(regex.IsMatch("el.norman01@gmail.com"));
            Assert.IsFalse(regex.IsMatch("gmail.com"));
            Assert.IsFalse(regex.IsMatch("a"));
            Assert.IsTrue(regex.IsMatch("laura@vaina.com"));
        }
    }
}
