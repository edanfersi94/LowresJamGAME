using UnityEngine;
using System.Collections;

public class resolutionController : MonoBehaviour {

	// Use this for initialization
	void Start () {

		// We set the 64x64 resolution with a window windowed
		Screen.SetResolution (64, 64, true);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
