using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PhysicsPlayground
{
    public class ColliderProxy : MonoBehaviour {

        public GameObject host;

        void OnTriggerEnter(Collider col) { Debug.Log("OnTriggerEnter"); }
        void OnTriggerStay(Collider col) { Debug.Log("OnTriggerStay"); }
        void OnTriggerExit(Collider col) { Debug.Log("OnTriggerExit");}

        void OnCollisionEnter(Collision col) { Debug.Log("OnCollisionEnter"); }
        void OnCollisionStay(Collision col) { Debug.Log("OnCollisionStay");}
        void OnCollisionExit(Collision col) { Debug.Log("OnCollisionExit"); }
    }
}
