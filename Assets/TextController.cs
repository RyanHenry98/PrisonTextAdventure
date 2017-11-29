using UnityEngine;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class TextController : MonoBehaviour {
	public Text text;
	public int escapeAttempts;
	private enum States {
		cellstuck,  death_penalty, escape_dig_again, death_penalty_infirmary, trial_stay, escape_attempt_stay, escape_attempt_stay_1, tunnel_stay, tunnel_1_stay, infirmary_stay,
		prison_riot_stay, prison_riot_1_stay, front_gate_stay, fence_escape_stay, infirmary_shot_stay, arrested_loss_stay, hitchhike_stay, hitchhike_loss_stay, escape_guard_stay,
		laundry_stay, darkness_stay, darkness_cont_stay, disguise_stay, disguise_cont_stay, laundry_remain_stay, laundry_haste_stay, laundry_remain_stay_1,
		escape, cell_remain, escape_guard, escape_inmate, escape_inmate_1, escape_dig, laundry, laundry_haste, laundry_remain,
		darkness, darkness_cont, disguise, disguise_cont, embassy, hitchhike, hitchhike_loss, freedom, tunnel, tunnel_1, infirmary, 
		trial, escape_reattempt, escape_reattempt_1, prison_riot, prison_riot_1, infirmary_shot,
		infirmary_arrested, infirmary_arrested_dualfail, trial_arrested, death_penalty_dualfail,
		escape_arrested_reattempt, escape_arrested_stay, escape_arrested_stay_1, escape_arrested_inmate, prison_riot_1_arrested, tunnel_arrested,
		escape_arrested_inmate_1, escape_inmate_stay, escape_inmate_stay_1
		
		
	};
	private States myState;
	// Use this for initialization
	void Start () {
		myState = States.cellstuck;
		escapeAttempts = 0;
	}
	// Update is called once per frame
	void Update () {
		print (myState);
		print (escapeAttempts);
		
		if(escapeAttempts > 1) {myState = States.death_penalty;}
		else {}
		
		//RECURRING METHODS & STATES (USED MANY TIMES)\\
		if (myState == States.cellstuck) {cellstuck();}
		else if (myState == States.death_penalty) {death_penalty();}
		else if (myState == States.escape_dig_again) {escape_dig_again();}
		else if (myState == States.death_penalty_infirmary) {death_penalty_infirmary();}
		
		//TRIAL STAY \\
		else if (myState == States.trial_stay) {trial_stay();}
		else if (myState == States.escape_attempt_stay) {escape_attempt_stay();}
		else if (myState == States.escape_attempt_stay_1) {escape_attempt_stay_1();}
		else if (myState == States.tunnel_stay) {tunnel_stay();}
		else if (myState == States.tunnel_1_stay) {tunnel_1_stay();}
		else if (myState == States.infirmary_stay) {infirmary_stay();}
		else if (myState == States.prison_riot_stay) {prison_riot_stay();}
		else if (myState == States.prison_riot_1_stay) {prison_riot_1_stay();}
		else if (myState == States.front_gate_stay) {front_gate_stay();}
		else if (myState == States.fence_escape_stay) {fence_escape_stay();}
		else if (myState == States.infirmary_shot_stay) {infirmary_shot_stay();}
		else if (myState == States.arrested_loss_stay) {arrested_loss_stay();}
		else if (myState == States.hitchhike_stay) {hitchhike_stay();}
		else if (myState == States.hitchhike_loss_stay) {hitchhike_loss_stay();}
		else if (myState == States.escape_guard_stay) {escape_guard_stay();}
		else if (myState == States.laundry_stay) {laundry_stay();}
		else if (myState == States.darkness_stay) {darkness_stay();}
		else if (myState == States.darkness_cont_stay) {darkness_cont_stay();}
		
		else if (myState == States.disguise_stay) {disguise_stay();}
		else if (myState == States.disguise_cont_stay) {disguise_cont_stay();}
		else if (myState == States.laundry_remain_stay) {laundry_remain_stay();}
		else if (myState == States.laundry_haste_stay) {laundry_haste_stay();}
		else if (myState == States.laundry_remain_stay_1) {laundry_remain_stay_1();}
		
		
		
		else if (myState == States.escape) {escape();}
		
		
		else if (myState == States.escape_inmate) {escape_inmate();}
		else if (myState == States.escape_inmate_1) {escape_inmate_1();}
		else if (myState == States.tunnel) {tunnel();}
		else if (myState == States.tunnel_1) {tunnel_1();}
		else if (myState == States.escape_guard) {escape_guard();}
		else if (myState == States.escape_dig) {escape_dig();}
		
		else if (myState == States.disguise) {disguise();}
		else if (myState == States.disguise_cont) {disguise_cont();}
		else if (myState == States.laundry) {laundry();}
		else if (myState == States.laundry_haste) {laundry_haste();}
		else if (myState == States.laundry_remain) {laundry_remain();}
		else if (myState == States.embassy) {embassy();}
		else if (myState == States.hitchhike) {hitchhike();}
		else if (myState == States.hitchhike_loss) {hitchhike_loss();}
		else if (myState == States.freedom) {freedom();}
		else if (myState == States.darkness) {darkness();}
		else if (myState == States.darkness_cont) {darkness_cont();}
		else if (myState == States.infirmary) {infirmary();}
		else if (myState == States.trial) {trial();}
		else if (myState == States.escape_reattempt) {escape_reattempt();}
		else if (myState == States.escape_reattempt_1) {escape_reattempt_1();}
		else if (myState == States.prison_riot) {prison_riot();}
		else if (myState == States.prison_riot_1) {prison_riot_1();}
		
		
		
		else if (myState == States.infirmary_arrested) {infirmary_arrested();}
		else if (myState == States.infirmary_arrested_dualfail) {infirmary_arrested_dualfail();}
		else if (myState == States.trial_arrested) {trial_arrested();}
		else if (myState == States.death_penalty_dualfail) {death_penalty_dualfail();}
		
		else if (myState == States.escape_arrested_stay) {escape_arrested_stay();}
		else if (myState == States.escape_arrested_stay_1) {escape_arrested_stay_1();}
		else if (myState == States.escape_arrested_inmate) {escape_arrested_inmate();}
		
		else if (myState == States.tunnel_arrested) {tunnel_arrested();}
		else if (myState == States.escape_arrested_inmate_1) {escape_arrested_inmate_1();}
		else if (myState == States.escape_inmate_stay) {escape_inmate_stay();}
		
		else if (myState == States.escape_inmate_stay_1) {escape_inmate_stay_1();}
		
		
	}
	#region State Handling Methods
	
	
	//START SCREEN\\
	void cellstuck() {
		text.text = "You are an American journalist in foreign prison awaiting trial for a crime you didn't commit. \n\n " +
			"The conditions are deplorable and you suspect you will not receive a fair trial. \n\n" +
				"Press E to plan an escape or press S to stay in the cell and await your trial.";
		if (Input.GetKeyDown(KeyCode.E)) {myState = States.escape;}
		else if (Input.GetKeyDown(KeyCode.S)) {myState = States.trial_stay;}
	} 
	
	//DEATH SCREEN\\
	
	void death_penalty() {
		text.text = "You are blindfolded and taken from your cell out in to the courtyard.\n\n" +
			"You hear muffled screams from several other inmates about to meet the same fate.\n\n" +
				"You are lined up against the wall and you know there's no escaping this.\n\n" +
				"Press P to play again.";
		if (Input.GetKeyDown(KeyCode.P)) {Start();}
	}
	
	
	//DIGGING LEADS TO DEATH\\
	void escape_dig_again() {
		text.text = "You dig and dig, but make very little progress. \n\n " +
			"You hear banging on your cell door.\n\n" +
				"Press Space to continue.";
		if (Input.GetKeyDown(KeyCode.Space)) {myState = States.death_penalty;}
	}
	
	
	//INITIAL ESCAPE\\ 
	void escape() {
		text.text = "You have several escape options, but which one will lead to your freedom? \n\n " +
			"Press A to escape with an inmate, B to escape with a prison guard's help, or C to dig out of your prison cell using a spork.\n\n";
		if (Input.GetKeyDown(KeyCode.A)) {myState = States.escape_inmate;}
		else if (Input.GetKeyDown(KeyCode.B)) {myState = States.escape_guard;}
		else if (Input.GetKeyDown(KeyCode.C)) {myState = States.escape_dig;}
	}
	
	
	//DYING IN INFIRMARY\\
	void death_penalty_infirmary() {
		text.text = "Several hours pass and you are blindfolded and dragged along the ground from the infirmary, out in to the courtyard.\n\n" +
			"You hear muffled screams from several other inmates about to meet the same fate.\n\n" +
				"You are lined up against the wall and you know there's no escaping this.\n\n" +
				"Press P to play again.";
		text.fontSize = 28;
		if (Input.GetKeyDown(KeyCode.P)) {Start();}
	}
	
	
	#region Stay in cell
	//STAY AND GO TO TRIAL\\
	void trial_stay() {
		text.text = "During your 'trial' you were sentenced to death.\n\n" +
			"Your execution is imminent.\n\n" +
				"Now more than ever you need to escape.\n\n" +
				"Press Space to continue.";
		if (Input.GetKeyDown(KeyCode.Space)) {myState = States.escape_attempt_stay;}
	}
	
	
	//STAY CONTINUED\\
	void escape_attempt_stay() {
		text.text ="You're now out of options and have to escape if you want to live.\n\n" +
			"You can choose to accept your fate or actually attempt an escape this time.\n\n" +
				"Press A to re-attempt, or press B to stay in your cell.";
		if (Input.GetKeyDown(KeyCode.A)) {myState = States.escape_attempt_stay_1;}
		else if (Input.GetKeyDown(KeyCode.B)) {myState = States.death_penalty;}	
	}
	
	
	
	//SECOND ESCAPE OPPORTUNITY\\
	void escape_attempt_stay_1() {
		text.text = "You have several escape options, but which one will lead to your freedom? \n\n " +
			"Press A to escape with an inmate, B to escape with a prison guard's help, or C to dig out of your prison cell using a spork.\n\n";
		if (Input.GetKeyDown(KeyCode.A)) {myState = States.escape_inmate_stay;}
		else if (Input.GetKeyDown(KeyCode.B)) {myState = States.escape_guard_stay;}
		else if (Input.GetKeyDown(KeyCode.C)) {myState = States.escape_dig_again;}
	}
	
	
	//OPTION A ESCAPE (STAY)\\
	void escape_inmate_stay() {
		text.text = "Several inmates also wish to escape.\n\n" +
			"You must choose from one of their plans.\n\n" +
				"Press Space to Continue.";
		if (Input.GetKeyDown(KeyCode.Space)) {myState = States.escape_inmate_stay_1;}
	}
	
	
	//OPTION A CONT\\
	void escape_inmate_stay_1() {
		text.text = "Plan A is to use their alleged 'secret tunnel' and Plan B is to cause a prison riot and use it as a distraction to escape\n\n" +
			"Press A to use the 'secret tunnel' or B to Start a prison riot.";
		if (Input.GetKeyDown(KeyCode.A)) {myState = States.tunnel_stay;}
		else if (Input.GetKeyDown(KeyCode.B)) {myState = States.prison_riot_stay;}
	}
	
	
	//PLAN A (TUNNEL)\\
	void tunnel_stay() {
		text.text = "You are given the location of the tunnel which goes under the prison and leads to freedom. \n\n" +
			"You arrive at the tunnel and are waiting for the inmates to give you access.\n\n" +
				"Press Space to contine.";
		if (Input.GetKeyDown(KeyCode.Space)) {myState = States.tunnel_1_stay;}
	}
	
	void tunnel_1_stay() {
		text.text = "As you stand, waiting patiently, multiple guards surround you and begin to beat you with their nightsticks.\n\n" +
			"You are sent to the infirmary.\n\n" +
				"Press Space to contine.";
		if (Input.GetKeyDown(KeyCode.Space)) {myState = States.infirmary_stay;}
	}
	
	
	void infirmary_stay() {
		text.text = "You awake several hours later and realise the inmates probably lied to and betrayed you for their own personal gain.\n\n" +
			"You aren't able to move.\n\n" +
				"Press Space to contine.";
		if (Input.GetKeyDown(KeyCode.Space)) {myState = States.death_penalty_infirmary;}
	}
	
	
	//PLAN B (PRISON RIOT)\\
	
	void prison_riot_stay() {
		text.text = "You meet up with several inmates who plan to kill guards and take over the prison. \n\n " +
			"This will be your opportunity to escape.\n\n" +
				"Press Space to continue.";
		if (Input.GetKeyDown(KeyCode.Space)) {myState = States.prison_riot_1_stay;}
	}
	
	
	//RIOT CONT.\\
	void prison_riot_1_stay() {
		text.text = "You begin to hear loud banging and screaming. You know the riot is taking place.\n\n " +
			"You choose to run out into the courtyard.\n\n" +
				"You have the option to use the front gate or look for a hole in the fence.\n\n" +
				"Press A to try and use the front gate and B to look for a hole to escape through.";
		if (Input.GetKeyDown(KeyCode.A)) {myState = States.front_gate_stay;}
		else if (Input.GetKeyDown(KeyCode.B)) {myState = States.fence_escape_stay;}
	}
	
	
	void front_gate_stay() {
		text.text = "As you approach the gate, you are shot by a prison guard.\n\n" +
			"Bleeding out on the floor, you begin to regret, in hindshight, your stupid choice.\n\n" +
				"You are taken to the infirmary.\n\n" +
				"Press Space to continue. ";
		if (Input.GetKeyDown(KeyCode.Space)) {myState = States.infirmary_shot_stay;}
	}
	
	
	void fence_escape_stay() {
		text.text = "You run for the fence and out of the prison\n\n" +
			"You now have the choice to run to the American embassy or hitch-hike a ride out of the country.\n\n" +
				"Press A to go the the embassy or B to hitch-hike a ride";
		if (Input.GetKeyDown(KeyCode.A)) {myState = States.embassy;}
		else if (Input.GetKeyDown(KeyCode.B)) {myState = States.hitchhike_stay;}
	}
	
	//OPTION A RESULT\\
	void infirmary_shot_stay() {
		text.text = "You awake several hours later and realise you were shot.\n\n" +
			"You aren't able to move\n\n" +
				"Press Space to contine.";
		if (Input.GetKeyDown(KeyCode.Space)) {myState = States.death_penalty_infirmary;}
	}
	
	//LOSING CONDITIONS\\
	void hitchhike_stay () {
		text.text = "You attract the attention of a driver, and he agrees to take you over the border. \n\n" +
			"Press Space to continue.";
		if (Input.GetKeyDown(KeyCode.Space)) {myState = States.hitchhike_loss_stay;}
	}
	
	void hitchhike_loss_stay () {
		text.text = "You approach the border and are immediately detained when you cannot provide identification. \n\n"+
			"Back to prison for you. \n\n" +
				"Press Space to continue";
		if (Input.GetKeyDown(KeyCode.Space)) {myState = States.arrested_loss_stay;}
	}
	
	
	void arrested_loss_stay() {
		text.text = "You arrive back at prison and the guards escort you back to your cell.\n\n" +
			"Your failed escape attempt means your execution is imminent.\n\n" +
				"Press Space to contine.";
		if (Input.GetKeyDown(KeyCode.Space)) {myState = States.death_penalty;}
	}
	
	
	
	//GUARD ESCAPE (STAY)\\
	void escape_guard_stay() {
		text.text = "Drawn crudely on a napkin, a guard has given you several escape options. \n\n " +
			"The napkin reads as follows 'Laundry, Darkness, Disguise.' \n\n" +
				"Press L for laundry escape, C to use the cover of darkness escape or D for a disguise."; 
		if (Input.GetKeyDown(KeyCode.L)) {myState = States.laundry_stay;}
		else if (Input.GetKeyDown(KeyCode.C)) {myState = States.darkness_stay;}
		else if (Input.GetKeyDown(KeyCode.D)) {myState = States.disguise_stay;}
	}
	
	
	//LAUNDRY ESCAPE (STAY)\\
	
	void laundry_stay () {
		text.text = "After several days of organisation the guard has given an escape window.\n\n" +
			"You are escorted to a laundry room and instructed to use the back of the truck to hide.\n\n"  +
				"The truck comes to an abrupt stop. Do you stay or make a hasty exit?\n\n" +
				"Press S to stay or E to make a hasty exit.";
		if (Input.GetKeyDown(KeyCode.S)) {myState = States.laundry_remain_stay;}
		else if (Input.GetKeyDown(KeyCode.E)) {myState = States.laundry_haste_stay;}
	}
	
	void laundry_remain_stay () {
		text.text = "The truck starts to move again, but promptly comes to a halt. \n\n" +
			"You begin to hear chatter outside and within seconds police tell you to exit the truck.\n\n"  +
				"You are escourted back to the prison where the guars beat you with nightsticks.\n\n" +
				"Press Space to continue.";
		if (Input.GetKeyDown(KeyCode.Space)) {myState = States.laundry_remain_stay_1;}
	}
	
	void laundry_remain_stay_1 () {
		text.text = "You awake several hours later to the realisation that your escape attempt was a failure. \n\n" +
			"Your execution is imminent.\n\n"  +
				"Press Space to continue.";
		if (Input.GetKeyDown(KeyCode.Space)) {myState = States.death_penalty_infirmary;}
	}
	
	
	
	
	
	
	
	
	void laundry_haste_stay () {
		text.text = "You leave the truck as fast as possibe, and run to the city. \n\n" +
			"You have the option to run to the American embassy or to hitch-hike a ride out of the country.\n\n"  +
				"Press A to go to the American embassy or B to hitch-hike a ride.\n\n";
		if (Input.GetKeyDown(KeyCode.A)) {myState = States.embassy;}
		else if (Input.GetKeyDown(KeyCode.B)) {myState = States.hitchhike_loss_stay;}
	}
	
	//DARKNESS (STAY)\\
	void darkness_stay () {
		text.text = "The guard has informed you that you'll be leaving come nightfall.\n\n" +
			"Press Space to continue.\n\n";
		if (Input.GetKeyDown(KeyCode.Space)) {myState = States.darkness_cont_stay;}
	}
	
	void darkness_cont_stay () {
		text.text = "You are escorted out of the cell and into the darkness of the night. The courtyard is empty.\n\n" +
			"After several minutes of walking, he points to a gap in the fence and tells you to run as fast as you can.\n\n" +
				"Press A to run to the embassy or B to hitch-hike out of the country.";
		if (Input.GetKeyDown(KeyCode.A)) {myState = States.embassy;}
		if (Input.GetKeyDown(KeyCode.B)) {myState = States.hitchhike_loss_stay;}
	}
	
	
	//DISGUISE (STAY)\\
	void disguise_stay () {
		text.text = "You have been provided with a cleaner's uniform and given a time frame to make your escape.\n\n" +
			"Press Space to continue.";
		if (Input.GetKeyDown(KeyCode.Space)) {myState = States.disguise_cont_stay;}
	}
	
	//\\
	
	void disguise_cont_stay () {
		text.text = "You walk out the door in broad daylight and through the courtyard.\n\n" +
			"You begin to approach the gate and the guard tips his hat. \n\n"  +
				"Your heart races as you run for freedom.\n\n" +
				"Press A to run to the American embassy or B to hitch-hike out of the country.";
		if (Input.GetKeyDown(KeyCode.A)) {myState = States.embassy;}
		else if (Input.GetKeyDown(KeyCode.B)) {myState = States.hitchhike_loss_stay;}
	}
	
	
	
	#endregion 
	
	
	//OPTION A\\
	void escape_inmate() {
		text.text = "Several inmates also wish to escape.\n\n" +
			"You must choose from one of their plans.\n\n" +
				"Press Space to Continue.";
		if (Input.GetKeyDown(KeyCode.Space)) {myState = States.escape_inmate_1;}
	}
	
	//OPTION B\\
	void escape_guard() {
		text.text = "Drawn crudely on a napkin, a guard has given you several escape options. \n\n " +
			"The napkin reads as follows 'Laundry, Darkness, Disguise.' \n\n" +
				"Press L for laundry escape, C to use the cover of darkness escape or D for a disguise."; 
		if (Input.GetKeyDown(KeyCode.L)) {myState = States.laundry;} 
		else if (Input.GetKeyDown(KeyCode.C)) {myState = States.darkness;}
		else if (Input.GetKeyDown(KeyCode.D)) {myState = States.disguise;}
	}
	
	
	//OPTION C\\												
	void escape_dig() {
		text.text = "You dig for days and make little progress.\n\n" +
			"Your trial is imminent.\n\n" +
				"Press Space to continue";
		if (Input.GetKeyDown(KeyCode.Space)) {myState = States.trial_stay;}
	}
	
	
	
	
	void escape_inmate_1() {
		text.text = "Plan A is to use their alleged 'secret tunnel' and Plan B is to cause a prison riot and use it as a distraction to escape\n\n" +
			"Press A to use the 'secret tunnel' or B to Start a prison riot.";
		if (Input.GetKeyDown(KeyCode.A)) {myState = States.tunnel;}
		else if (Input.GetKeyDown(KeyCode.B)) {myState = States.prison_riot_1;}
	}
	
	void front_gate() {
		text.text = "As you approach the gate, you are shot by a prison guard.\n\n" +
			"Bleeding out on the floor, you begin to regret your stupid choice." +
				"You are taken to the infirmary." +
				"Press Space to continue. ";
		if (Input.GetKeyDown(KeyCode.Space)) {myState = States.infirmary_shot;}
	}
	
	void fence_escape() {
		text.text = "You run for the fence and out of the prison\n\n" +
			"You now have the choice to run to the American embassy or hitch-hike a ride out of the country." +
				"Press A to go the the embassy or B to hitch-hike a ride";
		if (Input.GetKeyDown(KeyCode.A)) {myState = States.embassy;}
		else if (Input.GetKeyDown(KeyCode.B)) {myState = States.hitchhike;}
	}
	
	void tunnel() {
		text.text = "You are given the location of the tunnel which goes under the prison and leads to freedom. \n\n" +
			"You arrive at the tunnel and are waiting for the inmates to give you access.\n\n" +
				"Press Space to contine.";
		if (Input.GetKeyDown(KeyCode.Space)) {myState = States.tunnel_1;} 
	}
	
	void tunnel_1() {
		text.text = "As you stand, waiting patiently, multiple guards surround you and begin to beat you with their nightsticks.\n\n" +
			"You are sent to the infirmary.\n\n" +
				"Press Space to contine.";
		if (Input.GetKeyDown(KeyCode.Space)) {myState = States.infirmary;}
	}
	
	void infirmary() {
		text.text = "You awake several hours later and realise the inmates probably lied to and betrayed you for their own personal gain.\n\n" +
			"You aren't able to move, so will be in bed reconvering for a while.\n\n" +
				"Press Space to contine.";

		if (Input.GetKeyDown(KeyCode.Space)) {myState = States.trial; escapeAttempts ++;}
	}
	
	
	void infirmary_arrested() {
		text.text = "You awake several hours later and realise your attempt was a failure.\n\n" +
			"You aren't able to move, so will be in bed until your trial.\n\n" +
				"Press Space to contine.";
		if (Input.GetKeyDown(KeyCode.Space)) {myState = States.trial_arrested;}
	}
	
	void infirmary_arrested_dualfail() {
		text.text = "You awake several hours later and realise you've failed to escape again.\n\n" +
			"You aren't able to move.\n\n" +
				"Press Space to contine.";
		if (Input.GetKeyDown(KeyCode.Space)) {myState = States.death_penalty_dualfail;}
	}
	
	
	void trial_arrested() {
		text.text = "During your 'trial' you were sentenced to death.\n\n" +
			"Your execution is imminent.\n\n" +
				"Now more than ever you need to escape.\n\n" +
				"Press Space to continue.";
		if (Input.GetKeyDown(KeyCode.Space)) {myState = States.escape_arrested_reattempt;}
	}
	
	void trial_arrested_stay() {
		text.text = "During your 'trial' you were sentenced to death.\n\n" +
			"Your execution is imminent.\n\n" +
				"Now more than ever you need to escape.\n\n" +
				"Press Space to continue.";
		if (Input.GetKeyDown(KeyCode.Space)) {myState = States.escape_arrested_stay;}
	}
	
	void escape_arrested_stay() {
		text.text ="You're now out of options and have to escape if you want to live.\n\n" +
			"can choose to accept your fate or re-attempt escape.\n\n" +
				"Press A to re-attempt, or press B to stay in your cell.";
		if (Input.GetKeyDown(KeyCode.A)) {myState = States.escape_arrested_stay_1;}
		else if (Input.GetKeyDown(KeyCode.B)) {myState = States.death_penalty;}	
	}
	
	void escape_arrested_stay_1() {
		text.text = "You have several escape options, but the guard won't help you again \n\n " +
			"Press A to escape with an inmate or B to dig out of your prison cell using a spork.\n\n";
		if (Input.GetKeyDown(KeyCode.A)) {myState = States.escape_arrested_inmate;}
		else if (Input.GetKeyDown(KeyCode.B)) {myState = States.escape_dig_again;}
	}
	
	void escape_arrested_inmate() {
		text.text = "Several inmates also wish to escape.\n\n" +
			"You must choose from one of their plans.\n\n" +
				"Press Space to Continue.";
		if (Input.GetKeyDown(KeyCode.Space)) {myState = States.escape_arrested_inmate_1;}
	}
	
	void escape_arrested_inmate_1() {
		text.text = "Plan A is to use their alleged 'secret tunnel' and Plan B is to cause a prison riot and use it as a distraction to escape\n\n" +
			"Press A to use the 'secret tunnel' or B to Start a prison riot.";
		if (Input.GetKeyDown(KeyCode.A)) {myState = States.tunnel_arrested;}
		else if (Input.GetKeyDown(KeyCode.B)) {myState = States.prison_riot_1_arrested;}
	}
	
	void tunnel_arrested() {
		text.text = "You are given the location of the tunnel which goes under the prison and leads to freedom. \n\n" +
			"You arrive at the tunnel and are waiting for the inmates to give you access.\n\n" +
				"Press Space to contine.";
		if (Input.GetKeyDown(KeyCode.Space)) {myState = States.tunnel_1;}
	}
	
	
	
	void tunnel_arrested_1() {
		text.text = "As you stand, waiting patiently, multiple guards surround you and begin to beat you with their nightsticks... again.\n\n" +
			"You are sent to the infirmary.\n\n" +
				"Press Space to contine.";
		if (Input.GetKeyDown(KeyCode.Space)) {myState = States.infirmary;}
	}
	
	void trial() {
		text.text = "During your 'trial' you were sentenced to death.\n\n" +
			"Your execution is imminent.\n\n" +
				"Now more than ever you need to escape.\n\n" +
				"Press Space to continue.";
		if (Input.GetKeyDown(KeyCode.Space)) {myState = States.escape_reattempt;}
	}
	
	
	
	
	void escape_reattempt() {
		text.text = "You're still wounded, but able to move again.\n\n" +
			"You can choose to accept your fate or re-attempt escape.\n\n" +
				"Press A to re-attempt, or press B to stay in your cell.";
		if (Input.GetKeyDown(KeyCode.A)) {myState = States.escape_reattempt_1;}
		else if (Input.GetKeyDown(KeyCode.B)) {myState = States.death_penalty;}	
	}
	
	
	
	void death_penalty_dualfail() {
		text.text = "You are blindfolded and dragged along the ground from the infirmary out in to the courtyard.\n\n" +
			"You hear muffled screams from several other inmates about to meet the same fate.\n\n" +
				"You are lined up against the wall and you know there's no escaping this.\n\n" +
				"Press P to play again.";
		if (Input.GetKeyDown(KeyCode.P)) {Start();}
	}
	
	void escape_reattempt_1() {
		text.text = "You still have one last chance to escape. \n\n " +
			"Press A to escape with a prison guard's help or B to dig out of your prison cell using a spork.\n\n";
		if (Input.GetKeyDown(KeyCode.A)) {myState = States.escape_guard;}
		else if (Input.GetKeyDown(KeyCode.B)) {myState = States.escape_dig_again;}
	}
	
	
	void prison_riot() {
		text.text = "You meet up with several inmates who plan to kill guards and take over the prison. \n\n " +
			"This will be your opportunity to escape.\n\n" +
				"Press Space to continue.";
		if (Input.GetKeyDown(KeyCode.Space)) {myState = States.prison_riot_1;}
	}
	
	void prison_riot_1() {
		text.text = "You begin to hear loud banging and screaming. You know the riot is taking place.\n\n " +
			"You choose to run out into the courtyard.\n\n" +
				"You have the option to use the front gate or look for a hole in the fence.\n\n" +
				"Press F to try and use the front gate and B to look for a hole to escape throgh.";
		if (Input.GetKeyDown(KeyCode.A)) {myState = States.front_gate_stay;}
		else if (Input.GetKeyDown(KeyCode.B)) {myState = States.fence_escape_stay;}
	}
	
	
	
	void darkness () {
		text.text = "The guard has informed you that you'll be leaving come nightfall.\n\n" +
			"Press Space to continue.\n\n";
		if (Input.GetKeyDown(KeyCode.Space)) {myState = States.darkness_cont;}
	}
	
	void darkness_cont () {
		text.text = "You are escorted out of the cell and into the darkness of the night. The courtyard is empty.\n\n" +
			"After several minutes of walking, he points to a gap in the fence and tells you to run as fast as you can.\n\n" +
				"Press A to run to the embassy or B to hitch-hike out of the country.";
		if (Input.GetKeyDown(KeyCode.A)) {myState = States.embassy;}
		if (Input.GetKeyDown(KeyCode.B)) {myState = States.hitchhike;}
	}
	
	void disguise () {
		text.text = "You have been provided with a cleaner's uniform and given a time frame to make your escape.\n\n" +
			"Press Space to continue.";
		if (Input.GetKeyDown(KeyCode.Space)) {myState = States.disguise_cont;}
	}
	
	void disguise_cont () {
		text.text = "You walk out the door in broad daylight and through the courtyard.\n\n" +
			"You begin to approach the gate and the guard tips his hat. \n\n"  +
				"Your heart races as you run for freedom.\n\n" +
				"Press A to run to the American embassy or B to hitch-hike out of the country.";
		if (Input.GetKeyDown(KeyCode.A)) {myState = States.embassy;}
		else if (Input.GetKeyDown(KeyCode.B)) {myState = States.hitchhike;}
	}
	
	void laundry () {
		text.text = "After several days of organisation the guard has given an escape window.\n\n" +
			"You are escorted to a laundry room and instructed to use the back of the truck to hide.\n\n"  +
				"The truck comes to an abrupt stop. Do you stay or make a hasty exit?\n\n" +
				"Press S to stay or E to make a hasty exit.";
		if (Input.GetKeyDown(KeyCode.S)) {myState = States.laundry_remain;}
		else if (Input.GetKeyDown(KeyCode.E)) {myState = States.laundry_haste;}
	}
	
	void laundry_remain () {
		text.text = "The truck starts to move again, but promptly comes to a halt. \n\n" +
			"You begin to hear chatter outside and within seconds police tell you to exit the truck.\n\n"  +
				"You are escourted back to the prison where the guards beat you with nightsticks.\n\n" +
				"Press Space to continue.";
		if (Input.GetKeyDown(KeyCode.Space)) {myState = States.infirmary_arrested; escapeAttempts ++;}
	}
	
	void laundry_haste () {
		text.text = "You leave the truck as fast as possibe, and run to the city. \n\n" +
			"You have the option sto run to the American embassy or to hitch-hike a ride out of the country.\n\n"  +
				"Press A to go to the American embassy or B to hitch-hike a ride.\n\n";
		if (Input.GetKeyDown(KeyCode.A)) {myState = States.embassy;}
		else if (Input.GetKeyDown(KeyCode.B)) {myState = States.hitchhike;}
	}
	
	void embassy () {
		text.text = "You have made it to the embassy and are greeted by an American soldier. \n\n" +
			"He takes you inside the embassy where you are processed and returned to America. \n\n"  +
				"Press Space to continue";
		if (Input.GetKeyDown(KeyCode.Space)) {myState = States.freedom;}
	}
	
	void hitchhike () {
		text.text = "You attract the attention of a driver, and he agrees to take you over the border. \n\n" +
			"Press Space to continue.";
		if (Input.GetKeyDown(KeyCode.Space)) {myState = States.hitchhike_loss;}
	}
	
	void hitchhike_loss () {
		text.text = "You approach the border and are immediately detained when you cannot provide identification. \n\n "+
			"Back to prison for you. \n\n " +
				"Press Space to Continue ";
		if (Input.GetKeyDown(KeyCode.Space)) {myState = States.escape_attempt_stay; escapeAttempts ++;}
	}
	
	void freedom() {
		text.text = "You have been returned home to your family where you will expose the corruption of the foreign nation.\n\n" +
			"You have won!\n\n " +
				"Press P to play again. ";
		if (Input.GetKeyDown(KeyCode.P)) {Start();} 
	}
	
	
	#endregion
}
