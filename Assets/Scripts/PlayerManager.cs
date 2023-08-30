using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{

    private Health _health;

    // Start is called before the first frame update
    void Start()
    {
        _health = GetComponent<Health>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        EnemyManager enemy = collision.transform.GetComponent<EnemyManager>();

        if (enemy != null)
        {
            _health.Damage(20);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _health.Damage(20);
    }

}
