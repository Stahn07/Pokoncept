using UnityEngine;
using UnityEngine.UI;

public class inicio : MonoBehaviour
{

    //private float opacityTime;

    //private float[] opacidad;
    //private int indexColor;

    //private CanvasRenderer canvasRend;

    //private GameObject menuMensaje;


    private GameObject text_Original;

    // TODO Al terminar, fix sprites max num
    public Sprite[] sprites_Menu_Azul;
    public Font pokefont;
    public Sprite[] backgrounds;

    private int _indexStartMenu;
    private int _indexHelpMenu;
    private int _option;

    private Vector2[] spr_Pos =
    {
        new Vector2(102f, 71f), //spr0_Menu_00 (Next)

        new Vector2(69f, 71f), //spr0_Menu_01   (Next)
        new Vector2(102f, 71f), //spr1_Menu_01  (Back)
        new Vector2(-92f, 40f), //spr2_Menu_01  (Cruceta)
        new Vector2(-92f, -16f), //spr3_Menu_01 (A)
        new Vector2(-92f, -56f), //spr4_Menu_01 (B)

        new Vector2(-92f, 39f),   //spr5_Menu_02 (Start)
        new Vector2(-92f, -1f),     //spr6_Menu_02 (Select)
        new Vector2(-92f, -40f),  //spr7_Menu_02 (LR)

        //HELP 8
        new Vector2(94f, 70f), //spr0_Help_Menu_0 (Next)

        new Vector2(43f, 70f), //spr8_Help_Menu_1 (Pick)
        new Vector2(71f, 70f), //spr10_Help_Menu_1 (Ok)
        new Vector2(96f, 70f), //spr9_Help_Menu_1 (End)

        new Vector2(-100f, 45f), //spr12_Help_Menu_1 (Arrow_2)

        new Vector2(85f, 70f), //spr11_Help_Menu (AB_Cancel) 

        //14
        new Vector2(28f, 70f), //spr8_Help_Menu_2 (Pick)
        new Vector2(56f, 70f), //spr10_Help_Menu_2 (Ok)
        new Vector2(89f,70f), //spr13_Help_Menu_2 (Cancel)

        new Vector2(-100f, 28f), //spr12_Help_Menu_2 (Arrow_2)

        new Vector2(85f, 70f), //spr11_Help_Menu_3 (AB_Cancel)

    };

    private Vector2[] text_Pos =
    {
        new Vector2(-66f, 26f), //text0_Menu_00
        new Vector2(-68f, -29f), //text1_Menu_00

        new Vector2(-16f, 3f), //text0_Menu_01 || text0_Menu_02
        new Vector2(-16f, -53f), //text1_Menu_01
        new Vector2(-16f, -93f), //text2_Menu_01

        new Vector2(-16f, -37f), //text1_Menu_02
        new Vector2(-16f, -77f), //text2_Menu_02

        new Vector2(-56f, 25f), //text0_Help_Menu_0 ~ Menu_3
        new Vector2(-54f, 3f), //text1_Help_Menu_0 || text1_Help_Menu_1 || text1_Help_Menu_3

        new Vector2(-46f, -1f), //text1_Help_Menu_1
        new Vector2(-52f, -91f), //text2_Help_Menu_1

        new Vector2(-46f, -18f), //text2_Help_Menu_2

        new Vector2(-54f, -21f), // text2_Help_Menu_3


    };

    //TODO Corregir máximo sprites
    private GameObject[] sprites = new GameObject[8];
    private GameObject[] texts = new GameObject[3];
    private GameObject[] shadowText = new GameObject[9];

    private Color shadowColor = new Color(0.3764f, 0.3764f, 0.3764f);
    private Color shadowColor2 = new Color(0.8156f, 0.8156f, 0.7843f);

    private GameObject _whiteSquare;
    private GameObject _blueMenu;

    private bool _help;


    private string[] start_Menu_Texts =
    {
        "CONTROLS",
        "The  various  buttons  will  be  explained  in  \nthe  order  of  their  importance.",

        "Moves the main character. \nAlso used to choose various data \nheadings.",
        "Used to confirm a choice, check \nthings, chat, and scroll text.",
        "Used to exit, cancel a choice, \nand cancel a mode.",

        "Press this button to open the \nMENU.",
        "Used to shift items and to use \na registered item.",
        "If you need help playing the \ngame, or in how to do things, \npress the L or R Button.",

        "HELP",
        "Greetings! This is the Help System.\nCall me up wherever you\nneed by pressing the L or R Button.\nThe help messages change to suit the\nsituation, so check them often, please.",
        "About this game\nEXIT",
        "Detailed descriptions are given\nabout this game.",
        "Select to exit the HELP System.",
        "About this game",
        "The HELP System\nThe game\nWireless Adapter\nCANCEL",
        "The HELP System",
        "The help messages change depending on\nhow much you have progressed in the\ngame. The are designed to support you\nwhen you need them. If there is\nanything that you don't understand,\nplease look up the HELP System!",
        "The game",
        "You become the main character to\nexplore the world of POKéMON!\nBy talking to people and solving\nmysteries, new paths will open to you.\nStrive for the goal together with your\nwonderful POKéMON!",
        "Wireless Adapter",
        "This game communicates over a wireless\nlink using the Wireless Adapter.\nGo wireless anywhere, anytime, and\nwith anybody!\nTry playing with the Wireless Adapter\n always attached!"

    };

    

    //TODO Textos HELP
    private string[] _textosMenuHelp =
    {

    };



    private void Start()
    {
        text_Original = GameObject.Find("text_menu_azul");
        _blueMenu = GameObject.Find("menu_Azul");

        Sprite_Function(0, 0);
        Text_Function(0, 0);
        Text_Function(1, 1);

        //menuMensaje = GameObject.Find("Menú Mensaje");
        //menuMensaje.SetActive(false);

        //canvasRend = GetComponent<CanvasRenderer>();
        //opacityTime = Time.time;

        //opacidad = new[] {.97f, .85f, .7f, .61f, .34f, .17f, 0f};
        //indexColor = 0;




    }

    private void Update()
    {
        if (_help != true)
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {
                if (_indexStartMenu < 2)
                {
                    _indexStartMenu++;
                    Start_Menu(_indexStartMenu);
                }
            }


            if (Input.GetKeyDown(KeyCode.X))
            {
                if (_indexStartMenu > 0)
                {
                    _indexStartMenu--;
                    Start_Menu(_indexStartMenu);
                }
            }
        }

        if (_help)
        {
            bool back = false;
            if (Input.GetKeyDown(KeyCode.Z))
            {
                if (_indexHelpMenu == 3)
                {
                    back = true;
                }

                if (_indexHelpMenu == 2)
                {
                    if (_option != 3)
                    {
                        _indexHelpMenu++;
                        Help_Menu(_indexHelpMenu);
                    }
                    else
                    {
                        back = true;
                    }
                }

                if (_indexHelpMenu == 1)
                {
                    if (_option == 0)
                    {
                        _indexHelpMenu++;
                        Help_Menu(_indexHelpMenu);
                    }
                    else
                    {
                        _help = false;
                        if (_whiteSquare)
                        {
                            if (_whiteSquare.activeInHierarchy)
                            {
                                _whiteSquare.SetActive(false);
                            }
                        }
                        Start_Menu(_indexStartMenu);
                    }
                }

                if (_indexHelpMenu == 0)
                {
                    _indexHelpMenu++;
                    Help_Menu(_indexHelpMenu);

                }

            if (back)
            {
                Help_Menu(--_indexHelpMenu);
            }
        }

            if (Input.GetKeyDown(KeyCode.X))
            {
                if (_indexHelpMenu == 1)
                {
                    _help = false;
                    if (_whiteSquare)
                    {
                        if (_whiteSquare.activeInHierarchy)
                        {
                            _whiteSquare.SetActive(false);
                        }
                    }
                    Start_Menu(_indexStartMenu);
                }
                if (_indexHelpMenu == 2)
                {
                    _indexHelpMenu--;
                    Help_Menu(_indexHelpMenu);

                }
            }

            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                if (_indexHelpMenu == 1 && _option != 0)
                {
                    texts[2].GetComponent<Text>().text = start_Menu_Texts[11];

                    foreach (GameObject arrow2 in sprites)
                    {
                        if (arrow2 != null)
                        {
                            if (arrow2.name.Contains("arrow_2"))
                            {
                                arrow2.GetComponent<RectTransform>().anchoredPosition = new Vector2(arrow2.GetComponent<RectTransform>().anchoredPosition.x, arrow2.GetComponent<RectTransform>().anchoredPosition.y + 15f);
                                _option--;
                            }
                        }
                    }

                    foreach (GameObject textSombra in shadowText)
                    {
                        if (textSombra.name.Contains("text_11"))
                        {
                            textSombra.GetComponent<Text>().color = shadowColor2;
                            textSombra.GetComponent<Text>().text = texts[2].gameObject.GetComponent<Text>().text;
                        }
                    }
                }
                if (_indexHelpMenu == 2 && _option != 0)
                {
                    foreach (GameObject arrow2 in sprites)
                    {
                        if (arrow2 != null)
                        {
                            if (arrow2.name.Contains("arrow_2"))
                            {
                                arrow2.GetComponent<RectTransform>().anchoredPosition = new Vector2(arrow2.GetComponent<RectTransform>().anchoredPosition.x, arrow2.GetComponent<RectTransform>().anchoredPosition.y + 15f);
                                _option--;
                            }
                        }
                    }
                }
            }

            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                if (_indexHelpMenu == 1 && _option != 1)
                {
                    texts[2].GetComponent<Text>().text = start_Menu_Texts[12];

                    foreach (GameObject arrow2 in sprites)
                    {
                        if (arrow2 != null)
                        {
                            if (arrow2.name.Contains("arrow_2"))
                            {
                                arrow2.GetComponent<RectTransform>().anchoredPosition = new Vector2(arrow2.GetComponent<RectTransform>().anchoredPosition.x, arrow2.GetComponent<RectTransform>().anchoredPosition.y - 15f);
                                _option++;
                            }
                        }
                    }

                    foreach (GameObject textSombra in shadowText)
                    {
                        if (textSombra.name.Contains("text_11"))
                        {
                            textSombra.GetComponent<Text>().color = shadowColor2;
                            textSombra.GetComponent<Text>().text = texts[2].gameObject.GetComponent<Text>().text;
                        }
                    }
                }
                if (_indexHelpMenu == 2 && _option != 3)
                {
                    foreach (GameObject arrow2 in sprites)
                    {
                        if (arrow2 != null)
                        {
                            if (arrow2.name.Contains("arrow_2"))
                            {
                                arrow2.GetComponent<RectTransform>().anchoredPosition = new Vector2(arrow2.GetComponent<RectTransform>().anchoredPosition.x, arrow2.GetComponent<RectTransform>().anchoredPosition.y - 15f);
                                _option++;
                            }
                        }
                    }
                }

            }

        }

        if ((_indexHelpMenu == 0 && _help) == false)
        {
            if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S))
            {
                _help = !_help;

                if (_help)
                {
                    Help_Menu(_indexHelpMenu);
                }
                else
                {
                    if (_whiteSquare)
                    {
                        if (_whiteSquare.activeInHierarchy)
                        {
                            _whiteSquare.SetActive(false);
                        }
                    }
                    Start_Menu(_indexStartMenu);


                }
                if (_indexHelpMenu > 1)
                {
                    _indexHelpMenu = 1;
                }

            }
        }




        print("index_Help" + _indexHelpMenu);
        print("option" + _option);


        //if (Time.time - opacityTime >= .25f && indexColor < opacidad.Length)
            //{
            //    canvasRend.SetAlpha(opacidad[indexColor]);
            //    opacityTime = Time.time;
            //    indexColor++;
            //}

            //if (canvasRend.GetAlpha() == 0 && Time.time > 3.5f)
            //{

            //    menuMensaje.SetActive(true);

            //}



        }

    void Text_Function(int indexText, int indexPos)
    {
        
            GameObject text = new GameObject();
            text.GetComponent<Transform>().SetParent(_blueMenu.GetComponent<RectTransform>(), false);
            text.AddComponent<Text>();
            Text textComponent = text.GetComponent<Text>();
            textComponent.font = pokefont;
            textComponent.fontSize = 17;
            textComponent.lineSpacing = 2.52f;
            textComponent.horizontalOverflow = HorizontalWrapMode.Overflow;
            textComponent.verticalOverflow = VerticalWrapMode.Overflow;
            textComponent.resizeTextForBestFit = true;
            textComponent.resizeTextMinSize = 12;
            textComponent.resizeTextMaxSize = 1;
            text.layer = 5;
            textComponent.text = start_Menu_Texts[indexText];
            text.GetComponent<RectTransform>().anchoredPosition = text_Pos[indexPos];
            text.name = "text_" + indexText;


            for (int i = 0; i < texts.Length; i++)
            {
                if (texts[i] == null)
                {
                    texts[i] = text;
                    i = texts.Length;
                }
            }

        for (int i = 0; i < 3; i++)
        {
            GameObject shadowTextInst = Instantiate(text);
            shadowTextInst.name = text.name + "_" + i + "_shadow";
            shadowTextInst.GetComponent<RectTransform>().SetParent(_blueMenu.GetComponent<RectTransform>(), false);
            shadowTextInst.GetComponent<RectTransform>().anchoredPosition =
            text.GetComponent<RectTransform>().anchoredPosition;
            shadowTextInst.GetComponent<RectTransform>().SetSiblingIndex(i);
            shadowTextInst.GetComponent<Text>().color = shadowColor;

            Vector2 textOriginalPos = text.GetComponent<RectTransform>().anchoredPosition;
            if (i == 0)
            {
                shadowTextInst.GetComponent<RectTransform>().anchoredPosition =
                    new Vector2(textOriginalPos.x + 1f,
                        textOriginalPos.y);
            }
            if (i == 1)
            {
                shadowTextInst.GetComponent<RectTransform>().anchoredPosition = new Vector2(textOriginalPos.x,
                    textOriginalPos.y - 1f);
            }
            if (i == 2)
            {
                shadowTextInst.GetComponent<RectTransform>().anchoredPosition =
                    new Vector2(textOriginalPos.x + 1f,
                        textOriginalPos.y - 1f);
            }

            for (int j = 0; j < shadowText.Length; j++)
            {
                if (shadowText[j] == null)
                {
                    shadowText[j] = shadowTextInst;
                    j = shadowText.Length;
                }
            }

        }

    }

    void Sprite_Function(int indexSprite, int indexPos)
    {
            GameObject sprite = new GameObject("spr_" + indexSprite);
            sprite.AddComponent<Image>();
            sprite.GetComponent<Image>().sprite = sprites_Menu_Azul[indexSprite];
            sprite.GetComponent<RectTransform>().SetParent(_blueMenu.GetComponent<RectTransform>(), false);
            sprite.GetComponent<Image>().SetNativeSize();
            sprite.GetComponent<RectTransform>().anchoredPosition = spr_Pos[indexPos];
            sprite.name = sprite.GetComponent<Image>().sprite.name;
            sprite.layer = 5;
            

            for (int i = 0; i < sprites.Length; i++)
            {
                if (sprites[i] == null)
                {
                    sprites[i] = sprite;
                    i = sprites.Length;
                }
            }

          
    }


    void Start_Menu(int index)
    {
        _blueMenu.GetComponent<Image>().sprite = backgrounds[0];

        for (int i = 0; i < shadowText.Length; i++)
        {
            if (shadowText[i] != null)
            {
                Destroy(shadowText[i]);
                shadowText[i] = null;
            }
        }

        for (int i = 0; i < texts.Length; i++)
        {
            if (texts[i] != null)
            {
                Destroy(texts[i]);
                texts[i] = null;
            }
        }

        for (int i = 0; i < sprites.Length; i++)
        {
            if (sprites[i] != null)
            {
                Destroy(sprites[i]);
                sprites[i] = null;
            }
        }

        //TODO loop para recorrer esto?

        switch (index)
        {
            case 0:
            Sprite_Function(0, 0);
            Text_Function(0, 0);
            Text_Function(1, 1);
                break;
            case 1:
            Sprite_Function(0, 1);
            Sprite_Function(1, 2);
            Sprite_Function(2, 3);
            Sprite_Function(3, 4);
            Sprite_Function(4, 5);


            Text_Function(2, 2);
            Text_Function(3, 3);
            Text_Function(4, 4);
                break;

            case 2:
            Sprite_Function(0, 1);
            Sprite_Function(1, 2);

            Sprite_Function(5, 6);
            Sprite_Function(6, 7);
            Sprite_Function(7, 8);

            Text_Function(5, 2);
            Text_Function(6, 5);
            Text_Function(7, 6);
                break;
        }
    }

    void Help_Menu(int index)
    {
        _blueMenu.GetComponent<Image>().sprite = backgrounds[1];

        if (_whiteSquare)
        {
            if (_whiteSquare.activeInHierarchy)
            {
                _whiteSquare.SetActive(false);
            }
        }

        for (int i = 0; i < shadowText.Length; i++)
        {
            if (shadowText[i] != null)
            {
                Destroy(shadowText[i]);
                shadowText[i] = null;
            }
        }

        for (int i = 0; i < texts.Length; i++)
        {
            if (texts[i] != null)
            {
                Destroy(texts[i]);
                texts[i] = null;
            }
        }

        for (int i = 0; i < sprites.Length; i++)
        {
            if (sprites[i] != null)
            {
                Destroy(sprites[i]);
                sprites[i] = null;
            }
        }


        switch (index)
        {
              
            case 0:
                Sprite_Function(0, 9);
                Text_Function(8, 7);
                Text_Function(9, 8);
                break;
            case 1:
                _option = 0;
                Text_Function(8, 7);
                Text_Function(10, 9);
                Text_Function(11, 10);
                Sprite_Function(8, 10);
                Sprite_Function(9, 11);
                Sprite_Function(10, 12);
                Sprite_Function(12, 13);
                if (_whiteSquare == null)
                {
                    _whiteSquare = new GameObject();
                    _whiteSquare.AddComponent<Image>();
                    _whiteSquare.GetComponent<Image>().color = new Color(0.9725f, 0.9725f, 0.9725f);
                    _whiteSquare.GetComponent<RectTransform>().SetParent(_blueMenu.GetComponent<RectTransform>());
                    _whiteSquare.GetComponent<RectTransform>().SetSiblingIndex(0);
                    _whiteSquare.GetComponent<RectTransform>().anchoredPosition = new Vector2(0f, -52f);
                    _whiteSquare.GetComponent<RectTransform>().sizeDelta = new Vector2(208, 40);
                    _whiteSquare.name = "White_Square";
                }
                else
                {
                    _whiteSquare.SetActive(true);
                }
                texts[2].GetComponent<Text>().color = shadowColor;


                foreach (GameObject textSombra in shadowText)
                {
                    if (textSombra.name.Contains("text_11"))
                    {
                        textSombra.GetComponent<Text>().color = shadowColor2;
                        textSombra.GetComponent<Text>().text = texts[2].gameObject.GetComponent<Text>().text;
                    }
                }



                break;
            case 2:
                Text_Function(8, 7);
                Text_Function(13, 8);
                Text_Function(14, 11);
                Sprite_Function(8, 15);
                Sprite_Function(9, 16);
                Sprite_Function(13, 17);
                //TODO Función para colocar pos en menús con flecha (+15, -15)
                Sprite_Function(12, 18);
                break;

                //TODO Color Fondo
            case 3:
                Text_Function(8, 7);
                Sprite_Function(11,14);
                if (_option == 0)
                {
                Text_Function(15,8);
                Text_Function(16,12);
                }
                if (_option == 1)
                {
                Text_Function(17,8);
                Text_Function(18,12);
                }

                if (_option == 2)
                {
                Text_Function(19,8);
                Text_Function(20,12);
                }


                break;


        }
    }

}
