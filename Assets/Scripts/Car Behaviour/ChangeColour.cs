using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColour : MonoBehaviour
{
    public Color[] colors;
    public Renderer[] mats;
    public void yellow(){
        for(int i=0;i<mats.Length;i++){
            mats[i].material.color=colors[0];
        }
    }
    public void orange(){
        for(int i=0;i<mats.Length;i++){
            mats[i].material.color=colors[1];
        }
    }
    public void blue(){
        for(int i=0;i<mats.Length;i++){
            mats[i].material.color=colors[2];
        }
    }
    public void black(){
        for(int i=0;i<mats.Length;i++){
            mats[i].material.color=colors[3];
        }
    }

}
