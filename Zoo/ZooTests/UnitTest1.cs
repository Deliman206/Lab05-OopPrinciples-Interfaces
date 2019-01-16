using System;
using Xunit;
using Zoo.Classes;

namespace ZooTests
{
    public class ReproductionMethodTests
    {
        [Fact]
        public void TigerTest()
        {
            Animals tiger = new SiberianTiger();
            Assert.Equal("I have kids by birth!", tiger.Reproduce(tiger.reproduction));
        }
        [Fact]
        public void HumpBacktest()
        {
            Animals humback = new HumpbackWhale();
            Assert.Equal("I have kids by birth!", humback.Reproduce(humback.reproduction));

        }
        [Fact]
        public void EagleTest()
        {
            Animals eagle = new Eagle();
            Assert.Equal("I have kids by eggs!", eagle.Reproduce(eagle.reproduction));

        }
    }
    public class DiestMethodTests
    {
        [Fact]
        public void GrizzlyTest()
        {
            GrizzlyBear grizzly = new GrizzlyBear();
            Assert.Equal("I eat berries fish insects .", grizzly.Eat(grizzly.diet));
        }
        [Fact]
        public void MallardTest()
        {
            Mallard mallard = new Mallard();
            Assert.Equal("I eat fish eggs fish worms mollusk .", mallard.Eat(mallard.diet));

        }
        [Fact]
        public void TigerTest()
        {
            SiberianTiger tiger = new SiberianTiger();
            Assert.Equal("I eat mice deer insects .", tiger.Eat(tiger.diet));

        }
    }
}
