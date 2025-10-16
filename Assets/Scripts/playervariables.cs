using UnityEngine;

public class playervariables : MonoBehaviour
{

    public int maxHealth = 100;
    public int playerHealth = 80;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("current health: " + playerHealth);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
