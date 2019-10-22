using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    SpriteRenderer spriteRenderer;


    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.enabled = false;
    }


    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "FootCollider"){
            spriteRenderer.enabled = true;
        }
    }

}
