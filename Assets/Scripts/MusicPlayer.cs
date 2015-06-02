using UnityEngine;
using System.Collections;
//MusicPlayer (class) .Instance
public class MusicPlayer : MonoBehaviour {
	//static vars because only one should ever exist
	//you automatically make it to null
	static MusicPlayer instance = null;
	void Awake ()
	{
		Debug.Log ("music player Awake "+GetInstanceID());
		if (instance != null)
		{
			Destroy (gameObject);
			print ("dup music player is distroyed");
		} else 
		{
			instance = this;
			//GameObject is a static variable
			//gameObject is an instance of the music player
			GameObject.DontDestroyOnLoad(gameObject);
		}

	}
	// Use this for initialization
	void Start () {
		Debug.Log ("music player Start "+GetInstanceID());
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
