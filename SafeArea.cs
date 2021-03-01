using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeArea : MonoBehaviour
{
    private Rect _safeArea;
    public delegate void SafeAreaChanged (Rect safeArea);
    public static event SafeAreaChanged OnSafeAreaChanged;
    // Start is called before the first frame update
    void Awake()
    {
        _safeArea = Screen.safeArea;
    }

    // Update is called once per frame
    void Update()
    {
        if(_safeArea != Screen.safeArea)
        {
            _safeArea = Screen.safeArea;
            OnSafeAreaChanged?.Invoke(_safeArea);
        }
    }
}
