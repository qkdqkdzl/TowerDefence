using UnityEngine;

public class ParticleCollisionExample : MonoBehaviour
{
    public ParticleSystem particleSystem; 

    void Start()
    {
        var collision = particleSystem.collision;
        collision.enabled = true;
        collision.type = ParticleSystemCollisionType.World;
        //collision.collidesWith = LayerMask.GetMask("Default");
    }

    void OnParticleCollision(GameObject other)
    {
        

        // ���� �ǰݵǾ����� ��� �Ǵ��ұ�? 
        // ���� �ǰ� Ȥ�� ���� �ִ� �ǹ��� �ǰ� �� ���� �����ϱ�.
        // 
        if (other.GetComponent<Enemy>() != null)
        {
            //Debug.Log("Enemy hit");
            //other.GetComponent<Enemy>().CheckHP(1);
        }

        if (other.GetComponent<Turret>())
        {
            //Debug.Log("Turret hit");
            //other.GetComponent<Turret>().TakeDamage(1);
        }
    }
}