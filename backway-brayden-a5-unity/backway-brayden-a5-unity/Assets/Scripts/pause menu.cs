using UnityEngine;
using UnityEngine.Android;

public class NewMonoBehaviourScript : MonoBehaviour
{    public GameObject pausemenu;
    public bool ispaused;
    
   
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
            ispaused = !ispaused;
        {

        }
        if (ispaused)

        {
            ActivateMenu();
            Time.timeScale = 0f;


        }
        else
        {
            DeactivateMenu();
            Time.timeScale = 1f;
        }



    }
    void ActivateMenu()
    {
        pausemenu.SetActive(true);


    }
    void DeactivateMenu()
    {
        pausemenu.SetActive(false);
    }
}
}
