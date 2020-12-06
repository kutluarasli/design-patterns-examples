using System;
using System.Collections.Generic;
using DesignPatternExamples.Builder.Example3;
using Moq;
using NUnit.Framework;

namespace DesignPatternExamples.Tests.Builder.Example3
{
    public class IntegrationTests
    {
        [Test]
        public void Import_TrueStory()
        {
            // Arrange
            var currencyProvider = new Mock<ICurrencyProvider>();
            var sampleCurrencies = new List<Currency>
            {
                new DummyCurrency()
            };
            currencyProvider
                .Setup(x => x.ExtractCurrencies())
                .Returns(sampleCurrencies);
            
            var currencyStorage = new Mock<ICurrencyStorage>();

            var currencyImporterServiceBuilder = new FakeCurrencyImporterServiceBuilder(currencyProvider.Object, currencyStorage.Object);
            var currencyImporterService = new CurrencyImporterService(currencyImporterServiceBuilder);
            
            //Act
            currencyImporterService.Import();

            //Assert
            currencyStorage
                .Verify(x => 
                    x.Save(
                        It.Is<List<Currency>>(parameterValue => parameterValue.Equals(sampleCurrencies))
                        )
                    );
        }
    }

    public class FakeCurrencyImporterServiceBuilder : ICurrencyImporterServiceBuilder
    {
        private readonly ICurrencyProvider _currencyProvider;
        private readonly ICurrencyStorage _currencyStorage;

        public FakeCurrencyImporterServiceBuilder(ICurrencyProvider currencyProvider, ICurrencyStorage currencyStorage)
        {
            _currencyProvider = currencyProvider;
            _currencyStorage = currencyStorage;
        }

        public void BuildCurrencyProvider(CurrencyImporterService currencyImporterService)
        {
            currencyImporterService.Provider = _currencyProvider;
        }

        public void BuildCurrencyStorage(CurrencyImporterService currencyImporterService)
        {
            currencyImporterService.Storage = _currencyStorage;
        }
    }

    public class DummyCurrency : Currency
    {
        public DummyCurrency()
        {
            Code = "USD";
            Snapshotdate = DateTime.Now;
            TurkishLiraValue = 7.50M;
        }
    }
}