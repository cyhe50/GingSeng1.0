using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;  //StreamWrite會用到
using System.Runtime.Serialization.Formatters.Binary; //BinaryFormatter
public class load : MonoBehaviour
{

    static public endpassing.savefile loadData = new endpassing.savefile();
    endpassing.savefile sv = new endpassing.savefile();
    // Use this for initialization
    void Start()
    {

        if (!File.Exists(Application.persistentDataPath + "/myPlayer"))
        {
            Debug.Log(Application.persistentDataPath);
            string[] s = { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
            sv.endsinsave = s;
            sv.numberinsave = 0;
            //將myPlayer轉換成json格式的字串
            string saveString = JsonUtility.ToJson(sv);

            //將字串saveString存到硬碟中
            StreamWriter file = new StreamWriter(System.IO.Path.Combine(Application.persistentDataPath, "myPlayer"));
            file.Write(saveString);
            file.Close();
        }
        loadfile();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void loadfile()
   {
        //讀取json檔案並轉存成文字格式
        StreamReader file = new StreamReader(System.IO.Path.Combine(Application.persistentDataPath, "myPlayer"));
        string loadJson = file.ReadToEnd();
        file.Close();

        //使用JsonUtillty的FromJson方法將存文字轉成Json
        loadData = JsonUtility.FromJson<endpassing.savefile>(loadJson);

    }
}