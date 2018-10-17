using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuchilloScript : MonoBehaviour {

    void Start() {
        print("CUCHILLO SCRIPT");
    }

   private void OnTriggerEnter(Collider other) {
        print("Triger:" + other.name);
        gameObject.GetComponent<Rigidbody>().isKinematic = true;
    }
   /* private void OnCollisionEnter(Collision collision) {
        GameObject objetivoImpacto = collision.gameObject;
        if (objetivoImpacto.tag == "Explosionables") {
            gameObject.GetComponent<Rigidbody>().isKinematic = true;

        }
    }*/
}
      
     

     
