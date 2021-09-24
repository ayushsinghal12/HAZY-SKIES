using UnityEngine;

public class endTrigger : MonoBehaviour
{
    public GameObject levelCompleteMsg;
    void OnTriggerEnter(){
        levelCompleteMsg.SetActive(true);
    }
}
