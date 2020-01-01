using UnityEngine;

namespace UI
{
    public class Object : AnyObject
    {
        public float time;
        
        public override void Remove()
        {
            Destroy(gameObject, time);
        }
    }
}