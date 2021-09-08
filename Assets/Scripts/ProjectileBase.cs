using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ProjectileBase : MonoBehaviour
{
    protected abstract void ShootProjectile(GameObject projectile);

    [SerializeField] int _damageValue = 1;

    WeaponController _wc;

    private void Awake()
    {
        _wc = FindObjectOfType<WeaponController>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        Player player = collision.gameObject.GetComponent<Player>();

        if (player == null)
        {
            Enemy enemy = collision.gameObject.GetComponent<Enemy>();

            if (enemy != null)
            {
                enemy.Damage(_damageValue);
            }

            ImpactFeedback();
        }
    }



    private void Update()
    {
        if (_wc._loaded)
        {
            ShootProjectile(_wc.newProjectile);
            _wc._loaded = false;
        }
    }

private void ImpactFeedback()
    {
        //play stuff
        Destroy(_wc.newProjectile);
    }

}
