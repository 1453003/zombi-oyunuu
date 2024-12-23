using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGui : MonoBehaviour
{
    // Start is called before the first frame update

    public Texture2D _crosshair;

    // Update is called once per frame
    void Update()
    {
    }
    private void OnGUI()
    {
        
        float y = (Screen.height - _crosshair.height) / 2;
        float x = (Screen.width - _crosshair.width) / 2;
        GUI.DrawTexture(new Rect(x, y, _crosshair.width, _crosshair.height), _crosshair);
    }
}
