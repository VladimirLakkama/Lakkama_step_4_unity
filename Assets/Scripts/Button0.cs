using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button0 : MonoBehaviour
{
    public Text buttonNomberOne;
    int button0 = 0;

    public void onPress()
    {
        buttonNomberOne.text += button0.ToString();
    }

}
