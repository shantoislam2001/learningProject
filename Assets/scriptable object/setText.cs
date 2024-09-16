using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class setText : MonoBehaviour
{
    [SerializeField] private Data dataOb;
   [SerializeField] public Text Name;
   [SerializeField] public Text Age;
    // Start is called before the first frame update
    void Start()
    {
        Name.text = dataOb.name;
        Age.text = dataOb.age.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
