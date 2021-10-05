using Generic.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tests.Core.SampleObjects;

namespace Tests.Core
{
    [TestClass]
    public class ProcessMessageTests
    {
        [TestMethod]
        public void TestShouldProcessOneMessage()
        {
            // Given
            var now = new DateTime(2021, 10, 4, 7, 7, 7);
            var guid = Guid.Parse("03039638-a498-4c03-859c-6f4eac0f5928");
            var processOneMessage = ProcessMessage.Process(() => now, () => guid);
            var message = SampleMessage.Create();

            // When
            var result = processOneMessage(message);

            // Then
            Assert.AreEqual(new ValueTuple(), result);
        }
    }
}