package Game;

import java.util.ArrayList;
import java.util.Collections;
import java.util.LinkedList;

public class Hole {

	//private int players; // do we want number or actual collection of?
	
	private LinkedList<Player> players;
	private int par;
	
	private Deck deck; // how to show cards being removed into the discard pile?
	private ArrayList<Card> discardPile;
	
	public Hole(LinkedList<Player> players, int par) 
	{
		this.players = players;
		this.deck = new Deck();
	}

	public void Play()
	{
		this.deck.Shuffle();
		
		while (par > 0)
			for (Player p : players)
				p.AddToHand(deck.GetCard());
		
		
		
	}
}
