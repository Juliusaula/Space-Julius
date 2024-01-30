using System.Collections;
using UnityEngine;

public class Bullet : MonoBehaviour 
{
    [SerializeField] private float bulletLifeTime = 1f;

    private void Awake() {
        Destroy(gameObject, bulletLifeTime);
    }
}
