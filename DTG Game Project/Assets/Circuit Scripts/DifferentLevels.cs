using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class DifferentLevels : MonoBehaviour
{
    public Inventory_Click inventory_Click;
    public CheckAnswer checkAnswer;
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
        if (numberCheck == 0)
        {
            inventory_Click.SetObjective(0);
            objText.text = "Turn LED ON";
            inventory_Click.ResetCircuit();

        }
        if (numberCheck == 1)
        {
            inventory_Click.SetObjective(3);
            objText.text = "Turn SPEAKER ON";
            inventory_Click.ResetCircuit();
        }
        if (numberCheck == 2)
        {
            inventory_Click.SetObjective(4);
            objText.text = "Turn MOTOR ON";
            inventory_Click.ResetCircuit();
        }
        if(numberCheck == 3)
        {
            Debug.Log("YOU COMPLETED THIS MINUGAMESD");
        }
    }
}
