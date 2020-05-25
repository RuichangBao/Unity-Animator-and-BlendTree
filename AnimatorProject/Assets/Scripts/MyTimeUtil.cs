using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyTimeUtil
{
    public static long GetCurrTimeMM
    {
        get
        {
            return (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000) / 10000;
        }
    }
}