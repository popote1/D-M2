using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MaterialAnimator : MonoBehaviour
{
    public List<Material> Frames;
    public MeshRenderer MeshRenderer;
    public float Frequence;

    private float time=0;
    private int index;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      /*  time += Time.deltaTime;
        if (time > Frequence)
        {
            for (int i = 0; i < Frames.Count; i++)
            {
                if (i == index)
                {
                    Frames[i].SetActive(true);
                }
                else
                {
                    Frames[i].SetActive(false);
                }
            }

            time = 0;

            index++;
            if (index>=Frames.Count)
            {
                index = 0;
            }
        }*/

        time += Time.deltaTime;
        if (time > Frequence)
        {
            MeshRenderer.material = Frames[index];

            time = 0;

            index++;
            if (index>=Frames.Count)
            {
                index = 0;
            }
        }
    }

   
}
