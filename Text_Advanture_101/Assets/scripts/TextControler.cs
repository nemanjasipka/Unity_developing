using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextControler : MonoBehaviour
{
    public Text text;
    private  enum States
    { cell, mirror, sheets_0, lock_0, sheets_1, lock_1, cell_mirror, exit,
      stairs_0, floor, closet_door,corridor_1, stairs_1, in_closet, corridor_2,
      stairs_2, corridor_3,courtyard};
    private States myState;
    // Use this for initialization
    void Start()
    {
        myState = States.cell;
    }

    // Update is called once per frame
    void Update()
    {
        if      (myState == States.cell)            {cell();}
        else if (myState == States.sheets_0)        {states_sheets_0();}
        else if (myState == States.lock_0)          {lock_0();}
        else if (myState == States.mirror)          {mirror();}
        else if (myState == States.lock_1)          {lock_1();}
        else if (myState == States.cell_mirror)     {cell_mirror();}
        else if (myState == States.sheets_1)        {sheets_1();}
        else if (myState == States.exit)            {coridor_0();}
        else if (myState == States.stairs_0)        {stairs_0();}
        else if (myState == States.stairs_1)        {stairs_1();}
        else if (myState == States.stairs_2)        {stairs_2();}
        else if (myState == States.courtyard)       {courtyard();}
        else if (myState == States.floor)           { floor();}
        else if (myState == States.corridor_1)      {corridor_1();}
        else if (myState == States.corridor_2)      {corridor_2();}
        else if (myState == States.corridor_3)      {corridor_3();}
        else if (myState == States.closet_door)     {closet_door();}
        else if (myState == States.in_closet)       {in_closet();}

    }
    void cell()
    {
        text.text = "Hi there! You woke up after two days " +
           "of sleep in a jail cell. You don`t know how you got there " +
           "and what are you in for. You look around, " +
           "and you see on bed there are some sheets, and on the floor a piece of broken mirror. " +
           "You hear the footsteps coming " +
           "towards you.\n\n" +
           "Press M to view the Mirror, S to view the Sheets, and L to view the Lock.";
        if      (Input.GetKeyDown(KeyCode.S))       {myState = States.sheets_0;}
        else if (Input.GetKeyDown(KeyCode.L))       {myState = States.lock_0;}
        else if (Input.GetKeyDown(KeyCode.M))       {myState = States.mirror;}

    }
    void states_sheets_0()
    {
        text.text = "You don`t have a use for them now. " +
           "They might come handy later.\n\n" +
           "Press R to continue to examining the cell";
        if (Input.GetKeyDown(KeyCode.R))            {myState = States.cell;}
    }
    void lock_0()
    {
        text.text = "Cell door is locked and the footsteps are coming closer. " +
           "\n\n" +
           "Press R to continue to examining the cell";
        if (Input.GetKeyDown(KeyCode.R))            {myState = States.cell;}
    }

    void mirror()
    {
        text.text = "You pick up a piece of broken mirror.  " +
           "In that moment you here that cell door is opening behind you.\n\n" +
           "Press Space to continue";
        if (Input.GetKeyDown(KeyCode.Space))        {myState = States.lock_1;}
    }
    void lock_1()
    {
        text.text = "You turn around, and deside that this is time to act.  " +
           "In that moment you rush to one of the guards\n\n" +
           "Press U to attack one of the guards ";
        if (Input.GetKeyDown(KeyCode.U))            {myState = States.cell_mirror;}
    }
    void cell_mirror()
    {
        text.text = "You stab the guard in the neck, he starts to choke in his own blood. The second guard is reaching for the taiser, and you look at the sheets " +
           "and you deside to take them and strangle the guard\n\n" +
           "Press S to strangle the  second guard ";
        if (Input.GetKeyDown(KeyCode.S))            {myState = States.sheets_1;}

    }
    void sheets_1()
    {
        text.text = "After you done strangling the guard you rush towards the cell door to escape " +
           "\n\n" +
           "Press Space to escape ";
        if (Input.GetKeyDown(KeyCode.Space))        {myState = States.exit;}

    }

    void coridor_0()
    {
        text.text = "You are now in a hallway of the prison." /*+
           "\n\n" +
           "Press Space to escape "*/;
        /*if (Input.GetKeyDown(KeyCode.Space)) { myState = States.exit; }*/

    }


}

