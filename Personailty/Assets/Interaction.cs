﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Interaction : MonoBehaviour {

    public GameObject Player;
    public GameObject gameman;
    public GameObject logbookpart;
    public GameObject npcobj;
    public gameManager Gamemanager;
    public player player;
    public NPC npc;

    public Text speachbox ;                // The speach box 

    public Button question;        // Where the player can input their choices
    public Button accusebutt;      // accuse button 
    public Button questioingtype1;
    public Button questioingtype2;
    public Button questioingtype3;

    public GameObject head_shot; 

  
    public string question_style_text;

    public int incorrect_aac_num = 0;   // the number of inncorrect gusses. if 2 or more you lose 


    public void setNPC(NPC npcin)
    {
        npc = npcin;

    }

    public void setNPCobj(GameObject npcob)
    {
        npcobj = npcob;
    }
 
	public string npc_response()
	{
		switch(question_style_text)
		{
		case "Aggressive":
			return (npc.aggressive_response);
		
		case "Violent":
			return (npc.violent_response);
			
		case "Threaten":
                return (npc.threaten_response);
			
		case "Kind":
			return (npc.kind_response);
			
		case "Friendly":
			return (npc.friendly_response);
			
		case "Cunning":
			return (npc.cunning_response);
			
		case "Mean":
			return (npc.mean_response);
			
		default:
			return (npc.sympthetic_response);
			
		}
	}

    public void set_orintation()
    {
        if (player.orintation == npc.orintation)
        {
            if (npc.orintation == 1 )
            {
                npcobj.GetComponent<SpriteRenderer>().flipX = true;
                npc.orintation = 0;
            } else
            {
                npc.orintation = 1;
                npcobj.GetComponent<SpriteRenderer>().flipX = false;
            }
        }

    }


    public void pick_interaction()
    {
       

        if (npc.is_victim == true)
        {

            speachbox.text = "the Body has been placed in a bag and taped off - probably best";

        }
        else
        {

            head_shot.GetComponent<SpriteRenderer>().sprite = npc.headshot;

            set_orintation();

            if (npc.okay_to_interact == true)

                {

                
                    if (npc.first_interaction == true)
                    {
                        speachbox.text = "Detective " + player.Name + " :  " + player.Personailty.intro;

                        speachbox.text = speachbox.text + "\n\n" + npc.Name + ": " + npc.intro;

                        npc.first_interaction = false;

                        npc = null;
                    }
                    else
                    {
                    
                        speachbox.text = "How would you like to interact:";
                        question.transform.Translate(0, 57, 0);
                        accusebutt.transform.Translate(0, 57, 0);

                    }

                }
                else
                {
                    speachbox.text = npc.name + ": " + npc.dont_interact_response;
                    npc = null;
                }

            }

        } 
        
    


    public void pick_question()
    {
        question.transform.Translate(0, -57, 0);
        accusebutt.transform.Translate(0, -57, 0);
        questioingtype1.transform.Translate(0, 57, 0);
        questioingtype2.transform.Translate(0, 57, 0);
        questioingtype3.transform.Translate(0, 57, 0);
        questioingtype1.GetComponentInChildren<Text>().text = player.Personailty.type1();
        questioingtype2.GetComponentInChildren<Text>().text = player.Personailty.type2();
        questioingtype3.GetComponentInChildren<Text>().text = player.Personailty.type3();
    }


    public void questioing_style1()
    {

        questioingtype1.transform.Translate(0, -57, 0);
        questioingtype2.transform.Translate(0, -57, 0);
        questioingtype3.transform.Translate(0, -57, 0);
        question_style_text = player.Personailty.questiontype1;
        speachbox.text = "Detective " + player.Name + ": " + player.Personailty.Question1();

        if ((question_style_text.Equals(npc.clue_response1) || question_style_text.Equals(npc.clue_response2)) && npc.clue != "")  // checks that the questioing style of the player macthes the one in which the NPC will say thier clue 
        {
            speachbox.text += "\n\n" + npc.Name + ": " + npc.clue;
            logbookpart.GetComponent<logbookparts>().add_clue(npc.clue_object);
            check_okay_to_interact();
            npc = null;
        }
        else
        {
            speachbox.text += "\n\n" + npc.Name + ": " + npc_response();
            check_okay_to_interact();
            npc = null;
        }
    }
    



    public void questioing_style2()
        {

        questioingtype1.transform.Translate(0, -57, 0);
        questioingtype2.transform.Translate(0, -57, 0);
        questioingtype3.transform.Translate(0, -57, 0);
        question_style_text = player.Personailty.questiontype2;
        speachbox.text = "Detective " + player.Name + ": " + player.Personailty.Question2();

        if ((question_style_text.Equals(npc.clue_response1) || question_style_text.Equals(npc.clue_response2)) && npc.clue != "")  // checks that the questioing style of the player macthes the one in which the NPC will say thier clue 
        {
            speachbox.text += "\n\n" + npc.Name + ": " + npc.clue;
            logbookpart.GetComponent<logbookparts>().add_clue(npc.clue_object);
            check_okay_to_interact();

         

            npc = null;
        }
        else
        {
            speachbox.text += "\n\n" + npc.Name + ": " + npc_response();
            check_okay_to_interact();
            npc = null;
        }
    }

    public void questioning_style3()
    {
        questioingtype1.transform.Translate(0, -57, 0);
        questioingtype2.transform.Translate(0, -57, 0);
        questioingtype3.transform.Translate(0, -57, 0);
        question_style_text = player.Personailty.questiontype3;
        speachbox.text = "Detective " + player.Name + ": " + player.Personailty.Question3();

        if ((question_style_text.Equals(npc.clue_response1) || question_style_text.Equals(npc.clue_response2)) && npc.clue != "")  // checks that the questioing style of the player macthes the one in which the NPC will say thier clue 
        {
            speachbox.text += "\n\n" + npc.Name + ": " + npc.clue;
            logbookpart.GetComponent<logbookparts>().add_clue(npc.clue_object);
            check_okay_to_interact();



            npc = null;
        }
        else
        {
            speachbox.text += "\n\n" + npc.Name + ": " + npc_response();
            check_okay_to_interact();
            npc = null;
        }
    }

    public void check_okay_to_interact()
    {
        if (npc_response().Equals(npc.dont_interact_if1) || npc_response().Equals(npc.dont_interact_if2) || npc_response().Equals(npc.dont_interact_if3))
        {
            npc.okay_to_interact = false;
        }
        else
        {
            npc.okay_to_interact = true;
        }
    }


             

    public void accuse()
    {
        question.transform.Translate(0, -57, 0);
        accusebutt.transform.Translate(0, -57, 0);
        if (Gamemanager.get_clue_count() < 3)
        {
            speachbox.text = "You need to have found at least three clues before you can accuse soemone! \n\n You must be new to detective work";
            npc = null;
        } else
        {
            if (npc.Name == Gamemanager.get_murder())
            {
                Debug.Log("YOU WIN");
                GameObject.FindWithTag("GUI").GetComponent<timer>().testFalse();   // set the timer to false so it stops
                destory_objects();
                SceneManager.LoadScene("win");
                npc = null;
            }
            else
            {
                speachbox.text = npc.Name + ": "+ npc.incorect_accusation;
                incorrect_aac_num++;
                npc.okay_to_interact = false;
                npc = null;
                if (incorrect_aac_num > 1)
                {
                    Debug.Log("GAME OVER");
                    // load scene lose 
                }
            }
        }

    }



    public void destory_objects()
    {
        string[] objects = {"Player","GUI", "Bernard", "Tonald", "George", "Ethan", "Ryan", "Zoe", "Alice", "Stephen",
        "Robert", "Sophie", "Clue1", "Clue2", "Clue3", "Clue4", "Clue5", "Clue6", "Clue7", "Clue8", "map", "map_icon",
        "log_button","logbook","logbookcrime"};
        for (int i = 0; i < 25; i++)
        {
            Destroy(GameObject.FindWithTag(objects[i]));
        }


    }


    // Use this for initialization
    void Start () {
        Player = GameObject.FindWithTag("Player");          // sets up the player and in the interaction class for each scene 
        player = Player.GetComponent<player>();
        gameman = GameObject.FindWithTag("gamemanager");
        Gamemanager = gameman.GetComponent<gameManager>();
	}
	
	// Update is called once per frame
	void Update () {
        
	
	}
}
