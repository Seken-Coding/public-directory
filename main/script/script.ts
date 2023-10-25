interface Account {
    username: string,
    id: number;
}

const dataBase = {
    username: "Test",
    id: 1
};

function logIn(input:Account) {
    console.log(input.id);
    console.log(input.username);
}