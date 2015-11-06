using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class snex : MonoBehaviour 
{
	public GameObject Snex;
	Vector2 run = Vector2.up;
	float st = 0;
	private List<Transform> tails;
	bool sart = false;

	// Use this for initialization
	void Start () 
	{
		tails = new List<Transform>();
		InvokeRepeating("move",0.5f,0.5f);
	}


	// Update is called once per frame
	void Update () 
	{


		if (Input.GetKeyDown (KeyCode.D)) {
			run = Vector2.right;
		}
		else if (Input.GetKeyDown (KeyCode.A)) {
			run = -Vector2.right;
		}
		else if (Input.GetKeyDown (KeyCode.W)) {
			run = Vector2.up;
		}
		else if (Input.GetKeyDown (KeyCode.S)) {
			run = -Vector2.up;
		}
		st += Time.deltaTime;
		if(st >= 3f)
		{
			sart = true;
			st = 0;
		}
	
	}
	void move()
	{
		transform.Translate (run);
		Vector2 v = transform.position;
		
		if(sart)
		{GameObject g =(GameObject)Instantiate(Snex, v, Quaternion.identity);
		tails.Insert(0, g.transform);}
		
		if (tails.Count > 0) 
		{
			tails.Last().position = v;
			tails.Insert(0, tails.Last());
			tails.RemoveAt(tails.Count-1); 
		}
	}
	void OnTriggerEnter2D(Collider2D deathline )
	{
		if(deathline.name.StartsWith("line"))
		{
			Destroy(gameObject);
		}
	}
}
