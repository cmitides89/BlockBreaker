using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {
	//now you can use this function outside of this class cause its public
	public void LoadLevel(string name){
		//Debug.Log ("Level load requested for: " +name);
		Application.LoadLevel(name);
	}

	public void QuitLevel (){
		Debug.Log ("I want to quit");
		Application.Quit();
	}

}
