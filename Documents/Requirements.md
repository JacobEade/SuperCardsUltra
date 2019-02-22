# SuperCardsUltra Requirements

## Team members

* Jacob Eade
* Harrison Welch

## Purpose

* SuperCardsUltra will allow users to play card games with their friends. The Card games that will be implemented are Blackjack, Texas Hold Em, Pedro, and Mao.

## Requirements

### Menu and interface

#### User Interface

3. _
    * Name: home_screen
    * Type: functional
    * Summary: This is screen is the first page of the application when loaded up. It shows the title of the application 'SuperCardsUltra' and buttons to migrate to other screens in the game.

1. _
    * Name: load_screen
    * Type: functional
    * Summary: There will be a simple load screen with a logo spinning in circles centered in the screen. Below the logo should show a progress bar of the load.

2. _
    * Name: login_screen
    * Type: functional
    * Summary: A login screen will be seen by the user for logging into his or her account. It will feature a Username and a Password text feild. There will also be a button to create an account which will take you to the create an account screen

3. _
    * Name: login_screen
    * Type: functional
    * Summary: Similar to creating an account this will feature an account creation screen. This will be a screen centered modal that features username, email, password, and confirm password text fields.
    
4. _
    * Name: about_screen
    * Type: functional
    * Summary: There will be an about screen containing a general descrition of the application.

5. _
    * Name: settings_screen
    * Type: functional
    * Summary: There will be a settings screen. Where users can customize the card back texture/color, the board texture/color

1. _
    * Name: account_view
    * Type: functional
    * Summary: From the main screen the user can select to view their account. This moves them to a screen to see items such as wins, win percentage per game, last game played results, favorite game based on play time and other card game items.

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

1. _
    * Name: username_dupe_check
    * Type: functional
    * Summary: The account creation screen, upon submit there will be a check in the database for a duplicate of that username and if it should exist then

### Network

1. _
    * Name: net_connect
    * Type: risk
    * Summary: The network may disallow any computers to connect to one another. Networking is the not the developers strong suit. The network used to play the game may ban the sending of packer

2. _
    * Name: net_keep_connect
    * Type: risk
    * Summary: The network may drop the player and we would have to deal with a non-reponsive connection. The connection could be lost at any point during the game, lobby, server finding, or other processes.

### Lobby and social

1. _
    * Name: lobby_system
    * Type: functional
    * Summary: Upon loading into the game and selecting a server the players are placed into a lobby amongst all the players. The lobby systems is a centered list of the number of players

2. _
    * Name: num_players
    * Type: constraint
    * Summary: The number of players allowed in each lobby will be restricted to 4. This is done for the initial design of the game

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
    * Summary: From the menu button in the top left the user can press "Vote Kick". The user can then select a player from a screen centered (vertical and horizontal). Then the a notification to each player is sent to each player center screened as 'Don't you want to kick $name$'? and they select yes, no, or a close in the top right. All inputs when recieving this notification will be disabled and re-enabled when the user selects one of the aforementioned options. A 'Yes' majority is required to kick a person. A 'No' ends up with nothing happing. A tie results in a 'No' vote. A close counts as abstaining and will not count toward either 'yes' nor 'no'.

6. _
    * Name: player_chat
    * Type: functional
    * Summary: Towards the bottom left corner there will be a chat window. It will be default minimized about 5% vertical height and 30% horizontal width Pressing 'U' on the keyboard shall open the chat to take 40% vertical; horizontal remains the same.

### General game systems

1. _
    * Name: card_sort
    * Type: functional
    * Summary: Each time a user picks up a card inside the game the hand sorts it into logical order. 2-10 then Jack, Queen, King, and Ace. This system will not shuffle the hidden card in BlackJack; that card will remain far left in the users hand
1. _
    * Name: in_game_menu
    * Type: functional
    * Summary: The User will be able to click a button in the top left of the screen to open an in game menu. It will open a column from the left hand side of the screen. All options in the menu will be displayed vertically. Options about the game will be displayed here.
1. _
    * Name: menu_leave_game
    * Type: functional
    * Summary: In the side bar menu there will be a button to leave the current game the user is in. Clicking this button will result in the user leaving the game.
2. _
    * Name: hand_of_cards
    * Type: functional
    * Summary: The player's cards in hand. Using the mouse scroll wheel the player can scroll through cards in the user's hand.
3. _
    * Name: render_card
    * Type: functional
    * Summary: Each card in the players hand shall be images of that specific card.
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
1. _
    * Name: bank_display
    * Type: functional
    * Summary: On the THE board there will be a box dedicated to displaying the users total money. This box will be place directly in front of the users hand on the game board
1. __
    * Name: animate_bid
    * Type: functional
    * Summary: animate (moving objects) a bid being placed onto the current pot right of the cards being played down.
1. __
    * Name: animate_win
    * Type: functional
    * Summary: animate a collection of chips moving towards the the winner(s) bank section of the screen. In the case of split pot, this animation will play twice in both directions.
2. _
    * Name: double_single_blind_display
    * Type: functional
    * Summary: display chip to the screen indicating who is paying blinds and double blinds.
2. _
    * Name: center_pot
    * Type: functional
    * Summary: Left of any centered card display there will be a pot to bet money

### Specific Game Systems

#### Blackjack

1. _
    * Name: table_cards_blackjack_display
    * Type: functional
    * Summary: A players blackjack hand should have 1 card face up when displayed on the table

#### Texas Hold Em (THE)

1. _
    * Name: hold_em_opening screen
    * Type: functional
    * Summary: Upon starting a game of Texas-Hold-Em, the randomly chosen host can choose to enable different options such as enabling or disabling blinds, initial starting cash, enabling or disabling ALL-INS, maximum or minimum bets.
1. _
    * Name: hold_em_display
    * Type: functional
    * Summary: display to the table the 3 first round cards, 1 second round, and the final card to the table when playing texholdem
1. _
    * Name: hold_em_deal
    * Type: functional
    * Summary: users start with a hand of 2 cards in a game of THE.

#### Pedro

1. _
    * Name: card_hierarchy
    * Type: functional
    * Summary: There will be a system in place that determines where the played cards lay in the hierarchy.

#### Mao

1. _
    * Name: mao_deal
    * Type: functional
    * Summary: Users start with a hand of 7 cards by default
1. _
    * Name: random_rules
    * Type: functional
    * Summary: A finite set of 10 rules for cards to apply secretly to the game shall be used
2. _
    * Name: mao_opening_screen
    * Type: functional
    * Summary: Upon starting a game of Mao the 'Host' of a game (randomly decided) sets up the game. This set up screen will involve either randomly assigning cards values or the Host can pick the rules assigned to each card. The screen will have the Club suit of cards set on screen one for each value totaling 13 different cards. The Host can then select from a different drop down of each card it's rule. There is also a random button that will push a random value into each card. Rules cannot be used more than once.

##### Random Rules for Mao

1. _
    * Name: reverse_turn_direction
    * Type: functional
    * Summary: A card played rule where The order of play shall reverse direction. If the turn of play was going to the left it shall now go to the right and if it was right it should now go left.
2. _
    * Name: draw_two
    * Type: functional
    * Summary: A card played rule where The following user in the turn order draws two cards and skips their turn.
3. _
    * Name: skip_next_turn
    * Type: functional
    * Summary: A card played rule where The following user in the turn order skips their turn.
4. _
    * Name: leap_to_next_player
    * Type: functional
    * Summary: A card played rule where The next two players in turn order skip their turn
5. _
    * Name: leap_to_next_player
    * Type: functional
    * Summary: A card played rule where The next two players in turn order skip their turn
6. _
    * Name: leap_to_next_player
    * Type: functional
    * Summary: A card played rule where The next two players in turn order skip their turn. Play resumes on the third user in turn order.
7. _
    * Name: type_phrase_password
    * Type: functional
    * Summary: The user that plays a specific card (secret assignment) has to type the phrase 'password' in chat to enable the game to go forward.
8. _
    * Name: discard_one_card
    * Type: functional
    * Summary: The user that plays a specific card must discard one of their cards of their choosing onto the pile.
9. _
    * Name: swap_hands
    * Type: functional
    * Summary: The user that plays a specific card must swap hands with a player of their choosing
10. _
    * Name: draw_new_hand
    * Type: functional
    * Summary: The user that plays a specific card must discard all of their cards onto the draw pile. Shuffle the deck and draw a new set of the same number of cards discarded.