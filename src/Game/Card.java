package Game;

public class Card {
	
	private State state;
	
	public State getState()
	{
		return this.state;
	}
	
	public void setState(State state)
	{
		this.state = state;
	}
	
	private final Rank rank;
	
	public Rank getRank()
	{
		return this.rank;
	}
	
	private final Suit suit;
	
	public Suit getSuit()
	{
		return this.suit;
	}
	
	public Card(State state, Rank rank, Suit suit) 
	{
		this.state = state;
		this.rank = rank;
		this.suit = suit;
	}
}
