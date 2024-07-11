using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class DifferentLevels : MonoBehaviour
{
    public Inventory_Click inventory_Click;
    public CheckAnswer checkAnswer;
    public CongratsFade congratsFade;
    public TextMeshProUGUI objText;

    public List<int> everyOutput;

    private int numberCheck;

    void Start()
    {
        inventory_Click.SetObjective(0);
        numberCheck = 0;
    }

    public void NextLevel()
    {
        numberCheck = numberCheck + 1;
        checkAnswer.isPowerCorrect = false;
        checkAnswer.topLeftCorrect = false;
        checkAnswer.topRightCorrect = false;
        if (numberCheck == 0)
        {
            inventory_Click.SetObjective(0);
            objText.text = "TURN LED ON";
            inventory_Click.ResetCircuit();

        }
        if (numberCheck == 1)
        {
            inventory_Click.SetObjective(3);
            objText.text = "TURN SPEAKER ON";
            inventory_Click.ResetCircuit();
        }
        if (numberCheck == 2)
        {
            inventory_Click.SetObjective(4);
            objText.text = "TURN MOTOR ON";
            inventory_Click.ResetCircuit();
        }
        if(numberCheck == 3)
        {
            StartCoroutine(Wait());
            congratsFade.FadeInWin();
            
            
        }

        IEnumerator Wait()
        {
            yield return new WaitForSeconds(0.5f);
        }
    }
}
