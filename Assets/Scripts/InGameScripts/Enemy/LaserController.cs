using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserController : MonoBehaviour
{
    public void ChangeTag()
    {
        if (transform.CompareTag("Enemy"))
        {
            transform.tag = "Untagged";
        }
        else
        {
            transform.tag = "Enemy";
        }
    }
}