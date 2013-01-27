using UnityEngine;
using System.Collections;

public class MaterialSwitcher : MonoBehaviour 
{
	public Material successMaterial;
	
	void Activate()
	{
		renderer.material = successMaterial;
	}
}
