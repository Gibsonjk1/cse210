using System.Security.Cryptography.X509Certificates;

public class Character
{
    private static List<string> _levels = [
    "Level 1 - Baby Slime",
    "Level 2 - Clueless Kobold",
    "Level 3 - Mischievous Imp",
    "Level 4 - Overly Confident Griffin Chick",
    "Level 5 - Sassy Sphinx Apprentice",
    "Level 6 - Werewolf in Training",
    "Level 7 - Slightly Singed Phoenix",
    "Level 8 - Sneaky Shadow Dragon",
    "Level 9 - Elder Kraken of Chaos",
    "Level 10 - Almighty Cosmic Chimera"
];
    private static List<string> _characters = [
            // Level 1 - Baby Slime
            @"
    (°_°) 
     (   )  
      ~~~   
(*Wobbly, squishy, and probably harmless… probably.*)
            ",

            // Level 2 - Clueless Kobold
            @"
   ,     ,
  (o'___'o)
  {  ~~~  }
  (       )
   `-----`
(*A tiny dragon wannabe with big dreams and little firepower.*)
            ",

            // Level 3 - Mischievous Imp
            @"
   (\__/)
  (  •_•)
  <(   ''   )>
(*Small but full of chaotic energy—and questionable decisions.*)
            ",

            // Level 4 - Overly Confident Griffin Chick
            @"
    ,_
   (o,o)  
   { '' }~   
   (  ) (  )  
(*You can barely fly, but that won’t stop you from trying!*)
            ",

            // Level 5 - Sassy Sphinx Apprentice
            @"
  /\_/\
 ( o.o )  
  > ^ <
(*You’ve learned a few riddles, but your answers still confuse everyone.*)
            ",

            // Level 6 - Werewolf in Training
            @"
      ,     ,  
     ( 0_0 )  🌕  
  --(   🐾   )--  
     /  ~  \  
    (_/   \_)  
(*You howl at the moon… but only get a weird bark instead.*)
            ",

            // Level 7 - Slightly Singed Phoenix
            @"
   \ | /  
  --🔥--  
   / | \  
  ( ~~~ )  
(*You’ve risen from the ashes… with some crispy feathers.*)
            ",

            // Level 8 - Sneaky Shadow Dragon
            @"
      (  )  
     (   )  
  --<=====O  
     (   )  
      (  )  
(*People fear you, but mostly because you keep appearing behind them silently.*)
            ",

            // Level 9 - Elder Kraken of Chaos
            @"
    ~~~~~  
  (  O   O  )  
  (   \_/   )  
  --<=====>--  
(*Tentacles everywhere. No one is safe from your reach.*)
            ",

            // Level 10 - Almighty Cosmic Chimera
            @"
      /\     🦄  
     (  o.o)   
     <(  -  )> 🐍  
   ✨ ~~~~~ ✨  
(*A glorious fusion of power, wisdom, and absolute weirdness.*)
            "
    ];
    public static string GetLevel(int level)
    {
        return _levels[level];
    }

    public static string GetCharacter(int level)
    {
        return _characters[level];
    }
}