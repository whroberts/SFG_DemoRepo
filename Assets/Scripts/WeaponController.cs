using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    [SerializeField] GameObject _missle;
    [SerializeField] Transform _barrel;
    public bool _loaded = false;
    public GameObject newProjectile;

    protected Transform Barrel => _barrel;

    private void Awake()
    {
        _barrel = this.gameObject.transform;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            LoadProjectile(_missle);
        }
    }
    public void LoadProjectile(GameObject projectile)
    {
        Debug.Log("Load Missle");
        newProjectile = Instantiate(projectile, Barrel, false);
        LoadFeedback();
        _loaded = true;
    }

    private void LoadFeedback()
    {
        //play effects
    }
}
