using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideButton : MonoBehaviour
{
    public GameObject button;
    public GameObject player;
    public GameObject logo;
    public Animator logoAnim;

    public void Hide()
    {
        button.SetActive(false);
        logo.SetActive(false);
        player.SetActive(true);
    }

    public void LogoHide()
    {
        logoAnim.SetTrigger("Hide");
        
    }
}
