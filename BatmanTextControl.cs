//Batman Training 
// All Charatcers used in this story are the property of DC Comics. 
// This is a fictionilzed story and is intended for personal use and all right are reserved to DC comics.
// This story is the original story created by Richard A. Haynes
//http://localhost:49846/ 1st web build
//http://localhost:49846/ 2nd web build
//http://gamebucket.io/game/4373e2d4-afbb-4148-984e-9ed101026dae 1st gamebucket share
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BatmanTextControl :  MonoBehaviour {
public Text text;
private enum States{cell ,pull_ups, crunches, squats, push_ups,sheets_0, freedom};
private States myState;

    // Use this for initialization
    void Start () 
    {
        myState = States.cell;
    }
    
    // Update is called once per frame
    void Update () 
    {
        print(myState);
        if(myState == States.cell)
    {
        state_cell();
    } else if (myState == States.pull_ups)
    {
        state_pull_ups();
    }else if (myState == States.push_ups)
    {
        state_push_ups();
    }else if (myState == States.squats)
    {
        state_squats();
    }else if (myState == States.crunches)
    {
        state_crunches();
    }else if (myState == States.freedom)
    {
    	state_freedom();
    }
}
        void state_cell (){
            text.text = "Bruce Wayne AKA know as the Batman has just awaken in the Santa Prisca Prison after being trapped there by Bane"+
            "Batman has been injured and now has to train from having his back broken by Bane."+
            "Soon after he regains enough strength to train he meets Bane's former teach Lady Shiva who agrees to train"+
            "Batman in the martial arts. She soon gives him an intense training regimen which he begins instantly. \n\n"+
            "Press L to Practice Pull Ups, U To Practice Push Ups, C to Practice Crunches and Q to Practice Squats, R To Rest or Press F"+
            " if you have are strong enough to escape now.";

            if(Input.GetKeyDown(KeyCode.L)){
            myState = States.pull_ups;

            }else if (Input.GetKeyDown(KeyCode.U)){
            myState = States.push_ups;
            }else if (Input.GetKeyDown(KeyCode.Q)){
            myState = States.squats;
            }else if (Input.GetKeyDown(KeyCode.C)){
            myState = States.crunches;
            }else if (Input.GetKeyDown(KeyCode.F)){
            myState = States.freedom;
            }

        }
        void state_push_ups(){
        text.text = "Today you chosen training consists of 1000 Push ups.\n\n"+
                    "Press R to return to your cell and rest";

            if(Input.GetKeyDown(KeyCode.R)){
            myState = States.cell;

            }

        }
        void state_pull_ups(){
        text.text = "Its time to focus on developing your over all back and core strength and you perform 1000 Pullups.\n\n"+
                    "Press R to return to your cell and rest";

            if(Input.GetKeyDown(KeyCode.R)){
            myState = States.cell;
            }

           }
        void state_squats(){
        text.text = " You understand that a truly powerful body requires strong legs and you have chosen to do 1000 Squats.\n\n"+
                    "Press R to return to your cell and rest";

            if(Input.GetKeyDown(KeyCode.R)){
            myState = States.cell;
            }


        }
    void state_crunches(){
        text.text = "Core and abdominal work is a fundamental of all training and its time for 1000 Crunches.\n\n"+
                    "Press R to return to your cell and rest";

            if(Input.GetKeyDown(KeyCode.R)){
            myState = States.cell;
            }


        }
		void state_freedom(){
        text.text = "You've finally done it you have trained enough that you can finally escape with Lady Shivas blessing.\n\n"+
                    "Press R to Play the game again";

            if(Input.GetKeyDown(KeyCode.R)){
            myState = States.cell;
            }


        }
    
    }  