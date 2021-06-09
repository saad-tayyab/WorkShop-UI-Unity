using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Asset : MonoBehaviour
{
    [SerializeField]
    private Item[] AssetData;

    [SerializeField]
    private AssetItem AssetsItem;
   

    [SerializeField]
    private Transform Panel;  // parent of Asset game objects

    [SerializeField]
    private GameObject AssetPrefab;     // template asset to be filled with Asset data and instantiated

    [SerializeField]
    private Sprite VerifiedSprite;

    [SerializeField]
    private Sprite ContainerSprite;

    AssetPrefabController assetPrefabController;

    // Start is called before the first frame update
    void Start()
    {
        // IndividualAssetsStart();
        CollectectableAssetsStart();
    }

    private void Update()
    {
        
    }

    void IndividualAssetsStart()
    {
        for (int i = 0; i < AssetData.Length; i++)
        {
            // code to be written for adding AssetData to AssetPrefab
            assetPrefabController = Instantiate(AssetPrefab, Panel).GetComponent<AssetPrefabController>();

            assetPrefabController.CardsImage.sprite = AssetData[i].CardsImage;

            assetPrefabController.MiniItem1.sprite = AssetData[i].MiniItem1;
            assetPrefabController.MiniItem2.sprite = AssetData[i].MiniItem2;
            assetPrefabController.MiniItem3.sprite = AssetData[i].MiniItem3;
            assetPrefabController.MiniItem4.sprite = AssetData[i].MiniItem4;

            assetPrefabController.AddMouseEventListner(VerifiedSprite, ContainerSprite);

            assetPrefabController.MiniItemCount1.text = AssetData[i].MiniItemCount1;
            assetPrefabController.MiniItemCount2.text = AssetData[i].MiniItemCount2;
            assetPrefabController.MiniItemCount3.text = AssetData[i].MiniItemCount3;
            assetPrefabController.MiniItemCount4.text = AssetData[i].MiniItemCount4;

            assetPrefabController.ExpireTime.text = AssetData[i].ExpireTime;

            assetPrefabController.StartTimer();

        }
    }

    void CollectectableAssetsStart()
    {
        int length = AssetsItem.Contents.Capacity;

        for(int i = 0; i < length; i++)
        {
            assetPrefabController = Instantiate(AssetPrefab, Panel).GetComponent<AssetPrefabController>();

            assetPrefabController.CardsImage.sprite = AssetsItem.Contents[i].CardsImage;

            assetPrefabController.MiniItem1.sprite = AssetsItem.Contents[i].MiniItem1;
            assetPrefabController.MiniItem2.sprite = AssetsItem.Contents[i].MiniItem2;
            assetPrefabController.MiniItem3.sprite = AssetsItem.Contents[i].MiniItem3;
            assetPrefabController.MiniItem4.sprite = AssetsItem.Contents[i].MiniItem4;

            assetPrefabController.AddMouseEventListner(VerifiedSprite, ContainerSprite);

            assetPrefabController.MiniItemCount1.text = AssetsItem.Contents[i].MiniItemCount1;
            assetPrefabController.MiniItemCount2.text = AssetsItem.Contents[i].MiniItemCount2;
            assetPrefabController.MiniItemCount3.text = AssetsItem.Contents[i].MiniItemCount3;
            assetPrefabController.MiniItemCount4.text = AssetsItem.Contents[i].MiniItemCount4;

            assetPrefabController.ExpireTime.text = AssetsItem.Contents[i].ExpireTime;

            assetPrefabController.StartTimer();
        }
    }

}
