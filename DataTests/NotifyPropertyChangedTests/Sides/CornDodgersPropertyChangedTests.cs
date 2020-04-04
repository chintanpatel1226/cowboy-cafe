using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace NotifyPropertyChangedTest
{
    public class CornDodgersPropertyChangedTests
    {
        [Fact]
        public void CornDodgersShouldImplementINotifyPropertyChanged()
        {
            var corn = new CornDodgers();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(corn);
        }

        [Fact]
        public void ChangingSizeToSmallInvokesPropertyChangedForSize()
        {
            var corn = new CornDodgers();
            Assert.PropertyChanged(corn, "Size", () =>
                corn.Size = Size.Small
            );
        }

        [Fact]
        public void ChangingSizeToMediumInvokesPropertyChangedForSize()
        {
            var corn = new CornDodgers();
            Assert.PropertyChanged(corn, "Size", () =>
                corn.Size = Size.Medium
            );
        }

        [Fact]
        public void ChangingSizeToLargeInvokesPropertyChangedForSize()
        {
            var corn = new CornDodgers();
            Assert.PropertyChanged(corn, "Size", () =>
                corn.Size = Size.Large
            );
        }
    }
}
