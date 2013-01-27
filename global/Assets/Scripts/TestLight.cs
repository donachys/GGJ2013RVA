using UnityEngine;
using System.Collections;

public class TestLight : MonoBehaviour 
{

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		float newIntensity = HeartBeatAudioAnalyzer.smoothedVolume;
		
		newIntensity *= 0.015F;
		
		if ( newIntensity > 0.4F )
		{
			newIntensity = 0.4F;
		}
		
		light.intensity = newIntensity;
		
		light.color = Metronome.getColorByBeat();
	
	}
}
