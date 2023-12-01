using NSubstitute;
using school.Organization.Domain;

namespace school.Organization.Application.Tests
{
    public class Tests
    {
        private IRepositorySchool schoolRepositoryMock;
       
        [SetUp]
        public void Setup()
        {
            
            schoolRepositoryMock = Substitute.For<IRepositorySchool>();
           
        }


        [Test]
        public async Task AddFinanceItem()
        {
            var expectedFinance = new AddFinanceItemCommand()
            {
                Name = "Financa",
                Date = DateTime.Now,
                Value = 10,
                Supplier = "Empresa",
            };

            var result = await splanAppService.AddFinanceItem(expectedFinance, CancellationToken.None);

            Assert.That(result, Is.Not.Empty);
            Assert.That(result, Is.TypeOf<Guid>());
        }
}