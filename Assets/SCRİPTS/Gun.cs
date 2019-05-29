
using UnityEngine;
using UnityEngine.UI;
public class Gun : MonoBehaviour
{



    public float damage = 10f;
    public float range = 100f;
    public int Mermi = 120;
    public bool firing;
    public float stopFiring;
    public float coolDown;
    // public AudioSource AudioSource1;
    public ParticleSystem Flash;



    public Camera fpsCam;

    public Text Ammo;
    Scoreencontroller sc = new Scoreencontroller();
    // Update is called once per frame
    void Update()
    {



        if (Input.GetButtonDown("Fire1"))

        {
            // Shoot();

            //     AudioSource1.Play();
            //     AudioSource1.Stop();
            
            
            if (Mermi <= 0)
            {
                Mermi = 0;
                firing = false;
            }

            if (Mermi > 0)
            {
                Flash.Play();
                Mermi--;
              //  sc.decreaseAmmo();
                Shoot();
                firing = true;
                stopFiring = Time.time + coolDown;
            }
            Ammo.text = Mermi.ToString();
        }

        if (Time.time > stopFiring)
        {
            firing = false;

        }

    }


    void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

            Target target = hit.transform.GetComponent<Target>();

          
            if (target != null)
            {
                target.TakeDamage(damage);
            }

        }

    }
}
