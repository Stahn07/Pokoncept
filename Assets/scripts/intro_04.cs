using System;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class intro_04 : intro
{

	private GameObject fondo;
	private List<GameObject> fondos; 
	private GameObject grass;
	private List<GameObject> grassList;
	private List<Vector2> grassPos;

	private int distGrass;
	private int anchoGrass = 48;

	private Image gengarImage;
	private Image nidorinoImage;

	public Material white;



	void Start ()
	{
		fondos = new List<GameObject>();
		fondo = GameObject.Find("FondoBosque");
		fondos.Add(fondo);
		for (int i = 0; i < 2; i++)
		{
			GameObject fondo2 = Instantiate(fondo);
			RectTransform fondo2Trans = fondo2.GetComponent<RectTransform>();
			fondo2Trans.SetParent(gameObject.GetComponent<RectTransform>(), false);
			fondo2Trans.SetSiblingIndex(1);

			if (i == 1)
			{
				fondo2Trans.anchoredPosition = new Vector2(256, 0);
			}
			else
			{
				fondo2Trans.anchoredPosition = new Vector2(-256, 0);
			}

			fondos.Add(fondo2);
		}

		grassPos = new List<Vector2>();
		grassList = new List<GameObject>();


		grass = GameObject.Find("Grass");
		grassList.Add(grass);


		for (int i = 1; i < 9; i++)
		{
			Vector2 posicionesPositivas = new Vector2(anchoGrass * i, 0);
			grassPos.Add(posicionesPositivas);

			Vector2 posicionesNegativas = -posicionesPositivas;
			grassPos.Add(posicionesNegativas);

			GameObject hierba3 = Instantiate(grass);
			RectTransform hierba3Trans = hierba3.GetComponent<RectTransform>();
			hierba3Trans.SetParent(gameObject.GetComponent<RectTransform>(), false);
			hierba3Trans.anchoredPosition = grassPos[i - 1];
			grassList.Add(hierba3);

		}


		distGrass = (anchoGrass * grassList.Count);
		grassPos.Clear();

		gengarImage = GameObject.Find("Gengar").GetComponent<Image>();
		nidorinoImage = GameObject.Find("Nidorino").GetComponent<Image>();


	}
	
	void FixedUpdate () {

		if (index == 1034)
		{
			gengarImage.material = white;
			nidorinoImage.material = white;
		}

		if (index > 1034 && index < 1106)
		{


			if(index == 1035)
			{
					gengarImage.material = gengarImage.defaultMaterial;
					nidorinoImage.material = nidorinoImage.defaultMaterial;
			}



			foreach (GameObject grassy in grassList)
			{
				RectTransform grassyTrans = grassy.GetComponent<RectTransform>();
				Vector2 newPos = grassyTrans.anchoredPosition;
				newPos += new Vector2(-1.4f, 0f);
				if (newPos.x <= -200.0f)
				{
					newPos = new Vector2(newPos.x + distGrass, 0);
				}

				newPos.x = (float)Math.Round(newPos.x, 2, MidpointRounding.AwayFromZero);
				grassyTrans.anchoredPosition = newPos;

			}

				
			foreach (GameObject fondoGo in fondos)
			{
				
				RectTransform fondo2Trans = fondoGo.GetComponent<RectTransform>();

				if (fondo2Trans.anchoredPosition.x > 350)
				{
					fondo2Trans.anchoredPosition = new Vector2(fondo2Trans.anchoredPosition.x - 764, 0f);
				}
				else
				{
					fondo2Trans.anchoredPosition += new Vector2(4.1f, 0f);
				}
			}

		}

		if (index == 1106)
		{


			foreach (GameObject grassyy in grassList)
			{
				grassyy.SetActive(false);
			}
			foreach (GameObject fondoss in fondos)
			{
				fondoss.SetActive(false);
			}
			introGameObject[1].SetActive(true);

			introGameObject[4].SetActive(true);

		}
		if (index > 1106)
		{
			gameObject.SetActive(false);
		}

	}
}
