using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class Prop : MonoBehaviour
{
    public float hp = 10f;
    public int score = 5;
    
    public ParticleSystem explosionParticle;

    public void TakeDmg(float dmg)
    {
        hp -= dmg;
        
        if(hp<=0)
        {
            ParticleSystem instance = Instantiate(explosionParticle, transform.position, transform.rotation);
            AudioSource explosionAudio = instance.GetComponent<AudioSource>();
            explosionAudio.Play();
            
            GameManager.instance.AddScore(score);
            
            Destroy(instance.gameObject, instance.duration);
            gameObject.SetActive(false);
        }
    }
}
