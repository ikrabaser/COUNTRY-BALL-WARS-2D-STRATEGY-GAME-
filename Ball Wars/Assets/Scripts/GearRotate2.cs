using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace GearRotate
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class GearRotator : MonoBehaviour
    {
        public float rotationSpeed = -100f;
        void Update()
        {
            transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
        }
    }
}
