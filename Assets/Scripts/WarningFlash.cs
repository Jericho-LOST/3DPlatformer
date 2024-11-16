using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Unity.VisualScripting;
using UnityEngine;

public class WarningFlash : MonoBehaviour

    // this sript will be added to a "vanishing platform " prefab (i say this so i stop adding it to my player)

    //CURRENT ERROR object does'nt flash (even when aplied to a blank object) and doesnt wait before disapearing 
{
    MeshRenderer meshRenderer;
   
    public Material StartMaterial; 
    public Material EndMaterial;
   // that ws just me trying something  public Color startColor;
    float FlashTime = 12f;
    public float delay = 3f;


    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>(); // since this code will be inputted to any asset i need to assign its base color (the mesh renderer) from the start so it can flash later 
        // startcolor = meshRenderer.material.color;
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Disappear ")) // i took this techneque from the enemy//playerlife code but im not sure how to apply it outside of using Comparetags
        {
            FlashStart();
            new WaitForSeconds(delay); // hopefully this should make the platform wait before choosing i tried using "Invoke " and Yeild but it diddn't work
            Vanish();
        }



        void FlashStart()
        {
            meshRenderer.material = StartMaterial; 
            
             new  WaitForSeconds(delay); // 
            meshRenderer.material = EndMaterial;
        }
       
        void Vanish()
        {
            GetComponent<MeshRenderer>().enabled = false;
            GetComponent<BoxCollider>().enabled = false; // same trio as enemy script but with box collider instead of rigid body so player will fall through platform once it disapears 
            GetComponent<PlayerMovement>().enabled = false;
        }

    }
}