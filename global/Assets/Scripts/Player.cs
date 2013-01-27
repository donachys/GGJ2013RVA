using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour 
{	
	public static Vector3 currentPosition;
	public static Vector3 lookDirection;
	
	public static int numberOfTrinkets = 0;
	
	public static bool hasWon = false;
	
	public AudioClip winAudio;
	
	// Use this for initialization
	void Start () 
	{
	}
	
	// Update is called once per frame
	void Update () 
	{
		if ( Input.GetKeyDown( KeyCode.Escape) )
		{
			Application.Quit();
		}
		
		currentPosition = transform.position;
		lookDirection = transform.forward;
		
		if ( numberOfTrinkets >= 4 && !hasWon )
		{
			Debug.Log( "win" );
			audio.PlayOneShot( winAudio );
			hasWon = true;
			Messenger.Broadcast( "Win" );
		}
	}
}
