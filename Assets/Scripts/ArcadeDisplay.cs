using UnityEngine;
using System.Collections;

public class ArcadeDisplay : MonoBehaviour 
{
	public string triggerID;
	int gameID;
	// Use this for initialization
	void Start () 
	{
		
	}
	//Seaches the MDA in DataLoad matching the triggerID with the applicable Array
	void DataConnection()
	{
		for (int x = 0; x < DataLoad.gameData.GetLength(0); x++) 
		{
			if(DataLoad.gameData[x,0].Equals(triggerID))
			{
				gameID = x;
			}	
		}	
	}
	
	void Update () 
	{
		
	}
	void OnTriggerEnter(Collider collider)
	{
		
		GameObject banner = GameObject.Find("Banner");
		GameObject light = GameObject.Find("light_banner");
		if(collider.gameObject.tag == "Player")
		{
			triggerID = gameObject.name;
			Debug.Log("Trigger Arcade");
			DataConnection();
			Debug.Log ("triggerID: " + triggerID + " gameID: " + gameID + " Game Name: " + DataLoad.gameData[gameID, 1]);
			banner.renderer.enabled = true;
			light.light.enabled = true;
			//banner.renderer.material.SetTexture("_MainTex", PlayerTemp);
		}
	}
}