// Copyright (c) 2023 Koji Hasegawa.
// This software is released under the MIT License.

using System;
using System.Collections;
using NUnit.Framework;
using TestHelper.Input.SUT;
using TestHelper.Input.TestDoubles;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.TestTools.Utils;

// ReSharper disable Unity.InefficientPropertyAccess

namespace TestHelper.Input
{
    [TestFixture]
    public class UsingStubInputTest
    {
        [UnityTest]
        public IEnumerator PushW_MoveForward()
        {
            var sut = new GameObject().AddComponent<SampleController>();
            var stub = new StubInput();
            sut.Input = stub; // Inject test stub

            stub.PushedKeys = new[] { KeyCode.W }; // Push W key
            yield return new WaitForSeconds(0.5f);
            stub.PushedKeys = Array.Empty<KeyCode>(); // Release key

            var actual = sut.transform.position;
            Assert.That(actual, Is.EqualTo(new Vector3(0f, 0f, 4f))
                .Using(new Vector3EqualityComparer(0.3f)));
        }

        [UnityTest]
        public IEnumerator PushA_MoveLeft()
        {
            var sut = new GameObject().AddComponent<SampleController>();
            var stub = new StubInput();
            sut.Input = stub; // Inject test stub

            stub.PushedKeys = new[] { KeyCode.A };
            yield return new WaitForSeconds(0.5f);
            stub.PushedKeys = Array.Empty<KeyCode>();

            var actual = sut.transform.position;
            Assert.That(actual, Is.EqualTo(new Vector3(-4f, 0f, 0f))
                .Using(new Vector3EqualityComparer(0.3f)));
        }

        [UnityTest]
        public IEnumerator PushS_MoveBack()
        {
            var sut = new GameObject().AddComponent<SampleController>();
            var stub = new StubInput();
            sut.Input = stub; // Inject test stub

            stub.PushedKeys = new[] { KeyCode.S };
            yield return new WaitForSeconds(0.5f);
            stub.PushedKeys = Array.Empty<KeyCode>();

            var actual = sut.transform.position;
            Assert.That(actual, Is.EqualTo(new Vector3(0f, 0f, -4f))
                .Using(new Vector3EqualityComparer(0.3f)));
        }

        [UnityTest]
        public IEnumerator PushD_MoveRight()
        {
            var sut = new GameObject().AddComponent<SampleController>();
            var stub = new StubInput();
            sut.Input = stub; // Inject test stub

            stub.PushedKeys = new[] { KeyCode.D };
            yield return new WaitForSeconds(0.5f);
            stub.PushedKeys = Array.Empty<KeyCode>();

            var actual = sut.transform.position;
            Assert.That(actual, Is.EqualTo(new Vector3(4f, 0f, 0f))
                .Using(new Vector3EqualityComparer(0.3f)));
        }
    }
}
