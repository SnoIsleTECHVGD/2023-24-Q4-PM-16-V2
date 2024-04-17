using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackScript : MonoBehaviour
{
    public void Home()
    {
        SceneManager.LoadScene("Main Screen");
    }
    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }
}
