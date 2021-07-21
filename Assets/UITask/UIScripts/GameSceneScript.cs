using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSceneScript : MonoBehaviour
{
	public void Pause()
	{	
		SceneManager.LoadScene((SceneManager.GetActiveScene().buildIndex) + 1);
	
	}
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
