using UnityEngine;
using System.Collections;

public class Metronome : MonoBehaviour 
{
	public static int beat;
	public static bool beatDidChange = false;
	
	private int lastBeat;
	
	private int beatsPerMinute = 60;
	
	private float interval;
	
	// Use this for initialization
	void Start () 
	{
		interval = 60 / beatsPerMinute;
		
		StartCoroutine( Tick() ); 
	}
	
	// Update is called once per frame
	void Update () 
	{
		if ( beat != lastBeat )
		{
			beatDidChange = true;
			lastBeat = beat;
			Debug.Log ( beat );
		}
		else
		{
			beatDidChange = false;
		}
	}
	
	IEnumerator Tick()
	{
		yield return new WaitForSeconds( interval );
		
		beat++;
		
		if ( beat > 16 )
		{
			beat = 1;
		}
		
		

		StartCoroutine( Tick() ); 
	}
	public static Color getColorByBeat(){
		switch(beat){
			case 1: return new Color(214,111,0);
				break;
			case 2: return new Color(128,128,128);
				break;
			case 3: return new Color(192,192,192);
				break;
			case 4: return new Color(255,255,255);
				break;
			case 5: return new Color(128,0,0);
				break;
			case 6: return new Color(255,0,0);
				break;
			case 7: return new Color(128,128,0);
				break;
			case 8: return new Color(255,255,0);
				break;
			case 9: return new Color(0,128,0);
				break;
			case 10: return new Color(0,255,0);
				break;
			case 11: return new Color(0,128,128);
				break;
			case 12: return new Color(0,255,255);
				break;
			case 13: return new Color(0,0,128);
				break;
			case 14: return new Color(0,0,255);
				break;
			case 15: return new Color(128,0,128);
				break;
			case 16: return new Color(255,0,255);
				break;
			default: return new Color(255,255,255);
				break;			
		}
	}
}
