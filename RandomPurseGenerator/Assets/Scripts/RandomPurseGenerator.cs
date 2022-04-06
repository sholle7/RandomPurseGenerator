using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPurseGenerator : MonoBehaviour
{
    [SerializeField] private SpriteRenderer spriteRendeer;
    [SerializeField] private Sprite[] purses;
    // Start is called before the first frame update

    public void SetSprite()
    {
        int num = UnityEngine.Random.Range(0, purses.Length);
        spriteRendeer.sprite = purses[num];
    }
    private void OnMouseDown()
    {
        SetSprite();
    }


}
