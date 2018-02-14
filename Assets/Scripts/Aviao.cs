using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aviao : MonoBehaviour {
    Rigidbody2D fisica;

    private void Awake()
    {
        this.fisica = this.GetComponent<Rigidbody2D>();

    }

    private void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            this.Impulsionar();
        }
		
	}

    private void Impulsionar()
    {
        this.fisica.AddForce(Vector2.up * 10, ForceMode2D.Impulse);
    }
}
