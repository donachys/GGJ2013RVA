using UnityEngine;
using System.Collections;

public class AudioInput : MonoBehaviour 
{
	public static float volume;
	public static float smoothedVolume;
	public static bool beat;
	
	private const float minThreshold = -50;
	private const float maxThreshold = 10;
	
	private const int FREQUENCY = 48000;
	private const int SAMPLE_COUNT = 1024;
  	private const float REF_VALUE = 0.1f;    // RMS value for 0 dB.
	
  	private float rmsValue;            // Volume in RMS

 	 private float dbValue;             // Volume in DB
	
	
	 private float[] samples;        
	
	// Use this for initialization
	void Start () 
	{
  		samples = new float[SAMPLE_COUNT];
		
		StartMicrophone();
	}
	
	void Update()
	{
  	  	if (!audio.isPlaying) 
		{

			StartMicrophone();
   		}
		
		AnalyzeSound();
	}
	
	void StartMicrophone()
	{
   		audio.clip = Microphone.Start("Built-in Microphone", true, 30, FREQUENCY);

    	// HACK - Forces the function to wait until the microphone has started, before moving onto the play function.

    	while (!(Microphone.GetPosition("Built-in Microphone") > 0)) 
		{

    	} 
		audio.Play();
		audio.volume = 0.0001f;
		
	}
	
	// Update is called once per frame
	void AnalyzeSound () 
	{
   		audio.GetOutputData(samples, 0);
		
   		float sum = 0;

    	for (int i = 0; i < SAMPLE_COUNT; i++)
		{

      		sum += Mathf.Pow(samples[i], 2);

    	}
		
	    // RMS is the square root of the average value of the samples.
	
	    rmsValue = Mathf.Sqrt( sum / SAMPLE_COUNT );
	
	    dbValue = 20 * Mathf.Log10(rmsValue / REF_VALUE);
		
		float currentDB = dbValue;
		if ( currentDB < minThreshold )
		{
			currentDB = minThreshold;
		}
		
		if ( currentDB > maxThreshold )
		{
			currentDB = maxThreshold;
		}
		
		float totalAudioSpace = maxThreshold - minThreshold;
		currentDB = currentDB - minThreshold;
		
		volume = currentDB / totalAudioSpace;
		
		smoothedVolume = Mathf.Lerp( smoothedVolume, volume, 0.2F );
		
		if ( Input.GetKey( KeyCode.E ) )
		{
			//volume = 0.9F;
			//smoothedVolume = 0.9F;
		}
		
		//Debug.Log( smoothedVolume );
	}
		
	
}
