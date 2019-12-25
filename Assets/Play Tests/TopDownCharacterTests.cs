using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class TopDownCharacterTests
    {
        TopDownCharacter topDownCharacter;

        [SetUp]
        public void Setup()
        {
            GameObject player = MonoBehaviour.Instantiate(Resources.Load<GameObject>("Prefabs/Characters/TopDownCharacter"));
            topDownCharacter = player.GetComponent<TopDownCharacter>();
        }

        [TearDown]
        public void Teardown()
        {
            Object.Destroy(topDownCharacter.gameObject);
        }

        [UnityTest]
        public IEnumerator TopDownCharacterPositionChangesOnInput()
        {
            Vector2 playerInitialPosition = topDownCharacter.transform.position;

            topDownCharacter.Move(new Vector2(1.0f, 1.0f));

            yield return new WaitForSeconds(0.1f);

            Assert.AreNotEqual(playerInitialPosition, topDownCharacter.transform.position);
        }

        [UnityTest]
        public IEnumerator TopDownCharacterRotationChangesOnInput()
        {
            Quaternion playerInitialRotation = topDownCharacter.transform.rotation;

            topDownCharacter.Rotate(new Vector2(1.0f, 1.0f));

            yield return new WaitForSeconds(0.1f);

            Assert.AreNotEqual(playerInitialRotation, topDownCharacter.transform.rotation);
        }
    }
}
