using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AnyObject : MonoBehaviour
{
    public void Spawn(Transform location)
    {
        if(!GameObject.Find(gameObject.name+"(Clone)"))
            Instantiate(gameObject, location);
    }
    public abstract void Remove();
}