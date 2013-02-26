using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class WorldLoad : MonoBehaviour 
{	
	public static int numOfGames = DataLoad.gameData.GetLength(0);
	float stageSize = (numOfGames * 20) + 10;
	float newPosArcade = -7.0f;
	float newPosFloor = -21.0f;
	float newPosBackStop = -21.0f;

	void Start () 
	{
		for(int i = 0; i < numOfGames; i++)
		{
			newPosArcade += 14.0f;
			GameObject arcades = Instantiate(Resources.Load ("arcade"), new Vector3(newPosArcade, 2.0f, -1.5f), Quaternion.Euler(0, 270, 0)) as GameObject;
			arcades.name = "arcade" + i;
			GameObject arcadeTrigger = Instantiate(Resources.Load ("arcadeTrigger"), new Vector3(newPosArcade, 2.0f, -5.0f), Quaternion.Euler(0, 270, 0)) as GameObject;
			arcadeTrigger.name = "g" + i;
		}
		GameObject Floor = GameObject.Find ("Floor");
		GameObject BackStop = GameObject.Find ("BackStop");
		
		Vector3 v3_FloorPos = new Vector3((stageSize*.5f)-25.0f, 0f, -2.5f);
		Vector3 v3_BackStopPos = new Vector3((stageSize*.5f)-25.0f,10f, -0.5f);
		
		Vector3 v3_FloorSize = new Vector3(stageSize, 4.0f, 10.0f);
		Vector3 v3_BackStopSize = new Vector3(stageSize, 20.0f, 1.0f);
		
		Floor.transform.localPosition = v3_FloorPos;
		Floor.transform.localScale = v3_FloorSize;
		
		BackStop.transform.localPosition = v3_BackStopPos;
		BackStop.transform.localScale = v3_BackStopSize;
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
