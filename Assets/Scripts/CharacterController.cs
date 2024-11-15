using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : Subjects
{

    public GameObject[] chicken;

    [SerializeField]
    float evilChickenWeight = 0.20f;

    [SerializeField]
    Transform spawnPoint;

    public int chickenAmount;

    public float money; 
    

    

    // Start is called before the first frame update
    void Start()
    {
        evilChickenWeight = evilChickenWeight * 100;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown) 
        {
            float weight = Random.Range(0.0f, 1.0f);


            weight = Mathf.Round(weight);
            weight = weight * 100;

            if (weight <= evilChickenWeight) 
            {

                Instantiate(chicken[1], spawnPoint.transform);
                Debug.Log("EVIL");
            }


            Instantiate(chicken[0], spawnPoint.transform);
            Debug.Log("Normal");


        
        
        }
        chickenAmount = GameManager.Instance.chicken;
        money = GameManager.Instance.eggs;

    }
}
