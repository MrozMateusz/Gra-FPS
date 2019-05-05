using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyThings : MonoBehaviour
{
    float czas_zycia = 1f;

    private void Update()
    {
        czas_zycia -= Time.deltaTime;

        if(czas_zycia <= 0)
        {
            Destroy(gameObject);
        }
    }

}
