using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideButton : MonoBehaviour
{
    public GameObject button;
    public GameObject player;
    public GameObject logo;
    public GameObject button2;
    public Animator logoAnim;
    public Animator buttonAnim;
    public Animator button2Anim;

    public void Hide()
    {
        button.SetActive(false);
        button2.SetActive(false);
        logo.SetActive(false);
        player.SetActive(true);
    }

    public void LogoHide()
    {
        logoAnim.SetTrigger("Hide");
        buttonAnim.SetTrigger("Pressed");
        button2Anim.SetTrigger("Pressed");
    }

    public void GoToBackupScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("BackupScene");
    }
}
