using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public struct SoundFX
{
    public string name;
    public AudioClip clip;
    public float volume;
    public float pitch;
    public float duration;
}

public class FoleyPlayer : MonoBehaviour
{
    //[SerializeField] private AudioClip clip;

    private AudioSource audioSource;

    public SoundFX[] effects;

    public SoundFX explosionFX;
    public SoundFX shootFX;

	// Use this for initialization
    void Start () 
    {
        //int numSound = 10;
        audioSource = GetComponent<AudioSource>();
        //StartCoroutine(PlayTestCoroutine());
        StartCoroutine(PlayAllCoroutine());
	}

    private IEnumerator PlayTestCoroutine()
    {
        this.Play(explosionFX);
        yield return new WaitForSeconds(5.0f);
        this.Play(shootFX);
    }

    private IEnumerator PlayAllCoroutine()
    {
        for (int i = 0; i < effects.Length; i++)
        {
            this.Play(effects[i]);
            yield return new WaitForSeconds(effects[i].duration);
        }
    }

    private void Play(SoundFX fx)
    {
        audioSource.clip = fx.clip;
        audioSource.volume = fx.volume;
        audioSource.pitch = fx.pitch;
        audioSource.Play();
    }
	
	// Update is called once per frame
	void Update () 
    {
        //Debug.Log(fx);
	}
}
