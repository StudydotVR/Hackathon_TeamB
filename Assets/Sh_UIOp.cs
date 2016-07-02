using UnityEngine;
using System.Collections;

public class Sh_UIOp : MonoBehaviour {
    public Animator anime;
    int i = 3;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        //if(Input.GetMouseButtonDown(1) && (!anime.GetBool("BulletChange"))&& (!anime.GetBool("BulletChange1")) && (!anime.GetBool("BulletChange2")))
        if (Input.GetMouseButtonDown(1))
        {
            anime.SetBool("BulletChange1", false);
            anime.SetBool("BulletChange2", false);
            anime.SetBool("BulletChange", false);

            i++;

            if(i >= 3)
            {
                i = 0;
            }

            if (i % 3 == 0)
            {
                anime.SetBool("BulletChange1", false);
                anime.SetBool("BulletChange2", false);
                anime.SetBool("BulletChange", true);
               /* if (anime.GetBool("BulletChange"))
                {
                    anime.SetBool("BulletChange", false);
                }*/
            }
            if (i % 3 == 1)
            {
                anime.SetBool("BulletChange", false);
                anime.SetBool("BulletChange2", false);
                anime.SetBool("BulletChange1", true);
                /*if(anime.GetBool("BulletChange1"))
                {
                    anime.SetBool("BulletChange1", false);
                }*/
             

            }

            if (i % 3 == 2)
            {
                anime.SetBool("BulletChange", false);
                anime.SetBool("BulletChange1", false);
                anime.SetBool("BulletChange2", true);
                
            }
        
        }
        /*anime.SetBool("BulletChange1", false);
        anime.SetBool("BulletChange2", false);
        anime.SetBool("BulletChange", false);*/
    }
}
