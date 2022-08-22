using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    public Renderer rend;
    private int i;
    private int blueDisable;

    // Start is called before the first frame update
    void Start()
    {
        i = 3;
        blueDisable = UnityEngine.Random.Range(200, 251);
        if (transform.tag == "Blue") Debug.LogWarning($"Blue Disable: {blueDisable}");
    }

    // Update is called once per frame
    void Update()
    {
        
        Debug.Log($"{transform.name}:{++i}");
        
        if (transform.tag == "Red" && i == 100)
        {
            transform.gameObject.SetActive(false);
        }
        if (transform.tag == "Blue" && i == blueDisable)
        {
            transform.GetComponent<Renderer>().enabled = false;
        }
    }
}
