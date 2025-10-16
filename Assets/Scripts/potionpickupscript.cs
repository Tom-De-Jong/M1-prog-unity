using UnityEngine;

public class potionpickupscript : MonoBehaviour
{
    public int healAmount = 25;

    void OnTriggerEnter(Collider other)
    {

        playervariables player = other.GetComponent<playervariables>();
        if (player.playerHealth <= 75)
        {
            player.playerHealth += 25;
            Destroy(gameObject);
            Debug.Log("player healed. Current health: " + player.playerHealth);
        }
        else
        {
            Debug.Log("player is above 75 HP");
        }
        
    }
}
