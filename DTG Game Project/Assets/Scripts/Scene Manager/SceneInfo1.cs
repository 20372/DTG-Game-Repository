using UnityEngine;


[CreateAssetMenu(fileName = "SceneInfo1", menuName = "Persistence")]
public class SceneInfo1 : ScriptableObject
{
    public float current_playerHealth;
    public Vector3 current_PlayerPos;
    public Quaternion current_PlayerRot;
    public bool takeDamageOnReturn;
    public bool slopeComplete;
    public bool circuitComplete;
    public bool quizComplete;
    public bool footballComplete;
    public bool arenaComplete;
    private void OnEnable()
    {
        current_PlayerPos = new Vector3(-7.51917458f, 19.7783298f, 6.70836639f);
        current_PlayerRot = new Quaternion(0, 0, 0, 0);
        current_playerHealth = 100f;
        takeDamageOnReturn = false;
        slopeComplete = false;
        circuitComplete = false;
        quizComplete = false;
        footballComplete = false;
        arenaComplete = false;
    }
}
