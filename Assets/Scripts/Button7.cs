using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button7 : MonoBehaviour
{
    public Text buttonNomberOne;
    int button7 = 7;

    public void onPress()
    {
        buttonNomberOne.text += button7.ToString();
    }

}
