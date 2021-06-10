using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Asset : MonoBehaviour {
    [SerializeField]
    private Item[] AssetData;

    [SerializeField]
    private AssetItem AssetsItem;


    [SerializeField]
    private Transform Panel;

    [SerializeField]
    private GameObject AssetPrefab;

    [SerializeField]
    private Sprite VerifiedSprite;

    [SerializeField]
    private Sprite ContainerSprite;

    AssetPrefabController assetPrefabController;

    // Start is called before the first frame update
    void Start () {
        // IndividualAssetsStart();
        CollectectableAssetsStart();
    }

    void IndividualAssetsStart () {
        for (int i = 0; i < AssetData.Length; i++) {
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

    void CollectectableAssetsStart () {
        int length = AssetsItem.Contents.Capacity;

        for (int i = 0; i < length; i++) {
            assetPrefabController = Instantiate(AssetPrefab, Panel).GetComponent<AssetPrefabController>();
            assetPrefabController.AssignComponenets(AssetsItem.Contents[i]);
            //assetPrefabController.AddMouseEventListner(VerifiedSprite, ContainerSprite);
            assetPrefabController.StartTimer();
        }
    }

}
