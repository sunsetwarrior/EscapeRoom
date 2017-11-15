using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightObject : MonoBehaviour
{

    public GameObject rightObject;
    private static int num = 0;
    public AudioClip boxOpen;
    public AudioClip doorOpen;
    public GameObject boxRoof;
    public GameObject Door;
    public GameObject gameOverText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == rightObject || other.gameObject.name == "ring")
        {
            Destroy(other.gameObject);
            transform.GetChild(0).gameObject.SetActive(true);
            num++;
            Debug.Log(num);

            if (num == 3)
            {
                boxRoof.GetComponent<Animator>().SetBool("open", true);
                AudioSource.PlayClipAtPoint(boxOpen, GameObject.Find("BoxRoof").transform.position);
            }
            //the animation of box roof will add num by 1
            if (num == 6)
            {
                //door open
                gameOverText.SetActive(true);
                Door.GetComponent<Animator>().SetBool("open", true);
                AudioSource.PlayClipAtPoint(doorOpen, GameObject.Find("FinalDoor").transform.position);
            }
        }


    }
}
