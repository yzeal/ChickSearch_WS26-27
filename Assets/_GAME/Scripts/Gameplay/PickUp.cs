using StarterAssets;
using UnityEngine;

public class PickUp : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("PickUp: OnTriggerEnter: " + other.name);

        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
        }

    }

}
