using UnityEngine;
using System.Collections;

public class Dinger : MonoBehaviour {
	public static bool ding = false;
	// Use this for initialization
	private int counts=0;
	private int pitches = 0;
	public AudioClip clip1;
	public AudioClip clip2;
	public AudioClip clip3;
	public AudioClip clip4;
	public AudioClip clip5;
	public AudioClip clip6;
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		//if(ding){
			//Debug.Log("Playing DING***");
			//audio.Play();
			//ding = false;
		//}
	}
	/*public void StartLoop(){
		StartCoroutine(myfunction);	
	}
	public IEnumerator myfunction(){
		yield return new WaitForSeconds(2.0f);
		counts++;
		audio.PlayOneShot();
	}*/
	public void Ding(){
		//Debug.Log("Playing Ding");
		AudioClip tempclip;
		switch (counts){
		case 0:tempclip = clip1;
			counts++;
			pitches++;
			break;
		case 1: tempclip = clip2;
			counts++;
			pitches++;
			break;
		case 2: tempclip = clip3;
			counts++;
			pitches++;
			break;
		case 3: tempclip = clip4;
			counts++;
			pitches++;
			break;
		case 4: tempclip = clip5;
			counts++;
			pitches++;
			break;
		case 5: tempclip = clip6;
			counts++;
			pitches++;
			break;
		default: tempclip = clip1;
			break;
		}
		if(counts>=6){
			counts = 0;	
		}
		if(pitches >=3){
			pitches = 1;
		}
		if(pitches == 0){
			pitches = 1;	
		}
		audio.pitch = pitches;
		audio.PlayOneShot(tempclip, 0.5f);	
	}
	void OnEnable(){
		Messenger.AddListener("DingMe", Ding);	
	}
	void OnDisable(){
		Messenger.RemoveListener("DingMe", Ding);
	}
}
