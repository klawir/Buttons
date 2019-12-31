using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UI
{
    public class Object : MonoBehaviour
    {
        public GameObject obj;
        public float time;

        public void Render(Transform location)
        {
            Instantiate(obj, location);
        }
        public void Close()
        {
            Destroy(gameObject, time);
        }
    }
}