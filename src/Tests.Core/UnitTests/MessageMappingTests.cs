using Generic.Common.Events;
using Generic.Common.Helpers;
using Generic.Common.Messages;
using Generic.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tests.Core.SampleObjects;

namespace Tests.Core
{
    [TestClass]
    public class MessageMappingTests
    {
        [TestMethod]
        public void TestShouldCreateManagedMessage_AddRequested()
        {
            // Given
            var now = new DateTime(2021, 10, 4, 7, 7, 7);
            var guid = Guid.Parse("6d094222-a2e8-4c5d-a309-c0d8347ddf17");
            var rawMsg = SampleMessage.Create("{\"Name\": \"John Doe\"}");

            // When
            var result = MessageMapping.CreateManagedMessage(rawMsg);

            // Then
            var msg = (ManagedMessage<AddRequested>)result.GetValue();

            Assert.AreEqual("John Doe", msg.Data.Name);
            Assert.AreEqual(now, msg.Timestamp);
            Assert.AreEqual(guid, msg.MessageId);
        }
    }
}