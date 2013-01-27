using UnityEngine;
using System.Collections;

public class ActivationTrigger : MonoBehaviour 
{
	public GameObject target;
	public Light doorlight;
	
	void OnTriggerEnter( Collider other )
	{
		if ( other.gameObject.CompareTag( "Player" ) )
		{
			if ( target != null )
			{
				target.SendMessage( "Activate" );
				doorlight.intensity = 5;
			}
		}
		
	}
	
	void OnTriggerExit( Collider other )
	{
		if ( other.gameObject.CompareTag( "Player" ) )
		{
			if ( target != null )
			{
				target.SendMessage( "Deactivate" );
				doorlight.intensity = 0;
			}
		}
		
	}
}
