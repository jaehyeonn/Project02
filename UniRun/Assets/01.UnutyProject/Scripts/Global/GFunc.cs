using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public static partial class GFunc 
{
    [System.Diagnostics.Conditional("DEBUG_MODE")]
    public static void Log(object message)
    {
#if DEBUG_MODE
        Debug.Log(message);
#endif
    }
    [System.Diagnostics.Conditional("DEBUG_MODE")]
    public static void Assert (bool condition)
    {
#if DEBUG_MODE
        Debug.Assert(condition);
#endif
    }

    //! GameO 받아서 Text 컴포넌트 찾아서 text 필드 값 수저유하는 함수

    public static void SetText(this GameObject target, string text)
    {
        Text textComponent = target.GetComponent<Text>();
        if (textComponent == null || textComponent == default) { return; }

        textComponent.text = text;
    }

    //두 벡터를 더한다
    public static Vector2 AddVector(this Vector3 origin, Vector2 addVector)
    {
        Vector2 result = new Vector2(origin.x, origin.y);
        result += addVector;
            return result;
    }
}
