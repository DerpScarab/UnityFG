using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputCollector : MonoBehaviour
{
    public ArrayList<Integer> inputStream = new ArrayList();
    public int xInput;
    public int yInput;
    public int fInput;

    // Start is called before the first frame update
    void Start()
    {
        xInput = 0;
        yInput = 0;
    }

    // Update is called once per frame
    void Update()
    {
        xInput = Input.GetAxisRaw("Horizontal");
        yInput = Input.GetAxisRaw("Vertical");
        if (!facingRight){xInput = -xInput;}

        if (xInput == -1 && yInput == -1){fInput = 1;}
        if (xInput == 0 && yInput == -1) {fInput = 2;}
        if (xInput == 1 && yInput == -1) {fInput = 3;}
        if (xInput == -1 && yInput == 0) {fInput = 4;}
        if (xInput == 0 && yInput == 0)  {fInput = 5;}
        if (xInput == 1 && yInput == 0)  {fInput = 6;}
        if (xInput == -1 && yInput == 1) {fInput = 7;}
        if (xInput == 0 && yInput == 1)  {fInput = 8;}
        if (xInput == 1 && yInput == 1)  {fInput = 9;}

        inputStream.add(fInput);
    }
}
