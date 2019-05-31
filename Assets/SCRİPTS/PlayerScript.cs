using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{
    public int hp = 5;
    public Text ourHealth;
    // Start is called before the first frame update
    void Start()
    {
        ourHealth.text = hp.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        //  References.hp = hp;
        ourHealth.text = hp.ToString();
        if (hp <= 0)
        {
            Application.LoadLevel(0);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Dusman")
        {
            Debug.Log("dusman");
            GetComponent<PlayerScript>().hp--;

        }
    }


    }
