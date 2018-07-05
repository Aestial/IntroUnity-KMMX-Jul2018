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

    public List<SoundFX> effectsList;

    private string[] names = { "Hugo", "Paco", "Luis" };

    private float[] powerCosts;
    private bool[] flags;

    public SoundFX explosionFX;
    public SoundFX shootFX;

	// Use this for initialization
    void Start () 
    {
        powerCosts = new float[30];
        flags = new bool[25];

        InitializeArray(14.67f, powerCosts);
        InitializeArray(true, flags);
        //int numSound = 10;
        audioSource = GetComponent<AudioSource>();
        //StartCoroutine(PlayTestCoroutine());
        //StartCoroutine(PlayAllCoroutine());
        this.PrintArray(flags);
        this.PrintArray(powerCosts);
	}

    private void InitializeArray(bool value, bool[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = value;
        }
    }

    private void InitializeArray(float value, float[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = value * i;
        }
    }

    private void PrintArray(bool[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }
    }

    private void PrintArray(float[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }
    }

    private void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }
    }

    private void PrintArray(string[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }
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
