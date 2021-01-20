using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Punch : MonoBehaviour
{

    public bool punching = false;

    public Vector3 orgPos;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPunch(InputAction.CallbackContext context)
    {
        if (!punching)
        {
            punching = true;
            StartCoroutine(ActionPunch(0.25f, 0.80f, transform.forward));
        }
    }

  

    IEnumerator ActionPunch(float time, float distance, Vector3 direction)
    {
        var timer = 0.0f;
        orgPos = gameObject.transform.position;
        direction.Normalize();
        while (timer <= time)
        {
            var OriginPlace = orgPos + (Mathf.Sin(timer / time * Mathf.PI) + distance) * direction;
            transform.position = OriginPlace.normalized;
            yield return null;
            timer += Time.deltaTime;
        }
        gameObject.transform.position = orgPos;
        punching = false;
    }
}
