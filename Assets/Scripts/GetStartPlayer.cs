using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetStartPlayer : Controller
{
//Lay hieu ung
    private void Awake()
    {
        GetSpriteRender();
    }
//Lap lai hieu ung
    private void Start()
    {
        RepeatingAnimate();  
    }
//Lap lai hoat canh cho chim bay len va ha xuong
    private void Update()
    {
        BirdAutomaticallyMove();
    }
}

