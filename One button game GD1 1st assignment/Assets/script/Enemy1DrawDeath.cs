using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;
using UnityEngine.UIElements;

public class Enemy1DrawDeath : MonoBehaviour
{
    public Transform enemy1;
    public Transform sign;
    public Transform player;
    public GameObject playerbody;
    public GameObject draws;
    public bool signposition;
    public float timer = 0f;
    public bool playerdraw;
    public SpriteRenderer enemy1body;
    public Sprite[] pic;
    public GameObject lose;
    public bool enemy1draw;
    public GameObject win;
    public bool cheater;
    public GameObject cheat;


    // Start is called before the first frame update
    void Start()
    {
        enemy1 = gameObject.GetComponent<Transform>();
        sign = GameObject.Find("sign").GetComponent<Transform>();
        player = GameObject.Find("Player1").GetComponent<Transform>();
        playerbody = GameObject.FindGameObjectWithTag("Player");
        draws = GameObject.FindGameObjectWithTag("sign");
        signposition = false;
        playerdraw = false;
        enemy1draw=false;
        cheater= false;
        enemy1body = gameObject.GetComponent<SpriteRenderer>();
        lose = GameObject.FindGameObjectWithTag("Gameover");
        win = GameObject.FindGameObjectWithTag("Win");
        cheat = GameObject.FindGameObjectWithTag("Cheater");
        GameObject.FindGameObjectWithTag("Gameover").SetActive(false);
        GameObject.FindGameObjectWithTag("Win").SetActive(false);
        GameObject.FindGameObjectWithTag("Cheater").SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (sign.position == new Vector3(.25F, -.2F, 0))
        {
            signposition = true;
        }
        if(timer==0f&& Input.GetMouseButtonDown(0))
        {
            cheater= true;
            playerbody.SetActive(false);
            draws.SetActive(false);
            cheat.SetActive(true);
        }
        
        if (signposition == true&& cheater==false)//Timer after sign set on
        {
            timer += Time.deltaTime;
        }

        if (timer > 1f && playerdraw == false)
        {
            enemy1.position = new Vector3(-2.5F, -2.75F, 0);
            enemy1draw=true;
        }

        if (timer < 1f && Input.GetMouseButtonDown(0) && signposition == true)
        {
            player.position = new Vector3(2.39f, -2.68f, 0);
           lose.SetActive(false);
            playerdraw = true;
            enemy1body.sprite = pic[0];
            win.SetActive(true);
            draws.SetActive(false);
        }
        if (playerdraw == true)
        {
            enemy1.position+= new Vector3(.01F, .015F, 0);
        }
        if (enemy1draw == true)
        {
           lose.SetActive(true);
        }
    }
    
}

