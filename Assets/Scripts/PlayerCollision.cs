using UnityEngine;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour {

	public PlayerMovement movement;   

	void OnCollisionEnter (Collision collisionInfo)
	{
		
		if (collisionInfo.collider.tag == "Obstacle")
		{
			movement.enabled = false;   
			FindObjectOfType<GameManager>().EndGame();
		}
	}
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            Data.banuti++;
        }

    }
}
