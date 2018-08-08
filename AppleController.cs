using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleController : MonoBehaviour {

    GameObject player;

	void Start () {
        // プレイやのオブジェクトを取得
        this.player = GameObject.Find("player");
	}

    void Update () {
        // フレームごとにりんごを等速で落下させる
        transform.Translate(0, -0.1f, 0);

        // 画面外に出たらオブジェクトを破棄する
        if(transform.position.y < -5.0f) {
            Destroy(gameObject);
        }

        // 当たり判定を円の中心座標と半径を使って設定
        Vector2 p1 = transform.position;              // りんごの中心座標
        Vector2 p2 = this.player.transform.position;  // プレイヤの中心座標
        Vector2 dir = p1 - p2;        // プレイヤからりんごへ向かうベクトル
        float d = dir.magnitude;
        float r1 = 0.5f;   // りんごの半径
        float r2 = 1.0f;   // プレイヤの半径

        if (d < r1 + r2) {
            // 監督スクリプトにプレイヤと衝突したことを伝える
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().IncreaseManpuku();

            // 衝突した場合は矢を消す
            Destroy(gameObject);
        }
	}
}
