\ NOTE: This work is not complete. I am typing out the code listing as my schedule allows.

( constants)
30 CONSTANT SIZE                    ( the size of the galactic array)
SIZE 2 * CONSTANT NO-OF-STARS       ( no. of stars in the galaxy)
SIZE 3 * 2 / CONSTANT NO-OF-PLANETS ( planets in galaxy)
4 CONSTANT NO-OF-B-HOLES            ( no. of black holes)
200 CONSTANT W1                     ( weight value assigned to planets in score)
5 CONSTANT W2                       ( weight assigned to ship and troops)
10 CONSTANT W3                      ( weight assigned to computers troops)
20000 CONSTANT SPEED                ( how quickly computer moves)

( VARIABLES)
0 VARIABLE TEMP1        ( a temporary storage v ariable)
0 VARIABLE VTAX         ( tax collected)
0 VARIABLE C-LEGIONS    ( no. of computer legions for attacks)
0 VARIABLE CLASS-TOTALS ( computers planets classes totals)
0 VARIABLE C-FLEETS     ( no. of computer fleets)
0 VARIABLE LEN          ( no. of moves remaining in game)
0 VARIABLE TROOPS       ( no. of computers troops in game)
0 VARIABLE RAND1        ( first random number seed)
0 VARIABLE RAND2        ( second random number seed)
0 VARIABLE X            ( temporary storage for X position)
0 VARIABLE Y            ( temporary storage for Y position)
0 VARIABLE BUY-V        ( count to stop player buying every move)
0 VARIABLE LEG          ( the no. of legions available to buy)
0 VARIABLE NEW          ( how often new fleet created)
0 VARIABLE COMP-START   ( how quickly computer plays)
0 VARIABLE COMPUTER     ( how quickly computer plays)
0 VARIABLE DIFF         ( difficulty of game 1-4)
0 VARIABLE C-PLANETS    ( no. of computer planets)
0 VARIABLE PLANETS      ( no. of players planets)
0 VARIABLE FLEET-FLAG   ( no. of players current fleet)
250 VARIABLE CREDIT     ( players credit in taxes)
0 VARIABLE START        ( starting score in the game)

( DEFINING WORDS)
: ARRAY ( 2D Array)
   <BUILDS DUP C, * ALLOT DOES>
   ROT 1 - OVER C@ * + + ;

: ENDCASE
   4 ?PAIRS COMPILE DROP BEGIN SP@ CSP @ = 0= WHILE 2
   <<COMPILE>> ENDIF REPEAT CSP ! ; IMMEDIATE

( general utility words)
: DELAY                      ( delay a fixed amount of time)
   5000 0 DO LOOP ;

: CLEAR-MSGE                 ( clear message area on text screen)
   18 10 DO
           I 0 VHTAB 35 SPACES
         LOOP ;

: XY@
   X @ Y @ ;

: CLEAR-SCREEN ( clear hires screen 1)
   H1 HCLR ;

\ STOPPED AT PAGE 130 (page 132 on paper) ====
