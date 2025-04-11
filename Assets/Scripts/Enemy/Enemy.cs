using System;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform gunbarrel;
    public Transform RealTarget;
    public static event Action OnDestroyEnemy;

    public int HP = 100;
    public int ATK;
    ////public void CheckHP(int damage)

    [Header("PS for Destroy")]
    public ParticleSystem Destroy_particloSysteam;

    


    private void Awake()
    {
        Destroy_particloSysteam.Stop();    // Class
        //MuzzelFlash_particleSystem.Stop();
        //BulletShells_ParticleSystem.Stop();
        //Traser_ParticleSysem.Stop();
    }




}
