using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Endnum : MonoBehaviour
{

    public Text end;

    // Use this for initialization
    void Start()
    {
        end.text = load.loadData.numberinsave + "/90";
    }

    // Update is called once per frame
    void Update()
    {

    }
}
