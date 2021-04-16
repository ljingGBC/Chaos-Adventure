using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;


public class Sign : MonoBehaviour
{
    public GameObject dialogBox;
    public Text dialogText;
    public string dialog;
    public bool dialogActive;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (dialogActive)
        {
            /*
            if (dialogBox.activeInHierarchy)
            {
                dialogBox.SetActive(false);
            }
            else
            {
                dialogBox.SetActive(true);
                dialogText.text = dialog;
            }*/
            //dialogBox.SetActive(true);
            dialogText.text = dialog;
            dialogBox.GetComponent<Image>().enabled = true;
        }
        else
        {
            //dialogBox.SetActive(false);
            dialogText.text = "";//hide text
            dialogBox.GetComponent<Image>().enabled = false;//hide dialog box picture
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player is in range");
            dialogActive = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player left range");
            dialogActive = false;
            dialogBox.SetActive(false);
        }
    }

}
