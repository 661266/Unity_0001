using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Class8_Structinterface : MonoBehaviour
{
    // Unity 定義的結構 struct
    public Vector3 pos;

    //使用結構
    public Direction myDire1;
    //new 新增物件，並且可以使用結構子
    public Direction myDire2 = new Direction(4);
    void Start()
    {
        //使用結構成員
        //三圍向量結構 方法成員
        pos.Set(1, 2, 3);
        //三圍向量結構 欄位成員
        print("X座標:" + pos.x);

        //指定結構成員
        myDire1.direction = 1;
        //常數與靜態取得用法是一樣的
        print("方向右邊的值:" + Direction.right);

        //錯誤:不能變更常數
        //Direction.right = 5;
        myDire1.set("左");
        print("方向:" + myDire1.direction);

        //透過new 新增物件方向資訊
        print("第二筆方向資訊:" + myDire2.direction);

    }

    public Class_Data c_data1 = new Class_Data();
    public Struct_Data s_data1;

    //類別:參考型別 -傳址

    public Class_Data c2 = new Class_Data("50", 99999, 50);
    public Class_Data c3 = new Class_Data("亮亮", 999999, 100);
    
    //結構:實質型別 -傳值
    public Class_Data s2 = new Class_Data("50", 99999, 50);
    public Class_Data s3 = new Class_Data("亮亮", 999999, 100);
    private void Awake()
    {
        c_data1.name = "50小小";
        print(c_data1.name);
        s_data1.name = "KID";
        print(s_data1.name);

        c2 = c3;        //c2 = c3 兩筆資料地址相同
        c2.name = "50"; //修改 c2 等同於修改 c3

        s2 = s3;        //c2 = c3 兩筆資料值相同
        s2.name = "50";//修改s2 不會修改到s3
    }
}
