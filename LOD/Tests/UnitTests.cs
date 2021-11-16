using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using LOD.Classes;

namespace LOD.Tests
{
    public class UnitTests
    {
        public int Add(int y, int x)
        {
            return y + x;
        }
        public bool IsOdd(int x)
        {
            return x % 2 == 1;
        }

        [Fact]
        public void PassingTest()
        {
            Assert.Equal(4, Add(2, 2));
        }

        [Fact]
        public void FailingTest()
        {
            Assert.NotEqual(5, Add(2, 2));
        }

        [Fact]
        public void PlayerFlagsAreAbleToChange()
        {
            PlayerFlags playerFlags = new PlayerFlags();
            playerFlags.Rock_Champion = true;

            Assert.True(playerFlags.Rock_Champion);
        }

        [Fact]
        public void DoPlayerFlagsReset()
        {
            PlayerFlags playerFlags = new PlayerFlags();
            playerFlags.Rock_Champion = true;
            playerFlags.Reset();

            Assert.False(playerFlags.Rock_Champion);
        }
        [Fact]
        public void TypeWriterTypesFullMessage()
        {
            Assert.True(false);
        }
        [Fact]
        public void TypeWriterSkipWritesFullMessage()
        {
            Assert.True(false);
        }
        [Theory]
        [InlineData(false)]
        [InlineData(false)]
        [InlineData(false)]
        [InlineData(false)]
        [InlineData(false)]
        [InlineData(false)]
        public void TypeWithLineBreaksWorksWithAnyLengthMessage(bool msg)
        {
            Assert.True(msg);
        }
        [Fact]
        public void TauntGeneratorCreatesLegibleTaunt()
        {
            Assert.True(false);
        }
        [Fact]
        public void ShiaVictoryScenePrintsFully()
        {
            Assert.True(false);
        }
        [Fact]
        public void ShiaDefeatScenePrintsFully()
        {
            Assert.True(false);
        }
        [Theory]
        [InlineData(false)]
        [InlineData(false)]
        [InlineData(false)]
        [InlineData(false)]
        [InlineData(false)]
        [InlineData(false)]
        public void MenuReturnsCorrectIndex(bool index)
        {
            Assert.True(index);
        }
    }
}
