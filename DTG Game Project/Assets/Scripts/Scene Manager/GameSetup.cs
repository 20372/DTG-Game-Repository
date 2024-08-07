using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSetup : MonoBehaviour
{
    [SerializeField]
    public SceneInfo1 sceneInfo1;
    public HealthManager healthManager;
    public GameObject player;
    public Transform playertrans;
    private bool damageOnReturn;
    public PlayerObjectSelect playerObjectSelect;
    private void Awake()
    {
        LoadPlayerInfo();
        StartCoroutine(HandleGameSetup(0.1f));
    }

    public void LoadPlayerInfo()
    {
        healthManager.healthAmount = sceneInfo1.current_playerHealth;
        player.transform.position = sceneInfo1.current_PlayerPos;
        player.transform.rotation = sceneInfo1.current_PlayerRot;
        damageOnReturn = sceneInfo1.takeDamageOnReturn;
        if (damageOnReturn == false)
        {
            healthManager.healthBar.fillAmount = healthManager.healthAmount / 100f;
        }
    }

    public void SavePlayerInfo()
    {
        sceneInfo1.current_playerHealth = healthManager.healthAmount;
        sceneInfo1.current_PlayerPos = playertrans.transform.position;
        sceneInfo1.current_PlayerRot = playertrans.transform.rotation;
    }

    public void ApplyDamageOnReturn()
    {
        if (damageOnReturn == true)
        {
            healthManager.DealDamage(20f);
            sceneInfo1.current_playerHealth = healthManager.healthAmount;
            sceneInfo1.takeDamageOnReturn = false;
        }
    }
    IEnumerator HandleGameSetup(float waitTime)
    {
        yield return new WaitForSecondsRealtime(waitTime);
        ApplyDamageOnReturn();
        UpdateObjectiveUI();
    }

    public void UpdateObjectiveUI()
    {
        if (sceneInfo1.circuitComplete == true)
        {
            //update ui
        }
        if (sceneInfo1.slopeComplete == true)
        {
            //update ui
        }
        if (sceneInfo1.quizComplete == true)
        {
            //update UI
        }
        if (sceneInfo1.footballComplete == true)
        {
            //update UI
        }
        if (sceneInfo1.arenaComplete == true)
        {
            //update UI
        }
    }
   
}
