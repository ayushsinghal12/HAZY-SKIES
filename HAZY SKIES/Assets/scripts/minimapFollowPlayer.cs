using UnityEngine;

public class minimapFollowPlayer : MonoBehaviour
{
    public Transform player;
    void LateUpdate()
    {
        // transform.position=player.position+new Vector3(0,4,0);
        Vector3 newPosition=player.position;
        newPosition.y=transform.position.y;
        transform.position=newPosition;
    }
}
