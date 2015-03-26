using UnityEditor;
using UnityEditor.AnimatedValues;
using UnityEngine;
using UnityEngine.UI;

public class intro_06 : intro {

    public Sprite[] gengar02 = new Sprite[4];
    public Sprite[] nidorino02 = new Sprite[5];
    public Sprite[] backEffectSpr;

    private GameObject[] fondosbosque2;
    private Vector2[] fondosbosque2pos;


    private GameObject fondobosque2original;
    private RectTransform fondobosque2originalRect;

    private RectTransform nidorino02Trans;
    private RectTransform gengar02Trans;
    private RectTransform hierbitaTrans;


    private Image gengar02Image;
    private Image nidorino02Image;
    private Image golpeImage;
    private Image backEffectImg;

    private Image fondoblanco06;
    private float degradadoFondo = 0.125f;


    private int[] nidorino02Up = {1274, 1278, 1282, 1285, 1289, 1293, 1297, 1301, 1305, 1309, 1314, 1317};
    private int[] nidorino02Down = {1271, 1276, 1279, 1283, 1287, 1291, 1296, 1298, 1303, 1307, 1312, 1316};


    private float gengarPixelMov = 1.33f;
    private int[] gengarMov1 = {1229, 1353, 1355, 1357, 1359, 1361, 1362, 1365, 1367};
    private int[] gengarMov2 = {1352, 1354, 1356, 1358, 1360};
    private int[] gengarMov3 = {1211, 1217, 1220, 1221, 1223, 1224, 1226, 1227, 1228, 1364};
    private int[] gengarMov4 =
    {
        1173, 1174, 1175, 1176, 1177, 1178, 1181, 1182, 1184, 1185, 1186, 1187, 1188, 1189, 1190,
        1191, 1192, 1193, 1198, 1199, 1200, 1201, 1202, 1204, 1205, 1206, 1208, 1209, 1210, 1213, 1214, 1215, 1216, 1218,
        1222
    };
    private int[] gengarMov8 = {1180, 1195, 1197, 1207, 1389};

    private int[] fondoMov1 =
    {
        1236, 1244, 1252, 1260, 1269, 1277, 1285, 1293, 1300, 1309, 1316, 1324, 1332, 1340, 1348,
        1356, 1364, 1372, 1380, 1388, 1396, 1404, 1412, 1420, 1428, 1436, 1444, 1452, 1461, 1468, 1477, 1485, 1493, 1500,
        1508, 1516, 1524, 1532, 1540, 1548, 1556, 1564, 1572, 1580, 1588, 1596
    };

    private int[] hierbitaMov1 =
    {
        1242, 1243, 1244, 1246, 1247, 1248, 1250, 1251, 1252, 1253, 1254, 1257, 1258, 1259,
        1260, 1261, 1262, 1263, 1264, 1265, 1266, 1267, 1268, 1270, 1271, 1272, 1274, 1275, 1276, 1277, 1279, 1280, 1281,
        1282, 1283, 1284, 1286, 1289, 1290, 1291, 1294, 1295, 1296, 1297, 1298, 1299, 1300, 1301, 1302, 1303, 1304, 1305,
        1306, 1307, 1308, 1309, 1310, 1311, 1312, 1313, 1316, 1317, 1318, 1319, 1320,1321,1322,1323,1324,1325,1326,1327,1328,1329,1330,1331,1332,1333,1334,1335,1336,1337,1338,1339,1340,1341,1342,1343,1344,1345,1346,1347,1348,1349,1350,1351,1352,1353,1354,1355,1356,1357,1358,1359,1360
    };


    private int[] hierbitaMov2 = {1249, 1256, 1273, 1285, 1288, 1293, 1315, 1321};

    private int[] hierbitaMov5 =
    {
        1204, 1205, 1206, 1207, 1208, 1210, 1211, 1212, 1214, 1215, 1216, 1217, 1219, 1220, 1221,
        1222, 1223, 1224, 1226, 1227, 1228, 1229, 1230, 1233, 1234, 1236, 1237, 1238, 1239, 1240, 1241
    };

    private int[] hierbitaMov10 = { 1213, 1225, 1232, 1235 };

    private Vector2[] nidorinoMov =
    {
        new Vector2(2, 4),
        new Vector2(2, 5),
        new Vector2(3, 4),
        new Vector2(2, 3),
        new Vector2(2, 3),
        new Vector2(3, 3),
        new Vector2(2, 1),
        new Vector2(2, 1),
        new Vector2(2, -1),
        new Vector2(2, -1),
        new Vector2(2, -3),
        new Vector2(1, -3),
        new Vector2(2, -3),
        new Vector2(2, -4),

        new Vector2(4, 0),
        new Vector2(1, 0),
        new Vector2(2, 0),
        new Vector2(2, 0),
        new Vector2(2, 0),
        new Vector2(1, 0),
        new Vector2(5, 0),
        new Vector2(2, 0),
        new Vector2(1, 0),
        new Vector2(1, 0),
        new Vector2(3, 0),

        new Vector2(0, -1.461538f), 
        new Vector2(-4, 3), 
        new Vector2(-3,3), 
        new Vector2(-4,2), 
        new Vector2(-3,3), 
        new Vector2(-4,2), 
        new Vector2(-3,1), 
        new Vector2(-4,1), 
        new Vector2(-3,1), 

        new Vector2(-7,-2), 
        new Vector2(-3,-1), 
        new Vector2(-4,-2), 
        new Vector2(-3,-3), 
        new Vector2(-4,-2), 
        new Vector2(-3,-4), 

        new Vector2(1,3), 
        new Vector2(2,2), 
        new Vector2(1,2), 
        new Vector2(0,0),
        new Vector2(3,0), 
        new Vector2(2,-2), 
        new Vector2(1,-2), 
        new Vector2(0,0), 

        new Vector2(-3,2), 
        new Vector2(-2,2), 
        new Vector2(-2,2), 
        new Vector2(-2,3), 
        new Vector2(-2,2), 
        new Vector2(-2,3), 
        new Vector2(-2,2), 
        new Vector2(-2,2), 
        new Vector2(-1,1), 
        new Vector2(-2,2), 
        new Vector2(-1,1), 
        new Vector2(-2,2), 
        new Vector2(-1,1), 
        new Vector2(-2,2), 
        new Vector2(-1,1), 
        new Vector2(-1,1), 
        new Vector2(-1,1), 
        new Vector2(-1,0), 
        new Vector2(-1,1), 
        new Vector2(-1,1), 
        new Vector2(-1,1), 
        new Vector2(-1,1), 
        new Vector2(-1,0), 
        new Vector2(-1,1), 
        new Vector2(-1,1), 
        new Vector2(-1,1), 
        new Vector2(-1,0), 
        new Vector2(-1,1), 
        new Vector2(-1,1), 
        new Vector2(-1,0), 
        new Vector2(-1,1), 
        new Vector2(-1,0), 
        new Vector2(-1,1), 
        new Vector2(-1,0), 
        new Vector2(-1,1), 
        new Vector2(-1,0), 
        new Vector2(-1,1), 
        new Vector2(-1,0), 
        new Vector2(-1,0), 
        new Vector2(-1,1), 
        new Vector2(-1,0), 
        new Vector2(-1,0), 
        new Vector2(-1,0), 
        new Vector2(0,1), 
        new Vector2(-1,0), 
        new Vector2(0,0), 
        new Vector2(-1,0), 
        new Vector2(-1,0), 
        new Vector2(0,0), 
        new Vector2(-1,0), 
        new Vector2(-1,0), 
        new Vector2(-1,0), 
        new Vector2(-1,0), 
        new Vector2(0,0), 
        new Vector2(0,0), 
        new Vector2(-1,1), 
        new Vector2(0,0), 
        new Vector2(0,0), 
        new Vector2(0,0), 
        new Vector2(0,0), 


 
    };

    private Vector2[] backEffectPos =
    {
        new Vector2(101.7f, -48.8f), 
        new Vector2(107.3f, -48.8f), 
        new Vector2(107.1f, -48.8f), 
        new Vector2(106f, -48.8f), 
        new Vector2(105.9f, -48.8f), 
        new Vector2(107.8f, -48.8f), 
        new Vector2(104.6f, -48.8f), 
        new Vector2(104f, -48.8f),
        new Vector2(104f, -48.8f),
        new Vector2(104f, -48.8f),
        new Vector2(105.4f, -48.8f),
        new Vector2(104f, -48.8f),
        new Vector2(105.9f, -48.8f),
        new Vector2(105.9f, -48.8f), 
        new Vector2(106f, -48.8f), 
        new Vector2(104.6f, -48.8f), 
        new Vector2(105.5f, -48.8f),
        new Vector2(105.8f, -48.8f),
        new Vector2(106.2f, -48.8f),
        new Vector2(105.4f, -48.8f),
        new Vector2(106.2f, -48.8f),
        new Vector2(105.3f, -48.8f), 
        new Vector2(106f, -48.8f), 
        new Vector2(105.7f, -48.8f), 
        new Vector2(105.9f, -48.8f),
        new Vector2(105.6f, -48.8f),
        new Vector2(106f, -48.8f),
        new Vector2(107.2f, -48.8f),
        new Vector2(111f, -48.8f),
        new Vector2(105.3f, -48.8f), 
        new Vector2(106f, -48.8f), 
        new Vector2(105.7f, -48.8f), 
        new Vector2(105.9f, -48.8f),
        new Vector2(105.6f, -48.8f),
        new Vector2(106f, -48.8f),
        new Vector2(107.2f, -48.8f),
        new Vector2(111f, -48.8f),
        new Vector2(107.3f, -48.8f), 
        new Vector2(106f, -48.8f), 
        new Vector2(105.7f, -48.8f), 
        new Vector2(105.9f, -48.8f),
        new Vector2(105.6f, -48.8f),
        new Vector2(106f, -48.8f),
        new Vector2(105.4f, -48.8f),
    };

    private int indexPrueba;
    private int indexPrueba2;

    void Start()
    {
        indexPrueba = 0;

        nidorino02Trans = GameObject.Find("Nidorino02").GetComponent<RectTransform>();
        nidorino02Image = GameObject.Find("Nidorino02").GetComponent<Image>();
        gengar02Trans = GameObject.Find("Gengar02").GetComponent<RectTransform>();
        gengar02Image = GameObject.Find("Gengar02").GetComponent<Image>();
        golpeImage = GameObject.Find("Golpe").GetComponent<Image>();
        backEffectImg = GameObject.Find("backEffect").GetComponent<Image>();
        fondoblanco06 = GameObject.Find("fondo_blanco_06").GetComponent<Image>();
        fondoblanco06.color = new Color(255, 255, 255, 0);


        hierbitaTrans = GameObject.Find("hierbita").GetComponent<RectTransform>();
        fondosbosque2 = new GameObject[3];
        fondosbosque2pos = new Vector2[3];
        fondobosque2original = GameObject.Find("FondoBosque2");
        fondobosque2originalRect = fondobosque2original.GetComponent<RectTransform>();

        fondosbosque2pos[2] = fondobosque2originalRect.anchoredPosition;
        fondosbosque2pos[0] = new Vector2(fondobosque2originalRect.anchoredPosition.x + 255.8f, fondobosque2originalRect.anchoredPosition.y);
        fondosbosque2pos[1] = new Vector2(fondobosque2originalRect.anchoredPosition.x - 255.8f, fondobosque2originalRect.anchoredPosition.y);


        for (int i = 0; i < 2; i++)
        {
            GameObject fondo2Copia = Instantiate(fondobosque2original, fondobosque2originalRect.anchoredPosition, Quaternion.identity) as GameObject;
            fondosbosque2[i] = fondo2Copia;
            if (fondo2Copia != null)
            {
                RectTransform fondo2CopiaRect = fondo2Copia.GetComponent<RectTransform>();

                fondo2CopiaRect.SetParent(GetComponentInParent<RectTransform>(), false);
                fondo2CopiaRect.SetSiblingIndex(i);
                fondo2CopiaRect.anchoredPosition = fondosbosque2pos[i];
            }
        }

        fondosbosque2[2] = fondobosque2original;

    }

    void FixedUpdate()
    {

            foreach (int numero in hierbitaMov1)
            {
                if (index == numero)
                {
                    hierbitaTrans.anchoredPosition -= new Vector2(1.3f, 0);
                }
            }

            foreach (int numero in hierbitaMov2)
            {
                if (index == numero)
                {
                    hierbitaTrans.anchoredPosition -= new Vector2(1.3f * 2f, 0);
                }
            }

            foreach (int numero in hierbitaMov5)
            {
                if (index == numero)
                {
                    hierbitaTrans.anchoredPosition -= new Vector2(1.3f * 5f, 0);
                }
            }


            foreach (int numero in hierbitaMov10)
            {
                if (index == numero)
                {
                    hierbitaTrans.anchoredPosition -= new Vector2(1.3f * 10f, 0);
                }
            }




            foreach (int numero in gengarMov1)
            {
                if (index == numero)
                {
                    gengar02Trans.anchoredPosition -= new Vector2(gengarPixelMov, 0);
                }
            }

            foreach (int numero in gengarMov2)
            {
                if (index == numero)
                {
                    gengar02Trans.anchoredPosition -= new Vector2(2* gengarPixelMov, 0);
                }
            }


            foreach (int numero in gengarMov3)
            {
                if (index == numero)
                {
                    gengar02Trans.anchoredPosition -= new Vector2(3*gengarPixelMov, 0);
                }
            }

            foreach (int numero in gengarMov4)
            {
                if (index == numero)
                {
                    gengar02Trans.anchoredPosition -= new Vector2(4*gengarPixelMov, 0);
                }
            }

            foreach (int numero in gengarMov8)
            {
                if (index == numero)
                {
                    gengar02Trans.anchoredPosition -= new Vector2(8*gengarPixelMov, 0);
                }
            }

        foreach (int numero in nidorino02Up)
        {
            if (index == numero)
            {
                nidorino02Trans.anchoredPosition = new Vector2(nidorino02Trans.anchoredPosition.x, nidorino02Trans.anchoredPosition.y + 1);
            }
        }

        foreach (int numero in nidorino02Down)
        {
            if (index == numero)
            {
                nidorino02Trans.anchoredPosition = new Vector2(nidorino02Trans.anchoredPosition.x, nidorino02Trans.anchoredPosition.y - 1);
            }
        }

        if (index == 1199)
        {
            hierbitaTrans.anchoredPosition = new Vector2(194.88f, -46.1f);
        }


        if (index == 1201)
        {

            gengar02Trans.anchoredPosition = new Vector2(gengar02Trans.anchoredPosition.x, -11.03f);
        }

        if (index == 1219)
        {
            gengar02Trans.anchoredPosition -= new Vector2(7 * gengarPixelMov, 0);
        }

        if (index == 1231 || index == 1292)
        {
            gengar02Image.sprite = gengar02[1];
        }

        if (index == 1201 || index == 1261 || index == 1321)
        {
            gengar02Image.sprite = gengar02[0];
            nidorino02Image.sprite = nidorino02[1];
        }

        if (index == 1269)
        {
            nidorino02Image.sprite = nidorino02[0];
        }

        if (index == 1271)
        {
            nidorino02Trans.anchoredPosition = new Vector2(nidorino02Trans.anchoredPosition.x, nidorino02Trans.anchoredPosition.y - 1f);
        }

        if (index == 1318)
        {
            nidorino02Image.sprite = nidorino02[2];
        }


        if (index == 1350)
        {
            gengar02Image.sprite = gengar02[2];
        }
        if (index == 1351 || index == 1362)
        {
            gengar02Trans.anchoredPosition = new Vector2(gengar02Trans.anchoredPosition.x - 1.33f, gengar02Trans.anchoredPosition.y - 1.33f);
        }
        if (index == 1383)
        {
            nidorino02Image.sprite = nidorino02[0];
        }

        if (index == 1384 || index == 1385)
        {
            gengar02Trans.anchoredPosition = new Vector2(gengar02Trans.anchoredPosition.x + (5* gengarPixelMov), gengar02Trans.anchoredPosition.y);
        }
        if (index == 1386)
        {
            gengar02Image.sprite = gengar02[3];
            gengar02Trans.anchoredPosition = new Vector2(gengar02Trans.anchoredPosition.x + 22.4f, gengar02Trans.anchoredPosition.y);
            nidorino02Image.sprite = nidorino02[3];

        }
        if (index == 1387)
        {
            gengar02Trans.anchoredPosition = new Vector2(gengar02Trans.anchoredPosition.x + (10 * gengarPixelMov), gengar02Trans.anchoredPosition.y);


        }
        if (index == 1388)
        {
            gengar02Trans.anchoredPosition = new Vector2(gengar02Trans.anchoredPosition.x + (9 * gengarPixelMov), gengar02Trans.anchoredPosition.y - (2 * gengarPixelMov));

        }
        if (index == 1389)
        {
            gengar02Trans.anchoredPosition = new Vector2(gengar02Trans.anchoredPosition.x, gengar02Trans.anchoredPosition.y - (3 * gengarPixelMov));

        }
        if (index == 1390)
        {
            gengar02Trans.anchoredPosition = new Vector2(gengar02Trans.anchoredPosition.x + (9 * gengarPixelMov), gengar02Trans.anchoredPosition.y - (4 * gengarPixelMov));

        }
        if (index == 1391)
        {
            gengar02Trans.anchoredPosition = new Vector2(gengar02Trans.anchoredPosition.x - (9 * gengarPixelMov), gengar02Trans.anchoredPosition.y + (4 * gengarPixelMov));

        }
        if (index == 1392)
        {
            gengar02Trans.anchoredPosition = new Vector2(gengar02Trans.anchoredPosition.x, gengar02Trans.anchoredPosition.y + (3 * gengarPixelMov));

        }

        if (index == 1393)
        {
            gengar02Trans.anchoredPosition = new Vector2(gengar02Trans.anchoredPosition.x - (9 * gengarPixelMov), gengar02Trans.anchoredPosition.y + (2 * gengarPixelMov));

        }
        if (index == 1394)
        {
            gengar02Trans.anchoredPosition = new Vector2(gengar02Trans.anchoredPosition.x - (10 * gengarPixelMov), gengar02Trans.anchoredPosition.y);
            gengar02Image.sprite = gengar02[1];

        }

        if ((index > 1386 && index < 1401) || (index > 1403 && index < 1415))
        {
            nidorino02Trans.anchoredPosition += (nidorinoMov[indexPrueba] * 1.3f);

            indexPrueba++;
        }



        if (index == 1402)
        {
            nidorino02Image.sprite = nidorino02[1];

            nidorino02Trans.anchoredPosition = new Vector2(nidorino02Trans.anchoredPosition.x, -29);

        }

        if (index == 1404)
        {
            nidorino02Trans.anchoredPosition = new Vector2(nidorino02Trans.anchoredPosition.x + (4 * 1.3f), -29);
        }

        else if (index == 1387 || index == 1389 || index == 1391 || index == 1393)
        {
            golpeImage.enabled = true;
        }
        else
        {
            golpeImage.enabled = false;

        }
        if (index == 1415)
        {
            nidorino02Image.sprite = nidorino02[2];
        }


        if (index == 1408)
        {
            backEffectImg.enabled = true;

        }

        if (index > 1408)
        {
            if (index != 1446)
            {
                if (index > 1408 && indexPrueba2 < backEffectPos.Length)
                {
                    backEffectImg.sprite = backEffectSpr[indexPrueba2];
                    backEffectImg.gameObject.GetComponent<RectTransform>().anchoredPosition = backEffectPos[indexPrueba2];

                }
                if (indexPrueba2 < backEffectSpr.Length)
                {
                    indexPrueba2++;
                    print(indexPrueba2);
                }

            }
            if (index == 1432)
            {
                nidorino02Image.sprite = nidorino02[1];
                backEffectImg.gameObject.GetComponent<RectTransform>().anchoredPosition = backEffectPos[6];
            }

            if (index > 1436 && index < 1453 && index != 1446)
            {
                if (index == 1437)
                {
                    nidorino02Image.sprite = nidorino02[3];
                }

                nidorino02Trans.anchoredPosition += (nidorinoMov[indexPrueba] * 1.3f);
                indexPrueba++;
            }
            if (index == 1453)
            {
                nidorino02Image.sprite = nidorino02[1];
            }
        }

        if (index == 1454)
        {
            backEffectImg.enabled = false;
        }

        if (index == 1458)
        {
            nidorino02Image.sprite = nidorino02[2];
        }

        if (index == 1477)
        {
            nidorino02Image.sprite = nidorino02[1];

        }
        if (index == 1480)
        {
            nidorino02Image.sprite = nidorino02[3];

        }

        if (index >= 1480 && index <= 1487)
        {
            nidorino02Trans.anchoredPosition += nidorinoMov[indexPrueba]*1.3f;
            indexPrueba++;
        }

        if (index == 1488)
        {
            nidorino02Image.sprite = nidorino02[1];
            nidorino02Trans.anchoredPosition = new Vector2(275f, -28.3f);
        }

        if (index == 1524 || index == 1527 || index == 1532 || index == 1535 || index == 1539)
        {
            nidorino02Trans.anchoredPosition = new Vector2(nidorino02Trans.anchoredPosition.x + 1.3f, nidorino02Trans.anchoredPosition.y);
        }
        if (index == 1526 || index == 1529 || index == 1533 || index == 1535 || index == 1539)
        {
            nidorino02Trans.anchoredPosition = new Vector2(nidorino02Trans.anchoredPosition.x - 1.3f, nidorino02Trans.anchoredPosition.y);
        }

        if (index == 1580)
        {
            nidorino02Image.sprite = nidorino02[4];
        }

        if (index > 1580 && index < 1622)
        {
            nidorino02Trans.anchoredPosition += nidorinoMov[indexPrueba]*1.3f;
            indexPrueba++;

        }

        if (index == 1580 || index == 1581 || index == 1584 || index == 1588 || index == 1592 || index == 1594 || index == 1598 || index == 1603 || index == 1608)
            {
                fondoblanco06.color = new Color(1, 1, 1, degradadoFondo);
                degradadoFondo += degradadoFondo;
            }
        if (index == 1622)
        {
            nidorino02Trans.localScale = new Vector3(1.4f, 1.45f, 1);
            gengar02Trans.localScale = new Vector3(1.4f, 1.446f, 1);
        }

        if (index == 1624)
        {
            nidorino02Trans.localScale = new Vector3(1.6f, 1.75f, 1);
            gengar02Trans.localScale = new Vector3(1.6f, 1.778f, 1);
        }

        if (index == 1626)
        {
            nidorino02Trans.localScale = new Vector3(1.8f, 2.05f, 1);
            gengar02Trans.localScale = new Vector3(1.8f, 2.11f, 1);
        }

        if (index == 1628)
        {
            nidorino02Trans.localScale = new Vector3(1.9f, 2.2f, 1);
            gengar02Trans.localScale = new Vector3(1.9f, 2.276f, 1);
            fondoblanco06.color = Color.white;
        }


        if (index == 1630 || index == 1632 || index == 1634 || index == 1636)
        {

            fondoblanco06.color = new Color(fondoblanco06.color.r - 0.25f, fondoblanco06.color.b - 0.25f, fondoblanco06.color.g - 0.25f, 1f);

        }

        if (index == 1631 || index == 1633 || index == 1635 || index == 1637)
        {
            nidorino02Image.color = new Color(nidorino02Image.color.r - 0.25f, nidorino02Image.color.b - 0.25f, nidorino02Image.color.g - 0.25f, 1f);
            gengar02Image.color = new Color(gengar02Image.color.r - 0.25f, gengar02Image.color.b - 0.25f, gengar02Image.color.g -0.25f , 1f);
        }
        if (index == 1638)
        {
            introGameObject[1].SetActive(false);
            gameObject.SetActive(false);
            introGameObject[6].SetActive(true);
        }



        foreach (GameObject fondo in fondosbosque2)
        {
            RectTransform fondoRect = fondo.GetComponent<RectTransform>();
            if (fondoRect.anchoredPosition.x > 350f)
            {
                fondoRect.anchoredPosition = new Vector2(-fondoRect.anchoredPosition.x, 0);
            }
            else
            {
                if (index > 1171 && index < 1236)
                {
                    fondoRect.anchoredPosition += new Vector2(4.3f, 0);
                }
                else
                {
                    foreach (int numero in fondoMov1)
                    {
                        if (index == numero)
                        {
                            fondoRect.anchoredPosition += new Vector2(1f, 0);
                        }
                    }
                }

            }
        }

        if (index > 1171 && index < 1230)
        {
            nidorino02Trans.anchoredPosition += new Vector2(4.3f, 0);
        }



    }
}
