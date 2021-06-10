using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemPrefabController : MonoBehaviour
{
    [SerializeField]
    private Text miniItemCount;
    public Text MiniItemCount {
        get {
            return miniItemCount;
        }
    }

    [SerializeField]
    private Button miniItemButton;
    public Button MiniItemButton {
        get {
            return miniItemButton;
        }
    }

    [SerializeField]
    private Image miniItemContainer;
    public Image MiniItemContainer {
        get {
            return miniItemContainer;
        }
    }

    [SerializeField]
    private Sprite verifiedSprite;
    public Sprite VerifiedSprite {
        get {
            return verifiedSprite;
        }
    }

    [SerializeField]
    private Sprite containerSprite;
    public Sprite ContainerSprite {
        get {
            return containerSprite;
        }
    }
    private void Start () {
        miniItemButton.onClick.AddListener(() => IncreaseMiniItemCount());
    }

    public void IncreaseMiniItemCount () {
        string str = miniItemCount.text;
        if (str == "") {
            return;
        }

        int number = int.Parse(str.Split('/')[0]);
        int total = int.Parse(str.Split('/')[1]);

        if (number < total) {
            number++;
        }

        string temp = number.ToString() + "/" + str.Split('/')[1];
        miniItemCount.text = temp;

        if (number == total) {
            Image img = miniItemButton.GetComponent<Image>();
            img.sprite = verifiedSprite;

            RectTransform rt = miniItemButton.GetComponent<RectTransform>();
            rt.sizeDelta = new Vector2(47, 49);

            miniItemContainer.sprite = containerSprite;

            miniItemCount.text = null;
        }
    }
}
