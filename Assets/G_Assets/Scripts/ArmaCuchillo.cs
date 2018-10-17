using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmaCuchillo : MonoBehaviour {

    [SerializeField] Transform genPoint;
    [SerializeField] GameObject prefabProyectil;
    [SerializeField] int Fuerza = 50;
    
    private void OnMouseDown() {
        GameObject proyectil = Instantiate(prefabProyectil,
            genPoint.transform.position, genPoint.transform
            .rotation);
        proyectil.GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * Fuerza);

    }
}
