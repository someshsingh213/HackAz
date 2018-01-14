using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randAnswer : MonoBehaviour
{
    int sum1 = Shadow.number + cube2.number;
    int sum2 = cube3.number + cube4.number;
    int sum3 = cube5.number + cube6.number;







    // Use this for initialization
    void Start()
    {


        int ans;

        int randNum;
        randNum = Random.Range(1, 3);
        if (randNum == 1)
        {
            GameObject text = new GameObject();
            TextMesh t = text.AddComponent<TextMesh>();
            ans = sum1;
            t.text = ans.ToString();
            t.fontSize = 20;
            float x = (float)36.2;
            float y = (float)11.5;
            float z = (float)1.8;
            t.transform.localEulerAngles += new Vector3(0, -90, 0);
            t.transform.localPosition += new Vector3(x, y, z);
            t.color = new Color(0, 0, 0, 1);




        }
        else if (randNum == 2)
        {
            ans = sum2;
            GUI.Button(new Rect (10, 10, 150, 20), ans.ToString());
            GameObject text = new GameObject();
            TextMesh t = text.AddComponent<TextMesh>();
            ans = sum2;
            t.text = ans.ToString();
            t.fontSize = 20;
            float x = (float)36.2;
            float y = (float)11.5;
            float z = (float)1.8;
            t.transform.localEulerAngles += new Vector3(0, -90, 0);
            t.transform.localPosition += new Vector3(x, y, z);
            t.color = new Color(0, 0, 0, 1);


        }
        else
        {
            GameObject text = new GameObject();
            TextMesh t = text.AddComponent<TextMesh>();
            ans = sum3;
            t.text = ans.ToString();
            t.fontSize = 20;
            float x = (float)36.2;
            float y = (float)11.5;
            float z = (float)1.8;
            t.transform.localEulerAngles += new Vector3(0, -90, 0);
            t.transform.localPosition += new Vector3(x, y, z);
            t.color = new Color(0, 0, 0, 1);







        }

    }

    // Update is called once per frame
    void Update()
    {
        

    }
}

