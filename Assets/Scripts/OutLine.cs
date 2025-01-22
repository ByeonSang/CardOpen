using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[RequireComponent(typeof(Outline))]
public class OutLine : MonoBehaviour
{
    private Outline _outLine;
    
    float r, g, b, a;
    [Range(0, 10)]
    public float rPlus = 0, gPlus = 0, bPlus = 0, aPlus = 0.5f;
    
    // Start is called before the first frame update
    void Start()
    {
        _outLine = gameObject.GetComponent<Outline>();
    }

    // Update is called once per frame
    void Update()
    {
        r += rPlus  * Time.deltaTime;
        g += gPlus  * Time.deltaTime;
        b += bPlus  * Time.deltaTime;
        a += aPlus  * Time.deltaTime;

        if (r >= 1) r = 0;
        if (g >= 1) g = 0;
        if (b >= 1) b = 0;
        if (a >= 1) a = 0;
        
        _outLine.effectColor = new Color(r, g, b, a);
    }
}
