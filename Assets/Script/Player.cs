using UnityEngine;

public class Player : MonoBehaviour
{
    // Variaveis
    public float velocidade;
    private Rigidbody2D rig;
    private Vector2 direcao;
    // Classe de inicializacao
    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    //Atualizacao da direcao
    private void Update ()
    {
        direcao = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    }


    // Atualizacao da velocidade
    private void FixedUpdate()
    {
        rig.MovePosition(rig.position + direcao * velocidade * Time.fixedDeltaTime);
    }
}
