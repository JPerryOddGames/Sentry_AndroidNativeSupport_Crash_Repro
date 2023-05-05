using System.Runtime.CompilerServices;
using UnityEngine;

public class SentryCrashReproduce : MonoBehaviour
{
    [MethodImpl(MethodImplOptions.NoOptimization)]
    private void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).tapCount == 3)
        {
            Debug.Log("Triple-tap detected, doing crash");

            // Accessing the '.bytes' property on a null reference produces an exception that kills Sentry
            TextAsset textAsset = null;
            var bytes = textAsset.bytes;
        }
    }
}
