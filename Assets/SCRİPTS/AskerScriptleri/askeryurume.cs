using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class askeryurume : MonoBehaviour
{
    public Transform Player;
    Animator m_animator;
    float distance = 10f;
    bool dusmanyakın = true;
    // bool yenidusmanyakın = false;
    float MoveSpeed = 2f;
    // Start is called before the first frame update
    void Start()
    {
        m_animator = GetComponent<Animator>();    
    }

    // Update is called once per fra1me
    void Update()
    {
        
        bool yenidusmanyakın= Input.GetKey(KeyCode.Space);
        m_animator.SetBool("dusmanyakında",dusmanyakın);


        if (Vector3.Distance(transform.position, Player.position) <= distance)
        {

            yenidusmanyakın = true;



        }



        if (dusmanyakın != yenidusmanyakın)
        {
            if (yenidusmanyakın == true)
            {
                transform.LookAt(Player);

            }

            else if (yenidusmanyakın == false)
            {


                Debug.Log("Dotween başlıyor");
                DOTween.Sequence()
                  .Append(
                    transform.DOMove(new Vector3(-6, 0, 17), 5)
                         .SetEase(Ease.Linear)


                        )
                     .Append(
                        transform.DORotate(new Vector3(0, 180, 0), 0.5f)
                          .SetEase(Ease.Linear)


                        )
                     .Append(
                        transform.DOMove(new Vector3(-6, 0, 3), 5)
                          .SetEase(Ease.Linear)
                          )

                          .Append(
                        transform.DORotate(new Vector3(0, 180, 0), 1)
                          .SetEase(Ease.Linear)

                        )
                     .SetEase(Ease.Linear)
                    .SetLoops(-1);



            }
        }

        dusmanyakın = yenidusmanyakın;

       

        
    }
}
