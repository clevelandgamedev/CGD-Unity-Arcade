using UnityEngine;
using System.Collections;

public class ArcadeOff : MonoBehaviour 
{
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
	void OnTriggerEnter(Collider collider)
	{
		GameObject banner = GameObject.Find("Banner");
		GameObject light = GameObject.Find("light_banner");
		if(collider.gameObject.tag == "Player")
		{
			Debug.Log("Trigger Arcade");
			banner.renderer.enabled = false;
			light.light.enabled = false;
			 
		}
	}
}