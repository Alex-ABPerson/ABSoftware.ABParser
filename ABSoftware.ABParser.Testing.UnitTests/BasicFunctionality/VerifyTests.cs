﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ABSoftware.ABParser.Testing.UnitTests.BasicFunctionality
{
    [TestClass]
    public class VerifyTests : UnitTestBase
    {
        [TestMethod]
        [DataRow("Leadings", new string[] { "A", "B", "C", "arD" }, "E")]
        [DataRow("Trailings", new string[] { "B", "C", "arD", "E" }, "")]
        [DataRow("PreviousTokens", new string[] { null, "the", "they", "they" }, "")]
        [DataRow("Tokens", new string[] { "the", "they", "they", "theyare" }, "")]
        [DataRow("NextTokens", new string[] { "they", "they", "theyare", null }, "")]
        public void AllMultiChar_AllVerifyTypes_TriggersStartsWithToken(string toTest, string[] expected, string leadingEndExpected) => RunThey("AtheBtheyCtheyarDtheyareE").Test(toTest, expected, leadingEndExpected);

        [TestMethod]
        [DataRow("Leadings", new string[] { "A", "BtheyC", "Dt" }, "E")]
        [DataRow("Trailings", new string[] { "BtheyC", "Dt", "E" }, "")]
        [DataRow("PreviousTokens", new string[] { null, "theya", "thata" }, "")]
        [DataRow("Tokens", new string[] { "theya", "thata", "hat" }, "")]
        [DataRow("NextTokens", new string[] { "thata", "hat", null }, "")]
        public void AllMultiChar_AllVerifyTypes_TriggersInMiddle(string toTest, string[] expected, string leadingEndExpected) => RunTheyMiddle("AtheyaBtheyCthataDthatE").Test(toTest, expected, leadingEndExpected);
    }
}
