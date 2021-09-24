using UnityEngine;
using UnityEngine.SceneManagement;

public class gameState : MonoBehaviour
{
    bool ended=true;
    public void end(){
        if (ended==true){
            ended=false;
            Invoke("restart",0.4f);
        }
        }
    public void restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
