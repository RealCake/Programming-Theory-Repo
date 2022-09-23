using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    private DataManager instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = new DataManager();
        }
        else
        {
            GameObject.Destroy(this);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
