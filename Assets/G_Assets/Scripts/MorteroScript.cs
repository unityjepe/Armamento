using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MorteroScript : MonoBehaviour {
    [SerializeField] Transform genPoint;
    [SerializeField] GameObject prefabProyectil;
    [SerializeField] int Fuerza= 200;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnMouseDown() {
        GameObject proyectil = Instantiate(prefabProyectil,
            genPoint.transform.position, genPoint.transform
            .rotation);
        proyectil.GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * Fuerza);
       
    }
}
