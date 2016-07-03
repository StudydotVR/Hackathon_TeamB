using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Sh_UIOp : MonoBehaviour {
    public AudioClip SERelord;
    AudioSource SERelordSource;
    public Animator anime;

    int i = 3;

    public Text counttext;
    public static int count;
    //public static Sh_UIOp Instance = new Sh_UIOp();


    public Text timetext;
    public float timer = 10;
    

    // Use this for initialization
    void Start () {

        SERelordSource = gameObject.GetComponent<AudioSource>();
        SERelordSource.clip = SERelord;
        SetCountText();

    }
	
	// Update is called once per frame
	void Update () {
        //if(Input.GetMouseButtonDown(1) && (!anime.GetBool("BulletChange"))&& (!anime.GetBool("BulletChange1")) && (!anime.GetBool("BulletChange2")))
        //timetext = gameObject.GetComponent<Text>();
        if (Input.GetMouseButtonDown(1))
        {
            anime.SetBool("BulletChange1", false);
            anime.SetBool("BulletChange2", false);
            anime.SetBool("BulletChange", false);
            SERelordSource.PlayOneShot(SERelord);

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

        timer -= Time.deltaTime;
        timetext.text = "TIME:" + string.Format("{0:f2}\r", timer); //少数以下２桁まで表示

        if (Input.GetKeyDown(KeyCode.E))
        {
            count = count + 100;
            SetCountText();
        }
        if(timer < 0)
        {
            
            SceneLoad2();
            
        }
    }
    void SetCountText()
    {
        counttext.text = "SCORE : " + count.ToString();
    }
   
    public void SceneLoad2()
    {
        FadeManager.Instance.LoadLevel("Sh_End", 1);
    }
}
