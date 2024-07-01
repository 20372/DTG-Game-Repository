using UnityEngine;


[CreateAssetMenu(fileName = "SceneInfo1", menuName = "Persistence")]
public class SceneInfo1 : ScriptableObject
{
    public Vector3 current_playerPos;
    public float current_playerHealth;
    public float curret_playerSpeed;
    public Vector3 current_PlayerCameraPos;
    private void OnEnable()
    {
        current_playerPos = new Vector3(0, 0, 0);
        current_playerHealth = 100f;
        curret_playerSpeed = 10f;
        current_PlayerCameraPos = new Vector3(0, 0, 0);
    }
}
