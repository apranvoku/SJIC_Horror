using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.SceneManager;
using UnityEngine.SceneManagement;
public class teleportLogic : MonoBehaviour {
	//public Scene scene2;
    public int x = 0;
    void OnCollisionEnter (Collision col)
    {       
        if(col.gameObject.tag == "Player")
        {
            //Scene sceneToLoad = scene2;SceneManager.GetSceneByName("lev2m");
            //Assets/Scenes/lev2m.unity
            //Scene sceneToLoad = SceneManager.GetSceneByName("lev2m");
            //print(sceneToLoad);
			//Scene sceneToUnLoad = SceneManager.GetSceneByName("Mario");
            //print(sceneToUnLoad);
            //SceneManager.LoadScene(sceneToLoad.name, LoadSceneMode.Additive);
            if(x == 0){
                
                SceneManager.LoadScene("lev2m", LoadSceneMode.Additive);
                
                x++;
            }
            //SceneManager.MoveGameObjectToScene(FPSControllerr.gameObject, sceneToLoad);
			SceneManager.UnloadSceneAsync("Mario");
        }
        else if (col.gameObject.tag == "Terrain")
        {
            print("Get a life");
        }
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
