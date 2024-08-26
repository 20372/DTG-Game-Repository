using UnityEngine;


[CreateAssetMenu(fileName = "SceneInfo1", menuName = "Persistence")]
public class SceneInfo1 : ScriptableObject
{
    public float current_playerHealth;
    public Vector3 current_PlayerPos;
    public Quaternion current_PlayerRot; //Vairalbes that I want to save across scenes 
    public bool takeDamageOnReturn;
    public bool slopeComplete;
    public bool circuitComplete;

    private void OnEnable() //OnEnable gets called when the game is first played. This just reset the variables to default state 
    {
        current_PlayerPos = new Vector3(-10.9338417f, 12.4443045f, 31.1084385f);
        current_PlayerRot = new Quaternion(0, 0, 0, 0);
        current_playerHealth = 100f;
        takeDamageOnReturn = false;
        slopeComplete = false;
        circuitComplete = false;
    }
}
