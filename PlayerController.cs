﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    void Start () {
  	}

    void Update () {
      if (Input.GetKeyDown(KeyCode.LeftArrow)) {
        transform.Translate(-3, 0, 0); // 左に3動かす
      }

      if (Input.GetKeyDown(KeyCode.RightArrow)) {
        transform.Translate(3, 0, 0); // 右に3動かす
      }
  	}

}
