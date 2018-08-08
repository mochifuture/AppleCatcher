using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleGenerator : MonoBehaviour {

    public GameObject applePrefab;
    float span = 1.0f;
    float delta = 0;

    void Update() {
        // 前フレームと現在のフレームの時間差を加算
        this.delta += Time.deltaTime;
        // deltaの値が1秒を超えたらインスタンスを生成
        if (this.delta > this.span) {
            this.delta = 0;
            GameObject go = Instantiate(applePrefab) as GameObject;
            // りんごのX座標が-6〜6の間でランダムな位置になるようにする
            int px = Random.Range(-6, 7);
            go.transform.position = new Vector3(px, 7, 0);
        }
    }
}
