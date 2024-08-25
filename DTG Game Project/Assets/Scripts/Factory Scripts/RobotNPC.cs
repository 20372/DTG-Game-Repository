using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class RobotNPC : MonoBehaviour
{

    [SerializeField] private GameObject SparkyUI;
    public void Awake()
    {
        DisableSparkyUI();
    }


    public void DisableSparkyUI()
    {
        SparkyUI.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            SparkyUI.SetActive(true);
        }
    }
}
