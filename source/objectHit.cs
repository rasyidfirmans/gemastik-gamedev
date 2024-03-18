using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    // Start is called before the first frame update
    static int score = 0;
    private void OnCollisionEnter(Collision other)
    {
        if (GetComponent<MeshRenderer>().material.color != Color.red)
        {
            ++score;
        }
        Debug.Log(score);

        Debug.Log("Aduhhh, aku ada yang nabrak nichh! Sakit bangett...");
        // Mengubah warna objek yang di tabrak
        // Berubah warna merah hanya jika bertabrakan dengan player aka. tag player
        if (other.gameObject.tag == "Player")
        {
            GetComponent<MeshRenderer>().material.color = Color.red;
        }

    }
}
