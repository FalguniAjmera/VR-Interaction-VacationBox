using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioPicker : MonoBehaviour
{
	public AudioClip[] soundFiles;

	public AudioSource soundSource;
    // Start is called before the first frame update
    void Start()
    {
        int index = Random.Range(0, soundFiles.Length);
        soundSource.clip = soundFiles[index];
        soundSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
