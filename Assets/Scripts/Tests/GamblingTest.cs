using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;


public class GamblingTest {

    [Test]
    public void OrdinaryTest() {
        int a = 10;
        int b = 11;
        int sum = a + b;
        Assert.AreEqual(sum, 21);
    }

    [UnityTest]
    public IEnumerator UnityTest() {
        GameObject go = new GameObject("cardGame");
        go.AddComponent<CardGame>();
        CardGame cardGame = go.GetComponent<CardGame>();

        Card card = new Card{ 
            num = Random.Range(1, 14) 
        };

        string value = cardGame.GetValue(card);
        Debug.Log("result : " + value);
        yield return null;
    }

    [UnityTest]
    public IEnumerator MonoBehaviourUnityTest()
    {
        yield return new MonoBehaviourTest<MyMonoBehaviourTest>();
    }

    public class MyMonoBehaviourTest : MonoBehaviour, IMonoBehaviourTest {
        private int cardNumber = 0;
        private int tryCount = 0;
        public bool IsTestFinished {
            get { return cardNumber == 1; }
        }

        void Update() {
            this.tryCount++;
            Debug.Log($"tryCount : {this.tryCount}");
            int number = Random.Range(1, 14);
            Card card = CreateCard(number);
            if (card.num is 1) {
                this.cardNumber = 1;
                Debug.Log("end");
            }
        }

        Card CreateCard(int number) {
            Card card = new Card {
                num = number
            };
            return card;
        }
    }
}