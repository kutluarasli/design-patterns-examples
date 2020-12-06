using System;
using System.Collections.Generic;
using DesignPatternExamples.Builder.Example2;
using Moq;
using NUnit.Framework;

namespace DesignPatternExamples.Tests.Builder.Example2
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
            var currencyImporterServiceDirector = new CurrencyImporterServiceDirector(currencyImporterServiceBuilder);
            var currencyImporterService = currencyImporterServiceDirector.GetCurrencyImporterService();


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
        private readonly CurrencyImporterService _result;

        public FakeCurrencyImporterServiceBuilder(ICurrencyProvider currencyProvider, ICurrencyStorage currencyStorage)
        {
            _currencyProvider = currencyProvider;
            _currencyStorage = currencyStorage;
            _result = new CurrencyImporterService();
        }

        public void BuildCurrencyProvider()
        {
         
            _result.Provider = _currencyProvider;
        }

        public void BuildCurrencyStorage()
        {
            _result.Storage = _currencyStorage;
        }

        public CurrencyImporterService GetResult()
        {
            return _result;
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