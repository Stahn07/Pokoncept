using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class intro : MonoBehaviour
{

	private AudioSource sounds;

    public AudioClip[] intro_clips;
	private GameObject canvasMsg;
	public static int index;
	public static List<GameObject> introGameObject = new List<GameObject>();
	private string[] nombresIntro = {"intro_01", "intro_02", "intro_03", "intro_04", "intro_05", "intro_06", "intro_07"};
	void Start ()
	{
		Application.targetFrameRate = 60;

		index = 0;
		for (int i = 0; i < nombresIntro.Length; i++)
		{
			introGameObject.Add(GameObject.Find(nombresIntro[i]));
			introGameObject[i].SetActive(false);
			
		}

		introGameObject[0].SetActive(true);

		canvasMsg = GameObject.Find("Canvas Mensaje");
		canvasMsg.SetActive(false);

		sounds = GetComponent<AudioSource>();
	}

	void FixedUpdate()
	{
		index++;

		print(index);

		if (index > 440 && index < 1699 && Input.GetKey(KeyCode.Space))
		{
			index = 1700;

			foreach (GameObject intro in introGameObject)
			{
				GameObject intros = intro;
				intros.SetActive(false);
			}

			introGameObject[6].SetActive(true);
		}

		if (index == 441)
		{
		    sounds.clip = intro_clips[0];
			sounds.Play();
		}

	    if (index == 935)
	    {
	        sounds.clip = intro_clips[1];
	        sounds.Play();
	    }

	    if (index == 1700)
	    {
	        sounds.clip = intro_clips[2];
            sounds.Play();
	    }


	}

	public virtual void indexFrame()
	{
			
	}


	
}

