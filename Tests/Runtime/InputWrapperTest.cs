// Copyright (c) 2023 Koji Hasegawa.
// This software is released under the MIT License.

using NUnit.Framework;

namespace TestHelper.Input
{
    [TestFixture]
    public class InputWrapperTest
    {
        [Test]
        public void ToString_Overridden()
        {
            var sut = new InputWrapper();

            Assert.That(sut.ToString(), Is.EqualTo("wrapping UnityEngine.Input"));
        }
    }
}
