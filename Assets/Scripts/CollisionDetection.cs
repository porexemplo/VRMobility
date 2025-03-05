using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CollisionDetection : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;

    public ScoreManager scoreManager;

    public TextMeshProUGUI text;
    // This method is called when another collider enters this object's collider (must have IsTrigger enabled)
    private void Start()
    {
    }
    private void OnTriggerEnter(Collider other)
    {
        if (!other.gameObject.CompareTag("Box"))
           { return; }

        scoreManager.IncreaseScore();
        Debug.Log("Object collided with: " + other.gameObject.name);
        Debug.Log(score);

        Destroy(gameObject);
        // Perform any additional actions here, e.g., modifying game state, destroying objects, etc.
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Object exited the trigger: " + other.name);

        // Perform any additional actions here
    }

}
