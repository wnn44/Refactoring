using UnityEngine;

public class GoPlaces : MonoBehaviour
{
    public float _maxDistanceDelta = 0.05f;

    public void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, transform.position, _maxDistanceDelta);
    }
}