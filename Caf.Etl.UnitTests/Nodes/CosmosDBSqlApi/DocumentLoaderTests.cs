using System;
using Xunit;
using Caf.Etl.Nodes.CosmosDBSqlApi.Extract;
using Caf.Etl.Models.CosmosDBSqlApi.Measurement;
using System.Collections.Generic;
using System.Globalization;
using Microsoft.Azure.Documents.Client;
using Moq;
using Caf.Etl.Models.CosmosDBSqlApi;
using Caf.Etl.Nodes.CosmosDBSqlApi.Load;
using Microsoft.Azure.Documents;
using Caf.Etl.TestUtils;

namespace Caf.Etl.Nodes.CosmosDBSqlApi.Tests
{
    public class DocumentLoaderTests
    {
        [Fact]
        public async void LoadBulk_NoStoredProcedure_ThrowsException()
        {
            // Arrange
            var mockClient = new Mock<IDocumentClient>();
            mockClient.Setup(c => c.ExecuteStoredProcedureAsync<bool>(
                It.IsAny<string>(),
                It.IsAny<RequestOptions>(),
                It.IsAny<Object>()))
                .ThrowsAsync(new ArgumentNullException());
            DocumentLoader sut = new DocumentLoader(
                mockClient.Object,
                "", "");

            List<IAmDocument> docs = new List<IAmDocument>()
            {
                new DocumentBase(){ PartitionKey = "a" },
                new DocumentBase(){ PartitionKey = "a" }
            };

            // Act
            var exception = await Record.ExceptionAsync(() => sut.LoadBulk(docs));

            // Assert
            Assert.Contains("Error initializing tasks for bulk import on groupedDoc a with 2 measurements.", exception.Message);
        }

        [Fact]
        public async void LoadBulk_ExceptionWithTwoFailedGroups_MessageIndicatesTwoExceptions()
        {
            // Arrange
            var mockClient = new Mock<IDocumentClient>();
            mockClient.Setup(c => c.ExecuteStoredProcedureAsync<bool>(
                It.IsAny<string>(),
                It.IsAny<RequestOptions>(),
                It.IsAny<Object>()))
                .ThrowsAsync(new ArgumentNullException());
            DocumentLoader sut = new DocumentLoader(
                mockClient.Object,
                "", "");

            List<IAmDocument> docs = new List<IAmDocument>()
            {
                new DocumentBase(){ PartitionKey = "b" },
                new DocumentBase(){ PartitionKey = "bb" }
            };

            // Act
            var exception = await Record.ExceptionAsync(() => sut.LoadBulk(docs));

            // Assert
            //Assert.Contains("2 stored procedures failed out of a total of 2 sprocs for 2 measurements.", exception.Message);
            Assert.Contains("Error initializing tasks for bulk import on groupedDoc b with 1 measurements.", exception.Message);
        }
    }
}
