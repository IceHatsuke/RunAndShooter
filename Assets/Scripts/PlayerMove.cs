using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    float velocidade = 6f;

    // Update is called once per frame
    void Update()
    {

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        horizontal *= -1;
        vertical *= -1;

        Vector3 movimento = new Vector3(horizontal, 0, vertical);
        movimento = movimento * velocidade * Time.deltaTime;

       transform.Translate(movimento);
    }
}
