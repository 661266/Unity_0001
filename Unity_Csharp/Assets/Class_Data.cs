using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]//序列化:讓類別顯示在屬性面板
public class Class_Data
{
    public string name;
    public int coin;
    public float hp;

    public Class_Data()
    {
        Debug.Log("空白的結構子~");
    }

    /// <summary>
    /// 設定所有資料:名稱，金幣與血量
    /// </summary>
    /// <param name="n"></param>
    /// <param name="c"></param>
    /// <param name="h"></param>
    public Class_Data(string n, int c, float h)
    {
        name = n;
        coin = c;
        hp = h;
    }


}
