using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class intro_02 : intro
{
    private Image abajoArriba;
    private Image arribaAbajo;
    private float[] fillamountFloats = { 0.4f, 0.37f, 0.31f, 0.265f, 0.22f, 0.175f };
    private int index02;


    public static GameObject yellowStar;

    private bool StartAnim;
    public static Vector2[] yellowStarPosition;


    private GameObject gameFreak;
    private Image gameFreakImage;
    private CanvasRenderer gameFreakCanvas;
    private float gameFreakTransicion = 0.012195f;

    private GameObject gameFreakLogo;
    private Image gameFreakImageLogo;
    private CanvasRenderer gameFreakLogoCanvas;
    private float gameFreakLogoTransicion = 0.0625f;

    Color sombra = new Color(.054901965f, .129411772f, .258823544f);


    private float transicionDoble = 0.05f;

    private void Start()
    {

        index02 = 0;
        yellowStarPosition = new[]
        {
            new Vector2(15f,22f), 
            new Vector2(6f, 21f), 
            new Vector2(-10f, 18f), 
            new Vector2(-18f, 17f),
            new Vector2(-25.6f, 15.6f), 
            new Vector2(-34f, 16f), 
            new Vector2(-42f, 14f), 
            new Vector2(-58f, 14f), 
            new Vector2(-66f, 13f), 
            new Vector2(-74f, 11f), 
            new Vector2(-81f, 11f), 
            new Vector2(-90f, 10f), 
            new Vector2(-98f, 10f), 
            new Vector2(-106f, 9f), 
            new Vector2(-113f, 9f), 
             new Vector2(-113f, 9f), 
            new Vector2(-122f, 8f), 
            new Vector2(-129f, 7f), 
            new Vector2(-138f, 7f), 
            new Vector2(-145f, 6f), 
            new Vector2(-154f, 6f), 
            new Vector2(-154f, 6f), 
            new Vector2(-161f, 5f), 
            new Vector2(-169f, 5f), 
            new Vector2(-178f, 5f), 
            new Vector2(-186f, 4f), 
            new Vector2(-194f, 3f), 
            new Vector2(-201f, 2f), 
            new Vector2(-210f, 2f), 
            new Vector2(-226f, 1f), 
            new Vector2(-234f, 0f), 
            new Vector2(-258f, -3f), 
            new Vector2(-265f, -3f), 
            new Vector2(-274f, -5f), 
            new Vector2(-281f, -6f), 
            new Vector2(-298f, -9f), 
            new Vector2(-315f, -12f), 
        };





        abajoArriba = GameObject.Find("AnimacionAbajoArriba").GetComponent<Image>();
        arribaAbajo = GameObject.Find("AnimacionArribaAbajo").GetComponent<Image>();
        yellowStar = GameObject.Find("YellowStar");
        yellowStar.GetComponent<Image>().enabled = false;

        gameFreak = GameObject.Find("Game Freak");
        gameFreakCanvas = gameFreak.GetComponent<CanvasRenderer>();
        gameFreakImage = gameFreak.GetComponent<Image>();
        gameFreakImage.enabled = false;

        gameFreakLogo = GameObject.Find("Game Freak Logo");
        gameFreakImageLogo = gameFreakLogo.GetComponent<Image>();
        gameFreakImageLogo.enabled = false;
        gameFreakLogoCanvas = gameFreakLogo.GetComponent<CanvasRenderer>();
        gameFreakLogoCanvas.SetAlpha(0);



    }


    void FixedUpdate ()
    {
        if (index > 469 && index < 476)
        {

            abajoArriba.fillAmount = fillamountFloats[index02];
            arribaAbajo.fillAmount = fillamountFloats[index02];
            index02++;
        }

        if (index == 476)
        {
            index02 = 0;
            yellowStar.GetComponent<Image>().enabled = true;

        }

        if (index > 477 && index <= 520)
        {
            if (index == 520)
            {
                yellowStar.GetComponent<Image>().enabled = false;

            }
            else
            {
                if (index != 480 && index != 486 && index != 504 && index != 510 && index != 511 && index != 514)
                {
                    index02++;
                }
                yellowStar.GetComponent<RectTransform>().anchoredPosition = yellowStarPosition[index02];

            }
        }

        if (index > 641 && index < 646)
        {
            gameFreakImage.color = sombra;
            gameFreakImage.enabled = true;
        }

        if (index > 645 && index < 653)
        {
            gameFreakImage.enabled = false;
            gameFreakImage.color = Color.white;
            gameFreakCanvas.SetAlpha(0);
        }


        if (index > 652 && index <= 736)
        {
            if (gameFreakImage.enabled)
            {
                gameFreakCanvas.SetAlpha(gameFreakCanvas.GetAlpha() + gameFreakTransicion);
            }
            else
            {
                gameFreakImage.enabled = true;
            }
        }

        if (index > 789 && index < 820)
        {
            gameFreakImageLogo.enabled = true;
            if (index != 791 && index != 793 && index != 794 && index != 797 && index != 803 && index != 805 &&
                index != 807 && index != 808 && index != 809 && index != 810 && index != 813 && index != 815 &&
                index != 816 && index != 818)
            {
                gameFreakLogoCanvas.SetAlpha(gameFreakLogoCanvas.GetAlpha() + gameFreakLogoTransicion);
            }
        }

        if (index > 914 && index < 950)
        {
            if (index != 916 && index != 918 && index != 920 && index != 922 && index != 923 && index != 924 &&
                index != 928 && index != 933 && index != 934 && index != 936 && index != 938 && index != 943 &&
                index != 944 && index != 946)
            {
                gameFreakCanvas.SetAlpha(gameFreakCanvas.GetAlpha() - transicionDoble);
                gameFreakLogoCanvas.SetAlpha(gameFreakLogoCanvas.GetAlpha() - transicionDoble);
            }
        }

        if (index > 951 && index <= 954)
        {
            if (index == 954)
            {
                gameFreak.SetActive(false);
                gameFreakLogo.SetActive(false);
            }
            else
            {

                gameFreakImage.color = sombra;
                gameFreakCanvas.SetAlpha(1);
                gameFreakImageLogo.color = sombra;
                gameFreakLogoCanvas.SetAlpha(1);
            }

        }

        if (index == 978)
        {
            GameObject.Find("Fondo").GetComponent<Image>().color = Color.black;
            
        }
        if (index == 981)
        {
            introGameObject[2].SetActive(true);
            GameObject.Find("Fondo").SetActive(false);
            GameObject.Find("YellowStar").SetActive(false);
            gameObject.SetActive(false);
        }
    }
}


