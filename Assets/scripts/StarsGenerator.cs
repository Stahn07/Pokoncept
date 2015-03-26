using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StarsGenerator : MonoBehaviour {

    protected static StarsGenerator instance;

    public GameObject miniStarPrefab;
    [HideInInspector]
    public Vector3 localScale = new Vector3(1, 1, 1);
    [HideInInspector]
    public Vector2 anchorMin = new Vector2(1f, 0.5f);
    [HideInInspector]
    public Vector2 anchorMax = new Vector2(1f, 0.5f);
    [HideInInspector]
    public Vector2 pivot = new Vector2(1f, 0.5f);




    public StarsGenerator()
    {

        //miniStar = new GameObject();
        //miniStar = new GameObject("ministar");
        //ministar.AddComponent<Image>();
        //Image miniStarSprite = miniStar.GetComponent<Image>();
        //miniStarSprite.sprite = ministar0Sprite;


        //RectTransform miniStarTransform = miniStar.GetComponent<RectTransform>();
        //miniStarTransform.SetParent(GameObject.Find("FondoAzul").GetComponent<Transform>());
        //miniStarTransform.localScale = localScale;
        //miniStarTransform.anchorMin = anchorMin;
        //miniStarTransform.anchorMax = anchorMax;
        //miniStarTransform.pivot = pivot;
    }
}
