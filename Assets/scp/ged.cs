using UnityEngine;
using System.Collections;

public class ged : MonoBehaviour 
{
	public GameObject GridSpawn;
	public GameObject lane;
	public int NumObjectX = 1;
	public int NumObjectY = 1;

	// Use this for initialization
	void Start () 
	{
		for(int x = 0; x < NumObjectX; x++)
		{
			for(int y = 0; y < NumObjectY; y++)
			{
				Instantiate(GridSpawn,transform.position+transform.right*x+transform.up*y,Quaternion.identity);
			}
		}
		for(int x = -1; x < NumObjectX+1; x++)
		{
			for(int y = -1; y < NumObjectY+1; y++)
			{
				Instantiate(lane,transform.position+transform.right*x+transform.up*y,Quaternion.identity);
			}
		}
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
