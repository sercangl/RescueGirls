using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class tersasker2 : MonoBehaviour
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

        bool yenidusmanyakın = Input.GetKey(KeyCode.Space);
        m_animator.SetBool("dusmanyakında", dusmanyakın);


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
                    transform.DOMove(new Vector3(2, 0, 7), 8)
                         .SetEase(Ease.Linear)


                        )
                     .Append(
                        transform.DORotate(new Vector3(0, 0, 0), 0.5f)
                          .SetEase(Ease.Linear)


                        )
                     .Append(
                        transform.DOMove(new Vector3(2, 0, 20), 5)
                          .SetEase(Ease.Linear)
                          )

                          .Append(
                        transform.DORotate(new Vector3(0, 0, 0), 1)
                          .SetEase(Ease.Linear)

                        )
                     .SetEase(Ease.Linear)
                    .SetLoops(-1);



            }
        }

        dusmanyakın = yenidusmanyakın;




    }
}
