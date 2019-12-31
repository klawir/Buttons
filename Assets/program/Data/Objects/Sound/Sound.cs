using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : AnyObject
{
    public AudioSource audio;

    private void Start()
    {
        Remove();
    }
    public override void Remove()
    {
        Destroy(gameObject, audio.clip.length);
    }
}