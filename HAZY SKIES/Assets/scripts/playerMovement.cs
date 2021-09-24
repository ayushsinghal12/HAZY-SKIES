using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public Rigidbody player;
    bool onGround=false;
    void FixedUpdate()
    {
        if (Input.GetKey("right") && player.velocity[0]<=500*Time.deltaTime){
            player.velocity+=new Vector3(60*Time.deltaTime,0,0);
        }
        if (Input.GetKey("left") && player.velocity[0]>=-500*Time.deltaTime){
            player.velocity+=new Vector3(-60*Time.deltaTime,0,0);
        }
        if (Input.GetKey("up") && player.velocity[2]<=500*Time.deltaTime){
            player.velocity+=new Vector3(0,0,60*Time.deltaTime);
        }
        if (Input.GetKey("down") && player.velocity[2]>=-500*Time.deltaTime){
            player.velocity+=new Vector3(0,0,-60*Time.deltaTime);
        }
        if (Input.GetKey("space") && onGround==true){
            player.velocity+=new Vector3(0,800*Time.deltaTime,0);
            onGround=false;
        }
    }
    void OnCollisionEnter(Collision type){
        if (type.collider.tag=="platform"){
            onGround=true;
        } else{
            onGround=false;
        }
        if (type.collider.tag=="lava"){
            FindObjectOfType<gameState>().end();
        }
    }
}
