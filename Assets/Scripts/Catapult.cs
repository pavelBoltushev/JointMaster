using System.Collections;
using UnityEngine;

public class Catapult : MonoBehaviour
{
    [SerializeField] private SpringJoint _springPoint;
    [SerializeField] private Rigidbody _catapultStick;
    [SerializeField] private float _launchSpringTension;
    [SerializeField] private Transform _spawnPoint;
    [SerializeField] private GameObject _projectileTemplate;

    public void Launch()
    {
        _catapultStick.WakeUp();
        _springPoint.spring = _launchSpringTension;
    }

    public void Reload()
    {
        _catapultStick.WakeUp();
        _springPoint.spring = 0;
        StartCoroutine(SpawnProjectileInSecond());
    }

    private IEnumerator SpawnProjectileInSecond()
    {
        yield return new WaitForSeconds(1);

        Instantiate(_projectileTemplate, _spawnPoint.position, Quaternion.identity);
    }
}
