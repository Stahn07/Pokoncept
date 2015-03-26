using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class intro_07 : intro
{

	public Sprite charizard_Red;

	private RectTransform degradadoTrans;
	private Image degradadoImg;
	private Image charizardImg;
	private CanvasRenderer logo_version_white;
	private CanvasRenderer logo_pokemon_white;
	private Image logo_version;
	private Image logo_pokemon;
	private Image pressStartImg;
	private int contadorPressStart;

	private float degradado29 = 0.034482f;

	private CanvasRenderer charizard_white;
	private float[] charizardAlpha = {0.00784f, 0.33725f, 0.55294f, 0.48627f, 0.25882f, 0.50980f, 1f};
	private int indexCharizard;

	private RectTransform bluetrans;
	private RectTransform redTrans;
	private RectTransform orangeTrans;


	void Start ()
	{
		logo_version = GameObject.Find("logo_version").GetComponent<Image>();
		logo_version.enabled = false;
		logo_pokemon = GameObject.Find("logo_pokemon").GetComponent<Image>();
		logo_pokemon.enabled = false;
		pressStartImg = GameObject.Find("PressStart").GetComponent<Image>();

		logo_version_white = GameObject.Find("logo_version_white").GetComponent<CanvasRenderer>();
		logo_version_white.SetColor(Color.black);

		logo_version_white.gameObject.SetActive(false);

		logo_pokemon_white = GameObject.Find("logo_pokemon_white").GetComponent<CanvasRenderer>();
		logo_pokemon_white.SetColor(Color.black);

		logo_pokemon_white.gameObject.SetActive(false);


		charizard_white = GameObject.Find("Charizard_effect_white").GetComponent<CanvasRenderer>();
		charizardImg = GameObject.Find("Charizard").GetComponent<Image>();
		degradadoTrans = GameObject.Find("degradado").GetComponent<RectTransform>();
		degradadoImg = degradadoTrans.gameObject.GetComponent<Image>();
		charizard_white.gameObject.SetActive(false);
		bluetrans = GameObject.Find("blue_border").GetComponent<RectTransform>();
		redTrans = GameObject.Find("red_border").GetComponent<RectTransform>();
		orangeTrans = GameObject.Find("orange_border").GetComponent<RectTransform>();

	}
	
	void FixedUpdate () {

		if (index > 1700 && index < 1730 && Input.GetKey(KeyCode.Space))
		{
			index = 1983;
			charizardImg.material = null;

			charizardImg.sprite = charizard_Red;
			logo_version.enabled = true;
			logo_pokemon.enabled = true;
			bluetrans.anchoredPosition = new Vector2(0f, 12.5f);
			orangeTrans.anchoredPosition = new Vector2(0f, -5.650002f);
			redTrans.anchoredPosition = new Vector2(0.1000061f, .3f);
			degradadoTrans.gameObject.SetActive(false);
			
		}

		if (index > 1708 && index < 1730)
		{
			if (index == 1710 || index == 1720)
			{
				degradadoTrans.anchoredPosition += new Vector2(0, 16);

			}
			else
			{
			degradadoTrans.anchoredPosition += new Vector2(0, 8);
			}
		}

		if (index == 1731)
		{
			charizardImg.material = null;
			charizardImg.color = Color.black;
			degradadoImg.gameObject.SetActive(false);
		}

		if (index == 1762 || index == 1772 || index == 1783 || index == 1794 || index == 1803 || index == 1814 ||
			index == 1823 || index == 1864)
		{
			charizardImg.color += new Color(0.125f, 0.125f, 0.125f);
		}

		if (index == 1870)
		{
			charizard_white.gameObject.SetActive(true);


		}

		if (index == 1874 || index == 1875 || index == 1877 || index == 1878)
		{
		   charizard_white.SetAlpha(charizardAlpha[indexCharizard]);
		   indexCharizard++;
		}

		if (index == 1879)
		{
			charizard_white.SetAlpha(0);
		}

		if (index > 1874 && index < 1885)
		{
			bluetrans.anchoredPosition += new Vector2(32,0);
		}
		if (index > 1895 && index < 1906)
		{
			orangeTrans.anchoredPosition -= new Vector2(32, 0);
			redTrans.anchoredPosition -= new Vector2(32, 0);

		}

		if (index == 1923 || index == 1924 || index == 1926)
		{
			
			charizard_white.SetAlpha(charizardAlpha[indexCharizard]);
			indexCharizard++;
		}

		if (index == 1927)
		{
			logo_version_white.gameObject.SetActive(true);
			logo_pokemon_white.gameObject.SetActive(true);

			logo_version.enabled = true;
			logo_pokemon.enabled = true;

			charizardImg.sprite = charizard_Red;

		}

		if (index > 1927 && index < 1957)
		{
			logo_pokemon_white.SetAlpha(logo_pokemon_white.GetAlpha() - degradado29);
			logo_version_white.SetAlpha(logo_version_white.GetAlpha() - degradado29);
			charizard_white.SetAlpha(charizard_white.GetAlpha() - degradado29);
		}

		if (index > 1983)
		{
			contadorPressStart++;

			if (pressStartImg.IsActive() && contadorPressStart == 60)
			{
					pressStartImg.enabled = false;
					contadorPressStart = 0;
			}
			else
			{
				if (contadorPressStart == 30)
				{
					pressStartImg.enabled = true;
				}
			}

		    if (Input.GetKey(KeyCode.Space))
		    {
		        Application.LoadLevel(1);
		    }
		}




	
	}
}
