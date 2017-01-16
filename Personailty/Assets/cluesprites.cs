﻿using UnityEngine;
using System.Collections;

public class cluesprites : MonoBehaviour {

    public Sprite Dagger;
    public Sprite meatclever;
    public Sprite ruler;
    public Sprite tophat;
    public Sprite beanie;
    public Sprite flatcap;
    public Sprite cloth;
    public Sprite note;
    public Sprite pen;

    public Sprite cricket;
    public Sprite gloves;
    public Sprite present;
    public Sprite shoes;

    public Sprite jacket;
    public Sprite watch;
    public Sprite pocketwatch;
    public Sprite torncloth;
    public Sprite clipboard;

    public Sprite scarf;
    public Sprite pendant;
    public Sprite ring;
    public Sprite coin;

    public Sprite emptybottle;
    public Sprite flask;
    public Sprite sword;
    public Sprite lid;


    public Sprite getsprites_murder1(string clue)
    {
        switch (clue)
        {
            case ("Flick Knife"):
                return Dagger;
            case ("Meat Clever"):
                return meatclever;
            case ("Sharpened Metal Ruler"):
                return ruler;
            case ("Top Hat"):
                return tophat;
            case ("flat cap"):
                return flatcap;
            case ("beanie"):
                return beanie;
            case ("cloth with blood on"):
                return cloth;
            case ("Hand written note to Victim"):
                return note;
            default:
                return pen;
        }
    }

    public Sprite getsprites_murder2(string clue)
    {
        switch (clue)
        {
            case ("Flick Knife"):
                return Dagger;
            case ("Criket Bat"):
                return cricket;
            case ("A set of wet Ron Cooke HUB janitor gloves"):
                return gloves;
            case ("A Note"):
                return note;
            case ("A Present"):
                return present;
            case ("A pair of shoes with damp mud over the front"):
                return shoes;
            default:
                return pen;
        }
    }

    public Sprite getsprites_murder3(string clue)
    {
        switch (clue)
        {
            case ("Handkerchief"):
                return cloth;
            case ("Jacket"):
                return jacket;
            case ("coin sack"):
                return coin;
            case ("wacth"):
                return watch;
            case ("pocket watch"):
                return pocketwatch;
            case ("torn cloth"):
                return torncloth;
            case ("Clipboard"):
                return clipboard;
            default:
                return clipboard;         
        }
    }



    public Sprite getsprites_murder4(string clue)
    {
        switch (clue)
        {
            case ("Streched Red Scarf"):
                return scarf;
            case ("A note to the victim"):
                return note;
            case ("Pendant"):
                return pendant;
            case ("Ring"):
                return ring;
            case ("meat clever"):
                return meatclever;
            case ("dagger"):
                return Dagger;
            case ("coin sack"):
                return coin;
            case ("top hat"):
                return tophat;
            case ("beanie"):
                return beanie;
            default:
                return ring;
               
        }
    }

    public Sprite getsprites_murder5(string clue)
    {
        switch (clue)
        {
            case ("A note"):
                return note;
            case ("Empty bottle"):
                return emptybottle;
            case ("Flask"):
                return flask;
            case ("Black fountain pen"):
                return pen;
            case ("dagger"):
                return Dagger;
            case ("sword"):
                return sword;
            case ("Flask lid"):
                return lid;
            default:
                return note;
        }
    }

    public Sprite getsprites_murder6(string clue)
    {
        return pen;
    }

    

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
