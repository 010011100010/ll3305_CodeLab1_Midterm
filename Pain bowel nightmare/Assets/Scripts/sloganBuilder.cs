using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;

public class sloganBuilder : MonoBehaviour
{
    public string[] fileNames;
    public static int levelNum = 0;
    public float offsetZ = -30;
    public float heightOffset = 30;
    public int offsetX = -50;
    //public float offsetY = 0;
    // Use this for initialization
    void Start()
    {
        string fileName = fileNames[levelNum];

        string filePath = Application.dataPath + "/" + fileName;



        int yPos = 0;
        int zPos = 0;

        StreamReader sr = new StreamReader(filePath);

        GameObject levelHolder = new GameObject("Level Holder");
        levelNum++;
        zPos++;
        //SceneManager.LoadScene("Scene1");
        while (!sr.EndOfStream)
        {
            string line = sr.ReadLine();

            for (int xPos = 0; xPos < line.Length; xPos++)
            {
                if (line[xPos] == '#')
                {
                    //GameObject cube = GameObject.CreatePrimitive (PrimitiveType.Cube);
                    GameObject cube = Instantiate(Resources.Load("black brick prefab") as GameObject);
                    cube.transform.parent = levelHolder.transform;
                    cube.transform.position = new Vector3(xPos + offsetX, heightOffset, yPos + offsetZ);
                }
            }

            yPos--;
        }
        sr.Close();

    }

    // Update is called once per frame
    void Update()
    {
       
       



    }
}