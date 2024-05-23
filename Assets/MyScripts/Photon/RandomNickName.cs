using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RandomNickName : MonoBehaviour
{
    public TMP_InputField nickname;
    private void Reset()
    {
        this.nickname = GetComponent<TMP_InputField>();
    }
    private void Start()
    {
        string ranNumStr = this.RandomNum().ToString();
        this.nickname.text = "Player" + ranNumStr;
    }
    protected int RandomNum()
    {
        int ranNum =Random.Range(100, 999);
        return ranNum;
    }
}
