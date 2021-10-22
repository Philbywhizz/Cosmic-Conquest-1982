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
\   <BUILDS DUP C, * ALLOT DOES>
   create dup c, * allot does> ( fixed for gforth)
   ROT 1 - OVER C@ * + + ;

( arrays)

SIZE SIZE ARRAY GALAXY ( the galactic array)
SIZE SIZE ARRAY INFO1  ( planetary array)
SIZE SIZE ARRAY INFO2  ( strength array)
2 6 ARRAY FLEETS       ( player's flets info)

: ?pairs - 1 throw ; ( FIXME throw an error if the case statement doesn't match) 
: vhtab drop drop cr ." FIXME should actually move cursor on screen" ;

( general utility words)
: DELAY                      ( delay a fixed amount of time)
   5000 0 DO LOOP ;

: CLEAR-MSGE                 ( clear message area on text screen)
   18 10 DO
           I 0 VHTAB 35 SPACES
         LOOP ;

: XY@
   X @ Y @ ;

: h1 cr ." FIXME should select hires mode" ;
: hclr cr ." FIXME should clear screen" ;
24 40 array screen
: home cr ." FIXME should return cursor to home position" ;

: initialise ." FIXME real code in article" ;
: restart ." FIXME real code in article" ;

: CLEAR-SCREEN ( clear hires screen 1)
   H1 HCLR ;

: CLEAR-DISP ( fill screen array with FF's)
   1 1 SCREEN 121 255 FILL ;

: CLEAR-GALAXY ( fills galactic array with NULLs)
   1 1 GALAXY SIZE SIZE * 0 FILL ;

: CLEAR-INFO ( fills info array with NULLs)
   1 1 INFO1 SIZE SIZE * 0 FILL
   1 1 INFO2 SIZE SIZE * 0 FILL ;

: RANDOM1 ( --- ran ) ( random number in range 1-SIZE)
   RAND1 @ 37 * 651 + DUP RAND1 ! ABS SIZE MOD 1+ ;

: RANDOM2 ( --- ran ) ( random number in range 1-SIZE)
   RAND2 @ 53 * 773 + DUP RAND2 ! ABS SIZE MOD 1+ ;

: EDGE-CHECK ( n --- ng ) ( calculates wrap around of galaxy)
   SIZE 1 - + SIZE MOD 1+ ;

: INPUT ( --- n1) ( number input routine)
   0 BEGIN ( start with zero total)
     KEY DUP EMIT DUP 8 = ( is it backspace?)
     IF
       DROP 10 / 0 ( get rid of last digit)
     ELSE
       DUP 57 > ( check if char is digit)
       IF DROP 1
       ELSE DUP 48 <
         IF DROP 1
         ELSE 48 - SWAP 10 * + 0
         ENDIF
       ENDIF
     ENDIF
   UNTIL ;

: F ( n1 --- add1) ( ( indexes current fleet array)
   FLEET-FLAG @ SWAP FLEETS ;

\ bottom of page 130

: CONQUEST ( the main game word)
   HOME ." HIT ANY KEY" KEY RAND1 ! CR ( random number seed)
        ." AND AGAIN  " KEY RAND2 ! CR ( random number seed)
   HOME CR CR CR
   ." WELCOME TO COSMIC CONQUEST" CR CR
   ." DEVISED AND WRITTEN BY" CR CR
   ." ALAN SARTORI-ANGUS"
   INITIALISE
   RESTART ;
 
