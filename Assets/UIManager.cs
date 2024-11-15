using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class UIManager : Observer
{
    CharacterController characterController;

    [SerializeField]
    TMP_Text chickenText;

    [SerializeField]
    TMP_Text moneyOnMyMind;

    [SerializeField]
    TMP_Text Multiplier;


    public override void Notify(Subjects subjects)
    {
        if (!characterController) 
        {
            characterController = GameObject.Find("GameController").GetComponent<CharacterController>();
        }
    }

    // Start is called before the first frame update
    void Start()
    {

        characterController = GameObject.Find("GameController").GetComponent<CharacterController>();
        
    
    }

    // Update is called once per frame
    void Update()
    {
        chickenText.text = characterController.chickenAmount.ToString();
        moneyOnMyMind.text = characterController.money.ToString();
    }
}
