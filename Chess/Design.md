## Main classes

---

1. **Piece** - represents a figure. Defined as an abstract class.
   - **attributes** : color, position, concrete classes also contain a list of
    possible moves

2. **Movement** - describes a move.
   - **attributes**: oldPiece, newPiece, promotion, castling
   - **methods**: IsMoveValid()

3. **Board** - represents the game board. Must be a singleton.
   - **attributes** : Collection of pieces, of movements (remembers the state)
   - **methods** : MovePiece(), IsWinner()

4. **Player** - represents a player.
   - **attributes**: timeRemaining, collection of remaining pieces + their position

5. **Manager** - a manager for each game.
   - **attributes** : Player1, Player2, Board (singleton)
   - **methods** : startGame(), endGame()
