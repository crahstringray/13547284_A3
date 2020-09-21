using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    float x = 0;
    float y = 0; 
    public Object Outside_Corner;
    public Object Outside_Wall;
    public Object Inside_Corner;
    public Object Inside_Wall;
    public Object Power_Pellet;
    public Object Normal_Pellet;
    public Object Junction;

    // Start is called before the first frame update
    void Start()
    {
        int[,] levelMap =
        {
        {1,2,2,2,2,2,2,2,2,2,2,2,2,7},
        {2,5,5,5,5,5,5,5,5,5,5,5,5,4},
        {2,5,3,4,4,3,5,3,4,4,4,3,5,4},
        {2,6,4,0,0,4,5,4,0,0,0,4,5,4},
        {2,5,3,4,4,3,5,3,4,4,4,3,5,3},
        {2,5,5,5,5,5,5,5,5,5,5,5,5,5},
        {2,5,3,4,4,3,5,3,3,5,3,4,4,4},
        {2,5,3,4,4,3,5,4,4,5,3,4,4,3},
        {2,5,5,5,5,5,5,4,4,5,5,5,5,4},
        {1,2,2,2,2,1,5,4,3,4,4,3,0,4},
        {0,0,0,0,0,2,5,4,3,4,4,3,0,3},
        {0,0,0,0,0,2,5,4,4,0,0,0,0,0},
        {0,0,0,0,0,2,5,4,4,0,3,4,4,0},
        {2,2,2,2,2,1,5,3,3,0,4,0,0,0},
        {0,0,0,0,0,0,5,0,0,0,4,0,0,0},
        };

        foreach (int i in levelMap)
        {
           int mapNumber = i;
            if (mapNumber == 1)
            {
                Instantiate(Outside_Corner, new Vector3(x, y, 0), Quaternion.identity);
                x = x + 7;
                if (x == 98)
                {
                    y = y + 7;
                    x = 0;
                }

               
            }
            if (mapNumber == 2)
            {
                Instantiate(Outside_Wall, new Vector3(x, y, 0), Quaternion.identity);
                x = x + 7;
                if (x == 98)
                {
                    y = y + 7;
                    x = 0;
                }
            }

            if (mapNumber == 3)
            {
                Instantiate(Inside_Corner, new Vector3(x, y, 0), Quaternion.identity);
                x = x + 7;
                if (x == 98)
                {
                    y = y + 7;
                    x = 0;
                }
            }

            if (mapNumber == 4)
            {
                Instantiate(Inside_Wall, new Vector3(x, y, 0), Quaternion.identity);
                x = x + 7;
                if (x == 98)
                {
                    y = y + 7;
                    x = 0;
                }
            }

            if (mapNumber == 5)
            {
                Instantiate(Normal_Pellet, new Vector3(x, y, 0), Quaternion.identity);
                x = x + 7;
                if (x == 98)
                {
                    y = y + 7;
                    x = 0;
                }
            }

            if (mapNumber == 6)
            {
                Instantiate(Power_Pellet, new Vector3(x, y, 0), Quaternion.identity);
                x = x + 7f;
                if (x == 98)
                {
                    y = y + 7f;
                    x = 0;
                }
            }

            if (mapNumber == 7)
            {
                Instantiate(Junction, new Vector3(x, y, 0), Quaternion.identity);
                x = x + 7f;
                if (x == 98)
                {
                    y = y + 7f;
                    x = 0;
                }
            }

        } 
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

