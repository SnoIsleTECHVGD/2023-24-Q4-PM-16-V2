using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsScript : MonoBehaviour
{
    public void Clara()
    {
        SceneManager.LoadScene("ClaraCredits");
    }
    public void Sabastian()
    {
      SceneManager.LoadScene("SabastianCredits");
    }
    public void PJ()
    {
        SceneManager.LoadScene("PJCredits");
    }
    public void Alexei()
    {
        SceneManager.LoadScene("AlexeiCredits");
    }
    public void Madison()
    {
        SceneManager.LoadScene("MadisonCredits");
    }
}
