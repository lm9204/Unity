using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public LayerMask whatIsProp;
    
    public ParticleSystem explosionParticle;
    public AudioSource explosionAudio;

    public float maxDmg = 100f;
    public float explosionForce = 1000f;
    public float liftTime = 10f;
    public float explosionRadius = 20f;

    private void Start()
    {
        Destroy(gameObject,liftTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, explosionRadius, whatIsProp);

        for (int i = 0; i < colliders.Length; i++)
        {
            Rigidbody targetRigid = colliders[i].GetComponent<Rigidbody>();
            
            targetRigid.AddExplosionForce(explosionForce, transform.position, explosionRadius);

            Prop targetProp = colliders[i].GetComponent<Prop>();
            float dmg = CalcurateDmg(colliders[i].transform.position);

            targetProp.TakeDmg(dmg);
        }
        
        explosionParticle.transform.parent = null;

        explosionParticle.Play();
        explosionAudio.Play();
        
        GameManager.instance.OnBallDestory();
        
        Destroy(explosionParticle.gameObject, explosionParticle.main.duration);
        Destroy(gameObject);
    }

    private float CalcurateDmg(Vector3 targetPosition)
    {
        Vector3 explosionToTarget = targetPosition - transform.position;

        float distance = explosionToTarget.magnitude;

        float edgeToCenterDistance = explosionRadius - distance;

        float percentage = edgeToCenterDistance / explosionRadius;

        float dmg = maxDmg * percentage;

        dmg = Mathf.Max(0, dmg);

        return dmg;



    }
}
