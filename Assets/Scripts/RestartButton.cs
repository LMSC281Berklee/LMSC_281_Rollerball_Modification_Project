//LMSC-281
//Prin Keerasuntonpong

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class RestartButton : MonoBehaviour
{
    //Get button and stores it int yourButton
    public Button yourButton;

    void Start()
    {
        //Get Button component and stores it in btn
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        //Reload scene
        SceneManager.LoadScene("RollerBall");
    }
}