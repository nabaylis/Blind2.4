using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Choice : MonoBehaviour
{
    public GameObject lampLight;
    public Text CubeText;
    public Text CubeText2;
    public Text CubeText3;
    bool EnterArea;
    // Start is called before the first frame update
    void Start()
    {
        lampLight.SetActive(false);
        CubeText.enabled = false;
        CubeText2.enabled = false;
        CubeText3.enabled = false;
        EnterArea = false;
    }


    void OnTriggerStay(Collider Player)
    {
        if (Player.gameObject.CompareTag("Player"))
        {
            EnterArea = true;
            CubeText.enabled = true;
        }
    }
    void OnTriggerExit(Collider Player)
    {
        if (Player.gameObject.CompareTag("Player"))
        {
            CubeText.enabled = false;
            EnterArea = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && (EnterArea))
        {
            if (lampLight.activeSelf)
            {
                lampLight.SetActive(false);
            }
            else lampLight.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.Q) && (EnterArea))
        {
            CubeText2.enabled = true;
        }
        if (Input.GetKeyDown(KeyCode.F) && (EnterArea) && (CubeText2.enabled))
        {
            CubeText2.enabled = false;
            CubeText3.enabled = true;
        }
        if (Input.GetKeyDown(KeyCode.Q) && (EnterArea) && (CubeText3.enabled))
        {
            CubeText3.enabled = false;
        }
    }
}