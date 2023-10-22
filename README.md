# Supper-Tic-Tac-Toe-Game

**Problem description **

An interesting variation of the classic game tic-tac-toe is known as super,
strategic, or meta tic-tac-toe. In this "upscaled" version, each tic-tac-toe
the board serves as a square in a larger tic-tac-toe board. When a player, say X,
wins a full "small" board, this player gets to play the corresponding square
in the "larger" board. Consider Figure 2a and let us refer to the large 3x3
grid as a "large" board and each of the 9 individual 3x3 grids as the "small"
boards.
In the game represented in Figure 2a, we observe that X has won three small
boards and thereby gained three X:es in the large board. The second player
(O) have, however, merely won a single of the small boards and have hence
only gained a single O in the large board

Since X has won three small boards that together constitute three-in-a-row
in the large board, X is the winner of this match.
![image](https://user-images.githubusercontent.com/1320622/164992265-0d205e89-297c-4847-926d-6a4573c20115.png)
Sometimes this game is played with a rule that dictates which small board a
player is allowed to play in as a consequence of the square in a small board
that the last player played. In this exercise we ignore such complications
and assume that players are allowed to play whatever square they want to
play so long as each square is only played once.
Your program must read input data from a match between X and O and
return information concerning how the match has played out.
All input is provided as a single command line argument. This argument is
a comma-separated (,) list of moves where players take turn to make their
moves. Assuming that X makes the first move, all odd numbered moves
belong to X while all even belong to O.
The exception from this rule is if a player tries to make an invalid move.
If this happens, we simply assume that the next move in the list of moves
belongs to the player in question since the first move was rejected. I.e., if
player X attempts and invalid move, the next move from the move-list still
belongs to player X.
A move is only ever rejected if a player tries to either (1) play a square
(in a small board) that has already been played (i.e., the square is already
occupied) or (2) if a player attempts to make a move in a small board which
already has a winner.

**Input example**
Let us consider a complete input example before moving on. An example
input string is provided in Figure 2b and a visualization based on that input
is provided in Figure 2a.
As you may have noticed, we use abbreviations to refer to different positions
on the board. The abbreviations are based on the words: north (N), west
(W), east (E), south (S), and center (C). It is perhaps best explained by
means of the visualizations in Figure 3.
![image](https://user-images.githubusercontent.com/1320622/164992333-e39a7e39-25ac-4840-bb75-4c744337a662.png)

Note that we are using the "dot-syntax" to "dig down" into smaller boards.
The coordinate NW.CC, for example, refers to the middle square ("center center") in the top left small board ("north west"). While this syntax can be
used to specify games at an arbitrary depth, we observe one and two layers
in Figures 3a and 3b respectively.
No matter how many layers we employ, players always make their moves in
the "inner-most"/"smallest" squares and the winner is always determined
using the "outermost"/"largest" squares.
Your program must be able to handle at least a depth of 2 and determine
depth on the basis of the first move. Note that the depth of all moves must
be the same. For example, we cannot have "NW.CC" and "NW.CC.SE" in the same
input argument as they represent two different depths.
Whitespace must be insignificant in the input argument. As such, the line
breaks and spaces used in Figure 2a are only added to improve readability
of this document.
**Outputs**
When given some correctly formatted input, your program must return three
lines of output, as per the following specification:
Line 1: A comma-separated (,) list of the winning "large" squares in the
order in which they were played. Given the input in Figure 2b our program
would print:
1. **NW , CW , SW**
Line 2: A comma-separated (,) list of the winning "small" squares in the
order in which they were played. In the example of Figure 2b this is fairly
straight forward as all the moves, of player one, except one are winning
moves. The output should in this case be:
2. **NW .CC , NW .NW , NW . SE , CW . CC , CW .NW , CW .SE , SW .CC , SW .NW , SW . SE**
Line 3: Two values, separated by a comma (,) where the first (i.e. left)
value denotes how many games player X has won while the second (i.e.
right) value denotes that of player O. Wins are counted at every layer and
layers are separated with dots. In the example of Figure 2b we have two
layers and should thus print two numbers per player. The first player, (X),
has won one (of one) of the "big" boards and three (of nine) of the "small"
boards. The second player, (O), has won zero (of one) "big" boards but one
(of nine) "small" boards. Consequently we should print:
3. **1.3 , 0.1**

**Requirements**
While most of the functional requirements are specified in the description,
the program must also adhere to the following requirements:
• The program must be a console (i.e. command line/terminal) application written in C#.
• The program must be fault-tolerant and gracefully notify the user in
case of syntactically invalid input, missing arguments, and other runtime errors that might occur.
• The program must contain at least 6 meaningful classes.
• The program must not contain any static classes/methods/variables
(except for the Main-method).
• The program must not use downcasting or type checking.
• The program must prefer polymorphism over conditionals.
• The program must adhere to the SOLID principles.
• The program must exhibit meaningful use of at least two design patterns. You may freely choose which design patterns to apply from the
list in Table 5. Design patterns not listed in Table 5 will not count
towards the total.
• The program must contain at least one automated test that ensures
that the input example (see Figure 2) yields the expected output
