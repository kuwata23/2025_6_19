using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoote : MonoBehaviour
{
    public GameObject candy;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            CandyPop();
        }
    }
    public void CandyPop() 
    {
        Instantiate(candy,transform);
    }
}
