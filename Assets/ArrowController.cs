using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    GameObject player;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("player");
        this.audioSource = this.player.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -0.1f, 0);

        if (transform.position.y < -5.0f)
        {
            Destroy(gameObject);
        }

        Vector2 p1 = transform.position;                // 화살의 중심 좌표
        Vector2 p2 = this.player.transform.position;    // 플레이어의 중심 좌표
        Vector2 dir = p1 - p2;                          // 두 좌표 계산
        float d = dir.magnitude;                        // 두 점 사이의 거리 계산

        float r1 = 0.5f; // 화살
        float r2 = 1.0f; // 플레이어

        if (d < r1 + r2)
        {
            Destroy(gameObject);

            GameObject di = GameObject.Find("GameDirector");
            di.GetComponent<GameDirector>().DecreaseHp();
            audioSource.Play();

        }
        
    }

}
