using UnityEngine;
using System.Collections;

public class PushPlayerWhenQuiet : MonoBehaviour 
{
// Update is called once per frame
	public ParticleEmitter waterfall1;
	public ParticleEmitter waterfall2;
	void Update () 
	{
		
		if(AudioInput.smoothedVolume <=0.6f){
			waterfall1.emit = true;
			waterfall2.emit = true;
		}else{
			waterfall1.emit = false;
			waterfall2.emit = false;
		}
	
	}
	void OnTriggerStay(Collider col){
		if (col.gameObject.tag == "Player" && AudioInput.smoothedVolume <= 0.6){


			CharacterController player = col.gameObject.GetComponent<CharacterController>() as CharacterController;
			player.Move((transform.forward)*0.5f);

		}
		
		//transform.parent.gameObject.GetComponent();
		//Debug.Log("Pushing " + transform.forward);//parent.gameObject.GetComponent("CharacterController").rotation);
		//Debug.Log("up "+ Vector3.up);
		/*if(col.tag == "PushableBySound"){
		Debug.Log (col.tag,col);
		//Debug.Log(AudioInput.volume);
		}*/
	}
	
}