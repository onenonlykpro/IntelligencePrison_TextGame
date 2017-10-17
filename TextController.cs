using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

	public Text text;
	
	private enum States {office_0, desk_0, consult_0, office_1, desk_1, office_2};
	private States myState;

	// Use this for initialization
	void Start () {
		myState = States.desk_0;
	}
	
	// Update is called once per frame
	void Update () {
		if (myState == States.desk_0) {
			state_desk_0();
		}
		else if (myState == States.office_0) {
			state_office_0();
		}
		else if (myState == States.office_1) {
			state_office_1();
		}
		else if (myState == States.office_2) {
			state_office_2();
		}
		else if (myState == States.desk_1) {
			state_desk_1();
		}
		else if (myState == States.consult_0) {
			state_consult_0();
		}
	}
	
	// Starting scene at desk
	void state_desk_0 () {
		text.text = "You are an intelligence analyst building a market research " +
		"program at a rising start up. Your boss has proven to be an information " +
		"bottleneck, and the CEO is overly sensitive to bad news. Frustrated with " +
		"the company's internal flaws, you look for an alternative. You can either " +
		"talk to your boss about more autonomy (T), remain at your job and vent to " +
		"your coworkers (V), or quit your job and try consulting (Q).\n\n" + 
		"Press the corresponding letter key to make your choice.";
		
		if (Input.GetKeyDown(KeyCode.T)) {
			myState = States.office_0;
		}
		else if (Input.GetKeyDown(KeyCode.V)) {
			myState = States.desk_1;
		}
		else if (Input.GetKeyDown(KeyCode.Q)) {
			myState = States.consult_0;
		}
	}
	
	// Starting scene at in office to talk with boss
	void state_office_0 () {
		text.text = "Despite you carefully planning your words, the conversation with " +
		"your boss is not going well. She reminds you that you would not 'be here' " +
		"if it weren't for her bring you onboard. She demands explicit examples of " +
		"of her management style causing delays in your work circulating through the " +
		"executive team - which you have at least 10. \n\nDo you take a cue from her " +
		"behavior and drop the issue (D) or calmly list every instance in which her " +
		"overbearing management style has slowed you down (L).";
		
		if (Input.GetKeyDown(KeyCode.D)) {
			myState = States.office_1;
		}
		else if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.office_2;
		}
	}
	
	// Ending scene at in office talking with boss
	void state_office_1 () {
		text.text = "You drop the issue, but your boss never lets it go.  She actually " +
		"becomes increasingly overbearing, and your intelligence is shared less and " +
		"less. Your reputation in the company degrades, and your position is " +
		"in the next fiscal year budget.\n\n Press the Space bar to play again.";
		
		if (Input.GetKeyDown(KeyCode.Space)) {
			myState = States.desk_0;
		}
	}
	
	// Alternate ending scene at in office talking with boss
	void state_office_2 () {
		text.text = "You calmy list three instances in which your boss's management " +
		"style has indeed impeded your ability to get actionable intelligence to the " +
		"executive team. She claims she will look into it and the meeting ends. " +
		"Two weeks later, you notice your position is posted on the company's LinkedIn " + 
		"page. You take the hint, and resign.\n\n Press the Space bar to play again.";
		
		if (Input.GetKeyDown(KeyCode.Space)) {
			myState = States.desk_0;
		}
	}
	
	// Scene venting at coworkers
	void state_desk_1 () {
		text.text = "You begin to vent with your office mates about your frustrations. " +
		"It doesn't take long before your office mates also begin to voice their " +
		"complaints about the exectuive leadership in the company. Your office mates " +
		"job hunt in their off-time and both find employment elsewhere only a month later. Consequently, you " +
		"are pressured to work longer hours as the company struggles to find new talent, " +
		"thanks to the numerous negative Glassdoor reviews that suddenly accumulate. \n\n" +
		"Press the Space bar to play again.";
		
		if (Input.GetKeyDown(KeyCode.Space)) {
			myState = States.desk_0;
		}
	}
	
	// Scene for consulting
	void state_consult_0 () {
		text.text = "You hand in your two weeks' notice, and begin to market yourself in " +
		"the gig economy. While your last company begins to fail due to its internal flaws, "+
		"you start to build up a reputation by completing smaller, low paying intelligence " +
		"projects through UpWork and LinkedIn Profinder. You quickly gather great reviews " +
		"and move on to higher paying consulting gigs. You register your own business " +
		"and continue successfully as a trustworthy intelligence and strategy consultant. " +
		"\n\n Press the Space bar to play again.";
		
		if (Input.GetKeyDown(KeyCode.Space)) {
			myState = States.desk_0;
		}
	}
			
}
