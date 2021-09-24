using UnityEngine;

public class followPlayer : MonoBehaviour
{
    public Transform player;
    
    void Update()
    {
        transform.position=player.position;
    }
}
