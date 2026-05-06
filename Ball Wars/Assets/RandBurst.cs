using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UnityEngine;

public class RandBurst : MonoBehaviour
{
    public ParticleSystem ps;
    void Start()
    {
        if (ps != null)
        {
            ps.Play(); //Oyunun başında otomatik patlama 
        }
        else
        {
            Debug.LogWarning("ParticleSystem atanmadı!");
        }
    }

    //Eğer elle tetiklemek istersek 
    public void Fire()
    {
        if (ps != null)
        {
            ps.Play();
        }
    }
}
}
