using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour {

    //キューブの移動速度
    private float speed = -0.2f;

    // 消滅位置
    private float deadLine = -10;

    private AudioSource blockAudio;


	// Use this for initialization
	void Start () {
        blockAudio = GameObject.Find("BlockAudio").GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {

        //キューブを移動させる
        transform.Translate(this.speed, 0, 0);

        if (transform.position.x < this.deadLine) {
            Destroy(gameObject);
        }

	}

    void OnCollisionEnter2D(Collision2D other) {
        //print(other.gameObject.name);
        // 岩のぶつかりを確認
        if (other.gameObject.name != "UnityChan2D") {
            blockAudio.Play();
        }
    }
}
