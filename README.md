# optimised-golf
This machine will tell you how to beat your friends at golf (the card game created by J.V)

# rules
There exists, at this time, no limit to the number of players. This program will limit the number to 2-5 players.
There are 9 or 18 holes per game. The same deck is used for all holes. This program will limit the game to 9 holes.
During each hole, each player is dealt a number of cards ("par" for the hole). There exists, at this time, no limit to a hole's par. This program will limit par to 3-5.
Par for a 9-hole course must equal 36.
Each player's score is calculated at the end of each hole by taking the sum of his or her remaining cards. 
The card values are as follows:
	A: 1
	2: 2
	3: 3
	4: 4
	5: 5
	6: 6
	7: 7
	8: 8
	9: 9
	10: 10
	J: 11
	Q: 12
	K: 0, additionally, kings have the power to cancel out one of the player's other cards
	Additionally, pairs of cards cancel each other out (but not triples)
Each player's score for the game is calculated by taking the sum of the score of each hole.
The aim of the game is to be the player with the lowest score at the end of 9 holes.

# cards
Cards live either in a player's "hand" (actually, face-down or face-up in front of a player), in the deck, or in the discard pile adjacent to the deck.

Cards have three states:
	Revealed (to all players)
	Unrevealed (unknown to all players)
	Known (only to the owner of the card)

All cards in the discard pile are revealed. Cards in a players hand can be any state.

# hole
Each hole, one of the players acts as a dealer. The dealer's only job is to deal the cards at the beginning of the hole. The dealer for the next hole is the person to the left of the current dealer.

At the start of each hole, the dealer deals each player /par/ cards.

During each hole, each player may look at a certain number of cards they've been dealt, depending on the hole's par. When a player looks at the cards, the cards become known to that player.
	For a par 5, players may look at two of their cards.
	For a par 4, players may look at two of their cards.
	For a par 3, players may look at one of their cards.
In real life, a player may only look at his/her cards once per hole. If the player forgets his/her cards, he/she can use a mulligan (only one per player per game) to look at the cards again.

The player to the left of the dealer goes first. During the first round, the first player must:
	1. Reveal a card from the top of the deck, placing it in the discard pile, or 
			not reveal a card
	2. Reveal one of their known cards, keeping it in their possession, or
			reveal one of their unrevealed cards, keeping it in their possession, or
			replace one of their known cards with the card at the top of the discard pile (if one exists), or
			replace one of their unrevealed cards with the card at the top of the discard pile (if one exists)
			
The second and subsequent rounds proceed in the same manner. The player whose turn it is must:
	1. Reveal a card from the top of the deck, placing it in the discard pile, or 
			not reveal a card
	2. Reveal one of their known cards, keeping it in their possession, or
			reveal one of their unrevealed cards, keeping it in their possession, or
			replace one of their known cards with the card at the top of the discard pile, or
			replace one of their unrevealed cards with the card at the top of the discard pile
			
Once a card is revealed, it is permanenet and may not be replaced. 
The hole continues until all of each player's cards are revealed.

At the end of the hole, the score for each player is calculated, all cards are collected into the deck, and the new dealer shuffles and deals the next hole.

# future considerations
- risk tolerance based on player's cumulative score, current score, and rank
- card prediction taking into account other players' moves, such as revealing a high card or replacing a card with a high card
