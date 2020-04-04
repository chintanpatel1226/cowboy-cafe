using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace NotifyPropertyChangedTest
{
    public class BakedBeansPropertyChangedTests
    {
        [Fact]
        public void BakedBeasShouldImplementINotifyPropertyChanged()
        {
            var beans = new BakedBeans();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(beans);
        }

        [Fact]
        public void ChangingSizeToSmallInvokesPropertyChangedForSize()
        {
            var beans = new BakedBeans();
            Assert.PropertyChanged(beans, "Size", () =>
                beans.Size = Size.Small
            );
        }

        [Fact]
        public void ChangingSizeToMediumInvokesPropertyChangedForSize()
        {
            var beans = new BakedBeans();
            Assert.PropertyChanged(beans, "Size", () =>
                beans.Size = Size.Medium
            );
        }

        [Fact]
        public void ChangingSizeToLargeInvokesPropertyChangedForSize()
        {
            var beans = new BakedBeans();
            Assert.PropertyChanged(beans, "Size", () =>
                beans.Size = Size.Large
            );
        }
    }
}
