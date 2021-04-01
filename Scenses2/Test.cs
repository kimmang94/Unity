using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update 시작할때 한번 실행
    void Start()
    {
        
    }

    // Update is called once per frame 프레임마다 실행되는
    void Update()
    {
        transform.Rotate(new Vector3(1.0f, 1.0f, 1.0f));
    }
}
