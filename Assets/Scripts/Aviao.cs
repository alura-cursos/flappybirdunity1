using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aviao : MonoBehaviour {
    private Rigidbody2D fisica;
    [SerializeField]
    private float forca = 6;

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
        this.fisica.AddForce(Vector2.up * this.forca, ForceMode2D.Impulse);
    }
}
