using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SlopeHealth : MonoBehaviour
{
    public Image first_cross;
    public Image second_cross;
    public Image last_cross;
    public SceneInfo1 sceneInfo1;
    //public Animator animator;
    public float waitTime;
    private int Health = 3;
    void Start()
    {
        first_cross.enabled = false;
        second_cross.enabled = false;
        last_cross.enabled = false;
        AnimateCrossIn();
    }
    void AnimateCrossIn()
    {
        if (Health == 2)
        {
            first_cross.enabled = true;
            //fade in 
        }
        if (Health == 1)
        {
            second_cross.enabled = true;
        }
        if (Health == 0)
        {
            last_cross.enabled = true;
        }
    }
    public void TakeDamage()
    {
        Health = Health - 1;
        AnimateCrossIn();
        Wait();
        if (Health == 0)
        {
            GameOver();
        }

    }
    void GameOver()
    {
        sceneInfo1.takeDamageOnReturn = true;
        SceneManager.LoadScene("Factory");
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(waitTime);
    }
}
