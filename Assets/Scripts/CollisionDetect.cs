using UnityEngine;

public class CollisionDetect : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject playerAnim;
    void OnTriggerEnter(Collider other)
    {
        player.GetComponent<PlayerMove>().enabled = false;
        playerAnim.GetComponent<Animator>().Play("Stumble Backwards");
    }
}
