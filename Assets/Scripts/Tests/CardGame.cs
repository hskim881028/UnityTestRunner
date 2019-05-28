using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardGame : MonoBehaviour {
    private List<Card> ace = new List<Card> { 
        new Card { num = 1},
    };
    private List<Card> normal = new List<Card> { 
        new Card { num = 2 },
        new Card { num = 3 },
        new Card { num = 4 },
        new Card { num = 5 },
        new Card { num = 6 },
        new Card { num = 7 },
        new Card { num = 8 },
        new Card { num = 9 },
        new Card { num = 10 },
    };
    private List<Card> rare = new List<Card> { 
        new Card { num = 11 },
        new Card { num = 12 },
        new Card { num = 13 },
    };
    public string GetValue(Card card) {
        switch (card) {
            case Card c when this.ace.Exists(x => x.num == card.num):
                return string.Format($"<ace> number is {c.Value()}");
            case Card c when this.normal.Exists(x => x.num == card.num):
                return string.Format($"<normal> : {c.Value()}");
            case Card c when this.rare.Exists(x => x.num == card.num):
                return string.Format($"<rare> : {c.Value()}");
            case null:
                return "card is null";
            default:
                return "get odd number";
        }
    }
}
