using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightControl : MonoBehaviour{
    public GameObject red;
    public GameObject yellow;
    public GameObject green;
    private bool _colorRed = true;
    private bool _colorYellow;
    private bool _colorGreen;

    public void SelectRed(){
        if (this._colorRed){
            this.red.GetComponent<Renderer>().material.color = new Color(0, 0, 0);
            this._colorRed = false;
        }
        else{
            this.red.GetComponent<Renderer>().material.color = new Color(1f, 0, 0);
            this._colorRed = true;
        }
    }

    public void SelectYellow(){
        if (this._colorYellow){
            this.yellow.GetComponent<Renderer>().material.color = new Color(0, 0, 0);
            this._colorYellow = false;
        }
        else{
            this.yellow.GetComponent<Renderer>().material.color = new Color(1f, 1f, 0);
            this._colorYellow = true;
        }
    }

    public void SelectGreen(){
        if (this._colorGreen){
            this.green.GetComponent<Renderer>().material.color = new Color(0, 0, 0);
            this._colorGreen = false;
        }
        else{
            this.green.GetComponent<Renderer>().material.color = new Color(0, 1f, 0);
            this._colorGreen = true;
        }
    }
}