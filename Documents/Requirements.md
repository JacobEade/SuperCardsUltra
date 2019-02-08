# SuperCardsUltra Requirements

## Team members

* Jacob Eade
* Harrison Welch

## Purpose

* SuperCardsUltra will allow users to play card games with their friends.

## Requirements

1. _
    * Name: lobby_system
    * Type: functional
    * Summary: The Player jumps into a lobby with other players

2. _
    * Name: num_players
    * Type: constraint
    * Summary: Limit to 4 players

3. _
    * Name: home_screen
    * Type: functional
    * Summary: Enable the player to enter the lobby

4. _
    * Name: about_screen
    * Type: functional
    * Summary: Describe the application, copyright notice, and other information

5. _
    * Name: settings_screen
    * Type: functional
    * Summary: Setting the font, font-size, sound-mixing levels, color-blind mode, game-board skins/colors.

6. _
    * Name: voting_on_game
    * Type: functional
    * Summary: Players can vote on what game to play with the plurality of the votes winning. Each vote lasts 30 seconds. A pop-up is displayed for the user to scroll through games and click to vote.

7. _
    * Name: load_screen
    * Type: functional
    * Summary: Load screen of revolving logo. Basic and Easy.

8. _
	* Name: card_sort
	* Type: functional
	* Summary: sorts the cards into a easy to read fashion

9. _
    * Name: hand_of_cards
    * Type: functional
    * Summary: The player's cards in hand. Needs the ability to show cards to player. Auto-sorts the hand as cards come in.

10. _
    * Name: player_notes
    * Type: functional
    * Summary: notes the player can take about the current game allow the player to remember many complex things

11. _
    * Name: player_dealer
    * Type: functional
    * Summary: Certain games call for the leader and needs to be pointed out and the player given exclusive players

12. _
	* Name: player_points
	* Type: functional
	* Summary: Tracks the points for the player or team and displays them to the players

13. _
	* Name: display_cards
	* Type: functional
	* Summary: renders the cards to the screen

14. _
	* Name: play_cards
	* Type: functional
	* Summary: allows players to play cards

15. _
	* Name: net_connect
	* Type: risk
	* Summary: The network may disallow any computers to connect to one another

16. _
	* Name: net_keep_connect
	* Type: risk
	* Summary: The network may drop the player and we would have to deal with a non-reponsive connetection

17. _
	* Name: kick_player
	* Type: functional
	* Summary: The game should kick the player that is slow to respond

18. _
	* Name: vote_kick_player
	* Type: functional
	* Summary: The players can raise a vote to kick a player that is being rude

19. _
	* Name: random_rules
	* Type: functional
	* Summary: design a system of a set of rules randomly assigned to random cards

20. _
	* Name: hold_em_display
	* Type: functional
	* Summary: display to the table the 3 first round cards, 1 second round, and the final card to the table when playing texholdem

20. _
	* Name: double_single_blind
	* Type: functional
	* Summary: display chip to the screen indicating who is paying blinds and double blinds. Then include them actually paying it.

22. _
	* Name: turn_visual
	* Type: functional
	* Summary: animate the passing of who is taking their turn.

23. _
	* Name: table_cards_blackjack_display
	* Type: functional
	* Summary: A players blackjack hand should have 1 card face up when displayed on the table

24. _
	* Name: player_bids
	* Type: functional
	* Summary: allows the players to make bids appropiate to the game. animate chips going into the center pot when the user places a bet.

25. _
	* Name: account_creation
	* Type: functional
	* Summary: allows players to make a new account

26. _
	* Name: account_login
	* Type: functional
	* Summary: allows players to login

27. _
	* Name: player_chat
	* Type: functional
	* Summary: allows players to chat within the lobby

28. _
	* Name: cards_deal
	* Type: functional
	* Summary: deals cards to the players in the appropiate way for the chosen game
