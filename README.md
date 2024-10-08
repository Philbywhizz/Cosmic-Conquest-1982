# Cosmic Conquest 1982

This is a fork of Original project from [RickCarlino here](https://github.com/RickCarlino/Cosmic-Conquest-1982).

A copy of it is still in local [Original](./Original/) directory too. See [Original README](./Original/README.md) for details.

# Forked version 
```
        ___   _  _  _   
__   __/ _ \ / || || |  
\ \ / / | | || || || |_ 
 \ V /| |_| || ||__   _|
  \_/  \___(_)_(_) |_|  
                        
```

From now v0.1.3 - this diverge & becomes more modern & less retro compatible.

This will also become specific to gforth 0.7.x, more or less. And curently to linux compatible shells (android/macOSX/Linux) 

![2.png](./gamedata/2.png)

# Why forking ?

Project seems abandoned since about 2 years now. Forked on Wed Jun 21

- [ ] Modernize all the code & remove some useless words that are no more needed here
- [ ] Will try to do some improvement too
- [X] Add Makefile for latter usage (run/test/install/etc...)
- [X] Change score management/calculations
- [X] Code documentation is currently so bad...
- [X] Games is not starting automatically on load 
- [X] Key map is not pleasant to me 
- [X] Missing LICENSE file as there was originally no file the [unlicensed](./LICENSE) is the one to use.
- [X] Missing a quit in game to go back to system 
- [X] Modernize random sequences
- [X] No gforth version checking 
- [X] There are no colors 
- [X] There are no score file generated
- [X] Why is there 2 key press needed on start 
- [X] Will include original magazine notes too 

![1.png](./gamedata/1.png)

# References

[Full instructions are available in the original magazine article.](https://archive.org/details/byte-magazine-1982-12/page/n125/mode/2up)

This is a re-creation of a [real-time strategy game published in BYTE Magazine in 1982](https://archive.org/details/byte-magazine-1982-12/page/n131/mode/1up?q=cosmic+conquest). The original version of the game was distributed in printed form for users to manually type into their Apple II computers. It is credited as one of the first real-time strategy computer games. The game was authored in a flavor of FIGForth for the Apple II, possibly FIGForth '78. The exact platform is unknown at this time.

Attempts at emulation have not gone well because we cannot determine the exact Forth version originally used. The source code has been updated to run on a modern Forth system (GForth).

# Contents of This Repo

 * `Original` - repo as is before forking it
 * `cosmic_conquest_modern.fs` - "40Th Anniversary Edition". A modernized version of the game, playable on GForth.
 * `modernize.fs` - also comes from fork

# How to Run - TO BE CHANGED

1. Install [GForth](https://gforth.org/). Nearly any version will work and it is verified to work on GForth >= 0.7.3
1. Run the source code via `gforth cosmic_conquest_modern.fs`.
1. Once GForth is running, type `CONQUEST` to start the game.

# How To Play - TO BE CHANGED

**COMMANDS ARE CASE SENSITIVE.** In the original Apple II, this did not matter. On modern systems, it does. Keep that in mind as you enter commands.

When you open the game, you will be prompted to press "any key" twice. This is used for generation of a random seed and will affect the structure of the game's universe.

Just run 
```
./go.sh
``` 

[VIDEO](https://www.youtube.com/watch?v=btgiQU_NxUk) _in french so use youtube translator if needed_

Key controls:

 * `J`, `L`, `I`, `k` - Directional controls - J to left / K to down / I to up / L to right
 * `T` - **T**ax your planets
 * `G` - **L**and on a planet - Ground
 * `R` - **I**nformation - Radar
 * `F` - **F**ire / attack enemy
 * `C` - Switch to **O**ther fleet - Change 

[Full instructions are available in the original magazine article.](https://archive.org/details/byte-magazine-1982-12/page/n125/mode/2up)

# Contributors on forked version 

Special thanks goes to the folks who made this restoration possible:

 * Alan Sartori-Angus - Original author of the game in 1982.
 * [Gordon JC Pearce](https://github.com/gordonjcp) - Ported the historic 1982 source code to GForth.
 * [tmr4](https://github.com/tmr4) - Data entry of original sources.
 * [Rick Carlino](https://github.com/RickCarlino/) - Documentation, proofing, data entry.

# play it from container 

you can adapt the Makefile to your own needs/environnements but keep in mind the minimum steps below 

```
make Dockerfile
make container
make runcontainer
make clean
```

If you already built the container just run it from docker 

```
docker run -it cosmic_conquest:latest
```

you can play directly from shell with 

```
make run
```


