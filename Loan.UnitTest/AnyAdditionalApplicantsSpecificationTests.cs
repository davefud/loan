﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Ploeh.Samples.Loan;

namespace Ploeh.Samples.Loan.UnitTest
{
    public class AnyAdditionalApplicantsSpecificationTests
    {
        [Fact]
        public void SutIsMortgageApplicationSpecification()
        {
            var sut = new AnyAdditionalApplicantsSpecification();
            Assert.IsAssignableFrom<IMortgageApplicationSpecification>(sut);
        }
    }
}
