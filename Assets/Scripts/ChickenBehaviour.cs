using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenBehaviour : Subjects
{

    public float chickenSpeed = 5f;

    [SerializeField]
    Transform shed;

    [SerializeField]
    ChickenBehaviourSO behaviourSO;

    // Start is called before the first frame update
    void Start()
    {
        shed = FindAnyObjectByType<Shed>().transform;

        chickenSpeed = behaviourSO.Speed();
        
    }

    // Update is called once per frame
    void Update()
    {
        var step = chickenSpeed * Time.deltaTime;


        transform.position = Vector3.MoveTowards(transform.position, shed.position, step);
    }


    


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Shed")) 
        {
            GameManager.Instance.chicken += 1;

            Destroy(gameObject, 0.2f);
        
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (behaviourSO.IsEvil() == true)
        {
            
        }

    }

}
