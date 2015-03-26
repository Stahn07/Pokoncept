using UnityEngine;
using System.Collections;
using UnityEditor.Animations;
using UnityEngine.UI;

public class intro_01 : intro
{



	private CanvasRenderer fondo_blanco_00;

	private Animator logo_nintendo;

	private int index01;
	private float transicion01 = 0.0625f;
	private float transicion0102 = 0.0333f;
	private float transicion0103 = 0.0667f;
	
	void Start ()
	{
		logo_nintendo = GameObject.Find("logo_nintendo").GetComponent<Animator>();

		logo_nintendo.enabled = false;
		fondo_blanco_00 = GameObject.Find("fondo_blanco_00").GetComponent<CanvasRenderer>();

		index01 = 15;

	}
	
	void FixedUpdate ()
	{
		if (index > 3 && index < 19)
		{
			fondo_blanco_00.SetAlpha(transicion01 * index01);
			index01--;
		}

		if (index == 26)
		{
			fondo_blanco_00.SetAlpha(0f);
			index01 = 1;
			logo_nintendo.enabled = true;
		}

		if (index > 215 && index < 247)
		{
			fondo_blanco_00.SetAlpha(transicion0102 * index01);
			index01++;
		}

		if (index == 250)
		{
			logo_nintendo.gameObject.SetActive(false);
			index01 = 14;
		}


		if (index > 285 && index < 301)
		{
			fondo_blanco_00.SetAlpha(transicion0103 * index01);
			index01--;
		}

		if (index == 400)
		{
			fondo_blanco_00.GetComponent<Image>().enabled = false;

			fondo_blanco_00.SetColor(Color.black);
			fondo_blanco_00.SetAlpha(0f);
			index01 = 1;

		}
		if (index == 401)
		{
			fondo_blanco_00.GetComponent<Image>().enabled = true;

		}

		if (index > 425 && index < 441)
		{
			fondo_blanco_00.SetAlpha(transicion0103 * index01);
			index01++;
		}

		if (index == 445)
		{
			gameObject.SetActive(false);
			introGameObject[1].SetActive(true);
		}



	}


}
