using System.Globalization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SimpleUserInterfaceScript : MonoBehaviour
{

    public Text Result;
    public Text Number;
    public InputField InputField;
    public Button Add_Btn;
    public Button Transfer_Btn;

    public int Counter =0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PrintName()
    {
        Result.text = InputField.text;
    }

    public void AddNumber()
    {
        Counter++;
        Number.text = Counter.ToString();
    }


}
