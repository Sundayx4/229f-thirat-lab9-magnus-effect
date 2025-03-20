using UnityEngine;

public class magnusEffect : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] Vector3 velocity, spin;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.K)) 
        {
            //kick
            kick();
        }
        //apply magus effect
        ApplyMagnusEffect();
    }

    void kick() 
    {
        //·√ß‡µ–∫≈Õµ√ß‰ªÀ“ Goal
        rb.linearVelocity = velocity;
        //·√ßÀ¡ÿ≈∫Õ≈
        rb.angularVelocity = spin;
    }

    void ApplyMagnusEffect()
    {
        Vector3 magnusForce = Vector3.Cross(rb.linearVelocity, rb.angularVelocity);

        rb.AddForce(magnusForce);
    }

}   

