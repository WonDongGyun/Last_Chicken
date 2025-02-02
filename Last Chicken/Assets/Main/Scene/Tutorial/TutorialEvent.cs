﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialEvent : CustomCollider
{
    BoxCollider2D boxCollider2D;

    public GameObject actObject;
    public string itemName;

    bool actFlag = false;

    #region[Awake]
    public void Awake()
    {
        boxCollider2D = GetComponent<BoxCollider2D>();
    }
    #endregion

    #region[Update]
    public void Update()
    {
        if (IsAtPlayer(boxCollider2D) && IsAtItem(boxCollider2D, itemName))
            On();
        else
            Off();
    }
    #endregion

    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    #region[작동]
    public void On()
    {
        if (actFlag || !actObject)
            return;
        actFlag = true;

        actObject.SetActive(true);
    }

    public void Off()
    {
        if (!actFlag || !actObject)
            return;
        actFlag = false;

        actObject.SetActive(false);
    }
    #endregion
}
