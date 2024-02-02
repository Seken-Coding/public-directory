let humanScore = 0;
let computerScore = 0;
let currentRoundNumber = 1;

// Write your code below:

function checkLimit(humanGuess) {
    if(humanGuess >= 9 || humanGuess < 0){
        alert("Your number is out of Range!")
        return true
    }
}

function generateTarget(){
    return Math.floor(Math.random() * 10)
}

function compareGuesses(humanGuess,computerGuess,secretTarget) {
    let humanResult = getAbsoluteDistance(humanGuess,secretTarget);
    let compResult = getAbsoluteDistance(computerGuess,secretTarget);
    
    checkLimit(humanGuess)
    // Got replaced by seperate function!
    // checks distance for player
    // if (humanGuess > secretTarget) {
    //     humanResult = humanGuess - secretTarget
    // } else{
    //     humanResult = secretTarget - humanGuess
    // }
    // checks distance for computer
    // if (computerGuess > secretTarget) {
    //     compResult = computerGuess - secretTarget
    // } else{
    //     compResult = secretTarget - computerGuess
    // }
    
    // compares distances of guesses
    // tie
    if(humanResult === compResult){
        return true;
    }
    // win condition
    if(humanResult > compResult){
        return false;
    }else{
        return true;
    }


}

function updateScore(winner) {
    if(winner === "human"){
        humanScore++
    }
    if(winner === "computer")[
        computerScore++
    ]
}

function advanceRound() {
    currentRoundNumber++
}

function getAbsoluteDistance(num1,num2) {
    let result = 0;
    if (num1 > num2) {
        result = num1 - num2;
        return result;
    } else{
        result = num2 - num1;
        return result;
    }
}