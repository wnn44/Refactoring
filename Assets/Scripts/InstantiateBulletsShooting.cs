using System.Collections;
using UnityEngine;

public class InstantiateBulletsShooting : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _timeWaitShooting;
    [SerializeField] private Bullet _prefabBullet;
    [SerializeField] private Target _objectToShoot;

    void Start()
    {

        StartCoroutine(WorkerShooting());
    }

    IEnumerator WorkerShooting()
    {
        WaitForSeconds pause = new WaitForSeconds(_timeWaitShooting);

        bool isWork = true;        

        while (isWork)
        {
            Vector3 direction = (_objectToShoot.transform.position - transform.position).normalized;
            Bullet newBullet = Instantiate(_prefabBullet, transform.position, Quaternion.identity);

            newBullet.GetComponent<Rigidbody>().transform.up = direction;
            newBullet.GetComponent<Rigidbody>().velocity = direction * _speed;

            yield return pause;
        }
    }
}