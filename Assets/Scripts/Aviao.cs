using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aviao : MonoBehaviour {
    private Rigidbody2D fisica;
    [SerializeField]
    private float forca;
    private Diretor diretor;
    private Vector3 posicaoInicial;
    

    private void Awake()
    {
        this.posicaoInicial = this.transform.position;
        this.fisica = this.GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        this.diretor = GameObject.FindObjectOfType<Diretor>();
    }

    private void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            this.Impulsionar();
        }
		
	}

    public void Reiniciar()
    {
        this.transform.position = this.posicaoInicial;
        this.fisica.simulated = true;
    }

    private void Impulsionar()
    {
        this.fisica.velocity = Vector2.zero;
        this.fisica.AddForce(Vector2.up * this.forca, ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D colisao)
    {
        this.fisica.simulated = false;
        this.diretor.FinalizarJogo();
    }
}
