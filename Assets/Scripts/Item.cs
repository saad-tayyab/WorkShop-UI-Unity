using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New ItemData")]
public class Item : ScriptableObject {
    [SerializeField]
    private Sprite cardsImage;
    public Sprite CardsImage {
        get {
            return cardsImage;
        }
    }

    [SerializeField]
    private string expireTime;
    public string ExpireTime {
        get {
            return expireTime;
        }
    }

    [SerializeField]
    private Sprite miniItem1;
    public Sprite MiniItem1 {
        get {
            return miniItem1;
        }
    }
    [SerializeField]
    private string miniItemCount1;
    public string MiniItemCount1 {
        get {
            return miniItemCount1;
        }
    }

    [SerializeField]
    private Sprite miniItem2;
    public Sprite MiniItem2 {
        get {
            return miniItem2;
        }
    }
    [SerializeField]
    private string miniItemCount2;
    public string MiniItemCount2 {
        get {
            return miniItemCount2;
        }
    }

    [SerializeField]
    private Sprite miniItem3;
    public Sprite MiniItem3 {
        get {
            return miniItem3;
        }
    }
    [SerializeField]
    private string miniItemCount3;
    public string MiniItemCount3 {
        get {
            return miniItemCount3;
        }
    }

    [SerializeField]
    private Sprite miniItem4;
    public Sprite MiniItem4 {
        get {
            return miniItem4;
        }
    }
    [SerializeField]
    private string miniItemCount4;
    public string MiniItemCount4 {
        get {
            return miniItemCount4;
        }
    }
}
