using System;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

using System.Collections.Generic;


public class menu : MonoBehaviour
{

	public Text textComponent;
	public GameObject flecha;
	private Image flechaImg;


	private bool ascendente;
	private Vector2 animationPos;
	private Vector2 originalPos;
	private float diferencia = 1.5f;

	private int indexIntroduccion;
	private string[] introduccion =
	{
		"Hello there!\nGlad to meet you!",
		"Welcome to the world of POKéMON!",
		"My name is Oak.",
		"People affectionately refer to me as the POKéMON PROFESSOR.",
		"People affectionately refer to me as ansuf."
	};

	List<char> charList;

	private bool block;
	private bool inicio;

	//PRUEBAS

	private SpriteRenderer flechaSprite;


	void Start ()
	{
		textComponent = GetComponentInChildren<Text>();
		textComponent.mainTexture.filterMode = FilterMode.Point;

		charList = new List<char>();



		flecha = GameObject.Find("Flecha");
		flechaImg = flecha.GetComponent<Image>();
		flecha.GetComponent<Image>().enabled = false;

		block = false;

		ascendente = false;
		inicio = false;

		//PRUEBAS
	}
	
	void Update ()
	{
		if (inicio == false)
		{
			ascendente = false;
			flechaImg.enabled = false;
			textComponent.text = "";
			StartCoroutine(Mensaje());
			block = true;
			inicio = true;

		}

		if (Input.GetKey(KeyCode.Space) && indexIntroduccion <= 3 && block == false)
		{
			ascendente = false;
			flechaImg.enabled = false;
			textComponent.text = "";
			StartCoroutine(Mensaje());
			block = true;
		}

		//if (flechaImg.enabled)
		//{
		//    originalPos = flechaTrans.anchoredPosition;
		//    animationPos = flechaTrans.anchoredPosition;

		//    if (Time.time - keyTime >= 0.25f)
		//    {

		//        if (!ascendente)
		//        {
		//            animationPos.y -= diferencia;
		//        }
		//        else
		//        {
		//            animationPos.y += diferencia;
		//        }
				
		//        keyTime = Time.time;
		//        flechaTrans.anchoredPosition = animationPos;

		//    }

		//    if (originalPos.y - animationPos.y >= 3.0f)
		//    {
		//        ascendente = true;
		//    }

		//    if (originalPos == animationPos)
		//    {
		//        ascendente = false;
		//    }


		//}

	}

   IEnumerator Mensaje()
	{
		charList.AddRange(introduccion[indexIntroduccion].ToCharArray());
	   
		for (int i = 0; i < charList.Count; i++)
		{
			textComponent.text += charList[i].ToString();

			//flechaPosPorletraPixel(textComponent.text);


			
			if (!Input.GetKey(KeyCode.Space))
			{
				yield return new WaitForSeconds(0.05f);
			}
			else
			{
				yield return new WaitForSeconds(0.02f);

			}

		}



		//flechaPos(textComponent.preferredWidth);

		flechaImg.enabled = true;

		charList.Clear();

		indexIntroduccion++;

		block = false;
	}

	//public void flechaPos(float msgWidth)
	//{

	//    if (msgWidth > 199.0f)
	//    {
	//        flechaTrans.anchoredPosition = new Vector2((msgWidth - 199.0f), - 18f);
	//    }
	//    else
	//    {
	//        flechaTrans.anchoredPosition = new Vector2(msgWidth + 5f, - 1f);
	//    }
	//    originalPos = flechaTrans.anchoredPosition;

	//}

	//public void flechaPosPorletraPixel(string frase)
	//{
	//    float suma = 0;
	//    bool nuevaLinea = false;


	//    List<Char> listaChar = new List<char>();

	//    listaChar.AddRange(frase.ToCharArray());


	//    if (listaChar.Contains('\n'))
	//    {
	//        int indexDeBorrado = listaChar.IndexOf('\n');
	//        listaChar.RemoveRange(0, indexDeBorrado + 1);
	//        nuevaLinea = true;
	//    }

	//    foreach (char c in listaChar)
	//    {
	//        switch (c)
	//        {
	//            case 'H': case 'e': case 'o': case 'h': case 'G': case 'a': case 'd': case 'm': case 'y': case 'u': case 'W': case 'c': case 'w': case 'P': case 'O': case 'K': case 'M': case 'N': case 'é':
	//                suma += 5f;      
	//                break;
	//            case 'l':
	//                suma += 2f;
	//                break;
	//            case 't': case'r': case 'f':
	//                suma += 4f;      
	//                break;
	//            case '!':
	//                suma += 1f;      
	//                break; 

	//            default:
	//                suma += 1f;      
	//                break;
	//        }
	//    }

	//    //suma *= textComponent.rectTransform.localScale.x;
	//    suma += listaChar.Count;


	//    if (!nuevaLinea)
	//    {
	//        flechaTrans.anchoredPosition = new Vector2(suma, -1f);
	//        print(listaChar.Count);

	//        print(suma);

	//    }
	//    else
	//    {
	//        flechaTrans.anchoredPosition = new Vector2(suma, -18f);
	//        //print(suma);

	//    }
	//}


}
