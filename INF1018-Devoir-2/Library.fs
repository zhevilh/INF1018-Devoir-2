namespace INF1018_Devoir_2

open System
open System.Collections.Generic

(* 
Construisez un automate d'analyse lexicale pour cet alphabet
d'un langage d'arithmétique simple :

<var> := A | B | C
<int> := Séquence de chiffre représentant un entier valide
<op> := + | - | * | /

Basez votre automate sur l'approche procédurale 
basée sur les diagrammes d'états-transitions.
*)

module Lex =
    type Var = A | B | C
    type Op = Plus | Minus | Multiply | Divide
    type LexicalUnit = Var of Var | Int of int | Op of Op
    
    type IndexedString = { string: string; mutable index : int; output: List<LexicalUnit> }

    let peekChar { string = string; index = index } = 
        if index < string.Length
        then Some string.[index]
        else None

    let incIndex istring =
        istring.index <- istring.index + 1
        
    let popChar istring =
        let c = peekChar istring
        incIndex istring
        c

    let skipWhitespace istring =
        while peekChar istring = Some ' ' do incIndex istring

    // Prend une chaîne de caractère en entrée et retourne la structure
    // lexicale Assign si la chaîne en entrée est une expression du langage 
    // d'assignation valide.
    let parse string =
        failwith "Unimplemented."