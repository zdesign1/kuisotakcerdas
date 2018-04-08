﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class timerTwoSulit : MonoBehaviour {
    Image fillImg;
    float timeAmt = 30;
    float time;  

    // Use this for initialization
    void Start () {
        fillImg = this.GetComponent<Image>();
        time = timeAmt;
    }
    
    // Update is called once per frame
    void Update () {
        if(time  > 0){
            time -= Time.deltaTime;
            fillImg.fillAmount = time / timeAmt;  
        }
    }
}