using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDraw : MonoBehaviour
{
    public SpriteRenderer playerbody;
    public Sprite[] pic;
    public Transform player;
    public bool playerdraw;
    public Transform sign;
    public GameObject draws;
    public bool signposition;    
    public float timer = 0f;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player1").GetComponent<Transform>();
        playerdraw = false;
        signposition = false;
        draws = GameObject.FindGameObjectWithTag("sign");
        sign = GameObject.Find("sign").GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {
        if (sign.position == new Vector3(.25F, -.2F, 0))
        {
            signposition = true;
        }
        if (Input.GetMouseButtonDown(0) && signposition == true)
        {
            playerbody.sprite = pic[1];
            playerdraw = true;
        }
        if (signposition == true)//Timer after sign set on
        {
            timer += Time.deltaTime;
        }
        if (timer > 1f && playerdraw == false)
        {
            playerbody.sprite = pic[2];
            player.position += new Vector3(-.005F, .015F, 0);

        }
    }
}
