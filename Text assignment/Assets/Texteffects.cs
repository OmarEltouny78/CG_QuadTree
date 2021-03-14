using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Texteffects : MonoBehaviour
{
	public Text txt;
	public string story;
	public Color color;
	public float value;
	public float speed;
	public float r;
	public float g;
	public float b;

	void Awake()
	{
		txt = GetComponent<Text>();
		story = txt.text;
		txt.text = "";

		
		StartCoroutine("PlayText");

	}
	void Update()
    {
		color = txt.color;
		ModifyOpacity();
		ModifyColor();
	}

	void ModifyOpacity()
    {
		color.a=value;
		txt.color = color;
    }
	void ModifyColor()
    {
		color.r = r;
		color.g = g;
		color.b = b;
		txt.color = color;
    }

	IEnumerator PlayText()
	{
		foreach (char c in story)
		{
			txt.text += c;
			yield return new WaitForSeconds(1/speed);
		}
	}
}
