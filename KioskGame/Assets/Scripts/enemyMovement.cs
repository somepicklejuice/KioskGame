﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour
{
      public Vector3 pointB;

      IEnumerator Start()
      {
        var pointA = transform.position;
          while(true)
          {
              yield return StartCoroutine(MoveObject(transform, pointA, pointB, 3.0f));
              yield return StartCoroutine(MoveObject(transform, pointB, pointA, 3.0f));
          }
      }

      IEnumerator MoveObject(Transform thisTransform, Vector3 startPos, Vector3 endPos, float time)
      {
          var i = 0.0f;
          var rate = 1.0f/time;
          while(i < 1.0f)
          {
              i += Time.deltaTime * rate;
              thisTransform.position = Vector3.Lerp(startPos, endPos, i);
              transform.localRotation = Quaternion.Euler(0,180, 0);
              yield return null;
          }
      }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Player")
        {
            if(col.GetComponent<Rigidbody2D>().velocity.y <= 0f)
            {
                col.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 7f);
                Destroy(gameObject);
            }
        }
    }
}
