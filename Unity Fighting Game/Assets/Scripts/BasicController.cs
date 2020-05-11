using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicController : MonoBehaviour
{
    InputCollecter iC = new InputCollecter();
    float fWalk;
    float bWalk;
    int   airOptions;
    float jumpHeight;
    float gravity;
    int   health;
    bool  facingRight;
    bool  isP1 = true;

    // Start is called before the first frame update
    void Start()
    {
        fWalk       = .5f;
        bWalk       = -.45f;
        airOptions  = 1;
        jumpHeight  = 10;
        gravity     = .01f;
        health      = 10000;
        facingRight = isP1;
    }

    // Update is called once per frame
    void Update()
    {
        double left;
        double right;

        if (facingRight){
            left = bWalk;
            right = fWalk;
        } else {
            right = bWalk;
            left = fWalk;
        }

        if (iC.fInput == 6){
            transform.translate();
        }
        if (iC.fInput == 4){
            transform.translate();
        }
    }
}
