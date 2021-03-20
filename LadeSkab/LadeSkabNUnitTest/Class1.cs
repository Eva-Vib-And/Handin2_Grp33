using System;
using System.Collections.Generic;
using System.Text;
using LadeSkab;
using NUnit.Framework;

namespace LadeSkabNUnitTest
{
    class TestChargeControl
    {
       private FakeUsbCharger fakeUsbCharger;
       

        [SetUp]
        public void Setup()
        {
            ChargeControl _chargeControl = new ChargeControl(fakeUsbCharger);
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

    }
}
