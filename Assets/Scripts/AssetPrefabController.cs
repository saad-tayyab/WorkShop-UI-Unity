using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AssetPrefabController : MonoBehaviour
{
    [SerializeField]
    private Image cardsImage;
    public Image CardsImage
    {
        get
        {
            return cardsImage;
        }
        set
        {
            cardsImage = value;
        }
    }

    [SerializeField]
    private Text expireTime;
    public Text ExpireTime
    {
        get
        {
            return expireTime;
        }
    }

    [SerializeField]
    private Image miniItem1;
    public Image MiniItem1
    {
        get
        {
            return miniItem1;
        }
    }
    [SerializeField]
    private Text miniItemCount1;
    public Text MiniItemCount1
    {
        get
        {
            return miniItemCount1;
        }
    }
    [SerializeField]
    private Button miniItemButton1;
    public Button MiniItemButton1
    {
        get
        {
            return miniItemButton1;
        }
    }


    [SerializeField]
    private Image miniItem2;
    public Image MiniItem2
    {
        get
        {
            return miniItem2;
        }
    }
    [SerializeField]
    private Text miniItemCount2;
    public Text MiniItemCount2
    {
        get
        {
            return miniItemCount2;
        }
    }
    [SerializeField]
    private Button miniItemButton2;
    public Button MiniItemButton2
    {
        get
        {
            return miniItemButton2;
        }
    }
    

    [SerializeField]
    private Image miniItem3;
    public Image MiniItem3
    {
        get
        {
            return miniItem3;
        }
    }
    [SerializeField]
    private Text miniItemCount3;
    public Text MiniItemCount3
    {
        get
        {
            return miniItemCount3;
        }
    }
    [SerializeField]
    private Button miniItemButton3;
    public Button MiniItemButton3
    {
        get
        {
            return miniItemButton3;
        }
    }
    

    [SerializeField]
    private Image miniItem4;
    public Image MiniItem4
    {
        get
        {
            return miniItem4;
        }
    }
    [SerializeField]
    private Text miniItemCount4;
    public Text MiniItemCount4
    {
        get
        {
            return miniItemCount4;
        }
    }
    [SerializeField]
    private Button miniItemButton4;
    public Button MiniItemButton4
    {
        get
        {
            return miniItemButton4;
        }
    }

    [SerializeField]
    private Image miniItemContainer1;
    public Image MiniItemContainer1
    {
        get
        {
            return miniItemContainer1;
        }
    }
    [SerializeField]
    private Image miniItemContainer2;
    public Image MiniItemContainer2
    {
        get
        {
            return miniItemContainer2;
        }
    }
    [SerializeField]
    private Image miniItemContainer3;
    public Image MiniItemContainer3
    {
        get
        {
            return miniItemContainer3;
        }
    }
    [SerializeField]
    private Image miniItemContainer4;
    public Image MiniItemContainer4
    {
        get
        {
            return miniItemContainer4;
        }
    }


    public void AddMouseEventListner(Sprite VerifiedSprite, Sprite ContainerSprite)
    {
        MiniItemButton1.onClick.AddListener(() => IncreaseMiniItemCount(MiniItemButton1, MiniItemCount1, VerifiedSprite, miniItemContainer1, ContainerSprite));
        MiniItemButton2.onClick.AddListener(() => IncreaseMiniItemCount(MiniItemButton2, MiniItemCount2, VerifiedSprite, miniItemContainer2, ContainerSprite));
        MiniItemButton3.onClick.AddListener(() => IncreaseMiniItemCount(MiniItemButton3, MiniItemCount3, VerifiedSprite, miniItemContainer3, ContainerSprite));
        MiniItemButton4.onClick.AddListener(() => IncreaseMiniItemCount(MiniItemButton4, MiniItemCount4, VerifiedSprite, miniItemContainer4, ContainerSprite));
    }

    void IncreaseMiniItemCount(Button MiniItemButton, Text MiniItemCount, Sprite VerifiedSprite, Image containerImg, Sprite ContainerSprite)
    {
        string str = MiniItemCount.text;
        Debug.Log(str);
        if(str == "")
        {
            return;
        }

        int number = int.Parse(str.Split('/')[0]);
        int total = int.Parse(str.Split('/')[1]);

        if (number < total)
        {
            number++;
        }

        string temp = number.ToString() + "/" + str.Split('/')[1];
        MiniItemCount.text = temp;

        if (number == total)
        {
            Image img = MiniItemButton.GetComponent<Image>();
            img.sprite = VerifiedSprite;

            RectTransform rt = MiniItemButton.GetComponent<RectTransform>();
            rt.sizeDelta = new Vector2(47, 49);

            containerImg.sprite = ContainerSprite;

            MiniItemCount.text = null;
        }
    }


    Timer timeRemaining;
    bool startTimer = false;

    public void StartTimer()
    {
        string expireTimer = expireTime.text.ToString();
        timeRemaining = new Timer(expireTimer);
        timeRemaining.StartCountDown();
        startTimer = true;
    }

    private void Start()
    {
        
    }

    void Update()
    {
        if (startTimer)
        {
            timeRemaining.UpdateCountDown();
            expireTime.text = timeRemaining.timeRemainingInStr;
        }   
    }
}
