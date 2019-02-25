using System;
using ExpertSystemShell.Model;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExpertSystemShell.Tests
{
    [TestClass]
    public class ModelTests
    {
        [TestMethod]
        public void DatabaseShouldExist()
        {
            using (var context = new ExpertSystemContext())
            {
                context
                    .Database
                    .Exists()
                    .Should()
                    .BeTrue();
            }
        }
    }
}
