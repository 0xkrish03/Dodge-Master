using Unity.VisualScripting;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits = 0;
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag != "hit")
        {
            hits = hits + 1;
            Debug.Log($"You bumped this many time: {hits}");

        }
    }
}
