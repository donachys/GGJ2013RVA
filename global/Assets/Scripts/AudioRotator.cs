using UnityEngine;
using System.Collections;

public class AudioRotator : MonoBehaviour 
{
	public bool x;
	public bool y;
	public bool z;
	
	public bool waitUntilActivated;
	
	public Vector3 speed;
	
	public float volumeThreshold = 0.5F;
	
	private bool isActivated;
	
	// Update is called once per frame
	void Update () 
	{
		if ( !waitUntilActivated )
		{
			UpdateRotation();
		}
		else if ( isActivated )
		{
			UpdateRotation();
		}
	}
	
	void UpdateRotation()
	{
		if ( AudioInput.smoothedVolume > 0.5F )
		{
			Vector3 rotationSpeed = Vector3.zero;
			
			if ( x )
			{
				rotationSpeed.x = speed.x;
			}
			
			if ( y )
			{
				rotationSpeed.y = speed.y;
			}
			
			if ( z )
			{
				rotationSpeed.z = speed.z;
			}
			
			transform.Rotate( rotationSpeed * Time.deltaTime );
		}
	}
	
	void Activate()
	{
		isActivated = true;
		
		Debug.Log( "activate" );
	}
	
	void Deactivate()
	{
		isActivated = false;
	}
}
