using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public struct Quesition
{
    public string fact;
    public bool isTrue;

}

public static class Globals{
    public static List<Quesition> questions = new List<Quesition>();
}