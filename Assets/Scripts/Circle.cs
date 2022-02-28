using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
{
    public ParticleSystem explosion;

    private void OnMouseDown()
    {
        Destroy(this.gameObject);
        Instantiate(explosion, transform.position, explosion.transform.rotation);
        GameManager.INSTANCIA.Destroyed();
    }

}
