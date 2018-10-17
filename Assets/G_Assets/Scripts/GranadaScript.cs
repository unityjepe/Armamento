using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GranadaScript : MonoBehaviour {
    //[SerializeField] Transform genPoint;
    [SerializeField] int radioExplo=3;
    [SerializeField] int tiempoExplo = 1;
    [SerializeField] int fuerzaExplosion = 100;
    [SerializeField] int FuerzaVerticalDeExplo = 20;
    // Use this for initialization
    void Start () {
        Invoke("Explotar", tiempoExplo);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void Explotar() {
        print("Exploo");
        Collider[] cosas = Physics.OverlapSphere(transform.position, radioExplo);//array de collisionadores en la posicio y radio de la granada
        /*int i = 0;
         while (i < hitColliders.Length) {
             hitColliders[i].SendMessage("AddDamage");
             i++;
         }*/
        foreach (var cosa in cosas) {
            if (cosa.gameObject.CompareTag("Explosionables")) {
                cosa.gameObject.GetComponent<Rigidbody>().AddExplosionForce(fuerzaExplosion,
                    this.transform.position, radioExplo,
                    FuerzaVerticalDeExplo);
                print(cosa.gameObject.name);
            }
            
        }
    }


}
