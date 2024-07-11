using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CongratsFade : MonoBehaviour
{
    public List<CanvasGroup> loseUI;
    public List<CanvasGroup> winUI;

    public float fadeDuration = 1f;
    private float increaseAmount = 0.1f;
    private float waitTime = 0.1f;
     
    public void Start()
    {
        for (int i = 0; i < winUI.Count; i++) //sets every items alpha in list to 0
        {
            winUI[i].alpha = 0;
            if (i == 4)
            {
                winUI[i].blocksRaycasts = false;
            }
        }
        for (int i = 0; i < loseUI.Count; i++) { //sets every items alpha in list to 0
            loseUI[i].alpha = 0;
            if (i == 4 || i == 5)
            {
                loseUI[i].blocksRaycasts = false;
            }

        }
    }

    public void FadeInWin()
    {
        StartCoroutine(FadeCanvasGroup(winUI));   //pass down the winUI list to function 
    }

    public void FadeInLose()
    {
        StartCoroutine(FadeCanvasGroup(loseUI));   //pass down the winUI list to function 
    }

    public void GoHomeWin()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void GoGomeLose()
    {
        SceneManager.LoadScene("SampleScene");
    }

    private IEnumerator FadeCanvasGroup(List<CanvasGroup> UI)
    {
        UI[4].blocksRaycasts = true;
        UI[5].blocksRaycasts = true;
        while (true)
        {
            UI[4].alpha = UI[4].alpha + increaseAmount;
            UI[3].alpha = UI[3].alpha + increaseAmount;
            UI[2].alpha = UI[2].alpha + increaseAmount;
            UI[1].alpha = UI[1].alpha + increaseAmount;
            UI[0].alpha = UI[0].alpha + increaseAmount;
            yield return new WaitForSeconds(waitTime);

            if (UI[1].alpha == 1)
            {
                break;
            }
        }
        
    }
}
