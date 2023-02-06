using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawSign : MonoBehaviour
{
    
    float currentTime = 0f;
    float startingTime = 10f;
    public float radomnumber = 0f;
    public Transform sign;
    public GameObject draws;
    public bool signposition;
    public float timer = 0f;



    // Start is called before the first frame update
    void Start()
    {
        sign = GameObject.Find("sign").GetComponent<Transform>();
        currentTime = startingTime;
        radomnumber = Random.Range(0f, 5f);
        draws = GameObject.FindGameObjectWithTag("sign");
        signposition = false;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        
        if (currentTime < radomnumber)
        {
            signposition = true;
            sign.position = new Vector3(.25F, -.2F, 0);
        }
            
        if (signposition == true)
            {
                timer += Time.deltaTime;
            }

        if (timer > 1f&& signposition == true)
            {
                sign.position = new Vector3(-500.25F, -500.2F, 0);
            }
        
        
    }
}
