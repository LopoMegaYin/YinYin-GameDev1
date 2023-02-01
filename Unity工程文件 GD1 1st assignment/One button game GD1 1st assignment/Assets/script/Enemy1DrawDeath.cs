using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Enemy1DrawDeath : MonoBehaviour
{
    public Transform enemy1;
    public Transform sign;
    public Transform player;
    public GameObject draws;
    public bool signposition;
    public float timer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        enemy1 = gameObject.GetComponent<Transform>();
        sign= GameObject.Find("sign").GetComponent<Transform>();
        player = GameObject.Find("Player1").GetComponent<Transform>();
        enemy1.position = new Vector3(5, -1.35F,0);
        player.position = new Vector3(-4.73f, -1.37f, 0);
        draws = GameObject.FindGameObjectWithTag("sign");
        signposition = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (sign.position == new Vector3(.25F, -.2F, 0))
        {
            signposition = true;
        }

        if (signposition== true) 
        {
            timer += Time.deltaTime;
        }

        if(timer > 1f)
        {
            enemy1.position = new Vector3(-2.84F, -1.35F, 0);
        }

        if(timer< 1f && Input.GetMouseButtonDown(0)&& signposition == true)
        {
            player.position = new Vector3(3.28f, -1.37f, 0);
            Destroy(GameObject.FindGameObjectWithTag("sign"));
        }
    }
}

