using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class WorldLoad : MonoBehaviour 
{	
	public static int numOfGames = 3;
	int numOfTiles = (numOfGames * 4) + 10;
	float newPosArcade = -7.0f;
	float newPosFloor = -21.0f;
	float newPosBackStop = -21.0f;
	
	//public string[] g1 = {"2","5","2"};
	void Start () 
	{
		for(int i = 0; i < numOfGames; i++)
		{
			newPosArcade += 14.0f;
			GameObject arcades = Instantiate(Resources.Load ("arcade"), new Vector3(newPosArcade, 2.0f, -1.5f), Quaternion.Euler(0, 270, 0)) as GameObject;
		}
		for(int i = 0; i < numOfTiles; i++)
		{
			newPosFloor += 4.0f;
			GameObject arcades = Instantiate(Resources.Load ("Floor"), new Vector3(newPosFloor, 0f, -2.5f), Quaternion.Euler(0, 0, 0)) as GameObject;
		}
		for(int i = 0; i < numOfTiles; i++)
		{
			newPosBackStop += 4.0f;
			GameObject arcades = Instantiate(Resources.Load ("BackStop"), new Vector3(newPosBackStop, 10.0f, 0f), Quaternion.Euler(0, 0, 0)) as GameObject;
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
