using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopTimeSaveData : MonoBehaviour
{
    public static List<float> mTimeSaveList = new List<float>();

    public static void SaveTime(float SetTime)
    {
        mTimeSaveList.Add(SetTime);
    }
}
