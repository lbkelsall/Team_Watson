﻿using UnityEngine;
using System.Collections;

public class CreateNPC : MonoBehaviour {

    /* script used to create all of the NPC's that will be used in the game, all of their responses to all of the posiible personailtes that the playe could be 
     * also will have the types of questioning that the npcs will not like and so will ignore the player from 
     * will also hold the look of the npc's */

    public gameManager Gameman;   //gamemanager

    public GameObject crime;

    public GameObject clues;

    // GAMEOBJECTS OF EACH OF THE NPCS 
    public GameObject Tonald;
    public GameObject Bernard;
    public GameObject George;
    public GameObject Ethan;
    public GameObject Ryan;
    public GameObject Zoe;
    public GameObject Alice;
    public GameObject Sophie;
    public GameObject Stephen;
    public GameObject Robert;


    // NPCS PF NPC TYPE WITH THEIR NAMES 
    public NPC Tonald_Dump ;    //TEST NAME 
    public NPC Bernard_lowe ;  // test name 
    public NPC George_allen;   // test name 
    public NPC Ethan_hawk ;    // test name 
	public NPC Ryan_Smith;
	public NPC Zoe_Williams;
	public NPC Alice_Davis;
	public NPC Sophie_Aaron;
	public NPC Stephen_Brown;
	public NPC Robert_Henry;

    // NPC LOOKS 
    public SpriteRenderer tonald_look;  // for the look of the NPC
    public SpriteRenderer bernard_look;
    public SpriteRenderer george_look;
    public SpriteRenderer ethan_look;
	public SpriteRenderer ryan_look;
	public SpriteRenderer zoe_look;
	public SpriteRenderer alice_look;
	public SpriteRenderer sophie_look;
	public SpriteRenderer stephen_look;
	public SpriteRenderer robert_look;

    // lists for selecting a murder and a victim
    public NPC[] npc_list_ = new NPC[10];        
    public NPC[] npc_list_vic_ = new NPC[9];      // list with all npcs who are not the victim
    public NPC[] npc_list_mur_vic = new NPC[8];   // list without victim and murder

    // lists needed for creating the room allocation 
    public GameObject[] gameobjectlst_ = new GameObject[10];       
    public GameObject[] gameobjectlstshuffle_ = new GameObject[10];
   

    public void setNCPS() // method to access the NPC script of each game object of the NPC so it can be modifed to make each one unique 
    {
        Tonald_Dump = Tonald.GetComponent<NPC>();
        tonald_look = Tonald.GetComponent<SpriteRenderer>();    // to set the look 

        Bernard_lowe = Bernard.GetComponent<NPC>();
        bernard_look = Bernard.GetComponent<SpriteRenderer>();   

        George_allen = George.GetComponent<NPC>();
        george_look = George.GetComponent<SpriteRenderer>();

        Ethan_hawk = Ethan.GetComponent<NPC>();
        ethan_look = Ethan.GetComponent<SpriteRenderer>();

		Ryan_Smith = Ryan.GetComponent<NPC>();
        ryan_look = Ryan.GetComponent<SpriteRenderer>();

        Zoe_Williams = Zoe.GetComponent<NPC>();
        zoe_look = Zoe.GetComponent<SpriteRenderer>();

        Alice_Davis = Alice.GetComponent<NPC>();
        alice_look = Alice.GetComponent<SpriteRenderer>();

        Sophie_Aaron = Sophie.GetComponent<NPC>();
        sophie_look = Sophie.GetComponent<SpriteRenderer>();

        Stephen_Brown = Stephen.GetComponent<NPC>();
        stephen_look = Stephen.GetComponent<SpriteRenderer>();

        Robert_Henry = Robert.GetComponent<NPC>();
        robert_look = Robert.GetComponent<SpriteRenderer>();
    }

	public void make_tonald()   // set of tonalds attibutes to make his personailty
	{
		// basic setup
		Tonald_Dump.Name = "Tonald"; // HAS TO BE THE FIRST NAME ONLY AS IT MATCHES TE TAG OF THE PLAYER 
		Tonald_Dump.intro = "I am the manager of Ron Cooke Hub.";
		tonald_look.sprite = Tonald_Dump.look;    //look set from the sprite added to game object
		Tonald_Dump.he_she = "he";  // he or she
		// bad cop responses 
		Tonald_Dump.aggressive_response = "Dont talk to me like that!";
		Tonald_Dump.violent_response = "violent response";
		Tonald_Dump.threaten_response = "DON'T THREATEN ME! dont talk to me again!";                 // GOOD COP AND BAD COP NEED FIXING AS ONLY HAVING 
		Tonald_Dump.arrogant_response = "I don't want to waste my time on you!";
		Tonald_Dump.indifferent_response = "It's none of my business.";
		//good cop responses 
		Tonald_Dump.kind_response = "fucking nice mate";
		Tonald_Dump.friendly_response = "I can give you all the clues I have.";
		Tonald_Dump.enthusiastic_response = "I'm glad to help!"; // add clue
		Tonald_Dump.humorous_response = "It feels like a detective movie!";
		Tonald_Dump.sympthetic_response = "I fell sorry for what has happened today.";
		// no more interaction set up 
		Tonald_Dump.dont_interact_response = "IM not talking to you anymore";
		Tonald_Dump.dont_interact_if1 = Tonald_Dump.threaten_response;       // Tonald wont interact if he is questioned 'threaten or violent'
		Tonald_Dump.dont_interact_if2 = Tonald_Dump.violent_response;
	}

	public void make_bernard()   // set bernards 
	{
		//basic setup
		Bernard_lowe.Name = "Bernard";
		Bernard_lowe.intro = "My name is bernard. You have to try my food!";
		bernard_look.sprite = Bernard_lowe.look;
		Bernard_lowe.he_she = "he";   // he or she
		//badcop setup
		Bernard_lowe.aggressive_response = "Dont talk to me like that you fuck I'm Bernard !";
		Bernard_lowe.violent_response = "I'm a violent bernard";
		Bernard_lowe.threaten_response = "I dont appreiacte being theatened! dont ask me anymore!";
		Bernard_lowe.arrogant_response = "I don't want to waste my time on you!";
		Bernard_lowe.indifferent_response = "It's none of my business.";
		//goodcop setup 
		Bernard_lowe.kind_response = "fucking nice mate";
		Bernard_lowe.friendly_response = "I can give you all the clues I have.";
		Bernard_lowe.enthusiastic_response = "I'm glad to help!"; // add clue
		Bernard_lowe.humorous_response = "It feels like a detective movie!";
		Bernard_lowe.sympthetic_response = "I fell sorry for what has happened today.";
		//no more interaction setup
		Bernard_lowe.dont_interact_response = "I no longer wish to speak to you!";
		Bernard_lowe.dont_interact_if1 = Bernard_lowe.threaten_response;
	}



	public void make_George()
	{
		George_allen.Name = "George";
		George_allen.intro = "I have lots of first-hand news from all around the world!";
		george_look.sprite = George_allen.look;
		George_allen.he_she = "he";
		//badcop setup
		George_allen.aggressive_response = "Dont talk to me like that you fuck I'm Bernard !";
		George_allen.violent_response = "I'm a violent bernard";
		George_allen.threaten_response = "I dont appreiacte being theatened! dont ask me anymore!";
		George_allen.arrogant_response = "I don't want to waste my time on you!";
		George_allen.indifferent_response = "It's none of my business.";
		//goodcop setup 
		George_allen.kind_response = "fucking nice mate";
		George_allen.friendly_response = "I can give you all the clues I have.";
		George_allen.enthusiastic_response = "I'm glad to help!"; // add clue
		George_allen.humorous_response = "It feels like a detective movie!";
		George_allen.sympthetic_response = "I fell sorry for what has happened today.";
		//no more interaction setup
		George_allen.dont_interact_response = "I no longer wish to speak to you!";
		George_allen.dont_interact_if1 = Bernard_lowe.threaten_response;
	}



	public void make_Ethan()
	{
		Ethan_hawk.Name = "Ethan";
		Ethan_hawk.intro = "I will have my own Ferrari someday!";
		ethan_look.sprite = Ethan_hawk.look;
		Ethan_hawk.he_she = "he";
		//badcop setup
		Ethan_hawk.aggressive_response = "Dont talk to me like that you fuck I'm Bernard !";
		Ethan_hawk.violent_response = "I'm a violent bernard";
		Ethan_hawk.threaten_response = "I dont appreiacte being theatened! dont ask me anymore!";
		Ethan_hawk.arrogant_response = "I don't want to waste my time on you!";
		Ethan_hawk.indifferent_response = "It's none of my business.";
		//goodcop setup 
		Ethan_hawk.kind_response = "fucking nice mate";
		Ethan_hawk.friendly_response = "I can give you all the clues I have.";
		Ethan_hawk.enthusiastic_response = "I'm glad to help!"; // add clue
		Ethan_hawk.humorous_response = "It feels like a detective movie!";
		Ethan_hawk.sympthetic_response = "I fell sorry for what has happened today.";
		//no more interaction setup
		Ethan_hawk.dont_interact_response = "I no longer wish to speak to you!";
		Ethan_hawk.dont_interact_if1 = Bernard_lowe.threaten_response;
	}



	public void make_Ryan()
	{
		Ryan_Smith.Name = "Ryan";
		Ryan_Smith.intro = "I'm Ryan_Smith, and I'm a lawyer";
		ryan_look.sprite = Ryan_Smith.look;
		Ryan_Smith.he_she = "he";
		//badcop setup
		Ryan_Smith.aggressive_response = "Dont talk to me like that you fuck I'm Bernard !";
		Ryan_Smith.violent_response = "I'm a violent bernard";
		Ryan_Smith.threaten_response = "I dont appreiacte being theatened! dont ask me anymore!";
		Ryan_Smith.arrogant_response = "I don't want to waste my time on you!";
		Ryan_Smith.indifferent_response = "It's none of my business.";
		//goodcop setup 
		Ryan_Smith.kind_response = "fucking nice mate";
		Ryan_Smith.friendly_response = "I can give you all the clues I have.";
		Ryan_Smith.enthusiastic_response = "I'm glad to help!"; // add clue
		Ryan_Smith.humorous_response = "It feels like a detective movie!";
		Ryan_Smith.sympthetic_response = "I fell sorry for what has happened today.";
		//no more interaction setup
		Ryan_Smith.dont_interact_response = "I no longer wish to speak to you!";
		Ryan_Smith.dont_interact_if1 = Bernard_lowe.threaten_response;
	}

	public void make_Zoe()
	{
		Zoe_Williams.Name = "Zoe";
		Zoe_Williams.intro = "Go to talk with my agent.";
		zoe_look.sprite = Zoe_Williams.look;
		Zoe_Williams.he_she = "she";
		//badcop setup
		Zoe_Williams.aggressive_response = "Dont talk to me like that you fuck I'm Bernard !";
		Zoe_Williams.violent_response = "I'm a violent bernard";
		Zoe_Williams.threaten_response = "I dont appreiacte being theatened! dont ask me anymore!";
		Zoe_Williams.arrogant_response = "I don't want to waste my time on you!";
		Zoe_Williams.indifferent_response = "It's none of my business.";
		//goodcop setup 
		Zoe_Williams.kind_response = "fucking nice mate";
		Zoe_Williams.friendly_response = "I can give you all the clues I have.";
		Zoe_Williams.enthusiastic_response = "I'm glad to help!"; // add clue
		Zoe_Williams.humorous_response = "It feels like a detective movie!";
		Zoe_Williams.sympthetic_response = "I fell sorry for what has happened today.";
		//no more interaction setup
		Zoe_Williams.dont_interact_response = "I no longer wish to speak to you!";
		Zoe_Williams.dont_interact_if1 = Bernard_lowe.threaten_response;
	}
	public void make_Alice()
	{
		Alice_Davis.Name = "Alice";
		Alice_Davis.intro = "I'm Zoe's agent, can I help you?";
		alice_look.sprite = Alice_Davis.look;
		Alice_Davis.he_she = "she";
		//badcop setup
		Alice_Davis.aggressive_response = "Dont talk to me like that you fuck I'm Bernard !";
		Alice_Davis.violent_response = "I'm a violent bernard";
		Alice_Davis.threaten_response = "I dont appreiacte being theatened! dont ask me anymore!";
		Alice_Davis.arrogant_response = "I don't want to waste my time on you!";
		Alice_Davis.indifferent_response = "It's none of my business.";
		//goodcop setup 
		Alice_Davis.kind_response = "fucking nice mate";
		Alice_Davis.friendly_response = "I can give you all the clues I have.";
		Alice_Davis.enthusiastic_response = "I'm glad to help!"; // add clue
		Alice_Davis.humorous_response = "It feels like a detective movie!";
		Alice_Davis.sympthetic_response = "I fell sorry for what has happened today.";
		//no more interaction setup
		Alice_Davis.dont_interact_response = "I no longer wish to speak to you!";
		Alice_Davis.dont_interact_if1 = Bernard_lowe.threaten_response;
	}

	public void make_Sophie()
	{
		Sophie_Aaron.Name = "Sophie";
		Sophie_Aaron.intro = "I'm working in the hub as a waitress.";
		sophie_look.sprite = Sophie_Aaron.look;
		Sophie_Aaron.he_she = "she";
		//badcop setup
		Sophie_Aaron.aggressive_response = "Dont talk to me like that you fuck I'm Bernard !";
		Sophie_Aaron.violent_response = "I'm a violent bernard";
		Sophie_Aaron.threaten_response = "I dont appreiacte being theatened! dont ask me anymore!";
		Sophie_Aaron.arrogant_response = "I don't want to waste my time on you!";
		Sophie_Aaron.indifferent_response = "It's none of my business.";
		//goodcop setup 
		Sophie_Aaron.kind_response = "fucking nice mate";
		Sophie_Aaron.friendly_response = "I can give you all the clues I have.";
		Sophie_Aaron.enthusiastic_response = "I'm glad to help!"; // add clue
		Sophie_Aaron.humorous_response = "It feels like a detective movie!";
		Sophie_Aaron.sympthetic_response = "I fell sorry for what has happened today.";
		//no more interaction setup
		Sophie_Aaron.dont_interact_response = "I no longer wish to speak to you!";
		Sophie_Aaron.dont_interact_if1 = Bernard_lowe.threaten_response;
	}

	public void make_Stephen()
	{
		Stephen_Brown.Name = "Stephen";
		Stephen_Brown.intro = "I'll become a millionaire!";
		stephen_look.sprite = Stephen_Brown.look;
		Stephen_Brown.he_she = "he";
		//badcop setup
		Stephen_Brown.aggressive_response = "Dont talk to me like that you fuck I'm Bernard !";
		Stephen_Brown.violent_response = "I'm a violent bernard";
		Stephen_Brown.threaten_response = "I dont appreiacte being theatened! dont ask me anymore!";
		Stephen_Brown.arrogant_response = "I don't want to waste my time on you!";
		Stephen_Brown.indifferent_response = "It's none of my business.";
		//goodcop setup 
		Stephen_Brown.kind_response = "fucking nice mate";
		Stephen_Brown.friendly_response = "I can give you all the clues I have.";
		Stephen_Brown.enthusiastic_response = "I'm glad to help!"; // add clue
		Stephen_Brown.humorous_response = "It feels like a detective movie!";
		Stephen_Brown.sympthetic_response = "I fell sorry for what has happened today.";
		//no more interaction setup
		Stephen_Brown.dont_interact_response = "I no longer wish to speak to you!";
		Stephen_Brown.dont_interact_if1 = Bernard_lowe.threaten_response;
	}

	public void make_Robert()
	{
		Robert_Henry.Name = "Robert";
		Robert_Henry.intro = "I can give you the best advice on your issue!";
		robert_look.sprite = Robert_Henry.look;
		Robert_Henry.he_she = "he";
		//badcop setup
		Robert_Henry.aggressive_response = "Dont talk to me like that you fuck I'm Bernard !";
		Robert_Henry.violent_response = "I'm a violent bernard";
		Robert_Henry.threaten_response = "I dont appreiacte being theatened! dont ask me anymore!";
		Robert_Henry.arrogant_response = "I don't want to waste my time on you!";
		Robert_Henry.indifferent_response = "It's none of my business.";
		//goodcop setup 
		Robert_Henry.kind_response = "fucking nice mate";
		Robert_Henry.friendly_response = "I can give you all the clues I have.";
		Robert_Henry.enthusiastic_response = "I'm glad to help!"; // add clue
		Robert_Henry.humorous_response = "It feels like a detective movie!";
		Robert_Henry.sympthetic_response = "I fell sorry for what has happened today.";
		//no more interaction setup
		Robert_Henry.dont_interact_response = "I no longer wish to speak to you!";
		Robert_Henry.dont_interact_if1 = Bernard_lowe.threaten_response;
	}


	
    



    public void makelst()   //create a list of the npc's
    {
        npc_list_[0] = Tonald_Dump;
        npc_list_[1] = Bernard_lowe;
        npc_list_[2] = George_allen;
        npc_list_[3] = Ethan_hawk;
		npc_list_[4] = Ryan_Smith;
		npc_list_[5] = Zoe_Williams;
        npc_list_[6] = Alice_Davis;
		npc_list_[7] = Sophie_Aaron;
		npc_list_[8] = Stephen_Brown;
        npc_list_[9] = Robert_Henry;
    }


    public void makegameobjectlst()   // make the gameobjet list 
    {
        gameobjectlst_[0] = Tonald;
        gameobjectlst_[1] = Bernard;
        gameobjectlst_[2] = George;
        gameobjectlst_[3] = Ethan;
        gameobjectlst_[4] = Ryan;
        gameobjectlst_[5] = Zoe;
        gameobjectlst_[6] = Alice;
        gameobjectlst_[7] = Sophie;
        gameobjectlst_[8] = Stephen;
        gameobjectlst_[9] = Robert;
    }






    public void set_murderer_and_victim_crime()  //sets a NPC to be ther murder and a differnt npc to be the victim 
    {
        
        crime.GetComponent<CreateCrime>().select_crime();   // make the crime selection 

       // Debug.Log(crime.GetComponent<CreateCrime>().murder_int); // DEBUGGING PURPOSES

        if (crime.GetComponent<CreateCrime>().murder_int == 1)  // drowned 
        {
            Debug.Log("Did we take the drowned murder path: " + true);
            gameobjectlstshuffle_[6].GetComponent<NPC>().is_Victim();
            Gameman.GetComponent<gameManager>().set_victim(gameobjectlstshuffle_[6].GetComponent<NPC>());  // store data 
        }
        else if (crime.GetComponent<CreateCrime>().murder_int == 2) // pushed off lakehouse
        {
            gameobjectlstshuffle_[9].GetComponent<NPC>().is_Victim();
            Gameman.GetComponent<gameManager>().set_victim(gameobjectlstshuffle_[9].GetComponent<NPC>());  // store data 

        } else
        {
            Debug.Log(false);
            int x = Random.Range(0, 10);       // random number between 0 and 9
            npc_list_[x].is_Victim();
            Gameman.GetComponent<gameManager>().set_victim(npc_list_[x]);  // store data 

        }

        lst_no_victim();                   // create list of all other npcs who arent the victim 

        int y = Random.Range(0, 9);       // random number between 0 and 9
        npc_list_vic_[y].isMurder();           // get npc at x in the array and set to muderer
        Gameman.GetComponent<gameManager>().set_murder(npc_list_vic_[y]);    // store data in game manager 
        
    }

    public void lst_no_victim()   // creates a list of all other npcs who are not the victim. --> called in fucntion set_murder_and_victim()
    {
        int y = 0;
        for (int x =0; x < npc_list_.Length; x++)
        {
            if (npc_list_[x].is_victim == false)
            { 
                npc_list_vic_[y] = npc_list_[x];
                y++;
            } else
                ;
        }
    }

    public void list_no_vic_murder()
    {
        int x = 0;
        for (int y = 0; y < npc_list_vic_.Length; y++)
        {
            if (npc_list_vic_[y].is_muderer == false)
            {
                npc_list_mur_vic[x] = npc_list_vic_[y];
                x++;
            } else
            {
                ;
            }
        }

    }



   



    public void shuffle_lst()    // prodcues a shuffled list of all the npcs; --> used in the setroom() as it ensures they will be placed randomly into a room each time the game is loaded.  
    {
        for(int x =0; x<gameobjectlst_.Length;x++)     
        {
            int y = Random.Range(0, 10);
            while (gameobjectlstshuffle_[y] != null)    // while the element in the array gameobjectlstshuffle is empty put a random element y into it from gameobjectlst
            {                                           // otherwise keep randomising the element for y untill a space is found. 
                y = Random.Range(0, 10);
            }
            gameobjectlstshuffle_[y] = gameobjectlst_[x];

        }
    }



   

    public void setroom()
    {
        Gameman.GetComponent<gameManager>().setroom11(gameobjectlstshuffle_[0]);   //set the npc in room 1 pos 1 to shuffled index 0. 
        gameobjectlstshuffle_[0].GetComponent<NPC>().room = "Room1";
        Gameman.GetComponent<gameManager>().setroom12(gameobjectlstshuffle_[1]);
        gameobjectlstshuffle_[1].GetComponent<NPC>().room = "Room1";
        Gameman.GetComponent<gameManager>().setroom21(gameobjectlstshuffle_[2]);
        gameobjectlstshuffle_[2].GetComponent<NPC>().room = "Room2";
        Gameman.GetComponent<gameManager>().setroom31(gameobjectlstshuffle_[3]);
        gameobjectlstshuffle_[3].GetComponent<NPC>().room = "Room3";
        Gameman.GetComponent<gameManager>().setroom41(gameobjectlstshuffle_[4]);
        gameobjectlstshuffle_[4].GetComponent<NPC>().room = "Room4";
        Gameman.GetComponent<gameManager>().setroom51(gameobjectlstshuffle_[5]);
        gameobjectlstshuffle_[5].GetComponent<NPC>().room = "Room5";
        Gameman.GetComponent<gameManager>().setroom61(gameobjectlstshuffle_[6]);
        gameobjectlstshuffle_[6].GetComponent<NPC>().room = "Room6";
        Gameman.GetComponent<gameManager>().setroom71(gameobjectlstshuffle_[7]);
        gameobjectlstshuffle_[7].GetComponent<NPC>().room = "Room7";
        Gameman.GetComponent<gameManager>().setroom72(gameobjectlstshuffle_[8]);       
        gameobjectlstshuffle_[8].GetComponent<NPC>().room = "Room7";
        Gameman.GetComponent<gameManager>().setroom81(gameobjectlstshuffle_[9]);
        gameobjectlstshuffle_[9].GetComponent<NPC>().room = "Room8";
        
    }   



    public void Make_NPC() // called when initilased so to create all of the NPC's 
    {
        setNCPS();         // set the gameobjects to the corect npc

        make_tonald();     // make all of the npcs and sets them to the objects. 
        make_bernard();
        make_Ethan();
        make_George();
        make_Ryan();
        make_Zoe();
        make_Alice();
        make_Sophie();
        make_Stephen();
        make_Robert();

        makelst();                  // make the lists 
        makegameobjectlst();
           

        shuffle_lst();                  //creates a shuffled list 

        setroom();                      // sets the npcs to a room

        set_murderer_and_victim_crime();      // pick the crime that will take place and vicim according, also select murderer 


        crime.GetComponent<CreateCrime>().create_crime();  // around the crime selected set all of the............
        list_no_vic_murder();       // create a list of only NPC's who are not the murderer or the victim
        clues.GetComponent<createClue>().makeClues();   // make the clues for the game.... 
        
    }

   




    // Use this for initialization
    void Start() {
        Make_NPC();
        Debug.Log("the murderer is: " + Gameman.GetComponent<gameManager>().get_murder());
        Debug.Log("the victim is: " + Gameman.GetComponent<gameManager>().get_victim());
        
    }


	
	// Update is called once per frame
	void Update () {
	
	}
}
