using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // UIを使うので忘れずに追加

public class GameDirector : MonoBehaviour {

    GameObject manpukuGauge;

    void Start() {
        this.manpukuGauge = GameObject.Find("manpukuGauge");
    }

    public void IncreaseManpuku() {
        this.manpukuGauge.GetComponent<Image>().fillAmount += 0.1f;
    }
}
