using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Neo4jClient;
using Neo4jClient.Cypher;

namespace Ladder.Tests
{
    [TestClass]
    public class UnitTest1
    {
        private GraphClient client;

        [TestInitialize]
        public void Setup()
        {
            client = new GraphClient(new Uri("http://localhost.:7474/db/data"));
            client.Connect();
        }

        [TestMethod]
        public void CreateData()
        {

        }


        [TestMethod]
        public void ClearDatabase()
        {
            var query = client
               .Cypher
               .Start(new { n = All.Nodes })
               .Match("n-[r]-()")
               .Delete("n, r");

            query.ExecuteWithoutResults();

            query = client
            .Cypher
            .Start(new { n = All.Nodes })
            .Delete("n");

            query.ExecuteWithoutResults();

        }
    }
}
