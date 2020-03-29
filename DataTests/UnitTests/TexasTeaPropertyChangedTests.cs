using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.UnitTests
{
    public class TexasTeaPropertyChangedTests
    {
        [Fact]
        public void TexasTeaShouldImplementINotifyPropertyChanged()
        {
            var tea = new TexasTea();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(tea);
        }

        [Fact]
        public void ChangingSweetShouldInvokePropertyChangedForSweet()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "Sweet", () =>
            {
                tea.Sweet = false;
            });
        }

        [Fact]
        public void ChangingSweetShouldInvokePropertyChangedForSpecialInstructions()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "SpecialInstructions", () =>
            {
                tea.Sweet = false;
            });
        }

        [Fact]
        public void ChangingLemonShouldInvokePropertyChangedForLemon()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "Lemon", () =>
            {
                tea.Lemon = false;
            });
        }

        [Fact]
        public void ChangingLemonShouldInvokePropertyChangedForSpecialInstructions()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "SpecialInstructions", () =>
            {
                tea.Lemon = false;
            });
        }

        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForIce()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "Ice", () =>
            {
                tea.Ice = false;
            });
        }

        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForSpecialInstructions()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "SpecialInstructions", () =>
            {
                tea.Ice = false;
            });
        }
    }
}
