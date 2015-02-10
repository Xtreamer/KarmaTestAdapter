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
                [Fact(DisplayName = "Column should be null")]
                public void ColumnShouldBeNull()
                {
                    Assert.Null(Item.Column);
                }
            }

            [Fact(DisplayName = "Column should not be null")]
            public void ColumnShouldNotBeNull()
            {
                Assert.NotNull(Item.Column);
            }

            [Fact(DisplayName = "Column should be correct")]
            public void ColumnShouldBeCorrect()
            {
                Assert.Equal(4, Item.Column);
            }
        }
    }
}
