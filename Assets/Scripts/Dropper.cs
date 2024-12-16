using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float seconds = 10f;

    MeshRenderer myMeshRenderer;
    Rigidbody myRigidBody;

    void Start()
    {
        myMeshRenderer = GetComponent<MeshRenderer>();
        myRigidBody = GetComponent<Rigidbody>();
        myRigidBody.useGravity = false;
        myMeshRenderer.enabled = false;
    }


    void Update()
    {
        if (Time.time >= seconds)
        {
            myMeshRenderer.enabled = true;
            myRigidBody.useGravity = true;
        }
    }
}
