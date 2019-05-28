using System.Collections;
using System.Collections.Generic;

public class Card {
    public int num { get; set; }
}

public static class CardExtension {
    public static string Value(this Card card) {
        switch (card.num) {
            case 1:
                return "ace";
            case 2:
                return "two";
            case 3:
                return "three";
            case 4:
                return "four";
            case 5:
                return "five";
            case 6:
                return "six";
            case 7:
                return "seven";
            case 8:
                return "eight";
            case 9:
                return "nine";
            case 10:
                return "ten";
            case 11:
                return "jack";
            case 12:
                return "queen";
            case 13:
                return "king";
            default:
                return "?";
        }
    }
}
