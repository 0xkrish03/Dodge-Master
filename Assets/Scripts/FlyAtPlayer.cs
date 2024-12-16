using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] float projectSpeed;
    Vector3 playerPosition;
    void Awake()
    {
        gameObject.SetActive(false);

    }
    void Start()
    {
        playerPosition = player.transform.position;
    }
    void Update()
    {
        TargetToPlayer();
        DestroyWhenReached();
    }
    void DestroyWhenReached()
    {
        if (transform.position == playerPosition)
        {
            Destroy(gameObject);
        }
    }
    void TargetToPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, Time.deltaTime * projectSpeed);
    }
}
