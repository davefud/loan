﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Ploeh.Samples.Loan;
using Ploeh.Samples.Loan.DataCollection;

namespace Ploeh.Samples.Loan.UnitTest
{
    public class CurrentPropertySoldAsFinancingMortgageApplicationSpecificationTests
    {
        [Fact]
        public void SutIsMortgageApplicationSpecification()
        {
            var sut = new CurrentPropertySoldAsFinancingMortgageApplicationSpecification();
            Assert.IsAssignableFrom<IMortgageApplicationSpecification>(sut);
        }

        [Fact]
        public void IsSatisfiedByReturnsTrueIfCurrentPropertyHasValue()
        {
            var application = new MortgageApplication
            {
                CurrentPropertyWillBeSoldToFinanceNewProperty = true
            };
            var sut = new CurrentPropertySoldAsFinancingMortgageApplicationSpecification();

            var actual = sut.IsSatisfiedBy(application);

            Assert.True(actual);
        }

        [Fact]
        public void IsSatisfiedByReturnsFalseIfCurrentPropertyIsNull()
        {
            var application = new MortgageApplication
            {
                CurrentPropertyWillBeSoldToFinanceNewProperty = false
            };
            var sut = new CurrentPropertySoldAsFinancingMortgageApplicationSpecification();

            var actual = sut.IsSatisfiedBy(application);

            Assert.False(actual);
        }

        [Fact]
        public void SutEqualsOther()
        {
            var sut = new CurrentPropertySoldAsFinancingMortgageApplicationSpecification();
            var other = new CurrentPropertySoldAsFinancingMortgageApplicationSpecification();

            var actual = sut.Equals(other);

            Assert.True(actual);
        }

        [Fact]
        public void SutDoesNotEqualAnonymousObject()
        {
            var sut = new CurrentPropertySoldAsFinancingMortgageApplicationSpecification();
            var anonymous = new object();

            var actual = sut.Equals(anonymous);

            Assert.False(actual);
        }
    }
}
