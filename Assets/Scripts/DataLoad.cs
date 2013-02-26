using UnityEngine;
using System.Collections;

public class DataLoad : MonoBehaviour 
{
	public static string[,] gameData = new string[3,6] 
	{
		//{"Game ID","Game Name","Author","Description","ScreenShot","GameLocation"}
		{"g0","The Amazing Atom","Strangelet Studios","This was a game made for the April 2012 Ludum Dare","\\images\\ss\\taa.jpg","\\games\\taa\\taa.exe"}, 
		{"","","","","",""}, 
		{"","","","","",""}
	};
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
