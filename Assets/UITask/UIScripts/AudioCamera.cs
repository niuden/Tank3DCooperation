using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class AudioCamera : MonoBehaviour
{
    public Transform tr;
    public GameObject gameObject;
    // public AudioSource asd = GetComponent<AudioSource>();
    // Start is called before the first frame update
    void Start()
    {
        // gameObject.AudioSource.Play();
        AudioSource asd = gameObject.GetComponent<AudioSource>();
        asd.Play();
    }

    // Update is called once per frame
    void Update()
    {
        Scene scene = SceneManager.GetActiveScene();
        // Debug.Log("Active Scene is '" + scene.name + "'.");
        if (scene.name!="LoginScene")
        {
            AudioSource asd = gameObject.GetComponent<AudioSource>();
            asd.Stop();
        }
    }
}
