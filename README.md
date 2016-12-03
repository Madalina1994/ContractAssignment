# Code interpretation

The code is in the Account class from the ContractAssignment2 project. In the Deposit method, the balance is increased and in the Withdraw method the balance is decreased.
The Main method catches any exception thrown by passing to the Withdraw method parameters that don't comply to the contract. Initially the balance is 40, then by calling the Deposit method it is increased by 20, then it tries to withdraw 80, but because the contract states that the balance should be greater than the withdrwan amount, the balance stays unchanged. Finally, it withdrwas 5.
