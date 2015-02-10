﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace KarmaTestAdapterTests.TestResults.SuiteTests
{
    partial class TestResults
    {
        partial class Suite
        {
            partial class Empty
            {
                [Fact(DisplayName = "Line should be null")]
                public void LineShouldBeNull()
                {
                    Assert.Null(Item.Line);
                }
            }

            [Fact(DisplayName = "Line should not be null")]
            public void LineShouldNotBeNull()
            {
                Assert.NotNull(Item.Line);
            }

            [Fact(DisplayName = "Line should be correct")]
            public void LineShouldBeCorrect()
            {
                Assert.Equal(8, Item.Line);
            }
        }
    }
}
