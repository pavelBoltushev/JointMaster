using UnityEngine;

public class Swing : MonoBehaviour
{
    [SerializeField] private float _pushForce;
    [SerializeField] private Rigidbody _movingPart;    

    public void Push()
    {
        _movingPart.AddForce(Vector3.forward * _pushForce, ForceMode.Impulse);
    }
}