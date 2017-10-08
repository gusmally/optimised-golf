package Game;

import java.util.ArrayList;

public class Player {
	
	private ArrayList<Card> hand;
	private int score;
	
	public int getScore()
	{
		return this.score;
	}
	
	public Player(ArrayList<Card> hand) 
	{
		this.hand = hand;
		this.score = 0;
	}
	
	public void AddToHand(Card card)
	{
		this.hand.add(card);
	}
	
	public void Discard(Card card) //will this work? do we need a lookup system?
	{
		this.hand.remove(card);
	}
}
