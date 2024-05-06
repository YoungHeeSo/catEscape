using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{

    public GameObject arroawPrefab;
    float span = 1.0f;
    float delta = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime; 

        // 1초마다 랜덤한 위치에 화살 생성
        if(this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(arroawPrefab);

            int px = Random.Range(-6, 7); // 랜덤한 px 값 생성
            go.transform.position = new Vector2 (px, 4);
        }
    }
}
