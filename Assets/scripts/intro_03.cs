using UnityEngine;
using UnityEngine.UI;

public class intro_03 : intro
{

	private CanvasRenderer blanco;
	private Image hierba;

	private Image intro03_fondo;
	public Sprite hierba_01;
	public Sprite hierba_02;
	public Sprite hierba_025;
	public Sprite hierba_03;
	public Sprite hierba_040;
	public Sprite hierba_041;
	public Sprite hierba_042;
	public Sprite hierba_043;
	public Sprite hierba_044;
	public Sprite hierba_050;
	public Sprite hierba_051;
	public Sprite hierba_052;

	public Sprite intro03_fondo02;
	public Sprite intro03_fondo03;

    private int index03;

	void Start ()
	{
		hierba = GameObject.Find("hierba").GetComponent<Image>();
		blanco = GameObject.Find("fondoblanco").GetComponent<CanvasRenderer>();
		intro03_fondo = GameObject.Find("intro03_fondo").GetComponent<Image>();

	}
	void FixedUpdate () {


		indexFrame();

	}

	public override void indexFrame()
	{
	    if (index > 985 && index < 993)
	    {

	        if (index != 987 && index != 989 && index != 990)
	        {
	            blanco.SetAlpha(blanco.GetAlpha() - 0.25f);
	            if (index == 991)
	            {
                    hierba.sprite = hierba_01;
	            }
	        }

	    }

	    if (index == 997)
	    {
	        hierba.sprite = hierba_02;
	    }

	    if (index == 1002)
	    {
	        hierba.sprite = hierba_03;
	    }
	    if (index == 1008)
	    {
	        hierba.sprite = hierba_01;
	    }

	    if (index == 1014)
	    {
	        hierba.sprite = hierba_02;
	    }

	    if (index == 1019)
	    {
	        hierba.sprite = hierba_025;
	    }

	    if (index == 1020)
	    {
	        hierba.sprite = hierba_03;
	    }

	    if (index == 1021)
	    {
	        hierba.sprite = hierba_040;
	    }
	    if (index == 1022)
	    {
	        hierba.sprite = hierba_041;
	        intro03_fondo.sprite = intro03_fondo02;
	    }
	    if (index == 1023)
	    {
	        hierba.sprite = hierba_042;
	    }
	    if (index == 1024)
	    {
	        hierba.sprite = hierba_043;
	    }
	    if (index == 1025)
	    {
	        hierba.sprite = hierba_044;
	    }
	    if (index == 1026)
	    {
	        hierba.sprite = hierba_050;
	        intro03_fondo.sprite = intro03_fondo03;
	    }
	    if (index == 1027)
	    {
	        hierba.sprite = hierba_051;
	    }
	    if (index == 1028)
	    {
	        hierba.sprite = hierba_052;
	    }
	    if (index == 1029)
	    {
	        blanco.SetAlpha(1);
            introGameObject[3].SetActive(true);
            hierba.gameObject.SetActive(false);
            intro03_fondo.gameObject.SetActive(false);
	    }
	    if (index > 1033 && index < 1041)
	    {

	        if (index != 1035 && index != 1036 && index != 1039)
	        {
	            blanco.SetAlpha(blanco.GetAlpha() - 0.25f);
	        }
            
	    }

	    if (index == 1042)
	    {
	        gameObject.SetActive(false);
	    }

	}
}
