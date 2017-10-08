package Game;

import java.io.Console;
import java.util.ArrayList;
import java.util.Collections;

public class Deck {

	private ArrayList<Card> cards;
	
	public Deck() {
		this.cards = new ArrayList<Card>();
		
		for (Rank r : Rank.values())
			for (Suit s : Suit.values())
				cards.add(new Card(State.UNREVEALED, r, s));
		
		this.Shuffle();
	}
	
	public void Shuffle()
	{
		//will it shuffle the deck or do we need to return a new one?
		Collections.shuffle(this.cards);
	}
	
	public Card GetCard()
	{
		Card card = null;
		
		try
		{
			card = this.cards.get(0);
		}
		catch (Exception e)
		{
			System.out.println("Ran out of cards: " + e);
		}
		
		return card;
	}
}
