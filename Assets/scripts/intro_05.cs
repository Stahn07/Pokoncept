using UnityEngine;
using UnityEngine.UI;

public class intro_05 : intro
{

	private RectTransform gengar01RectTransform;
	private RectTransform nidorino01Transform;

    private GameObject fondo05;



	void Start ()
	{
        fondo05 = GameObject.Find("fondo_naranja");
		gengar01RectTransform = GameObject.Find("gengar01").GetComponent<RectTransform>();
		nidorino01Transform = GameObject.Find("nidorino01").GetComponent<RectTransform>();
	}
	
	void FixedUpdate () {
	    if (index == 1107 || index == 1121 || index == 1128 || index == 1135 || index == 1143 || index == 1150 ||
	        index == 1156 || index == 1163)
	    {
             nidorino01Transform.anchoredPosition -= new Vector2(0, 1.7f);

	    }

	    if (index == 1114 || index == 1122 || index == 1130 || index == 1138 || index == 1146 || index == 1155 || index == 1162)
	    {
	        gengar01RectTransform.anchoredPosition += new Vector2(0, 1.4f);

	    }

	    if (index == 1169)
	    {
	        fondo05.GetComponent<Image>().color = Color.white;
            gengar01RectTransform.gameObject.SetActive(false);
            nidorino01Transform.gameObject.SetActive(false);
            introGameObject[5].SetActive(true);
            gameObject.SetActive(false);
	    }


	}
	
	}

