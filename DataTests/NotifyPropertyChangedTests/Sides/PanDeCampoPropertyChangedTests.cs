using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace NotifyPropertyChangedTest
{
    public class PanDeCampoPropertyChangedTests
    {
        [Fact]
        public void PanDeCampoShouldImplementINotifyPropertyChanged()
        {
            var campo = new PanDeCampo();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(campo);
        }

        [Fact]
        public void ChangingSizeToSmallInvokesPropertyChangedForSize()
        {
            var campo = new PanDeCampo();
            Assert.PropertyChanged(campo, "Size", () =>
                campo.Size = Size.Small
            );
        }

        [Fact]
        public void ChangingSizeToMediumInvokesPropertyChangedForSize()
        {
            var campo = new PanDeCampo();
            Assert.PropertyChanged(campo, "Size", () =>
                campo.Size = Size.Medium
            );
        }

        [Fact]
        public void ChangingSizeToLargeInvokesPropertyChangedForSize()
        {
            var campo = new PanDeCampo();
            Assert.PropertyChanged(campo, "Size", () =>
                campo.Size = Size.Large
            );
        }
    }
}
