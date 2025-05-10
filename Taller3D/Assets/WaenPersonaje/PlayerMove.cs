using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speedMove = 5.0f;
    public float speedRotaion = 200.0f;
    public float x, y;
    public float sprintMultiplier = 2.0f;

    [SerializeField] private Animator animator;
    

    public float velocidadCorriendo = 8f;
    public float velicidadTransicion;
    float actualSpeedMove;


    // Start is called before the first frame update
    

    void Start()
    {
        animator = GetComponent<Animator>();
        actualSpeedMove = speedMove;

    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");



        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            actualSpeedMove = Mathf.Lerp(actualSpeedMove, velocidadCorriendo, velicidadTransicion*Time.deltaTime);

        }
        else
        {
            actualSpeedMove = Mathf.Lerp(actualSpeedMove,speedMove, velicidadTransicion*Time.deltaTime);

        }
        transform.Translate(0, 0, y * actualSpeedMove * Time.deltaTime);
       
        transform.Rotate(0, x * Time.deltaTime * speedRotaion, 0);
        

        animator.SetFloat("MoveSpeed", actualSpeedMove * Mathf.Max(Mathf.Abs(y), Mathf.Abs(x)));

     
    }
}
