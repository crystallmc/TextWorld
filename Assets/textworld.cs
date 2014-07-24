using UnityEngine;
using System.Collections;

public class textworld : MonoBehaviour {

	// Use this for initialization

	string currentroom = "bedroom";


	void Start () {
	
	}


	void Update () 
	{

		string textBuffer = "You are currently in the " + currentroom;

		if (currentroom == "bedroom") 
		{
			//when in the bedroom, show text
			textBuffer += 
				"\n " +
				"\nYou wake up in a room you've never seen before" +
				"\nYou head hurts so much as if someone hit you with a brick" +
				"\n'What's happened? Where am I?' You ask yourself" +
				"\nThe room is very dim and you're a little scared..." +
				"\n" +
				"\nPress [W] to go to the bathroom"+
				"\nPress [A] to do to the balcony"+
				"\nPress [D] to go to the living room";

			//when press key, navigate
			if(Input.GetKeyDown (KeyCode.W))
			{
				currentroom= "Bathroom";
				Debug.Log ("you're in the Bathroom");
			}

			else if(Input.GetKeyDown(KeyCode.A))
			{
				currentroom="Balcony";
				Debug.Log("you're in the Balcony");
			}

			else if(Input.GetKeyDown (KeyCode.D))
			{
				currentroom= "Living room";
				Debug.Log("you're in the living room");
			}

		}



		// now i can leave the bedroom, but can't go back
		//now i want to do the connect the bathroom, first show text then add key
		if (currentroom == "bathroom")
		{
			textBuffer += 
			"\n" +
			"\nYour found the light switch and turned it on" +
			"\nThe mirror has been broken into pieces" +
			"\nThings are scattered around, almost like a crime scene..." +
			"\nFrom the segments of the mirror you notice you have bruises all over your body" +
			"\n'Oh my God I gotta get outta here' " +
			"\nYou've never been as frightened before" +
			"\n\nPress [S] to return to the bedroom";
			
			if(Input.GetKeyDown(KeyCode.S))
			{
				currentroom = "Bedroom";
			}

		}
		
		
		//Same for living room: show text: You're currently... and add more text onto it
		if (currentroom == "living room") {
			//show text ("textbuffer" is the sentence in line 19)
			textBuffer += "\n " +
					"\nYou see a glass of water on the table and a note beside that says:" +
					"\n\n'Dude you were so drunk last night, you went crazy!" +
					"\nI'm off to work now, sober up and gimme a call!!" +
					"\nLove," +
					"\nCrystal" +
					"\n " +
					"\nPS: You're heavier than you look...'" +
					"\n\n\nSH*T!!!" +
					"\n\nYou gotta call your poor friend who's carried you up all the stairs" +
					"\nGrab your phone, press [S] to return to the bedroom";
			
			if(Input.GetKeyDown(KeyCode.S))
			{
				currentroom = "bedroom";
			}
		}
		
		//now the living room and the bedroom is connected
		//lastly do the balcony
		if(currentroom=="balcony")
		{
			textBuffer += 
				"\n" +
					"\nThe balcony is locked" +
					"\nYou opened the curtains but all you see is a gloomy sky..." +
					"\nPress [S] to return to the bedroom";
			
			if(Input.GetKeyDown(KeyCode.S))
			{
				currentroom = "bedroom";
			}
		}




			




		// the line of code below must be at the bottom of all "textBuffer", but inside 'update' scoop
		GetComponent <TextMesh> ().text = textBuffer;
	}





		

	//right now, my textmesh changes to the first sentence when played. 
	//i want to show instructions to navigate only when the player is in the bedroom

	}

