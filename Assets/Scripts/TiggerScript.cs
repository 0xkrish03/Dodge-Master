using Unity.VisualScripting;
using UnityEngine;

public class TiggerScript : MonoBehaviour
{
    [SerializeField]
    GameObject projectile;
    [SerializeField]
    GameObject projectile1;
    [SerializeField]
    GameObject projectile2;
    [SerializeField]
    GameObject projectile3;
    [SerializeField]
    GameObject projectile4;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && projectile != null && projectile1 != null && projectile2 != null && projectile3 != null && projectile4 != null)
        {
            projectile.SetActive(true);
            projectile1.SetActive(true);
            projectile2.SetActive(true);
            projectile3.SetActive(true);
            projectile4.SetActive(true);
        }
    }
}
