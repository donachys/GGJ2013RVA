using UnityEngine;
using System.Collections;

public class RandomBallGenerator : MonoBehaviour 
{
	public int numberToGenerate = 100;
	
	public GameObject prefab;
	
	// Use this for initialization
	void Start () 
	{
		float maxDistance = 100;
		
		for ( int i = 0; i < numberToGenerate; i++ )
		{
			GameObject instance = Instantiate( prefab ) as GameObject;
			
			Vector3 newPosition = transform.position;
			newPosition.x = Random.Range( -maxDistance, maxDistance );
			newPosition.z = Random.Range( -maxDistance, maxDistance );
			
			instance.transform.position = newPosition;
		}
	}
	
	void OnEnable()
	{
		Messenger.AddListener( "Win", Win );	
	}
	
	void OnDisable()
	{
		Messenger.RemoveListener( "Win", Win );	
	}
	
	// Update is called once per frame
	void Win () 
	{
		float maxDistance = 100;
		
		for ( int i = 0; i < 600; i++ )
		{
			GameObject instance = Instantiate( prefab ) as GameObject;
			
			Vector3 newPosition = transform.position;
			newPosition.x = Random.Range( -maxDistance, maxDistance );
			newPosition.z = Random.Range( -maxDistance, maxDistance );
			
			instance.transform.position = newPosition;
		}
	}
}
