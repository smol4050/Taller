using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float velocidadMovimiento = 5.0f;
    public float velocidadRotacion = 200.0f;
    private Animator anim;
    public float x, y;


    public Rigidbody rb;
    public float fuerzaDeSalto = 8.0f;
    public bool puedoSaltar;

    // Start is called before the first frame update
    void Start()
    {

        anim = GetComponent<Animator>();
        puedoSaltar = false;
    }

    void FixedUpdate()
    {
        transform.Translate(0, 0, y * velocidadMovimiento * Time.deltaTime);
        transform.Rotate(0, x * Time.deltaTime * velocidadRotacion, 0);

    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");


        anim.SetFloat("VelX", x);
        anim.SetFloat("VelY", y);


        if (puedoSaltar)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                anim.SetBool("salte", true);
                rb.AddForce(new Vector3(0, fuerzaDeSalto, 0), ForceMode.Impulse);
            }
            anim.SetBool("tocoSuelo", true);

        }
        else
        {
            EstoyCayendo();

        }
    }

    public void EstoyCayendo()
    {
        anim.SetBool("tocoSuelo", false);
        anim.SetBool("salte", false);

    }
}
