# HoloGuess

This is a simple multiple choice quiz game made in C# and Winforms, and the first C# project I made.

## Download

Download and extract the files from `HoloGuess.zip` and run `HoloGuessForm.exe`. 

## How to Play

This is a multiple choice quiz game. The player will be presented with a random question then has to select the correct answer among four random choices. The questions and choices will reference the streamers from the streamer group hololive. You can also choose to skip to the next question. The form will keep a tally of correct, incorrect, and skipped answers.

## The Code

For every turn, the game generates a list of 4 from every possible choice, which will be the available choices for the player. Questions are simply a text and a LINQ to sort the available choices, which will be sorted based on a single property relevant to the question text. If the selected choice matches the first in the sorted list, the player will have a correct answer.

For example, if the question asks for 'the most viewed', the choices will then be sorted by their 'views'. The first would then have the most views, and if the player picks the choice that is the same as that, then they will be correct.

## Afterword

Thank you for reading. You can go to [my website](https://benhwliu.com/) to check out my other projects.

