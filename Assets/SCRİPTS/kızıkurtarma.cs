using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class kızıkurtarma : MonoBehaviour
{

    public Transform Player;
    public Transform Cube;
    int MoveSpeed = 2;
    int MaxDist = 10;
    int MaxxDist = 100;
    int MinDist = 2;


    Animator k_animator;
    // Start is called before the first frame update
    void Start()
    {
        k_animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //E ye basınca yürüme moduna girip bizi takip etmesi
        bool rescueMode = false;
        rescueMode= Input.GetKey(KeyCode.E);

        if (Vector3.Distance(transform.position, Player.position) >= MinDist && Vector3.Distance(transform.position, Player.position) <= MaxDist)
        {

            rescueMode = true;

            if (Vector3.Distance(transform.position, Cube.position) <= MinDist)
            {

                SceneManager.LoadScene(2);
                Debug.Log("GEldi");
            }


        }


        k_animator.SetBool("rescue",rescueMode);
         
        // Bizimle olan uzaklığına göre peşimizden gelmesi

        if (rescueMode == true) {
            transform.LookAt(Player);

            if (Vector3.Distance(transform.position, Player.position) >= MinDist)
            {

                transform.position += transform.forward * MoveSpeed * Time.deltaTime;
                
            }

         

        }

        /*
        void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Cube"))
            {
                SceneManager.LoadScene(2);
            }
        }
     */
        }




}

