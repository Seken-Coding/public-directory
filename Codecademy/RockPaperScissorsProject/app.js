const getUserChoice = (userInput) => {
    userInput = userInput.toLowerCase();
    if(userInput === "rock" || userInput === "paper" || userInput === "scissors" || userInput === "bomb"){
      return userInput;
    }
    else{
      console.log("Error not a valid input!")
    }
  }
  
  const getComputerChoice = () =>{
    const computerChoice = Math.floor(Math.random() * 3)
  
    switch(true){
      case computerChoice === 0:
        return "rock"
      break;
      case computerChoice === 1:
        return "paper"
      break;
      case computerChoice === 2:
        return "scissors"
      break;
    }
  }
  
  const determineWinner = (userChoice,computerChoice) =>{
    if(userChoice === computerChoice){
      return "The game is a tie!"
    }
    if(userChoice === "bomb"){
      return "You won with a bomb!"
    }
    if(userChoice === "rock"){
      if(computerChoice === "paper"){
        return "You picked rock | The computer picked paper. You Lost!";
      }else{
        return "You picked rock | The computer picked scissors. You Won!";
      }
    }
    if(userChoice === "paper"){
      if(computerChoice === "rock"){
        return "You picked paper | The computer picked rock. You Won!";
      }else{
        return "You picked paper | The computer picked scissors. You Lost!";
      }
    }
    if(userChoice === "scissors"){
      if(computerChoice === "paper"){
        return "You picked scissors | The computer picked rock. You Lost!";
      }else{
        return "You picked scissors | The computer picked paper. You Won!";
      }
    }
  }
  
  function playGame(){
    const userChoice = getUserChoice("rock");
    const computerChoice = getComputerChoice();
  
    
    console.log(determineWinner(userChoice,computerChoice))
  }
  
  playGame()