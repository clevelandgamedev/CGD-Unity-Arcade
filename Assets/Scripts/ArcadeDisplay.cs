using UnityEngine;
using System.Collections;

public class ArcadeDisplay : MonoBehaviour 
{
	public string gameID;
	// Use this for initialization
	void Start () 
	{
		gameID = gameObject.name;
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
			Debug.Log ("gameID: " + gameID);
			banner.renderer.enabled = true;
			light.light.enabled = true;
			//banner.renderer.material.SetTexture("_MainTex", PlayerTemp);
		}
	}
}