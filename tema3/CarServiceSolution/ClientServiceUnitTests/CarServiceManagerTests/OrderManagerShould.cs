using CarService;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using CarService.Repos;
using CarServiceManager.Managers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = Xunit.Assert;

namespace ClientServiceUnitTests.CarServiceManagerTests
{
    [TestClass]
    public class OrderManagerShould
    {
        [TestMethod]
        //[Fact]
        //[Category("IntegrationTest")]
        public void ReturnComandaListForClientId()
        {
            //Arrange
            int clientId = 0;
            int comandaId_one = -1;
            int comandaId_two = -2;
            var clientTest = new Client()
            {
                Id = 0
            };

            var _manager = new OrderManager();

            var comandaLst = new List<Comanda>
            {
                new Comanda()
                {
                    Client = clientTest,
                    ComandaID = comandaId_one
                },
                new Comanda()
                {
                    Client = clientTest,
                    ComandaID = comandaId_two
                }
            };
            Populate(comandaLst, clientTest, new ComandaRepo(), new ClientRepo());

            //Act
            var result = _manager.GetOrderByAuto(clientId);
            //Assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(result.Count, 2);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(result.ElementAt(0).ComandaID, comandaId_one);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(result.ElementAt(1).ComandaID, comandaId_two);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(result.ElementAt(1).Client.Id, clientId);

            /*
            Assert.Equal(result.Count, 2);
            Assert.Equal(result.ElementAt(0).ComandaID, comandaId_one);
            Assert.Equal(result.ElementAt(1).ComandaID, comandaId_two);
            Assert.Equal(result.ElementAt(1).Client.Id, clientId);
            */
            //cleanup
            CleanUp(comandaLst, clientTest, new ComandaRepo(), new ClientRepo());
        }

        private void Populate(List<Comanda> lst, Client client, ComandaRepo repo, ClientRepo clientRepo)
        {
            clientRepo.Add(client);

            foreach (var c in lst)
            {
                repo.Add(c);
            }
        }

        private void CleanUp(List<Comanda> lst, Client client, ComandaRepo repo, ClientRepo clientRepo)
        {
            foreach (var c in lst)
            {
                repo.Delete(c);
            }
            clientRepo.Delete(client);
        }
    }
}
