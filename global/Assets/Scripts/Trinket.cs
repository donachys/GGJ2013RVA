using UnityEngine;
using System.Collections;

public class Trinket : MonoBehaviour 
{
	public GameObject[] targets;
	
	void OnTriggerEnter( Collider other )
	{
		if ( other.gameObject.CompareTag( "Player" ) )
		{
			foreach( GameObject target in targets )
			{
				target.SendMessage( "Activate" );
			}
			
			Player.numberOfTrinkets++;
			Destroy( gameObject );
		}
	}
}
