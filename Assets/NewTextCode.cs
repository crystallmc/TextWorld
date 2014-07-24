using UnityEngine;
using System.Collections;

public class NewTextCode : MonoBehaviour {


	void Start () {
	


	}

	string  currentroom = "bedroom";
	bool hasbalconykey =false;
	bool hasbugspray=false;

	void Update () {
	//first make a statment to indicate which room the player is in
		string textBuffer= currentroom;

	//now make 'currentroom' a variable, and make the starting room 'bedroom' by putting it outside 'update' scoop
	//now indicate that you want the above code to apply to the text Mesh: see bottom

	//now add more text to appear only when you're in the bedroom
		if (currentroom == "bedroom")
		{
			textBuffer += 
			"\n " +
			"\nYou wake up in a room you've never seen before" +
			"\nYou head hurts so much as if someone hit you with a brick" +
			"\n'What's happened? Where am I?' You ask yourself" +
			"\nThe room is very dim and you're a little scared..." +
			"\n" +
			"\nPress [D] to go to the living room"+
			"\nPress [W] to go to the bathroom"+
			"\nPress [A] to do to the balcony";

			//now add keys for player to navigate
			if(Input.GetKeyDown (KeyCode.W))
			{currentroom= "bathroom";
			}

			if(Input.GetKeyDown (KeyCode.A))
			{currentroom= "balcony";
			}

			if(Input.GetKeyDown(KeyCode.D))
			{currentroom="living room";
			}
		}
	//That's that for the bedroom, now do similar for the bathroom
	
		if (currentroom == "bathroom"){
			Debug.Log ("bathroom");
			textBuffer+=
			"\n" +
			"\nYour found the light switch and turned it on" +
			"\nThe mirror has been broken into pieces" +
			"\nThings are scattered around, almost like a crime scene..." +
			"\nFrom the segments of the mirror you notice you have bruises all over your body" +
			"\n'Oh my God I gotta get outta here' " +
			"\nYou've never been so frightened before" +
			"\n\nPress [S] to return to the bedroom" +
			"\nPress [X] to search the place";

			//now add a key to go back to the bedroom
			if(Input.GetKeyDown(KeyCode.S))
			{currentroom="bedroom";
			}
			if(Input.GetKeyDown (KeyCode.X))
			{currentroom=" ";
			}
		}
	//Now add a room with no name 
		if (currentroom==" "){

			Debug.Log ("carbinet");
			textBuffer+=
			"\n\nYou scrambled the place and found a bug spray..." +
			"\nSelf defense." +
			"\n\nPress [S] to return to the bedroom";

			//and now add key to go back to bedroom again, skip bathroom
			if(Input.GetKeyDown(KeyCode.S))
			{currentroom="bedroom";
			}

			hasbugspray=true;
			
		}


	//again for the balcony
		if (currentroom == "balcony") {
			Debug.Log ("balcony");

			if(hasbalconykey==false){
				textBuffer+=
				"\n\nThe balcony is locked" +
				"\nYou opened the curtains but all you see is a gloomy sky..." +
				"\nWait, is that your phone out there...!??" +
				"\n\nPress [S] to return to the bedroom";
			}
			
			else{
				textBuffer+= 
				"\nYou finally unlocked the balcony and got you phone!" +
				"\nBut hold on...it's soaked!" +
				"\nSay goodbye to your iPhone5" +
				"\nYou totally deserved it. " +
				"\n\nHope you liked my game!";
			}

		


			//now add a key to go back to the bedroom
			if(Input.GetKeyDown(KeyCode.S))
			{currentroom="bedroom";
			}
		}

	//and again for the living room
		if (currentroom == "living room") 
		{
			Debug.Log("living room");

			if(hasbugspray==false){
			textBuffer+=
			"\n\nYou want to get out of what seems to be the living room " +
			"\nbut there's a giant bug on the door nob that wouldn't go away..." +
			"\nCan you kill it with something...?" +
			"\n\nPress[S] to return to the bedroom";

				//This KeyCode has to in inside the scoop of "hasbugspray"
				//otherwise the 'else' statement below will show...WHY??
				if(Input.GetKeyDown(KeyCode.S))
				{currentroom="bedroom";
				}

			}



			else{
			textBuffer += 
			"\n " +
			"\nYou successfully killed the bug from afar, " +
			"\nit fell onto the floor and you carefully step outside" +
			"\nYou see a table and on top, a glass of water and a note beside that says:" +
			"\n\n'Dude you were so drunk last night, you went crazy!" +
			"\nYou smashed my mirror and demanded that your phone to be locked outside for some reason..." +
			"\nHere's the key to the balcony, I'm off to work now, sober up and gimme a call!!" +
			"\nLove," +
			"\nCrystal" +
			"\n " +
			"\nPS: You're heavier than you look... Sorry for dropping you from the stairs last night" +
			"\nHope you survive.'" +
			"\n\nSH*T!!!" +
			"\n\nYou gotta call your poor friend" +
			"\nGo unlock the balcony and get your phone!"+
			"\nPress [S] to return to the bedroom";

			hasbalconykey=true;
			
			}



			if(Input.GetKeyDown(KeyCode.S))
			{currentroom = "bedroom";
			}



		}
		
		
		
		
		
		
		
		
		
		
		

		//This line of code must be put inside UPDATE scoop and BENEATH ALL "TEXTBUFFER" CODES
		GetComponent<TextMesh> ().text = textBuffer;

	}
}
