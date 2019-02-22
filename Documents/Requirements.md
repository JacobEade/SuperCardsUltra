# SuperCardsUltra Requirements

## Team members

* Jacob Eade
* Harrison Welch

## Purpose

* SuperCardsUltra will allow users to play card games with their friends. The Card games that will be implemented are Blackjack, Texas Hold Em, Pedro, and Mao.

## Requirements

### Menu and interface

#### User Interface

1. _
    * Name: load_screen
    * Type: functional
    * Summary: There will be a simple load screen with a logo.

2. _
    * Name: login_screen
    * Type: functional
    * Summary: There will be a login screen for players.

3. _
    * Name: home_screen
    * Type: functional
    * Summary: There will be a home screen where players can directly acess the other screens.

4. _
    * Name: about_screen
    * Type: functional
    * Summary: There will be an about screen containing a general descrition of the application.

5. _
    * Name: settings_screen
    * Type: functional
    * Summary: There will be a settings screen. Where users can custimize the cards, as well as some other settings.

#### User Account System

1. _
    * Name: account_creation
    * Type: functional
    * Summary: Players will be able to creat an account.

2. _
    * Name: account_login
    * Type: functional
    * Summary: Players will be able to login to a account.

3. _
    * Name: account_logout
    * Type: functional
    * Summary: Players will be able to logout of their account.

4. _
    * Name: account_career
    * Type: functional
    * Summary: Players will be able to track their career wins and total games with their accounts.

### Network

1. _
    * Name: net_connect
    * Type: risk
    * Summary: The network may disallow any computers to connect to one another

2. _
    * Name: net_keep_connect
    * Type: risk
    * Summary: The network may drop the player and we would have to deal with a non-reponsive connetection

### Lobby and social

1. _
    * Name: lobby_system
    * Type: functional
    * Summary: The lobby will be where players connect to eachother and decide which game to play

2. _
    * Name: num_players
    * Type: constraint
    * Summary: The number of players allowed in each lobby will be restricted to 4.

3. _
    * Name: voting_on_game
    * Type: functional
    * Summary: Players can vote on what game to play with the plurality of the votes winning. Each vote lasts 30 seconds. A pop-up is displayed for the user to scroll through games and click to vote.

4. _
    * Name: kick_player
    * Type: functional
    * Summary: Games should track the player's time between actions and should this counter pass 60 seconds then the player will be automatically kicked from the game. That players position on the board will "grey out" or become darker than other players positions

5. _
    * Name: vote_kick_player
    * Type: functional
    * Summary: The players can raise a vote to kick a player that is being rude

6. _
    * Name: player_chat
    * Type: functional
    * Summary: Players will be able to chat to eachother.

### General game systems

1. _
    * Name: card_sort
    * Type: functional
    * Summary: The cards will be automatically sorted for the readabillity.

2. _
    * Name: hand_of_cards
    * Type: functional
    * Summary: The player's cards in hand. Needs the ability to show cards to player. Auto-sorts the hand as cards come in.

3. _
    * Name: display_cards
    * Type: functional
    * Summary: Displays the cards to the screen.

4. _
    * Name: cards_deal
    * Type: functional
    * Summary: Deals cards to players according to the rules of the games.

5. _
    * Name: play_cards
    * Type: functional
    * Summary: Players will be able to play cads.

6. _
    * Name: player_points
    * Type: functional
    * Summary: Points will be tracked and displayed to the players.

7. _
    * Name: player_notes
    * Type: functional
    * Summary: Players will be able to take notes during games.

8. _
    * Name: player_dealer
    * Type: functional
    * Summary: Certain games call for the leader and needs to be pointed out and the player given exclusive players

9. _
    * Name: turn_visual
    * Type: functional
    * Summary: A dark black indicator on the game board will point to the player whose turn it is. This indicator will rotate in turn in the direction of current play order to the next player. Repeat until end of game.

10. _
    * Name: player_bids
    * Type: functional
    * Summary: allows sthe players to make bids appropiate to the game. animate chips going into the center pot when the user places a bet.

### Specific Game Systems

#### Blackjack

1. _
    * Name: table_cards_blackjack_display
    * Type: functional
    * Summary: A players blackjack hand should have 1 card face up when displayed on the table

#### Texas Hold Em

1. _
    * Name: hold_em_display
    * Type: functional
    * Summary: display to the table the 3 first round cards, 1 second round, and the final card to the table when playing texholdem

2. _
    * Name: double_single_blind
    * Type: functional
    * Summary: display chip to the screen indicating who is paying blinds and double blinds. Then include them actually paying it.

#### Pedro

#### Mao

1. _
    * Name: random_rules
    * Type: functional
    * Summary: There will be a systenm of reandom rules
